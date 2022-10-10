using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using MvcAssigment1.Models;

namespace MvcAssigment1.Controllers
{
    [Route("NashTech/[controller]")]
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
                Gender = "Male",
                DateOfBirth = new DateTime(1997,12,26),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "Chien",
                LastName  = "Nguyen Minh",
                Gender = "Male",
                DateOfBirth = new DateTime(1998,12,26),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "Bao",
                LastName  = "Nguyen Minh",
                Gender = "Male",
                DateOfBirth = new DateTime(1999,12,26),
                PhoneNumber="",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "Hai",
                LastName  = "Nguyen Minh",
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
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
        };

        private readonly ILogger<RookiesController> _logger;

        public RookiesController(ILogger<RookiesController> looger)
        {
            _logger = looger;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            return Json(_people);
        }

        [Route("GetMaleMembers")]
        public IActionResult GetMaleMembers()
        {
            var data = _people.Where(p => p.Gender == "Male");
            return Json(data);
        }

        [Route("GetOldestMembers")]
        public IActionResult GetOldestMembers()
        {
            var maxAge = _people.Max(p => p.Age);
            var data = _people.Where(p => p.Age == maxAge);
            return Json(data);
        }

        #region #4

        public IActionResult GetMemberByBirthYear(int year, string compareType)
        {
            switch (compareType)
            {
                case "equals":
                    return Json(_people.Where(p => p.DateOfBirth?.Year == year));
                case "greaterThan":
                    return Json(_people.Where(p => p.DateOfBirth?.Year > year));
                case "lessThan":
                    return Json(_people.Where(p => p.DateOfBirth?.Year < year));
                default:
                    return Json(null);
            }
        }

        [Route("GetMembersWhoBornIn2000")]
        public IActionResult GetMembersWhoBornIn2000()
        {
            return RedirectToAction("GetMemberByBirthYear", new { year = 2000, compareType = "equals" });
        }

        [Route("GetMembersWhoBornAfter2000")]
        public IActionResult GetMembersWhoBornAfter2000()
        {
            return RedirectToAction("GetMemberByBirthYear", new { year = 2000, compareType = "greaterThan" });
        }

        [Route("GetMembersWhoBornBefore2000")]
        public IActionResult GetMembersWhoBornBefore2000()
        {
            return RedirectToAction("GetMemberByBirthYear", new { year = 2000, compareType = "lessThan" });
        }

        #endregion

        #region Export

        private byte[] WriteCsvToMemory(IEnumerable<PersonModel> people)
        {
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            using (var csvWriter = new CsvWriter(streamWriter, System.Globalization.CultureInfo.CurrentCulture))
            {
                csvWriter.WriteRecords(people);
                streamWriter.Flush();
                return memoryStream.ToArray();
            }
        }

        [Route("Export")]
        public FileStreamResult Export()
        {
            var result = WriteCsvToMemory(_people);
            var memoryStream = new MemoryStream(result);
            return new FileStreamResult(memoryStream, "text/csv") { FileDownloadName = "people.csv" };
        }

        #endregion
    }
}