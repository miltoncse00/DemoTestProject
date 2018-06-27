using Demo.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Business
{
    public interface IContactBusiness
    {
        int Add(ContactBo projectBo);
    }
}
