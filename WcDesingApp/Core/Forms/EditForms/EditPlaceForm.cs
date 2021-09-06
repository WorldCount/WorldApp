using System;
using System.Windows.Forms;

namespace WcDesingApp.Core.Forms.EditForms
{
    public partial class EditPlaceForm : Form
    {
        //private Place _selectPlace;

        //public Place Place => _selectPlace;

        public EditPlaceForm()
        {
            InitializeComponent();
            Text = $"Изменение участка";
        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {
        }

        private void ConnectForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
