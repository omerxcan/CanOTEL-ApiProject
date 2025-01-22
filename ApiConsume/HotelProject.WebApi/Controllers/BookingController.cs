using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.NetworkInformation;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);
        }
        //[HttpPut("UpdateReservationStatus")]
        //public IActionResult UpdateReservationStatus(Booking booking)
        //{
        //    _bookingService.TBookingStatusChangeApproved(booking);
        //    return Ok();
        //}

        //[HttpPut("UpdateReservationStatus2")]
        //public IActionResult UpdateReservationStatus2(int id)
        //{
        //    _bookingService.TBookingStatusChangeApproved2(id);
        //    return Ok();
        //}


        [HttpGet("GetLast6Bookings")]
        public IActionResult GetLast6Bookings()
        {
            return Ok(_bookingService.TGetLast6Bookings());
        }

        [HttpGet("BookingApproved")]
        public IActionResult BookingApproved(int id)
        {
            _bookingService.TBookingStatusChangedApproved(id);
            return Ok();
        }
        [HttpGet("BookingCancel")]
        public IActionResult BookingCancel(int id)
        {
            _bookingService.TBookingStatusChangedCancel(id);
            return Ok();
        }

        [HttpGet("BookingWait")]
        public IActionResult BookingWait(int id)
        {
            _bookingService.TBookingStatusChangedWait(id);
            return Ok();
        }

    }
}
