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
using System.IO;
using System.Threading;

namespace AVM_MCU_FLASH_TOOL
{
    public partial class FormMain : Form
    {
        FormAvmParameterSettings avmParadlg = new FormAvmParameterSettings();
        classUartSettings Uart1Settings = new classUartSettings();
        FormUartSettings uartdlg = new FormUartSettings();
        SerialPort port = new SerialPort();
        classCarData mainCarData = new classCarData();
        DateTime dt = new DateTime();

        FileStream fs;

        byte[] ParaForSave = new byte[18432];
        byte[] ParaForSend = new byte[18432];
        byte[] CarDataForSave = new byte[2048];
        byte[] CarDataForSend = new byte[2048];
        int destIndex = 0;
        int sendIndex = 0;
        int carDataStartIndex = 0;
        int carDataCurIndex = 0;
        string RxBuf = "";
        bool R_Mode = false;
        bool W_Mode = false;
        bool R_CarDataMode = false;
        bool W_CarDataMode = false;
        bool R_CarDataFinish = false;
        bool W_CarDataFinish = false;

        string KEY_MENU = "@UC_K_Menu!";
        string KEY_ENTER = "@UC_K_Enter!";
        string KEY_UP = "@UC_K_Up!";
        string KEY_DOWN = "@UC_K_Down!";
        string KEY_LEFT = "@UC_K_Left!";
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

        private delegate void commonUICallBack(string Str, Control ctl);

        private void commonUI(string myStr, Control ctl)
        {
            if (this.InvokeRequired)
            {
                commonUICallBack myupdate = new commonUICallBack(commonUI);
                this.Invoke(myupdate, myStr, ctl);
            }
            else
            {
                ctl.Text = myStr;
                if(R_Mode == true || W_Mode == true)
                {
                    ctl.Enabled = false;
                }
                else
                {
                    ctl.Enabled = true;
                }
            }
        }

        public FormMain()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            port.DataReceived += new SerialDataReceivedEventHandler(comport1_DataReceived);

            updateUartSettings();
        }

