using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertReadApi.Shared
{
    public interface IAddress
    {
        string Address1 { get; set; }
        string Address2 { get; set; }
        string City { get; set; }
        string Province { get; set; }
        string Zip { get; set; }
    }
}
