using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Butterfly.Service.Salary.Model
{
    [DataContract]
    public class SalaryCompDef
    {
        [DataMember]
        public string CompId { get; set; }
        [DataMember]
        public string CompName { get; set; }
        [DataMember]
        public SalaryCompType CompType { get; set; }
        [DataMember]
        public string CompDesc { get; set; }
        [DataMember]
        public decimal CompCalcValue { get; set; }
        [DataMember]
        public SalaryCompCalcMethod CompCalcMethod { get; set; }
    }
}