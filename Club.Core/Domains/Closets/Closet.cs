using System.Collections;
using System.Collections.Generic;
using Club.Core.Domains.Comman;
using Club.Core.Domains.Members;

namespace Club.Core.Domains.Closets
{
    public class Closet :BaseEntity
    {
        public virtual string Code { get; set; }
        public virtual bool IsReserved { get; set; }
        public virtual ICollection<MemberCloset> MemberClosets { get; set; }
    }
}
