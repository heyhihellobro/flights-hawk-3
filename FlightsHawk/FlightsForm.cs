using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FlightsHawk
{
    public class FlightsForm : Form
    {
        //
        // Основные используемые компоненты формы
        //
        private Label labelFlightNumber;
        private Label labelAircraft;
        private Label labelID;
        private Label labelLandingTime;
        private Label labelDepartureTime;
        private Label labelFrom;
        private Label labelTo;
        private Label labelStatus;
        private Label labelAirline;
        private Label labelFreeSeats;
        private Label labelTooltip;
        private Label labelBusinessClassPrice;
        private Label labelFirstClassPrice;
        private Label labelDistance;


        private TextBox textFlightNumber;
        private TextBox textAircraft;
        private TextBox textID;

        private DateTimePicker dateTimeDepartureTime;
        private DateTimePicker dateTimeLandingTime;

        private TextBox textFrom;
        private TextBox textTo;
        private TextBox textStatus;

        private NumericUpDown numericUpDownFreeSeats;
        private NumericUpDown numericUpDownBusinessClassPrice;
        private NumericUpDown numericUpDownFirstClassPrice;
        private NumericUpDown numericUpDownDistance;

        private ComboBox comboBoxAirLine;
        private ListBox listBox;
        private Button createButton;
        private Button updateButton;
        private Button deleteButton;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem mainToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonCreateFlight;
        private ToolStripButton toolStripButtonUpdateFlight;
        private ToolStripMenuItem createNewFlightToolStripMenuItem;
        private ToolStripMenuItem updateFlightToolStripMenuItem;
        private ToolStripMenuItem deleteFlightToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripButton toolStripButtonDelete;
        private GroupBox groupBoxMain;
        private GroupBox groupBoxFields;
        private GroupBox groupBoxList;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButtonCopyText;
        private ToolStripButton toolStripButtonPasteText;
        private ToolStripButton toolStripButtonCutText;
        private ToolStripButton toolStripButtonDeleteText;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem fieldsToolStripMenuItem;
        private ToolStripMenuItem listBoxToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private IContainer components;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabelTimeNow;
        private ToolStripStatusLabel toolStripStatusLabelDateToday;
        private ToolStripStatusLabel toolStripStatusLabelPerformedActions;
        private ToolStripMenuItem databaseConnectionToolStripMenuItem;
        private SqlDataReader dataReader;

        //
        // Конструктор по умолчанию
        //
        public FlightsForm()
        {
            InitializeComponent();
            displayTime();
        }


        //
        // Инициализация всех компонентов формы
        //
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightsForm));
            this.labelFlightNumber = new System.Windows.Forms.Label();
            this.textFlightNumber = new System.Windows.Forms.TextBox();
            this.labelAircraft = new System.Windows.Forms.Label();
            this.textAircraft = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.dateTimeDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.labelDepartureTime = new System.Windows.Forms.Label();
            this.dateTimeLandingTime = new System.Windows.Forms.DateTimePicker();
            this.labelLandingTime = new System.Windows.Forms.Label();
            this.textFrom = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textTo = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.numericUpDownFreeSeats = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBusinessClassPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFirstClassPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDistance = new System.Windows.Forms.NumericUpDown();
            this.labelFreeSeats = new System.Windows.Forms.Label();
            this.comboBoxAirLine = new System.Windows.Forms.ComboBox();
            this.labelAirline = new System.Windows.Forms.Label();
            this.labelTooltip = new System.Windows.Forms.Label();
            this.labelBusinessClassPrice = new System.Windows.Forms.Label();
            this.labelFirstClassPrice = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCreateFlight = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateFlight = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCopyText = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPasteText = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCutText = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteText = new System.Windows.Forms.ToolStripButton();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelDateToday = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTimeNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPerformedActions = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.groupBoxFields = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFreeSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBusinessClassPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstClassPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.groupBoxFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFlightNumber
            // 
            this.labelFlightNumber.AutoSize = true;
            this.labelFlightNumber.Location = new System.Drawing.Point(25, 121);
            this.labelFlightNumber.Name = "labelFlightNumber";
            this.labelFlightNumber.Size = new System.Drawing.Size(145, 26);
            this.labelFlightNumber.TabIndex = 0;
            this.labelFlightNumber.Text = "Flight number";
            // 
            // textFlightNumber
            // 
            this.textFlightNumber.Location = new System.Drawing.Point(197, 121);
            this.textFlightNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textFlightNumber.Name = "textFlightNumber";
            this.textFlightNumber.Size = new System.Drawing.Size(265, 32);
            this.textFlightNumber.TabIndex = 1;
            // 
            // labelAircraft
            // 
            this.labelAircraft.AutoSize = true;
            this.labelAircraft.Location = new System.Drawing.Point(25, 180);
            this.labelAircraft.Name = "labelAircraft";
            this.labelAircraft.Size = new System.Drawing.Size(81, 26);
            this.labelAircraft.TabIndex = 2;
            this.labelAircraft.Text = "Aircraft";
            // 
            // textAircraft
            // 
            this.textAircraft.Location = new System.Drawing.Point(197, 180);
            this.textAircraft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textAircraft.Name = "textAircraft";
            this.textAircraft.Size = new System.Drawing.Size(265, 32);
            this.textAircraft.TabIndex = 3;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(137, 1020);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(328, 58);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "New Flight";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(137, 936);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(328, 58);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(137, 1104);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(328, 58);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 26;
            this.listBox.Location = new System.Drawing.Point(3, 28);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(2195, 422);
            this.listBox.TabIndex = 11;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(25, 67);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(34, 26);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "ID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(197, 61);
            this.textID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(265, 32);
            this.textID.TabIndex = 14;
            // 
            // dateTimeDepartureTime
            // 
            this.dateTimeDepartureTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimeDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDepartureTime.Location = new System.Drawing.Point(200, 260);
            this.dateTimeDepartureTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeDepartureTime.Name = "dateTimeDepartureTime";
            this.dateTimeDepartureTime.Size = new System.Drawing.Size(265, 32);
            this.dateTimeDepartureTime.TabIndex = 22;
            // 
            // labelDepartureTime
            // 
            this.labelDepartureTime.AutoSize = true;
            this.labelDepartureTime.Location = new System.Drawing.Point(29, 266);
            this.labelDepartureTime.Name = "labelDepartureTime";
            this.labelDepartureTime.Size = new System.Drawing.Size(156, 26);
            this.labelDepartureTime.TabIndex = 21;
            this.labelDepartureTime.Text = "Departure time";
            // 
            // dateTimeLandingTime
            // 
            this.dateTimeLandingTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimeLandingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeLandingTime.Location = new System.Drawing.Point(200, 320);
            this.dateTimeLandingTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeLandingTime.Name = "dateTimeLandingTime";
            this.dateTimeLandingTime.Size = new System.Drawing.Size(265, 32);
            this.dateTimeLandingTime.TabIndex = 18;
            // 
            // labelLandingTime
            // 
            this.labelLandingTime.AutoSize = true;
            this.labelLandingTime.Location = new System.Drawing.Point(29, 320);
            this.labelLandingTime.Name = "labelLandingTime";
            this.labelLandingTime.Size = new System.Drawing.Size(137, 26);
            this.labelLandingTime.TabIndex = 17;
            this.labelLandingTime.Text = "Landing time";
            // 
            // textFrom
            // 
            this.textFrom.Location = new System.Drawing.Point(200, 421);
            this.textFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textFrom.Name = "textFrom";
            this.textFrom.Size = new System.Drawing.Size(265, 32);
            this.textFrom.TabIndex = 28;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(28, 427);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(63, 26);
            this.labelFrom.TabIndex = 27;
            this.labelFrom.Text = "From";
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(200, 481);
            this.textTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(265, 32);
            this.textTo.TabIndex = 24;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(28, 481);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(36, 26);
            this.labelTo.TabIndex = 23;
            this.labelTo.Text = "To";
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(200, 676);
            this.textStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(265, 32);
            this.textStatus.TabIndex = 34;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(29, 680);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(74, 26);
            this.labelStatus.TabIndex = 33;
            this.labelStatus.Text = "Status";
            // 
            // numericUpDownFreeSeats
            // 
            this.numericUpDownFreeSeats.Location = new System.Drawing.Point(38, 842);
            this.numericUpDownFreeSeats.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownFreeSeats.Name = "numericUpDownFreeSeats";
            this.numericUpDownFreeSeats.Size = new System.Drawing.Size(121, 32);
            this.numericUpDownFreeSeats.TabIndex = 36;
            // 
            // numericUpDownBusinessClassPrice
            // 
            this.numericUpDownBusinessClassPrice.DecimalPlaces = 2;
            this.numericUpDownBusinessClassPrice.Location = new System.Drawing.Point(442, 842);
            this.numericUpDownBusinessClassPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownBusinessClassPrice.Name = "numericUpDownBusinessClassPrice";
            this.numericUpDownBusinessClassPrice.Size = new System.Drawing.Size(121, 32);
            this.numericUpDownBusinessClassPrice.TabIndex = 41;
            // 
            // numericUpDownFirstClassPrice
            // 
            this.numericUpDownFirstClassPrice.DecimalPlaces = 2;
            this.numericUpDownFirstClassPrice.Location = new System.Drawing.Point(240, 842);
            this.numericUpDownFirstClassPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownFirstClassPrice.Name = "numericUpDownFirstClassPrice";
            this.numericUpDownFirstClassPrice.Size = new System.Drawing.Size(121, 32);
            this.numericUpDownFirstClassPrice.TabIndex = 36;
            // 
            // numericUpDownDistance
            // 
            this.numericUpDownDistance.DecimalPlaces = 2;
            this.numericUpDownDistance.Location = new System.Drawing.Point(200, 555);
            this.numericUpDownDistance.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownDistance.Name = "numericUpDownDistance";
            this.numericUpDownDistance.Size = new System.Drawing.Size(265, 32);
            this.numericUpDownDistance.TabIndex = 23;
            // 
            // labelFreeSeats
            // 
            this.labelFreeSeats.AutoSize = true;
            this.labelFreeSeats.Location = new System.Drawing.Point(38, 801);
            this.labelFreeSeats.Name = "labelFreeSeats";
            this.labelFreeSeats.Size = new System.Drawing.Size(114, 26);
            this.labelFreeSeats.TabIndex = 37;
            this.labelFreeSeats.Text = "Free seats";
            // 
            // comboBoxAirLine
            // 
            this.comboBoxAirLine.FormattingEnabled = true;
            this.comboBoxAirLine.Items.AddRange(new object[] {
            "United Airlines",
            "Turkish Airlines",
            "AirMoldova",
            "FeedEx"});
            this.comboBoxAirLine.Location = new System.Drawing.Point(200, 618);
            this.comboBoxAirLine.Name = "comboBoxAirLine";
            this.comboBoxAirLine.Size = new System.Drawing.Size(265, 34);
            this.comboBoxAirLine.TabIndex = 38;
            // 
            // labelAirline
            // 
            this.labelAirline.AutoSize = true;
            this.labelAirline.Location = new System.Drawing.Point(29, 627);
            this.labelAirline.Name = "labelAirline";
            this.labelAirline.Size = new System.Drawing.Size(73, 26);
            this.labelAirline.TabIndex = 39;
            this.labelAirline.Text = "Airline";
            // 
            // labelTooltip
            // 
            this.labelTooltip.AutoSize = true;
            this.labelTooltip.ForeColor = System.Drawing.Color.SlateGray;
            this.labelTooltip.Location = new System.Drawing.Point(25, 1202);
            this.labelTooltip.Name = "labelTooltip";
            this.labelTooltip.Size = new System.Drawing.Size(535, 130);
            this.labelTooltip.TabIndex = 40;
            this.labelTooltip.Text = "Для создания нового полета \r\n воспользуйтесь кнопкой New Flight. \r\n Для того, что" +
    "бы обновить существующую запись, \r\n выделите нужную запись выше и \r\n измените ну" +
    "жное значение.";
            this.labelTooltip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBusinessClassPrice
            // 
            this.labelBusinessClassPrice.AutoSize = true;
            this.labelBusinessClassPrice.Location = new System.Drawing.Point(419, 801);
            this.labelBusinessClassPrice.Name = "labelBusinessClassPrice";
            this.labelBusinessClassPrice.Size = new System.Drawing.Size(157, 26);
            this.labelBusinessClassPrice.TabIndex = 39;
            this.labelBusinessClassPrice.Text = "Business Price";
            // 
            // labelFirstClassPrice
            // 
            this.labelFirstClassPrice.AutoSize = true;
            this.labelFirstClassPrice.Location = new System.Drawing.Point(217, 801);
            this.labelFirstClassPrice.Name = "labelFirstClassPrice";
            this.labelFirstClassPrice.Size = new System.Drawing.Size(171, 26);
            this.labelFirstClassPrice.TabIndex = 42;
            this.labelFirstClassPrice.Text = "First Class Price";
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(28, 560);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(97, 26);
            this.labelDistance.TabIndex = 23;
            this.labelDistance.Text = "Distance";
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(2826, 40);
            this.menuStripMain.TabIndex = 43;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewFlightToolStripMenuItem,
            this.updateFlightToolStripMenuItem,
            this.deleteFlightToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.mainToolStripMenuItem.Text = "File";
            // 
            // createNewFlightToolStripMenuItem
            // 
            this.createNewFlightToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewFlightToolStripMenuItem.Image")));
            this.createNewFlightToolStripMenuItem.Name = "createNewFlightToolStripMenuItem";
            this.createNewFlightToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            this.createNewFlightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createNewFlightToolStripMenuItem.Size = new System.Drawing.Size(357, 38);
            this.createNewFlightToolStripMenuItem.Text = "New Flight";
            this.createNewFlightToolStripMenuItem.Click += new System.EventHandler(this.createNewFlightToolStripMenuItem_Click);
            // 
            // updateFlightToolStripMenuItem
            // 
            this.updateFlightToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateFlightToolStripMenuItem.Image")));
            this.updateFlightToolStripMenuItem.Name = "updateFlightToolStripMenuItem";
            this.updateFlightToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + U";
            this.updateFlightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateFlightToolStripMenuItem.Size = new System.Drawing.Size(357, 38);
            this.updateFlightToolStripMenuItem.Text = "Update Flight";
            this.updateFlightToolStripMenuItem.Click += new System.EventHandler(this.updateFlightToolStripMenuItem_Click);
            // 
            // deleteFlightToolStripMenuItem
            // 
            this.deleteFlightToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteFlightToolStripMenuItem.Image")));
            this.deleteFlightToolStripMenuItem.Name = "deleteFlightToolStripMenuItem";
            this.deleteFlightToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + D";
            this.deleteFlightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteFlightToolStripMenuItem.Size = new System.Drawing.Size(357, 38);
            this.deleteFlightToolStripMenuItem.Text = "Delete Flight";
            this.deleteFlightToolStripMenuItem.Click += new System.EventHandler(this.deleteFlightToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(354, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Shift + E";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(357, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 38);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + C";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(267, 38);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + V";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(267, 38);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + X";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(267, 38);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(264, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(267, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fieldsToolStripMenuItem,
            this.listBoxToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(78, 38);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fieldsToolStripMenuItem
            // 
            this.fieldsToolStripMenuItem.Checked = true;
            this.fieldsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fieldsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fieldsToolStripMenuItem.Image")));
            this.fieldsToolStripMenuItem.Name = "fieldsToolStripMenuItem";
            this.fieldsToolStripMenuItem.Size = new System.Drawing.Size(189, 38);
            this.fieldsToolStripMenuItem.Text = "Fields";
            this.fieldsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.fieldsToolStripMenuItem_CheckedChanged);
            this.fieldsToolStripMenuItem.Click += new System.EventHandler(this.fieldsToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Checked = true;
            this.listBoxToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.listBoxToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listBoxToolStripMenuItem.Image")));
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(189, 38);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseConnectionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // databaseConnectionToolStripMenuItem
            // 
            this.databaseConnectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("databaseConnectionToolStripMenuItem.Image")));
            this.databaseConnectionToolStripMenuItem.Name = "databaseConnectionToolStripMenuItem";
            this.databaseConnectionToolStripMenuItem.Size = new System.Drawing.Size(339, 38);
            this.databaseConnectionToolStripMenuItem.Text = "Database connection";
            this.databaseConnectionToolStripMenuItem.Click += new System.EventHandler(this.databaseConnectionToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.CheckOnClick = true;
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(339, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCreateFlight,
            this.toolStripButtonUpdateFlight,
            this.toolStripButtonDelete,
            this.toolStripSeparator3,
            this.toolStripButtonCopyText,
            this.toolStripButtonPasteText,
            this.toolStripButtonCutText,
            this.toolStripButtonDeleteText});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(2826, 39);
            this.toolStrip1.TabIndex = 44;
            this.toolStrip1.Text = "toolStripCEU";
            // 
            // toolStripButtonCreateFlight
            // 
            this.toolStripButtonCreateFlight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCreateFlight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreateFlight.Image")));
            this.toolStripButtonCreateFlight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreateFlight.Name = "toolStripButtonCreateFlight";
            this.toolStripButtonCreateFlight.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonCreateFlight.Text = "Create new flight";
            this.toolStripButtonCreateFlight.Click += new System.EventHandler(this.toolStripButtonCreateFlight_Click);
            // 
            // toolStripButtonUpdateFlight
            // 
            this.toolStripButtonUpdateFlight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdateFlight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateFlight.Image")));
            this.toolStripButtonUpdateFlight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateFlight.Name = "toolStripButtonUpdateFlight";
            this.toolStripButtonUpdateFlight.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonUpdateFlight.Text = "Save flight";
            this.toolStripButtonUpdateFlight.Click += new System.EventHandler(this.toolStripButtonUpdateFlight_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonDelete.Text = "Delete flight";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButtonCopyText
            // 
            this.toolStripButtonCopyText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopyText.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopyText.Image")));
            this.toolStripButtonCopyText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopyText.Name = "toolStripButtonCopyText";
            this.toolStripButtonCopyText.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonCopyText.Text = "Copy";
            this.toolStripButtonCopyText.Click += new System.EventHandler(this.toolStripButtonCopyText_Click);
            // 
            // toolStripButtonPasteText
            // 
            this.toolStripButtonPasteText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPasteText.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPasteText.Image")));
            this.toolStripButtonPasteText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPasteText.Name = "toolStripButtonPasteText";
            this.toolStripButtonPasteText.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonPasteText.Text = "Paste";
            this.toolStripButtonPasteText.Click += new System.EventHandler(this.toolStripButtonPasteText_Click);
            // 
            // toolStripButtonCutText
            // 
            this.toolStripButtonCutText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCutText.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCutText.Image")));
            this.toolStripButtonCutText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCutText.Name = "toolStripButtonCutText";
            this.toolStripButtonCutText.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonCutText.Text = "Cut";
            this.toolStripButtonCutText.Click += new System.EventHandler(this.toolStripButtonCutText_Click);
            // 
            // toolStripButtonDeleteText
            // 
            this.toolStripButtonDeleteText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteText.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteText.Image")));
            this.toolStripButtonDeleteText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteText.Name = "toolStripButtonDeleteText";
            this.toolStripButtonDeleteText.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonDeleteText.Text = "Delete";
            this.toolStripButtonDeleteText.Click += new System.EventHandler(this.toolStripButtonDeleteText_Click);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.statusStrip1);
            this.groupBoxMain.Controls.Add(this.groupBoxList);
            this.groupBoxMain.Controls.Add(this.groupBoxFields);
            this.groupBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMain.Location = new System.Drawing.Point(0, 79);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(2826, 1448);
            this.groupBoxMain.TabIndex = 45;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Main";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabelDateToday,
            this.toolStripStatusLabelTimeNow,
            this.toolStripStatusLabelPerformedActions});
            this.statusStrip1.Location = new System.Drawing.Point(622, 1407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2201, 38);
            this.statusStrip1.TabIndex = 45;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 32);
            // 
            // toolStripStatusLabelDateToday
            // 
            this.toolStripStatusLabelDateToday.Name = "toolStripStatusLabelDateToday";
            this.toolStripStatusLabelDateToday.Size = new System.Drawing.Size(338, 33);
            this.toolStripStatusLabelDateToday.Text = "toolStripStatusLabelDateToday";
            // 
            // toolStripStatusLabelTimeNow
            // 
            this.toolStripStatusLabelTimeNow.Name = "toolStripStatusLabelTimeNow";
            this.toolStripStatusLabelTimeNow.Size = new System.Drawing.Size(327, 33);
            this.toolStripStatusLabelTimeNow.Text = "toolStripStatusLabelTimeNow";
            // 
            // toolStripStatusLabelPerformedActions
            // 
            this.toolStripStatusLabelPerformedActions.Name = "toolStripStatusLabelPerformedActions";
            this.toolStripStatusLabelPerformedActions.Size = new System.Drawing.Size(28, 33);
            this.toolStripStatusLabelPerformedActions.Text = "0";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.listBox);
            this.groupBoxList.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxList.Location = new System.Drawing.Point(622, 28);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(2201, 453);
            this.groupBoxList.TabIndex = 44;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "List of flights";
            // 
            // groupBoxFields
            // 
            this.groupBoxFields.Controls.Add(this.textID);
            this.groupBoxFields.Controls.Add(this.labelID);
            this.groupBoxFields.Controls.Add(this.labelTooltip);
            this.groupBoxFields.Controls.Add(this.labelAirline);
            this.groupBoxFields.Controls.Add(this.deleteButton);
            this.groupBoxFields.Controls.Add(this.updateButton);
            this.groupBoxFields.Controls.Add(this.createButton);
            this.groupBoxFields.Controls.Add(this.labelDepartureTime);
            this.groupBoxFields.Controls.Add(this.comboBoxAirLine);
            this.groupBoxFields.Controls.Add(this.labelFlightNumber);
            this.groupBoxFields.Controls.Add(this.textStatus);
            this.groupBoxFields.Controls.Add(this.dateTimeLandingTime);
            this.groupBoxFields.Controls.Add(this.labelStatus);
            this.groupBoxFields.Controls.Add(this.textFlightNumber);
            this.groupBoxFields.Controls.Add(this.textFrom);
            this.groupBoxFields.Controls.Add(this.labelFrom);
            this.groupBoxFields.Controls.Add(this.labelLandingTime);
            this.groupBoxFields.Controls.Add(this.textTo);
            this.groupBoxFields.Controls.Add(this.labelBusinessClassPrice);
            this.groupBoxFields.Controls.Add(this.labelTo);
            this.groupBoxFields.Controls.Add(this.numericUpDownBusinessClassPrice);
            this.groupBoxFields.Controls.Add(this.labelDistance);
            this.groupBoxFields.Controls.Add(this.labelAircraft);
            this.groupBoxFields.Controls.Add(this.numericUpDownDistance);
            this.groupBoxFields.Controls.Add(this.labelFirstClassPrice);
            this.groupBoxFields.Controls.Add(this.numericUpDownFirstClassPrice);
            this.groupBoxFields.Controls.Add(this.dateTimeDepartureTime);
            this.groupBoxFields.Controls.Add(this.textAircraft);
            this.groupBoxFields.Controls.Add(this.numericUpDownFreeSeats);
            this.groupBoxFields.Controls.Add(this.labelFreeSeats);
            this.groupBoxFields.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxFields.Location = new System.Drawing.Point(3, 28);
            this.groupBoxFields.Name = "groupBoxFields";
            this.groupBoxFields.Size = new System.Drawing.Size(619, 1417);
            this.groupBoxFields.TabIndex = 43;
            this.groupBoxFields.TabStop = false;
            this.groupBoxFields.Text = "Fields";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2826, 1527);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "FlightsForm";
            this.Text = "Vladimir Rodin - FlightHawk Application - WinForms";
            this.Load += new System.EventHandler(this.FlightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFreeSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBusinessClassPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstClassPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxFields.ResumeLayout(false);
            this.groupBoxFields.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //
        // Метод, который вызывается по нажатию кнопки createButton
        //
        private void createButton_Click(object sender, EventArgs e)
        {
            CreateNewFlightForm form = new CreateNewFlightForm();
            form.ShowDialog();
            LoadList();
        }

        //
        // Метод, загружающий все данные из БД
        // Отображает данные в listBox
        //
        private void LoadList()
        {
            listBox.Items.Clear();
            updateButton.Enabled = false;

            Flight flight = new Flight();
            flight.OpenSqlConection();

            var countAllRows = flight.GetCountAllRows();
            for (int id = 1; id <= countAllRows; id++)
            {
                NameValueCollection temp = flight.GetFlightNVCollection(id);
                listBox.Items.Add(
                    temp["id"].PadRight(10 - temp["id"].Length) + "\t"
                    + temp["flight_number"].PadRight(20 - temp["flight_number"].Length) + "\t"
                    + temp["aircraft"].PadRight(15 - temp["aircraft"].Length) + "\t"
                    + temp["departure_time"].PadRight(50 - temp["departure_time"].Length) + "\t\t"
                    + temp["landing_time"].PadRight(20 - temp["landing_time"].Length) + "\t"
                    + temp["status"].PadRight(20 - temp["status"].Length) + "\t"
                    + temp["destination"].PadRight(20 - temp["destination"].Length) + "\t"
                    + temp["airline"].PadRight(20 - temp["airline"].Length) + "\t"
                    + temp["free_seats"].PadRight(20 - temp["free_seats"].Length) + "\t"
                    + temp["first_class_price"].PadRight(30 - temp["first_class_price"].Length) + "\t"
                    + temp["business_class_price"].PadRight(30 - temp["business_class_price"].Length) + "\t"
                    + temp["distance"].PadRight(30 - temp["distance"].Length)
                );
            }

            flight.CloseSqlConnection();
            IncreaseActions();
        }

        //
        // Метод, очищающий все поля в главной форме
        //
        private void RefreshFields()
        {
            textID.Text = "";
            textFlightNumber.Text = "";
            textAircraft.Text = "";
            dateTimeDepartureTime.Text = "";
            dateTimeLandingTime.Text = "";
            textStatus.Text = "";
            textFrom.Text = "";
            textTo.Text = "";
            comboBoxAirLine.Text = "";
            numericUpDownFreeSeats.Text = "";
            numericUpDownBusinessClassPrice.Text = "";
            numericUpDownDistance.Text = "";
            numericUpDownFirstClassPrice.Text = "";
            IncreaseActions();
        }

        //
        // Метод, который позволяет произвести удаление данных из БД
        //
        private void deleteButton_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure to delete this flight ?",
                "Confirm delete flight",
                MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes || textID.Text == "") return;

            String deleteSqlQuery = "DELETE FROM FLIGHTS WHERE id = '" + textID.Text + "'";
            Flight flight = new Flight();
            flight.CustomSqlQuery(deleteSqlQuery);
            MessageBox.Show(@"Flight was deleted!", @"Deleting Flight");

            RefreshFields();
            LoadList();
            IncreaseActions();
        }

        private void progressStart()
        {
            for (int i = 0; i < 100; i++)
            {
                toolStripProgressBar1.PerformStep();
            }
        }

        private void progressRefresh()
        {
            toolStripProgressBar1.Value = 0;
        }


        //
        // Метод, позволяющий произвести обновление записи
        //
        private void updateButton_Click(object sender, EventArgs e)
        {
            // Переводим даты в правильный SQL формат для UPDATE
            var sqlDateFormat = "yyyy-MM-dd HH:mm";

            var departureDateTemp = dateTimeDepartureTime.Text;
            var departureDateTempCorrect = Convert.ToDateTime(departureDateTemp);
            var newDepartureDate = departureDateTempCorrect.ToString(sqlDateFormat);

            var landingDateTemp = dateTimeLandingTime.Text;
            var landingDateTempCorrect = Convert.ToDateTime(landingDateTemp);
            var newLandingDate = landingDateTempCorrect.ToString(sqlDateFormat);

            // Переводим все цены в формат с точкой

            var newBusinsessClassPrice = numericUpDownBusinessClassPrice.Text.Replace(',', '.');
            var newFirstClassPrice = numericUpDownFirstClassPrice.Text.Replace(',', '.');
            var newDistance = numericUpDownDistance.Text.Replace(',', '.');

            String updateSqlCommand = "UPDATE FLIGHTS SET " +
                                      "id = '" + textID.Text + "', " +
                                      "flight_number = '" + textFlightNumber.Text + "', " +
                                      "aircraft = '" + textAircraft.Text + "', " +
                                      "departure_time = '" + newDepartureDate + "', " +
                                      "landing_time = '" + newLandingDate + "', " +
                                      "status = '" + textStatus.Text + "', " +
                                      "departure = '" + textFrom.Text + "', " +
                                      "destination = '" + textTo.Text + "', " +
                                      "airline = '" + comboBoxAirLine.Text + "', " +
                                      "free_seats = '" + numericUpDownFreeSeats.Text + "', " +
                                      "business_class_price = " + newBusinsessClassPrice + ", " +
                                      "first_class_price = '" + newFirstClassPrice + "', " +
                                      "distance = '" + newDistance + "' " +
                                      "WHERE ID = '" + textID.Text + "'";

            //            MessageBox.Show(updateSqlCommand);

            Flight flight = new Flight();
            flight.CustomSqlQuery(updateSqlCommand);
            MessageBox.Show(@"Flight was updated!", @"Updating Flight");
            RefreshFields();
            LoadList();
            IncreaseActions();
        }

        private void toolStripButtonCreateFlight_Click(object sender, EventArgs e)
        {
            CreateNewFlightForm form = new CreateNewFlightForm();
            form.ShowDialog();
            LoadList();

        }

        private void toolStripButtonUpdateFlight_Click(object sender, EventArgs e)
        {
            // Переводим даты в правильный SQL формат для UPDATE
            var sqlDateFormat = "yyyy-MM-dd HH:mm";

            var departureDateTemp = dateTimeDepartureTime.Text;
            var departureDateTempCorrect = Convert.ToDateTime(departureDateTemp);
            var newDepartureDate = departureDateTempCorrect.ToString(sqlDateFormat);

            var landingDateTemp = dateTimeLandingTime.Text;
            var landingDateTempCorrect = Convert.ToDateTime(landingDateTemp);
            var newLandingDate = landingDateTempCorrect.ToString(sqlDateFormat);

            // Переводим все цены в формат с точкой

            var newBusinsessClassPrice = numericUpDownBusinessClassPrice.Text.Replace(',', '.');
            var newFirstClassPrice = numericUpDownFirstClassPrice.Text.Replace(',', '.');
            var newDistance = numericUpDownDistance.Text.Replace(',', '.');

            String updateSqlCommand = "UPDATE FLIGHTS SET " +
                                      "id = '" + textID.Text + "', " +
                                      "flight_number = '" + textFlightNumber.Text + "', " +
                                      "aircraft = '" + textAircraft.Text + "', " +
                                      "departure_time = '" + newDepartureDate + "', " +
                                      "landing_time = '" + newLandingDate + "', " +
                                      "status = '" + textStatus.Text + "', " +
                                      "departure = '" + textFrom.Text + "', " +
                                      "destination = '" + textTo.Text + "', " +
                                      "airline = '" + comboBoxAirLine.Text + "', " +
                                      "free_seats = '" + numericUpDownFreeSeats.Text + "', " +
                                      "business_class_price = " + newBusinsessClassPrice + ", " +
                                      "first_class_price = '" + newFirstClassPrice + "', " +
                                      "distance = '" + newDistance + "' " +
                                      "WHERE ID = '" + textID.Text + "'";

            //            MessageBox.Show(updateSqlCommand);

            Flight flight = new Flight();
            flight.CustomSqlQuery(updateSqlCommand);
            MessageBox.Show(@"Flight was updated!", @"Updating Flight");
            RefreshFields();
            LoadList();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this flight ?",
               "Confirm delete flight",
               MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes || textID.Text == "") return;

            String deleteSqlQuery = "DELETE FROM FLIGHTS WHERE id = '" + textID.Text + "'";
            Flight flight = new Flight();
            flight.CustomSqlQuery(deleteSqlQuery);
            MessageBox.Show(@"Flight was deleted!", @"Deleting Flight");

            RefreshFields();
            LoadList();
        }

        private void FlightsForm_Load(object sender, EventArgs e)
        {
            Flight flights = new Flight();
            LoadList();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressStart();
            IncreaseActions();
            ListBox listBoxLocal = sender as ListBox;
            updateButton.Enabled = true;

            if (listBoxLocal != null && listBoxLocal.SelectedIndex != -1)
            {
                //берем индекс выбранной строчки
                listBoxLocal.SelectedIndex = listBox.SelectedIndex; // 0 ... !!!!

                var rowIndex = listBoxLocal.SelectedIndex;
                rowIndex++; //так как индексы начинаются с 0, инкрементим
                Flight flight = new Flight();
                flight.OpenSqlConection();
                NameValueCollection temp = flight.GetFlightNVCollection(rowIndex);

                textID.Text = temp["id"];
                textFlightNumber.Text = temp["flight_number"];
                textAircraft.Text = temp["aircraft"];
                dateTimeDepartureTime.Text = temp["departure_time"];
                dateTimeLandingTime.Text = temp["landing_time"];
                textStatus.Text = temp["status"];
                textFrom.Text = temp["departure"];
                textTo.Text = temp["destination"];
                comboBoxAirLine.Text = temp["airline"];
                numericUpDownFreeSeats.Text = temp["free_seats"];
                numericUpDownFirstClassPrice.Text = temp["first_class_price"].Replace('.', ',');
                numericUpDownBusinessClassPrice.Text = temp["business_class_price"].Replace('.', ',');
                numericUpDownDistance.Text = temp["distance"].Replace('.', ',');
            }
            progressRefresh();
        }


        private void createNewFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {

            IncreaseActions();
            progressStart();
            CreateNewFlightForm form = new CreateNewFlightForm();
            progressRefresh();

            form.ShowDialog();
            LoadList();
        }

        private void updateFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Переводим даты в правильный SQL формат для UPDATE
            var sqlDateFormat = "yyyy-MM-dd HH:mm";

            var departureDateTemp = dateTimeDepartureTime.Text;
            var departureDateTempCorrect = Convert.ToDateTime(departureDateTemp);
            var newDepartureDate = departureDateTempCorrect.ToString(sqlDateFormat);

            var landingDateTemp = dateTimeLandingTime.Text;
            var landingDateTempCorrect = Convert.ToDateTime(landingDateTemp);
            var newLandingDate = landingDateTempCorrect.ToString(sqlDateFormat);

            // Переводим все цены в формат с точкой

            var newBusinsessClassPrice = numericUpDownBusinessClassPrice.Text.Replace(',', '.');
            var newFirstClassPrice = numericUpDownFirstClassPrice.Text.Replace(',', '.');
            var newDistance = numericUpDownDistance.Text.Replace(',', '.');

            String updateSqlCommand = "UPDATE FLIGHTS SET " +
                                      "id = '" + textID.Text + "', " +
                                      "flight_number = '" + textFlightNumber.Text + "', " +
                                      "aircraft = '" + textAircraft.Text + "', " +
                                      "departure_time = '" + newDepartureDate + "', " +
                                      "landing_time = '" + newLandingDate + "', " +
                                      "status = '" + textStatus.Text + "', " +
                                      "departure = '" + textFrom.Text + "', " +
                                      "destination = '" + textTo.Text + "', " +
                                      "airline = '" + comboBoxAirLine.Text + "', " +
                                      "free_seats = '" + numericUpDownFreeSeats.Text + "', " +
                                      "business_class_price = " + newBusinsessClassPrice + ", " +
                                      "first_class_price = '" + newFirstClassPrice + "', " +
                                      "distance = '" + newDistance + "' " +
                                      "WHERE ID = '" + textID.Text + "'";

            //            MessageBox.Show(updateSqlCommand);

            Flight flight = new Flight();
            flight.CustomSqlQuery(updateSqlCommand);
            MessageBox.Show(@"Flight was updated!", @"Updating Flight");
            RefreshFields();
            LoadList();
        }

        private void deleteFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this flight ?",
              "Confirm delete flight",
              MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes || textID.Text == "") return;

            String deleteSqlQuery = "DELETE FROM FLIGHTS WHERE id = '" + textID.Text + "'";
            Flight flight = new Flight();
            flight.CustomSqlQuery(deleteSqlQuery);
            MessageBox.Show(@"Flight was deleted!", @"Deleting Flight");

            RefreshFields();
            LoadList();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ActiveControl.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = Clipboard.GetText();
            ActiveControl.Text = text;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ActiveControl.Text);
            ActiveControl.ResetText();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveControl.ResetText();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void toolStripButtonCopyText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ActiveControl.Text);
        }

        private void toolStripButtonPasteText_Click(object sender, EventArgs e)
        {
            string text = Clipboard.GetText();
            ActiveControl.Text = text;
        }

        private void toolStripButtonCutText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ActiveControl.Text);
            ActiveControl.ResetText();
        }

        private void toolStripButtonDeleteText_Click(object sender, EventArgs e)
        {
            ActiveControl.ResetText();
        }

        private void fieldsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {


        }

        private int controlFields = 0;

        private void fieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controlFields == 0)
            {
                controlFields = 1;
                fieldsToolStripMenuItem.Checked = false;
                groupBoxFields.Visible = false;
            }
            else
            {
                controlFields = 0;
                fieldsToolStripMenuItem.Checked = true;
                groupBoxFields.Visible = true;

            }
        }

        private int controlList = 0;


        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controlList == 0)
            {
                controlList = 1;
                listBoxToolStripMenuItem.Checked = false;
                groupBoxList.Visible = false;
            }
            else
            {
                controlList = 0;
                listBoxToolStripMenuItem.Checked = true;
                groupBoxList.Visible = true;

            }
        }
        

        public ToolStripStatusLabel ToolStripStatusLabelTimeNow
        {
            get { return toolStripStatusLabelTimeNow; }
            set { toolStripStatusLabelTimeNow = value; }
        }

        private Timer time = new Timer();

        private void displayTime()
        {
            toolStripStatusLabelDateToday.Text = DateTime.Now.ToLongDateString();
            time.Interval = 1000;
            time.Tick += new EventHandler(IncreaseTime);
            time.Start();
        }

        public void IncreaseTime(object sender, EventArgs e)
        {
            ToolStripStatusLabelTimeNow.Text = DateTime.Now.ToString("hh:mm:ss t z");
        }

        private int actions = 0;

        public void IncreaseActions()
        {
            actions++;
            this.toolStripStatusLabelPerformedActions.Text = "Performed Actions: " + actions;
        }

        private void databaseConnectionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Flight flight = new Flight();

            if (flight.checkSqlConnection())
            {
                MessageBox.Show("Successfully connected to database", "FlightsHawk", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Error to connect to database", "FlightsHawk", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}