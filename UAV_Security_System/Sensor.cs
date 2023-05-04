using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAV_Security_System
{
    internal class Sensor
    {
        string name;
        int num;
        long lat;
        long lon;
        bool isSleeping;
        float vol;
        byte batteryFlag;
        byte connectionFlag;

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

        public string getString()
        {
            return name + "; " + num + "; " + lat + "; " + lon + "; " + isSleeping + "; " + vol + "; " + batteryFlag + "; " + connectionFlag + ".";
        }
    }
}
