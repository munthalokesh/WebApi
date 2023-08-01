using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi.Models.DataLayer
{
    public class AddressDbOperations
    {
        public  static int GetLastAddressId()
        {
            AirportManagementEntities AE= new AirportManagementEntities();
            var id= AE.Addresses.OrderByDescending(item => item.Id) .Take(1).FirstOrDefault();
            if (id == null)
            {
                return 101;
            }
            else
            {
                int? no=id.Id;
                no = no + 1;
                return (int) no;
            }
        }
    }
}