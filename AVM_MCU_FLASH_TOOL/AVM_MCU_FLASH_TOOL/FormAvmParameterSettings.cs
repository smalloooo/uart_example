using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AVM_MCU_FLASH_TOOL
{
    public partial class FormAvmParameterSettings : Form
    {
        SerialPort port = new SerialPort();
        classCarData subCarData = new classCarData();

        bool updateComplete = false;

        string R_CarData = "@R_CarData!";
        string E_CarData = "@E_CarData!";
        string W_CarData = "@W_CarData!";

        public delegate void subUICallBack(string Str, Control ctl);
        public delegate void subComboBoxUICallBack(int selectIndex, ComboBox ctl);

        public void subUI(string myStr, Control ctl)
        {
            if (this.InvokeRequired)
            {
                subUICallBack myupdate = new subUICallBack(subUI);
                this.Invoke(myupdate, myStr, ctl);
            }
            else
            {
                ctl.Text = myStr;
            }
        }

        public void subComboBoxUI(int selectIndex, ComboBox ctl)
        {
            if (this.InvokeRequired)
            {
                subComboBoxUICallBack myupdate = new subComboBoxUICallBack(subComboBoxUI);
                this.Invoke(myupdate, selectIndex, ctl);
            }
            else
            {
                ctl.SelectedIndex = selectIndex;
            }
        }

        public FormAvmParameterSettings()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.labelSubStatus.Text = "Update Car Data...";

            this.timerStatus.Interval = 500;
            timerStatus.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            UI_Disable();
            timerStatus.Start();
            FormMain formmain = (FormMain)this.Owner;
            updateSubAllCarData();
            formmain._updateMainCarData = subCarData;
            formmain.updateW_Mode = true;
            formmain.updateW_CardataMode = true;
            byte[] UTF8bytes = Encoding.UTF8.GetBytes(E_CarData);
            port.Write(UTF8bytes, 0, UTF8bytes.Length);
            labelSubStatus.Text = "Write data begin";
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            if (updateComplete == true)
            {
                UI_Enable();
                updateSubAllCarData();
                updateComplete = false;
                timerStatus.Stop();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        public SerialPort updatePortPara
        {
            set { port = value; }
            get { return port; }
        }

        public Label updatelabelSubStatus
        {
            set { labelSubStatus = value; }
            get { return labelSubStatus; }
        }

        public bool updateStatus
        {
            set { updateComplete = value; }
            get { return updateComplete; }
        }

        public classCarData updateSubCarData
        {
            set { subCarData = value; }
            get { return subCarData; }
        }

        public TextBox updateTbxfVolt
        {
            set { tbx_fVolt = value; }
            get { return tbx_fVolt; }
        }

        public TextBox updateTbxfVoltBase
        {
            set { tbx_fVoltBase = value; }
            get { return tbx_fVoltBase; }
        }

        public TextBox updateTbxfVoltMult
        {
            set { tbx_fVolMult = value; }
            get { return tbx_fVolMult; }
        }

        public TextBox updateTbxfVoltRefPwr
        {
            set { tbx_fVoltRefPwr = value; }
            get { return tbx_fVoltRefPwr; }
        }

        public TextBox updateTbxfVoltRefSlp
        {
            set { tbx_fVoltRefSlp = value; }
            get { return tbx_fVoltRefSlp; }
        }

        public TextBox updateTbxu32CarSpeed
        {
            set { tbx_u32CarSpeed = value; }
            get { return tbx_u32CarSpeed; }
        }

        public TextBox updateTbxu32CarPluse
        {
            set { tbx_u32CarPluse = value; }
            get { return tbx_u32CarPluse; }
        }

        public TextBox updateTbxu32CarVar
        {
            set { tbx_u32CarVar = value; }
            get { return tbx_u32CarVar; }
        }

        public TextBox updateTbxu32CarRefSpeed
        {
            set { tbx_u32CarRefSpeed = value; }
            get { return tbx_u32CarRefSpeed; }
        }

        public ComboBox updateCbxu8TurnLightMode
        {
            set { cbxTrunLightMode = value; }
            get { return cbxTrunLightMode; }
        }

        public Timer updateSubTimer
        {
            set { timerStatus = value; }
            get { return timerStatus; }
        }

        private void FormAvmParameterSettings_Load(object sender, EventArgs e)
        {
            UI_Disable();
        }

        private void updateSubAllCarData()
        {
            subCarData.fvolt = float.Parse(tbx_fVolt.Text);
            subCarData.fvoltBase = float.Parse(tbx_fVoltBase.Text);
            subCarData.fvoltMult = float.Parse(tbx_fVolMult.Text);
            subCarData.fvoltRefPwr = float.Parse(tbx_fVoltRefPwr.Text);
            subCarData.fvoltRefSlp = float.Parse(tbx_fVoltRefSlp.Text);
            
            subCarData.u32carPluse = UInt32.Parse(tbx_u32CarPluse.Text);
            subCarData.u32carRefSpeed = UInt32.Parse(tbx_u32CarRefSpeed.Text);
            subCarData.u32carSpeed = UInt32.Parse(tbx_u32CarSpeed.Text);
            subCarData.u32carVar = UInt32.Parse(tbx_u32CarVar.Text);

            subCarData.u8turnLightMod = (byte)cbxTrunLightMode.SelectedIndex;
        }

        public void UI_Disable()
        {
            this.btnWrite.Enabled = false;

            this.tbx_fVolMult.Enabled = false;
            this.tbx_fVolt.Enabled = false;
            this.tbx_fVoltBase.Enabled = false;
            this.tbx_fVoltRefPwr.Enabled = false;
            this.tbx_fVoltRefSlp.Enabled = false;

            this.tbx_u32CarPluse.Enabled = false;
            this.tbx_u32CarRefSpeed.Enabled = false;
            this.tbx_u32CarSpeed.Enabled = false;
            this.tbx_u32CarVar.Enabled = false;

            this.cbxTrunLightMode.Enabled = false;
        }

        public void UI_Enable()
        {
            this.btnWrite.Enabled = true;

            this.tbx_fVolMult.Enabled = true;
            this.tbx_fVolt.Enabled = true;
            this.tbx_fVoltBase.Enabled = true;
            this.tbx_fVoltRefPwr.Enabled = true;
            this.tbx_fVoltRefSlp.Enabled = true;

            this.tbx_u32CarPluse.Enabled = true;
            this.tbx_u32CarRefSpeed.Enabled = true;
            this.tbx_u32CarSpeed.Enabled = true;
            this.tbx_u32CarVar.Enabled = true;

            this.cbxTrunLightMode.Enabled = true;
        }
    }
}
