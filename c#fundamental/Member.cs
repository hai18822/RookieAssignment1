public class Member
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public DateTime DOB { get; set; }
    public string PhoneNumber { get; set; }
    public string BirthPlace { get; set; }
    private uint age;
    public uint Age
    {
        get
        {
            int currentYear = DateTime.Now.Year;
            age = Convert.ToUInt32(currentYear - DOB.Year);
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
        string graduated;

        if (IsGraduated)
        {
            graduated = "Graduated";
        }
        else
        {
            graduated = "Not graduated";
        }

        System.Console.WriteLine(LastName + " " + FirstName + " | " + "Gender: " + Gender + " | " + "DOB: " + DOB + " | " +
        "Phone number: " + PhoneNumber + " | " + "Birth place: " + BirthPlace + " | " + "Age: " + Age + " | " + graduated);

    }

}
