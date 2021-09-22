
namespace AOP.Core.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.infosMenuItem = new Wc32Api.Widgets.Buttons.WcButton();
            this.settingsMenuItem = new Wc32Api.Widgets.Buttons.WcButton();
            this.fileMenuItem = new Wc32Api.Widgets.Buttons.WcButton();
            this.lblInfoDebug = new System.Windows.Forms.Label();
            this.toggleDebug = new Wc32Api.Widgets.Buttons.WcToggleButton();
            this.wcDropdownMenuFile = new Wc32Api.Widgets.Menus.WcDropdownMenu(this.components);
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wcDropdownMenuSettings = new Wc32Api.Widgets.Menus.WcDropdownMenu(this.components);
            this.diapazonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMenu.SuspendLayout();
            this.wcDropdownMenuFile.SuspendLayout();
            this.wcDropdownMenuSettings.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelGeneral.Location = new System.Drawing.Point(0, 42);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(800, 58);
            this.panelGeneral.TabIndex = 5;
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.panelMenu.Controls.Add(this.infosMenuItem);
            this.panelMenu.Controls.Add(this.settingsMenuItem);
            this.panelMenu.Controls.Add(this.fileMenuItem);
            this.panelMenu.Controls.Add(this.lblInfoDebug);
            this.panelMenu.Controls.Add(this.toggleDebug);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(1);
            this.panelMenu.Size = new System.Drawing.Size(800, 42);
            this.panelMenu.TabIndex = 7;
            // 
            // infosMenuItem
            // 
            this.infosMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.infosMenuItem.BorderColor = System.Drawing.Color.Silver;
            this.infosMenuItem.BorderRadius = 0F;
            this.infosMenuItem.BorderSize = 0;
            this.infosMenuItem.DisableBackColor = System.Drawing.Color.DimGray;
            this.infosMenuItem.DisableBorderColor = System.Drawing.Color.Silver;
            this.infosMenuItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.infosMenuItem.FlatAppearance.BorderSize = 0;
            this.infosMenuItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.infosMenuItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.infosMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infosMenuItem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infosMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.infosMenuItem.Image = global::AOP.Properties.Resources.info_24;
            this.infosMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infosMenuItem.Location = new System.Drawing.Point(241, 1);
            this.infosMenuItem.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.infosMenuItem.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.infosMenuItem.Name = "infosMenuItem";
            this.infosMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.infosMenuItem.Size = new System.Drawing.Size(100, 40);
            this.infosMenuItem.TabIndex = 0;
            this.infosMenuItem.TabStop = false;
            this.infosMenuItem.Text = "Инфо";
            this.infosMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infosMenuItem.TextColor = System.Drawing.Color.Gainsboro;
            this.infosMenuItem.UseVisualStyleBackColor = false;
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.settingsMenuItem.BorderColor = System.Drawing.Color.Silver;
            this.settingsMenuItem.BorderRadius = 0F;
            this.settingsMenuItem.BorderSize = 0;
            this.settingsMenuItem.DisableBackColor = System.Drawing.Color.DimGray;
            this.settingsMenuItem.DisableBorderColor = System.Drawing.Color.Silver;
            this.settingsMenuItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingsMenuItem.FlatAppearance.BorderSize = 0;
            this.settingsMenuItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.settingsMenuItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.settingsMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsMenuItem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.settingsMenuItem.Image = global::AOP.Properties.Resources.settings_4_24;
            this.settingsMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsMenuItem.Location = new System.Drawing.Point(101, 1);
            this.settingsMenuItem.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.settingsMenuItem.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.settingsMenuItem.Size = new System.Drawing.Size(140, 40);
            this.settingsMenuItem.TabIndex = 0;
            this.settingsMenuItem.TabStop = false;
            this.settingsMenuItem.Text = "Настройки";
            this.settingsMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsMenuItem.TextColor = System.Drawing.Color.Gainsboro;
            this.settingsMenuItem.UseVisualStyleBackColor = false;
            this.settingsMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.fileMenuItem.BorderColor = System.Drawing.Color.Silver;
            this.fileMenuItem.BorderRadius = 0F;
            this.fileMenuItem.BorderSize = 0;
            this.fileMenuItem.DisableBackColor = System.Drawing.Color.DimGray;
            this.fileMenuItem.DisableBorderColor = System.Drawing.Color.Silver;
            this.fileMenuItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.fileMenuItem.FlatAppearance.BorderSize = 0;
            this.fileMenuItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.fileMenuItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.fileMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileMenuItem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.fileMenuItem.Image = global::AOP.Properties.Resources.folder_7_24;
            this.fileMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileMenuItem.Location = new System.Drawing.Point(1, 1);
            this.fileMenuItem.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.fileMenuItem.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.fileMenuItem.Size = new System.Drawing.Size(100, 40);
            this.fileMenuItem.TabIndex = 0;
            this.fileMenuItem.TabStop = false;
            this.fileMenuItem.Text = "Файл";
            this.fileMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fileMenuItem.TextColor = System.Drawing.Color.Gainsboro;
            this.fileMenuItem.UseVisualStyleBackColor = false;
            this.fileMenuItem.Click += new System.EventHandler(this.fileMenuItem_Click);
            // 
            // lblInfoDebug
            // 
            this.lblInfoDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoDebug.AutoSize = true;
            this.lblInfoDebug.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoDebug.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInfoDebug.Location = new System.Drawing.Point(664, 11);
            this.lblInfoDebug.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.lblInfoDebug.Name = "lblInfoDebug";
            this.lblInfoDebug.Size = new System.Drawing.Size(71, 20);
            this.lblInfoDebug.TabIndex = 0;
            this.lblInfoDebug.Text = "Отладка:";
            // 
            // toggleDebug
            // 
            this.toggleDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleDebug.AutoSize = true;
            this.toggleDebug.DisableBackColor = System.Drawing.Color.DimGray;
            this.toggleDebug.DisableToggleColor = System.Drawing.Color.Gray;
            this.toggleDebug.Location = new System.Drawing.Point(741, 10);
            this.toggleDebug.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleDebug.Name = "toggleDebug";
            this.toggleDebug.OffBackColor = System.Drawing.Color.Firebrick;
            this.toggleDebug.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleDebug.OnBackColor = System.Drawing.Color.SeaGreen;
            this.toggleDebug.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleDebug.Size = new System.Drawing.Size(45, 22);
            this.toggleDebug.TabIndex = 0;
            this.toggleDebug.TabStop = false;
            this.toggleDebug.UseVisualStyleBackColor = true;
            // 
            // wcDropdownMenuFile
            // 
            this.wcDropdownMenuFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wcDropdownMenuFile.IsMainMenu = false;
            this.wcDropdownMenuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.wcDropdownMenuFile.MenuItemHeight = 25;
            this.wcDropdownMenuFile.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.wcDropdownMenuFile.Name = "wcDropdownMenuFile";
            this.wcDropdownMenuFile.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.wcDropdownMenuFile.Size = new System.Drawing.Size(125, 30);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.exitMenuItem.Image = global::AOP.Properties.Resources.Button_Close;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(124, 26);
            this.exitMenuItem.Text = "Выход";
            // 
            // wcDropdownMenuSettings
            // 
            this.wcDropdownMenuSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wcDropdownMenuSettings.IsMainMenu = false;
            this.wcDropdownMenuSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diapazonMenuItem,
            this.toolStripSeparator1,
            this.configMenuItem});
            this.wcDropdownMenuSettings.MenuItemHeight = 25;
            this.wcDropdownMenuSettings.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.wcDropdownMenuSettings.Name = "wcDropdownMenuSettings";
            this.wcDropdownMenuSettings.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.wcDropdownMenuSettings.Size = new System.Drawing.Size(161, 62);
            // 
            // diapazonMenuItem
            // 
            this.diapazonMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diapazonMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.diapazonMenuItem.Name = "diapazonMenuItem";
            this.diapazonMenuItem.Size = new System.Drawing.Size(160, 26);
            this.diapazonMenuItem.Text = "Диапазоны";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // configMenuItem
            // 
            this.configMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.configMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.configMenuItem.Image = global::AOP.Properties.Resources.Button_Settings;
            this.configMenuItem.Name = "configMenuItem";
            this.configMenuItem.Size = new System.Drawing.Size(160, 26);
            this.configMenuItem.Text = "Настройки";
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = false;
            this.statusBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.statusBar.Location = new System.Drawing.Point(0, 424);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 26);
            this.statusBar.TabIndex = 8;
            // 
            // statusText
            // 
            this.statusText.AutoSize = false;
            this.statusText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusText.Margin = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(671, 17);
            this.statusText.Spring = true;
            // 
            // statusAuthor
            // 
            this.statusAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAuthor.ForeColor = System.Drawing.Color.Gray;
            this.statusAuthor.Margin = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.statusAuthor.Name = "statusAuthor";
            this.statusAuthor.Size = new System.Drawing.Size(114, 17);
            this.statusAuthor.Text = "WorldCount, 2021 ©";
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GeneralForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.wcDropdownMenuFile.ResumeLayout(false);
            this.wcDropdownMenuSettings.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Panel panelMenu;
        private Wc32Api.Widgets.Buttons.WcButton infosMenuItem;
        private Wc32Api.Widgets.Buttons.WcButton settingsMenuItem;
        private Wc32Api.Widgets.Buttons.WcButton fileMenuItem;
        private System.Windows.Forms.Label lblInfoDebug;
        private Wc32Api.Widgets.Buttons.WcToggleButton toggleDebug;
        private Wc32Api.Widgets.Menus.WcDropdownMenu wcDropdownMenuFile;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private Wc32Api.Widgets.Menus.WcDropdownMenu wcDropdownMenuSettings;
        private System.Windows.Forms.ToolStripMenuItem diapazonMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
    }
}

