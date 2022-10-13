using Microsoft.AspNetCore.Mvc;
using D3.Models;
using D3.Services;

namespace D3.Controllers
{
    public class RookiesController : Controller
    {
        private readonly ILogger<RookiesController> _logger;
        private readonly IPersonService _personService;

        public RookiesController(ILogger<RookiesController> looger, IPersonService personService)
        {
            _logger = looger;
            _personService = personService;
        }

        public IActionResult Index()
        {
            var models = _personService.GetAll();

            return View(models);
        }

        public IActionResult Details(int index)
        {
            var person = _personService.GetOne(index);
            if (person != null)
            {
                var model = new PersonDetailModel
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    Gender = person.Gender,
                    DateOfBirth = person.DateOfBirth,
                    PhoneNumber = person.PhoneNumber,
                    BirthPlace = person.BirthPlace
                };
                ViewData["index"] = index;
                return View(model);
            }

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonCreateModel model)
        {
            if (ModelState.IsValid)
            {
                var person = new PersonModel
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Gender = model.Gender,
                    DateOfBirth = model.DateOfBirth,
                    BirthPlace = model.BirthPlace,
                    PhoneNumber = model.PhoneNumber,
                    IsGraduated = false
                };
                _personService.Create(person);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int index)
        {
            var person = _personService.GetOne(index);
            if (person != null)
            {
                var model = new PersonUpdateModel
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    PhoneNumber = person.PhoneNumber,
                    BirthPlace = person.BirthPlace
                };
                ViewData["Index"] = index;

                return View(model);
            }

            return View();
        }

        [HttpPost]
        public IActionResult Update(int index, PersonUpdateModel model)
        {
            if (ModelState.IsValid)
            {
                var person = _personService.GetOne(index);
                if (person != null)
                {
                    person.FirstName = model.FirstName;
                    person.LastName = model.LastName;
                    person.BirthPlace = model.BirthPlace;
                    person.PhoneNumber = model.PhoneNumber;

                    _personService.Update(index, person);
                }
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int index)
        {
            var result = _personService.Delete(index);
            if (result == null)
            {
                return NotFound();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteAndRedirectToResult(int index)
        {
            var result = _personService.Delete(index);

            if (result == null)
            {
                return NotFound();
            }
            HttpContext.Session.SetString("DeletedPersonName", result.FullName);

            return RedirectToAction("DeleteResult");
        }

        public IActionResult DeleteResult()
        {
            ViewBag.DeletedPersonName = HttpContext.Session.GetString("DeletedPersonName");
            return View();
        }
    }
}