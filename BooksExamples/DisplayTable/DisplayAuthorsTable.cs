using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.EntityClient;

namespace DisplayTable
{
    public partial class DisplayAuthorsTable : Form
    {
        public DisplayAuthorsTable()
        {
            InitializeComponent();
        }

        private DataTable dtcontext = new DataTable();
        bool done = false;

        //Entity Framework DbContext
        private BooksExamples.BooksEntities dbcontext = new BooksExamples.BooksEntities();
        //load data from database into DataGridView
        private void DisplayAuthorsTable_Load(object sender, EventArgs e)
        {
            //load Authors table ordered by LastName then FirstName
            /*dbcontext.Authors
                .OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .Load();/**/
            //specify datasource for authorBindingSource
            authorBindingSource.DataSource = GetAuthors();

        }
        private void authorBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            //load Authors table ordered by LastName then FirstName
            /*dbcontext.Authors
                .OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .Load();/**/
            //specify datasource for authorBindingSource
            if (done)
                return;
            authorBindingSource.DataSource = GetAuthors();
        
        }

        private DataTable GetAuthors()
        {
            /*SqlConnectionStringBuilder build = new SqlConnectionStringBuilder();
            build.DataSource = "System.Data.SqlClient";
            build.IntegratedSecurity = true;
            build.InitialCatalog = "BooksEntities";

            string connectionString = build.ToString();*/

            //EntityConnectionStringBuilder entBuild = new EntityConnectionStringBuilder();
            //entBuild.Provider = "System.Data.SqlClient";
            //entBuild.ProviderConnectionString = connectionString;
            //entBuild.Metadata = @"res://*/BooksModel.csdl|res://*/BooksModel.ssdl|res://*/BooksModel.msl";

            string connectionString = ConfigurationManager.ConnectionStrings["BooksEntities"].ConnectionString;

            if (connectionString.ToLower().StartsWith("metadata="))
            {
                EntityConnectionStringBuilder entBuild = new EntityConnectionStringBuilder(connectionString);
                connectionString = entBuild.ProviderConnectionString;
            }

            using (SqlConnection connection = new SqlConnection(connectionString.ToString()))
            {
                using(SqlCommand command = new SqlCommand("SELECT * FROM Titles", connection))
                {
                    connection.Open();

                    SqlDataReader read = command.ExecuteReader();

                    dtcontext.Load(read);
                }
            }

            done = true;

            return dtcontext;
        }

        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            authorBindingSource.EndEdit();
            try
            {
                dbcontext.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                MessageBox.Show("FirstName and LastName must contain values", "Entity Validation Exception");
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            AuthorTextBox.Clear();
            TitleTextBox.Clear();
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView dvcontext = dtcontext.DefaultView;

            dvcontext.RowFilter = "LastName LIKE '%" + AuthorTextBox.Text + "%'";
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView dvcontext = dtcontext.DefaultView;

            dvcontext.RowFilter = "Title LIKE '%" + TitleTextBox.Text + "%'";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataView dvcontext = dtcontext.DefaultView;

            dvcontext.RowFilter = "Title LIKE '%" + TitleTextBox.Text + "%'";
        }

        private void DisplayAuthorsTable_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.booksDataSet.Authors);
            // TODO: This line of code loads data into the 'booksDataSet.Titles' table. You can move, or remove it, as needed.
            this.titlesTableAdapter.Fill(this.booksDataSet.Titles);

        }
    }
}
