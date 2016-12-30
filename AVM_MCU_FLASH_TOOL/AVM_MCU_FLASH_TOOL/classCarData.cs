using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVM_MCU_FLASH_TOOL
{
    public class classCarData
    {
        private float fVolt;
        private float fVoltBase;
        private float fVoltMult;
        private float fVoltRefPwr;//delay shot down
        private float fVoltRefSlp;//save power	

        private UInt32 u32CarSpeed;
        private UInt32 u32CarPluse;
        private UInt32 u32CarVar;
        private UInt32 u32CarRefSpeed;//Off System use speed
        
        private byte u8TurnLightMod;

        public float fvolt
        {
            set { fVolt = value; }
            get { return fVolt; }
        }

        public float fvoltBase
        {
            set { fVoltBase = value; }
            get { return fVoltBase; }
        }

        public float fvoltMult
        {
            set { fVoltMult = value; }
            get { return fVoltMult; }
        }

        public float fvoltRefPwr
        {
            set { fVoltRefPwr = value; }
            get { return fVoltRefPwr; }
        }

        public float fvoltRefSlp
        {
            set { fVoltRefSlp = value; }
            get { return fVoltRefSlp; }
        }

        public UInt32 u32carSpeed
        {
            set { u32CarSpeed = value; }
            get { return u32CarSpeed; }
        }

        public UInt32 u32carPluse
        {
            set { u32CarPluse = value; }
            get { return u32CarPluse; }
        }

        public UInt32 u32carVar
        {
            set { u32CarVar = value; }
            get { return u32CarVar; }
        }

        public UInt32 u32carRefSpeed
        {
            set { u32CarRefSpeed = value; }
            get { return u32CarRefSpeed; }
        }

        public byte u8turnLightMod
        {
            set { u8TurnLightMod = value; }
            get { return u8TurnLightMod; }
        }
    }
}
