using Demo.Business;
using Demo.Common.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Api
{
    [Route("api/Projects")]
    public class ProjectController : Controller
    {
        private readonly IProjectBusiness projectBusiness;

        public ProjectController(IProjectBusiness projectBusiness)
        {
            this.projectBusiness = projectBusiness;
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProjectBo project)
        {
           projectBusiness.Add(project);
            return Ok();
        }
        [HttpGet]
        public ActionResult GetAll()
        {
           List<ProjectBo> projectBos= projectBusiness.GetAll();
           return Ok(projectBos);
        }
    }
}
