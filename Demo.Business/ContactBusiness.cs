using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Demo.Common;
using Demo.Common.Models;
using Demo.Data.DbManager;

namespace Demo.Business
{
    public class ContactBusiness : IContactBusiness
    {
        private readonly DemoCotext _context;
        private readonly IMapper _mapper;

        public ContactBusiness(DemoCotext context, IMapper mapper)
        {
           _context = context;
            _mapper = mapper;
        }
        public int Add(ContactBo contactBo)
        {
          
            var contact = _mapper.Map<Contact>(contactBo);
            _context.Contact.Add(contact);
            return _context.SaveChanges();
        }

        public List<ContactBo> GetAll()
        {
            return new List<ContactBo>();
        }
    }
}
