
using Wc32Api.Widgets.Buttons;

namespace DwUtils.Core.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.panelWork = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabFreeRpo = new System.Windows.Forms.TabPage();
            this.freeRpoDataGridView = new System.Windows.Forms.DataGridView();
            this.freeRpoColumnCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.freeRpoColumnLoadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeRpoColumnType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rpoTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freeRpoColumnBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeRpoColumnIndexTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeRpoColumnPlaceId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freeRpoColumnUserId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freeRpoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freeRpoPanelStat = new System.Windows.Forms.Panel();
            this.flowLayoutPanelFreeRpoStat = new System.Windows.Forms.FlowLayoutPanel();
            this.freeRpoLabelInfoCount = new System.Windows.Forms.Label();
            this.freeRpoLabelCount = new System.Windows.Forms.Label();
            this.panelFreeRpoL2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelFreeRpoL2 = new System.Windows.Forms.FlowLayoutPanel();
            this.freeRpoLabelInfoPlace = new System.Windows.Forms.Label();
            this.freeRpoComboBoxPlace = new System.Windows.Forms.ComboBox();
            this.freeRpoLabelInfoDate = new System.Windows.Forms.Label();
            this.freeRpoToggleButtonDate = new Wc32Api.Widgets.Buttons.WcToggleButton();
            this.freeRpoDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.freeRpoDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.panelFreeRpoL1 = new System.Windows.Forms.Panel();
            this.btnEditFreeRpo = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnDeleteFreeRpo = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnLoadFreeRpo = new Wc32Api.Widgets.Buttons.WcButton();
            this.flowLayoutPanelFreeRpoL1 = new System.Windows.Forms.FlowLayoutPanel();
            this.freeRpoLabelInfoUsers = new System.Windows.Forms.Label();
            this.freeRpoComboBoxUsers = new System.Windows.Forms.ComboBox();
            this.freeRpoLabelInfoType = new System.Windows.Forms.Label();
            this.freeRpoComboBoxRpoType = new System.Windows.Forms.ComboBox();
            this.tabReceived = new System.Windows.Forms.TabPage();
            this.receivedDataGridView = new System.Windows.Forms.DataGridView();
            this.receivedColumnHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedColumnDocumentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedColumnClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedColumnAllCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedColumnReceivedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedColumnReturnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedColumnReturnPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedRpoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receivedPanelStat = new System.Windows.Forms.Panel();
            this.flowLayoutPanelReceivedStat = new System.Windows.Forms.FlowLayoutPanel();
            this.receivedLabelInfoPosCount = new System.Windows.Forms.Label();
            this.receivedLabelPosCount = new System.Windows.Forms.Label();
            this.receivedLabelInfoAllCount = new System.Windows.Forms.Label();
            this.receivedLabelAllCount = new System.Windows.Forms.Label();
            this.receivedLabelInfoReceiveCount = new System.Windows.Forms.Label();
            this.receivedLabelReceiveCount = new System.Windows.Forms.Label();
            this.receivedLabelInfoReturnCount = new System.Windows.Forms.Label();
            this.receivedLabelReturnCount = new System.Windows.Forms.Label();
            this.receivedLabelInfoReturnPay = new System.Windows.Forms.Label();
            this.receivedLabelReturnPay = new System.Windows.Forms.Label();
            this.panelReceivedL2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelReceivedL2 = new System.Windows.Forms.FlowLayoutPanel();
            this.receivedLabelInfoDate = new System.Windows.Forms.Label();
            this.receivedToggleButtonCalendar = new Wc32Api.Widgets.Buttons.WcToggleButton();
            this.receivedDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.receivedDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.receivedDateTimePickerMonth = new System.Windows.Forms.DateTimePicker();
            this.receivedBtnDateMinus = new Wc32Api.Widgets.Buttons.WcButton();
            this.receivedBtnDatePlus = new Wc32Api.Widgets.Buttons.WcButton();
            this.panelReceivedL1 = new System.Windows.Forms.Panel();
            this.btnPrintReceived = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnLoadReceived = new Wc32Api.Widgets.Buttons.WcButton();
            this.flowLayoutPanelReceivedL1 = new System.Windows.Forms.FlowLayoutPanel();
            this.receivedLabelInfoUsers = new System.Windows.Forms.Label();
            this.receivedComboBoxUsers = new System.Windows.Forms.ComboBox();
            this.receivedLabelInfoReportType = new System.Windows.Forms.Label();
            this.receivedComboBoxReportType = new System.Windows.Forms.ComboBox();
            this.receiveRpoReportTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabDelivery = new System.Windows.Forms.TabPage();
            this.deliveryPictureBox = new System.Windows.Forms.PictureBox();
            this.panelDeliveryL1 = new System.Windows.Forms.Panel();
            this.btnPrintDelivery = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnLoadDelivery = new Wc32Api.Widgets.Buttons.WcButton();
            this.flowLayoutPanelDeliveryL1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabFiles = new System.Windows.Forms.TabPage();
            this.filesDataGridView = new System.Windows.Forms.DataGridView();
            this.filesColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filesColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filesColumnDayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filesColumnUserId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.filesColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpoFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filesPanelStat = new System.Windows.Forms.Panel();
            this.flowLayoutPanelFilesStat = new System.Windows.Forms.FlowLayoutPanel();
            this.filesLabelInfoCount = new System.Windows.Forms.Label();
            this.filesLabelCount = new System.Windows.Forms.Label();
            this.filesLabelInfoRpoCount = new System.Windows.Forms.Label();
            this.filesLabelRpoCount = new System.Windows.Forms.Label();
            this.panelFilesL2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelFilesL2 = new System.Windows.Forms.FlowLayoutPanel();
            this.filesLabelInfoDate = new System.Windows.Forms.Label();
            this.filesToggleButtonDate = new Wc32Api.Widgets.Buttons.WcToggleButton();
            this.filesDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.filesDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.panelFilesL1 = new System.Windows.Forms.Panel();
            this.btnLoadFiles = new Wc32Api.Widgets.Buttons.WcButton();
            this.flowLayoutPanelFilesL1 = new System.Windows.Forms.FlowLayoutPanel();
            this.filesLabelInfoUsers = new System.Windows.Forms.Label();
            this.filesComboBoxUsers = new System.Windows.Forms.ComboBox();
            this.filesLabelInfoLimit = new System.Windows.Forms.Label();
            this.filesToggleButtonLimit = new Wc32Api.Widgets.Buttons.WcToggleButton();
            this.filesLimit = new System.Windows.Forms.NumericUpDown();
            this.tabConnected = new System.Windows.Forms.TabPage();
            this.panelOnlineStat = new System.Windows.Forms.Panel();
            this.flowLayoutPanelOnlineStat = new System.Windows.Forms.FlowLayoutPanel();
            this.onlineLabelInfoCount = new System.Windows.Forms.Label();
            this.onlineLabelCount = new System.Windows.Forms.Label();
            this.onlineDataGridView = new System.Windows.Forms.DataGridView();
            this.onlineColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineColumnPlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineColumnConnectDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineColumnWorkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineColumnAdminStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelOnline = new System.Windows.Forms.Panel();
            this.btnEditUser = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnLoadConnectedUser = new Wc32Api.Widgets.Buttons.WcButton();
            this.flowLayoutPanelOnline = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.comboBoxPrinters = new System.Windows.Forms.ComboBox();
            this.lblInfoPrinter = new System.Windows.Forms.Label();
            this.btnTest = new Wc32Api.Widgets.Buttons.WcButton();
            this.lblInfoDebug = new System.Windows.Forms.Label();
            this.toggleDebug = new Wc32Api.Widgets.Buttons.WcToggleButton();
            this.labelInfoLoadLk = new System.Windows.Forms.Label();
            this.toggleLoadLk = new Wc32Api.Widgets.Buttons.WcToggleButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.infosMenuItem = new Wc32Api.Widgets.Buttons.WcButton();
            this.settingsMenuItem = new Wc32Api.Widgets.Buttons.WcButton();
            this.fileMenuItem = new Wc32Api.Widgets.Buttons.WcButton();
            this.wcDropdownMenuFile = new Wc32Api.Widgets.Menus.WcDropdownMenu(this.components);
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wcDropdownMenuSettings = new Wc32Api.Widgets.Menus.WcDropdownMenu(this.components);
            this.connectPostItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectPostUnitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfoCopies = new System.Windows.Forms.Label();
            this.numericUpDownCopies = new System.Windows.Forms.NumericUpDown();
            this.statusBar.SuspendLayout();
            this.panelWork.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabFreeRpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freeRpoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpoTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeRpoBindingSource)).BeginInit();
            this.freeRpoPanelStat.SuspendLayout();
            this.flowLayoutPanelFreeRpoStat.SuspendLayout();
            this.panelFreeRpoL2.SuspendLayout();
            this.flowLayoutPanelFreeRpoL2.SuspendLayout();
            this.panelFreeRpoL1.SuspendLayout();
            this.flowLayoutPanelFreeRpoL1.SuspendLayout();
            this.tabReceived.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedRpoBindingSource)).BeginInit();
            this.receivedPanelStat.SuspendLayout();
            this.flowLayoutPanelReceivedStat.SuspendLayout();
            this.panelReceivedL2.SuspendLayout();
            this.flowLayoutPanelReceivedL2.SuspendLayout();
            this.panelReceivedL1.SuspendLayout();
            this.flowLayoutPanelReceivedL1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiveRpoReportTypeBindingSource)).BeginInit();
            this.tabDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryPictureBox)).BeginInit();
            this.panelDeliveryL1.SuspendLayout();
            this.tabFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpoFileBindingSource)).BeginInit();
            this.filesPanelStat.SuspendLayout();
            this.flowLayoutPanelFilesStat.SuspendLayout();
            this.panelFilesL2.SuspendLayout();
            this.flowLayoutPanelFilesL2.SuspendLayout();
            this.panelFilesL1.SuspendLayout();
            this.flowLayoutPanelFilesL1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filesLimit)).BeginInit();
            this.tabConnected.SuspendLayout();
            this.panelOnlineStat.SuspendLayout();
            this.flowLayoutPanelOnlineStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectUserBindingSource)).BeginInit();
            this.panelOnline.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.wcDropdownMenuFile.SuspendLayout();
            this.wcDropdownMenuSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = false;
            this.statusBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.statusBar.Location = new System.Drawing.Point(0, 513);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1010, 26);
            this.statusBar.TabIndex = 0;
            // 
            // statusText
            // 
            this.statusText.AutoSize = false;
            this.statusText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusText.Margin = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(881, 17);
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
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // panelWork
            // 
            this.panelWork.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelWork.Controls.Add(this.tabControl);
            this.panelWork.Controls.Add(this.panelGeneral);
            this.panelWork.Controls.Add(this.panelMenu);
            this.panelWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWork.Location = new System.Drawing.Point(0, 0);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(1010, 513);
            this.panelWork.TabIndex = 8;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabFreeRpo);
            this.tabControl.Controls.Add(this.tabReceived);
            this.tabControl.Controls.Add(this.tabDelivery);
            this.tabControl.Controls.Add(this.tabFiles);
            this.tabControl.Controls.Add(this.tabConnected);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 100);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(30, 6);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1010, 413);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            // 
            // tabFreeRpo
            // 
            this.tabFreeRpo.Controls.Add(this.freeRpoDataGridView);
            this.tabFreeRpo.Controls.Add(this.freeRpoPanelStat);
            this.tabFreeRpo.Controls.Add(this.panelFreeRpoL2);
            this.tabFreeRpo.Controls.Add(this.panelFreeRpoL1);
            this.tabFreeRpo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tabFreeRpo.Location = new System.Drawing.Point(4, 36);
            this.tabFreeRpo.Margin = new System.Windows.Forms.Padding(0);
            this.tabFreeRpo.Name = "tabFreeRpo";
            this.tabFreeRpo.Size = new System.Drawing.Size(1002, 373);
            this.tabFreeRpo.TabIndex = 0;
            this.tabFreeRpo.Text = "Сводобные РПО";
            this.tabFreeRpo.UseVisualStyleBackColor = true;
            // 
            // freeRpoDataGridView
            // 
            this.freeRpoDataGridView.AllowUserToAddRows = false;
            this.freeRpoDataGridView.AllowUserToDeleteRows = false;
            this.freeRpoDataGridView.AllowUserToResizeColumns = false;
            this.freeRpoDataGridView.AllowUserToResizeRows = false;
            this.freeRpoDataGridView.AutoGenerateColumns = false;
            this.freeRpoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.freeRpoDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.freeRpoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.freeRpoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.freeRpoDataGridView.ColumnHeadersHeight = 40;
            this.freeRpoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.freeRpoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.freeRpoColumnCheck,
            this.freeRpoColumnLoadDate,
            this.freeRpoColumnType,
            this.freeRpoColumnBarcode,
            this.freeRpoColumnIndexTo,
            this.freeRpoColumnPlaceId,
            this.freeRpoColumnUserId});
            this.freeRpoDataGridView.DataSource = this.freeRpoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.freeRpoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.freeRpoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freeRpoDataGridView.EnableHeadersVisualStyles = false;
            this.freeRpoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.freeRpoDataGridView.Location = new System.Drawing.Point(0, 92);
            this.freeRpoDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.freeRpoDataGridView.Name = "freeRpoDataGridView";
            this.freeRpoDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.freeRpoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.freeRpoDataGridView.RowHeadersVisible = false;
            this.freeRpoDataGridView.RowHeadersWidth = 40;
            this.freeRpoDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.freeRpoDataGridView.RowTemplate.Height = 40;
            this.freeRpoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.freeRpoDataGridView.Size = new System.Drawing.Size(1002, 251);
            this.freeRpoDataGridView.TabIndex = 0;
            this.freeRpoDataGridView.TabStop = false;
            this.freeRpoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.freeRpoDataGridView_CellClick);
            this.freeRpoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.freeRpoDataGridView_CellDoubleClick);
            this.freeRpoDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.freeRpoDataGridView_CellMouseUp);
            this.freeRpoDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.freeRpoDataGridView_CellPainting);
            this.freeRpoDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.freeRpoDataGridView_ColumnHeaderMouseClick);
            this.freeRpoDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.freeRpoDataGridView_DataError);
            // 
            // freeRpoColumnCheck
            // 
            this.freeRpoColumnCheck.DataPropertyName = "Check";
            this.freeRpoColumnCheck.HeaderText = "От";
            this.freeRpoColumnCheck.Name = "freeRpoColumnCheck";
            this.freeRpoColumnCheck.ReadOnly = true;
            // 
            // freeRpoColumnLoadDate
            // 
            this.freeRpoColumnLoadDate.DataPropertyName = "LoadDate";
            this.freeRpoColumnLoadDate.HeaderText = "Загружено";
            this.freeRpoColumnLoadDate.Name = "freeRpoColumnLoadDate";
            this.freeRpoColumnLoadDate.ReadOnly = true;
            // 
            // freeRpoColumnType
            // 
            this.freeRpoColumnType.DataPropertyName = "Type";
            this.freeRpoColumnType.DataSource = this.rpoTypeBindingSource;
            this.freeRpoColumnType.DisplayMember = "Name";
            this.freeRpoColumnType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.freeRpoColumnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freeRpoColumnType.HeaderText = "Тип";
            this.freeRpoColumnType.Name = "freeRpoColumnType";
            this.freeRpoColumnType.ReadOnly = true;
            this.freeRpoColumnType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.freeRpoColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.freeRpoColumnType.ValueMember = "Id";
            // 
            // rpoTypeBindingSource
            // 
            this.rpoTypeBindingSource.DataSource = typeof(DwUtils.Core.Types.RpoType);
            // 
            // freeRpoColumnBarcode
            // 
            this.freeRpoColumnBarcode.DataPropertyName = "Barcode";
            this.freeRpoColumnBarcode.HeaderText = "ШПИ";
            this.freeRpoColumnBarcode.Name = "freeRpoColumnBarcode";
            this.freeRpoColumnBarcode.ReadOnly = true;
            // 
            // freeRpoColumnIndexTo
            // 
            this.freeRpoColumnIndexTo.DataPropertyName = "IndexTo";
            this.freeRpoColumnIndexTo.HeaderText = "Индекс";
            this.freeRpoColumnIndexTo.Name = "freeRpoColumnIndexTo";
            this.freeRpoColumnIndexTo.ReadOnly = true;
            // 
            // freeRpoColumnPlaceId
            // 
            this.freeRpoColumnPlaceId.DataPropertyName = "PlaceId";
            this.freeRpoColumnPlaceId.DataSource = this.placeBindingSource;
            this.freeRpoColumnPlaceId.DisplayMember = "Name";
            this.freeRpoColumnPlaceId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.freeRpoColumnPlaceId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freeRpoColumnPlaceId.HeaderText = "Место";
            this.freeRpoColumnPlaceId.Name = "freeRpoColumnPlaceId";
            this.freeRpoColumnPlaceId.ReadOnly = true;
            this.freeRpoColumnPlaceId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.freeRpoColumnPlaceId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.freeRpoColumnPlaceId.ValueMember = "Id";
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataSource = typeof(DwUtils.Core.Database.Models.Place);
            // 
            // freeRpoColumnUserId
            // 
            this.freeRpoColumnUserId.DataPropertyName = "UserId";
            this.freeRpoColumnUserId.DataSource = this.userBindingSource;
            this.freeRpoColumnUserId.DisplayMember = "Name";
            this.freeRpoColumnUserId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.freeRpoColumnUserId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freeRpoColumnUserId.HeaderText = "Пользователь";
            this.freeRpoColumnUserId.Name = "freeRpoColumnUserId";
            this.freeRpoColumnUserId.ReadOnly = true;
            this.freeRpoColumnUserId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.freeRpoColumnUserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.freeRpoColumnUserId.ValueMember = "Id";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DwUtils.Core.Database.Models.User);
            // 
            // freeRpoBindingSource
            // 
            this.freeRpoBindingSource.DataSource = typeof(DwUtils.Core.Database.Models.FreeRpo);
            // 
            // freeRpoPanelStat
            // 
            this.freeRpoPanelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.freeRpoPanelStat.Controls.Add(this.flowLayoutPanelFreeRpoStat);
            this.freeRpoPanelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.freeRpoPanelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.freeRpoPanelStat.Location = new System.Drawing.Point(0, 343);
            this.freeRpoPanelStat.Name = "freeRpoPanelStat";
            this.freeRpoPanelStat.Size = new System.Drawing.Size(1002, 30);
            this.freeRpoPanelStat.TabIndex = 7;
            // 
            // flowLayoutPanelFreeRpoStat
            // 
            this.flowLayoutPanelFreeRpoStat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelFreeRpoStat.Controls.Add(this.freeRpoLabelInfoCount);
            this.flowLayoutPanelFreeRpoStat.Controls.Add(this.freeRpoLabelCount);
            this.flowLayoutPanelFreeRpoStat.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanelFreeRpoStat.Name = "flowLayoutPanelFreeRpoStat";
            this.flowLayoutPanelFreeRpoStat.Size = new System.Drawing.Size(999, 26);
            this.flowLayoutPanelFreeRpoStat.TabIndex = 1;
            this.flowLayoutPanelFreeRpoStat.WrapContents = false;
            // 
            // freeRpoLabelInfoCount
            // 
            this.freeRpoLabelInfoCount.AutoSize = true;
            this.freeRpoLabelInfoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeRpoLabelInfoCount.Location = new System.Drawing.Point(8, 2);
            this.freeRpoLabelInfoCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.freeRpoLabelInfoCount.Name = "freeRpoLabelInfoCount";
            this.freeRpoLabelInfoCount.Size = new System.Drawing.Size(52, 20);
            this.freeRpoLabelInfoCount.TabIndex = 0;
            this.freeRpoLabelInfoCount.Text = "Всего:";
            // 
            // freeRpoLabelCount
            // 
            this.freeRpoLabelCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeRpoLabelCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.freeRpoLabelCount.Location = new System.Drawing.Point(66, 2);
            this.freeRpoLabelCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.freeRpoLabelCount.Name = "freeRpoLabelCount";
            this.freeRpoLabelCount.Size = new System.Drawing.Size(90, 22);
            this.freeRpoLabelCount.TabIndex = 0;
            this.freeRpoLabelCount.Text = "0";
            // 
            // panelFreeRpoL2
            // 
            this.panelFreeRpoL2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelFreeRpoL2.Controls.Add(this.flowLayoutPanelFreeRpoL2);
            this.panelFreeRpoL2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFreeRpoL2.Location = new System.Drawing.Point(0, 48);
            this.panelFreeRpoL2.Name = "panelFreeRpoL2";
            this.panelFreeRpoL2.Size = new System.Drawing.Size(1002, 44);
            this.panelFreeRpoL2.TabIndex = 8;
            // 
            // flowLayoutPanelFreeRpoL2
            // 
            this.flowLayoutPanelFreeRpoL2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelFreeRpoL2.Controls.Add(this.freeRpoLabelInfoPlace);
            this.flowLayoutPanelFreeRpoL2.Controls.Add(this.freeRpoComboBoxPlace);
            this.flowLayoutPanelFreeRpoL2.Controls.Add(this.freeRpoLabelInfoDate);
            this.flowLayoutPanelFreeRpoL2.Controls.Add(this.freeRpoToggleButtonDate);
            this.flowLayoutPanelFreeRpoL2.Controls.Add(this.freeRpoDateTimePickerStart);
            this.flowLayoutPanelFreeRpoL2.Controls.Add(this.freeRpoDateTimePickerEnd);
            this.flowLayoutPanelFreeRpoL2.Location = new System.Drawing.Point(3, 5);
            this.flowLayoutPanelFreeRpoL2.Name = "flowLayoutPanelFreeRpoL2";
            this.flowLayoutPanelFreeRpoL2.Size = new System.Drawing.Size(989, 34);
            this.flowLayoutPanelFreeRpoL2.TabIndex = 27;
            this.flowLayoutPanelFreeRpoL2.WrapContents = false;
            // 
            // freeRpoLabelInfoPlace
            // 
            this.freeRpoLabelInfoPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.freeRpoLabelInfoPlace.AutoSize = true;
            this.freeRpoLabelInfoPlace.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeRpoLabelInfoPlace.ForeColor = System.Drawing.Color.Gainsboro;
            this.freeRpoLabelInfoPlace.Location = new System.Drawing.Point(6, 6);
            this.freeRpoLabelInfoPlace.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.freeRpoLabelInfoPlace.Name = "freeRpoLabelInfoPlace";
            this.freeRpoLabelInfoPlace.Size = new System.Drawing.Size(70, 20);
            this.freeRpoLabelInfoPlace.TabIndex = 1;
            this.freeRpoLabelInfoPlace.Text = "Участок:";
            // 
            // freeRpoComboBoxPlace
            // 
            this.freeRpoComboBoxPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.freeRpoComboBoxPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.freeRpoComboBoxPlace.DataSource = this.placeBindingSource;
            this.freeRpoComboBoxPlace.DisplayMember = "Name";
            this.freeRpoComboBoxPlace.FormattingEnabled = true;
            this.freeRpoComboBoxPlace.Location = new System.Drawing.Point(82, 3);
            this.freeRpoComboBoxPlace.Name = "freeRpoComboBoxPlace";
            this.freeRpoComboBoxPlace.Size = new System.Drawing.Size(147, 29);
            this.freeRpoComboBoxPlace.TabIndex = 2;
            this.freeRpoComboBoxPlace.ValueMember = "Id";
            // 
            // freeRpoLabelInfoDate
            // 
            this.freeRpoLabelInfoDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.freeRpoLabelInfoDate.AutoSize = true;
            this.freeRpoLabelInfoDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeRpoLabelInfoDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.freeRpoLabelInfoDate.Location = new System.Drawing.Point(238, 6);
            this.freeRpoLabelInfoDate.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.freeRpoLabelInfoDate.Name = "freeRpoLabelInfoDate";
            this.freeRpoLabelInfoDate.Size = new System.Drawing.Size(46, 20);
            this.freeRpoLabelInfoDate.TabIndex = 1;
            this.freeRpoLabelInfoDate.Text = "Дата:";
            // 
            // freeRpoToggleButtonDate
            // 
            this.freeRpoToggleButtonDate.AutoSize = true;
            this.freeRpoToggleButtonDate.DisableBackColor = System.Drawing.Color.DimGray;
            this.freeRpoToggleButtonDate.DisableToggleColor = System.Drawing.Color.Gray;
            this.freeRpoToggleButtonDate.Location = new System.Drawing.Point(290, 6);
            this.freeRpoToggleButtonDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.freeRpoToggleButtonDate.MinimumSize = new System.Drawing.Size(45, 22);
            this.freeRpoToggleButtonDate.Name = "freeRpoToggleButtonDate";
            this.freeRpoToggleButtonDate.OffBackColor = System.Drawing.Color.DimGray;
            this.freeRpoToggleButtonDate.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.freeRpoToggleButtonDate.OnBackColor = System.Drawing.Color.SeaGreen;
            this.freeRpoToggleButtonDate.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.freeRpoToggleButtonDate.Size = new System.Drawing.Size(45, 22);
            this.freeRpoToggleButtonDate.TabIndex = 34;
            this.freeRpoToggleButtonDate.UseVisualStyleBackColor = true;
            this.freeRpoToggleButtonDate.CheckedChanged += new System.EventHandler(this.freeRpoToggleButtonDate_CheckedChanged);
            // 
            // freeRpoDateTimePickerStart
            // 
            this.freeRpoDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.freeRpoDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.freeRpoDateTimePickerStart.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.freeRpoDateTimePickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.freeRpoDateTimePickerStart.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.freeRpoDateTimePickerStart.Enabled = false;
            this.freeRpoDateTimePickerStart.Location = new System.Drawing.Point(341, 3);
            this.freeRpoDateTimePickerStart.Name = "freeRpoDateTimePickerStart";
            this.freeRpoDateTimePickerStart.Size = new System.Drawing.Size(220, 29);
            this.freeRpoDateTimePickerStart.TabIndex = 32;
            this.freeRpoDateTimePickerStart.ValueChanged += new System.EventHandler(this.freeRpoDateTimePickerStart_ValueChanged);
            // 
            // freeRpoDateTimePickerEnd
            // 
            this.freeRpoDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.freeRpoDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.freeRpoDateTimePickerEnd.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.freeRpoDateTimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.freeRpoDateTimePickerEnd.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.freeRpoDateTimePickerEnd.Enabled = false;
            this.freeRpoDateTimePickerEnd.Location = new System.Drawing.Point(567, 3);
            this.freeRpoDateTimePickerEnd.Name = "freeRpoDateTimePickerEnd";
            this.freeRpoDateTimePickerEnd.Size = new System.Drawing.Size(200, 29);
            this.freeRpoDateTimePickerEnd.TabIndex = 33;
            // 
            // panelFreeRpoL1
            // 
            this.panelFreeRpoL1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelFreeRpoL1.Controls.Add(this.btnEditFreeRpo);
            this.panelFreeRpoL1.Controls.Add(this.btnDeleteFreeRpo);
            this.panelFreeRpoL1.Controls.Add(this.btnLoadFreeRpo);
            this.panelFreeRpoL1.Controls.Add(this.flowLayoutPanelFreeRpoL1);
            this.panelFreeRpoL1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFreeRpoL1.Location = new System.Drawing.Point(0, 0);
            this.panelFreeRpoL1.Name = "panelFreeRpoL1";
            this.panelFreeRpoL1.Size = new System.Drawing.Size(1002, 48);
            this.panelFreeRpoL1.TabIndex = 5;
            // 
            // btnEditFreeRpo
            // 
            this.btnEditFreeRpo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditFreeRpo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditFreeRpo.BorderColor = System.Drawing.Color.Silver;
            this.btnEditFreeRpo.BorderRadius = 6F;
            this.btnEditFreeRpo.BorderSize = 0;
            this.btnEditFreeRpo.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnEditFreeRpo.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnEditFreeRpo.FlatAppearance.BorderSize = 0;
            this.btnEditFreeRpo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEditFreeRpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFreeRpo.ForeColor = System.Drawing.Color.White;
            this.btnEditFreeRpo.Image = global::DwUtils.Properties.Resources.edit_11_24;
            this.btnEditFreeRpo.Location = new System.Drawing.Point(906, 4);
            this.btnEditFreeRpo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnEditFreeRpo.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnEditFreeRpo.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEditFreeRpo.Name = "btnEditFreeRpo";
            this.btnEditFreeRpo.Padding = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.btnEditFreeRpo.Size = new System.Drawing.Size(40, 40);
            this.btnEditFreeRpo.TabIndex = 0;
            this.btnEditFreeRpo.TabStop = false;
            this.btnEditFreeRpo.TextColor = System.Drawing.Color.White;
            this.btnEditFreeRpo.UseVisualStyleBackColor = false;
            this.btnEditFreeRpo.Click += new System.EventHandler(this.btnEditFreeRpo_Click);
            // 
            // btnDeleteFreeRpo
            // 
            this.btnDeleteFreeRpo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFreeRpo.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteFreeRpo.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteFreeRpo.BorderRadius = 6F;
            this.btnDeleteFreeRpo.BorderSize = 0;
            this.btnDeleteFreeRpo.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnDeleteFreeRpo.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnDeleteFreeRpo.FlatAppearance.BorderSize = 0;
            this.btnDeleteFreeRpo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDeleteFreeRpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFreeRpo.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFreeRpo.Image = global::DwUtils.Properties.Resources.trash_2_24;
            this.btnDeleteFreeRpo.Location = new System.Drawing.Point(860, 4);
            this.btnDeleteFreeRpo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnDeleteFreeRpo.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnDeleteFreeRpo.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDeleteFreeRpo.Name = "btnDeleteFreeRpo";
            this.btnDeleteFreeRpo.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnDeleteFreeRpo.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteFreeRpo.TabIndex = 0;
            this.btnDeleteFreeRpo.TabStop = false;
            this.btnDeleteFreeRpo.TextColor = System.Drawing.Color.White;
            this.btnDeleteFreeRpo.UseVisualStyleBackColor = false;
            this.btnDeleteFreeRpo.Click += new System.EventHandler(this.btnDeleteFreeRpo_Click);
            // 
            // btnLoadFreeRpo
            // 
            this.btnLoadFreeRpo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFreeRpo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadFreeRpo.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadFreeRpo.BorderRadius = 6F;
            this.btnLoadFreeRpo.BorderSize = 0;
            this.btnLoadFreeRpo.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadFreeRpo.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadFreeRpo.Enabled = false;
            this.btnLoadFreeRpo.FlatAppearance.BorderSize = 0;
            this.btnLoadFreeRpo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLoadFreeRpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFreeRpo.ForeColor = System.Drawing.Color.White;
            this.btnLoadFreeRpo.Image = global::DwUtils.Properties.Resources.synchronize_24;
            this.btnLoadFreeRpo.Location = new System.Drawing.Point(952, 4);
            this.btnLoadFreeRpo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnLoadFreeRpo.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnLoadFreeRpo.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLoadFreeRpo.Name = "btnLoadFreeRpo";
            this.btnLoadFreeRpo.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadFreeRpo.Size = new System.Drawing.Size(40, 40);
            this.btnLoadFreeRpo.TabIndex = 0;
            this.btnLoadFreeRpo.TabStop = false;
            this.btnLoadFreeRpo.TextColor = System.Drawing.Color.White;
            this.btnLoadFreeRpo.UseVisualStyleBackColor = false;
            this.btnLoadFreeRpo.Click += new System.EventHandler(this.btnLoadFreeRpo_Click);
            // 
            // flowLayoutPanelFreeRpoL1
            // 
            this.flowLayoutPanelFreeRpoL1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelFreeRpoL1.Controls.Add(this.freeRpoLabelInfoUsers);
            this.flowLayoutPanelFreeRpoL1.Controls.Add(this.freeRpoComboBoxUsers);
            this.flowLayoutPanelFreeRpoL1.Controls.Add(this.freeRpoLabelInfoType);
            this.flowLayoutPanelFreeRpoL1.Controls.Add(this.freeRpoComboBoxRpoType);
            this.flowLayoutPanelFreeRpoL1.Location = new System.Drawing.Point(3, 7);
            this.flowLayoutPanelFreeRpoL1.Name = "flowLayoutPanelFreeRpoL1";
            this.flowLayoutPanelFreeRpoL1.Size = new System.Drawing.Size(851, 34);
            this.flowLayoutPanelFreeRpoL1.TabIndex = 27;
            this.flowLayoutPanelFreeRpoL1.WrapContents = false;
            // 
            // freeRpoLabelInfoUsers
            // 
            this.freeRpoLabelInfoUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.freeRpoLabelInfoUsers.AutoSize = true;
            this.freeRpoLabelInfoUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeRpoLabelInfoUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.freeRpoLabelInfoUsers.Location = new System.Drawing.Point(6, 6);
            this.freeRpoLabelInfoUsers.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.freeRpoLabelInfoUsers.Name = "freeRpoLabelInfoUsers";
            this.freeRpoLabelInfoUsers.Size = new System.Drawing.Size(111, 20);
            this.freeRpoLabelInfoUsers.TabIndex = 0;
            this.freeRpoLabelInfoUsers.Text = "Пользователь:";
            // 
            // freeRpoComboBoxUsers
            // 
            this.freeRpoComboBoxUsers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.freeRpoComboBoxUsers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.freeRpoComboBoxUsers.DataSource = this.userBindingSource;
            this.freeRpoComboBoxUsers.DisplayMember = "Name";
            this.freeRpoComboBoxUsers.FormattingEnabled = true;
            this.freeRpoComboBoxUsers.Location = new System.Drawing.Point(123, 3);
            this.freeRpoComboBoxUsers.Name = "freeRpoComboBoxUsers";
            this.freeRpoComboBoxUsers.Size = new System.Drawing.Size(234, 29);
            this.freeRpoComboBoxUsers.TabIndex = 0;
            this.freeRpoComboBoxUsers.ValueMember = "Id";
            // 
            // freeRpoLabelInfoType
            // 
            this.freeRpoLabelInfoType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.freeRpoLabelInfoType.AutoSize = true;
            this.freeRpoLabelInfoType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeRpoLabelInfoType.ForeColor = System.Drawing.Color.Gainsboro;
            this.freeRpoLabelInfoType.Location = new System.Drawing.Point(366, 6);
            this.freeRpoLabelInfoType.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.freeRpoLabelInfoType.Name = "freeRpoLabelInfoType";
            this.freeRpoLabelInfoType.Size = new System.Drawing.Size(38, 20);
            this.freeRpoLabelInfoType.TabIndex = 0;
            this.freeRpoLabelInfoType.Text = "Тип:";
            // 
            // freeRpoComboBoxRpoType
            // 
            this.freeRpoComboBoxRpoType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.freeRpoComboBoxRpoType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.freeRpoComboBoxRpoType.DataSource = this.rpoTypeBindingSource;
            this.freeRpoComboBoxRpoType.DisplayMember = "Name";
            this.freeRpoComboBoxRpoType.FormattingEnabled = true;
            this.freeRpoComboBoxRpoType.Location = new System.Drawing.Point(410, 3);
            this.freeRpoComboBoxRpoType.Name = "freeRpoComboBoxRpoType";
            this.freeRpoComboBoxRpoType.Size = new System.Drawing.Size(92, 29);
            this.freeRpoComboBoxRpoType.TabIndex = 0;
            this.freeRpoComboBoxRpoType.ValueMember = "Id";
            // 
            // tabReceived
            // 
            this.tabReceived.Controls.Add(this.receivedDataGridView);
            this.tabReceived.Controls.Add(this.receivedPanelStat);
            this.tabReceived.Controls.Add(this.panelReceivedL2);
            this.tabReceived.Controls.Add(this.panelReceivedL1);
            this.tabReceived.Location = new System.Drawing.Point(4, 36);
            this.tabReceived.Name = "tabReceived";
            this.tabReceived.Size = new System.Drawing.Size(1002, 373);
            this.tabReceived.TabIndex = 1;
            this.tabReceived.Text = "На вручение";
            this.tabReceived.UseVisualStyleBackColor = true;
            // 
            // receivedDataGridView
            // 
            this.receivedDataGridView.AllowUserToAddRows = false;
            this.receivedDataGridView.AllowUserToDeleteRows = false;
            this.receivedDataGridView.AllowUserToResizeColumns = false;
            this.receivedDataGridView.AllowUserToResizeRows = false;
            this.receivedDataGridView.AutoGenerateColumns = false;
            this.receivedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receivedDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.receivedDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receivedDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.receivedDataGridView.ColumnHeadersHeight = 40;
            this.receivedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.receivedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receivedColumnHour,
            this.receivedColumnUserName,
            this.receivedColumnDocumentCount,
            this.receivedColumnClientName,
            this.receivedColumnAllCount,
            this.receivedColumnReceivedCount,
            this.receivedColumnReturnCount,
            this.receivedColumnReturnPay});
            this.receivedDataGridView.DataSource = this.receivedRpoBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.receivedDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.receivedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receivedDataGridView.EnableHeadersVisualStyles = false;
            this.receivedDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.receivedDataGridView.Location = new System.Drawing.Point(0, 92);
            this.receivedDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.receivedDataGridView.Name = "receivedDataGridView";
            this.receivedDataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receivedDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.receivedDataGridView.RowHeadersVisible = false;
            this.receivedDataGridView.RowHeadersWidth = 40;
            this.receivedDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.receivedDataGridView.RowTemplate.Height = 40;
            this.receivedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.receivedDataGridView.Size = new System.Drawing.Size(1002, 251);
            this.receivedDataGridView.TabIndex = 10;
            this.receivedDataGridView.TabStop = false;
            this.receivedDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.receivedDataGridView_CellFormatting);
            this.receivedDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            // 
            // receivedColumnHour
            // 
            this.receivedColumnHour.DataPropertyName = "Hour";
            this.receivedColumnHour.HeaderText = "Час";
            this.receivedColumnHour.Name = "receivedColumnHour";
            this.receivedColumnHour.ReadOnly = true;
            this.receivedColumnHour.Visible = false;
            // 
            // receivedColumnUserName
            // 
            this.receivedColumnUserName.DataPropertyName = "UserName";
            this.receivedColumnUserName.HeaderText = "Оператор";
            this.receivedColumnUserName.Name = "receivedColumnUserName";
            this.receivedColumnUserName.ReadOnly = true;
            this.receivedColumnUserName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.receivedColumnUserName.Visible = false;
            // 
            // receivedColumnDocumentCount
            // 
            this.receivedColumnDocumentCount.DataPropertyName = "DocumentCount";
            this.receivedColumnDocumentCount.HeaderText = "Организаций";
            this.receivedColumnDocumentCount.Name = "receivedColumnDocumentCount";
            this.receivedColumnDocumentCount.ReadOnly = true;
            this.receivedColumnDocumentCount.Visible = false;
            // 
            // receivedColumnClientName
            // 
            this.receivedColumnClientName.DataPropertyName = "ClientName";
            this.receivedColumnClientName.HeaderText = "Организация";
            this.receivedColumnClientName.Name = "receivedColumnClientName";
            this.receivedColumnClientName.ReadOnly = true;
            // 
            // receivedColumnAllCount
            // 
            this.receivedColumnAllCount.DataPropertyName = "AllCount";
            this.receivedColumnAllCount.HeaderText = "Прибыло";
            this.receivedColumnAllCount.Name = "receivedColumnAllCount";
            this.receivedColumnAllCount.ReadOnly = true;
            // 
            // receivedColumnReceivedCount
            // 
            this.receivedColumnReceivedCount.DataPropertyName = "ReceivedCount";
            this.receivedColumnReceivedCount.HeaderText = "Получателю";
            this.receivedColumnReceivedCount.Name = "receivedColumnReceivedCount";
            this.receivedColumnReceivedCount.ReadOnly = true;
            // 
            // receivedColumnReturnCount
            // 
            this.receivedColumnReturnCount.DataPropertyName = "ReturnCount";
            this.receivedColumnReturnCount.HeaderText = "Возврат";
            this.receivedColumnReturnCount.Name = "receivedColumnReturnCount";
            this.receivedColumnReturnCount.ReadOnly = true;
            // 
            // receivedColumnReturnPay
            // 
            this.receivedColumnReturnPay.DataPropertyName = "ReturnPay";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.receivedColumnReturnPay.DefaultCellStyle = dataGridViewCellStyle5;
            this.receivedColumnReturnPay.HeaderText = "Плата за возврат";
            this.receivedColumnReturnPay.Name = "receivedColumnReturnPay";
            this.receivedColumnReturnPay.ReadOnly = true;
            // 
            // receivedRpoBindingSource
            // 
            this.receivedRpoBindingSource.DataSource = typeof(DwUtils.Core.Database.Models.ReceivedRpo);
            // 
            // receivedPanelStat
            // 
            this.receivedPanelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.receivedPanelStat.Controls.Add(this.flowLayoutPanelReceivedStat);
            this.receivedPanelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.receivedPanelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.receivedPanelStat.Location = new System.Drawing.Point(0, 343);
            this.receivedPanelStat.Name = "receivedPanelStat";
            this.receivedPanelStat.Size = new System.Drawing.Size(1002, 30);
            this.receivedPanelStat.TabIndex = 11;
            // 
            // flowLayoutPanelReceivedStat
            // 
            this.flowLayoutPanelReceivedStat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelReceivedStat.Controls.Add(this.receivedLabelInfoPosCount);
            this.flowLayoutPanelReceivedStat.Controls.Add(this.receivedLabelPosCount);
            this.flowLayoutPanelReceivedStat.Controls.Add(this.receivedLabelInfoAllCount);
            this.flowLayoutPanelReceivedStat.Controls.Add(this.receivedLabelAllCount);
            this.flowLayoutPanelReceivedStat.Controls.Add(this.receivedLabelInfoReceiveCount);
            this.flowLayoutPanelReceivedStat.Controls.Add(this.receivedLabelReceiveCount);
            this.flowLayoutPanelReceivedStat.Controls.Add(this.receivedLabelInfoReturnCount);
            this.flowLayoutPanelReceivedStat.Controls.Add(this.receivedLabelReturnCount);
            this.flowLayoutPanelReceivedStat.Controls.Add(this.receivedLabelInfoReturnPay);
            this.flowLayoutPanelReceivedStat.Controls.Add(this.receivedLabelReturnPay);
            this.flowLayoutPanelReceivedStat.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanelReceivedStat.Name = "flowLayoutPanelReceivedStat";
            this.flowLayoutPanelReceivedStat.Size = new System.Drawing.Size(999, 26);
            this.flowLayoutPanelReceivedStat.TabIndex = 1;
            this.flowLayoutPanelReceivedStat.WrapContents = false;
            // 
            // receivedLabelInfoPosCount
            // 
            this.receivedLabelInfoPosCount.AutoSize = true;
            this.receivedLabelInfoPosCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedLabelInfoPosCount.Location = new System.Drawing.Point(8, 2);
            this.receivedLabelInfoPosCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.receivedLabelInfoPosCount.Name = "receivedLabelInfoPosCount";
            this.receivedLabelInfoPosCount.Size = new System.Drawing.Size(76, 20);
            this.receivedLabelInfoPosCount.TabIndex = 0;
            this.receivedLabelInfoPosCount.Text = "Позиций:";
            // 
            // receivedLabelPosCount
            // 
            this.receivedLabelPosCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedLabelPosCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.receivedLabelPosCount.Location = new System.Drawing.Point(90, 2);
            this.receivedLabelPosCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.receivedLabelPosCount.Name = "receivedLabelPosCount";
            this.receivedLabelPosCount.Size = new System.Drawing.Size(90, 22);
            this.receivedLabelPosCount.TabIndex = 0;
            this.receivedLabelPosCount.Text = "0";
            // 
            // receivedLabelInfoAllCount
            // 
            this.receivedLabelInfoAllCount.AutoSize = true;
            this.receivedLabelInfoAllCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedLabelInfoAllCount.Location = new System.Drawing.Point(191, 2);
            this.receivedLabelInfoAllCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.receivedLabelInfoAllCount.Name = "receivedLabelInfoAllCount";
            this.receivedLabelInfoAllCount.Size = new System.Drawing.Size(79, 20);
            this.receivedLabelInfoAllCount.TabIndex = 1;
            this.receivedLabelInfoAllCount.Text = "Прибыло:";
            // 
            // receivedLabelAllCount
            // 
            this.receivedLabelAllCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedLabelAllCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.receivedLabelAllCount.Location = new System.Drawing.Point(276, 2);
            this.receivedLabelAllCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.receivedLabelAllCount.Name = "receivedLabelAllCount";
            this.receivedLabelAllCount.Size = new System.Drawing.Size(90, 22);
            this.receivedLabelAllCount.TabIndex = 2;
            this.receivedLabelAllCount.Text = "0";
            // 
            // receivedLabelInfoReceiveCount
            // 
            this.receivedLabelInfoReceiveCount.AutoSize = true;
            this.receivedLabelInfoReceiveCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedLabelInfoReceiveCount.Location = new System.Drawing.Point(377, 2);
            this.receivedLabelInfoReceiveCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.receivedLabelInfoReceiveCount.Name = "receivedLabelInfoReceiveCount";
            this.receivedLabelInfoReceiveCount.Size = new System.Drawing.Size(101, 20);
            this.receivedLabelInfoReceiveCount.TabIndex = 3;
            this.receivedLabelInfoReceiveCount.Text = "Получателю:";
            // 
            // receivedLabelReceiveCount
            // 
            this.receivedLabelReceiveCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedLabelReceiveCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.receivedLabelReceiveCount.Location = new System.Drawing.Point(484, 2);
            this.receivedLabelReceiveCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.receivedLabelReceiveCount.Name = "receivedLabelReceiveCount";
            this.receivedLabelReceiveCount.Size = new System.Drawing.Size(90, 22);
            this.receivedLabelReceiveCount.TabIndex = 4;
            this.receivedLabelReceiveCount.Text = "0";
            // 
            // receivedLabelInfoReturnCount
            // 
            this.receivedLabelInfoReturnCount.AutoSize = true;
            this.receivedLabelInfoReturnCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedLabelInfoReturnCount.Location = new System.Drawing.Point(585, 2);
            this.receivedLabelInfoReturnCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.receivedLabelInfoReturnCount.Name = "receivedLabelInfoReturnCount";
            this.receivedLabelInfoReturnCount.Size = new System.Drawing.Size(69, 20);
            this.receivedLabelInfoReturnCount.TabIndex = 5;
            this.receivedLabelInfoReturnCount.Text = "Возврат:";
            // 
            // receivedLabelReturnCount
            // 
            this.receivedLabelReturnCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedLabelReturnCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.receivedLabelReturnCount.Location = new System.Drawing.Point(660, 2);
            this.receivedLabelReturnCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.receivedLabelReturnCount.Name = "receivedLabelReturnCount";
            this.receivedLabelReturnCount.Size = new System.Drawing.Size(90, 22);
            this.receivedLabelReturnCount.TabIndex = 6;
            this.receivedLabelReturnCount.Text = "0";
            // 
            // receivedLabelInfoReturnPay
            // 
            this.receivedLabelInfoReturnPay.AutoSize = true;
            this.receivedLabelInfoReturnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedLabelInfoReturnPay.Location = new System.Drawing.Point(761, 2);
            this.receivedLabelInfoReturnPay.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.receivedLabelInfoReturnPay.Name = "receivedLabelInfoReturnPay";
            this.receivedLabelInfoReturnPay.Size = new System.Drawing.Size(54, 20);
            this.receivedLabelInfoReturnPay.TabIndex = 7;
            this.receivedLabelInfoReturnPay.Text = "Плата:";
            // 
            // receivedLabelReturnPay
            // 
            this.receivedLabelReturnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedLabelReturnPay.ForeColor = System.Drawing.Color.DarkOrange;
            this.receivedLabelReturnPay.Location = new System.Drawing.Point(821, 2);
            this.receivedLabelReturnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.receivedLabelReturnPay.Name = "receivedLabelReturnPay";
            this.receivedLabelReturnPay.Size = new System.Drawing.Size(122, 22);
            this.receivedLabelReturnPay.TabIndex = 8;
            this.receivedLabelReturnPay.Text = "0,00 ₽";
            // 
            // panelReceivedL2
            // 
            this.panelReceivedL2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelReceivedL2.Controls.Add(this.flowLayoutPanelReceivedL2);
            this.panelReceivedL2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceivedL2.Location = new System.Drawing.Point(0, 48);
            this.panelReceivedL2.Name = "panelReceivedL2";
            this.panelReceivedL2.Size = new System.Drawing.Size(1002, 44);
            this.panelReceivedL2.TabIndex = 9;
            // 
            // flowLayoutPanelReceivedL2
            // 
            this.flowLayoutPanelReceivedL2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelReceivedL2.Controls.Add(this.receivedLabelInfoDate);
            this.flowLayoutPanelReceivedL2.Controls.Add(this.receivedToggleButtonCalendar);
            this.flowLayoutPanelReceivedL2.Controls.Add(this.receivedDateTimePickerStart);
            this.flowLayoutPanelReceivedL2.Controls.Add(this.receivedDateTimePickerEnd);
            this.flowLayoutPanelReceivedL2.Controls.Add(this.receivedDateTimePickerMonth);
            this.flowLayoutPanelReceivedL2.Controls.Add(this.receivedBtnDateMinus);
            this.flowLayoutPanelReceivedL2.Controls.Add(this.receivedBtnDatePlus);
            this.flowLayoutPanelReceivedL2.Location = new System.Drawing.Point(3, 5);
            this.flowLayoutPanelReceivedL2.Name = "flowLayoutPanelReceivedL2";
            this.flowLayoutPanelReceivedL2.Size = new System.Drawing.Size(989, 34);
            this.flowLayoutPanelReceivedL2.TabIndex = 27;
            this.flowLayoutPanelReceivedL2.WrapContents = false;
            // 
            // receivedLabelInfoDate
            // 
            this.receivedLabelInfoDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.receivedLabelInfoDate.AutoSize = true;
            this.receivedLabelInfoDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedLabelInfoDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.receivedLabelInfoDate.Location = new System.Drawing.Point(6, 6);
            this.receivedLabelInfoDate.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.receivedLabelInfoDate.Name = "receivedLabelInfoDate";
            this.receivedLabelInfoDate.Size = new System.Drawing.Size(46, 20);
            this.receivedLabelInfoDate.TabIndex = 1;
            this.receivedLabelInfoDate.Text = "Дата:";
            // 
            // receivedToggleButtonCalendar
            // 
            this.receivedToggleButtonCalendar.AutoSize = true;
            this.receivedToggleButtonCalendar.DisableBackColor = System.Drawing.Color.DimGray;
            this.receivedToggleButtonCalendar.DisableToggleColor = System.Drawing.Color.Gray;
            this.receivedToggleButtonCalendar.Location = new System.Drawing.Point(58, 6);
            this.receivedToggleButtonCalendar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.receivedToggleButtonCalendar.MinimumSize = new System.Drawing.Size(45, 22);
            this.receivedToggleButtonCalendar.Name = "receivedToggleButtonCalendar";
            this.receivedToggleButtonCalendar.OffBackColor = System.Drawing.Color.Firebrick;
            this.receivedToggleButtonCalendar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.receivedToggleButtonCalendar.OnBackColor = System.Drawing.Color.SeaGreen;
            this.receivedToggleButtonCalendar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.receivedToggleButtonCalendar.Size = new System.Drawing.Size(45, 22);
            this.receivedToggleButtonCalendar.TabIndex = 36;
            this.receivedToggleButtonCalendar.UseVisualStyleBackColor = true;
            this.receivedToggleButtonCalendar.CheckedChanged += new System.EventHandler(this.receivedToggleButtonCalendar_CheckedChanged);
            // 
            // receivedDateTimePickerStart
            // 
            this.receivedDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.receivedDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.receivedDateTimePickerStart.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.receivedDateTimePickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.receivedDateTimePickerStart.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.receivedDateTimePickerStart.Location = new System.Drawing.Point(109, 3);
            this.receivedDateTimePickerStart.Name = "receivedDateTimePickerStart";
            this.receivedDateTimePickerStart.Size = new System.Drawing.Size(220, 29);
            this.receivedDateTimePickerStart.TabIndex = 32;
            this.receivedDateTimePickerStart.ValueChanged += new System.EventHandler(this.receivedDateTimePickerStart_ValueChanged);
            // 
            // receivedDateTimePickerEnd
            // 
            this.receivedDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.receivedDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.receivedDateTimePickerEnd.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.receivedDateTimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.receivedDateTimePickerEnd.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.receivedDateTimePickerEnd.Location = new System.Drawing.Point(335, 3);
            this.receivedDateTimePickerEnd.Name = "receivedDateTimePickerEnd";
            this.receivedDateTimePickerEnd.Size = new System.Drawing.Size(200, 29);
            this.receivedDateTimePickerEnd.TabIndex = 33;
            // 
            // receivedDateTimePickerMonth
            // 
            this.receivedDateTimePickerMonth.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.receivedDateTimePickerMonth.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.receivedDateTimePickerMonth.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.receivedDateTimePickerMonth.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.receivedDateTimePickerMonth.CustomFormat = "MMMM yyyy";
            this.receivedDateTimePickerMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.receivedDateTimePickerMonth.Location = new System.Drawing.Point(541, 3);
            this.receivedDateTimePickerMonth.Name = "receivedDateTimePickerMonth";
            this.receivedDateTimePickerMonth.ShowUpDown = true;
            this.receivedDateTimePickerMonth.Size = new System.Drawing.Size(220, 29);
            this.receivedDateTimePickerMonth.TabIndex = 35;
            this.receivedDateTimePickerMonth.Visible = false;
            // 
            // receivedBtnDateMinus
            // 
            this.receivedBtnDateMinus.BackColor = System.Drawing.Color.Firebrick;
            this.receivedBtnDateMinus.BorderColor = System.Drawing.Color.Silver;
            this.receivedBtnDateMinus.BorderRadius = 4F;
            this.receivedBtnDateMinus.BorderSize = 0;
            this.receivedBtnDateMinus.DisableBackColor = System.Drawing.Color.DimGray;
            this.receivedBtnDateMinus.DisableBorderColor = System.Drawing.Color.Silver;
            this.receivedBtnDateMinus.FlatAppearance.BorderSize = 0;
            this.receivedBtnDateMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.receivedBtnDateMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receivedBtnDateMinus.ForeColor = System.Drawing.Color.White;
            this.receivedBtnDateMinus.Image = global::DwUtils.Properties.Resources.minus_16;
            this.receivedBtnDateMinus.Location = new System.Drawing.Point(764, 3);
            this.receivedBtnDateMinus.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.receivedBtnDateMinus.MouseDownBackColor = System.Drawing.Color.Empty;
            this.receivedBtnDateMinus.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.receivedBtnDateMinus.Name = "receivedBtnDateMinus";
            this.receivedBtnDateMinus.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.receivedBtnDateMinus.Size = new System.Drawing.Size(28, 28);
            this.receivedBtnDateMinus.TabIndex = 38;
            this.receivedBtnDateMinus.TextColor = System.Drawing.Color.White;
            this.receivedBtnDateMinus.UseVisualStyleBackColor = false;
            this.receivedBtnDateMinus.Click += new System.EventHandler(this.receivedBtnDateMinus_Click);
            // 
            // receivedBtnDatePlus
            // 
            this.receivedBtnDatePlus.BackColor = System.Drawing.Color.SeaGreen;
            this.receivedBtnDatePlus.BorderColor = System.Drawing.Color.Silver;
            this.receivedBtnDatePlus.BorderRadius = 4F;
            this.receivedBtnDatePlus.BorderSize = 0;
            this.receivedBtnDatePlus.DisableBackColor = System.Drawing.Color.DimGray;
            this.receivedBtnDatePlus.DisableBorderColor = System.Drawing.Color.Silver;
            this.receivedBtnDatePlus.FlatAppearance.BorderSize = 0;
            this.receivedBtnDatePlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.receivedBtnDatePlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receivedBtnDatePlus.ForeColor = System.Drawing.Color.White;
            this.receivedBtnDatePlus.Image = global::DwUtils.Properties.Resources.plus_16;
            this.receivedBtnDatePlus.Location = new System.Drawing.Point(792, 3);
            this.receivedBtnDatePlus.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.receivedBtnDatePlus.MouseDownBackColor = System.Drawing.Color.Empty;
            this.receivedBtnDatePlus.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.receivedBtnDatePlus.Name = "receivedBtnDatePlus";
            this.receivedBtnDatePlus.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.receivedBtnDatePlus.Size = new System.Drawing.Size(28, 28);
            this.receivedBtnDatePlus.TabIndex = 37;
            this.receivedBtnDatePlus.TextColor = System.Drawing.Color.White;
            this.receivedBtnDatePlus.UseVisualStyleBackColor = false;
            this.receivedBtnDatePlus.Click += new System.EventHandler(this.receivedBtnDatePlus_Click);
            // 
            // panelReceivedL1
            // 
            this.panelReceivedL1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelReceivedL1.Controls.Add(this.btnPrintReceived);
            this.panelReceivedL1.Controls.Add(this.btnLoadReceived);
            this.panelReceivedL1.Controls.Add(this.flowLayoutPanelReceivedL1);
            this.panelReceivedL1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceivedL1.Location = new System.Drawing.Point(0, 0);
            this.panelReceivedL1.Name = "panelReceivedL1";
            this.panelReceivedL1.Size = new System.Drawing.Size(1002, 48);
            this.panelReceivedL1.TabIndex = 6;
            // 
            // btnPrintReceived
            // 
            this.btnPrintReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReceived.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrintReceived.BorderColor = System.Drawing.Color.Silver;
            this.btnPrintReceived.BorderRadius = 6F;
            this.btnPrintReceived.BorderSize = 0;
            this.btnPrintReceived.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnPrintReceived.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnPrintReceived.Enabled = false;
            this.btnPrintReceived.FlatAppearance.BorderSize = 0;
            this.btnPrintReceived.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnPrintReceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceived.ForeColor = System.Drawing.Color.White;
            this.btnPrintReceived.Image = global::DwUtils.Properties.Resources.printer_3_24;
            this.btnPrintReceived.Location = new System.Drawing.Point(906, 4);
            this.btnPrintReceived.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnPrintReceived.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnPrintReceived.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnPrintReceived.Name = "btnPrintReceived";
            this.btnPrintReceived.Padding = new System.Windows.Forms.Padding(5, 0, 4, 0);
            this.btnPrintReceived.Size = new System.Drawing.Size(40, 40);
            this.btnPrintReceived.TabIndex = 0;
            this.btnPrintReceived.TabStop = false;
            this.btnPrintReceived.TextColor = System.Drawing.Color.White;
            this.btnPrintReceived.UseVisualStyleBackColor = false;
            this.btnPrintReceived.Click += new System.EventHandler(this.btnPrintReceived_Click);
            // 
            // btnLoadReceived
            // 
            this.btnLoadReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadReceived.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadReceived.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadReceived.BorderRadius = 6F;
            this.btnLoadReceived.BorderSize = 0;
            this.btnLoadReceived.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadReceived.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadReceived.FlatAppearance.BorderSize = 0;
            this.btnLoadReceived.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLoadReceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadReceived.ForeColor = System.Drawing.Color.White;
            this.btnLoadReceived.Image = global::DwUtils.Properties.Resources.synchronize_24;
            this.btnLoadReceived.Location = new System.Drawing.Point(952, 4);
            this.btnLoadReceived.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnLoadReceived.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnLoadReceived.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLoadReceived.Name = "btnLoadReceived";
            this.btnLoadReceived.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadReceived.Size = new System.Drawing.Size(40, 40);
            this.btnLoadReceived.TabIndex = 0;
            this.btnLoadReceived.TabStop = false;
            this.btnLoadReceived.TextColor = System.Drawing.Color.White;
            this.btnLoadReceived.UseVisualStyleBackColor = false;
            this.btnLoadReceived.Click += new System.EventHandler(this.btnLoadReceived_Click);
            // 
            // flowLayoutPanelReceivedL1
            // 
            this.flowLayoutPanelReceivedL1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelReceivedL1.Controls.Add(this.receivedLabelInfoUsers);
            this.flowLayoutPanelReceivedL1.Controls.Add(this.receivedComboBoxUsers);
            this.flowLayoutPanelReceivedL1.Controls.Add(this.receivedLabelInfoReportType);
            this.flowLayoutPanelReceivedL1.Controls.Add(this.receivedComboBoxReportType);
            this.flowLayoutPanelReceivedL1.Location = new System.Drawing.Point(3, 7);
            this.flowLayoutPanelReceivedL1.Name = "flowLayoutPanelReceivedL1";
            this.flowLayoutPanelReceivedL1.Size = new System.Drawing.Size(897, 34);
            this.flowLayoutPanelReceivedL1.TabIndex = 27;
            this.flowLayoutPanelReceivedL1.WrapContents = false;
            // 
            // receivedLabelInfoUsers
            // 
            this.receivedLabelInfoUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.receivedLabelInfoUsers.AutoSize = true;
            this.receivedLabelInfoUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedLabelInfoUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.receivedLabelInfoUsers.Location = new System.Drawing.Point(6, 6);
            this.receivedLabelInfoUsers.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.receivedLabelInfoUsers.Name = "receivedLabelInfoUsers";
            this.receivedLabelInfoUsers.Size = new System.Drawing.Size(111, 20);
            this.receivedLabelInfoUsers.TabIndex = 1;
            this.receivedLabelInfoUsers.Text = "Пользователь:";
            // 
            // receivedComboBoxUsers
            // 
            this.receivedComboBoxUsers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.receivedComboBoxUsers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.receivedComboBoxUsers.DataSource = this.userBindingSource;
            this.receivedComboBoxUsers.DisplayMember = "Name";
            this.receivedComboBoxUsers.FormattingEnabled = true;
            this.receivedComboBoxUsers.Location = new System.Drawing.Point(123, 3);
            this.receivedComboBoxUsers.Name = "receivedComboBoxUsers";
            this.receivedComboBoxUsers.Size = new System.Drawing.Size(234, 29);
            this.receivedComboBoxUsers.TabIndex = 2;
            this.receivedComboBoxUsers.ValueMember = "Id";
            // 
            // receivedLabelInfoReportType
            // 
            this.receivedLabelInfoReportType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.receivedLabelInfoReportType.AutoSize = true;
            this.receivedLabelInfoReportType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedLabelInfoReportType.ForeColor = System.Drawing.Color.Gainsboro;
            this.receivedLabelInfoReportType.Location = new System.Drawing.Point(366, 6);
            this.receivedLabelInfoReportType.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.receivedLabelInfoReportType.Name = "receivedLabelInfoReportType";
            this.receivedLabelInfoReportType.Size = new System.Drawing.Size(53, 20);
            this.receivedLabelInfoReportType.TabIndex = 3;
            this.receivedLabelInfoReportType.Text = "Отчет:";
            // 
            // receivedComboBoxReportType
            // 
            this.receivedComboBoxReportType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.receivedComboBoxReportType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.receivedComboBoxReportType.DataSource = this.receiveRpoReportTypeBindingSource;
            this.receivedComboBoxReportType.DisplayMember = "Name";
            this.receivedComboBoxReportType.FormattingEnabled = true;
            this.receivedComboBoxReportType.Location = new System.Drawing.Point(425, 3);
            this.receivedComboBoxReportType.Name = "receivedComboBoxReportType";
            this.receivedComboBoxReportType.Size = new System.Drawing.Size(173, 29);
            this.receivedComboBoxReportType.TabIndex = 4;
            this.receivedComboBoxReportType.ValueMember = "Id";
            // 
            // receiveRpoReportTypeBindingSource
            // 
            this.receiveRpoReportTypeBindingSource.DataSource = typeof(DwUtils.Core.Types.ReceiveRpoReportType);
            // 
            // tabDelivery
            // 
            this.tabDelivery.Controls.Add(this.deliveryPictureBox);
            this.tabDelivery.Controls.Add(this.panelDeliveryL1);
            this.tabDelivery.Location = new System.Drawing.Point(4, 36);
            this.tabDelivery.Name = "tabDelivery";
            this.tabDelivery.Size = new System.Drawing.Size(1002, 373);
            this.tabDelivery.TabIndex = 2;
            this.tabDelivery.Text = "Вручено";
            this.tabDelivery.UseVisualStyleBackColor = true;
            // 
            // deliveryPictureBox
            // 
            this.deliveryPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deliveryPictureBox.Image = global::DwUtils.Properties.Resources.no_result;
            this.deliveryPictureBox.Location = new System.Drawing.Point(0, 48);
            this.deliveryPictureBox.Name = "deliveryPictureBox";
            this.deliveryPictureBox.Size = new System.Drawing.Size(1002, 325);
            this.deliveryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deliveryPictureBox.TabIndex = 8;
            this.deliveryPictureBox.TabStop = false;
            // 
            // panelDeliveryL1
            // 
            this.panelDeliveryL1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelDeliveryL1.Controls.Add(this.btnPrintDelivery);
            this.panelDeliveryL1.Controls.Add(this.btnLoadDelivery);
            this.panelDeliveryL1.Controls.Add(this.flowLayoutPanelDeliveryL1);
            this.panelDeliveryL1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeliveryL1.Location = new System.Drawing.Point(0, 0);
            this.panelDeliveryL1.Name = "panelDeliveryL1";
            this.panelDeliveryL1.Size = new System.Drawing.Size(1002, 48);
            this.panelDeliveryL1.TabIndex = 7;
            // 
            // btnPrintDelivery
            // 
            this.btnPrintDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintDelivery.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrintDelivery.BorderColor = System.Drawing.Color.Silver;
            this.btnPrintDelivery.BorderRadius = 6F;
            this.btnPrintDelivery.BorderSize = 0;
            this.btnPrintDelivery.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnPrintDelivery.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnPrintDelivery.FlatAppearance.BorderSize = 0;
            this.btnPrintDelivery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnPrintDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintDelivery.ForeColor = System.Drawing.Color.White;
            this.btnPrintDelivery.Image = global::DwUtils.Properties.Resources.printer_3_24;
            this.btnPrintDelivery.Location = new System.Drawing.Point(906, 4);
            this.btnPrintDelivery.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnPrintDelivery.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnPrintDelivery.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnPrintDelivery.Name = "btnPrintDelivery";
            this.btnPrintDelivery.Padding = new System.Windows.Forms.Padding(5, 0, 4, 0);
            this.btnPrintDelivery.Size = new System.Drawing.Size(40, 40);
            this.btnPrintDelivery.TabIndex = 0;
            this.btnPrintDelivery.TabStop = false;
            this.btnPrintDelivery.TextColor = System.Drawing.Color.White;
            this.btnPrintDelivery.UseVisualStyleBackColor = false;
            // 
            // btnLoadDelivery
            // 
            this.btnLoadDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadDelivery.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadDelivery.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadDelivery.BorderRadius = 6F;
            this.btnLoadDelivery.BorderSize = 0;
            this.btnLoadDelivery.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadDelivery.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadDelivery.Enabled = false;
            this.btnLoadDelivery.FlatAppearance.BorderSize = 0;
            this.btnLoadDelivery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLoadDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDelivery.ForeColor = System.Drawing.Color.White;
            this.btnLoadDelivery.Image = global::DwUtils.Properties.Resources.synchronize_24;
            this.btnLoadDelivery.Location = new System.Drawing.Point(952, 4);
            this.btnLoadDelivery.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnLoadDelivery.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnLoadDelivery.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLoadDelivery.Name = "btnLoadDelivery";
            this.btnLoadDelivery.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadDelivery.Size = new System.Drawing.Size(40, 40);
            this.btnLoadDelivery.TabIndex = 0;
            this.btnLoadDelivery.TabStop = false;
            this.btnLoadDelivery.TextColor = System.Drawing.Color.White;
            this.btnLoadDelivery.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelDeliveryL1
            // 
            this.flowLayoutPanelDeliveryL1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelDeliveryL1.Location = new System.Drawing.Point(3, 7);
            this.flowLayoutPanelDeliveryL1.Name = "flowLayoutPanelDeliveryL1";
            this.flowLayoutPanelDeliveryL1.Size = new System.Drawing.Size(897, 34);
            this.flowLayoutPanelDeliveryL1.TabIndex = 27;
            this.flowLayoutPanelDeliveryL1.WrapContents = false;
            // 
            // tabFiles
            // 
            this.tabFiles.Controls.Add(this.filesDataGridView);
            this.tabFiles.Controls.Add(this.filesPanelStat);
            this.tabFiles.Controls.Add(this.panelFilesL2);
            this.tabFiles.Controls.Add(this.panelFilesL1);
            this.tabFiles.Location = new System.Drawing.Point(4, 36);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Size = new System.Drawing.Size(1002, 373);
            this.tabFiles.TabIndex = 4;
            this.tabFiles.Text = "Файлы";
            this.tabFiles.UseVisualStyleBackColor = true;
            // 
            // filesDataGridView
            // 
            this.filesDataGridView.AllowUserToAddRows = false;
            this.filesDataGridView.AllowUserToDeleteRows = false;
            this.filesDataGridView.AllowUserToResizeColumns = false;
            this.filesDataGridView.AllowUserToResizeRows = false;
            this.filesDataGridView.AutoGenerateColumns = false;
            this.filesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.filesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.filesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.filesDataGridView.ColumnHeadersHeight = 40;
            this.filesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.filesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filesColumnName,
            this.filesColumnDate,
            this.filesColumnDayName,
            this.filesColumnUserId,
            this.filesColumnCount});
            this.filesDataGridView.DataSource = this.rpoFileBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.filesDataGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.filesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesDataGridView.EnableHeadersVisualStyles = false;
            this.filesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.filesDataGridView.Location = new System.Drawing.Point(0, 92);
            this.filesDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.filesDataGridView.Name = "filesDataGridView";
            this.filesDataGridView.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.filesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.filesDataGridView.RowHeadersVisible = false;
            this.filesDataGridView.RowHeadersWidth = 40;
            this.filesDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.filesDataGridView.RowTemplate.Height = 40;
            this.filesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.filesDataGridView.Size = new System.Drawing.Size(1002, 251);
            this.filesDataGridView.TabIndex = 11;
            this.filesDataGridView.TabStop = false;
            // 
            // filesColumnName
            // 
            this.filesColumnName.DataPropertyName = "Name";
            this.filesColumnName.HeaderText = "Файл";
            this.filesColumnName.Name = "filesColumnName";
            this.filesColumnName.ReadOnly = true;
            // 
            // filesColumnDate
            // 
            this.filesColumnDate.DataPropertyName = "DateName";
            dataGridViewCellStyle9.Format = "G";
            dataGridViewCellStyle9.NullValue = null;
            this.filesColumnDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.filesColumnDate.HeaderText = "Выгружено";
            this.filesColumnDate.Name = "filesColumnDate";
            this.filesColumnDate.ReadOnly = true;
            // 
            // filesColumnDayName
            // 
            this.filesColumnDayName.DataPropertyName = "DayName";
            this.filesColumnDayName.HeaderText = "День";
            this.filesColumnDayName.Name = "filesColumnDayName";
            this.filesColumnDayName.ReadOnly = true;
            // 
            // filesColumnUserId
            // 
            this.filesColumnUserId.DataPropertyName = "UserId";
            this.filesColumnUserId.DataSource = this.userBindingSource;
            this.filesColumnUserId.DisplayMember = "Name";
            this.filesColumnUserId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.filesColumnUserId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filesColumnUserId.HeaderText = "Пользователь";
            this.filesColumnUserId.Name = "filesColumnUserId";
            this.filesColumnUserId.ReadOnly = true;
            this.filesColumnUserId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.filesColumnUserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.filesColumnUserId.ValueMember = "Id";
            // 
            // filesColumnCount
            // 
            this.filesColumnCount.DataPropertyName = "Count";
            this.filesColumnCount.HeaderText = "Кол-во";
            this.filesColumnCount.Name = "filesColumnCount";
            this.filesColumnCount.ReadOnly = true;
            // 
            // rpoFileBindingSource
            // 
            this.rpoFileBindingSource.DataSource = typeof(DwUtils.Core.Database.Models.RpoFile);
            // 
            // filesPanelStat
            // 
            this.filesPanelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.filesPanelStat.Controls.Add(this.flowLayoutPanelFilesStat);
            this.filesPanelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filesPanelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.filesPanelStat.Location = new System.Drawing.Point(0, 343);
            this.filesPanelStat.Name = "filesPanelStat";
            this.filesPanelStat.Size = new System.Drawing.Size(1002, 30);
            this.filesPanelStat.TabIndex = 10;
            // 
            // flowLayoutPanelFilesStat
            // 
            this.flowLayoutPanelFilesStat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelFilesStat.Controls.Add(this.filesLabelInfoCount);
            this.flowLayoutPanelFilesStat.Controls.Add(this.filesLabelCount);
            this.flowLayoutPanelFilesStat.Controls.Add(this.filesLabelInfoRpoCount);
            this.flowLayoutPanelFilesStat.Controls.Add(this.filesLabelRpoCount);
            this.flowLayoutPanelFilesStat.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanelFilesStat.Name = "flowLayoutPanelFilesStat";
            this.flowLayoutPanelFilesStat.Size = new System.Drawing.Size(999, 26);
            this.flowLayoutPanelFilesStat.TabIndex = 1;
            this.flowLayoutPanelFilesStat.WrapContents = false;
            // 
            // filesLabelInfoCount
            // 
            this.filesLabelInfoCount.AutoSize = true;
            this.filesLabelInfoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesLabelInfoCount.Location = new System.Drawing.Point(8, 2);
            this.filesLabelInfoCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.filesLabelInfoCount.Name = "filesLabelInfoCount";
            this.filesLabelInfoCount.Size = new System.Drawing.Size(52, 20);
            this.filesLabelInfoCount.TabIndex = 0;
            this.filesLabelInfoCount.Text = "Всего:";
            // 
            // filesLabelCount
            // 
            this.filesLabelCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesLabelCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.filesLabelCount.Location = new System.Drawing.Point(66, 2);
            this.filesLabelCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.filesLabelCount.Name = "filesLabelCount";
            this.filesLabelCount.Size = new System.Drawing.Size(90, 22);
            this.filesLabelCount.TabIndex = 0;
            this.filesLabelCount.Text = "0";
            // 
            // filesLabelInfoRpoCount
            // 
            this.filesLabelInfoRpoCount.AutoSize = true;
            this.filesLabelInfoRpoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesLabelInfoRpoCount.Location = new System.Drawing.Point(167, 2);
            this.filesLabelInfoRpoCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.filesLabelInfoRpoCount.Name = "filesLabelInfoRpoCount";
            this.filesLabelInfoRpoCount.Size = new System.Drawing.Size(107, 20);
            this.filesLabelInfoRpoCount.TabIndex = 1;
            this.filesLabelInfoRpoCount.Text = "Отправлений:";
            // 
            // filesLabelRpoCount
            // 
            this.filesLabelRpoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesLabelRpoCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.filesLabelRpoCount.Location = new System.Drawing.Point(280, 2);
            this.filesLabelRpoCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.filesLabelRpoCount.Name = "filesLabelRpoCount";
            this.filesLabelRpoCount.Size = new System.Drawing.Size(90, 22);
            this.filesLabelRpoCount.TabIndex = 2;
            this.filesLabelRpoCount.Text = "0";
            // 
            // panelFilesL2
            // 
            this.panelFilesL2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelFilesL2.Controls.Add(this.flowLayoutPanelFilesL2);
            this.panelFilesL2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilesL2.Location = new System.Drawing.Point(0, 48);
            this.panelFilesL2.Name = "panelFilesL2";
            this.panelFilesL2.Size = new System.Drawing.Size(1002, 44);
            this.panelFilesL2.TabIndex = 9;
            // 
            // flowLayoutPanelFilesL2
            // 
            this.flowLayoutPanelFilesL2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelFilesL2.Controls.Add(this.filesLabelInfoDate);
            this.flowLayoutPanelFilesL2.Controls.Add(this.filesToggleButtonDate);
            this.flowLayoutPanelFilesL2.Controls.Add(this.filesDateTimePickerStart);
            this.flowLayoutPanelFilesL2.Controls.Add(this.filesDateTimePickerEnd);
            this.flowLayoutPanelFilesL2.Location = new System.Drawing.Point(3, 5);
            this.flowLayoutPanelFilesL2.Name = "flowLayoutPanelFilesL2";
            this.flowLayoutPanelFilesL2.Size = new System.Drawing.Size(989, 34);
            this.flowLayoutPanelFilesL2.TabIndex = 27;
            this.flowLayoutPanelFilesL2.WrapContents = false;
            // 
            // filesLabelInfoDate
            // 
            this.filesLabelInfoDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filesLabelInfoDate.AutoSize = true;
            this.filesLabelInfoDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesLabelInfoDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.filesLabelInfoDate.Location = new System.Drawing.Point(6, 6);
            this.filesLabelInfoDate.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.filesLabelInfoDate.Name = "filesLabelInfoDate";
            this.filesLabelInfoDate.Size = new System.Drawing.Size(46, 20);
            this.filesLabelInfoDate.TabIndex = 1;
            this.filesLabelInfoDate.Text = "Дата:";
            // 
            // filesToggleButtonDate
            // 
            this.filesToggleButtonDate.AutoSize = true;
            this.filesToggleButtonDate.DisableBackColor = System.Drawing.Color.DimGray;
            this.filesToggleButtonDate.DisableToggleColor = System.Drawing.Color.Gray;
            this.filesToggleButtonDate.Location = new System.Drawing.Point(58, 6);
            this.filesToggleButtonDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.filesToggleButtonDate.MinimumSize = new System.Drawing.Size(45, 22);
            this.filesToggleButtonDate.Name = "filesToggleButtonDate";
            this.filesToggleButtonDate.OffBackColor = System.Drawing.Color.DimGray;
            this.filesToggleButtonDate.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.filesToggleButtonDate.OnBackColor = System.Drawing.Color.SeaGreen;
            this.filesToggleButtonDate.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.filesToggleButtonDate.Size = new System.Drawing.Size(45, 22);
            this.filesToggleButtonDate.TabIndex = 34;
            this.filesToggleButtonDate.UseVisualStyleBackColor = true;
            this.filesToggleButtonDate.CheckedChanged += new System.EventHandler(this.filesToggleButtonDate_CheckedChanged);
            // 
            // filesDateTimePickerStart
            // 
            this.filesDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.filesDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.filesDateTimePickerStart.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.filesDateTimePickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.filesDateTimePickerStart.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.filesDateTimePickerStart.Enabled = false;
            this.filesDateTimePickerStart.Location = new System.Drawing.Point(109, 3);
            this.filesDateTimePickerStart.Name = "filesDateTimePickerStart";
            this.filesDateTimePickerStart.Size = new System.Drawing.Size(220, 29);
            this.filesDateTimePickerStart.TabIndex = 32;
            this.filesDateTimePickerStart.ValueChanged += new System.EventHandler(this.filesDateTimePickerStart_ValueChanged);
            // 
            // filesDateTimePickerEnd
            // 
            this.filesDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.filesDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.filesDateTimePickerEnd.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.filesDateTimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.filesDateTimePickerEnd.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.filesDateTimePickerEnd.Enabled = false;
            this.filesDateTimePickerEnd.Location = new System.Drawing.Point(335, 3);
            this.filesDateTimePickerEnd.Name = "filesDateTimePickerEnd";
            this.filesDateTimePickerEnd.Size = new System.Drawing.Size(200, 29);
            this.filesDateTimePickerEnd.TabIndex = 33;
            // 
            // panelFilesL1
            // 
            this.panelFilesL1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelFilesL1.Controls.Add(this.btnLoadFiles);
            this.panelFilesL1.Controls.Add(this.flowLayoutPanelFilesL1);
            this.panelFilesL1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilesL1.Location = new System.Drawing.Point(0, 0);
            this.panelFilesL1.Name = "panelFilesL1";
            this.panelFilesL1.Size = new System.Drawing.Size(1002, 48);
            this.panelFilesL1.TabIndex = 6;
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFiles.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadFiles.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadFiles.BorderRadius = 6F;
            this.btnLoadFiles.BorderSize = 0;
            this.btnLoadFiles.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadFiles.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadFiles.FlatAppearance.BorderSize = 0;
            this.btnLoadFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLoadFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFiles.ForeColor = System.Drawing.Color.White;
            this.btnLoadFiles.Image = global::DwUtils.Properties.Resources.synchronize_24;
            this.btnLoadFiles.Location = new System.Drawing.Point(952, 4);
            this.btnLoadFiles.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnLoadFiles.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnLoadFiles.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadFiles.Size = new System.Drawing.Size(40, 40);
            this.btnLoadFiles.TabIndex = 0;
            this.btnLoadFiles.TabStop = false;
            this.btnLoadFiles.TextColor = System.Drawing.Color.White;
            this.btnLoadFiles.UseVisualStyleBackColor = false;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // flowLayoutPanelFilesL1
            // 
            this.flowLayoutPanelFilesL1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelFilesL1.Controls.Add(this.filesLabelInfoUsers);
            this.flowLayoutPanelFilesL1.Controls.Add(this.filesComboBoxUsers);
            this.flowLayoutPanelFilesL1.Controls.Add(this.filesLabelInfoLimit);
            this.flowLayoutPanelFilesL1.Controls.Add(this.filesToggleButtonLimit);
            this.flowLayoutPanelFilesL1.Controls.Add(this.filesLimit);
            this.flowLayoutPanelFilesL1.Location = new System.Drawing.Point(3, 7);
            this.flowLayoutPanelFilesL1.Name = "flowLayoutPanelFilesL1";
            this.flowLayoutPanelFilesL1.Size = new System.Drawing.Size(943, 34);
            this.flowLayoutPanelFilesL1.TabIndex = 27;
            this.flowLayoutPanelFilesL1.WrapContents = false;
            // 
            // filesLabelInfoUsers
            // 
            this.filesLabelInfoUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filesLabelInfoUsers.AutoSize = true;
            this.filesLabelInfoUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesLabelInfoUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.filesLabelInfoUsers.Location = new System.Drawing.Point(6, 6);
            this.filesLabelInfoUsers.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.filesLabelInfoUsers.Name = "filesLabelInfoUsers";
            this.filesLabelInfoUsers.Size = new System.Drawing.Size(111, 20);
            this.filesLabelInfoUsers.TabIndex = 0;
            this.filesLabelInfoUsers.Text = "Пользователь:";
            // 
            // filesComboBoxUsers
            // 
            this.filesComboBoxUsers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.filesComboBoxUsers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filesComboBoxUsers.DataSource = this.userBindingSource;
            this.filesComboBoxUsers.DisplayMember = "Name";
            this.filesComboBoxUsers.FormattingEnabled = true;
            this.filesComboBoxUsers.Location = new System.Drawing.Point(123, 3);
            this.filesComboBoxUsers.Name = "filesComboBoxUsers";
            this.filesComboBoxUsers.Size = new System.Drawing.Size(234, 29);
            this.filesComboBoxUsers.TabIndex = 0;
            this.filesComboBoxUsers.ValueMember = "Id";
            // 
            // filesLabelInfoLimit
            // 
            this.filesLabelInfoLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filesLabelInfoLimit.AutoSize = true;
            this.filesLabelInfoLimit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesLabelInfoLimit.ForeColor = System.Drawing.Color.Gainsboro;
            this.filesLabelInfoLimit.Location = new System.Drawing.Point(366, 6);
            this.filesLabelInfoLimit.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.filesLabelInfoLimit.Name = "filesLabelInfoLimit";
            this.filesLabelInfoLimit.Size = new System.Drawing.Size(58, 20);
            this.filesLabelInfoLimit.TabIndex = 1;
            this.filesLabelInfoLimit.Text = "Лимит:";
            // 
            // filesToggleButtonLimit
            // 
            this.filesToggleButtonLimit.AutoSize = true;
            this.filesToggleButtonLimit.Checked = true;
            this.filesToggleButtonLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filesToggleButtonLimit.DisableBackColor = System.Drawing.Color.DimGray;
            this.filesToggleButtonLimit.DisableToggleColor = System.Drawing.Color.Gray;
            this.filesToggleButtonLimit.Location = new System.Drawing.Point(430, 6);
            this.filesToggleButtonLimit.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.filesToggleButtonLimit.MinimumSize = new System.Drawing.Size(45, 22);
            this.filesToggleButtonLimit.Name = "filesToggleButtonLimit";
            this.filesToggleButtonLimit.OffBackColor = System.Drawing.Color.DimGray;
            this.filesToggleButtonLimit.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.filesToggleButtonLimit.OnBackColor = System.Drawing.Color.SeaGreen;
            this.filesToggleButtonLimit.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.filesToggleButtonLimit.Size = new System.Drawing.Size(45, 22);
            this.filesToggleButtonLimit.TabIndex = 35;
            this.filesToggleButtonLimit.UseVisualStyleBackColor = true;
            this.filesToggleButtonLimit.CheckedChanged += new System.EventHandler(this.filesToggleButtonLimit_CheckedChanged);
            // 
            // filesLimit
            // 
            this.filesLimit.Location = new System.Drawing.Point(481, 3);
            this.filesLimit.Name = "filesLimit";
            this.filesLimit.Size = new System.Drawing.Size(59, 29);
            this.filesLimit.TabIndex = 36;
            this.filesLimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tabConnected
            // 
            this.tabConnected.Controls.Add(this.panelOnlineStat);
            this.tabConnected.Controls.Add(this.onlineDataGridView);
            this.tabConnected.Controls.Add(this.panelOnline);
            this.tabConnected.Location = new System.Drawing.Point(4, 36);
            this.tabConnected.Name = "tabConnected";
            this.tabConnected.Size = new System.Drawing.Size(1002, 373);
            this.tabConnected.TabIndex = 3;
            this.tabConnected.Text = "Онлайн";
            this.tabConnected.UseVisualStyleBackColor = true;
            // 
            // panelOnlineStat
            // 
            this.panelOnlineStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelOnlineStat.Controls.Add(this.flowLayoutPanelOnlineStat);
            this.panelOnlineStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOnlineStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelOnlineStat.Location = new System.Drawing.Point(0, 343);
            this.panelOnlineStat.Name = "panelOnlineStat";
            this.panelOnlineStat.Size = new System.Drawing.Size(1002, 30);
            this.panelOnlineStat.TabIndex = 8;
            // 
            // flowLayoutPanelOnlineStat
            // 
            this.flowLayoutPanelOnlineStat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelOnlineStat.Controls.Add(this.onlineLabelInfoCount);
            this.flowLayoutPanelOnlineStat.Controls.Add(this.onlineLabelCount);
            this.flowLayoutPanelOnlineStat.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanelOnlineStat.Name = "flowLayoutPanelOnlineStat";
            this.flowLayoutPanelOnlineStat.Size = new System.Drawing.Size(999, 26);
            this.flowLayoutPanelOnlineStat.TabIndex = 1;
            this.flowLayoutPanelOnlineStat.WrapContents = false;
            // 
            // onlineLabelInfoCount
            // 
            this.onlineLabelInfoCount.AutoSize = true;
            this.onlineLabelInfoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.onlineLabelInfoCount.Location = new System.Drawing.Point(8, 2);
            this.onlineLabelInfoCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.onlineLabelInfoCount.Name = "onlineLabelInfoCount";
            this.onlineLabelInfoCount.Size = new System.Drawing.Size(52, 20);
            this.onlineLabelInfoCount.TabIndex = 0;
            this.onlineLabelInfoCount.Text = "Всего:";
            // 
            // onlineLabelCount
            // 
            this.onlineLabelCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.onlineLabelCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.onlineLabelCount.Location = new System.Drawing.Point(66, 2);
            this.onlineLabelCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.onlineLabelCount.Name = "onlineLabelCount";
            this.onlineLabelCount.Size = new System.Drawing.Size(90, 22);
            this.onlineLabelCount.TabIndex = 0;
            this.onlineLabelCount.Text = "0";
            // 
            // onlineDataGridView
            // 
            this.onlineDataGridView.AllowUserToAddRows = false;
            this.onlineDataGridView.AllowUserToDeleteRows = false;
            this.onlineDataGridView.AllowUserToResizeColumns = false;
            this.onlineDataGridView.AllowUserToResizeRows = false;
            this.onlineDataGridView.AutoGenerateColumns = false;
            this.onlineDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.onlineDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.onlineDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.onlineDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.onlineDataGridView.ColumnHeadersHeight = 40;
            this.onlineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.onlineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.onlineColumnUserName,
            this.onlineColumnPlaceName,
            this.onlineColumnConnectDate,
            this.onlineColumnWorkDate,
            this.onlineColumnAdminStatus});
            this.onlineDataGridView.DataSource = this.connectUserBindingSource;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.onlineDataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.onlineDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onlineDataGridView.EnableHeadersVisualStyles = false;
            this.onlineDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.onlineDataGridView.Location = new System.Drawing.Point(0, 48);
            this.onlineDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.onlineDataGridView.Name = "onlineDataGridView";
            this.onlineDataGridView.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.onlineDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.onlineDataGridView.RowHeadersVisible = false;
            this.onlineDataGridView.RowHeadersWidth = 40;
            this.onlineDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.onlineDataGridView.RowTemplate.Height = 40;
            this.onlineDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.onlineDataGridView.Size = new System.Drawing.Size(1002, 325);
            this.onlineDataGridView.TabIndex = 7;
            this.onlineDataGridView.TabStop = false;
            this.onlineDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.onlineDataGridView_DataError);
            // 
            // onlineColumnUserName
            // 
            this.onlineColumnUserName.DataPropertyName = "UserName";
            this.onlineColumnUserName.HeaderText = "Пользователь";
            this.onlineColumnUserName.Name = "onlineColumnUserName";
            this.onlineColumnUserName.ReadOnly = true;
            // 
            // onlineColumnPlaceName
            // 
            this.onlineColumnPlaceName.DataPropertyName = "PlaceName";
            this.onlineColumnPlaceName.HeaderText = "Место";
            this.onlineColumnPlaceName.Name = "onlineColumnPlaceName";
            this.onlineColumnPlaceName.ReadOnly = true;
            // 
            // onlineColumnConnectDate
            // 
            this.onlineColumnConnectDate.DataPropertyName = "ConnectDate";
            this.onlineColumnConnectDate.HeaderText = "Подключился";
            this.onlineColumnConnectDate.Name = "onlineColumnConnectDate";
            this.onlineColumnConnectDate.ReadOnly = true;
            // 
            // onlineColumnWorkDate
            // 
            this.onlineColumnWorkDate.DataPropertyName = "WorkDate";
            this.onlineColumnWorkDate.HeaderText = "Работает";
            this.onlineColumnWorkDate.Name = "onlineColumnWorkDate";
            this.onlineColumnWorkDate.ReadOnly = true;
            // 
            // onlineColumnAdminStatus
            // 
            this.onlineColumnAdminStatus.DataPropertyName = "AdminStatus";
            this.onlineColumnAdminStatus.HeaderText = "Адм";
            this.onlineColumnAdminStatus.Name = "onlineColumnAdminStatus";
            this.onlineColumnAdminStatus.ReadOnly = true;
            // 
            // connectUserBindingSource
            // 
            this.connectUserBindingSource.DataSource = typeof(DwUtils.Core.Database.Models.ConnectUser);
            // 
            // panelOnline
            // 
            this.panelOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelOnline.Controls.Add(this.btnEditUser);
            this.panelOnline.Controls.Add(this.btnLoadConnectedUser);
            this.panelOnline.Controls.Add(this.flowLayoutPanelOnline);
            this.panelOnline.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOnline.Location = new System.Drawing.Point(0, 0);
            this.panelOnline.Name = "panelOnline";
            this.panelOnline.Size = new System.Drawing.Size(1002, 48);
            this.panelOnline.TabIndex = 6;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditUser.BorderColor = System.Drawing.Color.Silver;
            this.btnEditUser.BorderRadius = 6F;
            this.btnEditUser.BorderSize = 0;
            this.btnEditUser.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnEditUser.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.Image = global::DwUtils.Properties.Resources.edit_11_24;
            this.btnEditUser.Location = new System.Drawing.Point(906, 4);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnEditUser.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnEditUser.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Padding = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.btnEditUser.Size = new System.Drawing.Size(40, 40);
            this.btnEditUser.TabIndex = 0;
            this.btnEditUser.TabStop = false;
            this.btnEditUser.TextColor = System.Drawing.Color.White;
            this.btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnLoadConnectedUser
            // 
            this.btnLoadConnectedUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadConnectedUser.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoadConnectedUser.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadConnectedUser.BorderRadius = 6F;
            this.btnLoadConnectedUser.BorderSize = 0;
            this.btnLoadConnectedUser.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadConnectedUser.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadConnectedUser.FlatAppearance.BorderSize = 0;
            this.btnLoadConnectedUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLoadConnectedUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadConnectedUser.ForeColor = System.Drawing.Color.White;
            this.btnLoadConnectedUser.Image = global::DwUtils.Properties.Resources.synchronize_24;
            this.btnLoadConnectedUser.Location = new System.Drawing.Point(952, 4);
            this.btnLoadConnectedUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnLoadConnectedUser.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnLoadConnectedUser.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLoadConnectedUser.Name = "btnLoadConnectedUser";
            this.btnLoadConnectedUser.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadConnectedUser.Size = new System.Drawing.Size(40, 40);
            this.btnLoadConnectedUser.TabIndex = 0;
            this.btnLoadConnectedUser.TabStop = false;
            this.btnLoadConnectedUser.TextColor = System.Drawing.Color.White;
            this.btnLoadConnectedUser.UseVisualStyleBackColor = false;
            this.btnLoadConnectedUser.Click += new System.EventHandler(this.btnLoadConnectedUser_Click);
            // 
            // flowLayoutPanelOnline
            // 
            this.flowLayoutPanelOnline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelOnline.Location = new System.Drawing.Point(3, 7);
            this.flowLayoutPanelOnline.Name = "flowLayoutPanelOnline";
            this.flowLayoutPanelOnline.Size = new System.Drawing.Size(897, 34);
            this.flowLayoutPanelOnline.TabIndex = 27;
            this.flowLayoutPanelOnline.WrapContents = false;
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelGeneral.Controls.Add(this.numericUpDownCopies);
            this.panelGeneral.Controls.Add(this.lblInfoCopies);
            this.panelGeneral.Controls.Add(this.comboBoxPrinters);
            this.panelGeneral.Controls.Add(this.lblInfoPrinter);
            this.panelGeneral.Controls.Add(this.btnTest);
            this.panelGeneral.Controls.Add(this.labelInfoLoadLk);
            this.panelGeneral.Controls.Add(this.toggleLoadLk);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelGeneral.Location = new System.Drawing.Point(0, 42);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1010, 58);
            this.panelGeneral.TabIndex = 0;
            // 
            // comboBoxPrinters
            // 
            this.comboBoxPrinters.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxPrinters.FormattingEnabled = true;
            this.comboBoxPrinters.Location = new System.Drawing.Point(95, 17);
            this.comboBoxPrinters.Name = "comboBoxPrinters";
            this.comboBoxPrinters.Size = new System.Drawing.Size(225, 25);
            this.comboBoxPrinters.TabIndex = 0;
            this.comboBoxPrinters.TabStop = false;
            this.comboBoxPrinters.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrinters_SelectedIndexChanged);
            // 
            // lblInfoPrinter
            // 
            this.lblInfoPrinter.AutoSize = true;
            this.lblInfoPrinter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoPrinter.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInfoPrinter.Location = new System.Drawing.Point(15, 19);
            this.lblInfoPrinter.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.lblInfoPrinter.Name = "lblInfoPrinter";
            this.lblInfoPrinter.Size = new System.Drawing.Size(74, 20);
            this.lblInfoPrinter.TabIndex = 0;
            this.lblInfoPrinter.Text = "Принтер:";
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTest.BorderColor = System.Drawing.Color.Silver;
            this.btnTest.BorderRadius = 6F;
            this.btnTest.BorderSize = 0;
            this.btnTest.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnTest.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(668, 10);
            this.btnTest.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnTest.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnTest.Name = "btnTest";
            this.btnTest.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnTest.Size = new System.Drawing.Size(70, 40);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.TextColor = System.Drawing.Color.White;
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblInfoDebug
            // 
            this.lblInfoDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoDebug.AutoSize = true;
            this.lblInfoDebug.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoDebug.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInfoDebug.Location = new System.Drawing.Point(874, 11);
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
            this.toggleDebug.Location = new System.Drawing.Point(951, 10);
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
            this.toggleDebug.CheckedChanged += new System.EventHandler(this.toggleDebug_CheckedChanged);
            // 
            // labelInfoLoadLk
            // 
            this.labelInfoLoadLk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfoLoadLk.AutoSize = true;
            this.labelInfoLoadLk.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoLoadLk.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelInfoLoadLk.Location = new System.Drawing.Point(849, 19);
            this.labelInfoLoadLk.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.labelInfoLoadLk.Name = "labelInfoLoadLk";
            this.labelInfoLoadLk.Size = new System.Drawing.Size(98, 20);
            this.labelInfoLoadLk.TabIndex = 0;
            this.labelInfoLoadLk.Text = "Загрузка ЛК:";
            // 
            // toggleLoadLk
            // 
            this.toggleLoadLk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleLoadLk.AutoSize = true;
            this.toggleLoadLk.Checked = true;
            this.toggleLoadLk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleLoadLk.DisableBackColor = System.Drawing.Color.DimGray;
            this.toggleLoadLk.DisableToggleColor = System.Drawing.Color.Gray;
            this.toggleLoadLk.Location = new System.Drawing.Point(953, 18);
            this.toggleLoadLk.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleLoadLk.Name = "toggleLoadLk";
            this.toggleLoadLk.OffBackColor = System.Drawing.Color.Firebrick;
            this.toggleLoadLk.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleLoadLk.OnBackColor = System.Drawing.Color.SeaGreen;
            this.toggleLoadLk.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleLoadLk.Size = new System.Drawing.Size(45, 22);
            this.toggleLoadLk.TabIndex = 0;
            this.toggleLoadLk.TabStop = false;
            this.toggleLoadLk.UseVisualStyleBackColor = true;
            this.toggleLoadLk.CheckedChanged += new System.EventHandler(this.toggleLoadLk_CheckedChanged);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.panelMenu.Controls.Add(this.infosMenuItem);
            this.panelMenu.Controls.Add(this.settingsMenuItem);
            this.panelMenu.Controls.Add(this.fileMenuItem);
            this.panelMenu.Controls.Add(this.lblInfoDebug);
            this.panelMenu.Controls.Add(this.toggleDebug);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(1);
            this.panelMenu.Size = new System.Drawing.Size(1010, 42);
            this.panelMenu.TabIndex = 0;
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
            this.infosMenuItem.Image = global::DwUtils.Properties.Resources.info_24;
            this.infosMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infosMenuItem.Location = new System.Drawing.Point(235, 1);
            this.infosMenuItem.MouseDownBackColor = System.Drawing.Color.Empty;
            this.infosMenuItem.MouseOverBackColor = System.Drawing.Color.Empty;
            this.infosMenuItem.Name = "infosMenuItem";
            this.infosMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.infosMenuItem.Size = new System.Drawing.Size(96, 40);
            this.infosMenuItem.TabIndex = 0;
            this.infosMenuItem.TabStop = false;
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
            this.settingsMenuItem.Image = global::DwUtils.Properties.Resources.settings_4_24;
            this.settingsMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsMenuItem.Location = new System.Drawing.Point(97, 1);
            this.settingsMenuItem.MouseDownBackColor = System.Drawing.Color.Empty;
            this.settingsMenuItem.MouseOverBackColor = System.Drawing.Color.Empty;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.settingsMenuItem.Size = new System.Drawing.Size(138, 40);
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
            this.fileMenuItem.Image = global::DwUtils.Properties.Resources.folder_7_24;
            this.fileMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileMenuItem.Location = new System.Drawing.Point(1, 1);
            this.fileMenuItem.MouseDownBackColor = System.Drawing.Color.Empty;
            this.fileMenuItem.MouseOverBackColor = System.Drawing.Color.Empty;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.fileMenuItem.Size = new System.Drawing.Size(96, 40);
            this.fileMenuItem.TabIndex = 0;
            this.fileMenuItem.TabStop = false;
            this.fileMenuItem.Text = "Файл";
            this.fileMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fileMenuItem.TextColor = System.Drawing.Color.Gainsboro;
            this.fileMenuItem.UseVisualStyleBackColor = false;
            this.fileMenuItem.Click += new System.EventHandler(this.fileMenuItem_Click);
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
            this.wcDropdownMenuFile.Size = new System.Drawing.Size(123, 28);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Image = global::DwUtils.Properties.Resources.Button_Close;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(122, 24);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // wcDropdownMenuSettings
            // 
            this.wcDropdownMenuSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wcDropdownMenuSettings.IsMainMenu = false;
            this.wcDropdownMenuSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectPostItemMenuItem,
            this.connectPostUnitMenuItem,
            this.toolStripSeparator1,
            this.configMenuItem});
            this.wcDropdownMenuSettings.MenuItemHeight = 25;
            this.wcDropdownMenuSettings.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.wcDropdownMenuSettings.Name = "wcDropdownMenuSettings";
            this.wcDropdownMenuSettings.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.wcDropdownMenuSettings.Size = new System.Drawing.Size(248, 82);
            // 
            // connectPostItemMenuItem
            // 
            this.connectPostItemMenuItem.Image = global::DwUtils.Properties.Resources.Server;
            this.connectPostItemMenuItem.Name = "connectPostItemMenuItem";
            this.connectPostItemMenuItem.Size = new System.Drawing.Size(247, 24);
            this.connectPostItemMenuItem.Text = "Подключение к PostItem";
            this.connectPostItemMenuItem.Click += new System.EventHandler(this.connectPostItemMenuItem_Click);
            // 
            // connectPostUnitMenuItem
            // 
            this.connectPostUnitMenuItem.Image = global::DwUtils.Properties.Resources.Server;
            this.connectPostUnitMenuItem.Name = "connectPostUnitMenuItem";
            this.connectPostUnitMenuItem.Size = new System.Drawing.Size(247, 24);
            this.connectPostUnitMenuItem.Text = "Подключение к PostUnit";
            this.connectPostUnitMenuItem.Click += new System.EventHandler(this.connectPostUnitMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // configMenuItem
            // 
            this.configMenuItem.Image = global::DwUtils.Properties.Resources.Button_Settings;
            this.configMenuItem.Name = "configMenuItem";
            this.configMenuItem.Size = new System.Drawing.Size(247, 24);
            this.configMenuItem.Text = "Настройки";
            this.configMenuItem.Click += new System.EventHandler(this.configMenuItem_Click);
            // 
            // lblInfoCopies
            // 
            this.lblInfoCopies.AutoSize = true;
            this.lblInfoCopies.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoCopies.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInfoCopies.Location = new System.Drawing.Point(338, 19);
            this.lblInfoCopies.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.lblInfoCopies.Name = "lblInfoCopies";
            this.lblInfoCopies.Size = new System.Drawing.Size(58, 20);
            this.lblInfoCopies.TabIndex = 0;
            this.lblInfoCopies.Text = "Копий:";
            // 
            // numericUpDownCopies
            // 
            this.numericUpDownCopies.Location = new System.Drawing.Point(402, 17);
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
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1010, 539);
            this.Controls.Add(this.panelWork);
            this.Controls.Add(this.statusBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GeneralForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DWUtils: GeneralForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_FormClosing);
            this.Load += new System.EventHandler(this.form_Load);
            this.SizeChanged += new System.EventHandler(this.form_SizeChanged);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.panelWork.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabFreeRpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.freeRpoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpoTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeRpoBindingSource)).EndInit();
            this.freeRpoPanelStat.ResumeLayout(false);
            this.flowLayoutPanelFreeRpoStat.ResumeLayout(false);
            this.flowLayoutPanelFreeRpoStat.PerformLayout();
            this.panelFreeRpoL2.ResumeLayout(false);
            this.flowLayoutPanelFreeRpoL2.ResumeLayout(false);
            this.flowLayoutPanelFreeRpoL2.PerformLayout();
            this.panelFreeRpoL1.ResumeLayout(false);
            this.flowLayoutPanelFreeRpoL1.ResumeLayout(false);
            this.flowLayoutPanelFreeRpoL1.PerformLayout();
            this.tabReceived.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receivedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedRpoBindingSource)).EndInit();
            this.receivedPanelStat.ResumeLayout(false);
            this.flowLayoutPanelReceivedStat.ResumeLayout(false);
            this.flowLayoutPanelReceivedStat.PerformLayout();
            this.panelReceivedL2.ResumeLayout(false);
            this.flowLayoutPanelReceivedL2.ResumeLayout(false);
            this.flowLayoutPanelReceivedL2.PerformLayout();
            this.panelReceivedL1.ResumeLayout(false);
            this.flowLayoutPanelReceivedL1.ResumeLayout(false);
            this.flowLayoutPanelReceivedL1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiveRpoReportTypeBindingSource)).EndInit();
            this.tabDelivery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deliveryPictureBox)).EndInit();
            this.panelDeliveryL1.ResumeLayout(false);
            this.tabFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpoFileBindingSource)).EndInit();
            this.filesPanelStat.ResumeLayout(false);
            this.flowLayoutPanelFilesStat.ResumeLayout(false);
            this.flowLayoutPanelFilesStat.PerformLayout();
            this.panelFilesL2.ResumeLayout(false);
            this.flowLayoutPanelFilesL2.ResumeLayout(false);
            this.flowLayoutPanelFilesL2.PerformLayout();
            this.panelFilesL1.ResumeLayout(false);
            this.flowLayoutPanelFilesL1.ResumeLayout(false);
            this.flowLayoutPanelFilesL1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filesLimit)).EndInit();
            this.tabConnected.ResumeLayout(false);
            this.panelOnlineStat.ResumeLayout(false);
            this.flowLayoutPanelOnlineStat.ResumeLayout(false);
            this.flowLayoutPanelOnlineStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectUserBindingSource)).EndInit();
            this.panelOnline.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.wcDropdownMenuFile.ResumeLayout(false);
            this.wcDropdownMenuSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.BindingSource freeRpoBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private System.Windows.Forms.Panel panelWork;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabFreeRpo;
        private System.Windows.Forms.DataGridView freeRpoDataGridView;
        private System.Windows.Forms.Panel panelFreeRpoL1;
        private WcButton btnEditFreeRpo;
        private WcButton btnDeleteFreeRpo;
        private WcButton btnLoadFreeRpo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFreeRpoL1;
        private System.Windows.Forms.Label freeRpoLabelInfoUsers;
        private System.Windows.Forms.ComboBox freeRpoComboBoxUsers;
        private System.Windows.Forms.Panel freeRpoPanelStat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFreeRpoStat;
        private System.Windows.Forms.Label freeRpoLabelInfoCount;
        private System.Windows.Forms.Label freeRpoLabelCount;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Label lblInfoDebug;
        private WcToggleButton toggleDebug;
        private System.Windows.Forms.Label labelInfoLoadLk;
        private WcToggleButton toggleLoadLk;
        private System.Windows.Forms.Panel panelMenu;
        private WcButton infosMenuItem;
        private WcButton settingsMenuItem;
        private WcButton fileMenuItem;
        private Wc32Api.Widgets.Menus.WcDropdownMenu wcDropdownMenuFile;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private Wc32Api.Widgets.Menus.WcDropdownMenu wcDropdownMenuSettings;
        private System.Windows.Forms.ToolStripMenuItem connectPostUnitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectPostItemMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configMenuItem;
        private System.Windows.Forms.TabPage tabReceived;
        private System.Windows.Forms.TabPage tabDelivery;
        private System.Windows.Forms.TabPage tabConnected;
        private System.Windows.Forms.Label freeRpoLabelInfoType;
        private System.Windows.Forms.ComboBox freeRpoComboBoxRpoType;
        private System.Windows.Forms.BindingSource rpoTypeBindingSource;
        private System.Windows.Forms.Label freeRpoLabelInfoPlace;
        private System.Windows.Forms.ComboBox freeRpoComboBoxPlace;
        private System.Windows.Forms.Panel panelFreeRpoL2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFreeRpoL2;
        private WcToggleButton freeRpoToggleButtonDate;
        private System.Windows.Forms.DateTimePicker freeRpoDateTimePickerStart;
        private System.Windows.Forms.DateTimePicker freeRpoDateTimePickerEnd;
        private System.Windows.Forms.Label freeRpoLabelInfoDate;
        private System.Windows.Forms.DataGridView onlineDataGridView;
        private System.Windows.Forms.Panel panelOnline;
        private WcButton btnLoadConnectedUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOnline;
        private System.Windows.Forms.BindingSource connectUserBindingSource;
        private System.Windows.Forms.Panel panelOnlineStat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOnlineStat;
        private System.Windows.Forms.Label onlineLabelInfoCount;
        private System.Windows.Forms.Label onlineLabelCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn freeRpoColumnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeRpoColumnLoadDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn freeRpoColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeRpoColumnBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeRpoColumnIndexTo;
        private System.Windows.Forms.DataGridViewComboBoxColumn freeRpoColumnPlaceId;
        private System.Windows.Forms.DataGridViewComboBoxColumn freeRpoColumnUserId;
        private WcButton btnEditUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn onlineColumnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn onlineColumnPlaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn onlineColumnConnectDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn onlineColumnWorkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn onlineColumnAdminStatus;
        private System.Windows.Forms.Panel panelDeliveryL1;
        private WcButton btnPrintDelivery;
        private WcButton btnLoadDelivery;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDeliveryL1;
        private System.Windows.Forms.Panel panelReceivedL1;
        private WcButton btnPrintReceived;
        private WcButton btnLoadReceived;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReceivedL1;
        private WcButton btnTest;
        private System.Windows.Forms.TabPage tabFiles;
        private System.Windows.Forms.Panel panelFilesL1;
        private WcButton btnLoadFiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFilesL1;
        private System.Windows.Forms.Label filesLabelInfoUsers;
        private System.Windows.Forms.ComboBox filesComboBoxUsers;
        private System.Windows.Forms.Panel panelFilesL2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFilesL2;
        private System.Windows.Forms.Label filesLabelInfoDate;
        private WcToggleButton filesToggleButtonDate;
        private System.Windows.Forms.DateTimePicker filesDateTimePickerStart;
        private System.Windows.Forms.DateTimePicker filesDateTimePickerEnd;
        private System.Windows.Forms.Panel filesPanelStat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFilesStat;
        private System.Windows.Forms.Label filesLabelInfoCount;
        private System.Windows.Forms.Label filesLabelCount;
        private System.Windows.Forms.Label filesLabelInfoRpoCount;
        private System.Windows.Forms.Label filesLabelRpoCount;
        private System.Windows.Forms.DataGridView filesDataGridView;
        private System.Windows.Forms.BindingSource rpoFileBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesColumnDayName;
        private System.Windows.Forms.DataGridViewComboBoxColumn filesColumnUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesColumnCount;
        private System.Windows.Forms.Label filesLabelInfoLimit;
        private WcToggleButton filesToggleButtonLimit;
        private System.Windows.Forms.NumericUpDown filesLimit;
        private System.Windows.Forms.Label receivedLabelInfoUsers;
        private System.Windows.Forms.ComboBox receivedComboBoxUsers;
        private System.Windows.Forms.Panel panelReceivedL2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReceivedL2;
        private System.Windows.Forms.Label receivedLabelInfoDate;
        private System.Windows.Forms.DateTimePicker receivedDateTimePickerStart;
        private System.Windows.Forms.DateTimePicker receivedDateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker receivedDateTimePickerMonth;
        private WcToggleButton receivedToggleButtonCalendar;
        private System.Windows.Forms.DataGridView receivedDataGridView;
        private System.Windows.Forms.BindingSource receivedRpoBindingSource;
        private System.Windows.Forms.Panel receivedPanelStat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReceivedStat;
        private System.Windows.Forms.Label receivedLabelInfoPosCount;
        private System.Windows.Forms.Label receivedLabelPosCount;
        private System.Windows.Forms.Label receivedLabelInfoAllCount;
        private System.Windows.Forms.Label receivedLabelAllCount;
        private System.Windows.Forms.Label receivedLabelInfoReceiveCount;
        private System.Windows.Forms.Label receivedLabelReceiveCount;
        private System.Windows.Forms.Label receivedLabelInfoReturnCount;
        private System.Windows.Forms.Label receivedLabelReturnCount;
        private System.Windows.Forms.Label receivedLabelInfoReturnPay;
        private System.Windows.Forms.Label receivedLabelReturnPay;
        private System.Windows.Forms.Label receivedLabelInfoReportType;
        private System.Windows.Forms.ComboBox receivedComboBoxReportType;
        private System.Windows.Forms.BindingSource receiveRpoReportTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedColumnHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedColumnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedColumnDocumentCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedColumnClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedColumnAllCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedColumnReceivedCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedColumnReturnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedColumnReturnPay;
        private System.Windows.Forms.PictureBox deliveryPictureBox;
        private System.Windows.Forms.Label lblInfoPrinter;
        private System.Windows.Forms.ComboBox comboBoxPrinters;
        private WcButton receivedBtnDatePlus;
        private WcButton receivedBtnDateMinus;
        private System.Windows.Forms.Label lblInfoCopies;
        private System.Windows.Forms.NumericUpDown numericUpDownCopies;
    }
}

