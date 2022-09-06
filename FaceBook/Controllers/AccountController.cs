using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;
using maghriby.Helpers;
using facebook.Models;

namespace facebook.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        [Route("account")]
        public async Task<string> Login([FromForm] string Email, [FromForm] string Password)
         {
            User user = new User();
            user.Email = Email;
            user.Password = Password;
            DAL d = new DAL();
            string query = "INSERT INTO Users (Email, Password) VALUES ('{0}','{1}')";
            await d.insertdataasync(string.Format(query, Email, Password));
            

            return "success";
        }
    }
}