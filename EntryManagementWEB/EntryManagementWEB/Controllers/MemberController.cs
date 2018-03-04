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
    public class MemberController : ApiController
    {

        [HttpGet]
        public MemberModel GetMemberById(int MemberId)
        {
            MemberModel result = new MemberModel();
            try
            {
                result = MemberDAL.GetMemberById(MemberId);
            }
            catch (Exception e)
            {

            }
            return result;
        }

        [HttpGet]
        public List<MemberModel> GetMembersByCompany(int CompanyId)
        {
            List<MemberModel> result = new List<MemberModel>();
            try
            {
                result = MemberDAL.GetMembersByCompanyId(CompanyId);
            }
            catch (Exception e)
            {

            }
            return result;
        }


        //[HttpPost]
        //public Action AddNewMember(MemberModel member)
        //{
           
        //    try
        //    {
        //        result = MemberDAL.GetMemberById(MemberId);
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    return result;
        //}
    }
}
