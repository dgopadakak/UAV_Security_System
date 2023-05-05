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

        public string getString()
        {
            return name + "; " + num + "; " + lat + "; " + lon + "; " + isSleeping + "; " + vol + "; " + batteryFlag + "; " + connectionFlag + ".";
        }
    }
}
