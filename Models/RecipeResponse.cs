using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Api.Models
{
    [DataContract]
    public class RecipeResponse {
        [DataMember]
        public int count { get; set; }
        
        [DataMember]
        public Recipe[] recipes { get; set; }
    }
}