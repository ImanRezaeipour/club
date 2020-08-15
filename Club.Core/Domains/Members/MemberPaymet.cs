using System;
using System.Collections.Generic;
using Club.Core.Domain.Type;
using Club.Core.Domains.Comman;

namespace Club.Core.Domains.Members
{
    
    public class MemberPaymet : BaseEntity
    {
        public virtual PaymentType PaymentType { get; set; }
        public virtual decimal ReceivedMoney { get; set; }
        public virtual DateTime CreateOn { get; set; }
        public virtual Member Member { get; set; }
        public virtual Guid? MemberId { get; set; }
        public virtual ICollection<MemberSchadule>  Schedules { get; set; }


    }
}
