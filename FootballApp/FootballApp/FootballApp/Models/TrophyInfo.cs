using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballApp.Models
{   
        public class TrophyInfo
        {
            public Api api { get; set; }
        }
        public class Trophy
        {
            public string league { get; set; }
            public string country { get; set; }
            public string season { get; set; }
            public string place { get; set; }
        }

        public class Api
        {
            public int results { get; set; }
            public List<Trophy> trophies { get; set; }
        }
}
