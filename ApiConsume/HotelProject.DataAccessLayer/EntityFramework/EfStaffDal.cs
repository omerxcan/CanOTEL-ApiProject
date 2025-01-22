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
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }

        public int GetStaffCount()
        {
            Context context = new();
            var values = context.Staff.Count();
            return values;
        }

        public List<Staff> Last4Staff()
        {
            Context context = new();
            var values = context.Staff.OrderByDescending(x => x.StaffID).Take(4).ToList();  
            return values;
        }
    }
}
