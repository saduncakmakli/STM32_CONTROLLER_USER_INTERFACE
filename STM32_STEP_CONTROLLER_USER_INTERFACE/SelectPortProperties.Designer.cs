namespace Design_Project
{
    partial class SelectPortProperties
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.cB_serialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_baundRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_reflesh = new System.Windows.Forms.Button();
            this.cB_DataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cB_Parity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cB_serialPort
            // 
            this.cB_serialPort.FormattingEnabled = true;
            this.cB_serialPort.Location = new System.Drawing.Point(82, 6);
            this.cB_serialPort.Name = "cB_serialPort";
            this.cB_serialPort.Size = new System.Drawing.Size(121, 21);
            this.cB_serialPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seri Port";
            // 
            // cB_baundRate
            // 
            this.cB_baundRate.FormattingEnabled = true;
            this.cB_baundRate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000",
            "500000",
            "1000000",
            "2000000"});
            this.cB_baundRate.Location = new System.Drawing.Point(82, 33);
            this.cB_baundRate.Name = "cB_baundRate";
            this.cB_baundRate.Size = new System.Drawing.Size(121, 21);
            this.cB_baundRate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Band Hızı";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(120, 121);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Bağlan";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_reflesh
            // 
            this.btn_reflesh.Location = new System.Drawing.Point(24, 121);
            this.btn_reflesh.Name = "btn_reflesh";
            this.btn_reflesh.Size = new System.Drawing.Size(75, 23);
            this.btn_reflesh.TabIndex = 2;
            this.btn_reflesh.Text = "Yenile";
            this.btn_reflesh.UseVisualStyleBackColor = true;
            this.btn_reflesh.Click += new System.EventHandler(this.btn_reflesh_Click);
            // 
            // cB_DataBits
            // 
            this.cB_DataBits.FormattingEnabled = true;
            this.cB_DataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cB_DataBits.Location = new System.Drawing.Point(82, 60);
            this.cB_DataBits.Name = "cB_DataBits";
            this.cB_DataBits.Size = new System.Drawing.Size(121, 21);
            this.cB_DataBits.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bit Uzunluğu";
            // 
            // cB_Parity
            // 
            this.cB_Parity.FormattingEnabled = true;
            this.cB_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cB_Parity.Location = new System.Drawing.Point(82, 87);
            this.cB_Parity.Name = "cB_Parity";
            this.cB_Parity.Size = new System.Drawing.Size(121, 21);
            this.cB_Parity.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parity";
            // 
            // SelectPortProperties
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(221, 155);
            this.Controls.Add(this.btn_reflesh);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_Parity);
            this.Controls.Add(this.cB_DataBits);
            this.Controls.Add(this.cB_baundRate);
            this.Controls.Add(this.cB_serialPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPortProperties";
            this.ShowIcon = false;
            this.Text = "Seri Port Bağlantı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SerialReadAndWrite_FormClosed);
            this.Load += new System.EventHandler(this.Baglanti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cB_serialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_baundRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_reflesh;
        private System.Windows.Forms.ComboBox cB_DataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB_Parity;
        private System.Windows.Forms.Label label4;
    }
}