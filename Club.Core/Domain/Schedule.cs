using System;
using System.Collections;
using System.Collections.Generic;

namespace Club.Core.Domain
{
    public class Schedule : BaseEntity
    {
        #region Public Properties

        public virtual Salary Salary { get; set; }
        public virtual Guid SalaryId { get; set; }
        public virtual ICollection<ScheduleSpecification> Specifications { get; set; }
        public virtual DateTime StartDay { get; set; }
        public virtual DateTime EndDay { get; set; }

        #endregion Public Properties
    }
}