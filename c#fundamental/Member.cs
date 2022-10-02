public class Member
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public DateTime DOB { get; set; }
    public string PhoneNumber { get; set; }
    public string BirthPlace { get; set; }
    private int age;
    public int Age
    {
        get
        {
            int currentYear = DateTime.Now.Year;
            age = currentYear - DOB.Year;
            return age;
        }
    }
    public bool IsGraduated { get; set; }
    public Member(string fName, string lName, string gender, DateTime dob, string pNumber, string bPlace, bool isG)
    {
        FirstName = fName;
        LastName = lName;
        Gender = gender;
        DOB = dob;
        PhoneNumber = pNumber;
        BirthPlace = bPlace;
        IsGraduated = isG;
    }

    public void ShowInfo()
    {
        System.Console.WriteLine("----------------------------");
        System.Console.WriteLine("Fullname: " + FirstName+" " + LastName);
        System.Console.WriteLine("Gender: " + Gender);
        System.Console.WriteLine("Date of birth: " + DOB);
        System.Console.WriteLine("Phone number: " + PhoneNumber);
        System.Console.WriteLine("Birth Place: " + BirthPlace);
        System.Console.WriteLine("Age: " + Age);
        System.Console.WriteLine("Is graduated: " + IsGraduated);
        
    }

}
