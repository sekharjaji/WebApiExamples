using System;
using System.Runtime.Serialization;

namespace BasicWebApiFormatters.Models
{
    [DataContract(Namespace = "")]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}