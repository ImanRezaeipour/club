using System;
using System.Collections;
using System.Collections.Generic;
using Club.Core.Domain.Type;

namespace Club.Core.Domain
{
   
   public class Person :BaseEntity
    {
        public virtual string Code { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string NationalCode { get; set; }
        public virtual string Picture { get; set; }
        public virtual DateTime BirthDay { get; set; }
        public virtual BloobType BloobType { get; set; }
        public virtual DateTime CreateOn { get; set; }

        public virtual ICollection<Salary> Salaries { get; set; }
       
    }
}
