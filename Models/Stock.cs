using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Api.Models
{
    [DataContract]
    public class Stock {
        [DataMember]
        public Query Query { get; set; }
        
        [DataMember]
        public Information Information { get; set; }
        
        [DataMember]
        public RootDataSet Dataset { get; set; }
    }
}