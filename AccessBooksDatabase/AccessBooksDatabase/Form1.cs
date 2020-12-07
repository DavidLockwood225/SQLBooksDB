﻿/*David Lockwood
 *11/24/2020
 *Accesses Books database in SQL, add controls bound to fields in the Title database table
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace AccessBooksDatabase
{
    public partial class frmTitles : Form
    {
        SqlConnection booksConnection;
        SqlCommand titlesCommand;
        SqlDataAdapter titlesAdapter;
        DataTable titlesTable;
        public frmTitles()
        {
            InitializeComponent();
        }

        private void frmTitles_Load(object sender, EventArgs e)
        {
            booksConnection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;"
                                               + "AttachDbFilename=" + Path.GetFullPath("SQLBooksDB.mdf")
                                               + ";Integrated Security=True;"
                                               + "Connect Timeout=30;");
            booksConnection.Open();
            titlesCommand = new SqlCommand("Select * from Titles", booksConnection);
            titlesAdapter = new SqlDataAdapter();
            titlesAdapter.SelectCommand = titlesCommand;
            titlesTable = new DataTable();
            titlesAdapter.Fill(titlesTable);
            txtTitle.DataBindings.Add("Text", titlesTable, "Title");
            txtYearPublished.DataBindings.Add("Text", titlesTable, "Year_Published");
            txtISBN.DataBindings.Add("Text", titlesTable, "ISBN");
            txtPubID.DataBindings.Add("Text", titlesTable, "PubID");
            booksConnection.Close();
            booksConnection.Dispose();
            titlesCommand.Dispose();
            titlesAdapter.Dispose();
            titlesTable.Dispose();
        }
    }
}
