using ImageApi.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageApi.Models
{
    public class Image : FullAuditedEntity
    {
        public long PropertyId { get; set; }
        public string ImgPath { get; set; }

    }
}
