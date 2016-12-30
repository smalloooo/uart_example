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
    public partial class FormUartSettings : Form
    {
        classUartSettings equipUartSettings = new classUartSettings();

        public FormUartSettings()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            equipUartSettings.setBaudRate(9600);
            equipUartSettings.setDataBits(8);
            equipUartSettings.SetPortName("COM2");
            equipUartSettings.setStopBits(StopBits.One);
            equipUartSettings.setParity(Parity.None);

            parseUart(equipUartSettings);
        }

        private void parseUart(classUartSettings portSettings)
        {
            string portName = portSettings.getPortName();
            int portBaudRate = portSettings.getBaudRate();
            int portDataBits = portSettings.getDataBits();
            StopBits portStopBits = portSettings.getStopBits();
            Parity portParity = portSettings.getParity();

            if (portBaudRate == 0)
                return;

            CBX_Port.SelectedIndex = int.Parse(portName.Substring(3)) - 1;

            switch (portDataBits)
            {
                case 8:
                    CBX_DataBit.SelectedIndex = 0;
                    break;
                case 7:
                    CBX_DataBit.SelectedIndex = 1;
                    break;
                case 6:
                    CBX_DataBit.SelectedIndex = 2;
                    break;
            }

            switch (portStopBits)
            {
                case (StopBits)0:
                    CBX_StopBit.SelectedIndex = 0;
                    break;
                case (StopBits)1:
                    CBX_StopBit.SelectedIndex = 1;
                    break;
                case (StopBits)2:
                    CBX_StopBit.SelectedIndex = 2;
                    break;
                case (StopBits)3:
                    CBX_StopBit.SelectedIndex = 3;
                    break;
            }

            switch (portParity)
            {
                case (Parity)0:
                    CBX_Check.SelectedIndex = 0;
                    break;
                case (Parity)1:
                    CBX_Check.SelectedIndex = 1;
                    break;
                case (Parity)2:
                    CBX_Check.SelectedIndex = 2;
                    break;
                case (Parity)3:
                    CBX_Check.SelectedIndex = 3;
                    break;
                case (Parity)4:
                    CBX_Check.SelectedIndex = 4;
                    break;
            }

            switch (portBaudRate)
            {
                case 256000:
                    CBX_Rate.SelectedIndex = 0;
                    break;
                case 128000:
                    CBX_Rate.SelectedIndex = 1;
                    break;
                case 115200:
                    CBX_Rate.SelectedIndex = 2;
                    break;
                case 19200:
                    CBX_Rate.SelectedIndex = 3;
                    break;
                case 9600:
                    CBX_Rate.SelectedIndex = 4;
                    break;
                case 4800:
                    CBX_Rate.SelectedIndex = 5;
                    break;
            }

            return;
        }

        private void updateUartClass(ref classUartSettings uartSettings)
        {
            uartSettings.setBaudRate(Int32.Parse(CBX_Rate.SelectedItem.ToString()));
            uartSettings.setDataBits(Int32.Parse(CBX_DataBit.SelectedItem.ToString()));
            uartSettings.SetPortName(CBX_Port.GetItemText(CBX_Port.SelectedItem));

            switch (CBX_StopBit.GetItemText(CBX_StopBit.SelectedItem))
            {
                case "1":
                    uartSettings.setStopBits(StopBits.One);
                    break;
                case "1.5":
                    uartSettings.setStopBits(StopBits.OnePointFive);
                    break;
                case "2":
                    uartSettings.setStopBits(StopBits.Two);
                    break;
            }

            switch (CBX_Check.GetItemText(CBX_Check.SelectedItem))
            {
                case "NONE":
                    uartSettings.setParity(Parity.None);
                    break;
                case "EVEN":
                    uartSettings.setParity(Parity.Even);
                    break;
                case "MARK":
                    uartSettings.setParity(Parity.Mark);
                    break;
                case "ODD":
                    uartSettings.setParity(Parity.Odd);
                    break;
                case "SPACE":
                    uartSettings.setParity(Parity.Space);
                    break;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            updateUartClass(ref equipUartSettings);
            this.DialogResult = DialogResult.OK;
        }

        public classUartSettings backEquiSettings()
        {
            return this.equipUartSettings;
        }
    }
}
