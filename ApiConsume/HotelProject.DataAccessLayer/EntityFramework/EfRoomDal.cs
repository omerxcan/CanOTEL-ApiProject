﻿using HotelProject.DataAccessLayer.Abstract;
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
    public class EfRoomDal : GenericRepository<Room>,IRoomDal
    {
       
        public EfRoomDal(Context context) : base(context) 
        {

        }

        public int RoomCount()
        {
            var context = new Context();
            return context.Rooms.Count();
        }
    }
}
