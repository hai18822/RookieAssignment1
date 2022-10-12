using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using MvcAssignment2.Models;

namespace MvcAssignment2.Controllers
{
    public class RookiesController : Controller
    {
        private static List<PersonModel> _people = new List<PersonModel>{
            new PersonModel{
                FirstName = "Tien",
                LastName  = "Nguyen Minh",
                Gender = "Female",
                DateOfBirth = new DateTime(1997,12,26),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "Tien",
                LastName  = "Nguyen Minh",
                Gender = "Hai Duong",
                DateOfBirth = new DateTime(1997,12,26),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "Chien",
                LastName  = "Lao Cai",
                Gender = "Male",
                DateOfBirth = new DateTime(1998,12,26),
                PhoneNumber="",
                BirthPlace = "Thai nguyen",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "Bao",
                LastName  = "Thai nguyen",
                Gender = "Male",
                DateOfBirth = new DateTime(1999,12,26),
                PhoneNumber="",
                BirthPlace = "Lao Cai",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "Hai",
                LastName  = "Yen Bai",
                Gender = "Male",
                DateOfBirth = new DateTime(2000,12,26),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "Tu",
                LastName  = "Nguyen Minh",
                Gender = "Female",
                DateOfBirth = new DateTime(2001,12,26),
                PhoneNumber="",
                BirthPlace = "Hai Duong",
                IsGraduated = false
            },
        };

        private readonly ILogger<RookiesController> _logger;

        public RookiesController(ILogger<RookiesController> looger)
        {
            _logger = looger;
        }

        public IActionResult Index()
        {
            return View(_people);
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
                _people.Add(person);

                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int index)
        {
            if (index >= 0 && index < _people.Count)
            {
                var person = _people[index];
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
                if (index >= 0 && index < _people.Count)
                {
                    var person = _people[index];
                    person.FirstName = model.FirstName;
                    person.LastName = model.LastName;
                    person.BirthPlace = model.BirthPlace;
                    person.PhoneNumber = model.PhoneNumber;

                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int index)
        {
            if (index >= 0 && index < _people.Count)
            {
                _people.RemoveAt(index);
            }

            return RedirectToAction("Index");
        }
    }
}