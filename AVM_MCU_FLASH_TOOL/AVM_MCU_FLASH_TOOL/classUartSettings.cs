using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace AVM_MCU_FLASH_TOOL
{
    public class classUartSettings
    {
        private string portName;
        private int portBaudRate;
        private int portDataBits;
        private StopBits portStopBits;
        private Parity portParity;

        public string getPortName()
        {
            return portName;
        }

        public int getBaudRate()
        {
            return portBaudRate;
        }

        public int getDataBits()
        {
            return portDataBits;
        }

        public StopBits getStopBits()
        {
            return portStopBits;
        }

        public Parity getParity()
        {
            return portParity;
        }

        public void SetPortName(string str)
        {
            portName = str;
        }

        public void setBaudRate(int num)
        {
            portBaudRate = num;
        }

        public void setDataBits(int num)
        {
            portDataBits = num;
        }

        public void setStopBits(StopBits tmp)
        {
            portStopBits = tmp;
        }

        public void setParity(Parity tmp)
        {
            portParity = tmp;
        }
    }
}
