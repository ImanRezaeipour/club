using System;
using Club.Core.Domains.Comman;
using Club.Core.Domains.Diets;

namespace Club.Core.Domains.Members
{
    /// <summary>
    /// برنامه غذایی
    /// </summary>
    public class MemberDiet : BaseEntity
    {
        public virtual Member Member { get; set; }
        public virtual Guid? MemberId { get; set; }

        public virtual Diet Diet { get; set; }
        public virtual Guid? DietId { get; set; }
    }
}
