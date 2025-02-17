﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public int TGetBookingCount()
        {
            return _bookingDal.GetBookingCount();
        }

        public void TDelete(Booking t)
        {
            _bookingDal.Delete(t);
        }

        public Booking TGetByID(int id)
        {
            return _bookingDal.GetByID(id);
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }

        public void TInsert(Booking t)
        {
            _bookingDal.Insert(t);
        }

        public void TUpdate(Booking t)
        {
            _bookingDal.Update(t);
        }

        public List<Booking> TGetLast6Bookings()
        {
            return _bookingDal.GetLast6Bookings();
        }

        public void TBookingStatusChangedApproved(int id)
        {
            _bookingDal.BookingStatusChangedApproved(id);
        }

        public void TBookingStatusChangedCancel(int id)
        {
            _bookingDal.BookingStatusChangedCancel(id);
        }

        public void TBookingStatusChangedWait(int id)
        {
            _bookingDal.BookingStatusChangedWait(id);
        }
    }
}
