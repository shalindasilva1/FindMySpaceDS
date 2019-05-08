using PropertReadApi.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertReadApi.Models
{
    public class Property : FullAuditedEntity, IAddress
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }
        #region Address
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }
        #endregion
    }
}
