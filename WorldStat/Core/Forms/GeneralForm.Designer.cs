
using Wc32Api.Widgets.Buttons;
using Wc32Api.Widgets.Texts;

namespace WorldStat.Core.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFrankReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.importCalendarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mailTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailCategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mailCodeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.numericUpDownCopies = new System.Windows.Forms.NumericUpDown();
            this.lblInfoCopies = new System.Windows.Forms.Label();
            this.comboBoxPrinters = new System.Windows.Forms.ComboBox();
            this.lblInfoPrinter = new System.Windows.Forms.Label();
            this.btnPrint = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnOpenUnloadDir = new Wc32Api.Widgets.Buttons.WcButton();
            this.reportLabelInfoUnloadDir = new System.Windows.Forms.Label();
            this.reportTextBoxUnloadDir = new Wc32Api.Widgets.Texts.WcTextBox();
            this.orgToggleButtonCalendar = new Wc32Api.Widgets.Buttons.WcToggleButton();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.reportPanelStat = new System.Windows.Forms.Panel();
            this.reportLabelDaysCount = new System.Windows.Forms.Label();
            this.reportLabelInfoDays = new System.Windows.Forms.Label();
            this.reportLabelPay = new System.Windows.Forms.Label();
            this.reportLabelCount = new System.Windows.Forms.Label();
            this.reportLabelInfoPay = new System.Windows.Forms.Label();
            this.reportLabelInfoCount = new System.Windows.Forms.Label();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.reportColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportColumnDayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportColumnPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelReport = new System.Windows.Forms.FlowLayoutPanel();
            this.reportToggleButton = new Wc32Api.Widgets.Buttons.WcToggleButton();
            this.reportDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.reportDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.reportDateTimePickerCalendar = new System.Windows.Forms.DateTimePicker();
            this.reportLabelInfoTeam = new System.Windows.Forms.Label();
            this.reportComboBoxTeam = new System.Windows.Forms.ComboBox();
            this.btnLoadReports = new Wc32Api.Widgets.Buttons.WcButton();
            this.tabOrgs = new System.Windows.Forms.TabPage();
            this.orgPanelStat = new System.Windows.Forms.Panel();
            this.orgLabelPosCount = new System.Windows.Forms.Label();
            this.orgLabelInfoPosCount = new System.Windows.Forms.Label();
            this.orgLabelPay = new System.Windows.Forms.Label();
            this.orgLabelCount = new System.Windows.Forms.Label();
            this.orgLabelInfoPay = new System.Windows.Forms.Label();
            this.orgLabelInfoCount = new System.Windows.Forms.Label();
            this.orgDataGridView = new System.Windows.Forms.DataGridView();
            this.orgColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgColumnMailType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mailTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orgColumnMailCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mailCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orgColumnTransCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgColumnPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgColumnTransType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgReportPosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewDocOrg = new System.Windows.Forms.DataGridView();
            this.orgPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelOrgFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.orgLabelInfoMailType = new System.Windows.Forms.Label();
            this.orgComboBoxMailType = new System.Windows.Forms.ComboBox();
            this.orgAcitveMailTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orgLabelInfoMailCategory = new System.Windows.Forms.Label();
            this.orgComboBoxMailCategory = new System.Windows.Forms.ComboBox();
            this.orgActiveMailCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orgLabelInfoTransCategory = new System.Windows.Forms.Label();
            this.orgComboBoxTransCategory = new System.Windows.Forms.ComboBox();
            this.orgLabelInfoTransType = new System.Windows.Forms.Label();
            this.orgComboBoxTransType = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelOrgBase = new System.Windows.Forms.FlowLayoutPanel();
            this.orgDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.orgDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.orgDateTimePickerCalendar = new System.Windows.Forms.DateTimePicker();
            this.orgLabelInfoGroup = new System.Windows.Forms.Label();
            this.orgToggleButtonGroup = new Wc32Api.Widgets.Buttons.WcToggleButton();
            this.btnLoadOrgs = new Wc32Api.Widgets.Buttons.WcButton();
            this.orgComboBoxFirms = new System.Windows.Forms.ComboBox();
            this.orgFirmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabIncomes = new System.Windows.Forms.TabPage();
            this.incomePanelStat = new System.Windows.Forms.Panel();
            this.incomeLabelPosCount = new System.Windows.Forms.Label();
            this.incomeLabelInfoPosCount = new System.Windows.Forms.Label();
            this.incomeLabelPay = new System.Windows.Forms.Label();
            this.incomeLabelCount = new System.Windows.Forms.Label();
            this.incomeLabelInfoPay = new System.Windows.Forms.Label();
            this.incomeLabelInfoCount = new System.Windows.Forms.Label();
            this.incomeDataGridView = new System.Windows.Forms.DataGridView();
            this.incomeColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeColumnPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeReportPosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.incomeLabelInfoMailType = new System.Windows.Forms.Label();
            this.incomeComboBoxMailType = new System.Windows.Forms.ComboBox();
            this.incomeAcitveMailTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomeLabelInfoMailCategory = new System.Windows.Forms.Label();
            this.incomeComboBoxMailCategory = new System.Windows.Forms.ComboBox();
            this.incomeActiveMailCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomeLabelInfoTransCategory = new System.Windows.Forms.Label();
            this.incomeComboBoxTransCategory = new System.Windows.Forms.ComboBox();
            this.incomeLabelInfoTransType = new System.Windows.Forms.Label();
            this.incomeComboBoxTransType = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.incomeToggleButtonCalendar = new Wc32Api.Widgets.Buttons.WcToggleButton();
            this.incomeDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.incomeDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.incomeDateTimePickerCalendar = new System.Windows.Forms.DateTimePicker();
            this.incomeLabelInfoGroup = new System.Windows.Forms.Label();
            this.incomeToggleButtonGroup = new Wc32Api.Widgets.Buttons.WcToggleButton();
            this.btnLoadIncomes = new Wc32Api.Widgets.Buttons.WcButton();
            this.incomeComboBoxFirms = new System.Windows.Forms.ComboBox();
            this.incomeFirmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabStats = new System.Windows.Forms.TabPage();
            this.statDataGridView = new System.Windows.Forms.DataGridView();
            this.statColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statColumnPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispathReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelStat = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.statToggleButtonCalendar = new Wc32Api.Widgets.Buttons.WcToggleButton();
            this.statDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.statDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.statDateTimePickerCalendar = new System.Windows.Forms.DateTimePicker();
            this.btnLoadStat = new Wc32Api.Widgets.Buttons.WcButton();
            this.statComboBoxFirms = new System.Windows.Forms.ComboBox();
            this.statFirmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCharts = new System.Windows.Forms.TabPage();
            this.panelActive = new System.Windows.Forms.Panel();
            this.btnActiveUserLoad = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reportContextMenuUnload = new System.Windows.Forms.ToolStripMenuItem();
            this.reportContextMenuUnloadAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reportContextMenuUploadYandexDisk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopies)).BeginInit();
            this.statusBar.SuspendLayout();
            this.tabsControl.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.reportPanelStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.reportPanel.SuspendLayout();
            this.flowLayoutPanelReport.SuspendLayout();
            this.tabOrgs.SuspendLayout();
            this.orgPanelStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgReportPosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocOrg)).BeginInit();
            this.orgPanel.SuspendLayout();
            this.flowLayoutPanelOrgFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgAcitveMailTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgActiveMailCategoryBindingSource)).BeginInit();
            this.flowLayoutPanelOrgBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgFirmBindingSource)).BeginInit();
            this.tabIncomes.SuspendLayout();
            this.incomePanelStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeReportPosBindingSource)).BeginInit();
            this.incomePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeAcitveMailTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeActiveMailCategoryBindingSource)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeFirmBindingSource)).BeginInit();
            this.tabStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispathReportBindingSource)).BeginInit();
            this.panelStat.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statFirmBindingSource)).BeginInit();
            this.tabCharts.SuspendLayout();
            this.panelActive.SuspendLayout();
            this.reportContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.AutoSize = false;
            this.menuBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.dataMenuItem,
            this.settingsMenuItem,
            this.infosMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(1357, 40);
            this.menuBar.TabIndex = 2;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFrankReportMenuItem,
            this.toolStripSeparator5,
            this.importCalendarMenuItem,
            this.toolStripSeparator4,
            this.exitMenuItem});
            this.fileMenuItem.Image = global::WorldStat.Properties.Resources.File;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(85, 36);
            this.fileMenuItem.Text = " Файл";
            // 
            // loadFrankReportMenuItem
            // 
            this.loadFrankReportMenuItem.Image = global::WorldStat.Properties.Resources.File_Excel;
            this.loadFrankReportMenuItem.Name = "loadFrankReportMenuItem";
            this.loadFrankReportMenuItem.Size = new System.Drawing.Size(271, 30);
            this.loadFrankReportMenuItem.Text = "Загрузить отчет по франку";
            this.loadFrankReportMenuItem.Click += new System.EventHandler(this.loadFrankReportMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(268, 6);
            // 
            // importCalendarMenuItem
            // 
            this.importCalendarMenuItem.Image = global::WorldStat.Properties.Resources.Calendar_Day;
            this.importCalendarMenuItem.Name = "importCalendarMenuItem";
            this.importCalendarMenuItem.Size = new System.Drawing.Size(271, 30);
            this.importCalendarMenuItem.Text = "Импорт календаря";
            this.importCalendarMenuItem.Click += new System.EventHandler(this.importCalendarMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(268, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Image = global::WorldStat.Properties.Resources.Button_Close;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(271, 30);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // dataMenuItem
            // 
            this.dataMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmsMenuItem,
            this.toolStripSeparator2,
            this.mailTypeMenuItem,
            this.mailCategoryMenuItem,
            this.toolStripSeparator3,
            this.mailCodeMenuItem});
            this.dataMenuItem.Image = global::WorldStat.Properties.Resources.Cabinet;
            this.dataMenuItem.Name = "dataMenuItem";
            this.dataMenuItem.Size = new System.Drawing.Size(104, 36);
            this.dataMenuItem.Text = " Данные";
            // 
            // firmsMenuItem
            // 
            this.firmsMenuItem.Image = global::WorldStat.Properties.Resources.Man_Suit_2;
            this.firmsMenuItem.Name = "firmsMenuItem";
            this.firmsMenuItem.Size = new System.Drawing.Size(255, 30);
            this.firmsMenuItem.Text = "Организации";
            this.firmsMenuItem.Click += new System.EventHandler(this.firmsMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(252, 6);
            // 
            // mailTypeMenuItem
            // 
            this.mailTypeMenuItem.Image = global::WorldStat.Properties.Resources.Envelope_2;
            this.mailTypeMenuItem.Name = "mailTypeMenuItem";
            this.mailTypeMenuItem.Size = new System.Drawing.Size(255, 30);
            this.mailTypeMenuItem.Text = "Типы отправлений";
            this.mailTypeMenuItem.Click += new System.EventHandler(this.mailTypeMenuItem_Click);
            // 
            // mailCategoryMenuItem
            // 
            this.mailCategoryMenuItem.Image = global::WorldStat.Properties.Resources.Notebook_2;
            this.mailCategoryMenuItem.Name = "mailCategoryMenuItem";
            this.mailCategoryMenuItem.Size = new System.Drawing.Size(255, 30);
            this.mailCategoryMenuItem.Text = "Категории отправлений";
            this.mailCategoryMenuItem.Click += new System.EventHandler(this.mailCategoryMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(252, 6);
            // 
            // mailCodeMenuItem
            // 
            this.mailCodeMenuItem.Image = global::WorldStat.Properties.Resources.Calculator_2;
            this.mailCodeMenuItem.Name = "mailCodeMenuItem";
            this.mailCodeMenuItem.Size = new System.Drawing.Size(255, 30);
            this.mailCodeMenuItem.Text = "Коды отправлений";
            this.mailCodeMenuItem.Click += new System.EventHandler(this.mailCodeMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDbMenuItem});
            this.settingsMenuItem.Image = global::WorldStat.Properties.Resources.Button_Settings;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(124, 36);
            this.settingsMenuItem.Text = " Настройки";
            // 
            // createDbMenuItem
            // 
            this.createDbMenuItem.Image = global::WorldStat.Properties.Resources.Server;
            this.createDbMenuItem.Name = "createDbMenuItem";
            this.createDbMenuItem.Size = new System.Drawing.Size(213, 30);
            this.createDbMenuItem.Text = "Создать новую БД";
            this.createDbMenuItem.Click += new System.EventHandler(this.createDbMenuItem_Click);
            // 
            // infosMenuItem
            // 
            this.infosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateMenuItem});
            this.infosMenuItem.Image = global::WorldStat.Properties.Resources._4_Leaf_Clover;
            this.infosMenuItem.Name = "infosMenuItem";
            this.infosMenuItem.Size = new System.Drawing.Size(88, 36);
            this.infosMenuItem.Text = " Инфо";
            // 
            // updateMenuItem
            // 
            this.updateMenuItem.Image = global::WorldStat.Properties.Resources.Button_Dashboard;
            this.updateMenuItem.Name = "updateMenuItem";
            this.updateMenuItem.Size = new System.Drawing.Size(155, 30);
            this.updateMenuItem.Text = "Обновить";
            this.updateMenuItem.Click += new System.EventHandler(this.updateMenuItem_Click);
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panelGeneral.Controls.Add(this.numericUpDownCopies);
            this.panelGeneral.Controls.Add(this.lblInfoCopies);
            this.panelGeneral.Controls.Add(this.comboBoxPrinters);
            this.panelGeneral.Controls.Add(this.lblInfoPrinter);
            this.panelGeneral.Controls.Add(this.btnPrint);
            this.panelGeneral.Controls.Add(this.btnOpenUnloadDir);
            this.panelGeneral.Controls.Add(this.reportLabelInfoUnloadDir);
            this.panelGeneral.Controls.Add(this.reportTextBoxUnloadDir);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelGeneral.Location = new System.Drawing.Point(0, 40);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1357, 58);
            this.panelGeneral.TabIndex = 4;
            // 
            // numericUpDownCopies
            // 
            this.numericUpDownCopies.Location = new System.Drawing.Point(1213, 17);
            this.numericUpDownCopies.Name = "numericUpDownCopies";
            this.numericUpDownCopies.Size = new System.Drawing.Size(50, 25);
            this.numericUpDownCopies.TabIndex = 0;
            this.numericUpDownCopies.TabStop = false;
            this.numericUpDownCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblInfoCopies
            // 
            this.lblInfoCopies.AutoSize = true;
            this.lblInfoCopies.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoCopies.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInfoCopies.Location = new System.Drawing.Point(1149, 19);
            this.lblInfoCopies.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.lblInfoCopies.Name = "lblInfoCopies";
            this.lblInfoCopies.Size = new System.Drawing.Size(58, 20);
            this.lblInfoCopies.TabIndex = 0;
            this.lblInfoCopies.Text = "Копий:";
            // 
            // comboBoxPrinters
            // 
            this.comboBoxPrinters.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxPrinters.FormattingEnabled = true;
            this.comboBoxPrinters.Location = new System.Drawing.Point(906, 17);
            this.comboBoxPrinters.Name = "comboBoxPrinters";
            this.comboBoxPrinters.Size = new System.Drawing.Size(225, 25);
            this.comboBoxPrinters.TabIndex = 0;
            this.comboBoxPrinters.TabStop = false;
            // 
            // lblInfoPrinter
            // 
            this.lblInfoPrinter.AutoSize = true;
            this.lblInfoPrinter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoPrinter.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInfoPrinter.Location = new System.Drawing.Point(826, 19);
            this.lblInfoPrinter.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.lblInfoPrinter.Name = "lblInfoPrinter";
            this.lblInfoPrinter.Size = new System.Drawing.Size(74, 20);
            this.lblInfoPrinter.TabIndex = 0;
            this.lblInfoPrinter.Text = "Принтер:";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.BorderColor = System.Drawing.Color.Silver;
            this.btnPrint.BorderRadius = 6F;
            this.btnPrint.BorderSize = 0;
            this.btnPrint.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnPrint.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::WorldStat.Properties.Resources.printer_3_24;
            this.btnPrint.Location = new System.Drawing.Point(1305, 9);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnPrint.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnPrint.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(5, 0, 4, 0);
            this.btnPrint.Size = new System.Drawing.Size(40, 40);
            this.btnPrint.TabIndex = 30;
            this.btnPrint.TabStop = false;
            this.btnPrint.TextColor = System.Drawing.Color.White;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnOpenUnloadDir
            // 
            this.btnOpenUnloadDir.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnOpenUnloadDir.BorderColor = System.Drawing.Color.Silver;
            this.btnOpenUnloadDir.BorderRadius = 6F;
            this.btnOpenUnloadDir.BorderSize = 0;
            this.btnOpenUnloadDir.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnOpenUnloadDir.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnOpenUnloadDir.FlatAppearance.BorderSize = 0;
            this.btnOpenUnloadDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnOpenUnloadDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenUnloadDir.ForeColor = System.Drawing.Color.White;
            this.btnOpenUnloadDir.Location = new System.Drawing.Point(705, 12);
            this.btnOpenUnloadDir.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnOpenUnloadDir.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnOpenUnloadDir.Name = "btnOpenUnloadDir";
            this.btnOpenUnloadDir.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnOpenUnloadDir.Size = new System.Drawing.Size(101, 35);
            this.btnOpenUnloadDir.TabIndex = 30;
            this.btnOpenUnloadDir.Text = "Изменить";
            this.btnOpenUnloadDir.TextColor = System.Drawing.Color.White;
            this.btnOpenUnloadDir.UseVisualStyleBackColor = false;
            this.btnOpenUnloadDir.Click += new System.EventHandler(this.btnOpenUnloadDir_Click);
            // 
            // reportLabelInfoUnloadDir
            // 
            this.reportLabelInfoUnloadDir.AutoSize = true;
            this.reportLabelInfoUnloadDir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportLabelInfoUnloadDir.ForeColor = System.Drawing.Color.Gainsboro;
            this.reportLabelInfoUnloadDir.Location = new System.Drawing.Point(15, 19);
            this.reportLabelInfoUnloadDir.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.reportLabelInfoUnloadDir.Name = "reportLabelInfoUnloadDir";
            this.reportLabelInfoUnloadDir.Size = new System.Drawing.Size(138, 20);
            this.reportLabelInfoUnloadDir.TabIndex = 29;
            this.reportLabelInfoUnloadDir.Text = "Выгрузка отчетов:";
            // 
            // reportTextBoxUnloadDir
            // 
            this.reportTextBoxUnloadDir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reportTextBoxUnloadDir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(106)))), ((int)(((byte)(111)))));
            this.reportTextBoxUnloadDir.BorderFocusColor = System.Drawing.Color.LightSlateGray;
            this.reportTextBoxUnloadDir.BorderSize = 2;
            this.reportTextBoxUnloadDir.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.reportTextBoxUnloadDir.DisableBackColor = System.Drawing.Color.DarkGray;
            this.reportTextBoxUnloadDir.DisableBorderColor = System.Drawing.Color.DimGray;
            this.reportTextBoxUnloadDir.DisableForeColor = System.Drawing.Color.DimGray;
            this.reportTextBoxUnloadDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportTextBoxUnloadDir.ForeColor = System.Drawing.Color.DimGray;
            this.reportTextBoxUnloadDir.Location = new System.Drawing.Point(160, 14);
            this.reportTextBoxUnloadDir.Margin = new System.Windows.Forms.Padding(4);
            this.reportTextBoxUnloadDir.MaxLength = 32767;
            this.reportTextBoxUnloadDir.Multiline = false;
            this.reportTextBoxUnloadDir.Name = "reportTextBoxUnloadDir";
            this.reportTextBoxUnloadDir.Padding = new System.Windows.Forms.Padding(7);
            this.reportTextBoxUnloadDir.PasswordChar = '\0';
            this.reportTextBoxUnloadDir.ReadOnly = true;
            this.reportTextBoxUnloadDir.Size = new System.Drawing.Size(538, 31);
            this.reportTextBoxUnloadDir.TabIndex = 28;
            this.reportTextBoxUnloadDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reportTextBoxUnloadDir.UnderlinedStyle = false;
            this.reportTextBoxUnloadDir.UsePasswordChar = false;
            // 
            // orgToggleButtonCalendar
            // 
            this.orgToggleButtonCalendar.AutoSize = true;
            this.orgToggleButtonCalendar.Checked = true;
            this.orgToggleButtonCalendar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.orgToggleButtonCalendar.DisableBackColor = System.Drawing.Color.DimGray;
            this.orgToggleButtonCalendar.DisableToggleColor = System.Drawing.Color.Gray;
            this.orgToggleButtonCalendar.Location = new System.Drawing.Point(3, 6);
            this.orgToggleButtonCalendar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.orgToggleButtonCalendar.MinimumSize = new System.Drawing.Size(45, 22);
            this.orgToggleButtonCalendar.Name = "orgToggleButtonCalendar";
            this.orgToggleButtonCalendar.OffBackColor = System.Drawing.Color.DimGray;
            this.orgToggleButtonCalendar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.orgToggleButtonCalendar.OnBackColor = System.Drawing.Color.SeaGreen;
            this.orgToggleButtonCalendar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.orgToggleButtonCalendar.Size = new System.Drawing.Size(45, 22);
            this.orgToggleButtonCalendar.TabIndex = 28;
            this.orgToggleButtonCalendar.UseVisualStyleBackColor = true;
            this.orgToggleButtonCalendar.CheckedChanged += new System.EventHandler(this.orgToggleButtonCalendar_CheckedChanged);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.statusBar.Location = new System.Drawing.Point(0, 504);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1357, 22);
            this.statusBar.TabIndex = 5;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(1228, 17);
            this.statusText.Spring = true;
            // 
            // statusAuthor
            // 
            this.statusAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAuthor.ForeColor = System.Drawing.Color.Gray;
            this.statusAuthor.Name = "statusAuthor";
            this.statusAuthor.Size = new System.Drawing.Size(114, 17);
            this.statusAuthor.Text = "WorldCount, 2021 ©";
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabReports);
            this.tabsControl.Controls.Add(this.tabOrgs);
            this.tabsControl.Controls.Add(this.tabIncomes);
            this.tabsControl.Controls.Add(this.tabStats);
            this.tabsControl.Controls.Add(this.tabCharts);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabsControl.Location = new System.Drawing.Point(0, 98);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(1357, 406);
            this.tabsControl.TabIndex = 6;
            // 
            // tabReports
            // 
            this.tabReports.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabReports.Controls.Add(this.reportPanelStat);
            this.tabReports.Controls.Add(this.reportDataGridView);
            this.tabReports.Controls.Add(this.reportPanel);
            this.tabReports.Location = new System.Drawing.Point(4, 29);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(1349, 373);
            this.tabReports.TabIndex = 0;
            this.tabReports.Text = "Общее";
            // 
            // reportPanelStat
            // 
            this.reportPanelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.reportPanelStat.Controls.Add(this.reportLabelDaysCount);
            this.reportPanelStat.Controls.Add(this.reportLabelInfoDays);
            this.reportPanelStat.Controls.Add(this.reportLabelPay);
            this.reportPanelStat.Controls.Add(this.reportLabelCount);
            this.reportPanelStat.Controls.Add(this.reportLabelInfoPay);
            this.reportPanelStat.Controls.Add(this.reportLabelInfoCount);
            this.reportPanelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportPanelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.reportPanelStat.Location = new System.Drawing.Point(0, 343);
            this.reportPanelStat.Name = "reportPanelStat";
            this.reportPanelStat.Size = new System.Drawing.Size(1349, 30);
            this.reportPanelStat.TabIndex = 6;
            // 
            // reportLabelDaysCount
            // 
            this.reportLabelDaysCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportLabelDaysCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.reportLabelDaysCount.Location = new System.Drawing.Point(712, 5);
            this.reportLabelDaysCount.Name = "reportLabelDaysCount";
            this.reportLabelDaysCount.Size = new System.Drawing.Size(140, 20);
            this.reportLabelDaysCount.TabIndex = 3;
            this.reportLabelDaysCount.Text = "0";
            // 
            // reportLabelInfoDays
            // 
            this.reportLabelInfoDays.AutoSize = true;
            this.reportLabelInfoDays.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportLabelInfoDays.Location = new System.Drawing.Point(664, 5);
            this.reportLabelInfoDays.Name = "reportLabelInfoDays";
            this.reportLabelInfoDays.Size = new System.Drawing.Size(42, 20);
            this.reportLabelInfoDays.TabIndex = 2;
            this.reportLabelInfoDays.Text = "Дни:";
            // 
            // reportLabelPay
            // 
            this.reportLabelPay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportLabelPay.ForeColor = System.Drawing.Color.DarkOrange;
            this.reportLabelPay.Location = new System.Drawing.Point(461, 5);
            this.reportLabelPay.Name = "reportLabelPay";
            this.reportLabelPay.Size = new System.Drawing.Size(140, 20);
            this.reportLabelPay.TabIndex = 1;
            this.reportLabelPay.Text = "0,00 ₽";
            // 
            // reportLabelCount
            // 
            this.reportLabelCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportLabelCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.reportLabelCount.Location = new System.Drawing.Point(122, 5);
            this.reportLabelCount.Name = "reportLabelCount";
            this.reportLabelCount.Size = new System.Drawing.Size(140, 20);
            this.reportLabelCount.TabIndex = 0;
            this.reportLabelCount.Text = "0";
            // 
            // reportLabelInfoPay
            // 
            this.reportLabelInfoPay.AutoSize = true;
            this.reportLabelInfoPay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportLabelInfoPay.Location = new System.Drawing.Point(395, 5);
            this.reportLabelInfoPay.Name = "reportLabelInfoPay";
            this.reportLabelInfoPay.Size = new System.Drawing.Size(60, 20);
            this.reportLabelInfoPay.TabIndex = 0;
            this.reportLabelInfoPay.Text = "Сумма:";
            // 
            // reportLabelInfoCount
            // 
            this.reportLabelInfoCount.AutoSize = true;
            this.reportLabelInfoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportLabelInfoCount.Location = new System.Drawing.Point(21, 5);
            this.reportLabelInfoCount.Name = "reportLabelInfoCount";
            this.reportLabelInfoCount.Size = new System.Drawing.Size(95, 20);
            this.reportLabelInfoCount.TabIndex = 0;
            this.reportLabelInfoCount.Text = "Количество:";
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.AllowUserToAddRows = false;
            this.reportDataGridView.AllowUserToDeleteRows = false;
            this.reportDataGridView.AllowUserToResizeColumns = false;
            this.reportDataGridView.AllowUserToResizeRows = false;
            this.reportDataGridView.AutoGenerateColumns = false;
            this.reportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.reportDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reportDataGridView.ColumnHeadersHeight = 40;
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.reportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportColumnDate,
            this.reportColumnDayName,
            this.reportColumnType,
            this.reportColumnCount,
            this.reportColumnPay});
            this.reportDataGridView.DataSource = this.reportBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reportDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.reportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportDataGridView.EnableHeadersVisualStyles = false;
            this.reportDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.reportDataGridView.Location = new System.Drawing.Point(0, 48);
            this.reportDataGridView.Name = "reportDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.reportDataGridView.RowHeadersVisible = false;
            this.reportDataGridView.RowHeadersWidth = 40;
            this.reportDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.reportDataGridView.RowTemplate.Height = 40;
            this.reportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.reportDataGridView.Size = new System.Drawing.Size(1349, 325);
            this.reportDataGridView.TabIndex = 5;
            this.reportDataGridView.TabStop = false;
            this.reportDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            this.reportDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reportDataGridView_MouseClick);
            // 
            // reportColumnDate
            // 
            this.reportColumnDate.DataPropertyName = "Date";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.reportColumnDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.reportColumnDate.HeaderText = "Дата";
            this.reportColumnDate.Name = "reportColumnDate";
            this.reportColumnDate.ReadOnly = true;
            // 
            // reportColumnDayName
            // 
            this.reportColumnDayName.DataPropertyName = "DayName";
            this.reportColumnDayName.HeaderText = "День";
            this.reportColumnDayName.Name = "reportColumnDayName";
            this.reportColumnDayName.ReadOnly = true;
            // 
            // reportColumnType
            // 
            this.reportColumnType.DataPropertyName = "Type";
            this.reportColumnType.HeaderText = "Смена";
            this.reportColumnType.Name = "reportColumnType";
            this.reportColumnType.ReadOnly = true;
            // 
            // reportColumnCount
            // 
            this.reportColumnCount.DataPropertyName = "Count";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.reportColumnCount.DefaultCellStyle = dataGridViewCellStyle3;
            this.reportColumnCount.HeaderText = "Количество";
            this.reportColumnCount.Name = "reportColumnCount";
            this.reportColumnCount.ReadOnly = true;
            // 
            // reportColumnPay
            // 
            this.reportColumnPay.DataPropertyName = "Pay";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.reportColumnPay.DefaultCellStyle = dataGridViewCellStyle4;
            this.reportColumnPay.HeaderText = "Плата";
            this.reportColumnPay.Name = "reportColumnPay";
            this.reportColumnPay.ReadOnly = true;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.Report);
            // 
            // reportPanel
            // 
            this.reportPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.reportPanel.Controls.Add(this.flowLayoutPanelReport);
            this.reportPanel.Controls.Add(this.btnLoadReports);
            this.reportPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportPanel.Location = new System.Drawing.Point(0, 0);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(1349, 48);
            this.reportPanel.TabIndex = 4;
            // 
            // flowLayoutPanelReport
            // 
            this.flowLayoutPanelReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelReport.Controls.Add(this.reportToggleButton);
            this.flowLayoutPanelReport.Controls.Add(this.reportDateTimePickerStart);
            this.flowLayoutPanelReport.Controls.Add(this.reportDateTimePickerEnd);
            this.flowLayoutPanelReport.Controls.Add(this.reportDateTimePickerCalendar);
            this.flowLayoutPanelReport.Controls.Add(this.reportLabelInfoTeam);
            this.flowLayoutPanelReport.Controls.Add(this.reportComboBoxTeam);
            this.flowLayoutPanelReport.Location = new System.Drawing.Point(8, 7);
            this.flowLayoutPanelReport.Name = "flowLayoutPanelReport";
            this.flowLayoutPanelReport.Size = new System.Drawing.Size(1287, 34);
            this.flowLayoutPanelReport.TabIndex = 27;
            // 
            // reportToggleButton
            // 
            this.reportToggleButton.AutoSize = true;
            this.reportToggleButton.Checked = true;
            this.reportToggleButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reportToggleButton.DisableBackColor = System.Drawing.Color.DimGray;
            this.reportToggleButton.DisableToggleColor = System.Drawing.Color.Gray;
            this.reportToggleButton.Location = new System.Drawing.Point(3, 5);
            this.reportToggleButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.reportToggleButton.MinimumSize = new System.Drawing.Size(45, 22);
            this.reportToggleButton.Name = "reportToggleButton";
            this.reportToggleButton.OffBackColor = System.Drawing.Color.DimGray;
            this.reportToggleButton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.reportToggleButton.OnBackColor = System.Drawing.Color.SeaGreen;
            this.reportToggleButton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.reportToggleButton.Size = new System.Drawing.Size(45, 22);
            this.reportToggleButton.TabIndex = 30;
            this.reportToggleButton.UseVisualStyleBackColor = true;
            this.reportToggleButton.CheckedChanged += new System.EventHandler(this.reportToggleButtonCalendar_CheckedChanged);
            // 
            // reportDateTimePickerStart
            // 
            this.reportDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.reportDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.reportDateTimePickerStart.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.reportDateTimePickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.reportDateTimePickerStart.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.reportDateTimePickerStart.Location = new System.Drawing.Point(54, 3);
            this.reportDateTimePickerStart.Name = "reportDateTimePickerStart";
            this.reportDateTimePickerStart.Size = new System.Drawing.Size(220, 27);
            this.reportDateTimePickerStart.TabIndex = 28;
            this.reportDateTimePickerStart.Visible = false;
            this.reportDateTimePickerStart.ValueChanged += new System.EventHandler(this.reportDateTimePickerStart_ValueChanged);
            // 
            // reportDateTimePickerEnd
            // 
            this.reportDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.reportDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.reportDateTimePickerEnd.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.reportDateTimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.reportDateTimePickerEnd.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.reportDateTimePickerEnd.Location = new System.Drawing.Point(280, 3);
            this.reportDateTimePickerEnd.Name = "reportDateTimePickerEnd";
            this.reportDateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.reportDateTimePickerEnd.TabIndex = 29;
            this.reportDateTimePickerEnd.Visible = false;
            // 
            // reportDateTimePickerCalendar
            // 
            this.reportDateTimePickerCalendar.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.reportDateTimePickerCalendar.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.reportDateTimePickerCalendar.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.reportDateTimePickerCalendar.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.reportDateTimePickerCalendar.CustomFormat = "MMMM yyyy";
            this.reportDateTimePickerCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reportDateTimePickerCalendar.Location = new System.Drawing.Point(486, 3);
            this.reportDateTimePickerCalendar.Name = "reportDateTimePickerCalendar";
            this.reportDateTimePickerCalendar.ShowUpDown = true;
            this.reportDateTimePickerCalendar.Size = new System.Drawing.Size(200, 27);
            this.reportDateTimePickerCalendar.TabIndex = 23;
            // 
            // reportLabelInfoTeam
            // 
            this.reportLabelInfoTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportLabelInfoTeam.AutoSize = true;
            this.reportLabelInfoTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportLabelInfoTeam.ForeColor = System.Drawing.Color.Gainsboro;
            this.reportLabelInfoTeam.Location = new System.Drawing.Point(695, 6);
            this.reportLabelInfoTeam.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.reportLabelInfoTeam.Name = "reportLabelInfoTeam";
            this.reportLabelInfoTeam.Size = new System.Drawing.Size(58, 20);
            this.reportLabelInfoTeam.TabIndex = 26;
            this.reportLabelInfoTeam.Text = "Смена:";
            // 
            // reportComboBoxTeam
            // 
            this.reportComboBoxTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportComboBoxTeam.FormattingEnabled = true;
            this.reportComboBoxTeam.Location = new System.Drawing.Point(759, 3);
            this.reportComboBoxTeam.Name = "reportComboBoxTeam";
            this.reportComboBoxTeam.Size = new System.Drawing.Size(168, 28);
            this.reportComboBoxTeam.TabIndex = 25;
            // 
            // btnLoadReports
            // 
            this.btnLoadReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadReports.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadReports.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadReports.BorderRadius = 6F;
            this.btnLoadReports.BorderSize = 0;
            this.btnLoadReports.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadReports.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadReports.FlatAppearance.BorderSize = 0;
            this.btnLoadReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLoadReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadReports.ForeColor = System.Drawing.Color.White;
            this.btnLoadReports.Image = global::WorldStat.Properties.Resources.sinchronize_24;
            this.btnLoadReports.Location = new System.Drawing.Point(1301, 4);
            this.btnLoadReports.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnLoadReports.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLoadReports.Name = "btnLoadReports";
            this.btnLoadReports.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadReports.Size = new System.Drawing.Size(40, 40);
            this.btnLoadReports.TabIndex = 24;
            this.btnLoadReports.TextColor = System.Drawing.Color.White;
            this.btnLoadReports.UseVisualStyleBackColor = false;
            this.btnLoadReports.Click += new System.EventHandler(this.btnLoadReports_Click);
            // 
            // tabOrgs
            // 
            this.tabOrgs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabOrgs.Controls.Add(this.orgPanelStat);
            this.tabOrgs.Controls.Add(this.orgDataGridView);
            this.tabOrgs.Controls.Add(this.dataGridViewDocOrg);
            this.tabOrgs.Controls.Add(this.orgPanel);
            this.tabOrgs.Location = new System.Drawing.Point(4, 29);
            this.tabOrgs.Name = "tabOrgs";
            this.tabOrgs.Size = new System.Drawing.Size(1349, 373);
            this.tabOrgs.TabIndex = 1;
            this.tabOrgs.Text = "Организации";
            // 
            // orgPanelStat
            // 
            this.orgPanelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgPanelStat.Controls.Add(this.orgLabelPosCount);
            this.orgPanelStat.Controls.Add(this.orgLabelInfoPosCount);
            this.orgPanelStat.Controls.Add(this.orgLabelPay);
            this.orgPanelStat.Controls.Add(this.orgLabelCount);
            this.orgPanelStat.Controls.Add(this.orgLabelInfoPay);
            this.orgPanelStat.Controls.Add(this.orgLabelInfoCount);
            this.orgPanelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orgPanelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.orgPanelStat.Location = new System.Drawing.Point(0, 343);
            this.orgPanelStat.Name = "orgPanelStat";
            this.orgPanelStat.Size = new System.Drawing.Size(1349, 30);
            this.orgPanelStat.TabIndex = 9;
            // 
            // orgLabelPosCount
            // 
            this.orgLabelPosCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgLabelPosCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.orgLabelPosCount.Location = new System.Drawing.Point(731, 5);
            this.orgLabelPosCount.Name = "orgLabelPosCount";
            this.orgLabelPosCount.Size = new System.Drawing.Size(140, 20);
            this.orgLabelPosCount.TabIndex = 3;
            this.orgLabelPosCount.Text = "0";
            // 
            // orgLabelInfoPosCount
            // 
            this.orgLabelInfoPosCount.AutoSize = true;
            this.orgLabelInfoPosCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgLabelInfoPosCount.Location = new System.Drawing.Point(649, 5);
            this.orgLabelInfoPosCount.Name = "orgLabelInfoPosCount";
            this.orgLabelInfoPosCount.Size = new System.Drawing.Size(76, 20);
            this.orgLabelInfoPosCount.TabIndex = 2;
            this.orgLabelInfoPosCount.Text = "Позиций:";
            // 
            // orgLabelPay
            // 
            this.orgLabelPay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgLabelPay.ForeColor = System.Drawing.Color.DarkOrange;
            this.orgLabelPay.Location = new System.Drawing.Point(461, 5);
            this.orgLabelPay.Name = "orgLabelPay";
            this.orgLabelPay.Size = new System.Drawing.Size(140, 20);
            this.orgLabelPay.TabIndex = 1;
            this.orgLabelPay.Text = "0,00 ₽";
            // 
            // orgLabelCount
            // 
            this.orgLabelCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgLabelCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.orgLabelCount.Location = new System.Drawing.Point(122, 5);
            this.orgLabelCount.Name = "orgLabelCount";
            this.orgLabelCount.Size = new System.Drawing.Size(140, 20);
            this.orgLabelCount.TabIndex = 0;
            this.orgLabelCount.Text = "0";
            // 
            // orgLabelInfoPay
            // 
            this.orgLabelInfoPay.AutoSize = true;
            this.orgLabelInfoPay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgLabelInfoPay.Location = new System.Drawing.Point(395, 5);
            this.orgLabelInfoPay.Name = "orgLabelInfoPay";
            this.orgLabelInfoPay.Size = new System.Drawing.Size(60, 20);
            this.orgLabelInfoPay.TabIndex = 0;
            this.orgLabelInfoPay.Text = "Сумма:";
            // 
            // orgLabelInfoCount
            // 
            this.orgLabelInfoCount.AutoSize = true;
            this.orgLabelInfoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgLabelInfoCount.Location = new System.Drawing.Point(21, 5);
            this.orgLabelInfoCount.Name = "orgLabelInfoCount";
            this.orgLabelInfoCount.Size = new System.Drawing.Size(95, 20);
            this.orgLabelInfoCount.TabIndex = 0;
            this.orgLabelInfoCount.Text = "Количество:";
            // 
            // orgDataGridView
            // 
            this.orgDataGridView.AllowUserToAddRows = false;
            this.orgDataGridView.AllowUserToDeleteRows = false;
            this.orgDataGridView.AllowUserToResizeColumns = false;
            this.orgDataGridView.AllowUserToResizeRows = false;
            this.orgDataGridView.AutoGenerateColumns = false;
            this.orgDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orgDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.orgDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orgDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.orgDataGridView.ColumnHeadersHeight = 40;
            this.orgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.orgDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orgColumnDate,
            this.orgColumnName,
            this.orgColumnMailType,
            this.orgColumnMailCategory,
            this.orgColumnTransCategory,
            this.orgColumnCount,
            this.orgColumnPay,
            this.orgColumnTransType});
            this.orgDataGridView.DataSource = this.orgReportPosBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orgDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.orgDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orgDataGridView.EnableHeadersVisualStyles = false;
            this.orgDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.orgDataGridView.Location = new System.Drawing.Point(0, 92);
            this.orgDataGridView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.orgDataGridView.Name = "orgDataGridView";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orgDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.orgDataGridView.RowHeadersVisible = false;
            this.orgDataGridView.RowHeadersWidth = 40;
            this.orgDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orgDataGridView.RowTemplate.Height = 40;
            this.orgDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.orgDataGridView.Size = new System.Drawing.Size(1349, 281);
            this.orgDataGridView.TabIndex = 8;
            this.orgDataGridView.TabStop = false;
            this.orgDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            // 
            // orgColumnDate
            // 
            this.orgColumnDate.DataPropertyName = "DateText";
            this.orgColumnDate.HeaderText = "Дата";
            this.orgColumnDate.Name = "orgColumnDate";
            this.orgColumnDate.ReadOnly = true;
            // 
            // orgColumnName
            // 
            this.orgColumnName.DataPropertyName = "FirmName";
            this.orgColumnName.HeaderText = "Организация";
            this.orgColumnName.Name = "orgColumnName";
            this.orgColumnName.ReadOnly = true;
            // 
            // orgColumnMailType
            // 
            this.orgColumnMailType.DataPropertyName = "MailType";
            this.orgColumnMailType.DataSource = this.mailTypeBindingSource;
            this.orgColumnMailType.DisplayMember = "ShortName";
            this.orgColumnMailType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.orgColumnMailType.HeaderText = "Тип";
            this.orgColumnMailType.Name = "orgColumnMailType";
            this.orgColumnMailType.ReadOnly = true;
            this.orgColumnMailType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orgColumnMailType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orgColumnMailType.ValueMember = "Code";
            // 
            // mailTypeBindingSource
            // 
            this.mailTypeBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.MailType);
            // 
            // orgColumnMailCategory
            // 
            this.orgColumnMailCategory.DataPropertyName = "MailCategory";
            this.orgColumnMailCategory.DataSource = this.mailCategoryBindingSource;
            this.orgColumnMailCategory.DisplayMember = "ShortName";
            this.orgColumnMailCategory.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.orgColumnMailCategory.HeaderText = "Категория";
            this.orgColumnMailCategory.Name = "orgColumnMailCategory";
            this.orgColumnMailCategory.ReadOnly = true;
            this.orgColumnMailCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orgColumnMailCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orgColumnMailCategory.ValueMember = "Code";
            // 
            // mailCategoryBindingSource
            // 
            this.mailCategoryBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.MailCategory);
            // 
            // orgColumnTransCategory
            // 
            this.orgColumnTransCategory.DataPropertyName = "TransCategory";
            this.orgColumnTransCategory.HeaderText = "Класс";
            this.orgColumnTransCategory.Name = "orgColumnTransCategory";
            this.orgColumnTransCategory.ReadOnly = true;
            // 
            // orgColumnCount
            // 
            this.orgColumnCount.DataPropertyName = "Count";
            this.orgColumnCount.HeaderText = "Количество";
            this.orgColumnCount.Name = "orgColumnCount";
            this.orgColumnCount.ReadOnly = true;
            // 
            // orgColumnPay
            // 
            this.orgColumnPay.DataPropertyName = "Pay";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.orgColumnPay.DefaultCellStyle = dataGridViewCellStyle8;
            this.orgColumnPay.HeaderText = "Плата";
            this.orgColumnPay.Name = "orgColumnPay";
            this.orgColumnPay.ReadOnly = true;
            // 
            // orgColumnTransType
            // 
            this.orgColumnTransType.DataPropertyName = "TransType";
            this.orgColumnTransType.HeaderText = "Пересылка";
            this.orgColumnTransType.Name = "orgColumnTransType";
            this.orgColumnTransType.ReadOnly = true;
            // 
            // orgReportPosBindingSource
            // 
            this.orgReportPosBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.ReportPos);
            // 
            // dataGridViewDocOrg
            // 
            this.dataGridViewDocOrg.AllowUserToAddRows = false;
            this.dataGridViewDocOrg.AllowUserToDeleteRows = false;
            this.dataGridViewDocOrg.AllowUserToResizeRows = false;
            this.dataGridViewDocOrg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDocOrg.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDocOrg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocOrg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewDocOrg.ColumnHeadersHeight = 40;
            this.dataGridViewDocOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDocOrg.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewDocOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDocOrg.EnableHeadersVisualStyles = false;
            this.dataGridViewDocOrg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewDocOrg.Location = new System.Drawing.Point(0, 92);
            this.dataGridViewDocOrg.Name = "dataGridViewDocOrg";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocOrg.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewDocOrg.RowHeadersVisible = false;
            this.dataGridViewDocOrg.RowHeadersWidth = 40;
            this.dataGridViewDocOrg.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewDocOrg.RowTemplate.Height = 40;
            this.dataGridViewDocOrg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDocOrg.Size = new System.Drawing.Size(1349, 281);
            this.dataGridViewDocOrg.TabIndex = 7;
            this.dataGridViewDocOrg.TabStop = false;
            // 
            // orgPanel
            // 
            this.orgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgPanel.Controls.Add(this.flowLayoutPanelOrgFilter);
            this.orgPanel.Controls.Add(this.flowLayoutPanelOrgBase);
            this.orgPanel.Controls.Add(this.btnLoadOrgs);
            this.orgPanel.Controls.Add(this.orgComboBoxFirms);
            this.orgPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.orgPanel.Location = new System.Drawing.Point(0, 0);
            this.orgPanel.Name = "orgPanel";
            this.orgPanel.Size = new System.Drawing.Size(1349, 92);
            this.orgPanel.TabIndex = 3;
            // 
            // flowLayoutPanelOrgFilter
            // 
            this.flowLayoutPanelOrgFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelOrgFilter.Controls.Add(this.orgLabelInfoMailType);
            this.flowLayoutPanelOrgFilter.Controls.Add(this.orgComboBoxMailType);
            this.flowLayoutPanelOrgFilter.Controls.Add(this.orgLabelInfoMailCategory);
            this.flowLayoutPanelOrgFilter.Controls.Add(this.orgComboBoxMailCategory);
            this.flowLayoutPanelOrgFilter.Controls.Add(this.orgLabelInfoTransCategory);
            this.flowLayoutPanelOrgFilter.Controls.Add(this.orgComboBoxTransCategory);
            this.flowLayoutPanelOrgFilter.Controls.Add(this.orgLabelInfoTransType);
            this.flowLayoutPanelOrgFilter.Controls.Add(this.orgComboBoxTransType);
            this.flowLayoutPanelOrgFilter.Location = new System.Drawing.Point(8, 48);
            this.flowLayoutPanelOrgFilter.Name = "flowLayoutPanelOrgFilter";
            this.flowLayoutPanelOrgFilter.Size = new System.Drawing.Size(1333, 34);
            this.flowLayoutPanelOrgFilter.TabIndex = 0;
            // 
            // orgLabelInfoMailType
            // 
            this.orgLabelInfoMailType.AutoSize = true;
            this.orgLabelInfoMailType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgLabelInfoMailType.ForeColor = System.Drawing.Color.Gainsboro;
            this.orgLabelInfoMailType.Location = new System.Drawing.Point(0, 6);
            this.orgLabelInfoMailType.Margin = new System.Windows.Forms.Padding(0, 6, 2, 0);
            this.orgLabelInfoMailType.Name = "orgLabelInfoMailType";
            this.orgLabelInfoMailType.Size = new System.Drawing.Size(38, 20);
            this.orgLabelInfoMailType.TabIndex = 30;
            this.orgLabelInfoMailType.Text = "Тип:";
            // 
            // orgComboBoxMailType
            // 
            this.orgComboBoxMailType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orgComboBoxMailType.DataSource = this.orgAcitveMailTypeBindingSource;
            this.orgComboBoxMailType.DisplayMember = "ShortName";
            this.orgComboBoxMailType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgComboBoxMailType.FormattingEnabled = true;
            this.orgComboBoxMailType.Location = new System.Drawing.Point(43, 3);
            this.orgComboBoxMailType.Name = "orgComboBoxMailType";
            this.orgComboBoxMailType.Size = new System.Drawing.Size(257, 28);
            this.orgComboBoxMailType.TabIndex = 31;
            this.orgComboBoxMailType.ValueMember = "Code";
            // 
            // orgAcitveMailTypeBindingSource
            // 
            this.orgAcitveMailTypeBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.MailType);
            // 
            // orgLabelInfoMailCategory
            // 
            this.orgLabelInfoMailCategory.AutoSize = true;
            this.orgLabelInfoMailCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgLabelInfoMailCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.orgLabelInfoMailCategory.Location = new System.Drawing.Point(308, 6);
            this.orgLabelInfoMailCategory.Margin = new System.Windows.Forms.Padding(5, 6, 2, 0);
            this.orgLabelInfoMailCategory.Name = "orgLabelInfoMailCategory";
            this.orgLabelInfoMailCategory.Size = new System.Drawing.Size(85, 20);
            this.orgLabelInfoMailCategory.TabIndex = 30;
            this.orgLabelInfoMailCategory.Text = "Категория:";
            // 
            // orgComboBoxMailCategory
            // 
            this.orgComboBoxMailCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orgComboBoxMailCategory.DataSource = this.orgActiveMailCategoryBindingSource;
            this.orgComboBoxMailCategory.DisplayMember = "ShortName";
            this.orgComboBoxMailCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgComboBoxMailCategory.FormattingEnabled = true;
            this.orgComboBoxMailCategory.Location = new System.Drawing.Point(398, 3);
            this.orgComboBoxMailCategory.Name = "orgComboBoxMailCategory";
            this.orgComboBoxMailCategory.Size = new System.Drawing.Size(215, 28);
            this.orgComboBoxMailCategory.TabIndex = 31;
            this.orgComboBoxMailCategory.ValueMember = "Code";
            // 
            // orgActiveMailCategoryBindingSource
            // 
            this.orgActiveMailCategoryBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.MailCategory);
            // 
            // orgLabelInfoTransCategory
            // 
            this.orgLabelInfoTransCategory.AutoSize = true;
            this.orgLabelInfoTransCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgLabelInfoTransCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.orgLabelInfoTransCategory.Location = new System.Drawing.Point(621, 6);
            this.orgLabelInfoTransCategory.Margin = new System.Windows.Forms.Padding(5, 6, 2, 0);
            this.orgLabelInfoTransCategory.Name = "orgLabelInfoTransCategory";
            this.orgLabelInfoTransCategory.Size = new System.Drawing.Size(53, 20);
            this.orgLabelInfoTransCategory.TabIndex = 34;
            this.orgLabelInfoTransCategory.Text = "Класс:";
            // 
            // orgComboBoxTransCategory
            // 
            this.orgComboBoxTransCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orgComboBoxTransCategory.DisplayMember = "Code";
            this.orgComboBoxTransCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgComboBoxTransCategory.FormattingEnabled = true;
            this.orgComboBoxTransCategory.Location = new System.Drawing.Point(679, 3);
            this.orgComboBoxTransCategory.Name = "orgComboBoxTransCategory";
            this.orgComboBoxTransCategory.Size = new System.Drawing.Size(180, 28);
            this.orgComboBoxTransCategory.TabIndex = 35;
            this.orgComboBoxTransCategory.ValueMember = "Code";
            // 
            // orgLabelInfoTransType
            // 
            this.orgLabelInfoTransType.AutoSize = true;
            this.orgLabelInfoTransType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgLabelInfoTransType.ForeColor = System.Drawing.Color.Gainsboro;
            this.orgLabelInfoTransType.Location = new System.Drawing.Point(867, 6);
            this.orgLabelInfoTransType.Margin = new System.Windows.Forms.Padding(5, 6, 2, 0);
            this.orgLabelInfoTransType.Name = "orgLabelInfoTransType";
            this.orgLabelInfoTransType.Size = new System.Drawing.Size(91, 20);
            this.orgLabelInfoTransType.TabIndex = 32;
            this.orgLabelInfoTransType.Text = "Пересылка:";
            // 
            // orgComboBoxTransType
            // 
            this.orgComboBoxTransType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orgComboBoxTransType.DisplayMember = "Code";
            this.orgComboBoxTransType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgComboBoxTransType.FormattingEnabled = true;
            this.orgComboBoxTransType.Location = new System.Drawing.Point(963, 3);
            this.orgComboBoxTransType.Name = "orgComboBoxTransType";
            this.orgComboBoxTransType.Size = new System.Drawing.Size(180, 28);
            this.orgComboBoxTransType.TabIndex = 33;
            this.orgComboBoxTransType.ValueMember = "Code";
            // 
            // flowLayoutPanelOrgBase
            // 
            this.flowLayoutPanelOrgBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelOrgBase.Controls.Add(this.orgToggleButtonCalendar);
            this.flowLayoutPanelOrgBase.Controls.Add(this.orgDateTimePickerStart);
            this.flowLayoutPanelOrgBase.Controls.Add(this.orgDateTimePickerEnd);
            this.flowLayoutPanelOrgBase.Controls.Add(this.orgDateTimePickerCalendar);
            this.flowLayoutPanelOrgBase.Controls.Add(this.orgLabelInfoGroup);
            this.flowLayoutPanelOrgBase.Controls.Add(this.orgToggleButtonGroup);
            this.flowLayoutPanelOrgBase.Location = new System.Drawing.Point(417, 8);
            this.flowLayoutPanelOrgBase.Name = "flowLayoutPanelOrgBase";
            this.flowLayoutPanelOrgBase.Size = new System.Drawing.Size(878, 34);
            this.flowLayoutPanelOrgBase.TabIndex = 29;
            // 
            // orgDateTimePickerStart
            // 
            this.orgDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.orgDateTimePickerStart.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.orgDateTimePickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgDateTimePickerStart.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.orgDateTimePickerStart.Location = new System.Drawing.Point(54, 3);
            this.orgDateTimePickerStart.Name = "orgDateTimePickerStart";
            this.orgDateTimePickerStart.Size = new System.Drawing.Size(220, 27);
            this.orgDateTimePickerStart.TabIndex = 22;
            this.orgDateTimePickerStart.Visible = false;
            this.orgDateTimePickerStart.ValueChanged += new System.EventHandler(this.orgDateTimePickerStart_ValueChanged);
            // 
            // orgDateTimePickerEnd
            // 
            this.orgDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.orgDateTimePickerEnd.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.orgDateTimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgDateTimePickerEnd.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.orgDateTimePickerEnd.Location = new System.Drawing.Point(280, 3);
            this.orgDateTimePickerEnd.Name = "orgDateTimePickerEnd";
            this.orgDateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.orgDateTimePickerEnd.TabIndex = 23;
            this.orgDateTimePickerEnd.Visible = false;
            // 
            // orgDateTimePickerCalendar
            // 
            this.orgDateTimePickerCalendar.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgDateTimePickerCalendar.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.orgDateTimePickerCalendar.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.orgDateTimePickerCalendar.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgDateTimePickerCalendar.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.orgDateTimePickerCalendar.CustomFormat = "MMMM yyyy";
            this.orgDateTimePickerCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orgDateTimePickerCalendar.Location = new System.Drawing.Point(486, 3);
            this.orgDateTimePickerCalendar.Name = "orgDateTimePickerCalendar";
            this.orgDateTimePickerCalendar.ShowUpDown = true;
            this.orgDateTimePickerCalendar.Size = new System.Drawing.Size(200, 27);
            this.orgDateTimePickerCalendar.TabIndex = 27;
            // 
            // orgLabelInfoGroup
            // 
            this.orgLabelInfoGroup.AutoSize = true;
            this.orgLabelInfoGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgLabelInfoGroup.ForeColor = System.Drawing.Color.Gainsboro;
            this.orgLabelInfoGroup.Location = new System.Drawing.Point(694, 6);
            this.orgLabelInfoGroup.Margin = new System.Windows.Forms.Padding(5, 6, 2, 0);
            this.orgLabelInfoGroup.Name = "orgLabelInfoGroup";
            this.orgLabelInfoGroup.Size = new System.Drawing.Size(105, 20);
            this.orgLabelInfoGroup.TabIndex = 33;
            this.orgLabelInfoGroup.Text = "Группировка:";
            // 
            // orgToggleButtonGroup
            // 
            this.orgToggleButtonGroup.AutoSize = true;
            this.orgToggleButtonGroup.DisableBackColor = System.Drawing.Color.DimGray;
            this.orgToggleButtonGroup.DisableToggleColor = System.Drawing.Color.Gray;
            this.orgToggleButtonGroup.Location = new System.Drawing.Point(804, 6);
            this.orgToggleButtonGroup.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.orgToggleButtonGroup.MinimumSize = new System.Drawing.Size(45, 22);
            this.orgToggleButtonGroup.Name = "orgToggleButtonGroup";
            this.orgToggleButtonGroup.OffBackColor = System.Drawing.Color.Firebrick;
            this.orgToggleButtonGroup.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.orgToggleButtonGroup.OnBackColor = System.Drawing.Color.SeaGreen;
            this.orgToggleButtonGroup.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.orgToggleButtonGroup.Size = new System.Drawing.Size(45, 22);
            this.orgToggleButtonGroup.TabIndex = 34;
            this.orgToggleButtonGroup.UseVisualStyleBackColor = true;
            this.orgToggleButtonGroup.CheckedChanged += new System.EventHandler(this.orgToggleButtonGroup_CheckedChanged);
            // 
            // btnLoadOrgs
            // 
            this.btnLoadOrgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadOrgs.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadOrgs.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadOrgs.BorderRadius = 6F;
            this.btnLoadOrgs.BorderSize = 0;
            this.btnLoadOrgs.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadOrgs.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadOrgs.FlatAppearance.BorderSize = 0;
            this.btnLoadOrgs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLoadOrgs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadOrgs.ForeColor = System.Drawing.Color.White;
            this.btnLoadOrgs.Image = global::WorldStat.Properties.Resources.sinchronize_24;
            this.btnLoadOrgs.Location = new System.Drawing.Point(1301, 4);
            this.btnLoadOrgs.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnLoadOrgs.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLoadOrgs.Name = "btnLoadOrgs";
            this.btnLoadOrgs.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadOrgs.Size = new System.Drawing.Size(40, 40);
            this.btnLoadOrgs.TabIndex = 26;
            this.btnLoadOrgs.TextColor = System.Drawing.Color.White;
            this.btnLoadOrgs.UseVisualStyleBackColor = false;
            this.btnLoadOrgs.Click += new System.EventHandler(this.btnLoadOrgs_Click);
            // 
            // orgComboBoxFirms
            // 
            this.orgComboBoxFirms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.orgComboBoxFirms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.orgComboBoxFirms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orgComboBoxFirms.DataSource = this.orgFirmBindingSource;
            this.orgComboBoxFirms.DisplayMember = "ShortName";
            this.orgComboBoxFirms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgComboBoxFirms.FormattingEnabled = true;
            this.orgComboBoxFirms.Location = new System.Drawing.Point(8, 10);
            this.orgComboBoxFirms.Name = "orgComboBoxFirms";
            this.orgComboBoxFirms.Size = new System.Drawing.Size(403, 28);
            this.orgComboBoxFirms.TabIndex = 24;
            this.orgComboBoxFirms.ValueMember = "Id";
            this.orgComboBoxFirms.Enter += new System.EventHandler(this.comboBoxFirms_Enter);
            // 
            // orgFirmBindingSource
            // 
            this.orgFirmBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.Firm);
            // 
            // tabIncomes
            // 
            this.tabIncomes.Controls.Add(this.incomePanelStat);
            this.tabIncomes.Controls.Add(this.incomeDataGridView);
            this.tabIncomes.Controls.Add(this.incomePanel);
            this.tabIncomes.Location = new System.Drawing.Point(4, 29);
            this.tabIncomes.Name = "tabIncomes";
            this.tabIncomes.Size = new System.Drawing.Size(1349, 373);
            this.tabIncomes.TabIndex = 4;
            this.tabIncomes.Text = "Доход";
            this.tabIncomes.UseVisualStyleBackColor = true;
            // 
            // incomePanelStat
            // 
            this.incomePanelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.incomePanelStat.Controls.Add(this.incomeLabelPosCount);
            this.incomePanelStat.Controls.Add(this.incomeLabelInfoPosCount);
            this.incomePanelStat.Controls.Add(this.incomeLabelPay);
            this.incomePanelStat.Controls.Add(this.incomeLabelCount);
            this.incomePanelStat.Controls.Add(this.incomeLabelInfoPay);
            this.incomePanelStat.Controls.Add(this.incomeLabelInfoCount);
            this.incomePanelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.incomePanelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.incomePanelStat.Location = new System.Drawing.Point(0, 343);
            this.incomePanelStat.Name = "incomePanelStat";
            this.incomePanelStat.Size = new System.Drawing.Size(1349, 30);
            this.incomePanelStat.TabIndex = 12;
            // 
            // incomeLabelPosCount
            // 
            this.incomeLabelPosCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeLabelPosCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.incomeLabelPosCount.Location = new System.Drawing.Point(731, 5);
            this.incomeLabelPosCount.Name = "incomeLabelPosCount";
            this.incomeLabelPosCount.Size = new System.Drawing.Size(140, 20);
            this.incomeLabelPosCount.TabIndex = 3;
            this.incomeLabelPosCount.Text = "0";
            // 
            // incomeLabelInfoPosCount
            // 
            this.incomeLabelInfoPosCount.AutoSize = true;
            this.incomeLabelInfoPosCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeLabelInfoPosCount.Location = new System.Drawing.Point(649, 5);
            this.incomeLabelInfoPosCount.Name = "incomeLabelInfoPosCount";
            this.incomeLabelInfoPosCount.Size = new System.Drawing.Size(76, 20);
            this.incomeLabelInfoPosCount.TabIndex = 2;
            this.incomeLabelInfoPosCount.Text = "Позиций:";
            // 
            // incomeLabelPay
            // 
            this.incomeLabelPay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeLabelPay.ForeColor = System.Drawing.Color.DarkOrange;
            this.incomeLabelPay.Location = new System.Drawing.Point(461, 5);
            this.incomeLabelPay.Name = "incomeLabelPay";
            this.incomeLabelPay.Size = new System.Drawing.Size(140, 20);
            this.incomeLabelPay.TabIndex = 1;
            this.incomeLabelPay.Text = "0,00 ₽";
            // 
            // incomeLabelCount
            // 
            this.incomeLabelCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeLabelCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.incomeLabelCount.Location = new System.Drawing.Point(122, 5);
            this.incomeLabelCount.Name = "incomeLabelCount";
            this.incomeLabelCount.Size = new System.Drawing.Size(140, 20);
            this.incomeLabelCount.TabIndex = 0;
            this.incomeLabelCount.Text = "0";
            // 
            // incomeLabelInfoPay
            // 
            this.incomeLabelInfoPay.AutoSize = true;
            this.incomeLabelInfoPay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeLabelInfoPay.Location = new System.Drawing.Point(395, 5);
            this.incomeLabelInfoPay.Name = "incomeLabelInfoPay";
            this.incomeLabelInfoPay.Size = new System.Drawing.Size(60, 20);
            this.incomeLabelInfoPay.TabIndex = 0;
            this.incomeLabelInfoPay.Text = "Сумма:";
            // 
            // incomeLabelInfoCount
            // 
            this.incomeLabelInfoCount.AutoSize = true;
            this.incomeLabelInfoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeLabelInfoCount.Location = new System.Drawing.Point(21, 5);
            this.incomeLabelInfoCount.Name = "incomeLabelInfoCount";
            this.incomeLabelInfoCount.Size = new System.Drawing.Size(95, 20);
            this.incomeLabelInfoCount.TabIndex = 0;
            this.incomeLabelInfoCount.Text = "Количество:";
            // 
            // incomeDataGridView
            // 
            this.incomeDataGridView.AllowUserToAddRows = false;
            this.incomeDataGridView.AllowUserToDeleteRows = false;
            this.incomeDataGridView.AllowUserToResizeColumns = false;
            this.incomeDataGridView.AllowUserToResizeRows = false;
            this.incomeDataGridView.AutoGenerateColumns = false;
            this.incomeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incomeDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.incomeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.incomeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.incomeDataGridView.ColumnHeadersHeight = 40;
            this.incomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.incomeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incomeColumnDate,
            this.incomeColumnName,
            this.incomeColumnCount,
            this.incomeColumnPay});
            this.incomeDataGridView.DataSource = this.incomeReportPosBindingSource;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.incomeDataGridView.DefaultCellStyle = dataGridViewCellStyle16;
            this.incomeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomeDataGridView.EnableHeadersVisualStyles = false;
            this.incomeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.incomeDataGridView.Location = new System.Drawing.Point(0, 92);
            this.incomeDataGridView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.incomeDataGridView.Name = "incomeDataGridView";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.incomeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.incomeDataGridView.RowHeadersVisible = false;
            this.incomeDataGridView.RowHeadersWidth = 40;
            this.incomeDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.incomeDataGridView.RowTemplate.Height = 40;
            this.incomeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.incomeDataGridView.Size = new System.Drawing.Size(1349, 281);
            this.incomeDataGridView.TabIndex = 11;
            this.incomeDataGridView.TabStop = false;
            this.incomeDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            // 
            // incomeColumnDate
            // 
            this.incomeColumnDate.DataPropertyName = "DateText";
            this.incomeColumnDate.HeaderText = "Дата";
            this.incomeColumnDate.Name = "incomeColumnDate";
            this.incomeColumnDate.ReadOnly = true;
            // 
            // incomeColumnName
            // 
            this.incomeColumnName.DataPropertyName = "FirmName";
            this.incomeColumnName.HeaderText = "Организация";
            this.incomeColumnName.Name = "incomeColumnName";
            this.incomeColumnName.ReadOnly = true;
            // 
            // incomeColumnCount
            // 
            this.incomeColumnCount.DataPropertyName = "Count";
            this.incomeColumnCount.HeaderText = "Количество";
            this.incomeColumnCount.Name = "incomeColumnCount";
            this.incomeColumnCount.ReadOnly = true;
            // 
            // incomeColumnPay
            // 
            this.incomeColumnPay.DataPropertyName = "Pay";
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.incomeColumnPay.DefaultCellStyle = dataGridViewCellStyle15;
            this.incomeColumnPay.HeaderText = "Плата";
            this.incomeColumnPay.Name = "incomeColumnPay";
            this.incomeColumnPay.ReadOnly = true;
            // 
            // incomeReportPosBindingSource
            // 
            this.incomeReportPosBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.ReportPos);
            // 
            // incomePanel
            // 
            this.incomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.incomePanel.Controls.Add(this.flowLayoutPanel1);
            this.incomePanel.Controls.Add(this.flowLayoutPanel2);
            this.incomePanel.Controls.Add(this.btnLoadIncomes);
            this.incomePanel.Controls.Add(this.incomeComboBoxFirms);
            this.incomePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.incomePanel.Location = new System.Drawing.Point(0, 0);
            this.incomePanel.Name = "incomePanel";
            this.incomePanel.Size = new System.Drawing.Size(1349, 92);
            this.incomePanel.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.incomeLabelInfoMailType);
            this.flowLayoutPanel1.Controls.Add(this.incomeComboBoxMailType);
            this.flowLayoutPanel1.Controls.Add(this.incomeLabelInfoMailCategory);
            this.flowLayoutPanel1.Controls.Add(this.incomeComboBoxMailCategory);
            this.flowLayoutPanel1.Controls.Add(this.incomeLabelInfoTransCategory);
            this.flowLayoutPanel1.Controls.Add(this.incomeComboBoxTransCategory);
            this.flowLayoutPanel1.Controls.Add(this.incomeLabelInfoTransType);
            this.flowLayoutPanel1.Controls.Add(this.incomeComboBoxTransType);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1333, 34);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // incomeLabelInfoMailType
            // 
            this.incomeLabelInfoMailType.AutoSize = true;
            this.incomeLabelInfoMailType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeLabelInfoMailType.ForeColor = System.Drawing.Color.Gainsboro;
            this.incomeLabelInfoMailType.Location = new System.Drawing.Point(0, 6);
            this.incomeLabelInfoMailType.Margin = new System.Windows.Forms.Padding(0, 6, 2, 0);
            this.incomeLabelInfoMailType.Name = "incomeLabelInfoMailType";
            this.incomeLabelInfoMailType.Size = new System.Drawing.Size(38, 20);
            this.incomeLabelInfoMailType.TabIndex = 30;
            this.incomeLabelInfoMailType.Text = "Тип:";
            // 
            // incomeComboBoxMailType
            // 
            this.incomeComboBoxMailType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.incomeComboBoxMailType.DataSource = this.incomeAcitveMailTypeBindingSource;
            this.incomeComboBoxMailType.DisplayMember = "ShortName";
            this.incomeComboBoxMailType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.incomeComboBoxMailType.FormattingEnabled = true;
            this.incomeComboBoxMailType.Location = new System.Drawing.Point(43, 3);
            this.incomeComboBoxMailType.Name = "incomeComboBoxMailType";
            this.incomeComboBoxMailType.Size = new System.Drawing.Size(257, 28);
            this.incomeComboBoxMailType.TabIndex = 31;
            this.incomeComboBoxMailType.ValueMember = "Code";
            // 
            // incomeAcitveMailTypeBindingSource
            // 
            this.incomeAcitveMailTypeBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.MailType);
            // 
            // incomeLabelInfoMailCategory
            // 
            this.incomeLabelInfoMailCategory.AutoSize = true;
            this.incomeLabelInfoMailCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeLabelInfoMailCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.incomeLabelInfoMailCategory.Location = new System.Drawing.Point(308, 6);
            this.incomeLabelInfoMailCategory.Margin = new System.Windows.Forms.Padding(5, 6, 2, 0);
            this.incomeLabelInfoMailCategory.Name = "incomeLabelInfoMailCategory";
            this.incomeLabelInfoMailCategory.Size = new System.Drawing.Size(85, 20);
            this.incomeLabelInfoMailCategory.TabIndex = 30;
            this.incomeLabelInfoMailCategory.Text = "Категория:";
            // 
            // incomeComboBoxMailCategory
            // 
            this.incomeComboBoxMailCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.incomeComboBoxMailCategory.DataSource = this.incomeActiveMailCategoryBindingSource;
            this.incomeComboBoxMailCategory.DisplayMember = "ShortName";
            this.incomeComboBoxMailCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.incomeComboBoxMailCategory.FormattingEnabled = true;
            this.incomeComboBoxMailCategory.Location = new System.Drawing.Point(398, 3);
            this.incomeComboBoxMailCategory.Name = "incomeComboBoxMailCategory";
            this.incomeComboBoxMailCategory.Size = new System.Drawing.Size(215, 28);
            this.incomeComboBoxMailCategory.TabIndex = 31;
            this.incomeComboBoxMailCategory.ValueMember = "Code";
            // 
            // incomeActiveMailCategoryBindingSource
            // 
            this.incomeActiveMailCategoryBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.MailCategory);
            // 
            // incomeLabelInfoTransCategory
            // 
            this.incomeLabelInfoTransCategory.AutoSize = true;
            this.incomeLabelInfoTransCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeLabelInfoTransCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.incomeLabelInfoTransCategory.Location = new System.Drawing.Point(621, 6);
            this.incomeLabelInfoTransCategory.Margin = new System.Windows.Forms.Padding(5, 6, 2, 0);
            this.incomeLabelInfoTransCategory.Name = "incomeLabelInfoTransCategory";
            this.incomeLabelInfoTransCategory.Size = new System.Drawing.Size(53, 20);
            this.incomeLabelInfoTransCategory.TabIndex = 34;
            this.incomeLabelInfoTransCategory.Text = "Класс:";
            // 
            // incomeComboBoxTransCategory
            // 
            this.incomeComboBoxTransCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.incomeComboBoxTransCategory.DisplayMember = "Code";
            this.incomeComboBoxTransCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.incomeComboBoxTransCategory.FormattingEnabled = true;
            this.incomeComboBoxTransCategory.Location = new System.Drawing.Point(679, 3);
            this.incomeComboBoxTransCategory.Name = "incomeComboBoxTransCategory";
            this.incomeComboBoxTransCategory.Size = new System.Drawing.Size(180, 28);
            this.incomeComboBoxTransCategory.TabIndex = 35;
            this.incomeComboBoxTransCategory.ValueMember = "Code";
            // 
            // incomeLabelInfoTransType
            // 
            this.incomeLabelInfoTransType.AutoSize = true;
            this.incomeLabelInfoTransType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeLabelInfoTransType.ForeColor = System.Drawing.Color.Gainsboro;
            this.incomeLabelInfoTransType.Location = new System.Drawing.Point(867, 6);
            this.incomeLabelInfoTransType.Margin = new System.Windows.Forms.Padding(5, 6, 2, 0);
            this.incomeLabelInfoTransType.Name = "incomeLabelInfoTransType";
            this.incomeLabelInfoTransType.Size = new System.Drawing.Size(91, 20);
            this.incomeLabelInfoTransType.TabIndex = 32;
            this.incomeLabelInfoTransType.Text = "Пересылка:";
            // 
            // incomeComboBoxTransType
            // 
            this.incomeComboBoxTransType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.incomeComboBoxTransType.DisplayMember = "Code";
            this.incomeComboBoxTransType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.incomeComboBoxTransType.FormattingEnabled = true;
            this.incomeComboBoxTransType.Location = new System.Drawing.Point(963, 3);
            this.incomeComboBoxTransType.Name = "incomeComboBoxTransType";
            this.incomeComboBoxTransType.Size = new System.Drawing.Size(180, 28);
            this.incomeComboBoxTransType.TabIndex = 33;
            this.incomeComboBoxTransType.ValueMember = "Code";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.incomeToggleButtonCalendar);
            this.flowLayoutPanel2.Controls.Add(this.incomeDateTimePickerStart);
            this.flowLayoutPanel2.Controls.Add(this.incomeDateTimePickerEnd);
            this.flowLayoutPanel2.Controls.Add(this.incomeDateTimePickerCalendar);
            this.flowLayoutPanel2.Controls.Add(this.incomeLabelInfoGroup);
            this.flowLayoutPanel2.Controls.Add(this.incomeToggleButtonGroup);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(417, 8);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(878, 34);
            this.flowLayoutPanel2.TabIndex = 29;
            // 
            // incomeToggleButtonCalendar
            // 
            this.incomeToggleButtonCalendar.AutoSize = true;
            this.incomeToggleButtonCalendar.Checked = true;
            this.incomeToggleButtonCalendar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.incomeToggleButtonCalendar.DisableBackColor = System.Drawing.Color.DimGray;
            this.incomeToggleButtonCalendar.DisableToggleColor = System.Drawing.Color.Gray;
            this.incomeToggleButtonCalendar.Location = new System.Drawing.Point(3, 6);
            this.incomeToggleButtonCalendar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.incomeToggleButtonCalendar.MinimumSize = new System.Drawing.Size(45, 22);
            this.incomeToggleButtonCalendar.Name = "incomeToggleButtonCalendar";
            this.incomeToggleButtonCalendar.OffBackColor = System.Drawing.Color.DimGray;
            this.incomeToggleButtonCalendar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.incomeToggleButtonCalendar.OnBackColor = System.Drawing.Color.SeaGreen;
            this.incomeToggleButtonCalendar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.incomeToggleButtonCalendar.Size = new System.Drawing.Size(45, 22);
            this.incomeToggleButtonCalendar.TabIndex = 28;
            this.incomeToggleButtonCalendar.UseVisualStyleBackColor = true;
            this.incomeToggleButtonCalendar.CheckedChanged += new System.EventHandler(this.incomeToggleButtonCalendar_CheckedChanged);
            // 
            // incomeDateTimePickerStart
            // 
            this.incomeDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.incomeDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.incomeDateTimePickerStart.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.incomeDateTimePickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.incomeDateTimePickerStart.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.incomeDateTimePickerStart.Location = new System.Drawing.Point(54, 3);
            this.incomeDateTimePickerStart.Name = "incomeDateTimePickerStart";
            this.incomeDateTimePickerStart.Size = new System.Drawing.Size(220, 27);
            this.incomeDateTimePickerStart.TabIndex = 22;
            this.incomeDateTimePickerStart.Visible = false;
            this.incomeDateTimePickerStart.ValueChanged += new System.EventHandler(this.incomeDateTimePickerStart_ValueChanged);
            // 
            // incomeDateTimePickerEnd
            // 
            this.incomeDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.incomeDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.incomeDateTimePickerEnd.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.incomeDateTimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.incomeDateTimePickerEnd.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.incomeDateTimePickerEnd.Location = new System.Drawing.Point(280, 3);
            this.incomeDateTimePickerEnd.Name = "incomeDateTimePickerEnd";
            this.incomeDateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.incomeDateTimePickerEnd.TabIndex = 23;
            this.incomeDateTimePickerEnd.Visible = false;
            // 
            // incomeDateTimePickerCalendar
            // 
            this.incomeDateTimePickerCalendar.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.incomeDateTimePickerCalendar.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.incomeDateTimePickerCalendar.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.incomeDateTimePickerCalendar.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.incomeDateTimePickerCalendar.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.incomeDateTimePickerCalendar.CustomFormat = "MMMM yyyy";
            this.incomeDateTimePickerCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.incomeDateTimePickerCalendar.Location = new System.Drawing.Point(486, 3);
            this.incomeDateTimePickerCalendar.Name = "incomeDateTimePickerCalendar";
            this.incomeDateTimePickerCalendar.ShowUpDown = true;
            this.incomeDateTimePickerCalendar.Size = new System.Drawing.Size(200, 27);
            this.incomeDateTimePickerCalendar.TabIndex = 27;
            // 
            // incomeLabelInfoGroup
            // 
            this.incomeLabelInfoGroup.AutoSize = true;
            this.incomeLabelInfoGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeLabelInfoGroup.ForeColor = System.Drawing.Color.Gainsboro;
            this.incomeLabelInfoGroup.Location = new System.Drawing.Point(694, 6);
            this.incomeLabelInfoGroup.Margin = new System.Windows.Forms.Padding(5, 6, 2, 0);
            this.incomeLabelInfoGroup.Name = "incomeLabelInfoGroup";
            this.incomeLabelInfoGroup.Size = new System.Drawing.Size(105, 20);
            this.incomeLabelInfoGroup.TabIndex = 33;
            this.incomeLabelInfoGroup.Text = "Группировка:";
            // 
            // incomeToggleButtonGroup
            // 
            this.incomeToggleButtonGroup.AutoSize = true;
            this.incomeToggleButtonGroup.DisableBackColor = System.Drawing.Color.DimGray;
            this.incomeToggleButtonGroup.DisableToggleColor = System.Drawing.Color.Gray;
            this.incomeToggleButtonGroup.Location = new System.Drawing.Point(804, 6);
            this.incomeToggleButtonGroup.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.incomeToggleButtonGroup.MinimumSize = new System.Drawing.Size(45, 22);
            this.incomeToggleButtonGroup.Name = "incomeToggleButtonGroup";
            this.incomeToggleButtonGroup.OffBackColor = System.Drawing.Color.Firebrick;
            this.incomeToggleButtonGroup.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.incomeToggleButtonGroup.OnBackColor = System.Drawing.Color.SeaGreen;
            this.incomeToggleButtonGroup.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.incomeToggleButtonGroup.Size = new System.Drawing.Size(45, 22);
            this.incomeToggleButtonGroup.TabIndex = 34;
            this.incomeToggleButtonGroup.UseVisualStyleBackColor = true;
            this.incomeToggleButtonGroup.CheckedChanged += new System.EventHandler(this.incomeToggleButtonGroup_CheckedChanged);
            // 
            // btnLoadIncomes
            // 
            this.btnLoadIncomes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadIncomes.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadIncomes.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadIncomes.BorderRadius = 6F;
            this.btnLoadIncomes.BorderSize = 0;
            this.btnLoadIncomes.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadIncomes.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadIncomes.FlatAppearance.BorderSize = 0;
            this.btnLoadIncomes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLoadIncomes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadIncomes.ForeColor = System.Drawing.Color.White;
            this.btnLoadIncomes.Image = global::WorldStat.Properties.Resources.sinchronize_24;
            this.btnLoadIncomes.Location = new System.Drawing.Point(1301, 4);
            this.btnLoadIncomes.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnLoadIncomes.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLoadIncomes.Name = "btnLoadIncomes";
            this.btnLoadIncomes.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadIncomes.Size = new System.Drawing.Size(40, 40);
            this.btnLoadIncomes.TabIndex = 26;
            this.btnLoadIncomes.TextColor = System.Drawing.Color.White;
            this.btnLoadIncomes.UseVisualStyleBackColor = false;
            this.btnLoadIncomes.Click += new System.EventHandler(this.btnLoadIncomes_Click);
            // 
            // incomeComboBoxFirms
            // 
            this.incomeComboBoxFirms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.incomeComboBoxFirms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.incomeComboBoxFirms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.incomeComboBoxFirms.DataSource = this.incomeFirmBindingSource;
            this.incomeComboBoxFirms.DisplayMember = "ShortName";
            this.incomeComboBoxFirms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.incomeComboBoxFirms.FormattingEnabled = true;
            this.incomeComboBoxFirms.Location = new System.Drawing.Point(8, 10);
            this.incomeComboBoxFirms.Name = "incomeComboBoxFirms";
            this.incomeComboBoxFirms.Size = new System.Drawing.Size(403, 28);
            this.incomeComboBoxFirms.TabIndex = 24;
            this.incomeComboBoxFirms.ValueMember = "Id";
            this.incomeComboBoxFirms.Enter += new System.EventHandler(this.comboBoxFirms_Enter);
            // 
            // incomeFirmBindingSource
            // 
            this.incomeFirmBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.Firm);
            // 
            // tabStats
            // 
            this.tabStats.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabStats.Controls.Add(this.statDataGridView);
            this.tabStats.Controls.Add(this.panelStat);
            this.tabStats.Location = new System.Drawing.Point(4, 29);
            this.tabStats.Name = "tabStats";
            this.tabStats.Size = new System.Drawing.Size(1349, 373);
            this.tabStats.TabIndex = 2;
            this.tabStats.Text = "Статистика";
            // 
            // statDataGridView
            // 
            this.statDataGridView.AllowUserToAddRows = false;
            this.statDataGridView.AllowUserToDeleteRows = false;
            this.statDataGridView.AllowUserToResizeColumns = false;
            this.statDataGridView.AllowUserToResizeRows = false;
            this.statDataGridView.AutoGenerateColumns = false;
            this.statDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.statDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.statDataGridView.ColumnHeadersHeight = 40;
            this.statDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.statDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statColumnName,
            this.statColumnDescription,
            this.statColumnCount,
            this.statColumnPay});
            this.statDataGridView.DataSource = this.dispathReportBindingSource;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statDataGridView.DefaultCellStyle = dataGridViewCellStyle19;
            this.statDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statDataGridView.EnableHeadersVisualStyles = false;
            this.statDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.statDataGridView.Location = new System.Drawing.Point(0, 48);
            this.statDataGridView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.statDataGridView.Name = "statDataGridView";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.statDataGridView.RowHeadersVisible = false;
            this.statDataGridView.RowHeadersWidth = 40;
            this.statDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.statDataGridView.RowTemplate.Height = 40;
            this.statDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.statDataGridView.Size = new System.Drawing.Size(1349, 325);
            this.statDataGridView.TabIndex = 12;
            this.statDataGridView.TabStop = false;
            this.statDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.statDataGridView_CellFormatting);
            // 
            // statColumnName
            // 
            this.statColumnName.DataPropertyName = "Name";
            this.statColumnName.HeaderText = "Название";
            this.statColumnName.Name = "statColumnName";
            this.statColumnName.ReadOnly = true;
            // 
            // statColumnDescription
            // 
            this.statColumnDescription.DataPropertyName = "Description";
            this.statColumnDescription.HeaderText = "Описание";
            this.statColumnDescription.Name = "statColumnDescription";
            this.statColumnDescription.ReadOnly = true;
            // 
            // statColumnCount
            // 
            this.statColumnCount.DataPropertyName = "CountText";
            this.statColumnCount.HeaderText = "Количество";
            this.statColumnCount.Name = "statColumnCount";
            this.statColumnCount.ReadOnly = true;
            // 
            // statColumnPay
            // 
            this.statColumnPay.DataPropertyName = "PayText";
            this.statColumnPay.HeaderText = "Плата";
            this.statColumnPay.Name = "statColumnPay";
            this.statColumnPay.ReadOnly = true;
            // 
            // dispathReportBindingSource
            // 
            this.dispathReportBindingSource.DataSource = typeof(WorldStat.Core.Reports.Models.DispathReport);
            // 
            // panelStat
            // 
            this.panelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelStat.Controls.Add(this.flowLayoutPanel4);
            this.panelStat.Controls.Add(this.btnLoadStat);
            this.panelStat.Controls.Add(this.statComboBoxFirms);
            this.panelStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStat.Location = new System.Drawing.Point(0, 0);
            this.panelStat.Name = "panelStat";
            this.panelStat.Size = new System.Drawing.Size(1349, 48);
            this.panelStat.TabIndex = 5;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.Controls.Add(this.statToggleButtonCalendar);
            this.flowLayoutPanel4.Controls.Add(this.statDateTimePickerStart);
            this.flowLayoutPanel4.Controls.Add(this.statDateTimePickerEnd);
            this.flowLayoutPanel4.Controls.Add(this.statDateTimePickerCalendar);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(417, 8);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(878, 34);
            this.flowLayoutPanel4.TabIndex = 29;
            // 
            // statToggleButtonCalendar
            // 
            this.statToggleButtonCalendar.AutoSize = true;
            this.statToggleButtonCalendar.Checked = true;
            this.statToggleButtonCalendar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statToggleButtonCalendar.DisableBackColor = System.Drawing.Color.DimGray;
            this.statToggleButtonCalendar.DisableToggleColor = System.Drawing.Color.Gray;
            this.statToggleButtonCalendar.Location = new System.Drawing.Point(3, 6);
            this.statToggleButtonCalendar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.statToggleButtonCalendar.MinimumSize = new System.Drawing.Size(45, 22);
            this.statToggleButtonCalendar.Name = "statToggleButtonCalendar";
            this.statToggleButtonCalendar.OffBackColor = System.Drawing.Color.DimGray;
            this.statToggleButtonCalendar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.statToggleButtonCalendar.OnBackColor = System.Drawing.Color.SeaGreen;
            this.statToggleButtonCalendar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.statToggleButtonCalendar.Size = new System.Drawing.Size(45, 22);
            this.statToggleButtonCalendar.TabIndex = 28;
            this.statToggleButtonCalendar.UseVisualStyleBackColor = true;
            this.statToggleButtonCalendar.CheckedChanged += new System.EventHandler(this.statToggleButtonCalendar_CheckedChanged);
            // 
            // statDateTimePickerStart
            // 
            this.statDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.statDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.statDateTimePickerStart.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.statDateTimePickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.statDateTimePickerStart.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.statDateTimePickerStart.Location = new System.Drawing.Point(54, 3);
            this.statDateTimePickerStart.Name = "statDateTimePickerStart";
            this.statDateTimePickerStart.Size = new System.Drawing.Size(220, 27);
            this.statDateTimePickerStart.TabIndex = 22;
            this.statDateTimePickerStart.Visible = false;
            this.statDateTimePickerStart.ValueChanged += new System.EventHandler(this.statDateTimePickerStart_ValueChanged);
            // 
            // statDateTimePickerEnd
            // 
            this.statDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.statDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.statDateTimePickerEnd.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.statDateTimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.statDateTimePickerEnd.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.statDateTimePickerEnd.Location = new System.Drawing.Point(280, 3);
            this.statDateTimePickerEnd.Name = "statDateTimePickerEnd";
            this.statDateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.statDateTimePickerEnd.TabIndex = 23;
            this.statDateTimePickerEnd.Visible = false;
            // 
            // statDateTimePickerCalendar
            // 
            this.statDateTimePickerCalendar.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.statDateTimePickerCalendar.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.statDateTimePickerCalendar.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.statDateTimePickerCalendar.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.statDateTimePickerCalendar.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.statDateTimePickerCalendar.CustomFormat = "MMMM yyyy";
            this.statDateTimePickerCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.statDateTimePickerCalendar.Location = new System.Drawing.Point(486, 3);
            this.statDateTimePickerCalendar.Name = "statDateTimePickerCalendar";
            this.statDateTimePickerCalendar.ShowUpDown = true;
            this.statDateTimePickerCalendar.Size = new System.Drawing.Size(200, 27);
            this.statDateTimePickerCalendar.TabIndex = 27;
            // 
            // btnLoadStat
            // 
            this.btnLoadStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadStat.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadStat.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadStat.BorderRadius = 6F;
            this.btnLoadStat.BorderSize = 0;
            this.btnLoadStat.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadStat.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadStat.FlatAppearance.BorderSize = 0;
            this.btnLoadStat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLoadStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadStat.ForeColor = System.Drawing.Color.White;
            this.btnLoadStat.Image = global::WorldStat.Properties.Resources.sinchronize_24;
            this.btnLoadStat.Location = new System.Drawing.Point(1301, 4);
            this.btnLoadStat.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnLoadStat.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLoadStat.Name = "btnLoadStat";
            this.btnLoadStat.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadStat.Size = new System.Drawing.Size(40, 40);
            this.btnLoadStat.TabIndex = 26;
            this.btnLoadStat.TextColor = System.Drawing.Color.White;
            this.btnLoadStat.UseVisualStyleBackColor = false;
            this.btnLoadStat.Click += new System.EventHandler(this.btnLoadStat_Click);
            // 
            // statComboBoxFirms
            // 
            this.statComboBoxFirms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.statComboBoxFirms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statComboBoxFirms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statComboBoxFirms.DataSource = this.statFirmBindingSource;
            this.statComboBoxFirms.DisplayMember = "ShortName";
            this.statComboBoxFirms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.statComboBoxFirms.FormattingEnabled = true;
            this.statComboBoxFirms.Location = new System.Drawing.Point(8, 10);
            this.statComboBoxFirms.Name = "statComboBoxFirms";
            this.statComboBoxFirms.Size = new System.Drawing.Size(403, 28);
            this.statComboBoxFirms.TabIndex = 24;
            this.statComboBoxFirms.ValueMember = "Id";
            this.statComboBoxFirms.Enter += new System.EventHandler(this.comboBoxFirms_Enter);
            // 
            // statFirmBindingSource
            // 
            this.statFirmBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.Firm);
            // 
            // tabCharts
            // 
            this.tabCharts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCharts.Controls.Add(this.panelActive);
            this.tabCharts.Location = new System.Drawing.Point(4, 29);
            this.tabCharts.Name = "tabCharts";
            this.tabCharts.Size = new System.Drawing.Size(1349, 373);
            this.tabCharts.TabIndex = 3;
            this.tabCharts.Text = "Инфографика";
            // 
            // panelActive
            // 
            this.panelActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelActive.Controls.Add(this.btnActiveUserLoad);
            this.panelActive.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActive.Location = new System.Drawing.Point(0, 0);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(1349, 48);
            this.panelActive.TabIndex = 2;
            // 
            // btnActiveUserLoad
            // 
            this.btnActiveUserLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActiveUserLoad.BackColor = System.Drawing.Color.Brown;
            this.btnActiveUserLoad.FlatAppearance.BorderSize = 0;
            this.btnActiveUserLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnActiveUserLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiveUserLoad.ForeColor = System.Drawing.Color.White;
            this.btnActiveUserLoad.Location = new System.Drawing.Point(1305, 6);
            this.btnActiveUserLoad.Name = "btnActiveUserLoad";
            this.btnActiveUserLoad.Size = new System.Drawing.Size(36, 36);
            this.btnActiveUserLoad.TabIndex = 20;
            this.btnActiveUserLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActiveUserLoad.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn1.HeaderText = "Смена";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 472;
            // 
            // reportContextMenu
            // 
            this.reportContextMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportContextMenuUnload,
            this.reportContextMenuUnloadAll,
            this.toolStripSeparator1,
            this.reportContextMenuUploadYandexDisk});
            this.reportContextMenu.Name = "reportContextMenu";
            this.reportContextMenu.Size = new System.Drawing.Size(265, 82);
            // 
            // reportContextMenuUnload
            // 
            this.reportContextMenuUnload.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportContextMenuUnload.Name = "reportContextMenuUnload";
            this.reportContextMenuUnload.Size = new System.Drawing.Size(264, 24);
            this.reportContextMenuUnload.Text = "Выгрузить отчет";
            this.reportContextMenuUnload.Click += new System.EventHandler(this.reportContextMenuUnload_Click);
            // 
            // reportContextMenuUnloadAll
            // 
            this.reportContextMenuUnloadAll.Name = "reportContextMenuUnloadAll";
            this.reportContextMenuUnloadAll.Size = new System.Drawing.Size(264, 24);
            this.reportContextMenuUnloadAll.Text = "Выгрузить все отчеты";
            this.reportContextMenuUnloadAll.Click += new System.EventHandler(this.reportContextMenuUnloadAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // reportContextMenuUploadYandexDisk
            // 
            this.reportContextMenuUploadYandexDisk.Enabled = false;
            this.reportContextMenuUploadYandexDisk.Name = "reportContextMenuUploadYandexDisk";
            this.reportContextMenuUploadYandexDisk.Size = new System.Drawing.Size(264, 24);
            this.reportContextMenuUploadYandexDisk.Text = "Выгрузить отчет на Яндекс";
            this.reportContextMenuUploadYandexDisk.Click += new System.EventHandler(this.reportContextMenuUploadYandexDisk_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1357, 526);
            this.Controls.Add(this.tabsControl);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GeneralForm";
            this.Text = "WorldStat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopies)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabsControl.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.reportPanelStat.ResumeLayout(false);
            this.reportPanelStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.reportPanel.ResumeLayout(false);
            this.flowLayoutPanelReport.ResumeLayout(false);
            this.flowLayoutPanelReport.PerformLayout();
            this.tabOrgs.ResumeLayout(false);
            this.orgPanelStat.ResumeLayout(false);
            this.orgPanelStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgReportPosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocOrg)).EndInit();
            this.orgPanel.ResumeLayout(false);
            this.flowLayoutPanelOrgFilter.ResumeLayout(false);
            this.flowLayoutPanelOrgFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgAcitveMailTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgActiveMailCategoryBindingSource)).EndInit();
            this.flowLayoutPanelOrgBase.ResumeLayout(false);
            this.flowLayoutPanelOrgBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgFirmBindingSource)).EndInit();
            this.tabIncomes.ResumeLayout(false);
            this.incomePanelStat.ResumeLayout(false);
            this.incomePanelStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeReportPosBindingSource)).EndInit();
            this.incomePanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeAcitveMailTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeActiveMailCategoryBindingSource)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeFirmBindingSource)).EndInit();
            this.tabStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispathReportBindingSource)).EndInit();
            this.panelStat.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statFirmBindingSource)).EndInit();
            this.tabCharts.ResumeLayout(false);
            this.panelActive.ResumeLayout(false);
            this.reportContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFrankReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDbMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosMenuItem;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.TabPage tabStats;
        private System.Windows.Forms.TabPage tabOrgs;
        private System.Windows.Forms.DataGridView dataGridViewDocOrg;
        private System.Windows.Forms.Panel orgPanel;
        private System.Windows.Forms.DateTimePicker orgDateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker orgDateTimePickerStart;
        private System.Windows.Forms.TabPage tabCharts;
        private System.Windows.Forms.Panel panelActive;
        private System.Windows.Forms.Button btnActiveUserLoad;
        private System.Windows.Forms.DateTimePicker reportDateTimePickerCalendar;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private WcButton btnLoadReports;
        private System.Windows.Forms.Panel reportPanelStat;
        private System.Windows.Forms.Label reportLabelInfoCount;
        private System.Windows.Forms.Label reportLabelInfoPay;
        private System.Windows.Forms.Label reportLabelPay;
        private System.Windows.Forms.Label reportLabelCount;
        private System.Windows.Forms.ToolStripMenuItem importCalendarMenuItem;
        private System.Windows.Forms.Label reportLabelInfoTeam;
        private System.Windows.Forms.ComboBox reportComboBoxTeam;
        private System.Windows.Forms.ToolStripMenuItem firmsMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem mailCategoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailTypeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailCodeMenuItem;
        private System.Windows.Forms.Label reportLabelDaysCount;
        private System.Windows.Forms.Label reportLabelInfoDays;
        private System.Windows.Forms.ComboBox orgComboBoxFirms;
        private System.Windows.Forms.BindingSource orgFirmBindingSource;
        private System.Windows.Forms.Panel orgPanelStat;
        private System.Windows.Forms.Label orgLabelPay;
        private System.Windows.Forms.Label orgLabelCount;
        private System.Windows.Forms.Label orgLabelInfoPay;
        private System.Windows.Forms.Label orgLabelInfoCount;
        private System.Windows.Forms.DataGridView orgDataGridView;
        private WcButton btnLoadOrgs;
        private System.Windows.Forms.BindingSource orgReportPosBindingSource;
        private System.Windows.Forms.BindingSource incomeReportPosBindingSource;
        private System.Windows.Forms.BindingSource mailTypeBindingSource;
        private System.Windows.Forms.BindingSource mailCategoryBindingSource;
        private System.Windows.Forms.DateTimePicker orgDateTimePickerCalendar;
        private WcToggleButton orgToggleButtonCalendar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrgBase;
        private System.Windows.Forms.ComboBox orgComboBoxMailCategory;
        private System.Windows.Forms.ComboBox orgComboBoxMailType;
        private System.Windows.Forms.Label orgLabelInfoMailCategory;
        private System.Windows.Forms.Label orgLabelInfoMailType;
        private System.Windows.Forms.BindingSource orgAcitveMailTypeBindingSource;
        private System.Windows.Forms.BindingSource orgActiveMailCategoryBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReport;
        private System.Windows.Forms.DateTimePicker reportDateTimePickerStart;
        private System.Windows.Forms.DateTimePicker reportDateTimePickerEnd;
        private WcToggleButton reportToggleButton;
        private System.Windows.Forms.Label orgLabelInfoTransType;
        private System.Windows.Forms.ComboBox orgComboBoxTransType;
        private System.Windows.Forms.ComboBox orgComboBoxTransCategory;
        private System.Windows.Forms.Label orgLabelInfoTransCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrgFilter;
        private System.Windows.Forms.Label orgLabelInfoGroup;
        private WcToggleButton orgToggleButtonGroup;
        private System.Windows.Forms.TabPage tabIncomes;
        private System.Windows.Forms.DataGridView incomeDataGridView;
        private System.Windows.Forms.Panel incomePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label incomeLabelInfoMailType;
        private System.Windows.Forms.ComboBox incomeComboBoxMailType;
        private System.Windows.Forms.Label incomeLabelInfoMailCategory;
        private System.Windows.Forms.ComboBox incomeComboBoxMailCategory;
        private System.Windows.Forms.Label incomeLabelInfoTransCategory;
        private System.Windows.Forms.ComboBox incomeComboBoxTransCategory;
        private System.Windows.Forms.Label incomeLabelInfoTransType;
        private System.Windows.Forms.ComboBox incomeComboBoxTransType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private WcToggleButton incomeToggleButtonCalendar;
        private System.Windows.Forms.DateTimePicker incomeDateTimePickerStart;
        private System.Windows.Forms.DateTimePicker incomeDateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker incomeDateTimePickerCalendar;
        private WcButton btnLoadIncomes;
        private System.Windows.Forms.ComboBox incomeComboBoxFirms;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportColumnDayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportColumnPay;
        private System.Windows.Forms.Label orgLabelPosCount;
        private System.Windows.Forms.Label orgLabelInfoPosCount;
        private System.Windows.Forms.Panel incomePanelStat;
        private System.Windows.Forms.Label incomeLabelPosCount;
        private System.Windows.Forms.Label incomeLabelInfoPosCount;
        private System.Windows.Forms.Label incomeLabelPay;
        private System.Windows.Forms.Label incomeLabelCount;
        private System.Windows.Forms.Label incomeLabelInfoPay;
        private System.Windows.Forms.Label incomeLabelInfoCount;
        private System.Windows.Forms.Label incomeLabelInfoGroup;
        private WcToggleButton incomeToggleButtonGroup;
        private System.Windows.Forms.BindingSource incomeFirmBindingSource;
        private System.Windows.Forms.BindingSource incomeAcitveMailTypeBindingSource;
        private System.Windows.Forms.BindingSource incomeActiveMailCategoryBindingSource;
        private System.Windows.Forms.Panel panelStat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private WcToggleButton statToggleButtonCalendar;
        private System.Windows.Forms.DateTimePicker statDateTimePickerStart;
        private System.Windows.Forms.DateTimePicker statDateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker statDateTimePickerCalendar;
        private WcButton btnLoadStat;
        private System.Windows.Forms.ComboBox statComboBoxFirms;
        private System.Windows.Forms.DataGridView statDataGridView;
        private System.Windows.Forms.BindingSource statFirmBindingSource;
        private System.Windows.Forms.BindingSource dispathReportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn statColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn statColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn statColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn statColumnPay;
        private System.Windows.Forms.ContextMenuStrip reportContextMenu;
        private System.Windows.Forms.ToolStripMenuItem reportContextMenuUnload;
        private System.Windows.Forms.ToolStripMenuItem reportContextMenuUnloadAll;
        private System.Windows.Forms.Label reportLabelInfoUnloadDir;
        private WcTextBox reportTextBoxUnloadDir;
        private WcButton btnOpenUnloadDir;
        private System.Windows.Forms.ToolStripMenuItem reportContextMenuUploadYandexDisk;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private WcButton btnPrint;
        private System.Windows.Forms.NumericUpDown numericUpDownCopies;
        private System.Windows.Forms.Label lblInfoCopies;
        private System.Windows.Forms.ComboBox comboBoxPrinters;
        private System.Windows.Forms.Label lblInfoPrinter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn orgColumnMailType;
        private System.Windows.Forms.DataGridViewComboBoxColumn orgColumnMailCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgColumnTransCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgColumnPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgColumnTransType;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeColumnPay;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

