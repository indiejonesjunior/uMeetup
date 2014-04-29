using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuminousAcuity.Meetup.Model
{
    public class Venue
    {
        //TO DO
        //decide if I need these private fields

        #region fields
        private int _id;

        private double _lon;
        private bool _repinned;
        private string _name;
        private string _address_1;
        private double _lat;
        private string _country;
        private string _city;
        private string _address2;
        private string _phone;

        #endregion


        #region properties

        public int ID { get; set; }


        public double Lon { get; set; }
        public bool Repinned { get; set; }
        public string Name { get; set; }
        public string Address_1 { get; set; }
        public double Lat { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address_2 { get; set; }
        public string Phone { get; set; }

        #endregion

    }
}
