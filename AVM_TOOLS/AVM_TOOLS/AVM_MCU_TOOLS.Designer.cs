namespace AVM_TOOLS
{
    partial class AVM_MCU_TOOLS
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVM_MCU_TOOLS));
            this.btn_readPara = new System.Windows.Forms.Button();
            this.btn_writePara = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.label_connect_status = new System.Windows.Forms.Label();
            this.btn_num9 = new System.Windows.Forms.Button();
            this.btn_num8 = new System.Windows.Forms.Button();
            this.btn_num7 = new System.Windows.Forms.Button();
            this.btn_num4 = new System.Windows.Forms.Button();
            this.btn_num5 = new System.Windows.Forms.Button();
            this.btn_num6 = new System.Windows.Forms.Button();
            this.btn_num1 = new System.Windows.Forms.Button();
            this.btn_num2 = new System.Windows.Forms.Button();
            this.btn_num3 = new System.Windows.Forms.Button();
            this.btn_num0 = new System.Windows.Forms.Button();
            this.label_Para = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnWriteCarData = new System.Windows.Forms.Button();
            this.btnReadCarData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_readPara
            // 
            this.btn_readPara.Location = new System.Drawing.Point(700, 27);
            this.btn_readPara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_readPara.Name = "btn_readPara";
            this.btn_readPara.Size = new System.Drawing.Size(146, 64);
            this.btn_readPara.TabIndex = 0;
            this.btn_readPara.Text = "Read Parameters";
            this.btn_readPara.UseVisualStyleBackColor = true;
            this.btn_readPara.Click += new System.EventHandler(this.btn_readPara_Click);
            // 
            // btn_writePara
            // 
            this.btn_writePara.Location = new System.Drawing.Point(700, 98);
            this.btn_writePara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_writePara.Name = "btn_writePara";
            this.btn_writePara.Size = new System.Drawing.Size(146, 64);
            this.btn_writePara.TabIndex = 1;
            this.btn_writePara.Text = "Write Parameters";
            this.btn_writePara.UseVisualStyleBackColor = true;
            this.btn_writePara.Click += new System.EventHandler(this.btn_writePara_Click);
            // 
            // btn_up
            // 
            this.btn_up.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_up.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_up.Location = new System.Drawing.Point(462, 18);
            this.btn_up.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(104, 73);
            this.btn_up.TabIndex = 3;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_right
            // 
            this.btn_right.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_right.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_right.Location = new System.Drawing.Point(574, 98);
            this.btn_right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(104, 73);
            this.btn_right.TabIndex = 4;
            this.btn_right.Text = "Right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_left.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_left.Location = new System.Drawing.Point(350, 98);
            this.btn_left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(104, 73);
            this.btn_left.TabIndex = 5;
            this.btn_left.Text = "Left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_down
            // 
            this.btn_down.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_down.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_down.Location = new System.Drawing.Point(462, 178);
            this.btn_down.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(104, 73);
            this.btn_down.TabIndex = 6;
            this.btn_down.Text = "Down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_enter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_enter.Location = new System.Drawing.Point(462, 98);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(104, 73);
            this.btn_enter.TabIndex = 7;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_menu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_menu.Location = new System.Drawing.Point(350, 18);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(104, 73);
            this.btn_menu.TabIndex = 8;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // CBX_StopBit
            // 
            this.CBX_StopBit.FormattingEnabled = true;
            this.CBX_StopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.CBX_StopBit.Location = new System.Drawing.Point(111, 154);
            this.CBX_StopBit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBX_StopBit.Name = "CBX_StopBit";
            this.CBX_StopBit.Size = new System.Drawing.Size(159, 24);
            this.CBX_StopBit.TabIndex = 20;
            // 
            // CBX_DataBit
            // 
            this.CBX_DataBit.FormattingEnabled = true;
            this.CBX_DataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.CBX_DataBit.Location = new System.Drawing.Point(111, 118);
            this.CBX_DataBit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBX_DataBit.Name = "CBX_DataBit";
            this.CBX_DataBit.Size = new System.Drawing.Size(159, 24);
            this.CBX_DataBit.TabIndex = 19;
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
            this.CBX_Check.Location = new System.Drawing.Point(111, 84);
            this.CBX_Check.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBX_Check.Name = "CBX_Check";
            this.CBX_Check.Size = new System.Drawing.Size(159, 24);
            this.CBX_Check.TabIndex = 18;
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
            this.CBX_Rate.Location = new System.Drawing.Point(111, 49);
            this.CBX_Rate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBX_Rate.Name = "CBX_Rate";
            this.CBX_Rate.Size = new System.Drawing.Size(159, 24);
            this.CBX_Rate.TabIndex = 17;
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
            this.CBX_Port.Location = new System.Drawing.Point(111, 15);
            this.CBX_Port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBX_Port.Name = "CBX_Port";
            this.CBX_Port.Size = new System.Drawing.Size(159, 24);
            this.CBX_Port.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "停止位元：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(16, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "資料位元：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(32, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "同位元：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(48, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "鮑率：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "連接埠：";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(94, 198);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(118, 43);
            this.btn_connect.TabIndex = 21;
            this.btn_connect.Text = "Connect AVM";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label_connect_status
            // 
            this.label_connect_status.AutoSize = true;
            this.label_connect_status.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_connect_status.ForeColor = System.Drawing.Color.Green;
            this.label_connect_status.Location = new System.Drawing.Point(16, 256);
            this.label_connect_status.Name = "label_connect_status";
            this.label_connect_status.Size = new System.Drawing.Size(151, 13);
            this.label_connect_status.TabIndex = 22;
            this.label_connect_status.Text = "Status: Disconnect";
            // 
            // btn_num9
            // 
            this.btn_num9.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_num9.Location = new System.Drawing.Point(574, 278);
            this.btn_num9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num9.Name = "btn_num9";
            this.btn_num9.Size = new System.Drawing.Size(104, 73);
            this.btn_num9.TabIndex = 23;
            this.btn_num9.Text = "9";
            this.btn_num9.UseVisualStyleBackColor = true;
            this.btn_num9.Click += new System.EventHandler(this.btn_num9_Click);
            // 
            // btn_num8
            // 
            this.btn_num8.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_num8.Location = new System.Drawing.Point(462, 278);
            this.btn_num8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num8.Name = "btn_num8";
            this.btn_num8.Size = new System.Drawing.Size(104, 73);
            this.btn_num8.TabIndex = 24;
            this.btn_num8.Text = "8";
            this.btn_num8.UseVisualStyleBackColor = true;
            this.btn_num8.Click += new System.EventHandler(this.btn_num8_Click);
            // 
            // btn_num7
            // 
            this.btn_num7.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_num7.Location = new System.Drawing.Point(350, 278);
            this.btn_num7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num7.Name = "btn_num7";
            this.btn_num7.Size = new System.Drawing.Size(104, 73);
            this.btn_num7.TabIndex = 25;
            this.btn_num7.Text = "7";
            this.btn_num7.UseVisualStyleBackColor = true;
            this.btn_num7.Click += new System.EventHandler(this.btn_num7_Click);
            // 
            // btn_num4
            // 
            this.btn_num4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_num4.Location = new System.Drawing.Point(350, 358);
            this.btn_num4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num4.Name = "btn_num4";
            this.btn_num4.Size = new System.Drawing.Size(104, 73);
            this.btn_num4.TabIndex = 28;
            this.btn_num4.Text = "4";
            this.btn_num4.UseVisualStyleBackColor = true;
            this.btn_num4.Click += new System.EventHandler(this.btn_num4_Click);
            // 
            // btn_num5
            // 
            this.btn_num5.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_num5.Location = new System.Drawing.Point(462, 358);
            this.btn_num5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num5.Name = "btn_num5";
            this.btn_num5.Size = new System.Drawing.Size(104, 73);
            this.btn_num5.TabIndex = 27;
            this.btn_num5.Text = "5";
            this.btn_num5.UseVisualStyleBackColor = true;
            this.btn_num5.Click += new System.EventHandler(this.btn_num5_Click);
            // 
            // btn_num6
            // 
            this.btn_num6.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_num6.Location = new System.Drawing.Point(574, 358);
            this.btn_num6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num6.Name = "btn_num6";
            this.btn_num6.Size = new System.Drawing.Size(104, 73);
            this.btn_num6.TabIndex = 26;
            this.btn_num6.Text = "6";
            this.btn_num6.UseVisualStyleBackColor = true;
            this.btn_num6.Click += new System.EventHandler(this.btn_num6_Click);
            // 
            // btn_num1
            // 
            this.btn_num1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_num1.Location = new System.Drawing.Point(350, 438);
            this.btn_num1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num1.Name = "btn_num1";
            this.btn_num1.Size = new System.Drawing.Size(104, 73);
            this.btn_num1.TabIndex = 31;
            this.btn_num1.Text = "1";
            this.btn_num1.UseVisualStyleBackColor = true;
            this.btn_num1.Click += new System.EventHandler(this.btn_num1_Click);
            // 
            // btn_num2
            // 
            this.btn_num2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_num2.Location = new System.Drawing.Point(462, 438);
            this.btn_num2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num2.Name = "btn_num2";
            this.btn_num2.Size = new System.Drawing.Size(104, 73);
            this.btn_num2.TabIndex = 30;
            this.btn_num2.Text = "2";
            this.btn_num2.UseVisualStyleBackColor = true;
            this.btn_num2.Click += new System.EventHandler(this.btn_num2_Click);
            // 
            // btn_num3
            // 
            this.btn_num3.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_num3.Location = new System.Drawing.Point(574, 438);
            this.btn_num3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num3.Name = "btn_num3";
            this.btn_num3.Size = new System.Drawing.Size(104, 73);
            this.btn_num3.TabIndex = 29;
            this.btn_num3.Text = "3";
            this.btn_num3.UseVisualStyleBackColor = true;
            this.btn_num3.Click += new System.EventHandler(this.btn_num3_Click);
            // 
            // btn_num0
            // 
            this.btn_num0.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num0.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_num0.Location = new System.Drawing.Point(462, 518);
            this.btn_num0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num0.Name = "btn_num0";
            this.btn_num0.Size = new System.Drawing.Size(104, 73);
            this.btn_num0.TabIndex = 32;
            this.btn_num0.Text = "0";
            this.btn_num0.UseVisualStyleBackColor = true;
            this.btn_num0.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // label_Para
            // 
            this.label_Para.AutoSize = true;
            this.label_Para.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Para.ForeColor = System.Drawing.Color.Green;
            this.label_Para.Location = new System.Drawing.Point(697, 178);
            this.label_Para.Name = "label_Para";
            this.label_Para.Size = new System.Drawing.Size(71, 16);
            this.label_Para.TabIndex = 33;
            this.label_Para.Text = "Standby";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 233);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(702, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 356);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // btnWriteCarData
            // 
            this.btnWriteCarData.Location = new System.Drawing.Point(852, 97);
            this.btnWriteCarData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWriteCarData.Name = "btnWriteCarData";
            this.btnWriteCarData.Size = new System.Drawing.Size(146, 64);
            this.btnWriteCarData.TabIndex = 37;
            this.btnWriteCarData.Text = "Write Car Data";
            this.btnWriteCarData.UseVisualStyleBackColor = true;
            this.btnWriteCarData.Click += new System.EventHandler(this.btnWriteCarData_Click);
            // 
            // btnReadCarData
            // 
            this.btnReadCarData.Location = new System.Drawing.Point(852, 26);
            this.btnReadCarData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReadCarData.Name = "btnReadCarData";
            this.btnReadCarData.Size = new System.Drawing.Size(146, 64);
            this.btnReadCarData.TabIndex = 36;
            this.btnReadCarData.Text = "Read Car Data";
            this.btnReadCarData.UseVisualStyleBackColor = true;
            this.btnReadCarData.Click += new System.EventHandler(this.btnReadCarData_Click);
            // 
            // AVM_MCU_TOOLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 613);
            this.Controls.Add(this.btnWriteCarData);
            this.Controls.Add(this.btnReadCarData);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Para);
            this.Controls.Add(this.btn_num0);
            this.Controls.Add(this.btn_num1);
            this.Controls.Add(this.btn_num2);
            this.Controls.Add(this.btn_num3);
            this.Controls.Add(this.btn_num4);
            this.Controls.Add(this.btn_num5);
            this.Controls.Add(this.btn_num6);
            this.Controls.Add(this.btn_num7);
            this.Controls.Add(this.btn_num8);
            this.Controls.Add(this.btn_num9);
            this.Controls.Add(this.label_connect_status);
            this.Controls.Add(this.btn_connect);
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
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_writePara);
            this.Controls.Add(this.btn_readPara);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AVM_MCU_TOOLS";
            this.Text = "AVM MCU TOOLS";
            this.Load += new System.EventHandler(this.AVM_TOOLS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_readPara;
        private System.Windows.Forms.Button btn_writePara;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_menu;
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
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label_connect_status;
        private System.Windows.Forms.Button btn_num9;
        private System.Windows.Forms.Button btn_num8;
        private System.Windows.Forms.Button btn_num7;
        private System.Windows.Forms.Button btn_num4;
        private System.Windows.Forms.Button btn_num5;
        private System.Windows.Forms.Button btn_num6;
        private System.Windows.Forms.Button btn_num1;
        private System.Windows.Forms.Button btn_num2;
        private System.Windows.Forms.Button btn_num3;
        private System.Windows.Forms.Button btn_num0;
        private System.Windows.Forms.Label label_Para;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnWriteCarData;
        private System.Windows.Forms.Button btnReadCarData;
    }
}

