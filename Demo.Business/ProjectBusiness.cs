using AutoMapper;
using Demo.Common;
using Demo.Common.Models;
using Demo.Data.DbManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Business
{
    public class ProjectBusiness:IProjectBusiness
    {
        private readonly DemoCotext _context;
        private readonly IMapper _mapper;

        public ProjectBusiness(DemoCotext context, IMapper mapper)
        {
           _context = context;
            _mapper = mapper;
        }


        public int Add(ProjectBo projectBo)
        {
            var project = _mapper.Map<Project>(projectBo);
            _context.Project.Add(project);
            return _context.SaveChanges();
         
          
        }

        public List<ProjectBo> GetAll()
        {
            var projects = _context.Project.ToList();
            var projectBos= _mapper.Map<List<ProjectBo>>(projects);

            return projectBos;
        }
    }
}
