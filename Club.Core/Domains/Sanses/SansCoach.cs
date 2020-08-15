using System;
using Club.Core.Domains.Coachs;
using Club.Core.Domains.Comman;

namespace Club.Core.Domains.Sanses
{
   public class SansCoach :BaseEntity
    {
        public virtual Sans Sans { get; set; }
        public virtual Guid? SansId { get; set; }

        public virtual Coach Coach { get; set; }
        public virtual Guid? CoachId { get; set; }
    }
}
