using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Club.Core.Domains.Coachs;
using Club.Core.Model;

namespace Club.Core.Profile
{
    public class CoachProfile :AutoMapper.Profile
    {
        public CoachProfile()
        {
            CreateMap<Coach, CoachViewModel>(MemberList.None).ReverseMap();
        }

        
    }
}
