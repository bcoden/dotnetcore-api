using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Api.Models
{
    [DataContract]
    public class YearFact {
        [DataMember(Name = "date")]
        public string MonthDay { get; set; }
        
        [DataMember(Name = "text")]
        public string Fact { get; set; }
        
        [DataMember(Name = "number")]
        public int Year { get; set; }
        
        [DataMember(Name = "found")]
        public bool HasResult { get; set; }
        
        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}