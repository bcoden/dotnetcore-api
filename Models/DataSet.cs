using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Api.Models
{
    [DataContract]
    public class DataSet {
        [DataMember(Name="OPEN")]
        public double Open { get; set; }
        
        [DataMember(Name="HIGH")]
        public double High { get; set; }
        
        [DataMember(Name="LOW")]
        public double Low { get; set; }

        [DataMember(Name="CLOSE")]
        public double Close { get; set; }

        [DataMember(Name="VOLUME")]
        public long Volume { get; set; }
    }

}