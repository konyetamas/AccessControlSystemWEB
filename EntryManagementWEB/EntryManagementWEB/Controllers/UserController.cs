using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntryManagementWEB.Model;
using EntryManagementWEB.DAL;

namespace EntryManagementWEB.Controllers
{
    public class UserController : ApiController
    {

        [HttpGet]
        public UserModel GetUserByID(int MemberId)
        {
            UserModel result = new UserModel();
            try
            {
                result = UserDAL.GetUserById(MemberId);
            }
            catch (Exception e)
            {

            }
            return result;
        }


        [HttpGet]
        public UserModel CheckUserAutenthication(string name, string password)
        {
            UserModel result = new UserModel();
            try
            {
                result = UserDAL.CheckUserAutenthication(name, password);
            }
            catch (Exception e)
            {

            }
            return result;
        }
    }
}
