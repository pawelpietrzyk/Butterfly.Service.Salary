using Butterfly.Service.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Butterfly.Service.Salary.Model
{
    public class SalaryRestDispatcher : RestDispatcher
    {

        public override void GET(HttpContext context)
        {
            SalaryCompDef def = new SalaryCompDef();
            def.CompId = "101";
            def.CompName = "101 name";
            def.CompType = SalaryCompType.Calculated;
            def.CompCalcMethod = SalaryCompCalcMethod.Deductions;
            context.Response.Status = "200 OK";
            context.Response.StatusCode = 200;
            Serializer.Serialize(def, context.Response.OutputStream);
            
            
        }

        public override void POST(HttpContext context)
        {
            SalaryCompDef def = Serializer.Deserialize(context.Request.InputStream, typeof(SalaryCompDef)) as SalaryCompDef;
            if (def != null)
            {
                context.Response.StatusCode = 200;
                context.Response.Status = "200 OK";
            }
        }
        public void AddSalaryCompDef(string json)
        {
            SalaryCompDef compDef = Serializer.Deserialize(json, typeof(SalaryCompDef)) as SalaryCompDef;
            if (compDef != null)
            {
                
            }
        }
        public override void DispatchRestMethod(RestMethod method)
        {
            if (method != null)
            {
                
            }
        }
    }
}