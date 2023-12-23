namespace Booking
{
    partial class ProfilClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnenr = new Guna.UI2.WinForms.Guna2Button();
            this.btnann = new Guna.UI2.WinForms.Guna2Button();
            this.cbp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnsup = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnmod = new Guna.UI2.WinForms.Guna2Button();
            this.tbtele = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbmdp = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbnom = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvdata = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btncon = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnenr
            // 
            this.btnenr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnenr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnenr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnenr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnenr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnenr.ForeColor = System.Drawing.Color.White;
            this.btnenr.Location = new System.Drawing.Point(45, 305);
            this.btnenr.Name = "btnenr";
            this.btnenr.Size = new System.Drawing.Size(180, 45);
            this.btnenr.TabIndex = 33;
            this.btnenr.Text = "Enregistrer";
            this.btnenr.Visible = false;
            this.btnenr.Click += new System.EventHandler(this.btnenr_Click);
            // 
            // btnann
            // 
            this.btnann.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnann.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnann.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnann.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnann.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnann.ForeColor = System.Drawing.Color.White;
            this.btnann.Location = new System.Drawing.Point(292, 305);
            this.btnann.Name = "btnann";
            this.btnann.Size = new System.Drawing.Size(180, 45);
            this.btnann.TabIndex = 32;
            this.btnann.Text = "Annuler";
            this.btnann.Visible = false;
            this.btnann.Click += new System.EventHandler(this.btnann_Click);
            // 
            // cbp
            // 
            this.cbp.BackColor = System.Drawing.Color.Transparent;
            this.cbp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbp.ItemHeight = 30;
            this.cbp.Items.AddRange(new object[] {
            "Hotel",
            "Maison",
            "Voiture",
            "Taxi"});
            this.cbp.Location = new System.Drawing.Point(710, 12);
            this.cbp.Name = "cbp";
            this.cbp.Size = new System.Drawing.Size(200, 36);
            this.cbp.TabIndex = 31;
            this.cbp.SelectedIndexChanged += new System.EventHandler(this.cbp_SelectedIndexChanged);
            // 
            // btnsup
            // 
            this.btnsup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsup.ForeColor = System.Drawing.Color.White;
            this.btnsup.Location = new System.Drawing.Point(982, 12);
            this.btnsup.Name = "btnsup";
            this.btnsup.Size = new System.Drawing.Size(180, 45);
            this.btnsup.TabIndex = 30;
            this.btnsup.Text = "Supprimer";
            this.btnsup.Click += new System.EventHandler(this.btnsup_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(588, 21);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(178, 27);
            this.guna2HtmlLabel5.TabIndex = 29;
            this.guna2HtmlLabel5.Text = "Réservation :";
            // 
            // btnmod
            // 
            this.btnmod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnmod.ForeColor = System.Drawing.Color.White;
            this.btnmod.Location = new System.Drawing.Point(148, 305);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(180, 45);
            this.btnmod.TabIndex = 28;
            this.btnmod.Text = "Modifier";
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // tbtele
            // 
            this.tbtele.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtele.DefaultText = "";
            this.tbtele.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtele.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtele.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtele.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbtele.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtele.Location = new System.Drawing.Point(183, 215);
            this.tbtele.Name = "tbtele";
            this.tbtele.PasswordChar = '\0';
            this.tbtele.PlaceholderText = "";
            this.tbtele.ReadOnly = true;
            this.tbtele.SelectedText = "";
            this.tbtele.Size = new System.Drawing.Size(200, 36);
            this.tbtele.TabIndex = 27;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(12, 224);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(157, 27);
            this.guna2HtmlLabel4.TabIndex = 26;
            this.guna2HtmlLabel4.Text = "Téléphone :";
            // 
            // tbmdp
            // 
            this.tbmdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbmdp.DefaultText = "";
            this.tbmdp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbmdp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbmdp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbmdp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbmdp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbmdp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbmdp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbmdp.Location = new System.Drawing.Point(183, 146);
            this.tbmdp.Name = "tbmdp";
            this.tbmdp.PasswordChar = '\0';
            this.tbmdp.PlaceholderText = "";
            this.tbmdp.ReadOnly = true;
            this.tbmdp.SelectedText = "";
            this.tbmdp.Size = new System.Drawing.Size(200, 36);
            this.tbmdp.TabIndex = 25;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 155);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(170, 27);
            this.guna2HtmlLabel3.TabIndex = 24;
            this.guna2HtmlLabel3.Text = "Mot de passe :";
            // 
            // tbemail
            // 
            this.tbemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbemail.DefaultText = "";
            this.tbemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbemail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbemail.Location = new System.Drawing.Point(183, 74);
            this.tbemail.Name = "tbemail";
            this.tbemail.PasswordChar = '\0';
            this.tbemail.PlaceholderText = "";
            this.tbemail.ReadOnly = true;
            this.tbemail.SelectedText = "";
            this.tbemail.Size = new System.Drawing.Size(200, 36);
            this.tbemail.TabIndex = 23;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 83);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(123, 27);
            this.guna2HtmlLabel2.TabIndex = 22;
            this.guna2HtmlLabel2.Text = "Email :";
            // 
            // tbnom
            // 
            this.tbnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbnom.DefaultText = "";
            this.tbnom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbnom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbnom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbnom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbnom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbnom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbnom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbnom.Location = new System.Drawing.Point(183, 12);
            this.tbnom.Name = "tbnom";
            this.tbnom.PasswordChar = '\0';
            this.tbnom.PlaceholderText = "";
            this.tbnom.ReadOnly = true;
            this.tbnom.SelectedText = "";
            this.tbnom.Size = new System.Drawing.Size(200, 36);
            this.tbnom.TabIndex = 21;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 21);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(178, 27);
            this.guna2HtmlLabel1.TabIndex = 20;
            this.guna2HtmlLabel1.Text = "Nom et Prénom :";
            // 
            // dgvdata
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvdata.ColumnHeadersHeight = 4;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.GridColor = System.Drawing.Color.Gray;
            this.dgvdata.Location = new System.Drawing.Point(521, 100);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(646, 285);
            this.dgvdata.TabIndex = 19;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvdata.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvdata.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdata.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvdata.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvdata.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvdata.ThemeStyle.ReadOnly = false;
            this.dgvdata.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdata.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvdata.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvdata.ThemeStyle.RowsStyle.Height = 24;
            this.dgvdata.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvdata.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btncon
            // 
            this.btncon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncon.ForeColor = System.Drawing.Color.White;
            this.btncon.Location = new System.Drawing.Point(729, 64);
            this.btncon.Name = "btncon";
            this.btncon.Size = new System.Drawing.Size(181, 30);
            this.btncon.TabIndex = 34;
            this.btncon.Text = "Contater le Vendeur";
            this.btncon.Click += new System.EventHandler(this.btncon_Click);
            // 
            // ProfilClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1174, 397);
            this.Controls.Add(this.btncon);
            this.Controls.Add(this.btnenr);
            this.Controls.Add(this.btnann);
            this.Controls.Add(this.cbp);
            this.Controls.Add(this.btnsup);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.tbtele);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.tbmdp);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.tbnom);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilClient";
            this.Text = "ProfilClient";
            this.Load += new System.EventHandler(this.ProfilClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnenr;
        private Guna.UI2.WinForms.Guna2Button btnann;
        private Guna.UI2.WinForms.Guna2ComboBox cbp;
        private Guna.UI2.WinForms.Guna2Button btnsup;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button btnmod;
        private Guna.UI2.WinForms.Guna2TextBox tbtele;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox tbmdp;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox tbemail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox tbnom;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvdata;
        private Guna.UI2.WinForms.Guna2Button btncon;
    }
}