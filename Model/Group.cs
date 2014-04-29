using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuminousAcuity.Meetup.Model
{
    public class Group
    {
        //TO DO
        ////decide if I need these private fields

        #region fields

        private int _id;
        private double _group_lat;
        private string _name;
        private double _group_lon;
        private string _join_mode;
        private string _urlname;
        private string _who;

        #endregion

        #region properties

        public int ID { get; set; }
        //public double Group_lat { get; set; }
        public string Name { get; set; }
        //public double Group_lon { get; set; }
        public string Join_mode { get; set; }
        public string Urlname { get; set; }
        public string Who { get; set; }

        public double Lon { get; set; }
        public string Visibility { get; set; }
        public Organizer Organizer { get; set; }
        public string Link { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public Category Category { get; set; }
        public List<Topic> Topics { get; set; }
        public string Timezone { get; set; }
        public long Created { get; set; }
        public string Description { get; set; }
        
        public int Rating { get; set; }
      
        public double Lat { get; set; }
        public int Members { get; set; }

        #endregion


    }
}
