using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Api.Models
{
    [DataContract]
    public class Recipe {
        [DataMember]
        public string publisher { get; set; }
        
        [DataMember]
        public string f2f_url { get; set; }
        
        [DataMember]
        public string title { get; set; }

        [DataMember]
        public string source_url { get; set; }
        
        [DataMember]
        public string recipe_id { get; set; }
        
        [DataMember]
        public string image_url { get; set; }
        
        [DataMember]
        public double social_rank { get; set; }
    
        [DataMember]
        public string publisher_url { get; set; }
    }
}