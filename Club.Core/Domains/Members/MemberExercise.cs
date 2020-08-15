using System;
using Club.Core.Domains.Comman;

namespace Club.Core.Domains.Members
{
    /// <summary>
    /// برنامه تمرین
    /// </summary>
    public class MemberExercise :BaseEntity
    {
        public virtual Member Member { get; set; }
        public virtual Guid? MemberId { get; set; }
    }
}
