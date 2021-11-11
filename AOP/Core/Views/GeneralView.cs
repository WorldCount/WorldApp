using System.Windows.Forms;
using AOP.Core.Forms;

namespace AOP.Core.Views
{
    public class GeneralView
    {
        #region Private Fields

        private readonly GeneralForm _parent;

        #endregion

        public GeneralView(GeneralForm form)
        {
            _parent = form;

            Title = $"{Properties.Settings.Default.AppName} {Application.ProductVersion}";
        }

        #region Public Properties

        // ReSharper disable once MemberCanBePrivate.Global
        public string Title
        {
            get => _parent.Text;
            set => _parent.Text = value;
        }

        #endregion

        #region Form Positions

        // Загрузка расположения окна
        public void LoadPos()
        {
            int width = Forms.Settings.FormsPosition.Default.GeneralFormSize.Width;
            int height = Forms.Settings.FormsPosition.Default.GeneralFormSize.Height;

            if (width == 0 || height == 0)
            {
                // Первый старт
                _parent.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                _parent.WindowState = Forms.Settings.FormsPosition.Default.GeneralFormState;

                // Нам не нужно свернутое окно при запуске
                if (_parent.WindowState == FormWindowState.Minimized)
                    _parent.WindowState = FormWindowState.Normal;

                _parent.Location = Forms.Settings.FormsPosition.Default.GeneralFormLocation;
                _parent.Size = Forms.Settings.FormsPosition.Default.GeneralFormSize;
            }
        }

        // Сохранение расположения окна
        public void SavePos()
        {
            Forms.Settings.FormsPosition.Default.GeneralFormState = _parent.WindowState;

            if (_parent.WindowState == FormWindowState.Normal)
            {
                Forms.Settings.FormsPosition.Default.GeneralFormLocation = _parent.Location;
                Forms.Settings.FormsPosition.Default.GeneralFormSize = _parent.Size;
            }
            else
            {
                // Если форма свернута или развернута
                Forms.Settings.FormsPosition.Default.GeneralFormLocation = _parent.RestoreBounds.Location;
                Forms.Settings.FormsPosition.Default.GeneralFormSize = _parent.RestoreBounds.Size;
            }

            Forms.Settings.FormsPosition.Default.Save();
        }

        #endregion

        #region Form Settings

        // Перенос настроек предыдущей сборки в новую
        public void UpgradeSettings()
        {
            Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.NeedUpgrade = false;
            Properties.Settings.Default.Save();
        }

        // Загрузка настроек
        public void LoadSettings()
        {

        }

        // Сохранение настроек
        public void SaveSettings()
        {

        }
        #endregion
    }
}
