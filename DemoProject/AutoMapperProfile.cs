using AutoMapper;
using Demo.Common;
using Demo.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProjectBo, Project>().ReverseMap();
            CreateMap<ContactBo, Contact>().ReverseMap();
        }
    }
}
