﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>,IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context) 
        {
            
        }

        public int AppUserCount()
        {
            var context = new Context();
            return context.Users.Count();
        }

        //public List<AppUser> UserListWithWorkLocation()
        //{
        //    //Context context = new Context();
        //    //return context.Users.Include(x => x.WorkLocation).ToList();

        //}
    }
}
