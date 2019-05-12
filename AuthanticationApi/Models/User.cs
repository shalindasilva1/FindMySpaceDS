using AuthanticationApi.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthanticationApi.Models
{
    public class User : FullAuditedEntity, IAddress
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public DateTime BDate { get; set; }
        #region Address
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }
        #endregion
    }
}
