namespace BooksDatabaseWizardProject
{
    partial class frmTitles
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label year_PublishedLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label pubIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitles));
            this.sQLBooksDBDataSet = new BooksDatabaseWizardProject.SQLBooksDBDataSet();
            this.titlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titlesTableAdapter = new BooksDatabaseWizardProject.SQLBooksDBDataSetTableAdapters.TitlesTableAdapter();
            this.tableAdapterManager = new BooksDatabaseWizardProject.SQLBooksDBDataSetTableAdapters.TableAdapterManager();
            this.titlesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.titlesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.year_PublishedTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.pubIDTextBox = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            year_PublishedLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            pubIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBooksDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingNavigator)).BeginInit();
            this.titlesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(12, 44);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title:";
            // 
            // year_PublishedLabel
            // 
            year_PublishedLabel.AutoSize = true;
            year_PublishedLabel.Location = new System.Drawing.Point(12, 70);
            year_PublishedLabel.Name = "year_PublishedLabel";
            year_PublishedLabel.Size = new System.Drawing.Size(81, 13);
            year_PublishedLabel.TabIndex = 3;
            year_PublishedLabel.Text = "Year Published:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(12, 96);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 5;
            iSBNLabel.Text = "ISBN:";
            // 
            // pubIDLabel
            // 
            pubIDLabel.AutoSize = true;
            pubIDLabel.Location = new System.Drawing.Point(12, 122);
            pubIDLabel.Name = "pubIDLabel";
            pubIDLabel.Size = new System.Drawing.Size(43, 13);
            pubIDLabel.TabIndex = 7;
            pubIDLabel.Text = "Pub ID:";
            // 
            // sQLBooksDBDataSet
            // 
            this.sQLBooksDBDataSet.DataSetName = "SQLBooksDBDataSet";
            this.sQLBooksDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titlesBindingSource
            // 
            this.titlesBindingSource.DataMember = "Titles";
            this.titlesBindingSource.DataSource = this.sQLBooksDBDataSet;
            // 
            // titlesTableAdapter
            // 
            this.titlesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TitlesTableAdapter = this.titlesTableAdapter;
            this.tableAdapterManager.UpdateOrder = BooksDatabaseWizardProject.SQLBooksDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // titlesBindingNavigator
            // 
            this.titlesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.titlesBindingNavigator.BindingSource = this.titlesBindingSource;
            this.titlesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.titlesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.titlesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.titlesBindingNavigatorSaveItem});
            this.titlesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.titlesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.titlesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.titlesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.titlesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.titlesBindingNavigator.Name = "titlesBindingNavigator";
            this.titlesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.titlesBindingNavigator.Size = new System.Drawing.Size(422, 25);
            this.titlesBindingNavigator.TabIndex = 0;
            this.titlesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // titlesBindingNavigatorSaveItem
            // 
            this.titlesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.titlesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("titlesBindingNavigatorSaveItem.Image")));
            this.titlesBindingNavigatorSaveItem.Name = "titlesBindingNavigatorSaveItem";
            this.titlesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.titlesBindingNavigatorSaveItem.Text = "Save Data";
            this.titlesBindingNavigatorSaveItem.Click += new System.EventHandler(this.titlesBindingNavigatorSaveItem_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titlesBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(99, 41);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(286, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // year_PublishedTextBox
            // 
            this.year_PublishedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titlesBindingSource, "Year_Published", true));
            this.year_PublishedTextBox.Location = new System.Drawing.Point(99, 67);
            this.year_PublishedTextBox.Name = "year_PublishedTextBox";
            this.year_PublishedTextBox.Size = new System.Drawing.Size(286, 20);
            this.year_PublishedTextBox.TabIndex = 4;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titlesBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(99, 93);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(286, 20);
            this.iSBNTextBox.TabIndex = 6;
            // 
            // pubIDTextBox
            // 
            this.pubIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titlesBindingSource, "PubID", true));
            this.pubIDTextBox.Location = new System.Drawing.Point(99, 119);
            this.pubIDTextBox.Name = "pubIDTextBox";
            this.pubIDTextBox.Size = new System.Drawing.Size(286, 20);
            this.pubIDTextBox.TabIndex = 8;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(15, 171);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 9;
            // 
            // frmTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 254);
            this.Controls.Add(this.lblError);
            this.Controls.Add(pubIDLabel);
            this.Controls.Add(this.pubIDTextBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(year_PublishedLabel);
            this.Controls.Add(this.year_PublishedTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titlesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTitles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titles Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sQLBooksDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingNavigator)).EndInit();
            this.titlesBindingNavigator.ResumeLayout(false);
            this.titlesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SQLBooksDBDataSet sQLBooksDBDataSet;
        private System.Windows.Forms.BindingSource titlesBindingSource;
        private SQLBooksDBDataSetTableAdapters.TitlesTableAdapter titlesTableAdapter;
        private SQLBooksDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator titlesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton titlesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox year_PublishedTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox pubIDTextBox;
        private System.Windows.Forms.Label lblError;
    }
}

