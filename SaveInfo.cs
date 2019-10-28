using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SaveInfo.Models;
using System.Data.Entity;
using System.Net.Http.Formatting;
using System.Web.Http.Cors;

namespace SaveInfo.Controllers
{
    public class SaveInfoController : ApiController
    {
        //PUT api/values/5 IHttpActionResult

        public IHttpActionResult Put(dynamic obj)
        {
            string srl;
            string SQL =  obj.SQL;
            string DBName = obj.DB;
            string AGT = obj.AGT;       // true or false
            string AID = obj.AID;
            string Street = obj.ADDR;
            string City = obj.City;
            string State = obj.State;
            string Zip = obj.ZIP;
            string Phone = obj.Phone;
            string Email = obj.Email;

            int AgentRID;
      
            try
            {
                //Step1: Connect to SQL database
                DBContext db = new DBContext(Common.getDBConnString(DBName, SQL));

                if (int.TryParse(AID, out AgentRID))
                {
                    //
                    // Update the new contact info. for agent
                    //
                    Agent agt = db.Agent.Find(AgentRID);
                    if (agt == null)
                    { srl = "Fail"; }
                    else
                    {
                        if (agt.MailToHome)
                        {
                            agt.HomeStreet = Street;
                            agt.HomeCity = City;
                            agt.HomeState = State;
                            agt.HomeZipCode = Zip;
                            agt.HomePhone = Phone;   
                            agt.HomeEMail = Email;

                            if (agt.BusinessEMail == null)
                            { agt.BusinessEMail = Email; }
                            if (agt.BusinessEMail.Trim().Length == 0)
                            { agt.BusinessEMail = Email; }
                        }
                        else
                        {
                            agt.BusinessStreet = Street;
                            agt.BusinessCity = City;
                            agt.BusinessState = State;
                            agt.BusinessZipCode = Zip;
                            agt.BusinessPhone = Phone;
                            agt.BusinessEMail = Email;
                        }

                        db.Entry(agt).State = EntityState.Modified;
                        db.SaveChanges();
                        srl = "Ok";
                    }
                }
                else
                {         
                    srl = "Fail";
                }
            }
            catch (Exception ex)
            { srl = "Fail"; }

            
            return Json<dynamic>(new { Status = srl });

        }

    }
}
