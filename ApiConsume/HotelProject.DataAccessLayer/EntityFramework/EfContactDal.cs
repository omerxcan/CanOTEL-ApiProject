using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>,IContactDal
    {
        public EfContactDal(Context context) : base(context)
        {
            
        }

        public int GetContactCount()
        {
            Context context = new();
            return context.Contacts.Count();

        }
    }
}
