namespace Design_Project
{
    partial class ModeSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeSelect));
            this.BtnTetiklemeliMod = new System.Windows.Forms.Button();
            this.BtnSinirliAciMod = new System.Windows.Forms.Button();
            this.BtnTetiklemeliSinirliAciMod = new System.Windows.Forms.Button();
            this.BtnTekYonTetiklemeliSinirliAciMod = new System.Windows.Forms.Button();
            this.BtnManuelMod = new System.Windows.Forms.Button();
            this.BtnKalibrasyonMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEnable = new System.Windows.Forms.Button();
            this.LblYon_ = new System.Windows.Forms.Label();
            this.CmbBxYon = new System.Windows.Forms.ComboBox();
            this.BtnStandartMod = new System.Windows.Forms.Button();
            this.BtnDirection = new System.Windows.Forms.Button();
            this.BtnPulse = new System.Windows.Forms.Button();
            this.LblHiz_ = new System.Windows.Forms.Label();
            this.LblDrece_ = new System.Windows.Forms.Label();
            this.BtnAyarlariUygula = new System.Windows.Forms.Button();
            this.LblYon = new System.Windows.Forms.Label();
            this.LblHiz = new System.Windows.Forms.Label();
            this.LblDerece = new System.Windows.Forms.Label();
            this.BtnCalis = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumUpDwnHiz = new System.Windows.Forms.NumericUpDown();
            this.NumUpDwnDerece = new System.Windows.Forms.NumericUpDown();
            this.LblSerialPort = new System.Windows.Forms.Label();
            this.LblBaundRate = new System.Windows.Forms.Label();
            this.BtnReConnect = new System.Windows.Forms.Button();
            this.Tmr1000MS = new System.Windows.Forms.Timer(this.components);
            this.BtnNewSerial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCalis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwnHiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwnDerece)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTetiklemeliMod
            // 
            this.BtnTetiklemeliMod.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnTetiklemeliMod.BackgroundImage = global::STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.tetiklemeli;
            this.BtnTetiklemeliMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnTetiklemeliMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTetiklemeliMod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTetiklemeliMod.Location = new System.Drawing.Point(129, 60);
            this.BtnTetiklemeliMod.Name = "BtnTetiklemeliMod";
            this.BtnTetiklemeliMod.Size = new System.Drawing.Size(107, 142);
            this.BtnTetiklemeliMod.TabIndex = 0;
            this.BtnTetiklemeliMod.Text = "Tetiklemeli Mod";
            this.BtnTetiklemeliMod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTetiklemeliMod.UseVisualStyleBackColor = false;
            this.BtnTetiklemeliMod.Click += new System.EventHandler(this.ModeChangeButtons_Click);
            // 
            // BtnSinirliAciMod
            // 
            this.BtnSinirliAciMod.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSinirliAciMod.BackgroundImage = global::STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.sinirli_aci;
            this.BtnSinirliAciMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSinirliAciMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSinirliAciMod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSinirliAciMod.Location = new System.Drawing.Point(14, 208);
            this.BtnSinirliAciMod.Name = "BtnSinirliAciMod";
            this.BtnSinirliAciMod.Size = new System.Drawing.Size(107, 142);
            this.BtnSinirliAciMod.TabIndex = 0;
            this.BtnSinirliAciMod.Text = "Sınırlı Açı Modu";
            this.BtnSinirliAciMod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSinirliAciMod.UseVisualStyleBackColor = false;
            this.BtnSinirliAciMod.Click += new System.EventHandler(this.ModeChangeButtons_Click);
            // 
            // BtnTetiklemeliSinirliAciMod
            // 
            this.BtnTetiklemeliSinirliAciMod.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnTetiklemeliSinirliAciMod.BackgroundImage = global::STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.tetiklemeli_sinirli_aci;
            this.BtnTetiklemeliSinirliAciMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnTetiklemeliSinirliAciMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTetiklemeliSinirliAciMod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTetiklemeliSinirliAciMod.Location = new System.Drawing.Point(129, 208);
            this.BtnTetiklemeliSinirliAciMod.Name = "BtnTetiklemeliSinirliAciMod";
            this.BtnTetiklemeliSinirliAciMod.Size = new System.Drawing.Size(107, 142);
            this.BtnTetiklemeliSinirliAciMod.TabIndex = 0;
            this.BtnTetiklemeliSinirliAciMod.Text = "Tetiklemeli Sınırlı Açı Modu";
            this.BtnTetiklemeliSinirliAciMod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTetiklemeliSinirliAciMod.UseVisualStyleBackColor = false;
            this.BtnTetiklemeliSinirliAciMod.Click += new System.EventHandler(this.ModeChangeButtons_Click);
            // 
            // BtnTekYonTetiklemeliSinirliAciMod
            // 
            this.BtnTekYonTetiklemeliSinirliAciMod.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnTekYonTetiklemeliSinirliAciMod.BackgroundImage = global::STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.tek_yonlu_tetiklemeli_sinirli_aci;
            this.BtnTekYonTetiklemeliSinirliAciMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnTekYonTetiklemeliSinirliAciMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTekYonTetiklemeliSinirliAciMod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTekYonTetiklemeliSinirliAciMod.Location = new System.Drawing.Point(242, 208);
            this.BtnTekYonTetiklemeliSinirliAciMod.Name = "BtnTekYonTetiklemeliSinirliAciMod";
            this.BtnTekYonTetiklemeliSinirliAciMod.Size = new System.Drawing.Size(107, 142);
            this.BtnTekYonTetiklemeliSinirliAciMod.TabIndex = 0;
            this.BtnTekYonTetiklemeliSinirliAciMod.Text = "Tek Yönlü Tetiklemeli Sınırlı Açı Modu";
            this.BtnTekYonTetiklemeliSinirliAciMod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTekYonTetiklemeliSinirliAciMod.UseVisualStyleBackColor = false;
            this.BtnTekYonTetiklemeliSinirliAciMod.Click += new System.EventHandler(this.ModeChangeButtons_Click);
            // 
            // BtnManuelMod
            // 
            this.BtnManuelMod.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnManuelMod.BackgroundImage = global::STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.manuel;
            this.BtnManuelMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnManuelMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManuelMod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManuelMod.Location = new System.Drawing.Point(242, 60);
            this.BtnManuelMod.Name = "BtnManuelMod";
            this.BtnManuelMod.Size = new System.Drawing.Size(107, 142);
            this.BtnManuelMod.TabIndex = 0;
            this.BtnManuelMod.Text = "Manuel Mod";
            this.BtnManuelMod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnManuelMod.UseVisualStyleBackColor = false;
            this.BtnManuelMod.Click += new System.EventHandler(this.ModeChangeButtons_Click);
            // 
            // BtnKalibrasyonMod
            // 
            this.BtnKalibrasyonMod.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnKalibrasyonMod.BackgroundImage = global::STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.kalibrasyon;
            this.BtnKalibrasyonMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnKalibrasyonMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKalibrasyonMod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKalibrasyonMod.Location = new System.Drawing.Point(169, 356);
            this.BtnKalibrasyonMod.Name = "BtnKalibrasyonMod";
            this.BtnKalibrasyonMod.Size = new System.Drawing.Size(180, 145);
            this.BtnKalibrasyonMod.TabIndex = 0;
            this.BtnKalibrasyonMod.Text = "Kalibrasyon Modu";
            this.BtnKalibrasyonMod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnKalibrasyonMod.UseVisualStyleBackColor = false;
            this.BtnKalibrasyonMod.Click += new System.EventHandler(this.ModeChangeButtons_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MUHAMMED SADUN ÇAKMAKLI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(136, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DESIGN PROJECT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(153, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "1030520673";
            // 
            // BtnEnable
            // 
            this.BtnEnable.BackColor = System.Drawing.Color.DarkGray;
            this.BtnEnable.BackgroundImage = global::STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.power2;
            this.BtnEnable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnable.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnable.Location = new System.Drawing.Point(434, 60);
            this.BtnEnable.Name = "BtnEnable";
            this.BtnEnable.Size = new System.Drawing.Size(107, 111);
            this.BtnEnable.TabIndex = 0;
            this.BtnEnable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEnable.UseVisualStyleBackColor = false;
            this.BtnEnable.Visible = false;
            this.BtnEnable.Click += new System.EventHandler(this.BtnEnable_Click);
            // 
            // LblYon_
            // 
            this.LblYon_.AutoSize = true;
            this.LblYon_.BackColor = System.Drawing.Color.Transparent;
            this.LblYon_.ForeColor = System.Drawing.SystemColors.Control;
            this.LblYon_.Location = new System.Drawing.Point(406, 71);
            this.LblYon_.Name = "LblYon_";
            this.LblYon_.Size = new System.Drawing.Size(26, 13);
            this.LblYon_.TabIndex = 1;
            this.LblYon_.Text = "Yön";
            this.LblYon_.Visible = false;
            // 
            // CmbBxYon
            // 
            this.CmbBxYon.FormattingEnabled = true;
            this.CmbBxYon.Items.AddRange(new object[] {
            "Saat Yönü",
            "Saat Yönü Tersi"});
            this.CmbBxYon.Location = new System.Drawing.Point(431, 67);
            this.CmbBxYon.Name = "CmbBxYon";
            this.CmbBxYon.Size = new System.Drawing.Size(100, 21);
            this.CmbBxYon.TabIndex = 5;
            this.CmbBxYon.Visible = false;
            // 
            // BtnStandartMod
            // 
            this.BtnStandartMod.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnStandartMod.BackgroundImage = global::STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.clockwise;
            this.BtnStandartMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnStandartMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStandartMod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStandartMod.Location = new System.Drawing.Point(14, 60);
            this.BtnStandartMod.Name = "BtnStandartMod";
            this.BtnStandartMod.Size = new System.Drawing.Size(107, 142);
            this.BtnStandartMod.TabIndex = 0;
            this.BtnStandartMod.Text = "Standart Mod";
            this.BtnStandartMod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnStandartMod.UseVisualStyleBackColor = false;
            this.BtnStandartMod.Click += new System.EventHandler(this.ModeChangeButtons_Click);
            // 
            // BtnDirection
            // 
            this.BtnDirection.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnDirection.BackgroundImage = global::STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.clockwise;
            this.BtnDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDirection.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDirection.Location = new System.Drawing.Point(434, 294);
            this.BtnDirection.Name = "BtnDirection";
            this.BtnDirection.Size = new System.Drawing.Size(107, 111);
            this.BtnDirection.TabIndex = 0;
            this.BtnDirection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDirection.UseVisualStyleBackColor = false;
            this.BtnDirection.Visible = false;
            this.BtnDirection.Click += new System.EventHandler(this.BtnDirection_Click);
            // 
            // BtnPulse
            // 
            this.BtnPulse.BackColor = System.Drawing.Color.Moccasin;
            this.BtnPulse.BackgroundImage = global::STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.pulse;
            this.BtnPulse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPulse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPulse.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPulse.Location = new System.Drawing.Point(434, 177);
            this.BtnPulse.Name = "BtnPulse";
            this.BtnPulse.Size = new System.Drawing.Size(107, 111);
            this.BtnPulse.TabIndex = 0;
            this.BtnPulse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPulse.UseVisualStyleBackColor = false;
            this.BtnPulse.Visible = false;
            this.BtnPulse.Click += new System.EventHandler(this.BtnPulse_Click);
            // 
            // LblHiz_
            // 
            this.LblHiz_.AutoSize = true;
            this.LblHiz_.BackColor = System.Drawing.Color.Transparent;
            this.LblHiz_.ForeColor = System.Drawing.SystemColors.Control;
            this.LblHiz_.Location = new System.Drawing.Point(356, 95);
            this.LblHiz_.Name = "LblHiz_";
            this.LblHiz_.Size = new System.Drawing.Size(76, 13);
            this.LblHiz_.TabIndex = 1;
            this.LblHiz_.Text = "Hız (Pulse/Dk)";
            this.LblHiz_.Visible = false;
            // 
            // LblDrece_
            // 
            this.LblDrece_.AutoSize = true;
            this.LblDrece_.BackColor = System.Drawing.Color.Transparent;
            this.LblDrece_.ForeColor = System.Drawing.SystemColors.Control;
            this.LblDrece_.Location = new System.Drawing.Point(390, 121);
            this.LblDrece_.Name = "LblDrece_";
            this.LblDrece_.Size = new System.Drawing.Size(42, 13);
            this.LblDrece_.TabIndex = 1;
            this.LblDrece_.Text = "Derece";
            this.LblDrece_.Visible = false;
            // 
            // BtnAyarlariUygula
            // 
            this.BtnAyarlariUygula.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnAyarlariUygula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAyarlariUygula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyarlariUygula.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAyarlariUygula.Location = new System.Drawing.Point(449, 157);
            this.BtnAyarlariUygula.Name = "BtnAyarlariUygula";
            this.BtnAyarlariUygula.Size = new System.Drawing.Size(65, 65);
            this.BtnAyarlariUygula.TabIndex = 0;
            this.BtnAyarlariUygula.Text = "Ayarları Uygula";
            this.BtnAyarlariUygula.UseVisualStyleBackColor = false;
            this.BtnAyarlariUygula.Visible = false;
            this.BtnAyarlariUygula.Click += new System.EventHandler(this.BtnAyarlariUygula_Click);
            // 
            // LblYon
            // 
            this.LblYon.AutoSize = true;
            this.LblYon.BackColor = System.Drawing.Color.Transparent;
            this.LblYon.ForeColor = System.Drawing.SystemColors.Control;
            this.LblYon.Location = new System.Drawing.Point(529, 70);
            this.LblYon.Name = "LblYon";
            this.LblYon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblYon.Size = new System.Drawing.Size(57, 13);
            this.LblYon.TabIndex = 1;
            this.LblYon.Text = "Saat Yönü";
            this.LblYon.Visible = false;
            // 
            // LblHiz
            // 
            this.LblHiz.AutoSize = true;
            this.LblHiz.BackColor = System.Drawing.Color.Transparent;
            this.LblHiz.ForeColor = System.Drawing.SystemColors.Control;
            this.LblHiz.Location = new System.Drawing.Point(529, 96);
            this.LblHiz.Name = "LblHiz";
            this.LblHiz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblHiz.Size = new System.Drawing.Size(19, 13);
            this.LblHiz.TabIndex = 1;
            this.LblHiz.Text = "60";
            this.LblHiz.Visible = false;
            // 
            // LblDerece
            // 
            this.LblDerece.AutoSize = true;
            this.LblDerece.BackColor = System.Drawing.Color.Transparent;
            this.LblDerece.ForeColor = System.Drawing.SystemColors.Control;
            this.LblDerece.Location = new System.Drawing.Point(529, 121);
            this.LblDerece.Name = "LblDerece";
            this.LblDerece.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblDerece.Size = new System.Drawing.Size(25, 13);
            this.LblDerece.TabIndex = 1;
            this.LblDerece.Text = "360";
            this.LblDerece.Visible = false;
            // 
            // BtnCalis
            // 
            this.BtnCalis.BackColor = System.Drawing.Color.Transparent;
            this.BtnCalis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCalis.Image = global::STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.stopbutton_passive;
            this.BtnCalis.Location = new System.Drawing.Point(434, 238);
            this.BtnCalis.Name = "BtnCalis";
            this.BtnCalis.Size = new System.Drawing.Size(100, 100);
            this.BtnCalis.TabIndex = 6;
            this.BtnCalis.TabStop = false;
            this.BtnCalis.Click += new System.EventHandler(this.BtnCalis_Click);
            this.BtnCalis.MouseEnter += new System.EventHandler(this.BtnCalisPBox_MouseEnter);
            this.BtnCalis.MouseLeave += new System.EventHandler(this.BtnCalisPBox_MouseLeave);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnExit.Image = global::STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.exitblue;
            this.BtnExit.Location = new System.Drawing.Point(14, 412);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 75);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.BtnExit.MouseEnter += new System.EventHandler(this.BtnExitPBox_MouseEnter);
            this.BtnExit.MouseLeave += new System.EventHandler(this.BtnExitPBox_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(31, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "ÇIKIŞ";
            // 
            // NumUpDwnHiz
            // 
            this.NumUpDwnHiz.Location = new System.Drawing.Point(431, 92);
            this.NumUpDwnHiz.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumUpDwnHiz.Name = "NumUpDwnHiz";
            this.NumUpDwnHiz.Size = new System.Drawing.Size(100, 20);
            this.NumUpDwnHiz.TabIndex = 7;
            // 
            // NumUpDwnDerece
            // 
            this.NumUpDwnDerece.Location = new System.Drawing.Point(431, 118);
            this.NumUpDwnDerece.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumUpDwnDerece.Name = "NumUpDwnDerece";
            this.NumUpDwnDerece.Size = new System.Drawing.Size(100, 20);
            this.NumUpDwnDerece.TabIndex = 7;
            // 
            // LblSerialPort
            // 
            this.LblSerialPort.AutoSize = true;
            this.LblSerialPort.BackColor = System.Drawing.Color.Transparent;
            this.LblSerialPort.ForeColor = System.Drawing.SystemColors.Control;
            this.LblSerialPort.Location = new System.Drawing.Point(390, 9);
            this.LblSerialPort.Name = "LblSerialPort";
            this.LblSerialPort.Size = new System.Drawing.Size(122, 13);
            this.LblSerialPort.TabIndex = 1;
            this.LblSerialPort.Text = "SERIAL PORT: COMXX";
            // 
            // LblBaundRate
            // 
            this.LblBaundRate.AutoSize = true;
            this.LblBaundRate.BackColor = System.Drawing.Color.Transparent;
            this.LblBaundRate.ForeColor = System.Drawing.SystemColors.Control;
            this.LblBaundRate.Location = new System.Drawing.Point(390, 22);
            this.LblBaundRate.Name = "LblBaundRate";
            this.LblBaundRate.Size = new System.Drawing.Size(118, 13);
            this.LblBaundRate.TabIndex = 3;
            this.LblBaundRate.Text = "BAUND RATE: XXXXX";
            // 
            // BtnReConnect
            // 
            this.BtnReConnect.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnReConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnReConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReConnect.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReConnect.Location = new System.Drawing.Point(90, 356);
            this.BtnReConnect.Name = "BtnReConnect";
            this.BtnReConnect.Size = new System.Drawing.Size(74, 41);
            this.BtnReConnect.TabIndex = 0;
            this.BtnReConnect.Text = "Bağlantıyı Yenile";
            this.BtnReConnect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReConnect.UseVisualStyleBackColor = false;
            this.BtnReConnect.Click += new System.EventHandler(this.BtnPassiveMod_Click);
            // 
            // Tmr1000MS
            // 
            this.Tmr1000MS.Interval = 1000;
            this.Tmr1000MS.Tick += new System.EventHandler(this.Tmr1000MS_Tick);
            // 
            // BtnNewSerial
            // 
            this.BtnNewSerial.BackColor = System.Drawing.Color.Yellow;
            this.BtnNewSerial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNewSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewSerial.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnNewSerial.Location = new System.Drawing.Point(90, 403);
            this.BtnNewSerial.Name = "BtnNewSerial";
            this.BtnNewSerial.Size = new System.Drawing.Size(74, 41);
            this.BtnNewSerial.TabIndex = 0;
            this.BtnNewSerial.Text = "Yeni Program";
            this.BtnNewSerial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNewSerial.UseVisualStyleBackColor = false;
            this.BtnNewSerial.Click += new System.EventHandler(this.BtnNewSerial_Click);
            // 
            // ModeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(620, 512);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCalis);
            this.Controls.Add(this.NumUpDwnDerece);
            this.Controls.Add(this.NumUpDwnHiz);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.CmbBxYon);
            this.Controls.Add(this.LblBaundRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblDerece);
            this.Controls.Add(this.LblDrece_);
            this.Controls.Add(this.LblHiz);
            this.Controls.Add(this.LblYon);
            this.Controls.Add(this.LblHiz_);
            this.Controls.Add(this.LblYon_);
            this.Controls.Add(this.LblSerialPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnManuelMod);
            this.Controls.Add(this.BtnNewSerial);
            this.Controls.Add(this.BtnReConnect);
            this.Controls.Add(this.BtnKalibrasyonMod);
            this.Controls.Add(this.BtnTekYonTetiklemeliSinirliAciMod);
            this.Controls.Add(this.BtnTetiklemeliSinirliAciMod);
            this.Controls.Add(this.BtnSinirliAciMod);
            this.Controls.Add(this.BtnTetiklemeliMod);
            this.Controls.Add(this.BtnAyarlariUygula);
            this.Controls.Add(this.BtnStandartMod);
            this.Controls.Add(this.BtnDirection);
            this.Controls.Add(this.BtnEnable);
            this.Controls.Add(this.BtnPulse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModeSelect";
            this.Text = "STEP MOTOR KONTROL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModeSelect_FormClosing);
            this.Load += new System.EventHandler(this.ModeSelect_Load);
            this.Shown += new System.EventHandler(this.ModeSelect_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCalis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwnHiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwnDerece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnTetiklemeliMod;
        private System.Windows.Forms.Button BtnSinirliAciMod;
        private System.Windows.Forms.Button BtnTetiklemeliSinirliAciMod;
        private System.Windows.Forms.Button BtnTekYonTetiklemeliSinirliAciMod;
        private System.Windows.Forms.Button BtnManuelMod;
        private System.Windows.Forms.Button BtnKalibrasyonMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEnable;
        private System.Windows.Forms.Label LblYon_;
        private System.Windows.Forms.ComboBox CmbBxYon;
        private System.Windows.Forms.Button BtnStandartMod;
        private System.Windows.Forms.Button BtnDirection;
        private System.Windows.Forms.Button BtnPulse;
        private System.Windows.Forms.Label LblHiz_;
        private System.Windows.Forms.Label LblDrece_;
        private System.Windows.Forms.Button BtnAyarlariUygula;
        private System.Windows.Forms.Label LblYon;
        private System.Windows.Forms.Label LblHiz;
        private System.Windows.Forms.Label LblDerece;
        private System.Windows.Forms.PictureBox BtnCalis;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumUpDwnHiz;
        private System.Windows.Forms.NumericUpDown NumUpDwnDerece;
        private System.Windows.Forms.Label LblSerialPort;
        private System.Windows.Forms.Label LblBaundRate;
        private System.Windows.Forms.Button BtnReConnect;
        private System.Windows.Forms.Timer Tmr1000MS;
        private System.Windows.Forms.Button BtnNewSerial;
    }
}

