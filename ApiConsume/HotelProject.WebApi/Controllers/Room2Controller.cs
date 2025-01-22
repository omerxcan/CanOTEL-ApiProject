﻿using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public Room2Controller(IMapper mapper, IRoomService roomService)
        {
            _mapper = mapper;
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(AddRoomDto roomDto)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest();
            //}
            var values = _mapper.Map<Room>(roomDto);
            _roomService.TInsert(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto roomDto)
        {
            var values = _mapper.Map<Room>(roomDto);
            _roomService.TUpdate(values);
            return Ok();
        }
    }
}
