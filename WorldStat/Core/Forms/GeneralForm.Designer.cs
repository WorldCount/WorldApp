
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFrankReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCalendarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailCategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailCodeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.toggleButtonCalendar = new Wc32Api.Widgets.WcToggleButton();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.panelStat = new System.Windows.Forms.Panel();
            this.labelDaysCount = new System.Windows.Forms.Label();
            this.labelInfoDays = new System.Windows.Forms.Label();
            this.labelPay = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelInfoPay = new System.Windows.Forms.Label();
            this.labelInfoCount = new System.Windows.Forms.Label();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.reportDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportPaytDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelReceived = new System.Windows.Forms.Panel();
            this.labelCalendar = new System.Windows.Forms.Label();
            this.comboBoxCalendar = new System.Windows.Forms.ComboBox();
            this.btnLoadReport = new Wc32Api.Widgets.WcButton();
            this.dateTimePickerReport = new System.Windows.Forms.DateTimePicker();
            this.tabOrg = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFirmPay = new System.Windows.Forms.Label();
            this.labelFirmCount = new System.Windows.Forms.Label();
            this.labelFirmInfoPay = new System.Windows.Forms.Label();
            this.labelFirmInfoCount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mailTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mailCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportPosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewDocOrg = new System.Windows.Forms.DataGridView();
            this.panelOrgDoc = new System.Windows.Forms.Panel();
            this.comboBoxFirmsMailCategory = new System.Windows.Forms.ComboBox();
            this.activeMailCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxFirmsMailType = new System.Windows.Forms.ComboBox();
            this.acitveMailTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFirmInfoMailCategory = new System.Windows.Forms.Label();
            this.labelFirmInfoMailType = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.orgDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.orgDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.orgDateTimePickerCalendar = new System.Windows.Forms.DateTimePicker();
            this.btnLoadReportFirms = new Wc32Api.Widgets.WcButton();
            this.comboBoxFirms = new System.Windows.Forms.ComboBox();
            this.firmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabStat = new System.Windows.Forms.TabPage();
            this.dataGridViewDocReceive = new System.Windows.Forms.DataGridView();
            this.panelReceivedDoc = new System.Windows.Forms.Panel();
            this.btnReceiveDocLoad = new System.Windows.Forms.Button();
            this.receiveDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.receiveDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.dataGridViewUserOnline = new System.Windows.Forms.DataGridView();
            this.adminStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelActive = new System.Windows.Forms.Panel();
            this.btnActiveUserLoad = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmMailTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.firmMailCategoryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.firmCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmTransCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmTransTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBar.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tabsControl.SuspendLayout();
            this.tabAll.SuspendLayout();
            this.panelStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.panelReceived.SuspendLayout();
            this.tabOrg.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocOrg)).BeginInit();
            this.panelOrgDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeMailCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acitveMailTypeBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).BeginInit();
            this.tabStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocReceive)).BeginInit();
            this.panelReceivedDoc.SuspendLayout();
            this.tabChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserOnline)).BeginInit();
            this.panelActive.SuspendLayout();
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
            this.menuBar.Size = new System.Drawing.Size(1265, 40);
            this.menuBar.TabIndex = 2;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFrankReportMenuItem,
            this.importCalendarMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(57, 36);
            this.fileMenuItem.Text = "Файл";
            // 
            // loadFrankReportMenuItem
            // 
            this.loadFrankReportMenuItem.Name = "loadFrankReportMenuItem";
            this.loadFrankReportMenuItem.Size = new System.Drawing.Size(263, 24);
            this.loadFrankReportMenuItem.Text = "Загрузить отчет по франку";
            this.loadFrankReportMenuItem.Click += new System.EventHandler(this.loadFrankReportMenuItem_Click);
            // 
            // importCalendarMenuItem
            // 
            this.importCalendarMenuItem.Name = "importCalendarMenuItem";
            this.importCalendarMenuItem.Size = new System.Drawing.Size(263, 24);
            this.importCalendarMenuItem.Text = "Импорт календаря";
            this.importCalendarMenuItem.Click += new System.EventHandler(this.importCalendarMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(263, 24);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // dataMenuItem
            // 
            this.dataMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmsMenuItem,
            this.mailCategoryMenuItem,
            this.mailTypeMenuItem,
            this.mailCodeMenuItem});
            this.dataMenuItem.Name = "dataMenuItem";
            this.dataMenuItem.Size = new System.Drawing.Size(76, 36);
            this.dataMenuItem.Text = "Данные";
            // 
            // firmsMenuItem
            // 
            this.firmsMenuItem.Name = "firmsMenuItem";
            this.firmsMenuItem.Size = new System.Drawing.Size(247, 24);
            this.firmsMenuItem.Text = "Организации";
            this.firmsMenuItem.Click += new System.EventHandler(this.firmsMenuItem_Click);
            // 
            // mailCategoryMenuItem
            // 
            this.mailCategoryMenuItem.Name = "mailCategoryMenuItem";
            this.mailCategoryMenuItem.Size = new System.Drawing.Size(247, 24);
            this.mailCategoryMenuItem.Text = "Категории отправлений";
            this.mailCategoryMenuItem.Click += new System.EventHandler(this.mailCategoryMenuItem_Click);
            // 
            // mailTypeMenuItem
            // 
            this.mailTypeMenuItem.Name = "mailTypeMenuItem";
            this.mailTypeMenuItem.Size = new System.Drawing.Size(247, 24);
            this.mailTypeMenuItem.Text = "Типы отправлений";
            this.mailTypeMenuItem.Click += new System.EventHandler(this.mailTypeMenuItem_Click);
            // 
            // mailCodeMenuItem
            // 
            this.mailCodeMenuItem.Name = "mailCodeMenuItem";
            this.mailCodeMenuItem.Size = new System.Drawing.Size(247, 24);
            this.mailCodeMenuItem.Text = "Коды отправлений";
            this.mailCodeMenuItem.Click += new System.EventHandler(this.mailCodeMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDbMenuItem});
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(96, 36);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // createDbMenuItem
            // 
            this.createDbMenuItem.Name = "createDbMenuItem";
            this.createDbMenuItem.Size = new System.Drawing.Size(205, 24);
            this.createDbMenuItem.Text = "Создать новую БД";
            this.createDbMenuItem.Click += new System.EventHandler(this.createDbMenuItem_Click);
            // 
            // infosMenuItem
            // 
            this.infosMenuItem.Name = "infosMenuItem";
            this.infosMenuItem.Size = new System.Drawing.Size(60, 36);
            this.infosMenuItem.Text = "Инфо";
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panelGeneral.Controls.Add(this.toggleButtonCalendar);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelGeneral.Location = new System.Drawing.Point(0, 40);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1265, 58);
            this.panelGeneral.TabIndex = 4;
            // 
            // toggleButtonCalendar
            // 
            this.toggleButtonCalendar.AutoSize = true;
            this.toggleButtonCalendar.Checked = true;
            this.toggleButtonCalendar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButtonCalendar.DisableBackColor = System.Drawing.Color.DimGray;
            this.toggleButtonCalendar.DisableToggleColor = System.Drawing.Color.Gray;
            this.toggleButtonCalendar.Location = new System.Drawing.Point(1029, 19);
            this.toggleButtonCalendar.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonCalendar.Name = "toggleButtonCalendar";
            this.toggleButtonCalendar.OffBackColor = System.Drawing.Color.DimGray;
            this.toggleButtonCalendar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtonCalendar.OnBackColor = System.Drawing.Color.SeaGreen;
            this.toggleButtonCalendar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtonCalendar.Size = new System.Drawing.Size(45, 22);
            this.toggleButtonCalendar.TabIndex = 28;
            this.toggleButtonCalendar.UseVisualStyleBackColor = true;
            this.toggleButtonCalendar.CheckedChanged += new System.EventHandler(this.toggleButtonCalendar_CheckedChanged);
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
            this.statusBar.Size = new System.Drawing.Size(1265, 22);
            this.statusBar.TabIndex = 5;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(1136, 17);
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
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabAll);
            this.tabsControl.Controls.Add(this.tabOrg);
            this.tabsControl.Controls.Add(this.tabStat);
            this.tabsControl.Controls.Add(this.tabChart);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabsControl.Location = new System.Drawing.Point(0, 98);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(1265, 406);
            this.tabsControl.TabIndex = 6;
            // 
            // tabAll
            // 
            this.tabAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAll.Controls.Add(this.panelStat);
            this.tabAll.Controls.Add(this.dataGridViewReport);
            this.tabAll.Controls.Add(this.panelReceived);
            this.tabAll.Location = new System.Drawing.Point(4, 29);
            this.tabAll.Name = "tabAll";
            this.tabAll.Size = new System.Drawing.Size(1257, 373);
            this.tabAll.TabIndex = 0;
            this.tabAll.Text = "Общее";
            // 
            // panelStat
            // 
            this.panelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelStat.Controls.Add(this.labelDaysCount);
            this.panelStat.Controls.Add(this.labelInfoDays);
            this.panelStat.Controls.Add(this.labelPay);
            this.panelStat.Controls.Add(this.labelCount);
            this.panelStat.Controls.Add(this.labelInfoPay);
            this.panelStat.Controls.Add(this.labelInfoCount);
            this.panelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelStat.Location = new System.Drawing.Point(0, 343);
            this.panelStat.Name = "panelStat";
            this.panelStat.Size = new System.Drawing.Size(1257, 30);
            this.panelStat.TabIndex = 6;
            // 
            // labelDaysCount
            // 
            this.labelDaysCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDaysCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelDaysCount.Location = new System.Drawing.Point(712, 5);
            this.labelDaysCount.Name = "labelDaysCount";
            this.labelDaysCount.Size = new System.Drawing.Size(140, 20);
            this.labelDaysCount.TabIndex = 3;
            this.labelDaysCount.Text = "0";
            // 
            // labelInfoDays
            // 
            this.labelInfoDays.AutoSize = true;
            this.labelInfoDays.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoDays.Location = new System.Drawing.Point(664, 5);
            this.labelInfoDays.Name = "labelInfoDays";
            this.labelInfoDays.Size = new System.Drawing.Size(42, 20);
            this.labelInfoDays.TabIndex = 2;
            this.labelInfoDays.Text = "Дни:";
            // 
            // labelPay
            // 
            this.labelPay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPay.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelPay.Location = new System.Drawing.Point(461, 5);
            this.labelPay.Name = "labelPay";
            this.labelPay.Size = new System.Drawing.Size(140, 20);
            this.labelPay.TabIndex = 1;
            this.labelPay.Text = "0,00 ₽";
            // 
            // labelCount
            // 
            this.labelCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelCount.Location = new System.Drawing.Point(122, 5);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(140, 20);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "0";
            // 
            // labelInfoPay
            // 
            this.labelInfoPay.AutoSize = true;
            this.labelInfoPay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoPay.Location = new System.Drawing.Point(395, 5);
            this.labelInfoPay.Name = "labelInfoPay";
            this.labelInfoPay.Size = new System.Drawing.Size(60, 20);
            this.labelInfoPay.TabIndex = 0;
            this.labelInfoPay.Text = "Сумма:";
            // 
            // labelInfoCount
            // 
            this.labelInfoCount.AutoSize = true;
            this.labelInfoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoCount.Location = new System.Drawing.Point(21, 5);
            this.labelInfoCount.Name = "labelInfoCount";
            this.labelInfoCount.Size = new System.Drawing.Size(95, 20);
            this.labelInfoCount.TabIndex = 0;
            this.labelInfoCount.Text = "Количество:";
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.AllowUserToResizeColumns = false;
            this.dataGridViewReport.AllowUserToResizeRows = false;
            this.dataGridViewReport.AutoGenerateColumns = false;
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReport.ColumnHeadersHeight = 40;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportDateDataGridViewTextBoxColumn,
            this.reportDayNameDataGridViewTextBoxColumn,
            this.reportTypeDataGridViewTextBoxColumn,
            this.reportCountDataGridViewTextBoxColumn,
            this.reportPaytDataGridViewTextBoxColumn});
            this.dataGridViewReport.DataSource = this.reportBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReport.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReport.EnableHeadersVisualStyles = false;
            this.dataGridViewReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewReport.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewReport.RowHeadersVisible = false;
            this.dataGridViewReport.RowHeadersWidth = 40;
            this.dataGridViewReport.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewReport.RowTemplate.Height = 40;
            this.dataGridViewReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewReport.Size = new System.Drawing.Size(1257, 325);
            this.dataGridViewReport.TabIndex = 5;
            this.dataGridViewReport.TabStop = false;
            // 
            // reportDateDataGridViewTextBoxColumn
            // 
            this.reportDateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.reportDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.reportDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.reportDateDataGridViewTextBoxColumn.Name = "reportDateDataGridViewTextBoxColumn";
            this.reportDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportDayNameDataGridViewTextBoxColumn
            // 
            this.reportDayNameDataGridViewTextBoxColumn.DataPropertyName = "DayName";
            this.reportDayNameDataGridViewTextBoxColumn.HeaderText = "День";
            this.reportDayNameDataGridViewTextBoxColumn.Name = "reportDayNameDataGridViewTextBoxColumn";
            this.reportDayNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportTypeDataGridViewTextBoxColumn
            // 
            this.reportTypeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.reportTypeDataGridViewTextBoxColumn.HeaderText = "Смена";
            this.reportTypeDataGridViewTextBoxColumn.Name = "reportTypeDataGridViewTextBoxColumn";
            this.reportTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportCountDataGridViewTextBoxColumn
            // 
            this.reportCountDataGridViewTextBoxColumn.DataPropertyName = "Count";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.reportCountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.reportCountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.reportCountDataGridViewTextBoxColumn.Name = "reportCountDataGridViewTextBoxColumn";
            this.reportCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportPaytDataGridViewTextBoxColumn
            // 
            this.reportPaytDataGridViewTextBoxColumn.DataPropertyName = "Pay";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.reportPaytDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.reportPaytDataGridViewTextBoxColumn.HeaderText = "Плата";
            this.reportPaytDataGridViewTextBoxColumn.Name = "reportPaytDataGridViewTextBoxColumn";
            this.reportPaytDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.Report);
            // 
            // panelReceived
            // 
            this.panelReceived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelReceived.Controls.Add(this.labelCalendar);
            this.panelReceived.Controls.Add(this.comboBoxCalendar);
            this.panelReceived.Controls.Add(this.btnLoadReport);
            this.panelReceived.Controls.Add(this.dateTimePickerReport);
            this.panelReceived.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceived.Location = new System.Drawing.Point(0, 0);
            this.panelReceived.Name = "panelReceived";
            this.panelReceived.Size = new System.Drawing.Size(1257, 48);
            this.panelReceived.TabIndex = 4;
            // 
            // labelCalendar
            // 
            this.labelCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCalendar.AutoSize = true;
            this.labelCalendar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCalendar.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCalendar.Location = new System.Drawing.Point(1021, 14);
            this.labelCalendar.Name = "labelCalendar";
            this.labelCalendar.Size = new System.Drawing.Size(54, 20);
            this.labelCalendar.TabIndex = 26;
            this.labelCalendar.Text = "Смена";
            // 
            // comboBoxCalendar
            // 
            this.comboBoxCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCalendar.FormattingEnabled = true;
            this.comboBoxCalendar.Location = new System.Drawing.Point(1081, 11);
            this.comboBoxCalendar.Name = "comboBoxCalendar";
            this.comboBoxCalendar.Size = new System.Drawing.Size(168, 28);
            this.comboBoxCalendar.TabIndex = 25;
            // 
            // btnLoadReport
            // 
            this.btnLoadReport.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadReport.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadReport.BorderRadius = 6F;
            this.btnLoadReport.BorderSize = 0;
            this.btnLoadReport.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadReport.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadReport.FlatAppearance.BorderSize = 0;
            this.btnLoadReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLoadReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadReport.ForeColor = System.Drawing.Color.White;
            this.btnLoadReport.Image = global::WorldStat.Properties.Resources.sinchronize_24;
            this.btnLoadReport.Location = new System.Drawing.Point(219, 4);
            this.btnLoadReport.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnLoadReport.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadReport.Size = new System.Drawing.Size(40, 40);
            this.btnLoadReport.TabIndex = 24;
            this.btnLoadReport.TextColor = System.Drawing.Color.White;
            this.btnLoadReport.UseVisualStyleBackColor = false;
            this.btnLoadReport.Click += new System.EventHandler(this.btnLoadReport_Click);
            // 
            // dateTimePickerReport
            // 
            this.dateTimePickerReport.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dateTimePickerReport.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerReport.CustomFormat = "MMMM yyyy";
            this.dateTimePickerReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReport.Location = new System.Drawing.Point(8, 12);
            this.dateTimePickerReport.Name = "dateTimePickerReport";
            this.dateTimePickerReport.ShowUpDown = true;
            this.dateTimePickerReport.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerReport.TabIndex = 23;
            // 
            // tabOrg
            // 
            this.tabOrg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabOrg.Controls.Add(this.panel1);
            this.tabOrg.Controls.Add(this.dataGridView1);
            this.tabOrg.Controls.Add(this.dataGridViewDocOrg);
            this.tabOrg.Controls.Add(this.panelOrgDoc);
            this.tabOrg.Location = new System.Drawing.Point(4, 29);
            this.tabOrg.Name = "tabOrg";
            this.tabOrg.Size = new System.Drawing.Size(1257, 373);
            this.tabOrg.TabIndex = 1;
            this.tabOrg.Text = "Организации";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.labelFirmPay);
            this.panel1.Controls.Add(this.labelFirmCount);
            this.panel1.Controls.Add(this.labelFirmInfoPay);
            this.panel1.Controls.Add(this.labelFirmInfoCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 30);
            this.panel1.TabIndex = 9;
            // 
            // labelFirmPay
            // 
            this.labelFirmPay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirmPay.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelFirmPay.Location = new System.Drawing.Point(461, 5);
            this.labelFirmPay.Name = "labelFirmPay";
            this.labelFirmPay.Size = new System.Drawing.Size(140, 20);
            this.labelFirmPay.TabIndex = 1;
            this.labelFirmPay.Text = "0,00 ₽";
            // 
            // labelFirmCount
            // 
            this.labelFirmCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirmCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelFirmCount.Location = new System.Drawing.Point(122, 5);
            this.labelFirmCount.Name = "labelFirmCount";
            this.labelFirmCount.Size = new System.Drawing.Size(140, 20);
            this.labelFirmCount.TabIndex = 0;
            this.labelFirmCount.Text = "0";
            // 
            // labelFirmInfoPay
            // 
            this.labelFirmInfoPay.AutoSize = true;
            this.labelFirmInfoPay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirmInfoPay.Location = new System.Drawing.Point(395, 5);
            this.labelFirmInfoPay.Name = "labelFirmInfoPay";
            this.labelFirmInfoPay.Size = new System.Drawing.Size(60, 20);
            this.labelFirmInfoPay.TabIndex = 0;
            this.labelFirmInfoPay.Text = "Сумма:";
            // 
            // labelFirmInfoCount
            // 
            this.labelFirmInfoCount.AutoSize = true;
            this.labelFirmInfoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirmInfoCount.Location = new System.Drawing.Point(21, 5);
            this.labelFirmInfoCount.Name = "labelFirmInfoCount";
            this.labelFirmInfoCount.Size = new System.Drawing.Size(95, 20);
            this.labelFirmInfoCount.TabIndex = 0;
            this.labelFirmInfoCount.Text = "Количество:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmDateDataGridViewTextBoxColumn,
            this.firmNameDataGridViewTextBoxColumn,
            this.firmMailTypeDataGridViewCheckBoxColumn,
            this.firmMailCategoryDataGridViewCheckBoxColumn,
            this.firmCountDataGridViewTextBoxColumn,
            this.firmPayDataGridViewTextBoxColumn,
            this.firmTransCategoryDataGridViewTextBoxColumn,
            this.firmTransTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reportPosBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 92);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1257, 281);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.TabStop = false;
            // 
            // mailTypeBindingSource
            // 
            this.mailTypeBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.MailType);
            // 
            // mailCategoryBindingSource
            // 
            this.mailCategoryBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.MailCategory);
            // 
            // reportPosBindingSource
            // 
            this.reportPosBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.ReportPos);
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
            this.dataGridViewDocOrg.Size = new System.Drawing.Size(1257, 281);
            this.dataGridViewDocOrg.TabIndex = 7;
            this.dataGridViewDocOrg.TabStop = false;
            // 
            // panelOrgDoc
            // 
            this.panelOrgDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelOrgDoc.Controls.Add(this.comboBoxFirmsMailCategory);
            this.panelOrgDoc.Controls.Add(this.comboBoxFirmsMailType);
            this.panelOrgDoc.Controls.Add(this.labelFirmInfoMailCategory);
            this.panelOrgDoc.Controls.Add(this.labelFirmInfoMailType);
            this.panelOrgDoc.Controls.Add(this.flowLayoutPanel1);
            this.panelOrgDoc.Controls.Add(this.btnLoadReportFirms);
            this.panelOrgDoc.Controls.Add(this.comboBoxFirms);
            this.panelOrgDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrgDoc.Location = new System.Drawing.Point(0, 0);
            this.panelOrgDoc.Name = "panelOrgDoc";
            this.panelOrgDoc.Size = new System.Drawing.Size(1257, 92);
            this.panelOrgDoc.TabIndex = 3;
            // 
            // comboBoxFirmsMailCategory
            // 
            this.comboBoxFirmsMailCategory.DataSource = this.activeMailCategoryBindingSource;
            this.comboBoxFirmsMailCategory.DisplayMember = "ShortName";
            this.comboBoxFirmsMailCategory.FormattingEnabled = true;
            this.comboBoxFirmsMailCategory.Location = new System.Drawing.Point(417, 50);
            this.comboBoxFirmsMailCategory.Name = "comboBoxFirmsMailCategory";
            this.comboBoxFirmsMailCategory.Size = new System.Drawing.Size(257, 28);
            this.comboBoxFirmsMailCategory.TabIndex = 31;
            this.comboBoxFirmsMailCategory.ValueMember = "Code";
            // 
            // activeMailCategoryBindingSource
            // 
            this.activeMailCategoryBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.MailCategory);
            // 
            // comboBoxFirmsMailType
            // 
            this.comboBoxFirmsMailType.DataSource = this.acitveMailTypeBindingSource;
            this.comboBoxFirmsMailType.DisplayMember = "ShortName";
            this.comboBoxFirmsMailType.FormattingEnabled = true;
            this.comboBoxFirmsMailType.Location = new System.Drawing.Point(52, 50);
            this.comboBoxFirmsMailType.Name = "comboBoxFirmsMailType";
            this.comboBoxFirmsMailType.Size = new System.Drawing.Size(257, 28);
            this.comboBoxFirmsMailType.TabIndex = 31;
            this.comboBoxFirmsMailType.ValueMember = "Code";
            // 
            // acitveMailTypeBindingSource
            // 
            this.acitveMailTypeBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.MailType);
            // 
            // labelFirmInfoMailCategory
            // 
            this.labelFirmInfoMailCategory.AutoSize = true;
            this.labelFirmInfoMailCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirmInfoMailCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFirmInfoMailCategory.Location = new System.Drawing.Point(326, 53);
            this.labelFirmInfoMailCategory.Name = "labelFirmInfoMailCategory";
            this.labelFirmInfoMailCategory.Size = new System.Drawing.Size(85, 20);
            this.labelFirmInfoMailCategory.TabIndex = 30;
            this.labelFirmInfoMailCategory.Text = "Категория:";
            // 
            // labelFirmInfoMailType
            // 
            this.labelFirmInfoMailType.AutoSize = true;
            this.labelFirmInfoMailType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirmInfoMailType.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFirmInfoMailType.Location = new System.Drawing.Point(8, 53);
            this.labelFirmInfoMailType.Name = "labelFirmInfoMailType";
            this.labelFirmInfoMailType.Size = new System.Drawing.Size(38, 20);
            this.labelFirmInfoMailType.TabIndex = 30;
            this.labelFirmInfoMailType.Text = "Тип:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.orgDateTimePickerStart);
            this.flowLayoutPanel1.Controls.Add(this.orgDateTimePickerEnd);
            this.flowLayoutPanel1.Controls.Add(this.orgDateTimePickerCalendar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(417, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 34);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // orgDateTimePickerStart
            // 
            this.orgDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.White;
            this.orgDateTimePickerStart.Location = new System.Drawing.Point(3, 3);
            this.orgDateTimePickerStart.Name = "orgDateTimePickerStart";
            this.orgDateTimePickerStart.Size = new System.Drawing.Size(220, 27);
            this.orgDateTimePickerStart.TabIndex = 22;
            this.orgDateTimePickerStart.Visible = false;
            this.orgDateTimePickerStart.ValueChanged += new System.EventHandler(this.orgDateTimePickerStart_ValueChanged);
            // 
            // orgDateTimePickerEnd
            // 
            this.orgDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.White;
            this.orgDateTimePickerEnd.Location = new System.Drawing.Point(229, 3);
            this.orgDateTimePickerEnd.Name = "orgDateTimePickerEnd";
            this.orgDateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.orgDateTimePickerEnd.TabIndex = 23;
            this.orgDateTimePickerEnd.Visible = false;
            // 
            // orgDateTimePickerCalendar
            // 
            this.orgDateTimePickerCalendar.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgDateTimePickerCalendar.CalendarMonthBackground = System.Drawing.Color.White;
            this.orgDateTimePickerCalendar.CustomFormat = "MMMM yyyy";
            this.orgDateTimePickerCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orgDateTimePickerCalendar.Location = new System.Drawing.Point(435, 3);
            this.orgDateTimePickerCalendar.Name = "orgDateTimePickerCalendar";
            this.orgDateTimePickerCalendar.ShowUpDown = true;
            this.orgDateTimePickerCalendar.Size = new System.Drawing.Size(200, 27);
            this.orgDateTimePickerCalendar.TabIndex = 27;
            // 
            // btnLoadReportFirms
            // 
            this.btnLoadReportFirms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadReportFirms.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadReportFirms.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadReportFirms.BorderRadius = 6F;
            this.btnLoadReportFirms.BorderSize = 0;
            this.btnLoadReportFirms.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadReportFirms.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadReportFirms.FlatAppearance.BorderSize = 0;
            this.btnLoadReportFirms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLoadReportFirms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadReportFirms.ForeColor = System.Drawing.Color.White;
            this.btnLoadReportFirms.Image = global::WorldStat.Properties.Resources.sinchronize_24;
            this.btnLoadReportFirms.Location = new System.Drawing.Point(1209, 4);
            this.btnLoadReportFirms.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnLoadReportFirms.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLoadReportFirms.Name = "btnLoadReportFirms";
            this.btnLoadReportFirms.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadReportFirms.Size = new System.Drawing.Size(40, 40);
            this.btnLoadReportFirms.TabIndex = 26;
            this.btnLoadReportFirms.TextColor = System.Drawing.Color.White;
            this.btnLoadReportFirms.UseVisualStyleBackColor = false;
            this.btnLoadReportFirms.Click += new System.EventHandler(this.btnLoadReportFirms_Click);
            // 
            // comboBoxFirms
            // 
            this.comboBoxFirms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFirms.DataSource = this.firmBindingSource;
            this.comboBoxFirms.DisplayMember = "ShortName";
            this.comboBoxFirms.FormattingEnabled = true;
            this.comboBoxFirms.Location = new System.Drawing.Point(8, 10);
            this.comboBoxFirms.Name = "comboBoxFirms";
            this.comboBoxFirms.Size = new System.Drawing.Size(403, 28);
            this.comboBoxFirms.TabIndex = 24;
            this.comboBoxFirms.ValueMember = "Id";
            // 
            // firmBindingSource
            // 
            this.firmBindingSource.DataSource = typeof(WorldStat.Core.Database.Models.Firm);
            // 
            // tabStat
            // 
            this.tabStat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabStat.Controls.Add(this.dataGridViewDocReceive);
            this.tabStat.Controls.Add(this.panelReceivedDoc);
            this.tabStat.Location = new System.Drawing.Point(4, 29);
            this.tabStat.Name = "tabStat";
            this.tabStat.Size = new System.Drawing.Size(1257, 373);
            this.tabStat.TabIndex = 2;
            this.tabStat.Text = "Статистика";
            // 
            // dataGridViewDocReceive
            // 
            this.dataGridViewDocReceive.AllowUserToAddRows = false;
            this.dataGridViewDocReceive.AllowUserToDeleteRows = false;
            this.dataGridViewDocReceive.AllowUserToResizeRows = false;
            this.dataGridViewDocReceive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDocReceive.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDocReceive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocReceive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewDocReceive.ColumnHeadersHeight = 40;
            this.dataGridViewDocReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDocReceive.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewDocReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDocReceive.EnableHeadersVisualStyles = false;
            this.dataGridViewDocReceive.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewDocReceive.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewDocReceive.Name = "dataGridViewDocReceive";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocReceive.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewDocReceive.RowHeadersVisible = false;
            this.dataGridViewDocReceive.RowHeadersWidth = 40;
            this.dataGridViewDocReceive.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewDocReceive.RowTemplate.Height = 40;
            this.dataGridViewDocReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDocReceive.Size = new System.Drawing.Size(1257, 325);
            this.dataGridViewDocReceive.TabIndex = 6;
            this.dataGridViewDocReceive.TabStop = false;
            // 
            // panelReceivedDoc
            // 
            this.panelReceivedDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelReceivedDoc.Controls.Add(this.btnReceiveDocLoad);
            this.panelReceivedDoc.Controls.Add(this.receiveDateTimePickerEnd);
            this.panelReceivedDoc.Controls.Add(this.receiveDateTimePickerStart);
            this.panelReceivedDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceivedDoc.Location = new System.Drawing.Point(0, 0);
            this.panelReceivedDoc.Name = "panelReceivedDoc";
            this.panelReceivedDoc.Size = new System.Drawing.Size(1257, 48);
            this.panelReceivedDoc.TabIndex = 3;
            // 
            // btnReceiveDocLoad
            // 
            this.btnReceiveDocLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceiveDocLoad.BackColor = System.Drawing.Color.Brown;
            this.btnReceiveDocLoad.FlatAppearance.BorderSize = 0;
            this.btnReceiveDocLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnReceiveDocLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveDocLoad.ForeColor = System.Drawing.Color.White;
            this.btnReceiveDocLoad.Location = new System.Drawing.Point(1213, 6);
            this.btnReceiveDocLoad.Name = "btnReceiveDocLoad";
            this.btnReceiveDocLoad.Size = new System.Drawing.Size(36, 36);
            this.btnReceiveDocLoad.TabIndex = 21;
            this.btnReceiveDocLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceiveDocLoad.UseVisualStyleBackColor = false;
            // 
            // receiveDateTimePickerEnd
            // 
            this.receiveDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.receiveDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.White;
            this.receiveDateTimePickerEnd.Location = new System.Drawing.Point(219, 11);
            this.receiveDateTimePickerEnd.Name = "receiveDateTimePickerEnd";
            this.receiveDateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.receiveDateTimePickerEnd.TabIndex = 4;
            // 
            // receiveDateTimePickerStart
            // 
            this.receiveDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.receiveDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.White;
            this.receiveDateTimePickerStart.Location = new System.Drawing.Point(13, 11);
            this.receiveDateTimePickerStart.Name = "receiveDateTimePickerStart";
            this.receiveDateTimePickerStart.Size = new System.Drawing.Size(200, 27);
            this.receiveDateTimePickerStart.TabIndex = 3;
            // 
            // tabChart
            // 
            this.tabChart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabChart.Controls.Add(this.dataGridViewUserOnline);
            this.tabChart.Controls.Add(this.panelActive);
            this.tabChart.Location = new System.Drawing.Point(4, 29);
            this.tabChart.Name = "tabChart";
            this.tabChart.Size = new System.Drawing.Size(1257, 373);
            this.tabChart.TabIndex = 3;
            this.tabChart.Text = "Инфографика";
            // 
            // dataGridViewUserOnline
            // 
            this.dataGridViewUserOnline.AllowUserToAddRows = false;
            this.dataGridViewUserOnline.AllowUserToDeleteRows = false;
            this.dataGridViewUserOnline.AllowUserToResizeRows = false;
            this.dataGridViewUserOnline.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUserOnline.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewUserOnline.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserOnline.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewUserOnline.ColumnHeadersHeight = 40;
            this.dataGridViewUserOnline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUserOnline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminStatusDataGridViewTextBoxColumn});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUserOnline.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewUserOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUserOnline.EnableHeadersVisualStyles = false;
            this.dataGridViewUserOnline.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewUserOnline.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewUserOnline.Name = "dataGridViewUserOnline";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserOnline.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewUserOnline.RowHeadersVisible = false;
            this.dataGridViewUserOnline.RowHeadersWidth = 40;
            this.dataGridViewUserOnline.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewUserOnline.RowTemplate.Height = 40;
            this.dataGridViewUserOnline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewUserOnline.Size = new System.Drawing.Size(1257, 325);
            this.dataGridViewUserOnline.TabIndex = 1;
            this.dataGridViewUserOnline.TabStop = false;
            // 
            // adminStatusDataGridViewTextBoxColumn
            // 
            this.adminStatusDataGridViewTextBoxColumn.DataPropertyName = "AdminStatus";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.NullValue = "НЕТ";
            this.adminStatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.adminStatusDataGridViewTextBoxColumn.HeaderText = "  Админ";
            this.adminStatusDataGridViewTextBoxColumn.Name = "adminStatusDataGridViewTextBoxColumn";
            this.adminStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panelActive
            // 
            this.panelActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelActive.Controls.Add(this.btnActiveUserLoad);
            this.panelActive.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActive.Location = new System.Drawing.Point(0, 0);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(1257, 48);
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
            this.btnActiveUserLoad.Location = new System.Drawing.Point(1213, 6);
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
            // firmDateDataGridViewTextBoxColumn
            // 
            this.firmDateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.firmDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.firmDateDataGridViewTextBoxColumn.Name = "firmDateDataGridViewTextBoxColumn";
            this.firmDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmNameDataGridViewTextBoxColumn
            // 
            this.firmNameDataGridViewTextBoxColumn.DataPropertyName = "Firm";
            this.firmNameDataGridViewTextBoxColumn.HeaderText = "Организация";
            this.firmNameDataGridViewTextBoxColumn.Name = "firmNameDataGridViewTextBoxColumn";
            this.firmNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmMailTypeDataGridViewCheckBoxColumn
            // 
            this.firmMailTypeDataGridViewCheckBoxColumn.DataPropertyName = "MailType";
            this.firmMailTypeDataGridViewCheckBoxColumn.DataSource = this.mailTypeBindingSource;
            this.firmMailTypeDataGridViewCheckBoxColumn.DisplayMember = "ShortName";
            this.firmMailTypeDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.firmMailTypeDataGridViewCheckBoxColumn.HeaderText = "Тип";
            this.firmMailTypeDataGridViewCheckBoxColumn.Name = "firmMailTypeDataGridViewCheckBoxColumn";
            this.firmMailTypeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.firmMailTypeDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.firmMailTypeDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.firmMailTypeDataGridViewCheckBoxColumn.ValueMember = "Code";
            // 
            // firmMailCategoryDataGridViewCheckBoxColumn
            // 
            this.firmMailCategoryDataGridViewCheckBoxColumn.DataPropertyName = "MailCategory";
            this.firmMailCategoryDataGridViewCheckBoxColumn.DataSource = this.mailCategoryBindingSource;
            this.firmMailCategoryDataGridViewCheckBoxColumn.DisplayMember = "ShortName";
            this.firmMailCategoryDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.firmMailCategoryDataGridViewCheckBoxColumn.HeaderText = "Категория";
            this.firmMailCategoryDataGridViewCheckBoxColumn.Name = "firmMailCategoryDataGridViewCheckBoxColumn";
            this.firmMailCategoryDataGridViewCheckBoxColumn.ReadOnly = true;
            this.firmMailCategoryDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.firmMailCategoryDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.firmMailCategoryDataGridViewCheckBoxColumn.ValueMember = "Code";
            // 
            // firmCountDataGridViewTextBoxColumn
            // 
            this.firmCountDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.firmCountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.firmCountDataGridViewTextBoxColumn.Name = "firmCountDataGridViewTextBoxColumn";
            this.firmCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmPayDataGridViewTextBoxColumn
            // 
            this.firmPayDataGridViewTextBoxColumn.DataPropertyName = "Pay";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.firmPayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.firmPayDataGridViewTextBoxColumn.HeaderText = "Плата";
            this.firmPayDataGridViewTextBoxColumn.Name = "firmPayDataGridViewTextBoxColumn";
            this.firmPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmTransCategoryDataGridViewTextBoxColumn
            // 
            this.firmTransCategoryDataGridViewTextBoxColumn.DataPropertyName = "TransCategory";
            this.firmTransCategoryDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.firmTransCategoryDataGridViewTextBoxColumn.Name = "firmTransCategoryDataGridViewTextBoxColumn";
            this.firmTransCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmTransTypeDataGridViewTextBoxColumn
            // 
            this.firmTransTypeDataGridViewTextBoxColumn.DataPropertyName = "TransType";
            this.firmTransTypeDataGridViewTextBoxColumn.HeaderText = "Пересылка";
            this.firmTransTypeDataGridViewTextBoxColumn.Name = "firmTransTypeDataGridViewTextBoxColumn";
            this.firmTransTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1265, 526);
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
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabsControl.ResumeLayout(false);
            this.tabAll.ResumeLayout(false);
            this.panelStat.ResumeLayout(false);
            this.panelStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.panelReceived.ResumeLayout(false);
            this.panelReceived.PerformLayout();
            this.tabOrg.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocOrg)).EndInit();
            this.panelOrgDoc.ResumeLayout(false);
            this.panelOrgDoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeMailCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acitveMailTypeBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).EndInit();
            this.tabStat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocReceive)).EndInit();
            this.panelReceivedDoc.ResumeLayout(false);
            this.tabChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserOnline)).EndInit();
            this.panelActive.ResumeLayout(false);
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
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Panel panelReceived;
        private System.Windows.Forms.TabPage tabStat;
        private System.Windows.Forms.DataGridView dataGridViewDocReceive;
        private System.Windows.Forms.Panel panelReceivedDoc;
        private System.Windows.Forms.Button btnReceiveDocLoad;
        private System.Windows.Forms.DateTimePicker receiveDateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker receiveDateTimePickerStart;
        private System.Windows.Forms.TabPage tabOrg;
        private System.Windows.Forms.DataGridView dataGridViewDocOrg;
        private System.Windows.Forms.Panel panelOrgDoc;
        private System.Windows.Forms.DateTimePicker orgDateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker orgDateTimePickerStart;
        private System.Windows.Forms.TabPage tabChart;
        private System.Windows.Forms.DataGridView dataGridViewUserOnline;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelActive;
        private System.Windows.Forms.Button btnActiveUserLoad;
        private System.Windows.Forms.DateTimePicker dateTimePickerReport;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private Wc32Api.Widgets.WcButton btnLoadReport;
        private System.Windows.Forms.Panel panelStat;
        private System.Windows.Forms.Label labelInfoCount;
        private System.Windows.Forms.Label labelInfoPay;
        private System.Windows.Forms.Label labelPay;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.ToolStripMenuItem importCalendarMenuItem;
        private System.Windows.Forms.Label labelCalendar;
        private System.Windows.Forms.ComboBox comboBoxCalendar;
        private System.Windows.Forms.ToolStripMenuItem firmsMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem mailCategoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailTypeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailCodeMenuItem;
        private System.Windows.Forms.Label labelDaysCount;
        private System.Windows.Forms.Label labelInfoDays;
        private System.Windows.Forms.ComboBox comboBoxFirms;
        private System.Windows.Forms.BindingSource firmBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFirmPay;
        private System.Windows.Forms.Label labelFirmCount;
        private System.Windows.Forms.Label labelFirmInfoPay;
        private System.Windows.Forms.Label labelFirmInfoCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Wc32Api.Widgets.WcButton btnLoadReportFirms;
        private System.Windows.Forms.BindingSource reportPosBindingSource;
        private System.Windows.Forms.BindingSource mailTypeBindingSource;
        private System.Windows.Forms.BindingSource mailCategoryBindingSource;
        private System.Windows.Forms.DateTimePicker orgDateTimePickerCalendar;
        private Wc32Api.Widgets.WcToggleButton toggleButtonCalendar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxFirmsMailCategory;
        private System.Windows.Forms.ComboBox comboBoxFirmsMailType;
        private System.Windows.Forms.Label labelFirmInfoMailCategory;
        private System.Windows.Forms.Label labelFirmInfoMailType;
        private System.Windows.Forms.BindingSource acitveMailTypeBindingSource;
        private System.Windows.Forms.BindingSource activeMailCategoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportPaytDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn firmMailTypeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn firmMailCategoryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmTransCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmTransTypeDataGridViewTextBoxColumn;
    }
}

