using HotelProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        int GetBookingCount();     
        List<Booking> GetLast6Bookings();
        void BookingStatusChangedApproved(int id);
        void BookingStatusChangedCancel(int id);
        void BookingStatusChangedWait(int id);
    }
}
