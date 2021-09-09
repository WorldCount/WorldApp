using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DwUtils.Core.Database;
using DwUtils.Core.Database.Models;

namespace DwUtils.Core.Forms.EditForms
{
    public partial class EditPlaceForm : Form
    {

        #region Private Fields

        private Place _selectPlace;
        private Db _database;

        #endregion

        public EditPlaceForm(Db database)
        {
            InitializeComponent();

            _database = database;
            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Изменение участка";
        }


        #region Public Properties

        public Place Place => _selectPlace;

        #endregion

        #region Form Events

        private void form_Load(object sender, EventArgs e)
        {
            List<Place> places = _database.GetPlaces();
            placeBindingSource.DataSource = places;
            _selectPlace = (Place)cbPlace.SelectedItem;
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }

        #endregion

        #region Button Events

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

        #endregion

        #region Other Events

        private void cbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectPlace = (Place) cbPlace.SelectedItem;
        }

        #endregion

    }
}
