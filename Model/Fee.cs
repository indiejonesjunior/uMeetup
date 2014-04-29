using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuminousAcuity.Meetup.Model
{
    public class Fee
    {

        public int Amount { get; set; }
        public string Description { get; set; }
        public string Label { get; set; }
        public string Required { get; set; }
        public string Accepts { get; set; }
        public string Currency { get; set; }
    }
}
