namespace Booking
{
    partial class commanderhouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nudnuit = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnres = new Guna.UI2.WinForms.Guna2Button();
            this.lbadresse = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbdes = new System.Windows.Forms.RichTextBox();
            this.lbprix = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbnom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bookingProDataSet1 = new Booking.BookingProDataSet1();
            this.houseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseTableAdapter = new Booking.BookingProDataSet1TableAdapters.houseTableAdapter();
            this.bookingProDataSet2 = new Booking.BookingProDataSet2();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelTableAdapter = new Booking.BookingProDataSet2TableAdapters.HotelTableAdapter();
            this.phtoi = new Guna.UI2.WinForms.Guna2PictureBox();
            this.phch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.phcui = new Guna.UI2.WinForms.Guna2PictureBox();
            this.phout = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudnuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingProDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingProDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phtoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phcui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phout)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.Checked = true;
            this.dtp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp.Location = new System.Drawing.Point(689, 319);
            this.dtp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(2022, 6, 14, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(163, 36);
            this.dtp.TabIndex = 58;
            this.dtp.Value = new System.DateTime(2022, 6, 14, 0, 0, 0, 0);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(523, 319);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(352, 36);
            this.guna2HtmlLabel5.TabIndex = 57;
            this.guna2HtmlLabel5.Text = "Date Debut :";
            // 
            // nudnuit
            // 
            this.nudnuit.BackColor = System.Drawing.Color.Transparent;
            this.nudnuit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudnuit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudnuit.ForeColor = System.Drawing.Color.Black;
            this.nudnuit.Location = new System.Drawing.Point(104, 319);
            this.nudnuit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudnuit.Name = "nudnuit";
            this.nudnuit.Size = new System.Drawing.Size(100, 36);
            this.nudnuit.TabIndex = 56;
            this.nudnuit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudnuit.ValueChanged += new System.EventHandler(this.nudnuit_ValueChanged);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(12, 319);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(120, 36);
            this.guna2HtmlLabel7.TabIndex = 55;
            this.guna2HtmlLabel7.Text = "Nuits :";
            // 
            // btnres
            // 
            this.btnres.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnres.ForeColor = System.Drawing.Color.White;
            this.btnres.Location = new System.Drawing.Point(942, 310);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(180, 45);
            this.btnres.TabIndex = 54;
            this.btnres.Text = "Réserver ";
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // lbadresse
            // 
            this.lbadresse.AutoSize = false;
            this.lbadresse.BackColor = System.Drawing.Color.Transparent;
            this.lbadresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbadresse.Location = new System.Drawing.Point(508, 26);
            this.lbadresse.Name = "lbadresse";
            this.lbadresse.Size = new System.Drawing.Size(204, 36);
            this.lbadresse.TabIndex = 47;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(381, 26);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(222, 36);
            this.guna2HtmlLabel2.TabIndex = 46;
            this.guna2HtmlLabel2.Text = "Adresse :";
            // 
            // tbdes
            // 
            this.tbdes.Location = new System.Drawing.Point(754, 55);
            this.tbdes.Name = "tbdes";
            this.tbdes.ReadOnly = true;
            this.tbdes.Size = new System.Drawing.Size(368, 186);
            this.tbdes.TabIndex = 44;
            this.tbdes.Text = "";
            // 
            // lbprix
            // 
            this.lbprix.AutoSize = false;
            this.lbprix.BackColor = System.Drawing.Color.Transparent;
            this.lbprix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprix.Location = new System.Drawing.Point(313, 319);
            this.lbprix.Name = "lbprix";
            this.lbprix.Size = new System.Drawing.Size(204, 36);
            this.lbprix.TabIndex = 43;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(240, 319);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(287, 36);
            this.guna2HtmlLabel1.TabIndex = 42;
            this.guna2HtmlLabel1.Text = "Prix :";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(8, 233);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(151, 27);
            this.guna2HtmlLabel8.TabIndex = 40;
            this.guna2HtmlLabel8.Text = "Photo Chambre  :";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(381, 127);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(213, 27);
            this.guna2HtmlLabel4.TabIndex = 38;
            this.guna2HtmlLabel4.Text = "Photo Cuisine :";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(8, 127);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(210, 27);
            this.guna2HtmlLabel3.TabIndex = 36;
            this.guna2HtmlLabel3.Text = "Photo Outside :";
            // 
            // lbnom
            // 
            this.lbnom.AutoSize = false;
            this.lbnom.BackColor = System.Drawing.Color.Transparent;
            this.lbnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnom.Location = new System.Drawing.Point(12, 26);
            this.lbnom.Name = "lbnom";
            this.lbnom.Size = new System.Drawing.Size(321, 36);
            this.lbnom.TabIndex = 35;
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(-2, 387);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.Size = new System.Drawing.Size(1175, 148);
            this.dgvdata.TabIndex = 34;
            this.dgvdata.SelectionChanged += new System.EventHandler(this.dgvdata_SelectionChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(381, 233);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(213, 27);
            this.guna2HtmlLabel6.TabIndex = 59;
            this.guna2HtmlLabel6.Text = "Photo Toilet :";
            // 
            // bookingProDataSet1
            // 
            this.bookingProDataSet1.DataSetName = "BookingProDataSet1";
            this.bookingProDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // houseBindingSource
            // 
            this.houseBindingSource.DataMember = "house";
            this.houseBindingSource.DataSource = this.bookingProDataSet1;
            // 
            // houseTableAdapter
            // 
            this.houseTableAdapter.ClearBeforeFill = true;
            // 
            // bookingProDataSet2
            // 
            this.bookingProDataSet2.DataSetName = "BookingProDataSet2";
            this.bookingProDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.bookingProDataSet2;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // phtoi
            // 
            this.phtoi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.phtoi.ImageRotate = 0F;
            this.phtoi.Location = new System.Drawing.Point(551, 206);
            this.phtoi.Name = "phtoi";
            this.phtoi.Size = new System.Drawing.Size(113, 80);
            this.phtoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phtoi.TabIndex = 60;
            this.phtoi.TabStop = false;
            // 
            // phch
            // 
            this.phch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.phch.ImageRotate = 0F;
            this.phch.Location = new System.Drawing.Point(159, 206);
            this.phch.Name = "phch";
            this.phch.Size = new System.Drawing.Size(110, 81);
            this.phch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phch.TabIndex = 41;
            this.phch.TabStop = false;
            // 
            // phcui
            // 
            this.phcui.BackColor = System.Drawing.SystemColors.ControlDark;
            this.phcui.ImageRotate = 0F;
            this.phcui.Location = new System.Drawing.Point(551, 100);
            this.phcui.Name = "phcui";
            this.phcui.Size = new System.Drawing.Size(113, 80);
            this.phcui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phcui.TabIndex = 39;
            this.phcui.TabStop = false;
            // 
            // phout
            // 
            this.phout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.phout.ImageRotate = 0F;
            this.phout.Location = new System.Drawing.Point(159, 100);
            this.phout.Name = "phout";
            this.phout.Size = new System.Drawing.Size(110, 80);
            this.phout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phout.TabIndex = 37;
            this.phout.TabStop = false;
            // 
            // commanderhouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1207, 418);
            this.Controls.Add(this.phtoi);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.nudnuit);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.btnres);
            this.Controls.Add(this.lbadresse);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.tbdes);
            this.Controls.Add(this.lbprix);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.phch);
            this.Controls.Add(this.phcui);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.phout);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.lbnom);
            this.Controls.Add(this.dgvdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "commanderhouse";
            this.Text = "commanderhouse";
            this.Load += new System.EventHandler(this.commanderhouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudnuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingProDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingProDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phtoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phcui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtp;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudnuit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2Button btnres;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbadresse;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.RichTextBox tbdes;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbprix;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2PictureBox phch;
        private Guna.UI2.WinForms.Guna2PictureBox phcui;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2PictureBox phout;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbnom;
        private System.Windows.Forms.DataGridView dgvdata;
        private Guna.UI2.WinForms.Guna2PictureBox phtoi;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private BookingProDataSet1 bookingProDataSet1;
        private System.Windows.Forms.BindingSource houseBindingSource;
        private BookingProDataSet1TableAdapters.houseTableAdapter houseTableAdapter;
        private BookingProDataSet2 bookingProDataSet2;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private BookingProDataSet2TableAdapters.HotelTableAdapter hotelTableAdapter;
    }
}