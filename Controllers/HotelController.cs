using CommunityProApp.Dtos;
using CommunityProApp.Interfaces.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;

namespace CommunityProApp.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelService _hotelService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HotelController(IHotelService hotelService, IWebHostEnvironment webHostEnvironment)
        {
            _hotelService = hotelService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateRoomType()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateRoomType(CreateRoomTypeRequestModel model, IFormFile roomTypeImage, IFormFile roomTypeImage1, IFormFile roomTypeImage2)
        {
            if (roomTypeImage != null && roomTypeImage1 != null && roomTypeImage2 != null)
            {
                string roomTypeImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "RoomTypeImage");
                string roomTypeImage1PhotoPath = Path.Combine(_webHostEnvironment.WebRootPath, "RoomTypeImage");
                string roomTypeImage2PhotoPath = Path.Combine(_webHostEnvironment.WebRootPath, "RoomTypeImage");
                Directory.CreateDirectory(roomTypeImagePath);
                Directory.CreateDirectory(roomTypeImage1PhotoPath);
                Directory.CreateDirectory(roomTypeImage2PhotoPath);
                string contentType = roomTypeImage.ContentType.Split('/')[1];
                string contentType1 = roomTypeImage1.ContentType.Split('/')[1];
                string contentType2 = roomTypeImage2.ContentType.Split('/')[1];
                string photoImage = $"RMT{Guid.NewGuid()}.{contentType}";
                string photoImage1 = $"RMT{Guid.NewGuid()}.{contentType1}";
                string photoImage2 = $"RMT{Guid.NewGuid()}.{contentType2}";
                string fullPath = Path.Combine(roomTypeImagePath, photoImage);
                string fullPath1 = Path.Combine(roomTypeImage1PhotoPath, photoImage1);
                string fullPath2 = Path.Combine(roomTypeImage2PhotoPath, photoImage2);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    roomTypeImage.CopyTo(fileStream);

                }
                using (var fileStream = new FileStream(fullPath1, FileMode.Create))
                {
                    roomTypeImage1.CopyTo(fileStream);

                }
                using (var fileStream = new FileStream(fullPath2, FileMode.Create))
                {
                    roomTypeImage2.CopyTo(fileStream);

                }
                model.Image = photoImage;
                model.Image2 = photoImage1;
                model.Image3 = photoImage2;

            }
            var roomType = _hotelService.AddRoomType(model);
            return View("Index");



        }
        public IActionResult CreateRoom()
        {
            var roomTypes = _hotelService.GetRoomTypes();
            ViewData["RoomTypes"] = new SelectList(roomTypes, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult CreateRoom(CreateRoomRequestModel model)
        {
            var room = _hotelService.AddRoom(model);
            return RedirectToAction("Index");
        }
        public IActionResult SearchAvailableRooms()
        {
            var roomTypes = _hotelService.GetRoomTypes();
            ViewData["RoomTypes"] = new SelectList(roomTypes, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult SearchAvailableRooms(CheckRoomAvailabilityModel model)
        {
            var searchRooms = _hotelService.SearchProducts(model);
            return View("BookView",searchRooms);
        }
        [HttpGet]
        public IActionResult BookView()
        {
            return View();
        }
        
    }
}
