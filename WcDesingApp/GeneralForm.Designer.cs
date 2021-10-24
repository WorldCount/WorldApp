
using Wc32Api.Widgets.Buttons;

namespace WcDesingApp
{
    partial class GeneralForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            WcDesingApp.Core.Widgets.Menu.DefaultMainMenuColor defaultMainMenuColor1 = new WcDesingApp.Core.Widgets.Menu.DefaultMainMenuColor();
            WcDesingApp.Core.Widgets.Menu.DefaultMenuColor defaultMenuColor1 = new WcDesingApp.Core.Widgets.Menu.DefaultMenuColor();
            WcDesingApp.Core.Widgets.Menu.DefaultMainMenuColor defaultMainMenuColor2 = new WcDesingApp.Core.Widgets.Menu.DefaultMainMenuColor();
            WcDesingApp.Core.Widgets.Menu.DefaultMenuColor defaultMenuColor2 = new WcDesingApp.Core.Widgets.Menu.DefaultMenuColor();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelButtonTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.panelWork = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.wcDropdownMenuFile = new WcDesingApp.Core.Widgets.Menu.WcDropdownMenu(this.components);
            this.wcDropdownMenuSettings = new WcDesingApp.Core.Widgets.Menu.WcDropdownMenu(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.infosMenuItem = new Wc32Api.Widgets.Buttons.WcButton();
            this.settingsMenuItem = new Wc32Api.Widgets.Buttons.WcButton();
            this.fileMenuItem = new Wc32Api.Widgets.Buttons.WcButton();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.btnClose = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnMaximize = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnMinimize = new Wc32Api.Widgets.Buttons.WcButton();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectPostUnitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectPostItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTitleBar.SuspendLayout();
            this.panelButtonTitle.SuspendLayout();
            this.panelWork.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.wcDropdownMenuFile.SuspendLayout();
            this.wcDropdownMenuSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelTitleBar.Controls.Add(this.iconPicture);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.panelButtonTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(847, 34);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(43, 8);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(75, 18);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "WcForm";
            this.labelTitle.DoubleClick += new System.EventHandler(this.labelTitle_DoubleClick);
            // 
            // panelButtonTitle
            // 
            this.panelButtonTitle.Controls.Add(this.btnClose);
            this.panelButtonTitle.Controls.Add(this.btnMaximize);
            this.panelButtonTitle.Controls.Add(this.btnMinimize);
            this.panelButtonTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtonTitle.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtonTitle.Location = new System.Drawing.Point(754, 0);
            this.panelButtonTitle.Name = "panelButtonTitle";
            this.panelButtonTitle.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panelButtonTitle.Size = new System.Drawing.Size(93, 34);
            this.panelButtonTitle.TabIndex = 0;
            // 
            // panelWork
            // 
            this.panelWork.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelWork.Controls.Add(this.panelMenu);
            this.panelWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWork.Location = new System.Drawing.Point(0, 34);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(847, 474);
            this.panelWork.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.panelMenu.Controls.Add(this.infosMenuItem);
            this.panelMenu.Controls.Add(this.settingsMenuItem);
            this.panelMenu.Controls.Add(this.fileMenuItem);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(847, 42);
            this.panelMenu.TabIndex = 0;
            // 
            // wcDropdownMenuFile
            // 
            this.wcDropdownMenuFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wcDropdownMenuFile.IsMainMenu = false;
            this.wcDropdownMenuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            defaultMainMenuColor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            defaultMainMenuColor1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            defaultMainMenuColor1.LeftColumnColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.wcDropdownMenuFile.MainMenuColor = defaultMainMenuColor1;
            defaultMenuColor1.BackColor = System.Drawing.Color.White;
            defaultMenuColor1.BorderColor = System.Drawing.Color.LightGray;
            defaultMenuColor1.LeftColumnColor = System.Drawing.Color.LightGray;
            this.wcDropdownMenuFile.MenuColor = defaultMenuColor1;
            this.wcDropdownMenuFile.MenuItemHeight = 25;
            this.wcDropdownMenuFile.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.wcDropdownMenuFile.Name = "wcDropdownMenuFile";
            this.wcDropdownMenuFile.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.wcDropdownMenuFile.Size = new System.Drawing.Size(124, 28);
            // 
            // wcDropdownMenuSettings
            // 
            this.wcDropdownMenuSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wcDropdownMenuSettings.IsMainMenu = false;
            this.wcDropdownMenuSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectPostUnitMenuItem,
            this.connectPostItemMenuItem,
            this.toolStripSeparator1,
            this.configMenuItem});
            defaultMainMenuColor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            defaultMainMenuColor2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            defaultMainMenuColor2.LeftColumnColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.wcDropdownMenuSettings.MainMenuColor = defaultMainMenuColor2;
            defaultMenuColor2.BackColor = System.Drawing.Color.White;
            defaultMenuColor2.BorderColor = System.Drawing.Color.LightGray;
            defaultMenuColor2.LeftColumnColor = System.Drawing.Color.LightGray;
            this.wcDropdownMenuSettings.MenuColor = defaultMenuColor2;
            this.wcDropdownMenuSettings.MenuItemHeight = 25;
            this.wcDropdownMenuSettings.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.wcDropdownMenuSettings.Name = "wcDropdownMenuSettings";
            this.wcDropdownMenuSettings.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.wcDropdownMenuSettings.Size = new System.Drawing.Size(258, 88);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
            // 
            // infosMenuItem
            // 
            this.infosMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.infosMenuItem.BorderColor = System.Drawing.Color.Silver;
            this.infosMenuItem.BorderRadius = 0F;
            this.infosMenuItem.BorderSize = 0;
            this.infosMenuItem.DisableBackColor = System.Drawing.Color.DimGray;
            this.infosMenuItem.DisableBorderColor = System.Drawing.Color.Silver;
            this.infosMenuItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.infosMenuItem.FlatAppearance.BorderSize = 0;
            this.infosMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infosMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.infosMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.infosMenuItem.Image = global::WcDesingApp.Properties.Resources.info_24;
            this.infosMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infosMenuItem.Location = new System.Drawing.Point(234, 0);
            this.infosMenuItem.MouseDownBackColor = System.Drawing.Color.Empty;
            this.infosMenuItem.MouseOverBackColor = System.Drawing.Color.Empty;
            this.infosMenuItem.Name = "infosMenuItem";
            this.infosMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.infosMenuItem.Size = new System.Drawing.Size(96, 42);
            this.infosMenuItem.TabIndex = 3;
            this.infosMenuItem.Text = "Инфо";
            this.infosMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infosMenuItem.TextColor = System.Drawing.Color.Gainsboro;
            this.infosMenuItem.UseVisualStyleBackColor = false;
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.settingsMenuItem.BorderColor = System.Drawing.Color.Silver;
            this.settingsMenuItem.BorderRadius = 0F;
            this.settingsMenuItem.BorderSize = 0;
            this.settingsMenuItem.DisableBackColor = System.Drawing.Color.DimGray;
            this.settingsMenuItem.DisableBorderColor = System.Drawing.Color.Silver;
            this.settingsMenuItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingsMenuItem.FlatAppearance.BorderSize = 0;
            this.settingsMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.settingsMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.settingsMenuItem.Image = global::WcDesingApp.Properties.Resources.settings_4_24;
            this.settingsMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsMenuItem.Location = new System.Drawing.Point(96, 0);
            this.settingsMenuItem.MouseDownBackColor = System.Drawing.Color.Empty;
            this.settingsMenuItem.MouseOverBackColor = System.Drawing.Color.Empty;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.settingsMenuItem.Size = new System.Drawing.Size(138, 42);
            this.settingsMenuItem.TabIndex = 2;
            this.settingsMenuItem.Text = "Настройки";
            this.settingsMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsMenuItem.TextColor = System.Drawing.Color.Gainsboro;
            this.settingsMenuItem.UseVisualStyleBackColor = false;
            this.settingsMenuItem.Click += new System.EventHandler(this.wcButton1_Click);
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.fileMenuItem.BorderColor = System.Drawing.Color.Silver;
            this.fileMenuItem.BorderRadius = 0F;
            this.fileMenuItem.BorderSize = 0;
            this.fileMenuItem.DisableBackColor = System.Drawing.Color.DimGray;
            this.fileMenuItem.DisableBorderColor = System.Drawing.Color.Silver;
            this.fileMenuItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.fileMenuItem.FlatAppearance.BorderSize = 0;
            this.fileMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.fileMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.fileMenuItem.Image = global::WcDesingApp.Properties.Resources.folder_7_24;
            this.fileMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileMenuItem.Location = new System.Drawing.Point(0, 0);
            this.fileMenuItem.MouseDownBackColor = System.Drawing.Color.Empty;
            this.fileMenuItem.MouseOverBackColor = System.Drawing.Color.Empty;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.fileMenuItem.Size = new System.Drawing.Size(96, 42);
            this.fileMenuItem.TabIndex = 1;
            this.fileMenuItem.Text = "Файл";
            this.fileMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fileMenuItem.TextColor = System.Drawing.Color.Gainsboro;
            this.fileMenuItem.UseVisualStyleBackColor = false;
            this.fileMenuItem.Click += new System.EventHandler(this.fileMenuItem_Click);
            // 
            // iconPicture
            // 
            this.iconPicture.Image = global::WcDesingApp.Properties.Resources.web_hi_res_5121;
            this.iconPicture.Location = new System.Drawing.Point(6, 3);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(28, 28);
            this.iconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPicture.TabIndex = 3;
            this.iconPicture.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.BorderRadius = 3F;
            this.btnClose.BorderSize = 0;
            this.btnClose.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnClose.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::WcDesingApp.Properties.Resources.x_mark_16;
            this.btnClose.Location = new System.Drawing.Point(62, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(1, 2, 0, 2);
            this.btnClose.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnClose.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMaximize.BorderColor = System.Drawing.Color.Silver;
            this.btnMaximize.BorderRadius = 3F;
            this.btnMaximize.BorderSize = 0;
            this.btnMaximize.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnMaximize.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = global::WcDesingApp.Properties.Resources.expand_16;
            this.btnMaximize.Location = new System.Drawing.Point(33, 2);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(1, 2, 0, 2);
            this.btnMaximize.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnMaximize.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMaximize.Size = new System.Drawing.Size(28, 28);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TextColor = System.Drawing.Color.White;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMinimize.BorderColor = System.Drawing.Color.Silver;
            this.btnMinimize.BorderRadius = 3F;
            this.btnMinimize.BorderSize = 0;
            this.btnMinimize.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnMinimize.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::WcDesingApp.Properties.Resources.minus_2_16;
            this.btnMinimize.Location = new System.Drawing.Point(4, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(1, 2, 0, 2);
            this.btnMinimize.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnMinimize.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.btnMinimize.Size = new System.Drawing.Size(28, 28);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TextColor = System.Drawing.Color.White;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitMenuItem.Image = global::WcDesingApp.Properties.Resources.Button_Close;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(123, 24);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // connectPostUnitMenuItem
            // 
            this.connectPostUnitMenuItem.Image = global::WcDesingApp.Properties.Resources.Server;
            this.connectPostUnitMenuItem.Name = "connectPostUnitMenuItem";
            this.connectPostUnitMenuItem.Size = new System.Drawing.Size(257, 26);
            this.connectPostUnitMenuItem.Text = "Подключение к PostUnit";
            // 
            // connectPostItemMenuItem
            // 
            this.connectPostItemMenuItem.Image = global::WcDesingApp.Properties.Resources.Server;
            this.connectPostItemMenuItem.Name = "connectPostItemMenuItem";
            this.connectPostItemMenuItem.Size = new System.Drawing.Size(257, 26);
            this.connectPostItemMenuItem.Text = "Подключение к PostItem";
            // 
            // configMenuItem
            // 
            this.configMenuItem.Image = global::WcDesingApp.Properties.Resources.Button_Settings;
            this.configMenuItem.Name = "configMenuItem";
            this.configMenuItem.Size = new System.Drawing.Size(257, 26);
            this.configMenuItem.Text = "Настройки";
            // 
            // GeneralForm
            // 
            this.ClientSize = new System.Drawing.Size(847, 508);
            this.Controls.Add(this.panelWork);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "GeneralForm";
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.Resize += new System.EventHandler(this.GeneralForm_Resize);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelButtonTitle.ResumeLayout(false);
            this.panelWork.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.wcDropdownMenuFile.ResumeLayout(false);
            this.wcDropdownMenuSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox iconPicture;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel panelButtonTitle;
        private System.Windows.Forms.Panel panelWork;
        private System.Windows.Forms.Panel panelMenu;
        private WcButton fileMenuItem;
        private WcButton infosMenuItem;
        private WcButton settingsMenuItem;
        private WcButton btnClose;
        private WcButton btnMaximize;
        private WcButton btnMinimize;
        private Core.Widgets.Menu.WcDropdownMenu wcDropdownMenuFile;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private Core.Widgets.Menu.WcDropdownMenu wcDropdownMenuSettings;
        private System.Windows.Forms.ToolStripMenuItem connectPostUnitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectPostItemMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configMenuItem;
    }
}

