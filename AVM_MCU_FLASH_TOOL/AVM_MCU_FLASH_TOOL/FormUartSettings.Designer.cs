namespace AVM_MCU_FLASH_TOOL
{
    partial class FormUartSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUartSettings));
            this.CBX_StopBit = new System.Windows.Forms.ComboBox();
            this.CBX_DataBit = new System.Windows.Forms.ComboBox();
            this.CBX_Check = new System.Windows.Forms.ComboBox();
            this.CBX_Rate = new System.Windows.Forms.ComboBox();
            this.CBX_Port = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBX_StopBit
            // 
            this.CBX_StopBit.FormattingEnabled = true;
            this.CBX_StopBit.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.CBX_StopBit.Location = new System.Drawing.Point(105, 126);
            this.CBX_StopBit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBX_StopBit.Name = "CBX_StopBit";
            this.CBX_StopBit.Size = new System.Drawing.Size(159, 20);
            this.CBX_StopBit.TabIndex = 55;
            // 
            // CBX_DataBit
            // 
            this.CBX_DataBit.FormattingEnabled = true;
            this.CBX_DataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.CBX_DataBit.Location = new System.Drawing.Point(105, 70);
            this.CBX_DataBit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBX_DataBit.Name = "CBX_DataBit";
            this.CBX_DataBit.Size = new System.Drawing.Size(159, 20);
            this.CBX_DataBit.TabIndex = 54;
            // 
            // CBX_Check
            // 
            this.CBX_Check.FormattingEnabled = true;
            this.CBX_Check.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN",
            "MARK",
            "SPACE"});
            this.CBX_Check.Location = new System.Drawing.Point(105, 98);
            this.CBX_Check.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBX_Check.Name = "CBX_Check";
            this.CBX_Check.Size = new System.Drawing.Size(159, 20);
            this.CBX_Check.TabIndex = 53;
            // 
            // CBX_Rate
            // 
            this.CBX_Rate.FormattingEnabled = true;
            this.CBX_Rate.Items.AddRange(new object[] {
            "256000",
            "128000",
            "115200",
            "19200",
            "9600",
            "4800"});
            this.CBX_Rate.Location = new System.Drawing.Point(105, 41);
            this.CBX_Rate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBX_Rate.Name = "CBX_Rate";
            this.CBX_Rate.Size = new System.Drawing.Size(159, 20);
            this.CBX_Rate.TabIndex = 52;
            // 
            // CBX_Port
            // 
            this.CBX_Port.FormattingEnabled = true;
            this.CBX_Port.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15"});
            this.CBX_Port.Location = new System.Drawing.Point(105, 13);
            this.CBX_Port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBX_Port.Name = "CBX_Port";
            this.CBX_Port.Size = new System.Drawing.Size(159, 20);
            this.CBX_Port.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(10, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "停止位元：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "資料位元：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "同位元：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(42, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "鮑率：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "連接埠：";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(189, 153);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 56;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // FormUartSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 189);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.CBX_StopBit);
            this.Controls.Add(this.CBX_DataBit);
            this.Controls.Add(this.CBX_Check);
            this.Controls.Add(this.CBX_Rate);
            this.Controls.Add(this.CBX_Port);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUartSettings";
            this.Text = "Uart Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBX_StopBit;
        private System.Windows.Forms.ComboBox CBX_DataBit;
        private System.Windows.Forms.ComboBox CBX_Check;
        private System.Windows.Forms.ComboBox CBX_Rate;
        private System.Windows.Forms.ComboBox CBX_Port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ok;
    }
}