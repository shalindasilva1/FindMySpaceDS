using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertReadApi.Shared
{
    public class FullAuditedEntity
    {
        public long Id { get; set; }
        public long CreaterUserId { get; set; }
        public long DeleterUserId { get; set; }
        public long UpdaterUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime DeletionTime { get; set; }
        public DateTime UpdationTime { get; set; }
    }
}