        private void comport1_DataReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            if (W_Mode == true)
            {
                RxBuf += sp.ReadExisting();

                if (RxBuf.IndexOf("!") > 0)
                {
                    RxBuf = RxBuf.Substring(RxBuf.IndexOf("@"), RxBuf.Length - RxBuf.IndexOf("@"));
                    Console.WriteLine(RxBuf);
                    switch (RxBuf)
                    {
                        case "@E_AVMPara!":
                            port.WriteLine(W_PARA);
                            break;
                        case "@W_AVMPara!":
                            sendPara();
                            break;
                        case "@E_CarData!":
                            updateArrayMainCarData();
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
                    }
                }
                else
                {
                    Array.Copy(Rx_TmpBuffer, 0, CarDataForSave, destIndex, Rx_TmpBuffer.Length);
                    destIndex += Rx_TmpBuffer.Length;
                    if (destIndex == 2048)
                    {
                        saveCarData();
                        commonUI("CarData Ok", labelStatus);

                        commonUI("Update Complete.", this.avmParadlg.updatelabelSubStatus);
                        updateClassMainCarData();
                        this.avmParadlg.updateStatus = true;
                        
                    }
                }
            }
            else
            {
                sp.ReadExisting();
            }

        }

        private void savePara()
        {
            destIndex = 0;

            fs.Write(ParaForSave, 0, ParaForSave.Length);
            fs.Flush();
            fs.Close();
            fs.Dispose();
            R_Mode = false;
            R_CarDataMode = false;
            mainUI_Deg();
            commonUI("Copy Complete!", labelStatus);
        }

        private void saveCarData()
        {
            destIndex = 0;

            fs.Write(CarDataForSave, 0, CarDataForSave.Length);
            fs.Flush();
            fs.Close();
            fs.Dispose();

            Array.Copy(CarDataForSave, CarDataForSend, CarDataForSend.Length);

            R_Mode = false;
            R_CarDataMode = false;
            mainUI_Deg();
            commonUI("Copy Complete!", labelStatus);
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
                W_CarDataFinish = false;
                mainUI_Deg();
                commonUI("Write Complete!", labelStatus);
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
                commonUI("Write Complete.", this.avmParadlg.updatelabelSubStatus);
                sendIndex = 0;
                W_Mode = false;
                W_CarDataFinish = false;
                this.avmParadlg.updateStatus = true;
            }
        }

        private void uartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uartdlg.ShowDialog() == DialogResult.OK)
            {
                updateUartSettings();
            }
        }

        private void updateUartSettings()
        {
            Uart1Settings = uartdlg.backEquiSettings();

            port.PortName = Uart1Settings.getPortName();
            port.BaudRate = Uart1Settings.getBaudRate();
            port.DataBits = Uart1Settings.getDataBits();
            port.Parity   = Uart1Settings.getParity();
            port.StopBits = Uart1Settings.getStopBits();

            statusStrip1.Items[0].Text = port.PortName + ", " +
                                         port.BaudRate.ToString() + ", " +
                                         port.DataBits.ToString() + ", " +
                                         port.Parity.ToString() + ", " +
                                         port.StopBits.ToString(); ;
            statusStrip1.Items[1].Text = "Close";

            if (port.IsOpen)
                port.Close();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                main_UI_Disable();
                port.Close();
                btn_connect.Text = "Open COM Port";
                statusStrip1.Items[1].Text = "Close";
            }
            else
            {
                try
                {
                    port.Open();
                    btn_connect.Text = "Close COM Port";
                    statusStrip1.Items[1].Text = "Open";
                    main_UI_Enable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAvmParaSet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            dt = DateTime.Now;
            sfd.InitialDirectory = System.Environment.CurrentDirectory;
            sfd.Filter = "bin|*.bin";
            sfd.Title = "Save to new File";
            sfd.FileName = dt.ToString("yyyyMMdd_HHmmss") + "_AVM_CarData";

            destIndex = 0;

            if (port.IsOpen)
            {
                try
                {
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        fs = new FileStream(sfd.FileName, FileMode.Create);
                        port.WriteLine(S_TPMS);
                        Thread.Sleep(200);
                        port.ReadExisting();
                        Thread.Sleep(200);
                        RxBuf = "";
                        port.WriteLine(R_CarData);
                        R_Mode = true;
                        R_CarDataMode = true;
                        commonUI("CarData Begin", labelStatus);
                        commonUI("CarData Begine.", this.avmParadlg.updatelabelSubStatus);
                        this.avmParadlg.updatePortPara = this.port;
                        this.avmParadlg.Owner = this;
                        this.avmParadlg.ShowDialog();
                        this.avmParadlg.updateSubTimer.Start();
                    }
                    else
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("老大你還沒連線啊！", "暈！", MessageBoxButtons.OK);
            }
            
            sfd.Dispose();
        }

        private void updateArrayMainCarData()
        {
            byte[] tmpByte = new byte[4];
            carDataCurIndex = carDataStartIndex;

            tmpByte = BitConverter.GetBytes(mainCarData.fvolt);
            Array.Copy(tmpByte, 0, CarDataForSend, carDataCurIndex, tmpByte.Length);
            carDataCurIndex += 4;

            tmpByte = BitConverter.GetBytes(mainCarData.fvoltBase);
            Array.Copy(tmpByte, 0, CarDataForSend, carDataCurIndex, tmpByte.Length);
            carDataCurIndex += 4;

            tmpByte = BitConverter.GetBytes(mainCarData.fvoltMult);
            Array.Copy(tmpByte, 0, CarDataForSend, carDataCurIndex, tmpByte.Length);
            carDataCurIndex += 4;

            tmpByte = BitConverter.GetBytes(mainCarData.fvoltRefPwr);
            Array.Copy(tmpByte, 0, CarDataForSend, carDataCurIndex, tmpByte.Length);
            carDataCurIndex += 4;

            tmpByte = BitConverter.GetBytes(mainCarData.fvoltRefSlp);
            Array.Copy(tmpByte, 0, CarDataForSend, carDataCurIndex, tmpByte.Length);
            carDataCurIndex += 4;

            tmpByte = BitConverter.GetBytes(mainCarData.u32carSpeed);
            Array.Copy(tmpByte, 0, CarDataForSend, carDataCurIndex, tmpByte.Length);
            carDataCurIndex += 4;

            tmpByte = BitConverter.GetBytes(mainCarData.u32carPluse);
            Array.Copy(tmpByte, 0, CarDataForSend, carDataCurIndex, tmpByte.Length);
            carDataCurIndex += 4;

            tmpByte = BitConverter.GetBytes(mainCarData.u32carVar);
            Array.Copy(tmpByte, 0, CarDataForSend, carDataCurIndex, tmpByte.Length);
            carDataCurIndex += 4;

            tmpByte = BitConverter.GetBytes(mainCarData.u32carRefSpeed);
            Array.Copy(tmpByte, 0, CarDataForSend, carDataCurIndex, tmpByte.Length);
            carDataCurIndex += 4;

            tmpByte = BitConverter.GetBytes(mainCarData.u8turnLightMod);
            Array.Copy(tmpByte, 0, CarDataForSend, carDataCurIndex, tmpByte.Length);
            carDataCurIndex += 4;
        }

        private void updateClassMainCarData()
        {
            byte[] tmpByte = new byte[4];
            byte tmp1Byte;
            for (carDataStartIndex = 4; carDataStartIndex < CarDataForSave.Length; carDataStartIndex += 4)
            {
                if (CarDataForSave[carDataStartIndex] != 0xFF)
                {
                    carDataCurIndex = carDataStartIndex;
                    break;
                }
            }

            if (carDataCurIndex < CarDataForSave.Length)
            {
                tmpByte[0] = CarDataForSave[carDataCurIndex];
                tmpByte[1] = CarDataForSave[carDataCurIndex + 1];
                tmpByte[2] = CarDataForSave[carDataCurIndex + 2];
                tmpByte[3] = CarDataForSave[carDataCurIndex + 3];
                mainCarData.fvolt = BitConverter.ToSingle(tmpByte, 0);
                this.avmParadlg.subUI(mainCarData.fvolt.ToString(), this.avmParadlg.updateTbxfVolt);
                carDataCurIndex += 4;

                tmpByte[0] = CarDataForSave[carDataCurIndex];
                tmpByte[1] = CarDataForSave[carDataCurIndex + 1];
                tmpByte[2] = CarDataForSave[carDataCurIndex + 2];
                tmpByte[3] = CarDataForSave[carDataCurIndex + 3];
                mainCarData.fvoltBase = BitConverter.ToSingle(tmpByte, 0);
                this.avmParadlg.subUI(mainCarData.fvoltBase.ToString(), this.avmParadlg.updateTbxfVoltBase);
                carDataCurIndex += 4;

                tmpByte[0] = CarDataForSave[carDataCurIndex];
                tmpByte[1] = CarDataForSave[carDataCurIndex + 1];
                tmpByte[2] = CarDataForSave[carDataCurIndex + 2];
                tmpByte[3] = CarDataForSave[carDataCurIndex + 3];
                mainCarData.fvoltMult = BitConverter.ToSingle(tmpByte, 0);
                this.avmParadlg.subUI(mainCarData.fvoltMult.ToString(), this.avmParadlg.updateTbxfVoltMult);
                carDataCurIndex += 4;

                tmpByte[0] = CarDataForSave[carDataCurIndex];
                tmpByte[1] = CarDataForSave[carDataCurIndex + 1];
                tmpByte[2] = CarDataForSave[carDataCurIndex + 2];
                tmpByte[3] = CarDataForSave[carDataCurIndex + 3];
                mainCarData.fvoltRefPwr = BitConverter.ToSingle(tmpByte, 0);
                this.avmParadlg.subUI(mainCarData.fvoltRefPwr.ToString(), this.avmParadlg.updateTbxfVoltRefPwr);
                carDataCurIndex += 4;

                tmpByte[0] = CarDataForSave[carDataCurIndex];
                tmpByte[1] = CarDataForSave[carDataCurIndex + 1];
                tmpByte[2] = CarDataForSave[carDataCurIndex + 2];
                tmpByte[3] = CarDataForSave[carDataCurIndex + 3];
                mainCarData.fvoltRefSlp = BitConverter.ToSingle(tmpByte, 0);
                this.avmParadlg.subUI(mainCarData.fvoltRefSlp.ToString(), this.avmParadlg.updateTbxfVoltRefSlp);
                carDataCurIndex += 4;

                tmpByte[0] = CarDataForSave[carDataCurIndex];
                tmpByte[1] = CarDataForSave[carDataCurIndex + 1];
                tmpByte[2] = CarDataForSave[carDataCurIndex + 2];
                tmpByte[3] = CarDataForSave[carDataCurIndex + 3];
                mainCarData.u32carSpeed = BitConverter.ToUInt32(tmpByte, 0);
                this.avmParadlg.subUI(mainCarData.u32carSpeed.ToString(), this.avmParadlg.updateTbxu32CarSpeed);
                carDataCurIndex += 4;

                tmpByte[0] = CarDataForSave[carDataCurIndex];
                tmpByte[1] = CarDataForSave[carDataCurIndex + 1];
                tmpByte[2] = CarDataForSave[carDataCurIndex + 2];
                tmpByte[3] = CarDataForSave[carDataCurIndex + 3];
                mainCarData.u32carPluse = BitConverter.ToUInt32(tmpByte, 0);
                this.avmParadlg.subUI(mainCarData.u32carPluse.ToString(), this.avmParadlg.updateTbxu32CarPluse);
                carDataCurIndex += 4;

                tmpByte[0] = CarDataForSave[carDataCurIndex];
                tmpByte[1] = CarDataForSave[carDataCurIndex + 1];
                tmpByte[2] = CarDataForSave[carDataCurIndex + 2];
                tmpByte[3] = CarDataForSave[carDataCurIndex + 3];
                mainCarData.u32carVar = BitConverter.ToUInt32(tmpByte, 0);
                this.avmParadlg.subUI(mainCarData.u32carVar.ToString(), this.avmParadlg.updateTbxu32CarVar);
                carDataCurIndex += 4;

                tmpByte[0] = CarDataForSave[carDataCurIndex];
                tmpByte[1] = CarDataForSave[carDataCurIndex + 1];
                tmpByte[2] = CarDataForSave[carDataCurIndex + 2];
                tmpByte[3] = CarDataForSave[carDataCurIndex + 3];
                mainCarData.u32carRefSpeed = BitConverter.ToUInt32(tmpByte, 0);
                this.avmParadlg.subUI(mainCarData.u32carRefSpeed.ToString(), this.avmParadlg.updateTbxu32CarRefSpeed);
                carDataCurIndex += 4;

                tmp1Byte = CarDataForSave[carDataCurIndex];
                mainCarData.u8turnLightMod = tmp1Byte;
                this.avmParadlg.subComboBoxUI(mainCarData.u8turnLightMod, this.avmParadlg.updateCbxu8TurnLightMode);
            }
            else
            {
                MessageBox.Show("資料可能已經毀損，請重新上電！", "不會吧！", MessageBoxButtons.OK);
            }
        }

        public Label updatelabeStatus
        {
            set { labelStatus = value; }
            get { return labelStatus; }
        }

        public classCarData _updateMainCarData
        {
            set { mainCarData = value; }
            get { return mainCarData; }
        }

        public bool updateR_Mode
        {
            set { R_Mode = value; }
            get { return R_Mode; }
        }

        public bool updateW_Mode
        {
            set { W_Mode = value; }
            get { return W_Mode; }
        }

        public bool updateR_CardataMode
        {
            set { R_CarDataMode = value; }
            get { return R_CarDataMode; }
        }

        public bool updateW_CardataMode
        {
            set { W_CarDataMode = value; }
            get { return W_CarDataMode; }
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

            main_UI_Disable();

            if (port.IsOpen)
            {
                try
                {
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        fs = new FileStream(sfd.FileName, FileMode.Create);
                        this.labelStatus.Text = "Data copying...";
                        //timer1.Start();
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
                        this.labelStatus.Text = "Standby";

                        main_UI_Enable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
                    //label_connect_status.Text = ex.Message;
                }
            }

            sfd.Dispose();
        }

        private void btn_writePara_Click(object sender, EventArgs e)
        {
            sendIndex = 0;

            main_UI_Disable();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = System.Environment.CurrentDirectory;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                fs.Seek(0, SeekOrigin.Begin);
                fs.Read(ParaForSend, 0, ParaForSend.Length);
                fs.Flush();
                fs.Close();

                if (port.IsOpen)
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
                            this.labelStatus.Text = "Data writing...";
                            //timer1.Start();
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
                        //label_connect_status.Text = ex.Message;
                    }
                }
            }
            else
            {
                this.labelStatus.Text = "Standby";

                main_UI_Enable();
            }
        }

        private void main_UI_Disable()
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

            btnAvmParaSet.Enabled = false;
            btn_readPara.Enabled = false;
            btn_writePara.Enabled = false;
        }

        private void main_UI_Enable()
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

            btnAvmParaSet.Enabled = true;
            btn_readPara.Enabled = true;
            btn_writePara.Enabled = true;
        }

        private void mainUI_Deg()
        {
            commonUI(btn_down.Text, btn_down);
            commonUI(btn_up.Text, btn_up);
            commonUI(btn_left.Text, btn_left);
            commonUI(btn_right.Text, btn_right);
            commonUI(btn_enter.Text, btn_enter);
            commonUI(btn_menu.Text, btn_menu);
            commonUI(btn_num9.Text, btn_num9);
            commonUI(btn_num8.Text, btn_num8);
            commonUI(btn_num7.Text, btn_num7);
            commonUI(btn_num6.Text, btn_num6);
            commonUI(btn_num5.Text, btn_num5);
            commonUI(btn_num4.Text, btn_num4);
            commonUI(btn_num3.Text, btn_num3);
            commonUI(btn_num2.Text, btn_num2);
            commonUI(btn_num1.Text, btn_num1);
            commonUI(btn_num0.Text, btn_num0);

            commonUI(btnAvmParaSet.Text, btnAvmParaSet);
            commonUI(btn_readPara.Text, btn_readPara);
            commonUI(btn_writePara.Text, btn_writePara);
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
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            main_UI_Disable();
        }
    }
}
