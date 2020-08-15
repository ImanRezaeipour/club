using System.Collections.Generic;
using Club.Core.Domains.Comman;
using Club.Core.Domains.Members;
using Club.Core.Types;

namespace Club.Core.Domains.Exercises
{
    public class Exercise:BaseEntity
    {

        public virtual ICollection<MemberExercise> MemberExercises { get; set; }
        public virtual string TempExercise { get; set; }

        public virtual WeightType DietType { get; set; }
    }
}
