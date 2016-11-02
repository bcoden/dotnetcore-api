using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Api.Models
{
    [DataContract]
    public class RootDataSet {
        [DataMember(Name = "Dataset")]
        public Dictionary<DateTime, DataSet> Stats { get; set; }
    }
}