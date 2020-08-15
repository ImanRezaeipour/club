using System;
using Club.Core.Domains.Closets;
using Club.Core.Domains.Comman;

namespace Club.Core.Domains.Members
{
    public class MemberCloset : BaseEntity
    {
        public virtual Member Member { get; set; }
        public virtual Guid? MemberId { get; set; }
        public virtual Closet Closet { get; set; }
        public virtual Guid? ClosetId { get; set; }
    }
}