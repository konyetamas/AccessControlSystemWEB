using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntryManagementWEB.DB;
using EntryManagementWEB.Model;
using EntryManagementWEB.DAL;

namespace EntryManagementWEB.Controllers
{
    public class CompanyController : ApiController
    {
        [HttpGet]
        public List<CompanyModel> GetCompanies()
        {
            List<CompanyModel> result = new List<CompanyModel>();
            try
            {
                result = CompanyDAL.GetCompanies();
            }
            catch(Exception e)
            {

            }
            return result;
        }

    }
}
