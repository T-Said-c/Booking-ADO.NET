namespace Booking
{
    partial class commadervoiture
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
            this.dtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nudnuit = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnres = new Guna.UI2.WinForms.Guna2Button();
            this.lbadresse = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbprix = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbmar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbmod = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbcar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbtr = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ph = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbtype = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudnuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.Checked = true;
            this.dtp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp.Location = new System.Drawing.Point(706, 230);
            this.dtp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(2022, 6, 14, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(163, 36);
            this.dtp.TabIndex = 45;
            this.dtp.Value = new System.DateTime(2022, 6, 14, 0, 0, 0, 0);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(540, 230);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(352, 36);
            this.guna2HtmlLabel5.TabIndex = 44;
            this.guna2HtmlLabel5.Text = "Date Debut :";
            // 
            // nudnuit
            // 
            this.nudnuit.BackColor = System.Drawing.Color.Transparent;
            this.nudnuit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudnuit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudnuit.ForeColor = System.Drawing.Color.Black;
            this.nudnuit.Location = new System.Drawing.Point(121, 230);
            this.nudnuit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudnuit.Name = "nudnuit";
            this.nudnuit.Size = new System.Drawing.Size(100, 36);
            this.nudnuit.TabIndex = 43;
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
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(29, 230);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(120, 36);
            this.guna2HtmlLabel7.TabIndex = 42;
            this.guna2HtmlLabel7.Text = "Jours :";
            // 
            // btnres
            // 
            this.btnres.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnres.ForeColor = System.Drawing.Color.White;
            this.btnres.Location = new System.Drawing.Point(959, 221);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(180, 45);
            this.btnres.TabIndex = 41;
            this.btnres.Text = "Réserver ";
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // lbadresse
            // 
            this.lbadresse.AutoSize = false;
            this.lbadresse.BackColor = System.Drawing.Color.Transparent;
            this.lbadresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbadresse.Location = new System.Drawing.Point(923, 92);
            this.lbadresse.Name = "lbadresse";
            this.lbadresse.Size = new System.Drawing.Size(204, 36);
            this.lbadresse.TabIndex = 40;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(796, 92);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(222, 36);
            this.guna2HtmlLabel2.TabIndex = 39;
            this.guna2HtmlLabel2.Text = "Adresse :";
            // 
            // lbprix
            // 
            this.lbprix.AutoSize = false;
            this.lbprix.BackColor = System.Drawing.Color.Transparent;
            this.lbprix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprix.Location = new System.Drawing.Point(377, 230);
            this.lbprix.Name = "lbprix";
            this.lbprix.Size = new System.Drawing.Size(204, 36);
            this.lbprix.TabIndex = 38;
            this.lbprix.Text = "labelprix";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(306, 230);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(287, 36);
            this.guna2HtmlLabel1.TabIndex = 37;
            this.guna2HtmlLabel1.Text = "Prix :";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(437, 134);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(210, 27);
            this.guna2HtmlLabel3.TabIndex = 35;
            this.guna2HtmlLabel3.Text = "Photo :";
            // 
            // lbmar
            // 
            this.lbmar.AutoSize = false;
            this.lbmar.BackColor = System.Drawing.Color.Transparent;
            this.lbmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmar.Location = new System.Drawing.Point(148, 12);
            this.lbmar.Name = "lbmar";
            this.lbmar.Size = new System.Drawing.Size(182, 36);
            this.lbmar.TabIndex = 34;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(425, 12);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(222, 36);
            this.guna2HtmlLabel4.TabIndex = 46;
            this.guna2HtmlLabel4.Text = "Modele :";
            // 
            // lbmod
            // 
            this.lbmod.AutoSize = false;
            this.lbmod.BackColor = System.Drawing.Color.Transparent;
            this.lbmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmod.Location = new System.Drawing.Point(539, 12);
            this.lbmod.Name = "lbmod";
            this.lbmod.Size = new System.Drawing.Size(204, 36);
            this.lbmod.TabIndex = 47;
            // 
            // lbcar
            // 
            this.lbcar.AutoSize = false;
            this.lbcar.BackColor = System.Drawing.Color.Transparent;
            this.lbcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcar.Location = new System.Drawing.Point(944, 12);
            this.lbcar.Name = "lbcar";
            this.lbcar.Size = new System.Drawing.Size(163, 36);
            this.lbcar.TabIndex = 49;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(799, 12);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(181, 36);
            this.guna2HtmlLabel9.TabIndex = 48;
            this.guna2HtmlLabel9.Text = "Carburant :";
            // 
            // lbtr
            // 
            this.lbtr.AutoSize = false;
            this.lbtr.BackColor = System.Drawing.Color.Transparent;
            this.lbtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtr.Location = new System.Drawing.Point(218, 125);
            this.lbtr.Name = "lbtr";
            this.lbtr.Size = new System.Drawing.Size(163, 36);
            this.lbtr.TabIndex = 51;
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.AutoSize = false;
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(31, 125);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(181, 36);
            this.guna2HtmlLabel11.TabIndex = 50;
            this.guna2HtmlLabel11.Text = "Transmission :";
            // 
            // ph
            // 
            this.ph.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ph.ImageRotate = 0F;
            this.ph.Location = new System.Drawing.Point(548, 100);
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(171, 105);
            this.ph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ph.TabIndex = 36;
            this.ph.TabStop = false;
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(-1, 272);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.Size = new System.Drawing.Size(1181, 148);
            this.dgvdata.TabIndex = 52;
            this.dgvdata.SelectionChanged += new System.EventHandler(this.dgvdata_SelectionChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(28, 12);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(183, 36);
            this.guna2HtmlLabel6.TabIndex = 53;
            this.guna2HtmlLabel6.Text = "Marque :";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(799, 160);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(222, 36);
            this.guna2HtmlLabel8.TabIndex = 54;
            this.guna2HtmlLabel8.Text = "Type :";
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = false;
            this.lbtype.BackColor = System.Drawing.Color.Transparent;
            this.lbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtype.Location = new System.Drawing.Point(903, 160);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(204, 36);
            this.lbtype.TabIndex = 55;
            // 
            // commadervoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 418);
            this.Controls.Add(this.lbtype);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.lbmar);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.lbtr);
            this.Controls.Add(this.guna2HtmlLabel11);
            this.Controls.Add(this.lbcar);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.lbmod);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.nudnuit);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.btnres);
            this.Controls.Add(this.lbadresse);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lbprix);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.ph);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "commadervoiture";
            this.Text = "commadervoiture";
            this.Load += new System.EventHandler(this.commadervoiture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudnuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lbprix;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox ph;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbmar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbmod;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbcar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbtr;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private System.Windows.Forms.DataGridView dgvdata;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbtype;
    }
}