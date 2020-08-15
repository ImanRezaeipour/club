using System.Collections;
using System.Collections.Generic;
using Club.Core.Domains.Comman;
using Club.Core.Domains.Sanses;

namespace Club.Core.Domains.Coachs
{
   public class Coach :BasePerson
    {
        public virtual ICollection<SansCoach> SansCoaches { get; set; }

    }
}
