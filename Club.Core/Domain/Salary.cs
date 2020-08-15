using System;
using System.Collections;
using System.Collections.Generic;
using Club.Core.Domain.Type;

namespace Club.Core.Domain
{
    
    public class Salary :BaseEntity
    {
        public virtual PaymentType PaymentType { get; set; }
        public virtual decimal ReceivedMoney { get; set; }
        public virtual DateTime CreateOn { get; set; }
        public virtual Guid PersonId { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Schedule>  Schedules { get; set; }


    }
}
