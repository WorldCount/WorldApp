
using WhoseIsBarcode.Core.Database.Models;

namespace WhoseIsBarcode.Core.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.labelInfoFilter = new System.Windows.Forms.Label();
            this.tbFilter = new Wc32Api.Widgets.WcTextBox();
            this.lblInfoDebug = new System.Windows.Forms.Label();
            this.btnDebug = new Wc32Api.Widgets.WcToggleButton();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBarcodes = new System.Windows.Forms.TabPage();
            this.barcodeDataGridView = new System.Windows.Forms.DataGridView();
            this.barcodeColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumnBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumnMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumnOps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumnSeria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumnFirmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbBarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBarcode = new System.Windows.Forms.FlowLayoutPanel();
            this.barcodeLabelInfoBarcode = new System.Windows.Forms.Label();
            this.barcodeTextBoxBarcode = new Wc32Api.Widgets.WcTextBox();
            this.barcodeLabelError = new System.Windows.Forms.Label();
            this.btnLoadBarcode = new Wc32Api.Widgets.WcButton();
            this.barcodePanelStat = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBarcodeStat = new System.Windows.Forms.FlowLayoutPanel();
            this.barcodeLabelInfoCount = new System.Windows.Forms.Label();
            this.barcodeLabelCount = new System.Windows.Forms.Label();
            this.barcodeLabelInfoFreeCount = new System.Windows.Forms.Label();
            this.barcodeLabelFreeCount = new System.Windows.Forms.Label();
            this.barcodeLabelInfoBusyCount = new System.Windows.Forms.Label();
            this.barcodeLabelBusyCount = new System.Windows.Forms.Label();
            this.tabRanges = new System.Windows.Forms.TabPage();
            this.rangeDataGridView = new System.Windows.Forms.DataGridView();
            this.rangeColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnExternal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnOps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnSeria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnFirstNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnLastNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnFirmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnFreeCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnBusyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbRangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rangePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelRangeCalendar = new System.Windows.Forms.FlowLayoutPanel();
            this.rangeLabelInfoDate = new System.Windows.Forms.Label();
            this.rangeToggleCalendar = new Wc32Api.Widgets.WcToggleButton();
            this.rangeToggleDateFormat = new Wc32Api.Widgets.WcToggleButton();
            this.rangeDateTimePickerCalendar = new System.Windows.Forms.DateTimePicker();
            this.rangeDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.rangeDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanelRange = new System.Windows.Forms.FlowLayoutPanel();
            this.rangeLabelInfoFirm = new System.Windows.Forms.Label();
            this.rangeComboBoxFirm = new System.Windows.Forms.ComboBox();
            this.dbFirmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rangeLabelInfoLimit = new System.Windows.Forms.Label();
            this.rangeToggleLimit = new Wc32Api.Widgets.WcToggleButton();
            this.rangeLimitNum = new System.Windows.Forms.NumericUpDown();
            this.rangeLabelInfoType = new System.Windows.Forms.Label();
            this.rangeComboBoxType = new System.Windows.Forms.ComboBox();
            this.externalTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadRange = new Wc32Api.Widgets.WcButton();
            this.panelRangeStat = new System.Windows.Forms.Panel();
            this.flowLayoutPanelRangeStat = new System.Windows.Forms.FlowLayoutPanel();
            this.rangeLabelInfoRangeCount = new System.Windows.Forms.Label();
            this.rangeLabelRangeCount = new System.Windows.Forms.Label();
            this.rangeLabelInfoBarcodeCount = new System.Windows.Forms.Label();
            this.rangeLabelBarcodeCount = new System.Windows.Forms.Label();
            this.rangeLabelInfoBarcodeFree = new System.Windows.Forms.Label();
            this.rangeLabelBarcodeFree = new System.Windows.Forms.Label();
            this.rangeLabelInfoBarcodeBusy = new System.Windows.Forms.Label();
            this.rangeLabelBarcodeBusy = new System.Windows.Forms.Label();
            this.barcodeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toRangeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromRangeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.allbarcodesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabBarcodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBarcodeBindingSource)).BeginInit();
            this.barcodePanel.SuspendLayout();
            this.flowLayoutPanelBarcode.SuspendLayout();
            this.barcodePanelStat.SuspendLayout();
            this.flowLayoutPanelBarcodeStat.SuspendLayout();
            this.tabRanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRangeBindingSource)).BeginInit();
            this.rangePanel.SuspendLayout();
            this.flowLayoutPanelRangeCalendar.SuspendLayout();
            this.flowLayoutPanelRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbFirmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeLimitNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalTypeBindingSource)).BeginInit();
            this.panelRangeStat.SuspendLayout();
            this.flowLayoutPanelRangeStat.SuspendLayout();
            this.barcodeContextMenu.SuspendLayout();
            this.rangeContextMenu.SuspendLayout();
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
            this.settingsMenuItem,
            this.infosMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(884, 40);
            this.menuBar.TabIndex = 3;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Image = global::WhoseIsBarcode.Properties.Resources.Folder;
            this.fileMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(81, 36);
            this.fileMenuItem.Text = "Файл";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.exitMenuItem.Image = global::WhoseIsBarcode.Properties.Resources.Button_Close;
            this.exitMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(130, 30);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectItem});
            this.settingsMenuItem.Image = global::WhoseIsBarcode.Properties.Resources.Folder_Settings;
            this.settingsMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(120, 36);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // connectItem
            // 
            this.connectItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.connectItem.Image = global::WhoseIsBarcode.Properties.Resources.Server;
            this.connectItem.Name = "connectItem";
            this.connectItem.Size = new System.Drawing.Size(217, 30);
            this.connectItem.Text = "Подключение к БД";
            this.connectItem.Click += new System.EventHandler(this.connectItem_Click);
            // 
            // infosMenuItem
            // 
            this.infosMenuItem.Image = global::WhoseIsBarcode.Properties.Resources.Folder_Heart;
            this.infosMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.infosMenuItem.Name = "infosMenuItem";
            this.infosMenuItem.Size = new System.Drawing.Size(84, 36);
            this.infosMenuItem.Text = "Инфо";
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelGeneral.Controls.Add(this.labelInfoFilter);
            this.panelGeneral.Controls.Add(this.tbFilter);
            this.panelGeneral.Controls.Add(this.lblInfoDebug);
            this.panelGeneral.Controls.Add(this.btnDebug);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelGeneral.Location = new System.Drawing.Point(0, 40);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(884, 58);
            this.panelGeneral.TabIndex = 5;
            // 
            // labelInfoFilter
            // 
            this.labelInfoFilter.AutoSize = true;
            this.labelInfoFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoFilter.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelInfoFilter.Location = new System.Drawing.Point(15, 19);
            this.labelInfoFilter.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.labelInfoFilter.Name = "labelInfoFilter";
            this.labelInfoFilter.Size = new System.Drawing.Size(64, 20);
            this.labelInfoFilter.TabIndex = 29;
            this.labelInfoFilter.Text = "Фильтр:";
            // 
            // tbFilter
            // 
            this.tbFilter.BackColor = System.Drawing.Color.White;
            this.tbFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.tbFilter.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.tbFilter.BorderSize = 2;
            this.tbFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFilter.DisableBackColor = System.Drawing.Color.DarkGray;
            this.tbFilter.DisableBorderColor = System.Drawing.Color.DimGray;
            this.tbFilter.DisableForeColor = System.Drawing.Color.DimGray;
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFilter.ForeColor = System.Drawing.Color.DimGray;
            this.tbFilter.Location = new System.Drawing.Point(86, 14);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilter.MaxLength = 32767;
            this.tbFilter.Multiline = false;
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Padding = new System.Windows.Forms.Padding(7);
            this.tbFilter.PasswordChar = '\0';
            this.tbFilter.ReadOnly = false;
            this.tbFilter.Size = new System.Drawing.Size(290, 31);
            this.tbFilter.TabIndex = 28;
            this.tbFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFilter.UnderlinedStyle = true;
            this.tbFilter.UsePasswordChar = false;
            this.tbFilter._TextChanged += new System.EventHandler(this.tbFilter__TextChanged);
            this.tbFilter.Enter += new System.EventHandler(this.tbFilter_Enter);
            // 
            // lblInfoDebug
            // 
            this.lblInfoDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoDebug.AutoSize = true;
            this.lblInfoDebug.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoDebug.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInfoDebug.Location = new System.Drawing.Point(747, 17);
            this.lblInfoDebug.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.lblInfoDebug.Name = "lblInfoDebug";
            this.lblInfoDebug.Size = new System.Drawing.Size(71, 20);
            this.lblInfoDebug.TabIndex = 27;
            this.lblInfoDebug.Text = "Отладка:";
            // 
            // btnDebug
            // 
            this.btnDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDebug.AutoSize = true;
            this.btnDebug.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnDebug.DisableToggleColor = System.Drawing.Color.Gray;
            this.btnDebug.Location = new System.Drawing.Point(824, 17);
            this.btnDebug.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.OffBackColor = System.Drawing.Color.Firebrick;
            this.btnDebug.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnDebug.OnBackColor = System.Drawing.Color.SeaGreen;
            this.btnDebug.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnDebug.Size = new System.Drawing.Size(45, 22);
            this.btnDebug.TabIndex = 0;
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.CheckedChanged += new System.EventHandler(this.btnDebug_CheckedChanged);
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = false;
            this.statusBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.statusBar.Location = new System.Drawing.Point(0, 577);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(884, 24);
            this.statusBar.TabIndex = 6;
            // 
            // statusText
            // 
            this.statusText.AutoSize = false;
            this.statusText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusText.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(755, 19);
            this.statusText.Spring = true;
            // 
            // statusAuthor
            // 
            this.statusAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAuthor.ForeColor = System.Drawing.Color.Gray;
            this.statusAuthor.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.statusAuthor.Name = "statusAuthor";
            this.statusAuthor.Size = new System.Drawing.Size(114, 19);
            this.statusAuthor.Text = "WorldCount, 2021 ©";
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBarcodes);
            this.tabControl.Controls.Add(this.tabRanges);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 98);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(60, 6);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 479);
            this.tabControl.TabIndex = 8;
            // 
            // tabBarcodes
            // 
            this.tabBarcodes.Controls.Add(this.barcodeDataGridView);
            this.tabBarcodes.Controls.Add(this.barcodePanel);
            this.tabBarcodes.Controls.Add(this.barcodePanelStat);
            this.tabBarcodes.Location = new System.Drawing.Point(4, 36);
            this.tabBarcodes.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.tabBarcodes.Name = "tabBarcodes";
            this.tabBarcodes.Padding = new System.Windows.Forms.Padding(3);
            this.tabBarcodes.Size = new System.Drawing.Size(876, 439);
            this.tabBarcodes.TabIndex = 0;
            this.tabBarcodes.Text = "ШПИ";
            this.tabBarcodes.UseVisualStyleBackColor = true;
            // 
            // barcodeDataGridView
            // 
            this.barcodeDataGridView.AllowUserToAddRows = false;
            this.barcodeDataGridView.AllowUserToDeleteRows = false;
            this.barcodeDataGridView.AllowUserToResizeColumns = false;
            this.barcodeDataGridView.AllowUserToResizeRows = false;
            this.barcodeDataGridView.AutoGenerateColumns = false;
            this.barcodeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.barcodeDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.barcodeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.barcodeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.barcodeDataGridView.ColumnHeadersHeight = 40;
            this.barcodeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.barcodeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeColumnDate,
            this.barcodeColumnBarcode,
            this.barcodeColumnMonth,
            this.barcodeColumnOps,
            this.barcodeColumnSeria,
            this.barcodeColumnNum,
            this.barcodeColumnFirmName,
            this.barcodeColumnState});
            this.barcodeDataGridView.DataSource = this.dbBarcodeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.barcodeDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.barcodeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeDataGridView.EnableHeadersVisualStyles = false;
            this.barcodeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.barcodeDataGridView.Location = new System.Drawing.Point(3, 51);
            this.barcodeDataGridView.Name = "barcodeDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.barcodeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.barcodeDataGridView.RowHeadersVisible = false;
            this.barcodeDataGridView.RowHeadersWidth = 40;
            this.barcodeDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.barcodeDataGridView.RowTemplate.Height = 40;
            this.barcodeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.barcodeDataGridView.Size = new System.Drawing.Size(870, 355);
            this.barcodeDataGridView.TabIndex = 6;
            this.barcodeDataGridView.TabStop = false;
            this.barcodeDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.barcodeDataGridView_MouseClick);
            // 
            // barcodeColumnDate
            // 
            this.barcodeColumnDate.DataPropertyName = "Date";
            this.barcodeColumnDate.HeaderText = "  Дата";
            this.barcodeColumnDate.Name = "barcodeColumnDate";
            this.barcodeColumnDate.ReadOnly = true;
            // 
            // barcodeColumnBarcode
            // 
            this.barcodeColumnBarcode.DataPropertyName = "Barcode";
            this.barcodeColumnBarcode.HeaderText = "   ШПИ";
            this.barcodeColumnBarcode.Name = "barcodeColumnBarcode";
            this.barcodeColumnBarcode.ReadOnly = true;
            // 
            // barcodeColumnMonth
            // 
            this.barcodeColumnMonth.DataPropertyName = "MonthName";
            this.barcodeColumnMonth.HeaderText = "Месяц";
            this.barcodeColumnMonth.Name = "barcodeColumnMonth";
            this.barcodeColumnMonth.ReadOnly = true;
            // 
            // barcodeColumnOps
            // 
            this.barcodeColumnOps.DataPropertyName = "Ops";
            this.barcodeColumnOps.HeaderText = "   ОПС";
            this.barcodeColumnOps.Name = "barcodeColumnOps";
            this.barcodeColumnOps.ReadOnly = true;
            // 
            // barcodeColumnSeria
            // 
            this.barcodeColumnSeria.DataPropertyName = "SeriaName";
            this.barcodeColumnSeria.HeaderText = "Серия";
            this.barcodeColumnSeria.Name = "barcodeColumnSeria";
            this.barcodeColumnSeria.ReadOnly = true;
            // 
            // barcodeColumnNum
            // 
            this.barcodeColumnNum.DataPropertyName = "Num";
            this.barcodeColumnNum.HeaderText = "  Номер";
            this.barcodeColumnNum.Name = "barcodeColumnNum";
            this.barcodeColumnNum.ReadOnly = true;
            // 
            // barcodeColumnFirmName
            // 
            this.barcodeColumnFirmName.DataPropertyName = "FirmName";
            this.barcodeColumnFirmName.HeaderText = "Организация";
            this.barcodeColumnFirmName.Name = "barcodeColumnFirmName";
            this.barcodeColumnFirmName.ReadOnly = true;
            // 
            // barcodeColumnState
            // 
            this.barcodeColumnState.DataPropertyName = "State";
            this.barcodeColumnState.HeaderText = "   Статус";
            this.barcodeColumnState.Name = "barcodeColumnState";
            this.barcodeColumnState.ReadOnly = true;
            // 
            // dbBarcodeBindingSource
            // 
            this.dbBarcodeBindingSource.DataSource = typeof(WhoseIsBarcode.Core.Database.Models.DbBarcode);
            // 
            // barcodePanel
            // 
            this.barcodePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.barcodePanel.Controls.Add(this.flowLayoutPanelBarcode);
            this.barcodePanel.Controls.Add(this.btnLoadBarcode);
            this.barcodePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.barcodePanel.Location = new System.Drawing.Point(3, 3);
            this.barcodePanel.Name = "barcodePanel";
            this.barcodePanel.Size = new System.Drawing.Size(870, 48);
            this.barcodePanel.TabIndex = 5;
            // 
            // flowLayoutPanelBarcode
            // 
            this.flowLayoutPanelBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelBarcode.Controls.Add(this.barcodeLabelInfoBarcode);
            this.flowLayoutPanelBarcode.Controls.Add(this.barcodeTextBoxBarcode);
            this.flowLayoutPanelBarcode.Controls.Add(this.barcodeLabelError);
            this.flowLayoutPanelBarcode.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanelBarcode.Name = "flowLayoutPanelBarcode";
            this.flowLayoutPanelBarcode.Size = new System.Drawing.Size(813, 40);
            this.flowLayoutPanelBarcode.TabIndex = 27;
            this.flowLayoutPanelBarcode.WrapContents = false;
            // 
            // barcodeLabelInfoBarcode
            // 
            this.barcodeLabelInfoBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeLabelInfoBarcode.AutoSize = true;
            this.barcodeLabelInfoBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLabelInfoBarcode.ForeColor = System.Drawing.Color.Gainsboro;
            this.barcodeLabelInfoBarcode.Location = new System.Drawing.Point(6, 10);
            this.barcodeLabelInfoBarcode.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.barcodeLabelInfoBarcode.Name = "barcodeLabelInfoBarcode";
            this.barcodeLabelInfoBarcode.Size = new System.Drawing.Size(51, 20);
            this.barcodeLabelInfoBarcode.TabIndex = 26;
            this.barcodeLabelInfoBarcode.Text = "ШПИ:";
            // 
            // barcodeTextBoxBarcode
            // 
            this.barcodeTextBoxBarcode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.barcodeTextBoxBarcode.BorderColor = System.Drawing.Color.DimGray;
            this.barcodeTextBoxBarcode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.barcodeTextBoxBarcode.BorderSize = 2;
            this.barcodeTextBoxBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.barcodeTextBoxBarcode.DisableBackColor = System.Drawing.Color.DarkGray;
            this.barcodeTextBoxBarcode.DisableBorderColor = System.Drawing.Color.DimGray;
            this.barcodeTextBoxBarcode.DisableForeColor = System.Drawing.Color.DimGray;
            this.barcodeTextBoxBarcode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeTextBoxBarcode.ForeColor = System.Drawing.Color.DimGray;
            this.barcodeTextBoxBarcode.Location = new System.Drawing.Point(64, 3);
            this.barcodeTextBoxBarcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this.barcodeTextBoxBarcode.MaxLength = 14;
            this.barcodeTextBoxBarcode.Multiline = false;
            this.barcodeTextBoxBarcode.Name = "barcodeTextBoxBarcode";
            this.barcodeTextBoxBarcode.Padding = new System.Windows.Forms.Padding(7);
            this.barcodeTextBoxBarcode.PasswordChar = '\0';
            this.barcodeTextBoxBarcode.ReadOnly = false;
            this.barcodeTextBoxBarcode.Size = new System.Drawing.Size(210, 35);
            this.barcodeTextBoxBarcode.TabIndex = 27;
            this.barcodeTextBoxBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.barcodeTextBoxBarcode.UnderlinedStyle = false;
            this.barcodeTextBoxBarcode.UsePasswordChar = false;
            this.barcodeTextBoxBarcode.Enter += new System.EventHandler(this.barcodeTextBoxBarcode_Enter);
            this.barcodeTextBoxBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcodeTextBoxBarcode_KeyDown);
            // 
            // barcodeLabelError
            // 
            this.barcodeLabelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeLabelError.AutoSize = true;
            this.barcodeLabelError.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLabelError.ForeColor = System.Drawing.Color.DarkOrange;
            this.barcodeLabelError.Location = new System.Drawing.Point(284, 12);
            this.barcodeLabelError.Margin = new System.Windows.Forms.Padding(6, 12, 3, 0);
            this.barcodeLabelError.Name = "barcodeLabelError";
            this.barcodeLabelError.Size = new System.Drawing.Size(59, 17);
            this.barcodeLabelError.TabIndex = 28;
            this.barcodeLabelError.Text = "Ошибка";
            this.barcodeLabelError.Visible = false;
            // 
            // btnLoadBarcode
            // 
            this.btnLoadBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnLoadBarcode.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadBarcode.BorderRadius = 6F;
            this.btnLoadBarcode.BorderSize = 0;
            this.btnLoadBarcode.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadBarcode.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadBarcode.FlatAppearance.BorderSize = 0;
            this.btnLoadBarcode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnLoadBarcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(119)))), ((int)(((byte)(190)))));
            this.btnLoadBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadBarcode.ForeColor = System.Drawing.Color.White;
            this.btnLoadBarcode.Image = global::WhoseIsBarcode.Properties.Resources.sinchronize_24;
            this.btnLoadBarcode.Location = new System.Drawing.Point(822, 3);
            this.btnLoadBarcode.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnLoadBarcode.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(119)))), ((int)(((byte)(190)))));
            this.btnLoadBarcode.Name = "btnLoadBarcode";
            this.btnLoadBarcode.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadBarcode.Size = new System.Drawing.Size(40, 40);
            this.btnLoadBarcode.TabIndex = 24;
            this.btnLoadBarcode.TextColor = System.Drawing.Color.White;
            this.btnLoadBarcode.UseVisualStyleBackColor = false;
            this.btnLoadBarcode.Click += new System.EventHandler(this.btnLoadBarcode_Click);
            // 
            // barcodePanelStat
            // 
            this.barcodePanelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.barcodePanelStat.Controls.Add(this.flowLayoutPanelBarcodeStat);
            this.barcodePanelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barcodePanelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.barcodePanelStat.Location = new System.Drawing.Point(3, 406);
            this.barcodePanelStat.Name = "barcodePanelStat";
            this.barcodePanelStat.Size = new System.Drawing.Size(870, 30);
            this.barcodePanelStat.TabIndex = 7;
            // 
            // flowLayoutPanelBarcodeStat
            // 
            this.flowLayoutPanelBarcodeStat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelBarcodeStat.Controls.Add(this.barcodeLabelInfoCount);
            this.flowLayoutPanelBarcodeStat.Controls.Add(this.barcodeLabelCount);
            this.flowLayoutPanelBarcodeStat.Controls.Add(this.barcodeLabelInfoFreeCount);
            this.flowLayoutPanelBarcodeStat.Controls.Add(this.barcodeLabelFreeCount);
            this.flowLayoutPanelBarcodeStat.Controls.Add(this.barcodeLabelInfoBusyCount);
            this.flowLayoutPanelBarcodeStat.Controls.Add(this.barcodeLabelBusyCount);
            this.flowLayoutPanelBarcodeStat.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanelBarcodeStat.Name = "flowLayoutPanelBarcodeStat";
            this.flowLayoutPanelBarcodeStat.Size = new System.Drawing.Size(867, 26);
            this.flowLayoutPanelBarcodeStat.TabIndex = 1;
            this.flowLayoutPanelBarcodeStat.WrapContents = false;
            // 
            // barcodeLabelInfoCount
            // 
            this.barcodeLabelInfoCount.AutoSize = true;
            this.barcodeLabelInfoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLabelInfoCount.Location = new System.Drawing.Point(8, 2);
            this.barcodeLabelInfoCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.barcodeLabelInfoCount.Name = "barcodeLabelInfoCount";
            this.barcodeLabelInfoCount.Size = new System.Drawing.Size(52, 20);
            this.barcodeLabelInfoCount.TabIndex = 0;
            this.barcodeLabelInfoCount.Text = "Всего:";
            // 
            // barcodeLabelCount
            // 
            this.barcodeLabelCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLabelCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.barcodeLabelCount.Location = new System.Drawing.Point(66, 2);
            this.barcodeLabelCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.barcodeLabelCount.Name = "barcodeLabelCount";
            this.barcodeLabelCount.Size = new System.Drawing.Size(90, 22);
            this.barcodeLabelCount.TabIndex = 0;
            this.barcodeLabelCount.Text = "0";
            // 
            // barcodeLabelInfoFreeCount
            // 
            this.barcodeLabelInfoFreeCount.AutoSize = true;
            this.barcodeLabelInfoFreeCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLabelInfoFreeCount.Location = new System.Drawing.Point(167, 2);
            this.barcodeLabelInfoFreeCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.barcodeLabelInfoFreeCount.Name = "barcodeLabelInfoFreeCount";
            this.barcodeLabelInfoFreeCount.Size = new System.Drawing.Size(84, 20);
            this.barcodeLabelInfoFreeCount.TabIndex = 0;
            this.barcodeLabelInfoFreeCount.Text = "Свободно:";
            // 
            // barcodeLabelFreeCount
            // 
            this.barcodeLabelFreeCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLabelFreeCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.barcodeLabelFreeCount.Location = new System.Drawing.Point(257, 2);
            this.barcodeLabelFreeCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.barcodeLabelFreeCount.Name = "barcodeLabelFreeCount";
            this.barcodeLabelFreeCount.Size = new System.Drawing.Size(90, 22);
            this.barcodeLabelFreeCount.TabIndex = 0;
            this.barcodeLabelFreeCount.Text = "0";
            // 
            // barcodeLabelInfoBusyCount
            // 
            this.barcodeLabelInfoBusyCount.AutoSize = true;
            this.barcodeLabelInfoBusyCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLabelInfoBusyCount.Location = new System.Drawing.Point(358, 2);
            this.barcodeLabelInfoBusyCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.barcodeLabelInfoBusyCount.Name = "barcodeLabelInfoBusyCount";
            this.barcodeLabelInfoBusyCount.Size = new System.Drawing.Size(61, 20);
            this.barcodeLabelInfoBusyCount.TabIndex = 0;
            this.barcodeLabelInfoBusyCount.Text = "Занято:";
            // 
            // barcodeLabelBusyCount
            // 
            this.barcodeLabelBusyCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLabelBusyCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.barcodeLabelBusyCount.Location = new System.Drawing.Point(425, 2);
            this.barcodeLabelBusyCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.barcodeLabelBusyCount.Name = "barcodeLabelBusyCount";
            this.barcodeLabelBusyCount.Size = new System.Drawing.Size(90, 22);
            this.barcodeLabelBusyCount.TabIndex = 0;
            this.barcodeLabelBusyCount.Text = "0";
            // 
            // tabRanges
            // 
            this.tabRanges.Controls.Add(this.rangeDataGridView);
            this.tabRanges.Controls.Add(this.rangePanel);
            this.tabRanges.Controls.Add(this.panelRangeStat);
            this.tabRanges.Location = new System.Drawing.Point(4, 36);
            this.tabRanges.Name = "tabRanges";
            this.tabRanges.Padding = new System.Windows.Forms.Padding(3);
            this.tabRanges.Size = new System.Drawing.Size(876, 439);
            this.tabRanges.TabIndex = 1;
            this.tabRanges.Text = "Диапазоны";
            this.tabRanges.UseVisualStyleBackColor = true;
            // 
            // rangeDataGridView
            // 
            this.rangeDataGridView.AllowUserToAddRows = false;
            this.rangeDataGridView.AllowUserToDeleteRows = false;
            this.rangeDataGridView.AllowUserToResizeColumns = false;
            this.rangeDataGridView.AllowUserToResizeRows = false;
            this.rangeDataGridView.AutoGenerateColumns = false;
            this.rangeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rangeDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.rangeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rangeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.rangeDataGridView.ColumnHeadersHeight = 40;
            this.rangeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rangeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rangeColumnDate,
            this.rangeColumnExternal,
            this.rangeColumnMonth,
            this.rangeColumnOps,
            this.rangeColumnSeria,
            this.rangeColumnFirstNum,
            this.rangeColumnLastNum,
            this.rangeColumnFirmName,
            this.rangeColumnCount,
            this.rangeColumnFreeCount,
            this.rangeColumnBusyCount});
            this.rangeDataGridView.DataSource = this.dbRangeBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rangeDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.rangeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangeDataGridView.EnableHeadersVisualStyles = false;
            this.rangeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rangeDataGridView.Location = new System.Drawing.Point(3, 96);
            this.rangeDataGridView.Name = "rangeDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rangeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.rangeDataGridView.RowHeadersVisible = false;
            this.rangeDataGridView.RowHeadersWidth = 40;
            this.rangeDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rangeDataGridView.RowTemplate.Height = 40;
            this.rangeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.rangeDataGridView.Size = new System.Drawing.Size(870, 310);
            this.rangeDataGridView.TabIndex = 7;
            this.rangeDataGridView.TabStop = false;
            this.rangeDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rangeDataGridView_MouseClick);
            // 
            // rangeColumnDate
            // 
            this.rangeColumnDate.DataPropertyName = "Date";
            this.rangeColumnDate.HeaderText = "   Дата";
            this.rangeColumnDate.Name = "rangeColumnDate";
            this.rangeColumnDate.ReadOnly = true;
            // 
            // rangeColumnExternal
            // 
            this.rangeColumnExternal.DataPropertyName = "ExtName";
            this.rangeColumnExternal.HeaderText = "Тип";
            this.rangeColumnExternal.Name = "rangeColumnExternal";
            this.rangeColumnExternal.ReadOnly = true;
            // 
            // rangeColumnMonth
            // 
            this.rangeColumnMonth.DataPropertyName = "MonthName";
            this.rangeColumnMonth.HeaderText = "Месяц";
            this.rangeColumnMonth.Name = "rangeColumnMonth";
            this.rangeColumnMonth.ReadOnly = true;
            // 
            // rangeColumnOps
            // 
            this.rangeColumnOps.DataPropertyName = "Ops";
            this.rangeColumnOps.HeaderText = "  ОПС";
            this.rangeColumnOps.Name = "rangeColumnOps";
            this.rangeColumnOps.ReadOnly = true;
            // 
            // rangeColumnSeria
            // 
            this.rangeColumnSeria.DataPropertyName = "SeriaName";
            this.rangeColumnSeria.HeaderText = "Серия";
            this.rangeColumnSeria.Name = "rangeColumnSeria";
            this.rangeColumnSeria.ReadOnly = true;
            // 
            // rangeColumnFirstNum
            // 
            this.rangeColumnFirstNum.DataPropertyName = "FirstNum";
            this.rangeColumnFirstNum.HeaderText = "  Нач.";
            this.rangeColumnFirstNum.Name = "rangeColumnFirstNum";
            this.rangeColumnFirstNum.ReadOnly = true;
            // 
            // rangeColumnLastNum
            // 
            this.rangeColumnLastNum.DataPropertyName = "LastNum";
            this.rangeColumnLastNum.HeaderText = "  Кон.";
            this.rangeColumnLastNum.Name = "rangeColumnLastNum";
            this.rangeColumnLastNum.ReadOnly = true;
            // 
            // rangeColumnFirmName
            // 
            this.rangeColumnFirmName.DataPropertyName = "FirmName";
            this.rangeColumnFirmName.HeaderText = "Организация";
            this.rangeColumnFirmName.Name = "rangeColumnFirmName";
            this.rangeColumnFirmName.ReadOnly = true;
            // 
            // rangeColumnCount
            // 
            this.rangeColumnCount.DataPropertyName = "Count";
            this.rangeColumnCount.HeaderText = "  Кол.";
            this.rangeColumnCount.Name = "rangeColumnCount";
            this.rangeColumnCount.ReadOnly = true;
            // 
            // rangeColumnFreeCount
            // 
            this.rangeColumnFreeCount.DataPropertyName = "FreeCountName";
            this.rangeColumnFreeCount.HeaderText = "  Своб.";
            this.rangeColumnFreeCount.Name = "rangeColumnFreeCount";
            this.rangeColumnFreeCount.ReadOnly = true;
            // 
            // rangeColumnBusyCount
            // 
            this.rangeColumnBusyCount.DataPropertyName = "BusyCountName";
            this.rangeColumnBusyCount.HeaderText = "  Зан.";
            this.rangeColumnBusyCount.Name = "rangeColumnBusyCount";
            this.rangeColumnBusyCount.ReadOnly = true;
            // 
            // dbRangeBindingSource
            // 
            this.dbRangeBindingSource.DataSource = typeof(WhoseIsBarcode.Core.Database.Models.DbRange);
            // 
            // rangePanel
            // 
            this.rangePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.rangePanel.Controls.Add(this.flowLayoutPanelRangeCalendar);
            this.rangePanel.Controls.Add(this.flowLayoutPanelRange);
            this.rangePanel.Controls.Add(this.btnLoadRange);
            this.rangePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rangePanel.Location = new System.Drawing.Point(3, 3);
            this.rangePanel.Name = "rangePanel";
            this.rangePanel.Size = new System.Drawing.Size(870, 93);
            this.rangePanel.TabIndex = 6;
            // 
            // flowLayoutPanelRangeCalendar
            // 
            this.flowLayoutPanelRangeCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelRangeCalendar.Controls.Add(this.rangeLabelInfoDate);
            this.flowLayoutPanelRangeCalendar.Controls.Add(this.rangeToggleCalendar);
            this.flowLayoutPanelRangeCalendar.Controls.Add(this.rangeToggleDateFormat);
            this.flowLayoutPanelRangeCalendar.Controls.Add(this.rangeDateTimePickerCalendar);
            this.flowLayoutPanelRangeCalendar.Controls.Add(this.rangeDateTimePickerStart);
            this.flowLayoutPanelRangeCalendar.Controls.Add(this.rangeDateTimePickerEnd);
            this.flowLayoutPanelRangeCalendar.Location = new System.Drawing.Point(3, 47);
            this.flowLayoutPanelRangeCalendar.Name = "flowLayoutPanelRangeCalendar";
            this.flowLayoutPanelRangeCalendar.Size = new System.Drawing.Size(859, 40);
            this.flowLayoutPanelRangeCalendar.TabIndex = 28;
            this.flowLayoutPanelRangeCalendar.WrapContents = false;
            // 
            // rangeLabelInfoDate
            // 
            this.rangeLabelInfoDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rangeLabelInfoDate.AutoSize = true;
            this.rangeLabelInfoDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelInfoDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.rangeLabelInfoDate.Location = new System.Drawing.Point(6, 10);
            this.rangeLabelInfoDate.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.rangeLabelInfoDate.Name = "rangeLabelInfoDate";
            this.rangeLabelInfoDate.Size = new System.Drawing.Size(46, 20);
            this.rangeLabelInfoDate.TabIndex = 33;
            this.rangeLabelInfoDate.Text = "Дата:";
            // 
            // rangeToggleCalendar
            // 
            this.rangeToggleCalendar.AutoSize = true;
            this.rangeToggleCalendar.DisableBackColor = System.Drawing.Color.DimGray;
            this.rangeToggleCalendar.DisableToggleColor = System.Drawing.Color.Gray;
            this.rangeToggleCalendar.Location = new System.Drawing.Point(58, 10);
            this.rangeToggleCalendar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.rangeToggleCalendar.MinimumSize = new System.Drawing.Size(45, 22);
            this.rangeToggleCalendar.Name = "rangeToggleCalendar";
            this.rangeToggleCalendar.OffBackColor = System.Drawing.Color.Firebrick;
            this.rangeToggleCalendar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rangeToggleCalendar.OnBackColor = System.Drawing.Color.SeaGreen;
            this.rangeToggleCalendar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rangeToggleCalendar.Size = new System.Drawing.Size(45, 22);
            this.rangeToggleCalendar.TabIndex = 28;
            this.rangeToggleCalendar.UseVisualStyleBackColor = true;
            this.rangeToggleCalendar.CheckedChanged += new System.EventHandler(this.rangeToggleCalendar_CheckedChanged);
            // 
            // rangeToggleDateFormat
            // 
            this.rangeToggleDateFormat.AutoSize = true;
            this.rangeToggleDateFormat.DisableBackColor = System.Drawing.Color.DimGray;
            this.rangeToggleDateFormat.DisableToggleColor = System.Drawing.Color.Gray;
            this.rangeToggleDateFormat.Location = new System.Drawing.Point(109, 10);
            this.rangeToggleDateFormat.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.rangeToggleDateFormat.MinimumSize = new System.Drawing.Size(45, 22);
            this.rangeToggleDateFormat.Name = "rangeToggleDateFormat";
            this.rangeToggleDateFormat.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rangeToggleDateFormat.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rangeToggleDateFormat.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rangeToggleDateFormat.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rangeToggleDateFormat.Size = new System.Drawing.Size(45, 22);
            this.rangeToggleDateFormat.TabIndex = 34;
            this.rangeToggleDateFormat.UseVisualStyleBackColor = true;
            this.rangeToggleDateFormat.CheckedChanged += new System.EventHandler(this.rangeToggleDateFormat_CheckedChanged);
            // 
            // rangeDateTimePickerCalendar
            // 
            this.rangeDateTimePickerCalendar.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.rangeDateTimePickerCalendar.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.rangeDateTimePickerCalendar.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.rangeDateTimePickerCalendar.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.rangeDateTimePickerCalendar.CustomFormat = "MMMM yyyy";
            this.rangeDateTimePickerCalendar.Enabled = false;
            this.rangeDateTimePickerCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rangeDateTimePickerCalendar.Location = new System.Drawing.Point(160, 6);
            this.rangeDateTimePickerCalendar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.rangeDateTimePickerCalendar.Name = "rangeDateTimePickerCalendar";
            this.rangeDateTimePickerCalendar.ShowUpDown = true;
            this.rangeDateTimePickerCalendar.Size = new System.Drawing.Size(200, 29);
            this.rangeDateTimePickerCalendar.TabIndex = 30;
            // 
            // rangeDateTimePickerStart
            // 
            this.rangeDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.rangeDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.rangeDateTimePickerStart.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.rangeDateTimePickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.rangeDateTimePickerStart.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.rangeDateTimePickerStart.Enabled = false;
            this.rangeDateTimePickerStart.Location = new System.Drawing.Point(366, 6);
            this.rangeDateTimePickerStart.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.rangeDateTimePickerStart.Name = "rangeDateTimePickerStart";
            this.rangeDateTimePickerStart.Size = new System.Drawing.Size(220, 29);
            this.rangeDateTimePickerStart.TabIndex = 31;
            this.rangeDateTimePickerStart.Visible = false;
            this.rangeDateTimePickerStart.ValueChanged += new System.EventHandler(this.rangeDateTimePickerStart_ValueChanged);
            // 
            // rangeDateTimePickerEnd
            // 
            this.rangeDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.rangeDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.rangeDateTimePickerEnd.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.rangeDateTimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.rangeDateTimePickerEnd.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.rangeDateTimePickerEnd.Enabled = false;
            this.rangeDateTimePickerEnd.Location = new System.Drawing.Point(592, 6);
            this.rangeDateTimePickerEnd.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.rangeDateTimePickerEnd.Name = "rangeDateTimePickerEnd";
            this.rangeDateTimePickerEnd.Size = new System.Drawing.Size(200, 29);
            this.rangeDateTimePickerEnd.TabIndex = 32;
            this.rangeDateTimePickerEnd.Visible = false;
            // 
            // flowLayoutPanelRange
            // 
            this.flowLayoutPanelRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelRange.Controls.Add(this.rangeLabelInfoFirm);
            this.flowLayoutPanelRange.Controls.Add(this.rangeComboBoxFirm);
            this.flowLayoutPanelRange.Controls.Add(this.rangeLabelInfoLimit);
            this.flowLayoutPanelRange.Controls.Add(this.rangeToggleLimit);
            this.flowLayoutPanelRange.Controls.Add(this.rangeLimitNum);
            this.flowLayoutPanelRange.Controls.Add(this.rangeLabelInfoType);
            this.flowLayoutPanelRange.Controls.Add(this.rangeComboBoxType);
            this.flowLayoutPanelRange.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanelRange.Name = "flowLayoutPanelRange";
            this.flowLayoutPanelRange.Size = new System.Drawing.Size(813, 40);
            this.flowLayoutPanelRange.TabIndex = 27;
            this.flowLayoutPanelRange.WrapContents = false;
            // 
            // rangeLabelInfoFirm
            // 
            this.rangeLabelInfoFirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rangeLabelInfoFirm.AutoSize = true;
            this.rangeLabelInfoFirm.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelInfoFirm.ForeColor = System.Drawing.Color.Gainsboro;
            this.rangeLabelInfoFirm.Location = new System.Drawing.Point(6, 10);
            this.rangeLabelInfoFirm.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.rangeLabelInfoFirm.Name = "rangeLabelInfoFirm";
            this.rangeLabelInfoFirm.Size = new System.Drawing.Size(106, 20);
            this.rangeLabelInfoFirm.TabIndex = 27;
            this.rangeLabelInfoFirm.Text = "Организация:";
            // 
            // rangeComboBoxFirm
            // 
            this.rangeComboBoxFirm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rangeComboBoxFirm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rangeComboBoxFirm.DataSource = this.dbFirmBindingSource;
            this.rangeComboBoxFirm.DisplayMember = "Name";
            this.rangeComboBoxFirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.rangeComboBoxFirm.FormattingEnabled = true;
            this.rangeComboBoxFirm.Location = new System.Drawing.Point(118, 6);
            this.rangeComboBoxFirm.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.rangeComboBoxFirm.Name = "rangeComboBoxFirm";
            this.rangeComboBoxFirm.Size = new System.Drawing.Size(318, 29);
            this.rangeComboBoxFirm.TabIndex = 0;
            this.rangeComboBoxFirm.ValueMember = "InnId";
            this.rangeComboBoxFirm.Enter += new System.EventHandler(this.rangeComboBoxFirm_Enter);
            // 
            // dbFirmBindingSource
            // 
            this.dbFirmBindingSource.DataSource = typeof(WhoseIsBarcode.Core.Database.Models.DbFirm);
            // 
            // rangeLabelInfoLimit
            // 
            this.rangeLabelInfoLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rangeLabelInfoLimit.AutoSize = true;
            this.rangeLabelInfoLimit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelInfoLimit.ForeColor = System.Drawing.Color.Gainsboro;
            this.rangeLabelInfoLimit.Location = new System.Drawing.Point(445, 10);
            this.rangeLabelInfoLimit.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.rangeLabelInfoLimit.Name = "rangeLabelInfoLimit";
            this.rangeLabelInfoLimit.Size = new System.Drawing.Size(58, 20);
            this.rangeLabelInfoLimit.TabIndex = 27;
            this.rangeLabelInfoLimit.Text = "Лимит:";
            // 
            // rangeToggleLimit
            // 
            this.rangeToggleLimit.AutoSize = true;
            this.rangeToggleLimit.Checked = true;
            this.rangeToggleLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rangeToggleLimit.DisableBackColor = System.Drawing.Color.DimGray;
            this.rangeToggleLimit.DisableToggleColor = System.Drawing.Color.Gray;
            this.rangeToggleLimit.Location = new System.Drawing.Point(509, 10);
            this.rangeToggleLimit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.rangeToggleLimit.MinimumSize = new System.Drawing.Size(45, 22);
            this.rangeToggleLimit.Name = "rangeToggleLimit";
            this.rangeToggleLimit.OffBackColor = System.Drawing.Color.Firebrick;
            this.rangeToggleLimit.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rangeToggleLimit.OnBackColor = System.Drawing.Color.SeaGreen;
            this.rangeToggleLimit.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rangeToggleLimit.Size = new System.Drawing.Size(45, 22);
            this.rangeToggleLimit.TabIndex = 28;
            this.rangeToggleLimit.UseVisualStyleBackColor = true;
            this.rangeToggleLimit.CheckedChanged += new System.EventHandler(this.rangeToggleLimit_CheckedChanged);
            // 
            // rangeLimitNum
            // 
            this.rangeLimitNum.Location = new System.Drawing.Point(560, 6);
            this.rangeLimitNum.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.rangeLimitNum.Name = "rangeLimitNum";
            this.rangeLimitNum.Size = new System.Drawing.Size(66, 29);
            this.rangeLimitNum.TabIndex = 29;
            this.rangeLimitNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // rangeLabelInfoType
            // 
            this.rangeLabelInfoType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rangeLabelInfoType.AutoSize = true;
            this.rangeLabelInfoType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelInfoType.ForeColor = System.Drawing.Color.Gainsboro;
            this.rangeLabelInfoType.Location = new System.Drawing.Point(635, 10);
            this.rangeLabelInfoType.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.rangeLabelInfoType.Name = "rangeLabelInfoType";
            this.rangeLabelInfoType.Size = new System.Drawing.Size(38, 20);
            this.rangeLabelInfoType.TabIndex = 34;
            this.rangeLabelInfoType.Text = "Тип:";
            // 
            // rangeComboBoxType
            // 
            this.rangeComboBoxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rangeComboBoxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rangeComboBoxType.DataSource = this.externalTypeBindingSource;
            this.rangeComboBoxType.DisplayMember = "Name";
            this.rangeComboBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.rangeComboBoxType.FormattingEnabled = true;
            this.rangeComboBoxType.Location = new System.Drawing.Point(679, 6);
            this.rangeComboBoxType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.rangeComboBoxType.Name = "rangeComboBoxType";
            this.rangeComboBoxType.Size = new System.Drawing.Size(125, 29);
            this.rangeComboBoxType.TabIndex = 35;
            this.rangeComboBoxType.ValueMember = "InnId";
            // 
            // externalTypeBindingSource
            // 
            this.externalTypeBindingSource.DataSource = typeof(WhoseIsBarcode.Core.Filters.ExternalType);
            // 
            // btnLoadRange
            // 
            this.btnLoadRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnLoadRange.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadRange.BorderRadius = 6F;
            this.btnLoadRange.BorderSize = 0;
            this.btnLoadRange.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadRange.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadRange.FlatAppearance.BorderSize = 0;
            this.btnLoadRange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnLoadRange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(119)))), ((int)(((byte)(190)))));
            this.btnLoadRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadRange.ForeColor = System.Drawing.Color.White;
            this.btnLoadRange.Image = global::WhoseIsBarcode.Properties.Resources.sinchronize_24;
            this.btnLoadRange.Location = new System.Drawing.Point(822, 3);
            this.btnLoadRange.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnLoadRange.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(119)))), ((int)(((byte)(190)))));
            this.btnLoadRange.Name = "btnLoadRange";
            this.btnLoadRange.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadRange.Size = new System.Drawing.Size(40, 40);
            this.btnLoadRange.TabIndex = 24;
            this.btnLoadRange.TextColor = System.Drawing.Color.White;
            this.btnLoadRange.UseVisualStyleBackColor = false;
            this.btnLoadRange.Click += new System.EventHandler(this.btnLoadRange_Click);
            // 
            // panelRangeStat
            // 
            this.panelRangeStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelRangeStat.Controls.Add(this.flowLayoutPanelRangeStat);
            this.panelRangeStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRangeStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelRangeStat.Location = new System.Drawing.Point(3, 406);
            this.panelRangeStat.Name = "panelRangeStat";
            this.panelRangeStat.Size = new System.Drawing.Size(870, 30);
            this.panelRangeStat.TabIndex = 8;
            // 
            // flowLayoutPanelRangeStat
            // 
            this.flowLayoutPanelRangeStat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelRangeStat.Controls.Add(this.rangeLabelInfoRangeCount);
            this.flowLayoutPanelRangeStat.Controls.Add(this.rangeLabelRangeCount);
            this.flowLayoutPanelRangeStat.Controls.Add(this.rangeLabelInfoBarcodeCount);
            this.flowLayoutPanelRangeStat.Controls.Add(this.rangeLabelBarcodeCount);
            this.flowLayoutPanelRangeStat.Controls.Add(this.rangeLabelInfoBarcodeFree);
            this.flowLayoutPanelRangeStat.Controls.Add(this.rangeLabelBarcodeFree);
            this.flowLayoutPanelRangeStat.Controls.Add(this.rangeLabelInfoBarcodeBusy);
            this.flowLayoutPanelRangeStat.Controls.Add(this.rangeLabelBarcodeBusy);
            this.flowLayoutPanelRangeStat.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanelRangeStat.Name = "flowLayoutPanelRangeStat";
            this.flowLayoutPanelRangeStat.Size = new System.Drawing.Size(867, 26);
            this.flowLayoutPanelRangeStat.TabIndex = 1;
            this.flowLayoutPanelRangeStat.WrapContents = false;
            // 
            // rangeLabelInfoRangeCount
            // 
            this.rangeLabelInfoRangeCount.AutoSize = true;
            this.rangeLabelInfoRangeCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelInfoRangeCount.Location = new System.Drawing.Point(8, 2);
            this.rangeLabelInfoRangeCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.rangeLabelInfoRangeCount.Name = "rangeLabelInfoRangeCount";
            this.rangeLabelInfoRangeCount.Size = new System.Drawing.Size(100, 20);
            this.rangeLabelInfoRangeCount.TabIndex = 0;
            this.rangeLabelInfoRangeCount.Text = "Диапазонов:";
            // 
            // rangeLabelRangeCount
            // 
            this.rangeLabelRangeCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelRangeCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.rangeLabelRangeCount.Location = new System.Drawing.Point(114, 2);
            this.rangeLabelRangeCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.rangeLabelRangeCount.Name = "rangeLabelRangeCount";
            this.rangeLabelRangeCount.Size = new System.Drawing.Size(90, 22);
            this.rangeLabelRangeCount.TabIndex = 0;
            this.rangeLabelRangeCount.Text = "0";
            // 
            // rangeLabelInfoBarcodeCount
            // 
            this.rangeLabelInfoBarcodeCount.AutoSize = true;
            this.rangeLabelInfoBarcodeCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelInfoBarcodeCount.Location = new System.Drawing.Point(215, 2);
            this.rangeLabelInfoBarcodeCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.rangeLabelInfoBarcodeCount.Name = "rangeLabelInfoBarcodeCount";
            this.rangeLabelInfoBarcodeCount.Size = new System.Drawing.Size(51, 20);
            this.rangeLabelInfoBarcodeCount.TabIndex = 1;
            this.rangeLabelInfoBarcodeCount.Text = "ШПИ:";
            // 
            // rangeLabelBarcodeCount
            // 
            this.rangeLabelBarcodeCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelBarcodeCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.rangeLabelBarcodeCount.Location = new System.Drawing.Point(272, 2);
            this.rangeLabelBarcodeCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.rangeLabelBarcodeCount.Name = "rangeLabelBarcodeCount";
            this.rangeLabelBarcodeCount.Size = new System.Drawing.Size(90, 22);
            this.rangeLabelBarcodeCount.TabIndex = 2;
            this.rangeLabelBarcodeCount.Text = "0";
            // 
            // rangeLabelInfoBarcodeFree
            // 
            this.rangeLabelInfoBarcodeFree.AutoSize = true;
            this.rangeLabelInfoBarcodeFree.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelInfoBarcodeFree.Location = new System.Drawing.Point(373, 2);
            this.rangeLabelInfoBarcodeFree.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.rangeLabelInfoBarcodeFree.Name = "rangeLabelInfoBarcodeFree";
            this.rangeLabelInfoBarcodeFree.Size = new System.Drawing.Size(84, 20);
            this.rangeLabelInfoBarcodeFree.TabIndex = 3;
            this.rangeLabelInfoBarcodeFree.Text = "Свободно:";
            // 
            // rangeLabelBarcodeFree
            // 
            this.rangeLabelBarcodeFree.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelBarcodeFree.ForeColor = System.Drawing.Color.DarkOrange;
            this.rangeLabelBarcodeFree.Location = new System.Drawing.Point(463, 2);
            this.rangeLabelBarcodeFree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.rangeLabelBarcodeFree.Name = "rangeLabelBarcodeFree";
            this.rangeLabelBarcodeFree.Size = new System.Drawing.Size(90, 22);
            this.rangeLabelBarcodeFree.TabIndex = 4;
            this.rangeLabelBarcodeFree.Text = "0";
            // 
            // rangeLabelInfoBarcodeBusy
            // 
            this.rangeLabelInfoBarcodeBusy.AutoSize = true;
            this.rangeLabelInfoBarcodeBusy.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelInfoBarcodeBusy.Location = new System.Drawing.Point(564, 2);
            this.rangeLabelInfoBarcodeBusy.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.rangeLabelInfoBarcodeBusy.Name = "rangeLabelInfoBarcodeBusy";
            this.rangeLabelInfoBarcodeBusy.Size = new System.Drawing.Size(61, 20);
            this.rangeLabelInfoBarcodeBusy.TabIndex = 5;
            this.rangeLabelInfoBarcodeBusy.Text = "Занято:";
            // 
            // rangeLabelBarcodeBusy
            // 
            this.rangeLabelBarcodeBusy.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelBarcodeBusy.ForeColor = System.Drawing.Color.DarkOrange;
            this.rangeLabelBarcodeBusy.Location = new System.Drawing.Point(631, 2);
            this.rangeLabelBarcodeBusy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.rangeLabelBarcodeBusy.Name = "rangeLabelBarcodeBusy";
            this.rangeLabelBarcodeBusy.Size = new System.Drawing.Size(90, 22);
            this.rangeLabelBarcodeBusy.TabIndex = 6;
            this.rangeLabelBarcodeBusy.Text = "0";
            // 
            // barcodeContextMenu
            // 
            this.barcodeContextMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.barcodeContextMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toRangeMenuItem,
            this.loadFromRangeMenuItem});
            this.barcodeContextMenu.Name = "barcodeContextMenu";
            this.barcodeContextMenu.Size = new System.Drawing.Size(233, 56);
            // 
            // toRangeMenuItem
            // 
            this.toRangeMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toRangeMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.toRangeMenuItem.Name = "toRangeMenuItem";
            this.toRangeMenuItem.Size = new System.Drawing.Size(232, 26);
            this.toRangeMenuItem.Text = "Перейти к диапазону";
            this.toRangeMenuItem.Click += new System.EventHandler(this.toRangeMenuItem_Click);
            // 
            // loadFromRangeMenuItem
            // 
            this.loadFromRangeMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadFromRangeMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.loadFromRangeMenuItem.Name = "loadFromRangeMenuItem";
            this.loadFromRangeMenuItem.Size = new System.Drawing.Size(232, 26);
            this.loadFromRangeMenuItem.Text = "Загрузить все ШПИ";
            this.loadFromRangeMenuItem.Click += new System.EventHandler(this.loadFromRangeMenuItem_Click);
            // 
            // rangeContextMenu
            // 
            this.rangeContextMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rangeContextMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allbarcodesMenuItem});
            this.rangeContextMenu.Name = "rangeContextMenu";
            this.rangeContextMenu.Size = new System.Drawing.Size(196, 30);
            // 
            // allbarcodesMenuItem
            // 
            this.allbarcodesMenuItem.Name = "allbarcodesMenuItem";
            this.allbarcodesMenuItem.Size = new System.Drawing.Size(195, 26);
            this.allbarcodesMenuItem.Text = "Перейти к ШПИ";
            this.allbarcodesMenuItem.Click += new System.EventHandler(this.allbarcodesMenuItem_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.menuBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(900, 640);
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneralForm_KeyDown);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabBarcodes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barcodeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBarcodeBindingSource)).EndInit();
            this.barcodePanel.ResumeLayout(false);
            this.flowLayoutPanelBarcode.ResumeLayout(false);
            this.flowLayoutPanelBarcode.PerformLayout();
            this.barcodePanelStat.ResumeLayout(false);
            this.flowLayoutPanelBarcodeStat.ResumeLayout(false);
            this.flowLayoutPanelBarcodeStat.PerformLayout();
            this.tabRanges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rangeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRangeBindingSource)).EndInit();
            this.rangePanel.ResumeLayout(false);
            this.flowLayoutPanelRangeCalendar.ResumeLayout(false);
            this.flowLayoutPanelRangeCalendar.PerformLayout();
            this.flowLayoutPanelRange.ResumeLayout(false);
            this.flowLayoutPanelRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbFirmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeLimitNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalTypeBindingSource)).EndInit();
            this.panelRangeStat.ResumeLayout(false);
            this.flowLayoutPanelRangeStat.ResumeLayout(false);
            this.flowLayoutPanelRangeStat.PerformLayout();
            this.barcodeContextMenu.ResumeLayout(false);
            this.rangeContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosMenuItem;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBarcodes;
        private System.Windows.Forms.TabPage tabRanges;
        private System.Windows.Forms.Panel barcodePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBarcode;
        private System.Windows.Forms.Label barcodeLabelInfoBarcode;
        private Wc32Api.Widgets.WcButton btnLoadBarcode;
        private Wc32Api.Widgets.WcTextBox barcodeTextBoxBarcode;
        private System.Windows.Forms.DataGridView barcodeDataGridView;
        private System.Windows.Forms.Panel barcodePanelStat;
        private System.Windows.Forms.Label barcodeLabelCount;
        private System.Windows.Forms.Label barcodeLabelInfoCount;
        private System.Windows.Forms.Label barcodeLabelError;
        private System.Windows.Forms.BindingSource dbBarcodeBindingSource;
        private System.Windows.Forms.ToolStripMenuItem connectItem;
        private System.Windows.Forms.Label lblInfoDebug;
        private Wc32Api.Widgets.WcToggleButton btnDebug;
        private System.Windows.Forms.Panel rangePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRange;
        private Wc32Api.Widgets.WcButton btnLoadRange;
        private System.Windows.Forms.DataGridView rangeDataGridView;
        private System.Windows.Forms.BindingSource dbRangeBindingSource;
        private System.Windows.Forms.ContextMenuStrip barcodeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toRangeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromRangeMenuItem;
        private System.Windows.Forms.Label barcodeLabelBusyCount;
        private System.Windows.Forms.Label barcodeLabelFreeCount;
        private System.Windows.Forms.Label barcodeLabelInfoBusyCount;
        private System.Windows.Forms.Label barcodeLabelInfoFreeCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBarcodeStat;
        private System.Windows.Forms.Panel panelRangeStat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRangeStat;
        private System.Windows.Forms.Label rangeLabelInfoRangeCount;
        private System.Windows.Forms.Label rangeLabelRangeCount;
        private System.Windows.Forms.Label rangeLabelInfoFirm;
        private System.Windows.Forms.ComboBox rangeComboBoxFirm;
        private System.Windows.Forms.BindingSource dbFirmBindingSource;
        private System.Windows.Forms.Label rangeLabelInfoBarcodeCount;
        private System.Windows.Forms.Label rangeLabelBarcodeCount;
        private System.Windows.Forms.Label rangeLabelInfoBarcodeFree;
        private System.Windows.Forms.Label rangeLabelBarcodeFree;
        private System.Windows.Forms.Label rangeLabelInfoBarcodeBusy;
        private System.Windows.Forms.Label rangeLabelBarcodeBusy;
        private Wc32Api.Widgets.WcToggleButton rangeToggleCalendar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRangeCalendar;
        private Wc32Api.Widgets.WcToggleButton rangeToggleLimit;
        private System.Windows.Forms.Label rangeLabelInfoLimit;
        private System.Windows.Forms.NumericUpDown rangeLimitNum;
        private System.Windows.Forms.DateTimePicker rangeDateTimePickerCalendar;
        private System.Windows.Forms.DateTimePicker rangeDateTimePickerStart;
        private System.Windows.Forms.DateTimePicker rangeDateTimePickerEnd;
        private System.Windows.Forms.Label rangeLabelInfoDate;
        private Wc32Api.Widgets.WcToggleButton rangeToggleDateFormat;
        private System.Windows.Forms.Label labelInfoFilter;
        private Wc32Api.Widgets.WcTextBox tbFilter;
        private System.Windows.Forms.ContextMenuStrip rangeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem allbarcodesMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnOps;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnSeria;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnFirmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnState;
        private System.Windows.Forms.Label rangeLabelInfoType;
        private System.Windows.Forms.ComboBox rangeComboBoxType;
        private System.Windows.Forms.BindingSource externalTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnExternal;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnOps;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnSeria;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnFirstNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnLastNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnFirmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnFreeCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnBusyCount;
    }
}

