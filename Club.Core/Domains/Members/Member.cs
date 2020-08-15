using System;
using System.Collections.Generic;
using Club.Core.Domains.Comman;

namespace Club.Core.Domains.Members
{
   
   public class Member :BasePerson
    {
        public virtual ICollection<MemberPaymet> MemberPaymets { get; set; }
        public virtual ICollection<MemberCloset> MemberClosets { get; set; }
        public virtual ICollection<MemberExercise> MemberExercises { get; set; }
        public virtual ICollection<MemberSchadule> MemberSchadules { get; set; }
        public virtual ICollection<MemberDiet> MemberDiets { get; set; }
        public virtual ICollection<MemberTraffic> MemberTraffics { get; set; }
        public virtual ICollection<MemberHistory> MemberHistories { get; set; }
       
    }
}
