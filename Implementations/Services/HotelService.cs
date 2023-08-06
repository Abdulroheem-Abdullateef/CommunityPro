using CommunityProApp.Dtos;
using CommunityProApp.Entities;
using CommunityProApp.Interfaces.Repositories;
using CommunityProApp.Interfaces.Services;
using CommunityProApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommunityProApp.Implementations.Services
{
    public class HotelService : IHotelService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IRoomTypeRepository _roomTypeRepository;
        private readonly IHotelBookingRepository _hotelBookingRepository;




        public HotelService(IRoomRepository roomRepository, IRoomTypeRepository roomTypeRepository, IHotelBookingRepository hotelBookingRepository)
        {
            _hotelBookingRepository = hotelBookingRepository;

            _roomRepository = roomRepository;
            _roomTypeRepository = roomTypeRepository;
        }

        public BaseResponse AddRoomType(CreateRoomTypeRequestModel model)
        {
            var roomType = new RoomType
            {
                Name = model.Name,
                Image = model.Image,
                Image2 = model.Image2,
                Image3 = model.Image3,
                Price = model.Price,
                MaxNumberOfAdult = model.MaxNumberOfAdult,
                Description = model.Description
            };
            _roomTypeRepository.Create(roomType);
            return new BaseResponse
            {
                Message = "Created Succesfully",
                Status = true,
            };
        }

        public BaseResponse AddRoom(CreateRoomRequestModel model)
        {
            var room = new Room
            {
                RoomNumber = model.RoomNumber,
                RoomTypeId = model.RoomTypeId,
                Status = Enums.RoomAvailabilityStatus.Available
            };
            _roomRepository.Create(room);
            return new BaseResponse
            {
                Message = "Created Succesfully",
                Status = true,
            };
        }

        public IList<RoomTypeDto> GetRoomTypes()
        {
            
            return _roomTypeRepository.Get().Select(rT => new RoomTypeDto
            {
                Description = rT.Description,
                Id = rT.Id,
                Image= rT.Image,
                Image2 = rT.Image2,
                Image3 = rT.Image3, 
                MaxNumberOfAdult = rT.MaxNumberOfAdult,
                Name = rT.Name,
                Price = rT.Price,
            }).ToList();
        }

        public IList<RoomTypeDto> GetRoomTypes(int roomTypeId)
        {
            var roomType = _roomTypeRepository.Get(r => r.Id == roomTypeId);
             return _roomTypeRepository.Get().Select(rT => new RoomTypeDto
            {
                Description = rT.Description,
                Id = rT.Id,
                Image= rT.Image,
                Image2 = rT.Image2,
                Image3 = rT.Image3, 
                MaxNumberOfAdult = rT.MaxNumberOfAdult,
                Name = rT.Name,
                Price = rT.Price,
            }).ToList();
        }

        public RoomTypeDto RoomTypeDetail(int id)
        {
            return new RoomTypeDto();
        }
        /* private IEnumerable<IList<int>> AvailableRoomsIds(int roomTypeId)
         {
             return _roomRepository.GetAll(r => r.RoomTypeId == roomTypeId && r.Status == Enums.RoomAvailabilityStatus.Available).ToList()
         }*/
        private SearchRoomDto GetAvailableRoom(CheckRoomAvailabilityModel model)
        {
            var dr = _roomRepository.Query().Include(a => a.Type).Where(r => r.RoomTypeId == model.RoomTypeId).FirstOrDefault();
            var room = _roomRepository.Query().Include(a => a.Type).Where(r => r.RoomTypeId == model.RoomTypeId)
                .ToList()
                .Select(r => new SearchRoomDto
                {
                    Id = r.Id,
                    Price = r.Type.Price,
                    RoomNumber = r.RoomNumber,
                    RoomTypeName = r.Type.Name,
                    CheckInDate = model.CheckInDate,
                    CheckOutDate = model.CheckOutDate,
                    NumberOfAdults = model.NumberOfAdults,
                    RoomImage = r.Type.Image
                })
                .FirstOrDefault(r => IsAvailableBetweenDate(r.Id, model.CheckInDate, model.CheckOutDate));


            return room;
          
        }

       

        private bool IsAvailableBetweenDate(int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            bool isAvailble = false;
            var bookings = _hotelBookingRepository.GetByRoomId(roomId).Where(b => b.CheckOutDate >= DateTime.Now).ToList();

            if (bookings.Count == 0) return isAvailble;

            foreach(var booking in bookings)
            {
                if ((booking.CheckOutDate < checkInDate) || (booking.CheckInDate > checkInDate && booking.CheckInDate > checkOutDate))
                {
                    isAvailble = true;
                    break;
                }
            }

            return isAvailble;
        }

        public SearchRoomDto SearchProducts(CheckRoomAvailabilityModel model)
        {
            return GetAvailableRoom(model);
        }
        //public BookRoomInvoice BookRoom(CreateBookingRequestModel model)
        //{
        //    var days = model.CheckOutDate.Subtract(model.CheckInDate).Days;
        //    var booking = new HotelBooking
        //    {
        //        NumberOfAdults = model.NumberOfAdults,
        //        CheckInDate = model.CheckInDate,
        //        CheckOutDate = model.CheckOutDate,
        //        CustomerId = model.CustomerId,
        //        ReferenceNumber = Guid.NewGuid().ToString().Substring(0, 7),
        //        RoomId = model.RoomId,.

        //        RoomPrice = model.RoomPrice * days,
        //        Status = Enums.BookingStatus.Initialized,

        //    };
        //    _hotelBookingRepository.Create(booking);
        //    return new BookRoomInvoice
        //    {

        //    };
        //}

       

    }
}
