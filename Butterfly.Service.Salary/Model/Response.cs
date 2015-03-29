using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Butterfly.Service.Salary.Model
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public int ResultCode { get; set; }
        [DataMember]
        public string ResultMessage { get; set; }

        public void ResultOK()
        {
            this.ResultCode = 0;
            this.ResultMessage = Response.OK;
        }
        public void ResultFault()
        {
            this.ResultCode = 1;
            this.ResultMessage = Response.Fault;
        }
        public const string OK = "OK";
        public const string Fault = "Fault";
    }
}