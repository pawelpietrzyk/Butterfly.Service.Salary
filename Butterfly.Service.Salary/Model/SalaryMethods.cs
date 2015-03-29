using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Butterfly.Service.Salary.Model
{
    public class SalaryMethods
    {
        public static Response AddSalaryComponentDef(SalaryCompDef compDef)
        {
            Response response = new Response();
            response.ResultFault();
            using (DataEntities context = new DataEntities())
            {
                SalaryComponentDef def = new SalaryComponentDef();
                def.CompId = compDef.CompId;
                def.CompName = compDef.CompName;
                def.CompDesc = compDef.CompDesc;
                def.CompType = (int)compDef.CompType;
                def.CompCalcValue = compDef.CompCalcValue;
                def.CompCalcMethod = (int)compDef.CompCalcMethod;

                context.SalaryComponentDef.Add(def);
                context.SaveChanges();
                response.ResultOK();
            }
            return response;
        }
        public static Response AddSalaryComponent(SalaryComp comp)
        {
            Response response = new Response();
            response.ResultFault();
            using (DataEntities context = new DataEntities())
            {
                SalaryComponents compEntity = new SalaryComponents();
                compEntity.CompId = comp.CompId;
                compEntity.CompName = comp.CompName;
                compEntity.CompType = comp.CompType;
                compEntity.CompValue = comp.CompValue;
                context.SalaryComponents.Add(compEntity);
                context.SaveChanges();
                response.ResultOK();
            }
            return response;
        }
    }
}