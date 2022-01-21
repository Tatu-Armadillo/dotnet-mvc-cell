using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cell.Data.Context;
using cell.Models;
using cell.Repository;

namespace cell.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class CellController : Controller
    {
        private readonly ICellRepository cellRepository;
        public CellController(ICellRepository cellRepository)
        {
            this.cellRepository = cellRepository;
        }
        public IActionResult Index()
        {
            List<Cell> people = this.cellRepository.FindAll();
            return View(people);
        }

        [HttpGet("/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/create")]
        public IActionResult Create(Cell cell)
        {
            if (ModelState.IsValid)
            {
                this.cellRepository.Create(cell);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, $"Modelo Invalido");
            return View(cell);
        }

        [HttpGet("/edit")]
        public IActionResult Edit(long id)
        {
            var cell = this.cellRepository.FindById(id);
            return View(cell);
        }

        [HttpPost("/edit")]
        public IActionResult Edit(Cell cell)
        {
            if (ModelState.IsValid)
            {
                this.cellRepository.Update(cell);
                return RedirectToAction("Index");
            }
            return View(cell);
        }

        [HttpGet("/delete")]
        public IActionResult Delete(long id)
        {
            var cell = this.cellRepository.FindById(id);
            this.cellRepository.Delete(id);
            return View(cell);
        }

        [HttpPost("/delete")]
        public IActionResult Delete(Cell cell)
        {
            this.cellRepository.Delete(cell.Id);
            return RedirectToAction("Index");
        }

    }
}