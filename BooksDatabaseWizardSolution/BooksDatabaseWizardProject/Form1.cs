/*David Lockwood
 *12/7/2020
 *Accesses Books database in SQL using Data Source Configuration Wizard
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

namespace BooksDatabaseWizardProject
{
    public partial class frmTitles : Form
    {
        public frmTitles()
        {
            InitializeComponent();
        }

        private void titlesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.titlesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sQLBooksDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sQLBooksDBDataSet.Titles' table. You can move, or remove it, as needed.
            try
            {
                this.titlesTableAdapter.Fill(this.sQLBooksDBDataSet.Titles);
            }
            catch
            {
                lblError.Text = "Error: Unable to connect to database.";
            }
        }
    }
}
