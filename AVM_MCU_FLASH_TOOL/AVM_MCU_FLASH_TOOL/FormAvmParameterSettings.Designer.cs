namespace AVM_MCU_FLASH_TOOL
{
    partial class FormAvmParameterSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvmParameterSettings));
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelSubStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_fVolt = new System.Windows.Forms.TextBox();
            this.tbx_fVoltBase = new System.Windows.Forms.TextBox();
            this.tbx_fVolMult = new System.Windows.Forms.TextBox();
            this.tbx_fVoltRefPwr = new System.Windows.Forms.TextBox();
            this.tbx_fVoltRefSlp = new System.Windows.Forms.TextBox();
            this.tbx_u32CarRefSpeed = new System.Windows.Forms.TextBox();
            this.tbx_u32CarVar = new System.Windows.Forms.TextBox();
            this.tbx_u32CarPluse = new System.Windows.Forms.TextBox();
            this.tbx_u32CarSpeed = new System.Windows.Forms.TextBox();
            this.labelcarrefspeed = new System.Windows.Forms.Label();
            this.labelcarvar = new System.Windows.Forms.Label();
            this.labelcarpluse = new System.Windows.Forms.Label();
            this.labelcarspeed = new System.Windows.Forms.Label();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTrunLightMode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(12, 17);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "Write Parameter";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 122);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelSubStatus
            // 
            this.labelSubStatus.AutoSize = true;
            this.labelSubStatus.Location = new System.Drawing.Point(0, 51);
            this.labelSubStatus.Name = "labelSubStatus";
            this.labelSubStatus.Size = new System.Drawing.Size(30, 12);
            this.labelSubStatus.TabIndex = 3;
            this.labelSubStatus.Text = "status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "fVolt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "fVoltBase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "fVoltMult";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "fVoltRefPwr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "fVoltRefSlp";
            // 
            // tbx_fVolt
            // 
            this.tbx_fVolt.Location = new System.Drawing.Point(193, 17);
            this.tbx_fVolt.Name = "tbx_fVolt";
            this.tbx_fVolt.Size = new System.Drawing.Size(100, 22);
            this.tbx_fVolt.TabIndex = 9;
            // 
            // tbx_fVoltBase
            // 
            this.tbx_fVoltBase.Location = new System.Drawing.Point(193, 43);
            this.tbx_fVoltBase.Name = "tbx_fVoltBase";
            this.tbx_fVoltBase.Size = new System.Drawing.Size(100, 22);
            this.tbx_fVoltBase.TabIndex = 10;
            // 
            // tbx_fVolMult
            // 
            this.tbx_fVolMult.Location = new System.Drawing.Point(193, 71);
            this.tbx_fVolMult.Name = "tbx_fVolMult";
            this.tbx_fVolMult.Size = new System.Drawing.Size(100, 22);
            this.tbx_fVolMult.TabIndex = 11;
            // 
            // tbx_fVoltRefPwr
            // 
            this.tbx_fVoltRefPwr.Location = new System.Drawing.Point(193, 99);
            this.tbx_fVoltRefPwr.Name = "tbx_fVoltRefPwr";
            this.tbx_fVoltRefPwr.Size = new System.Drawing.Size(100, 22);
            this.tbx_fVoltRefPwr.TabIndex = 12;
            // 
            // tbx_fVoltRefSlp
            // 
            this.tbx_fVoltRefSlp.Location = new System.Drawing.Point(193, 127);
            this.tbx_fVoltRefSlp.Name = "tbx_fVoltRefSlp";
            this.tbx_fVoltRefSlp.Size = new System.Drawing.Size(100, 22);
            this.tbx_fVoltRefSlp.TabIndex = 13;
            // 
            // tbx_u32CarRefSpeed
            // 
            this.tbx_u32CarRefSpeed.Location = new System.Drawing.Point(392, 97);
            this.tbx_u32CarRefSpeed.Name = "tbx_u32CarRefSpeed";
            this.tbx_u32CarRefSpeed.Size = new System.Drawing.Size(100, 22);
            this.tbx_u32CarRefSpeed.TabIndex = 21;
            // 
            // tbx_u32CarVar
            // 
            this.tbx_u32CarVar.Location = new System.Drawing.Point(392, 69);
            this.tbx_u32CarVar.Name = "tbx_u32CarVar";
            this.tbx_u32CarVar.Size = new System.Drawing.Size(100, 22);
            this.tbx_u32CarVar.TabIndex = 20;
            // 
            // tbx_u32CarPluse
            // 
            this.tbx_u32CarPluse.Location = new System.Drawing.Point(392, 41);
            this.tbx_u32CarPluse.Name = "tbx_u32CarPluse";
            this.tbx_u32CarPluse.Size = new System.Drawing.Size(100, 22);
            this.tbx_u32CarPluse.TabIndex = 19;
            // 
            // tbx_u32CarSpeed
            // 
            this.tbx_u32CarSpeed.Location = new System.Drawing.Point(392, 15);
            this.tbx_u32CarSpeed.Name = "tbx_u32CarSpeed";
            this.tbx_u32CarSpeed.Size = new System.Drawing.Size(100, 22);
            this.tbx_u32CarSpeed.TabIndex = 18;
            // 
            // labelcarrefspeed
            // 
            this.labelcarrefspeed.AutoSize = true;
            this.labelcarrefspeed.Location = new System.Drawing.Point(307, 101);
            this.labelcarrefspeed.Name = "labelcarrefspeed";
            this.labelcarrefspeed.Size = new System.Drawing.Size(85, 12);
            this.labelcarrefspeed.TabIndex = 17;
            this.labelcarrefspeed.Text = "u32CarRefSpeed";
            // 
            // labelcarvar
            // 
            this.labelcarvar.AutoSize = true;
            this.labelcarvar.Location = new System.Drawing.Point(307, 72);
            this.labelcarvar.Name = "labelcarvar";
            this.labelcarvar.Size = new System.Drawing.Size(57, 12);
            this.labelcarvar.TabIndex = 16;
            this.labelcarvar.Text = "u32CarVar";
            // 
            // labelcarpluse
            // 
            this.labelcarpluse.AutoSize = true;
            this.labelcarpluse.Location = new System.Drawing.Point(307, 44);
            this.labelcarpluse.Name = "labelcarpluse";
            this.labelcarpluse.Size = new System.Drawing.Size(64, 12);
            this.labelcarpluse.TabIndex = 15;
            this.labelcarpluse.Text = "u32CarPluse";
            // 
            // labelcarspeed
            // 
            this.labelcarspeed.AutoSize = true;
            this.labelcarspeed.Location = new System.Drawing.Point(307, 18);
            this.labelcarspeed.Name = "labelcarspeed";
            this.labelcarspeed.Size = new System.Drawing.Size(68, 12);
            this.labelcarspeed.TabIndex = 14;
            this.labelcarspeed.Text = "u32CarSpeed";
            // 
            // timerStatus
            // 
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "u8TrunLight";
            // 
            // cbxTrunLightMode
            // 
            this.cbxTrunLightMode.FormattingEnabled = true;
            this.cbxTrunLightMode.Items.AddRange(new object[] {
            "關閉",
            "開啟"});
            this.cbxTrunLightMode.Location = new System.Drawing.Point(392, 127);
            this.cbxTrunLightMode.Name = "cbxTrunLightMode";
            this.cbxTrunLightMode.Size = new System.Drawing.Size(100, 20);
            this.cbxTrunLightMode.TabIndex = 23;
            // 
            // FormAvmParameterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 157);
            this.Controls.Add(this.cbxTrunLightMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_u32CarRefSpeed);
            this.Controls.Add(this.tbx_u32CarVar);
            this.Controls.Add(this.tbx_u32CarPluse);
            this.Controls.Add(this.tbx_u32CarSpeed);
            this.Controls.Add(this.labelcarrefspeed);
            this.Controls.Add(this.labelcarvar);
            this.Controls.Add(this.labelcarpluse);
            this.Controls.Add(this.labelcarspeed);
            this.Controls.Add(this.tbx_fVoltRefSlp);
            this.Controls.Add(this.tbx_fVoltRefPwr);
            this.Controls.Add(this.tbx_fVolMult);
            this.Controls.Add(this.tbx_fVoltBase);
            this.Controls.Add(this.tbx_fVolt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSubStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWrite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAvmParameterSettings";
            this.Text = "AVM Parameter Settings";
            this.Load += new System.EventHandler(this.FormAvmParameterSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelSubStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_fVolt;
        private System.Windows.Forms.TextBox tbx_fVoltBase;
        private System.Windows.Forms.TextBox tbx_fVolMult;
        private System.Windows.Forms.TextBox tbx_fVoltRefPwr;
        private System.Windows.Forms.TextBox tbx_fVoltRefSlp;
        private System.Windows.Forms.TextBox tbx_u32CarRefSpeed;
        private System.Windows.Forms.TextBox tbx_u32CarVar;
        private System.Windows.Forms.TextBox tbx_u32CarPluse;
        private System.Windows.Forms.TextBox tbx_u32CarSpeed;
        private System.Windows.Forms.Label labelcarrefspeed;
        private System.Windows.Forms.Label labelcarvar;
        private System.Windows.Forms.Label labelcarpluse;
        private System.Windows.Forms.Label labelcarspeed;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTrunLightMode;
    }
}