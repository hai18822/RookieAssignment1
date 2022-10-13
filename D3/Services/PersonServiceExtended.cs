using D3.Models;

namespace D3.Services
{
    public class PersonServiceExtended : IPersonService
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
        List<PersonModel> IPersonService.GetAll()
        {
            return _people;
        }

        public PersonModel? GetOne(int index)
        {
            throw new NotImplementedException();
        }

        public PersonModel Create(PersonModel model)
        {
            _people.Add(model);
            return model;
        }

        public PersonModel? Update(int index, PersonModel model)
        {
            if (index >= 0 && index < _people.Count)
            {
                _people[index]=model;
                return model;
            }

            return null;
        }

        public PersonModel? Delete(int index)
        {
            if (index >= 0 && index < _people.Count)
            {
                var person = _people[index];
                _people.RemoveAt(index);
                return person;
            }

            return null;
        }
    }
}