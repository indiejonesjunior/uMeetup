using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuminousAcuity.Meetup.Model
{
    public class Event
    {
        //TO DO
        //decide if I need these private fields

        #region fields

        private int _id;

        private int _rsvp_limit;
        private string _status;
        private string _visibility;
        private int _maybe_rsvp_count;

        private int _utc_offset;
        private int _duration;
        private long _waitlist_count;
        private bool _announced;
        private long _updated;
        private int _yes_rsvp_count;
        private long _created;
        private string _event_url;
        private string _description;
        private string _name;
        private int _headcount;
        private string how_to_find_us;
        private Venue _venue;
        private Group _group;
        private Fee _fee;


        #endregion

        #region properties
        
        //ID as string because MeetUp allows strings in fields
        public string ID { get; set; }

        public int Rsvp_Limit { get; set; }
        public string Status { get; set; }
        public string Visibility { get; set; }
        public int Maybe_Rsvp_Count { get; set; }
        
        public int Utc_Offset { get; set; }
        public int Duration { get; set; }
        public long Time { get; set; }
        public int Waitlist_Count { get; set; }
        public bool Announced { get; set; }
        public long Updated { get; set; }
        public int Yes_Rsvp_Count { get; set; }
        public long Created { get; set; }
        public string Event_Url { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Headcount { get; set; }

        public double Distance { get; set; }
        public string How_To_Find_Us { get; set; }

        public Venue Venue { get; set; }
        public Group Group { get; set; }
        public Fee Fee { get; set; }

        #endregion

    }
}