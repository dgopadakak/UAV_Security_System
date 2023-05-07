using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV_Security_System
{
    internal class Sensor
    {
        private string name;
        private int num;
        private long lat;
        private long lon;
        private bool isSleeping;
        private float vol;
        private byte batteryFlag;
        private byte connectionFlag;

        public Sensor(string name, int num, long lat, long lon, bool isSleeping, float vol, byte batteryFlag, byte connectionFlag)
        {
            this.name = name;
            this.num = num;
            this.lat = lat;
            this.lon = lon;
            this.isSleeping = isSleeping;
            this.vol = vol;
            this.batteryFlag = batteryFlag;
            this.connectionFlag = connectionFlag;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

        public void setNum(int num)
        {
            this.num = num;
        }
        public int getNum()
        {
            return this.num;
        }

        public void setLat(long lat)
        {
            this.lat = lat;
        }
        public long getLat()
        {
            return lat;
        }

        public void setLon(long lon)
        {
            this.lon = lon;
        }
        public long getLon()
        {
            return lon;
        }

        public void setIsSleeping(bool isSleeping)
        {
            this.isSleeping = isSleeping;
        }
        public bool getIsSleeping()
        {
            return isSleeping;
        }

        public void setVol(float vol)
        {
            this.vol = vol;
        }
        public float getVol()
        {
            return vol;
        }

        public void setBatteryFlag(byte batteryFlag)
        {
            this.batteryFlag = batteryFlag;
        }
        public byte getBatteryFlag()
        {
            return batteryFlag;
        }

        public void setConnectionFlag(byte connectionFlag)
        {
            this.connectionFlag = connectionFlag;
        }
        public byte getConnectionFlag()
        {
            return connectionFlag;
        }

        public string getStringForAdd()
        {
            string sleep = "false";
            if (isSleeping)
            {
                sleep = "true";
            }
            string vol_str = vol.ToString();
            vol_str = vol_str.Replace(",", ".");
            return "\"name\":\"" + name + "\",\"num\":" + num + ",\"lat\":" + lat + ",\"lon\":" + lon + ",\"isSleeping\":" + sleep + ",\"vol\":" + vol_str + "";
        }

        public string[] getDataForDataGrid()
        {
            string batteryFlagString = "";
            string connectionFlagString = "";
            if (batteryFlag == 0)
            {
                batteryFlagString = "Высокий заряд";
            }
            else if (batteryFlag == 1)
            {
                batteryFlagString = "Низкий заряд";
            }
            else
            {
                batteryFlagString = "Критический заряд";
            }
            if (connectionFlag == 0)
            {
                connectionFlagString = "Хорошая связь";
            }
            else if (connectionFlag == 1)
            {
                connectionFlagString = "Проблемная связь";
            }
            else
            {
                connectionFlagString = "Связь потеряна";
            }
            string[] dataForReturn = {num.ToString(), name, isSleeping.ToString(), (lat / 10000000f).ToString(), (lon / 10000000f).ToString(), vol.ToString(), batteryFlagString, connectionFlagString};
            return dataForReturn;
        }

        public Color GetColorForBatteryFlag()
        {
            if (batteryFlag == 0)
            {
                return Color.Green;
            }
            if (batteryFlag == 1)
            {
                return Color.Yellow;
            }
            return Color.Red;
        }

        public Color GetColorForConnectionFlag()
        {
            if(connectionFlag == 0)
            {
                return Color.Green;
            }
            if (connectionFlag == 1)
            {
                return Color.Yellow;
            }
            return Color.Red;
        }
    }
}
