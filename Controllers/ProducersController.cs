﻿using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {

        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;

        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync() ;
            return View(allProducers);
        }


        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id) ;
            if (producerDetails == null) return View("Not Found");
            return View(producerDetails);
        }


        //GET:producers/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")]Producer producer)
        {
            if(!ModelState.IsValid) return View(producer);
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

    }
}
