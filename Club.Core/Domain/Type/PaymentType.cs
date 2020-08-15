using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Club.Core.Domain.Type
{
    public enum PaymentType
    {
        [Description("نقد")]
        Cach =1,

        [Description("کارتخوان")]
        CardReader = 2
    }
}
