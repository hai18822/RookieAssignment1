namespace AsignmentDay2
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        private string _fullName;
        public string FullName
        {
            get
            {
                _fullName = FirstName + " " + LastName;
                return _fullName;
            }
        }
        private uint _age;
        public uint Age
        {
            get
            {
                _age = Convert.ToUInt32(DateTime.Now.Year - DOB.Year);

                return _age;
            }
        }
        public bool IsGraduated { get; set; }
        public Member(string firstName, string lastName, string gender, DateTime dob, string phoneNumber, string birthPlace, bool isGraduated)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DOB = dob;
            PhoneNumber = phoneNumber;
            BirthPlace = birthPlace;
            IsGraduated = isGraduated;
        }
        public void ShowInfo()
        {
            string graduated;

            if (IsGraduated)
            {
                graduated = "Graduated";
            }
            else
            {
                graduated = "Not gradeuated";
            }
            System.Console.WriteLine(FirstName + " " + LastName + " | " + "Gender: " + Gender + " | " + "DOB: " + DOB
            + "Phone number: " + PhoneNumber + " | " + "Birth place: " + BirthPlace + " | " + "Age: " + Age + " | " + "Graduated: " + graduated);
        }
    }
}