namespace orologio
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.cmbFuso = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbOre = new System.Windows.Forms.ComboBox();
            this.cmbMinuti = new System.Windows.Forms.ComboBox();
            this.cmbSecondi = new System.Windows.Forms.ComboBox();
            this.cmbColori = new System.Windows.Forms.ComboBox();
            this.lblFuso = new System.Windows.Forms.Label();
            this.lblColori = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(22, 36);
            this.lblData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(55, 21);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "label1";
            // 
            // cmbFuso
            // 
            this.cmbFuso.BackColor = System.Drawing.Color.White;
            this.cmbFuso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFuso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuso.ForeColor = System.Drawing.Color.Black;
            this.cmbFuso.FormattingEnabled = true;
            this.cmbFuso.Items.AddRange(new object[] {
            "(+00:00)\tLisbona",
            "(+00:00)\tLondra",
            "(+01:00)\tRoma",
            "(+01:00)\tBerlino",
            "(+01:00)\tParigi",
            "(+02:00)\tHelsinki",
            "(+02:00)\tIl Cairo",
            "(+02:00)\tIstanbul",
            "(+03:00)\tMosca",
            "(+03:00)\tNairobi",
            "(+03:30)\tTeheran",
            "(+04:00)\tAbu Dhabi",
            "(+04:00)\tBaku",
            "(+04:30)\tKabul",
            "(+05:00)\tKarachi",
            "(+05:00)\tIslamabad",
            "(+05:30)\tCalcutta",
            "(+05:30)\tNuova Delhi",
            "(+06:00)\tAlmaty",
            "(+06:00)\tDacca",
            "(+06:30)\tYangon",
            "(+07:00)\tBangkok",
            "(+07:00)\tGiacarta",
            "(+08:00)\tHong Kong",
            "(+08:00)\tSingapore",
            "(+08:00)\tPechino",
            "(+09:00)\tTokyo",
            "(+09:00)\tSeul",
            "(+09:30)\tAdelaide",
            "(+09:30)\tDarwin",
            "(+10:00)\tMelbourne",
            "(+10:00)\tSydney",
            "(+11:00)\tNuova Caledonia",
            "(+12:00)\tFiji",
            "(+12:00)\tWellington",
            "(-11:00)\tIsole Midway",
            "(-10:00)\tHawaii",
            "(-09:00)\tAlaska",
            "(-08:00)\tSan Francisco",
            "(-08:00)\tTijuana",
            "(-07:00)\tDenver",
            "(-07:00)\tArizona",
            "(-06:00)\tChicago",
            "(-06:00)\tCittà del Messico",
            "(-05:00)\tNew York",
            "(-05:00)\tBogotá",
            "(-04:00)\tSantiago",
            "(-03:30)\tSt. John’s",
            "(-03:00)\tBrasilia",
            "(-03:00)\tMontevideo",
            "(-02:00)\tFernando de Noronha",
            "(-01:00)\tAzzorre",
            "(-01:00)\tIsole di Capo Verde"});
            this.cmbFuso.Location = new System.Drawing.Point(380, 36);
            this.cmbFuso.Name = "cmbFuso";
            this.cmbFuso.Size = new System.Drawing.Size(270, 29);
            this.cmbFuso.TabIndex = 1;
            this.cmbFuso.SelectedIndexChanged += new System.EventHandler(this.cmbFuso_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Punta la sveglia!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbOre
            // 
            this.cmbOre.FormattingEnabled = true;
            this.cmbOre.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmbOre.Location = new System.Drawing.Point(26, 301);
            this.cmbOre.Name = "cmbOre";
            this.cmbOre.Size = new System.Drawing.Size(51, 29);
            this.cmbOre.TabIndex = 4;
            // 
            // cmbMinuti
            // 
            this.cmbMinuti.FormattingEnabled = true;
            this.cmbMinuti.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinuti.Location = new System.Drawing.Point(83, 301);
            this.cmbMinuti.Name = "cmbMinuti";
            this.cmbMinuti.Size = new System.Drawing.Size(51, 29);
            this.cmbMinuti.TabIndex = 5;
            // 
            // cmbSecondi
            // 
            this.cmbSecondi.FormattingEnabled = true;
            this.cmbSecondi.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbSecondi.Location = new System.Drawing.Point(140, 301);
            this.cmbSecondi.Name = "cmbSecondi";
            this.cmbSecondi.Size = new System.Drawing.Size(51, 29);
            this.cmbSecondi.TabIndex = 6;
            // 
            // cmbColori
            // 
            this.cmbColori.FormattingEnabled = true;
            this.cmbColori.Items.AddRange(new object[] {
            "Base",
            "Antico",
            "Special"});
            this.cmbColori.Location = new System.Drawing.Point(542, 354);
            this.cmbColori.Name = "cmbColori";
            this.cmbColori.Size = new System.Drawing.Size(121, 29);
            this.cmbColori.TabIndex = 7;
            // 
            // lblFuso
            // 
            this.lblFuso.AutoSize = true;
            this.lblFuso.ForeColor = System.Drawing.Color.Black;
            this.lblFuso.Location = new System.Drawing.Point(376, 9);
            this.lblFuso.Name = "lblFuso";
            this.lblFuso.Size = new System.Drawing.Size(179, 21);
            this.lblFuso.TabIndex = 8;
            this.lblFuso.Text = "Imposta il fuso orario";
            // 
            // lblColori
            // 
            this.lblColori.AutoSize = true;
            this.lblColori.ForeColor = System.Drawing.Color.Black;
            this.lblColori.Location = new System.Drawing.Point(574, 321);
            this.lblColori.Name = "lblColori";
            this.lblColori.Size = new System.Drawing.Size(66, 21);
            this.lblColori.TabIndex = 9;
            this.lblColori.Text = "TEMA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.lblColori);
            this.Controls.Add(this.lblFuso);
            this.Controls.Add(this.cmbColori);
            this.Controls.Add(this.cmbSecondi);
            this.Controls.Add(this.cmbMinuti);
            this.Controls.Add(this.cmbOre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFuso);
            this.Controls.Add(this.lblData);
            this.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cmbFuso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbOre;
        private System.Windows.Forms.ComboBox cmbMinuti;
        private System.Windows.Forms.ComboBox cmbSecondi;
        private System.Windows.Forms.ComboBox cmbColori;
        private System.Windows.Forms.Label lblFuso;
        private System.Windows.Forms.Label lblColori;
    }
}

