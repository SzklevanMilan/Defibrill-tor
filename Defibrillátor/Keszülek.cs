using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defibrillátor
{
    class Keszülek
    {
        private int id;

        public int Id
        {
            get { return id; }
        }

        private string name;

        public string Name
        {
            get { return name; }
        }
        private int latitude;

        public int Latitude
        {
            get { return latitude; }
        }
        private int longitude;

        public int Longitude
        {
            get { return longitude; }
        }
        private int tel;

        public int Tel
        {
            get { return tel; }
        }
        private int address;

        public int Address
        {
            get { return address; }
        }

        public Keszülek(int id, string name, int latitude, int longitude, int tel, int address)
        {
            this.id = id;
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
            this.tel = tel;
            this.address = address;
        }
    }
}
