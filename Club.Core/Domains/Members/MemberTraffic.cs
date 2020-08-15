using System;
using Club.Core.Domains.Comman;

namespace Club.Core.Domains.Members
{
    /// <summary>
    /// فعالیتها
    /// </summary>
   public class MemberTraffic : BaseEntity
    {
        public virtual Member Member { get; set; }
        public virtual Guid? MemberId { get; set; }
        public virtual DateTime? CreateOn { get; set; }
        public virtual int? Time { get; set; }

    }
}
