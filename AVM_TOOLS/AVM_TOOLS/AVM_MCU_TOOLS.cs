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
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace AVM_TOOLS
{
    public partial class AVM_MCU_TOOLS : Form
    {
        DateTime dt = new DateTime();
        SerialPort port = new SerialPort();
        FileStream fs;

        string KEY_MENU  = "@UC_K_Menu!";
        string KEY_ENTER = "@UC_K_Enter!";
        string KEY_UP    = "@UC_K_Up!";
        string KEY_DOWN  = "@UC_K_Down!";
        string KEY_LEFT  = "@UC_K_Left!";
        string KEY_RIGHT = "@UC_K_Right!";
        string KEY_NUM_9 = "@UC_K_Num9!";
        string KEY_NUM_8 = "@UC_K_Num8!";
        string KEY_NUM_7 = "@UC_K_Num7!";
        string KEY_NUM_6 = "@UC_K_Num6!";
        string KEY_NUM_5 = "@UC_K_Num5!";
        string KEY_NUM_4 = "@UC_K_Num4!";
        string KEY_NUM_3 = "@UC_K_Num3!";
        string KEY_NUM_2 = "@UC_K_Num2!";
        string KEY_NUM_1 = "@UC_K_Num1!";
        string KEY_NUM_0 = "@UC_K_Num0!";

        string S_TPMS = "@S_TPMS!";
        string R_PARA = "@R_AVMPara!";
        string E_PARA = "@E_AVMPara!";
        string W_PARA = "@W_AVMPara!";
        string R_CarData = "@R_CarData!";
        string E_CarData = "@E_CarData!";
        string W_CarData = "@W_CarData!";

        byte[] ParaForSave = new byte[18432];
        byte[] ParaForSend = new byte[18432];
        byte[] CarDataForSave = new byte[2048];
        byte[] CarDataForSend = new byte[2048];
        int destIndex = 0;
        int sendIndex = 0;
        string RxBuf = "";
        bool R_Mode = false;
        bool W_Mode = false;
        bool R_CarDataMode = false;
        bool W_CarDataMode = false;
        
        int timeOutCnt = 0;

        public AVM_MCU_TOOLS()
        {
            InitializeComponent();
    
            port.DataReceived += new SerialDataReceivedEventHandler(comport_DataReceived);

            btn_Disable();
            btn_connect.Enabled = true;

            CBX_Check.SelectedIndex = 0;
            CBX_DataBit.SelectedIndex = 0;
            CBX_Port.SelectedIndex = 1;
            CBX_Rate.SelectedIndex = 4;
            CBX_StopBit.SelectedIndex = 0;

            label_Para.Visible = false;
            pictureBox1.Visible = false;
            showFloat();
        }
        
        unsafe private void showFloat()
        {
            float f = 0;
            byte[] n = new byte[] {0x00, 0x00, 0x40, 0x41};
            f = BitConverter.ToSingle(n, 0);
            f = 1;
            n = BitConverter.GetBytes(f);
            return;
        }

        private void savePara()
        {
            destIndex = 0;
            
            fs.Write(ParaForSave, 0, ParaForSave.Length);
            fs.Flush();
            fs.Close();
            fs.Dispose();
        }

        private void saveCarData()
        {
            destIndex = 0;

            fs.Write(CarDataForSave, 0, CarDataForSave.Length);
            fs.Flush();
            fs.Close();
            fs.Dispose();
        }

        private void sendPara()
        {
            if (sendIndex < ParaForSend.Length)
            {
                port.Write(ParaForSend, sendIndex, 128);
                sendIndex += 128;
            }
            else
            {
                W_Mode = false;
                W_CarDataMode = false;
            }
        }

        private void sendCarData()
        {
            if (sendIndex < CarDataForSend.Length)
            {
                port.Write(CarDataForSend, sendIndex, 128);
                sendIndex += 128;
            }
            else
            {
                W_Mode = false;
                W_CarDataMode = false;
            }
        }

        private void btn_readPara_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            dt = DateTime.Now;
            sfd.InitialDirectory = System.Environment.CurrentDirectory;
            sfd.Filter = "bin|*.bin";
            sfd.Title = "Save to new File";
            sfd.FileName = dt.ToString("yyyyMMdd_HHmmss") + "_AVM_Parameter";

            
            destIndex = 0;

            btn_Disable();

            if (port.IsOpen)
            {
                try
                {
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        fs = new FileStream(sfd.FileName, FileMode.Create);
                        this.label_Para.Text = "Data copying...";
                        timer1.Start();
                        port.WriteLine(S_TPMS);
                        Thread.Sleep(200);
                        port.ReadExisting();
                        Thread.Sleep(200);
                        RxBuf = "";
                        port.WriteLine(R_PARA);
                        R_Mode = true;
                    }
                    else
                    {
                        this.label_Para.Text = "Standby";

                        btn_Enable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }

            sfd.Dispose();
        }

        private void btn_writePara_Click(object sender, EventArgs e)
        {
            sendIndex = 0;

            btn_Disable();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = System.Environment.CurrentDirectory;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                fs.Seek(0, SeekOrigin.Begin);
                fs.Read(ParaForSend, 0, ParaForSend.Length);
                fs.Flush();
                fs.Close();

                if(port.IsOpen)
                {
                    try
                    {
                        DialogResult dlgRes = MessageBox.Show("即將清除AVM所有參數!\n按 是 確認清除並更新參數\n按 否 取消更新參數", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlgRes == DialogResult.Yes)
                        {
                            port.WriteLine(S_TPMS);
                            Thread.Sleep(200);
                            port.ReadExisting();

                            port.WriteLine(E_PARA);
                            this.label_Para.Text = "Data writing...";
                            timer1.Start();
                            W_Mode = true;
                        }
                        else
                        {
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                        label_connect_status.Text = ex.Message;
                    }
                }
            }
            else
            {
                this.label_Para.Text = "Standby";

                btn_Enable();
            }
        }

        private void comport_DataReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            //
            timeOutCnt = 0;
            
            if (W_Mode == true)
            {
                RxBuf += sp.ReadExisting();

                if (RxBuf.IndexOf("!") > 0)
                {
                    RxBuf = RxBuf.Substring(RxBuf.IndexOf("@"), RxBuf.Length - RxBuf.IndexOf("@"));
                    Console.WriteLine(RxBuf);
                    switch(RxBuf)
                    {
                        case "@E_AVMPara!":
                            port.WriteLine(W_PARA);
                            break;
                        case "@W_AVMPara!":
                            sendPara();
                            break;
                        case "@E_CarData!":
                            port.WriteLine(W_CarData);
                            break;
                        case "@W_CarData!":
                            sendCarData();
                            break;
                    }
                    RxBuf = "";
                }
            }
            else if (R_Mode == true)
            {
                Byte[] Rx_TmpBuffer = new Byte[128];
                Int32 length = sp.Read(Rx_TmpBuffer, 0, Rx_TmpBuffer.Length);
                Array.Resize(ref Rx_TmpBuffer, length);

                if (R_CarDataMode == false)
                {
                    Array.Copy(Rx_TmpBuffer, 0, ParaForSave, destIndex, Rx_TmpBuffer.Length);
                    destIndex += Rx_TmpBuffer.Length;
                    if (destIndex == 18432)
                    {
                        savePara();
                        R_Mode = false;
                        R_CarDataMode = false;
                    }
                }
                else
                {
                    Array.Copy(Rx_TmpBuffer, 0, CarDataForSave, destIndex, Rx_TmpBuffer.Length);
                    destIndex += Rx_TmpBuffer.Length;
                    if (destIndex == 2048)
                    {
                        saveCarData();
                        R_Mode = false;
                        R_CarDataMode = false;
                    }
                }
            }
            else
            {
                sp.ReadExisting();
            }
        }


        private void btn_connect_Click(object sender, EventArgs e)
        {
            if(port.IsOpen)
                port.Close();

            port.PortName = CBX_Port.GetItemText(CBX_Port.SelectedItem);
            port.BaudRate = Int32.Parse(CBX_Rate.SelectedItem.ToString());
            port.DataBits = Int32.Parse(CBX_DataBit.SelectedItem.ToString());
            port.RtsEnable = true;
            port.Handshake = Handshake.None;

            switch (CBX_StopBit.GetItemText(CBX_StopBit.SelectedItem))
            {
                case "1":
                    port.StopBits = StopBits.One;
                    break;
                case "1.5":
                    port.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    port.StopBits = StopBits.Two;
                    break;
            }

            switch (CBX_Check.GetItemText(CBX_Check.SelectedItem))
            {
                case "NONE":
                    port.Parity = Parity.None;
                    break;
                case "EVEN":
                    port.Parity = Parity.Even;
                    break;
                case "MARK":
                    port.Parity = Parity.Mark;
                    break;
                case "ODD":
                    port.Parity = Parity.Odd;
                    break;
                case "SPACE":
                    port.Parity = Parity.Space;
                    break;
            }

            try
            {
                port.Open();
                btn_Enable();
                label_connect_status.Text = "Status: Comport open was success.";
                label_Para.Visible = true;

                pictureBox1.Visible = true;
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                label_connect_status.Text = ex.Message;
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_MENU);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    this.label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_ENTER);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_UP);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_DOWN);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_LEFT);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_RIGHT);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_num9_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_NUM_9);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_num8_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_NUM_8);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_num7_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_NUM_7);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_num6_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_NUM_6);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_num5_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_NUM_5);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_num4_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_NUM_4);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_num3_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_NUM_3);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_num2_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_NUM_2);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_num1_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_NUM_1);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void btn_num0_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] UTF8bytes = Encoding.UTF8.GetBytes(KEY_NUM_0);
                    port.Write(UTF8bytes, 0, UTF8bytes.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeOutCnt += 1;
            if (R_Mode)
            {
                if(R_CarDataMode == false)
                    this.label_Para.Text = "Read parameter from AVM" + "\n" + destIndex + " / 18432";
                else
                    this.label_Para.Text = "Read parameter from AVM" + "\n" + destIndex + " / 2048";
            }
            else if(W_Mode)
            {
                if(W_CarDataMode == false)
                    this.label_Para.Text = "Write parameter to AVM" + "\n" + sendIndex + " / 18432";
                else
                    this.label_Para.Text = "Write parameter to AVM" + "\n" + sendIndex + " / 2048";
            }
            else
            {
                this.label_Para.Text = "Standby";
                btn_Enable();
            }

            if(timeOutCnt > 3)
            {
                if (R_Mode == true || W_Mode == true)
                    this.label_Para.Text = "Error: Times out!";

                this.label_connect_status.Text = "Status: AVM connection was failed";
            }
            else
            {
                this.label_connect_status.Text = "Status: AVM connection was success";
            }
        }

        private void AVM_TOOLS_Load(object sender, EventArgs e)
        {

        }

        private void btnReadCarData_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            dt = DateTime.Now;
            sfd.InitialDirectory = System.Environment.CurrentDirectory;
            sfd.Filter = "bin|*.bin";
            sfd.Title = "Save to new File";
            sfd.FileName = dt.ToString("yyyyMMdd_HHmmss") + "_AVM_CarData";


            destIndex = 0;

            btn_Disable();

            if (port.IsOpen)
            {
                try
                {
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        fs = new FileStream(sfd.FileName, FileMode.Create);
                        this.label_Para.Text = "Data copying...";
                        timer1.Start();
                        port.WriteLine(S_TPMS);
                        Thread.Sleep(200);
                        port.ReadExisting();
                        Thread.Sleep(200);
                        RxBuf = "";
                        port.WriteLine(R_CarData);
                        R_Mode = true;
                        R_CarDataMode = true;
                    }
                    else
                    {
                        this.label_Para.Text = "Standby";

                        btn_Enable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    label_connect_status.Text = ex.Message;
                }
            }

            sfd.Dispose();
        }

        private void btnWriteCarData_Click(object sender, EventArgs e)
        {
            sendIndex = 0;

            btn_Disable();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = System.Environment.CurrentDirectory;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                fs.Seek(0, SeekOrigin.Begin);
                fs.Read(CarDataForSend, 0, CarDataForSend.Length);
                fs.Flush();
                fs.Close();

                if (port.IsOpen)
                {
                    try
                    {
                        DialogResult dlgRes = MessageBox.Show("即將清除參數!\n按 是 確認清除並更新參數\n按 否 取消更新參數", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlgRes == DialogResult.Yes)
                        {
                            port.WriteLine(S_TPMS);
                            Thread.Sleep(200);
                            port.ReadExisting();

                            port.WriteLine(E_CarData);
                            this.label_Para.Text = "Data writing...";
                            timer1.Start();
                            W_Mode = true;
                            W_CarDataMode = true;
                        }
                        else
                        {
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                        label_connect_status.Text = ex.Message;
                    }
                }
            }
            else
            {
                this.label_Para.Text = "Standby";

                btn_Enable();
            }
        }

        private void btn_Enable()
        {
            btn_down.Enabled = true;
            btn_up.Enabled = true;
            btn_left.Enabled = true;
            btn_right.Enabled = true;
            btn_enter.Enabled = true;
            btn_menu.Enabled = true;
            btn_num9.Enabled = true;
            btn_num8.Enabled = true;
            btn_num7.Enabled = true;
            btn_num6.Enabled = true;
            btn_num5.Enabled = true;
            btn_num4.Enabled = true;
            btn_num3.Enabled = true;
            btn_num2.Enabled = true;
            btn_num1.Enabled = true;
            btn_num0.Enabled = true;

            btn_connect.Enabled = true;

            btn_readPara.Enabled = true;
            btn_writePara.Enabled = true;
        }
        
        private void btn_Disable()
        {
            btn_down.Enabled = false;
            btn_up.Enabled = false;
            btn_left.Enabled = false;
            btn_right.Enabled = false;
            btn_enter.Enabled = false;
            btn_menu.Enabled = false;
            btn_num9.Enabled = false;
            btn_num8.Enabled = false;
            btn_num7.Enabled = false;
            btn_num6.Enabled = false;
            btn_num5.Enabled = false;
            btn_num4.Enabled = false;
            btn_num3.Enabled = false;
            btn_num2.Enabled = false;
            btn_num1.Enabled = false;
            btn_num0.Enabled = false;

            btn_connect.Enabled = false;

            btn_readPara.Enabled = false;
            btn_writePara.Enabled = false;
        }

    }
}
