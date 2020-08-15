using System.Collections.Generic;
using Club.Core.Domains.Comman;
using Club.Core.Domains.Members;
using Club.Core.Types;

namespace Club.Core.Domains.Diets
{
    public class Diet:BaseEntity
    {
        public virtual ICollection<MemberDiet> MemberDiets { get; set; }
        public virtual string TempDiet { get; set; }

        public virtual WeightType DietType { get; set; }

    }
}
