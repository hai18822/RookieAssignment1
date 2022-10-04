namespace AsignmentDay2;
class Program
{
    static void Main(string[] args)
    {
        List<Member> listMembers = new List<Member>();
        Member member = new Member("Hai", "Le", "Male", new DateTime(1999, 11, 20), "02040234328", "Hai Duong", false);
        Member member1 = new Member("Bao", "Thanh", "Male", new DateTime(1999, 11, 20), "02040234328", "Hai Phong", true);
        Member member2 = new Member("LA", "Le", "Female", new DateTime(2002, 11, 20), "02040234328", "Ha Noi", true);
        Member member3 = new Member("Tu", "Pham", "Male", new DateTime(2000, 11, 20), "02040234328", "Ha Noi", true);
        Member member4 = new Member("Ngan", "Ha", "Female", new DateTime(2000, 11, 20), "02040234328", "Bac Ninh", false);

        listMembers.Add(member);
        listMembers.Add(member1);
        listMembers.Add(member2);
        listMembers.Add(member3);
        listMembers.Add(member4);

        Bai5(listMembers);
    }
    static void Bai1(List<Member> listMembers)
    {
        Console.WriteLine("------------------Bai 1------------------------");
        var maleList = from member in listMembers
                       where member.Gender == "Male"
                       select member;

        foreach (var item in maleList)
        {
            item.ShowInfo();
        }
    }
    static void Bai2(List<Member> listMembers)
    {
        Console.WriteLine("------------------Bai 2-------------------");
        var max = listMembers.Max(member => member.Age);
        var oldestAge = listMembers.Find(m => m.Age == max);

        if (oldestAge == null)
        {
            Console.WriteLine("khong co ai");
            return;
        }
        oldestAge.ShowInfo();
    }
    static void Bai3(List<Member> listMembers)
    {
        Console.WriteLine("----------------Bai 3----------------------");
        var listFullName = (from member in listMembers
                            select new { FullName = member.FirstName + " " + member.LastName }).ToList();

        foreach (var item in listFullName)
        {
            Console.WriteLine(item.FullName);
        }
    }
    static void Bai4(List<Member> listMembers)
    {
        Console.WriteLine("-----------------------------Bai 4-----------------------------");
        int choice2 = 1;

        while (1 <= choice2 && choice2 <= 3)
        {
            Console.WriteLine("------------Chon list can in ra------------");
            Console.WriteLine("Choose 1. List of members who has birth year greater than 2000");
            Console.WriteLine("Choose 2. List of members who has birth year less than 2000");
            Console.WriteLine("Choose 3. List of members who has birth year is 2000");
            Console.WriteLine("Choose 4. Exit");
            choice2 = Convert.ToInt32(Console.ReadLine());

            switch (choice2)
            {
                case 1:
                    Console.WriteLine("List of members who has birth year greater than 2000");
                    var memberGreader2000 = from member in listMembers
                                            where member.DOB.Year > 2000
                                            select member;
                    foreach (Member item in memberGreader2000)
                    {
                        item.ShowInfo();
                    }
                    break;
                case 2:
                    Console.WriteLine("List of members who has birth year less than 2000");
                    var memberLess2000 = from member in listMembers
                                         where member.DOB.Year < 2000
                                         select member;
                    foreach (Member item in memberLess2000)
                    {
                        item.ShowInfo();
                    }
                    break;
                case 3:
                    Console.WriteLine("List of members who has birth year is 2000");
                    var member2000 = from member in listMembers
                                     where member.DOB.Year == 2000
                                     select member;
                    foreach (Member item in member2000)
                    {
                        item.ShowInfo();
                    }
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
        }
    }
    static void Bai5(List<Member> listMembers)
    {
        Console.WriteLine("-----------------Bai 5--------------------");
        var memberHN = (from member in listMembers
                        where member.BirthPlace == "Ha Noi"
                        select member).FirstOrDefault();

        if (memberHN != null)
        {
            memberHN.ShowInfo();
        }
    }
}