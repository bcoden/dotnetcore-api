using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Api.Models
{
    [DataContract]
    public class Query {
        [DataMember(Name = "Symbol")]
        public string Symbol { get; set; }
        
        [DataMember(Name = "Exchange")]
        public string Exchange { get; set; }
        
        [DataMember(Name = "Indicator")]
        public string Indicator { get; set; }
        
        [DataMember(Name = "Start_date")]
        public DateTime StartDate { get; set; }
        
        [DataMember(Name = "End_date")]
        public DateTime EndDate { get; set; }
    }
}