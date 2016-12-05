using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlightsHawk
{
    public class CreateNewFlightForm : Form
    {
        //
        // Основные используемые компоненты формы
        //
        private Label labelID;
        private Label labelAirline;
        private Label labelStatus;
        private Label labelFrom;
        private Label labelTo;
        private Label labelDepartureTime;
        private Label labelLandingTime;
        private Label labelAircraft;
        private Label labelFlightNumber;
        private Label labelFreeSeats;
        private TextBox textStatus;
        private TextBox textFrom;
        private TextBox textTo;
        private TextBox textID;
        private TextBox textAircraft;
        private TextBox textFlightNumber;
        private ComboBox comboBoxAirLine;

        private DateTimePicker dateTimeDepartureTime;
        private DateTimePicker dateTimeLandingTime;

        private NumericUpDown numericUpDownFreeSeats;
        private NumericUpDown numericUpDownBusinessClassPrice;
        private NumericUpDown numericUpDownFirstClassPrice;
        private NumericUpDown numericUpDownDistance;

        private Label labelBusinessClassPrice;
        private Label labelFirstClassPrice;
        private Label labelDistance;

        private Button buttonCreateNewFlight;

        private readonly SqlConnection conection =
            new SqlConnection("data source = THINKPAD-W540; database = Flights; Integrated Security = SSPI;");

        private readonly SqlCommand command = new SqlCommand();
        private SqlDataReader dataReader;


        public CreateNewFlightForm()
        {
            InitializeComponent();

            conection.Open();
            command.CommandText = "SELECT TOP 1 id FROM FLIGHTS ORDER BY id DESC";
            command.Connection = conection; //при инициализации формы производим коннект к БД
            dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    var temp = int.Parse(dataReader[0].ToString());
                    temp++;

                    textID.Text =(temp.ToString());
                    textID.Enabled = false;
                }
            }

            dateTimeDepartureTime.Text = "";
            dateTimeLandingTime.Text = "";

            conection.Close();
        }

        private void InitializeComponent()
        {
            this.labelAirline = new System.Windows.Forms.Label();
            this.comboBoxAirLine = new System.Windows.Forms.ComboBox();
            this.labelFreeSeats = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textFrom = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textTo = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimeDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.labelDepartureTime = new System.Windows.Forms.Label();
            this.dateTimeLandingTime = new System.Windows.Forms.DateTimePicker();
            this.labelLandingTime = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textAircraft = new System.Windows.Forms.TextBox();
            this.labelAircraft = new System.Windows.Forms.Label();
            this.textFlightNumber = new System.Windows.Forms.TextBox();
            this.labelFlightNumber = new System.Windows.Forms.Label();
            this.numericUpDownFreeSeats = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBusinessClassPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFirstClassPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDistance = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateNewFlight = new System.Windows.Forms.Button();
            this.labelBusinessClassPrice = new System.Windows.Forms.Label();
            this.labelFirstClassPrice = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFreeSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBusinessClassPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstClassPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAirline
            // 
            this.labelAirline.AutoSize = true;
            this.labelAirline.Location = new System.Drawing.Point(73, 561);
            this.labelAirline.Name = "labelAirline";
            this.labelAirline.Size = new System.Drawing.Size(72, 25);
            this.labelAirline.TabIndex = 59;
            this.labelAirline.Text = "Airline";
            // 
            // comboBoxAirLine
            // 
            this.comboBoxAirLine.FormattingEnabled = true;
            this.comboBoxAirLine.Items.AddRange(new object[] {
            "United Airlines",
            "Turkish Airlines",
            "AirMoldova",
            "FeedEx"});
            this.comboBoxAirLine.Location = new System.Drawing.Point(243, 557);
            this.comboBoxAirLine.Name = "comboBoxAirLine";
            this.comboBoxAirLine.Size = new System.Drawing.Size(262, 33);
            this.comboBoxAirLine.TabIndex = 58;
            // 
            // labelFreeSeats
            // 
            this.labelFreeSeats.AutoSize = true;
            this.labelFreeSeats.Location = new System.Drawing.Point(73, 357);
            this.labelFreeSeats.Name = "labelFreeSeats";
            this.labelFreeSeats.Size = new System.Drawing.Size(114, 25);
            this.labelFreeSeats.TabIndex = 57;
            this.labelFreeSeats.Text = "Free seats";
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(243, 625);
            this.textStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(262, 31);
            this.textStatus.TabIndex = 55;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(73, 631);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(73, 25);
            this.labelStatus.TabIndex = 54;
            this.labelStatus.Text = "Status";
            // 
            // textFrom
            // 
            this.textFrom.Location = new System.Drawing.Point(243, 426);
            this.textFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textFrom.Name = "textFrom";
            this.textFrom.Size = new System.Drawing.Size(262, 31);
            this.textFrom.TabIndex = 53;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(73, 432);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(61, 25);
            this.labelFrom.TabIndex = 52;
            this.labelFrom.Text = "From";
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(243, 485);
            this.textTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(262, 31);
            this.textTo.TabIndex = 51;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(73, 485);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(37, 25);
            this.labelTo.TabIndex = 50;
            this.labelTo.Text = "To";
            // 
            // dateTimeDepartureTime
            // 
            this.dateTimeDepartureTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimeDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDepartureTime.Location = new System.Drawing.Point(243, 239);
            this.dateTimeDepartureTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeDepartureTime.Name = "dateTimeDepartureTime";
            this.dateTimeDepartureTime.Size = new System.Drawing.Size(262, 31);
            this.dateTimeDepartureTime.TabIndex = 49;
            // 
            // labelDepartureTime
            // 
            this.labelDepartureTime.AutoSize = true;
            this.labelDepartureTime.Location = new System.Drawing.Point(73, 245);
            this.labelDepartureTime.Name = "labelDepartureTime";
            this.labelDepartureTime.Size = new System.Drawing.Size(153, 25);
            this.labelDepartureTime.TabIndex = 48;
            this.labelDepartureTime.Text = "Departure time";
            // 
            // dateTimeLandingTime
            // 
            this.dateTimeLandingTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimeLandingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeLandingTime.Location = new System.Drawing.Point(243, 298);
            this.dateTimeLandingTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeLandingTime.Name = "dateTimeLandingTime";
            this.dateTimeLandingTime.Size = new System.Drawing.Size(262, 31);
            this.dateTimeLandingTime.TabIndex = 47;
            // 
            // labelLandingTime
            // 
            this.labelLandingTime.AutoSize = true;
            this.labelLandingTime.Location = new System.Drawing.Point(73, 298);
            this.labelLandingTime.Name = "labelLandingTime";
            this.labelLandingTime.Size = new System.Drawing.Size(135, 25);
            this.labelLandingTime.TabIndex = 46;
            this.labelLandingTime.Text = "Landing time";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(243, 45);
            this.textID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(262, 31);
            this.textID.TabIndex = 45;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(73, 51);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(32, 25);
            this.labelID.TabIndex = 44;
            this.labelID.Text = "ID";
            // 
            // textAircraft
            // 
            this.textAircraft.Location = new System.Drawing.Point(243, 163);
            this.textAircraft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textAircraft.Name = "textAircraft";
            this.textAircraft.Size = new System.Drawing.Size(262, 31);
            this.textAircraft.TabIndex = 43;
            // 
            // labelAircraft
            // 
            this.labelAircraft.AutoSize = true;
            this.labelAircraft.Location = new System.Drawing.Point(73, 163);
            this.labelAircraft.Name = "labelAircraft";
            this.labelAircraft.Size = new System.Drawing.Size(80, 25);
            this.labelAircraft.TabIndex = 42;
            this.labelAircraft.Text = "Aircraft";
            // 
            // textFlightNumber
            // 
            this.textFlightNumber.Location = new System.Drawing.Point(243, 104);
            this.textFlightNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textFlightNumber.Name = "textFlightNumber";
            this.textFlightNumber.Size = new System.Drawing.Size(262, 31);
            this.textFlightNumber.TabIndex = 41;
            // 
            // labelFlightNumber
            // 
            this.labelFlightNumber.AutoSize = true;
            this.labelFlightNumber.Location = new System.Drawing.Point(73, 104);
            this.labelFlightNumber.Name = "labelFlightNumber";
            this.labelFlightNumber.Size = new System.Drawing.Size(143, 25);
            this.labelFlightNumber.TabIndex = 40;
            this.labelFlightNumber.Text = "Flight number";
            // 
            // numericUpDownFreeSeats
            // 
            this.numericUpDownFreeSeats.Location = new System.Drawing.Point(243, 358);
            this.numericUpDownFreeSeats.Name = "numericUpDownFreeSeats";
            this.numericUpDownFreeSeats.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownFreeSeats.TabIndex = 56;
            // 
            // numericUpDownBusinessClassPrice
            // 
            this.numericUpDownBusinessClassPrice.DecimalPlaces = 2;
            this.numericUpDownBusinessClassPrice.Location = new System.Drawing.Point(243, 740);
            this.numericUpDownBusinessClassPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownBusinessClassPrice.Name = "numericUpDownBusinessClassPrice";
            this.numericUpDownBusinessClassPrice.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownBusinessClassPrice.TabIndex = 61;
            // 
            // numericUpDownFirstClassPrice
            // 
            this.numericUpDownFirstClassPrice.DecimalPlaces = 2;
            this.numericUpDownFirstClassPrice.Location = new System.Drawing.Point(243, 685);
            this.numericUpDownFirstClassPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownFirstClassPrice.Name = "numericUpDownFirstClassPrice";
            this.numericUpDownFirstClassPrice.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownFirstClassPrice.TabIndex = 36;
            // 
            // numericUpDownDistance
            // 
            this.numericUpDownDistance.DecimalPlaces = 2;
            this.numericUpDownDistance.Location = new System.Drawing.Point(243, 800);
            this.numericUpDownDistance.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownDistance.Name = "numericUpDownDistance";
            this.numericUpDownDistance.Size = new System.Drawing.Size(262, 31);
            this.numericUpDownDistance.TabIndex = 23;
            // 
            // buttonCreateNewFlight
            // 
            this.buttonCreateNewFlight.Location = new System.Drawing.Point(78, 900);
            this.buttonCreateNewFlight.Name = "buttonCreateNewFlight";
            this.buttonCreateNewFlight.Size = new System.Drawing.Size(427, 52);
            this.buttonCreateNewFlight.TabIndex = 60;
            this.buttonCreateNewFlight.Text = "Create new Fligth";
            this.buttonCreateNewFlight.UseVisualStyleBackColor = true;
            // 
            // labelBusinessClassPrice
            // 
            this.labelBusinessClassPrice.AutoSize = true;
            this.labelBusinessClassPrice.Location = new System.Drawing.Point(73, 740);
            this.labelBusinessClassPrice.Name = "labelBusinessClassPrice";
            this.labelBusinessClassPrice.Size = new System.Drawing.Size(155, 25);
            this.labelBusinessClassPrice.TabIndex = 39;
            this.labelBusinessClassPrice.Text = "Business Price";
            // 
            // labelFirstClassPrice
            // 
            this.labelFirstClassPrice.AutoSize = true;
            this.labelFirstClassPrice.Location = new System.Drawing.Point(73, 685);
            this.labelFirstClassPrice.Name = "labelFirstClassPrice";
            this.labelFirstClassPrice.Size = new System.Drawing.Size(109, 25);
            this.labelFirstClassPrice.TabIndex = 62;
            this.labelFirstClassPrice.Text = "First Price";
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(73, 800);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(96, 25);
            this.labelDistance.TabIndex = 23;
            this.labelDistance.Text = "Distance";
            // 
            // CreateNewFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 1000);
            this.Controls.Add(this.buttonCreateNewFlight);
            this.Controls.Add(this.labelAirline);
            this.Controls.Add(this.comboBoxAirLine);
            this.Controls.Add(this.labelFreeSeats);
            this.Controls.Add(this.numericUpDownFreeSeats);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textFrom);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.dateTimeDepartureTime);
            this.Controls.Add(this.labelDepartureTime);
            this.Controls.Add(this.dateTimeLandingTime);
            this.Controls.Add(this.labelLandingTime);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textAircraft);
            this.Controls.Add(this.labelAircraft);
            this.Controls.Add(this.textFlightNumber);
            this.Controls.Add(this.labelFlightNumber);
            this.Controls.Add(this.labelBusinessClassPrice);
            this.Controls.Add(this.numericUpDownBusinessClassPrice);
            this.Controls.Add(this.labelFirstClassPrice);
            this.Controls.Add(this.numericUpDownFirstClassPrice);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.numericUpDownDistance);
            this.Name = "CreateNewFlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewFlightForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFreeSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBusinessClassPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstClassPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //
        // Метод, позволяющий создать новый полет
        //
        private void buttonNewFlight_Click(object sender, EventArgs e)
        {
            if (textID.Text != "" & textFlightNumber.Text != "")
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

                conection.Open();
                command.Connection = conection; //при инициализации формы производим коннект к БД

                String createSqlCommand = "INSERT INTO FLIGHTS (id, flight_number," +
                                          " aircraft, departure_time, landing_time, " +
                                          "status, departure, destination, airline, free_seats, " +
                                          "business_class_price, first_class_price, distance) " +
                                          "VALUES ('" +
                                          textID.Text + "', '" +
                                          textFlightNumber.Text + "', '" +
                                          textAircraft.Text + "', '" +
                                          newDepartureDate + "', '" +
                                          newLandingDate + "', '" +
                                          textStatus.Text + "', '" +
                                          textFrom.Text + "', '" +
                                          textTo.Text + "', '" +
                                          comboBoxAirLine.Text + "', '" +
                                          numericUpDownFreeSeats.Text + "', '" +
                                          newBusinsessClassPrice + "', '" +
                                          newFirstClassPrice + "', '" +
                                          newDistance + "')";

                command.CommandText = createSqlCommand;
                command.ExecuteNonQuery();
                conection.Close();

                MessageBox.Show(@"New flight was successfully added.");

                Close();
            }
        }
        
    }
}