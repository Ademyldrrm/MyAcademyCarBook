using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Concrete
{
    public class ContactInformationManager : IContactInformationService
    {
        private readonly IContactInformation _contactInformation;

        public ContactInformationManager(IContactInformation contactInformation)
        {
            _contactInformation = contactInformation;
        }

        public void TDelete(ContactInformation entity)
        {
           _contactInformation.Delete(entity);  
        }

        public ContactInformation TGetById(int id)
        {
           return _contactInformation.GetById(id);
        }

        public List<ContactInformation> TGetListAll()
        {
            return _contactInformation.GetListAll();
        }

        public void TInsert(ContactInformation entity)
        {
           _contactInformation.Insert(entity);
        }

        public void TUpdate(ContactInformation entity)
        {
            _contactInformation.Insert(entity);
        }
    }
}
