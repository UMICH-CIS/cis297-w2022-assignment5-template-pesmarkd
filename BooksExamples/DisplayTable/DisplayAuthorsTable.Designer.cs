namespace DisplayTable
{
    partial class DisplayAuthorsTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayAuthorsTable));
            this.authorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.authorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.Reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.AuthorTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.TitleTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.Search = new System.Windows.Forms.ToolStripButton();
            this.authorDataGridView = new System.Windows.Forms.DataGridView();
            this.booksDataSet = new DisplayTable.BooksDataSet();
            this.titlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titlesTableAdapter = new DisplayTable.BooksDataSetTableAdapters.TitlesTableAdapter();
            this.tableAdapterManager = new DisplayTable.BooksDataSetTableAdapters.TableAdapterManager();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new DisplayTable.BooksDataSetTableAdapters.AuthorsTableAdapter();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyrightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingNavigator)).BeginInit();
            this.authorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // authorBindingNavigator
            // 
            this.authorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.authorBindingNavigator.BindingSource = this.authorBindingSource;
            this.authorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.authorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.authorBindingNavigator.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.authorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.authorBindingNavigatorSaveItem,
            this.Reset,
            this.toolStripLabel1,
            this.AuthorTextBox,
            this.toolStripLabel2,
            this.TitleTextBox,
            this.Search});
            this.authorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.authorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.authorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.authorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.authorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.authorBindingNavigator.Name = "authorBindingNavigator";
            this.authorBindingNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.authorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.authorBindingNavigator.Size = new System.Drawing.Size(870, 43);
            this.authorBindingNavigator.TabIndex = 0;
            this.authorBindingNavigator.Text = "bindingNavigator1";
            this.authorBindingNavigator.RefreshItems += new System.EventHandler(this.authorBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(BooksExamples.Title);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 40);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(24, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // authorBindingNavigatorSaveItem
            // 
            this.authorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.authorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("authorBindingNavigatorSaveItem.Image")));
            this.authorBindingNavigatorSaveItem.Name = "authorBindingNavigatorSaveItem";
            this.authorBindingNavigatorSaveItem.Size = new System.Drawing.Size(40, 40);
            this.authorBindingNavigatorSaveItem.Text = "Save Data";
            this.authorBindingNavigatorSaveItem.Click += new System.EventHandler(this.authorBindingNavigatorSaveItem_Click);
            // 
            // Reset
            // 
            this.Reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Reset.Image = ((System.Drawing.Image)(resources.GetObject("Reset.Image")));
            this.Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(40, 40);
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 40);
            this.toolStripLabel1.Text = "Author";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(100, 43);
            this.AuthorTextBox.TextChanged += new System.EventHandler(this.AuthorTextBox_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(29, 40);
            this.toolStripLabel2.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 43);
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // Search
            // 
            this.Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(40, 40);
            this.Search.Text = "toolStripButton1";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // authorDataGridView
            // 
            this.authorDataGridView.AutoGenerateColumns = false;
            this.authorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.editionNumberDataGridViewTextBoxColumn,
            this.copyrightDataGridViewTextBoxColumn});
            this.authorDataGridView.DataSource = this.titlesBindingSource;
            this.authorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorDataGridView.Location = new System.Drawing.Point(0, 43);
            this.authorDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.authorDataGridView.Name = "authorDataGridView";
            this.authorDataGridView.RowTemplate.Height = 37;
            this.authorDataGridView.Size = new System.Drawing.Size(870, 280);
            this.authorDataGridView.TabIndex = 1;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titlesBindingSource
            // 
            this.titlesBindingSource.DataMember = "Titles";
            this.titlesBindingSource.DataSource = this.booksDataSet;
            // 
            // titlesTableAdapter
            // 
            this.titlesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = this.authorsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TitlesTableAdapter = this.titlesTableAdapter;
            this.tableAdapterManager.UpdateOrder = DisplayTable.BooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.booksDataSet;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // editionNumberDataGridViewTextBoxColumn
            // 
            this.editionNumberDataGridViewTextBoxColumn.DataPropertyName = "EditionNumber";
            this.editionNumberDataGridViewTextBoxColumn.HeaderText = "EditionNumber";
            this.editionNumberDataGridViewTextBoxColumn.Name = "editionNumberDataGridViewTextBoxColumn";
            // 
            // copyrightDataGridViewTextBoxColumn
            // 
            this.copyrightDataGridViewTextBoxColumn.DataPropertyName = "Copyright";
            this.copyrightDataGridViewTextBoxColumn.HeaderText = "Copyright";
            this.copyrightDataGridViewTextBoxColumn.Name = "copyrightDataGridViewTextBoxColumn";
            // 
            // DisplayAuthorsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 323);
            this.Controls.Add(this.authorDataGridView);
            this.Controls.Add(this.authorBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "DisplayAuthorsTable";
            this.Text = "Display Authors Table";
            this.Load += new System.EventHandler(this.DisplayAuthorsTable_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingNavigator)).EndInit();
            this.authorBindingNavigator.ResumeLayout(false);
            this.authorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource authorBindingSource;
        private System.Windows.Forms.BindingNavigator authorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton authorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView authorDataGridView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton Reset;
        private System.Windows.Forms.ToolStripTextBox AuthorTextBox;
        private System.Windows.Forms.ToolStripTextBox TitleTextBox;
        private System.Windows.Forms.ToolStripButton Search;
        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource titlesBindingSource;
        private BooksDataSetTableAdapters.TitlesTableAdapter titlesTableAdapter;
        private BooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BooksDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copyrightDataGridViewTextBoxColumn;
    }
}

