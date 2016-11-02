using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Api.Models
{
    [DataContract]
    public class Information {
        [DataMember(Name = "Symbol")]
        public string Symbol { get; set; }
        
        [DataMember(Name="Exchange")]
        public string Exchange { get; set; }
        
        [DataMember(Name="Oldest_date_available")]
        public DateTime OldestDate { get; set; }
       
        [DataMember(Name="Newest_date_available")]
        public DateTime NewestDate { get; set; }
        
        [DataMember(Name="Refreshed_at")]
        public DateTime RefreshedAt { get; set; }
    }
}