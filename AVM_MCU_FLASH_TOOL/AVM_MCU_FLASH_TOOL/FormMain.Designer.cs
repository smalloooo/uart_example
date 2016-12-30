namespace AVM_MCU_FLASH_TOOL
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_connect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAvmParaSet = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btn_readPara = new System.Windows.Forms.Button();
            this.btn_writePara = new System.Windows.Forms.Button();
            this.btn_num0 = new System.Windows.Forms.Button();
            this.btn_num1 = new System.Windows.Forms.Button();
            this.btn_num2 = new System.Windows.Forms.Button();
            this.btn_num3 = new System.Windows.Forms.Button();
            this.btn_num4 = new System.Windows.Forms.Button();
            this.btn_num5 = new System.Windows.Forms.Button();
            this.btn_num6 = new System.Windows.Forms.Button();
            this.btn_num7 = new System.Windows.Forms.Button();
            this.btn_num8 = new System.Windows.Forms.Button();
            this.btn_num9 = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uartToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // uartToolStripMenuItem
            // 
            this.uartToolStripMenuItem.Name = "uartToolStripMenuItem";
            this.uartToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.uartToolStripMenuItem.Text = "Uart";
            this.uartToolStripMenuItem.Click += new System.EventHandler(this.uartToolStripMenuItem_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_connect.ForeColor = System.Drawing.Color.Black;
            this.btn_connect.Location = new System.Drawing.Point(12, 39);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(118, 43);
            this.btn_connect.TabIndex = 22;
            this.btn_connect.Text = "Open COM Port";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(541, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // btnAvmParaSet
            // 
            this.btnAvmParaSet.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAvmParaSet.ForeColor = System.Drawing.Color.Black;
            this.btnAvmParaSet.Location = new System.Drawing.Point(12, 89);
            this.btnAvmParaSet.Name = "btnAvmParaSet";
            this.btnAvmParaSet.Size = new System.Drawing.Size(118, 43);
            this.btnAvmParaSet.TabIndex = 24;
            this.btnAvmParaSet.Text = "AVM Car Data";
            this.btnAvmParaSet.UseVisualStyleBackColor = true;
            this.btnAvmParaSet.Click += new System.EventHandler(this.btnAvmParaSet_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 246);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(35, 12);
            this.labelStatus.TabIndex = 25;
            this.labelStatus.Text = "Ready";
            // 
            // btn_readPara
            // 
            this.btn_readPara.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_readPara.ForeColor = System.Drawing.Color.Black;
            this.btn_readPara.Location = new System.Drawing.Point(12, 138);
            this.btn_readPara.Name = "btn_readPara";
            this.btn_readPara.Size = new System.Drawing.Size(118, 43);
            this.btn_readPara.TabIndex = 26;
            this.btn_readPara.Text = "Read Parameter";
            this.btn_readPara.UseVisualStyleBackColor = true;
            this.btn_readPara.Click += new System.EventHandler(this.btn_readPara_Click);
            // 
            // btn_writePara
            // 
            this.btn_writePara.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_writePara.ForeColor = System.Drawing.Color.Black;
            this.btn_writePara.Location = new System.Drawing.Point(12, 187);
            this.btn_writePara.Name = "btn_writePara";
            this.btn_writePara.Size = new System.Drawing.Size(118, 43);
            this.btn_writePara.TabIndex = 27;
            this.btn_writePara.Text = "Write Parameter";
            this.btn_writePara.UseVisualStyleBackColor = true;
            this.btn_writePara.Click += new System.EventHandler(this.btn_writePara_Click);
            // 
            // btn_num0
            // 
            this.btn_num0.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num0.ForeColor = System.Drawing.Color.Sienna;
            this.btn_num0.Location = new System.Drawing.Point(306, 380);
            this.btn_num0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num0.Name = "btn_num0";
            this.btn_num0.Size = new System.Drawing.Size(104, 49);
            this.btn_num0.TabIndex = 48;
            this.btn_num0.Text = "0";
            this.btn_num0.UseVisualStyleBackColor = true;
            this.btn_num0.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // btn_num1
            // 
            this.btn_num1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num1.ForeColor = System.Drawing.Color.Sienna;
            this.btn_num1.Location = new System.Drawing.Point(194, 323);
            this.btn_num1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num1.Name = "btn_num1";
            this.btn_num1.Size = new System.Drawing.Size(104, 49);
            this.btn_num1.TabIndex = 47;
            this.btn_num1.Text = "1";
            this.btn_num1.UseVisualStyleBackColor = true;
            this.btn_num1.Click += new System.EventHandler(this.btn_num1_Click);
            // 
            // btn_num2
            // 
            this.btn_num2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num2.ForeColor = System.Drawing.Color.Sienna;
            this.btn_num2.Location = new System.Drawing.Point(306, 323);
            this.btn_num2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num2.Name = "btn_num2";
            this.btn_num2.Size = new System.Drawing.Size(104, 49);
            this.btn_num2.TabIndex = 46;
            this.btn_num2.Text = "2";
            this.btn_num2.UseVisualStyleBackColor = true;
            this.btn_num2.Click += new System.EventHandler(this.btn_num2_Click);
            // 
            // btn_num3
            // 
            this.btn_num3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num3.ForeColor = System.Drawing.Color.Sienna;
            this.btn_num3.Location = new System.Drawing.Point(418, 323);
            this.btn_num3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num3.Name = "btn_num3";
            this.btn_num3.Size = new System.Drawing.Size(104, 49);
            this.btn_num3.TabIndex = 45;
            this.btn_num3.Text = "3";
            this.btn_num3.UseVisualStyleBackColor = true;
            this.btn_num3.Click += new System.EventHandler(this.btn_num3_Click);
            // 
            // btn_num4
            // 
            this.btn_num4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num4.ForeColor = System.Drawing.Color.Sienna;
            this.btn_num4.Location = new System.Drawing.Point(194, 266);
            this.btn_num4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num4.Name = "btn_num4";
            this.btn_num4.Size = new System.Drawing.Size(104, 49);
            this.btn_num4.TabIndex = 44;
            this.btn_num4.Text = "4";
            this.btn_num4.UseVisualStyleBackColor = true;
            this.btn_num4.Click += new System.EventHandler(this.btn_num4_Click);
            // 
            // btn_num5
            // 
            this.btn_num5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num5.ForeColor = System.Drawing.Color.Sienna;
            this.btn_num5.Location = new System.Drawing.Point(306, 266);
            this.btn_num5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num5.Name = "btn_num5";
            this.btn_num5.Size = new System.Drawing.Size(104, 49);
            this.btn_num5.TabIndex = 43;
            this.btn_num5.Text = "5";
            this.btn_num5.UseVisualStyleBackColor = true;
            this.btn_num5.Click += new System.EventHandler(this.btn_num5_Click);
            // 
            // btn_num6
            // 
            this.btn_num6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num6.ForeColor = System.Drawing.Color.Sienna;
            this.btn_num6.Location = new System.Drawing.Point(418, 266);
            this.btn_num6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num6.Name = "btn_num6";
            this.btn_num6.Size = new System.Drawing.Size(104, 49);
            this.btn_num6.TabIndex = 42;
            this.btn_num6.Text = "6";
            this.btn_num6.UseVisualStyleBackColor = true;
            this.btn_num6.Click += new System.EventHandler(this.btn_num6_Click);
            // 
            // btn_num7
            // 
            this.btn_num7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num7.ForeColor = System.Drawing.Color.Sienna;
            this.btn_num7.Location = new System.Drawing.Point(194, 209);
            this.btn_num7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num7.Name = "btn_num7";
            this.btn_num7.Size = new System.Drawing.Size(104, 49);
            this.btn_num7.TabIndex = 41;
            this.btn_num7.Text = "7";
            this.btn_num7.UseVisualStyleBackColor = true;
            this.btn_num7.Click += new System.EventHandler(this.btn_num7_Click);
            // 
            // btn_num8
            // 
            this.btn_num8.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num8.ForeColor = System.Drawing.Color.Sienna;
            this.btn_num8.Location = new System.Drawing.Point(306, 209);
            this.btn_num8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num8.Name = "btn_num8";
            this.btn_num8.Size = new System.Drawing.Size(104, 49);
            this.btn_num8.TabIndex = 40;
            this.btn_num8.Text = "8";
            this.btn_num8.UseVisualStyleBackColor = true;
            this.btn_num8.Click += new System.EventHandler(this.btn_num8_Click);
            // 
            // btn_num9
            // 
            this.btn_num9.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_num9.ForeColor = System.Drawing.Color.Sienna;
            this.btn_num9.Location = new System.Drawing.Point(418, 209);
            this.btn_num9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_num9.Name = "btn_num9";
            this.btn_num9.Size = new System.Drawing.Size(104, 49);
            this.btn_num9.TabIndex = 39;
            this.btn_num9.Text = "9";
            this.btn_num9.UseVisualStyleBackColor = true;
            this.btn_num9.Click += new System.EventHandler(this.btn_num9_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_menu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_menu.Location = new System.Drawing.Point(194, 39);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(104, 49);
            this.btn_menu.TabIndex = 38;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_enter.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_enter.Location = new System.Drawing.Point(306, 95);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(104, 49);
            this.btn_enter.TabIndex = 37;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_down
            // 
            this.btn_down.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_down.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_down.Location = new System.Drawing.Point(306, 152);
            this.btn_down.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(104, 49);
            this.btn_down.TabIndex = 36;
            this.btn_down.Text = "Down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_left
            // 
            this.btn_left.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_left.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_left.Location = new System.Drawing.Point(194, 95);
            this.btn_left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(104, 49);
            this.btn_left.TabIndex = 35;
            this.btn_left.Text = "Left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_right.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_right.Location = new System.Drawing.Point(418, 95);
            this.btn_right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(104, 49);
            this.btn_right.TabIndex = 34;
            this.btn_right.Text = "Right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_up
            // 
            this.btn_up.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_up.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_up.Location = new System.Drawing.Point(306, 39);
            this.btn_up.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(104, 49);
            this.btn_up.TabIndex = 33;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 466);
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
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_writePara);
            this.Controls.Add(this.btn_readPara);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnAvmParaSet);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "AVM MCU FLASH TOOL";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uartToolStripMenuItem;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnAvmParaSet;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btn_readPara;
        private System.Windows.Forms.Button btn_writePara;
        private System.Windows.Forms.Button btn_num0;
        private System.Windows.Forms.Button btn_num1;
        private System.Windows.Forms.Button btn_num2;
        private System.Windows.Forms.Button btn_num3;
        private System.Windows.Forms.Button btn_num4;
        private System.Windows.Forms.Button btn_num5;
        private System.Windows.Forms.Button btn_num6;
        private System.Windows.Forms.Button btn_num7;
        private System.Windows.Forms.Button btn_num8;
        private System.Windows.Forms.Button btn_num9;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_up;
    }
}

