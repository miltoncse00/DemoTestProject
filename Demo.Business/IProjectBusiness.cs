using System.Collections.Generic;
using Demo.Common.Models;

namespace Demo.Business
{
    public interface IProjectBusiness
    {
        int Add(ProjectBo projectBo);
        List<ProjectBo> GetAll();
    }
}