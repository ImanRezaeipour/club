using System;
using Club.Core.Domain.Type;
using Club.Core.Types;

namespace Club.Core.Domains.Comman
{
    public class BasePerson :BaseEntity
    {
        public virtual string Code { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string NationalCode { get; set; }
        public virtual string Picture { get; set; }
        public virtual DateTime? BirthDay { get; set; }
        public virtual BloobType? BloobType { get; set; }
        public virtual DateTime? CreateOn { get; set; }
        public virtual string Address { get; set; }
        public virtual string FatherName { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string Email { get; set; }
        public virtual string Job { get; set; }
        public virtual StatusType? StatusType { get; set; }

        
    }
}
