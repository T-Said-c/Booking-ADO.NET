namespace Booking
{
    partial class commandertaxi
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
            this.lbmar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.lbtel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnres = new Guna.UI2.WinForms.Guna2Button();
            this.lbadresse = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbprix = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbdes = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmar
            // 
            this.lbmar.AutoSize = false;
            this.lbmar.BackColor = System.Drawing.Color.Transparent;
            this.lbmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmar.Location = new System.Drawing.Point(273, 36);
            this.lbmar.Name = "lbmar";
            this.lbmar.Size = new System.Drawing.Size(182, 36);
            this.lbmar.TabIndex = 56;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(153, 36);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(183, 36);
            this.guna2HtmlLabel6.TabIndex = 75;
            this.guna2HtmlLabel6.Text = "Marque :";
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(3, 265);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.Size = new System.Drawing.Size(1181, 148);
            this.dgvdata.TabIndex = 74;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.SelectionChanged += new System.EventHandler(this.dgvdata_SelectionChanged);
            // 
            // lbtel
            // 
            this.lbtel.AutoSize = false;
            this.lbtel.BackColor = System.Drawing.Color.Transparent;
            this.lbtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtel.Location = new System.Drawing.Point(821, 36);
            this.lbtel.Name = "lbtel";
            this.lbtel.Size = new System.Drawing.Size(163, 36);
            this.lbtel.TabIndex = 71;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(666, 36);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(181, 36);
            this.guna2HtmlLabel9.TabIndex = 70;
            this.guna2HtmlLabel9.Text = "Téléphone :";
            // 
            // dtp
            // 
            this.dtp.Checked = true;
            this.dtp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp.Location = new System.Drawing.Point(93, 195);
            this.dtp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(2022, 6, 14, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(163, 36);
            this.dtp.TabIndex = 67;
            this.dtp.Value = new System.DateTime(2022, 6, 14, 0, 0, 0, 0);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(5, 195);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(141, 36);
            this.guna2HtmlLabel5.TabIndex = 66;
            this.guna2HtmlLabel5.Text = "Date :";
            // 
            // btnres
            // 
            this.btnres.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnres.ForeColor = System.Drawing.Color.White;
            this.btnres.Location = new System.Drawing.Point(994, 195);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(180, 45);
            this.btnres.TabIndex = 63;
            this.btnres.Text = "Réserver ";
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // lbadresse
            // 
            this.lbadresse.AutoSize = false;
            this.lbadresse.BackColor = System.Drawing.Color.Transparent;
            this.lbadresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbadresse.Location = new System.Drawing.Point(273, 118);
            this.lbadresse.Name = "lbadresse";
            this.lbadresse.Size = new System.Drawing.Size(204, 36);
            this.lbadresse.TabIndex = 62;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(146, 118);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(222, 36);
            this.guna2HtmlLabel2.TabIndex = 61;
            this.guna2HtmlLabel2.Text = "Adresse :";
            // 
            // lbprix
            // 
            this.lbprix.AutoSize = false;
            this.lbprix.BackColor = System.Drawing.Color.Transparent;
            this.lbprix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprix.Location = new System.Drawing.Point(900, 118);
            this.lbprix.Name = "lbprix";
            this.lbprix.Size = new System.Drawing.Size(204, 36);
            this.lbprix.TabIndex = 60;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(666, 118);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(287, 36);
            this.guna2HtmlLabel1.TabIndex = 59;
            this.guna2HtmlLabel1.Text = "Prix par kilometre :";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(313, 195);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(123, 36);
            this.guna2HtmlLabel3.TabIndex = 76;
            this.guna2HtmlLabel3.Text = "Heure :";
            // 
            // cbh
            // 
            this.cbh.BackColor = System.Drawing.Color.Transparent;
            this.cbh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbh.ItemHeight = 30;
            this.cbh.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cbh.Location = new System.Drawing.Point(429, 195);
            this.cbh.Name = "cbh";
            this.cbh.Size = new System.Drawing.Size(140, 36);
            this.cbh.TabIndex = 77;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(593, 195);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(224, 36);
            this.guna2HtmlLabel7.TabIndex = 78;
            this.guna2HtmlLabel7.Text = "Destination :";
            // 
            // tbdes
            // 
            this.tbdes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbdes.DefaultText = "";
            this.tbdes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbdes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbdes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbdes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbdes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbdes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbdes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbdes.Location = new System.Drawing.Point(753, 195);
            this.tbdes.Name = "tbdes";
            this.tbdes.PasswordChar = '\0';
            this.tbdes.PlaceholderText = "";
            this.tbdes.SelectedText = "";
            this.tbdes.Size = new System.Drawing.Size(200, 36);
            this.tbdes.TabIndex = 79;
            // 
            // commandertaxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 418);
            this.Controls.Add(this.tbdes);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.cbh);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.lbmar);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.lbtel);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.btnres);
            this.Controls.Add(this.lbadresse);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lbprix);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "commandertaxi";
            this.Text = "commandertaxi";
            this.Load += new System.EventHandler(this.commandertaxi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lbmar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private System.Windows.Forms.DataGridView dgvdata;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbtel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button btnres;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbadresse;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbprix;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbh;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox tbdes;
    }
}