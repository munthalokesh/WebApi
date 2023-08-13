using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models.DataLayer
{
    public class LoginDbOperations
    {
        public Login GetUser(string email)
        {
            AirportManagementEntities entities = new AirportManagementEntities();
            return entities.Login.FirstOrDefault(x => x.Email == email);
        }
    }
}