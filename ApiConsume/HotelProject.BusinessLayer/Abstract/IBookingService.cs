using HotelProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        int TGetBookingCount();
        List<Booking> TGetLast6Bookings();
        void TBookingStatusChangedApproved(int id);
        void TBookingStatusChangedCancel(int id);
        void TBookingStatusChangedWait(int id);
    }
}
