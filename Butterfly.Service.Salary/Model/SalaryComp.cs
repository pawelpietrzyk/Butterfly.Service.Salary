using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Butterfly.Service.Salary.Model
{
    [DataContract]
    public class SalaryComp
    {
        [DataMember]
        public string CompId { get; set; }
        [DataMember]
        public string CompName { get; set; }
        [DataMember]
        public int CompType { get; set; }
        [DataMember]
        public string CompDescription { get; set; }
        [DataMember]
        public decimal CompValue { get; set; }
    }
}