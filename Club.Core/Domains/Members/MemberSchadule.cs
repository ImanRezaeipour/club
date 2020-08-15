using System;
using System.Collections.Generic;
using Club.Core.Domains.Comman;
using Club.Core.Domains.Sanses;

namespace Club.Core.Domains.Members
{
    public class MemberSchadule : BaseEntity
    {
        #region Public Properties

        public virtual ICollection<Sans> Sanses { get; set; }
        public virtual DateTime? StartDay { get; set; }
        public virtual DateTime? EndDay { get; set; }
        public virtual Member Member { get; set; }
        public virtual Guid? MemberId { get; set; }

        #endregion Public Properties
    }
}