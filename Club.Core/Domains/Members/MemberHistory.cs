using System;
using Club.Core.Domains.Comman;

namespace Club.Core.Domains.Members
{
    /// <summary>
    /// سوابق
    /// </summary>
    public class MemberHistory : BaseEntity
    {
        public virtual Member Member { get; set; }
        public virtual Guid? MemberId { get; set; }
    }
}
