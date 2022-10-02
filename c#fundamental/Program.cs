// See https://aka.ms/new-console-template for more information


List<Member> listMembers = new List<Member>();
Member member = new Member("Hai", "Le", "Male", new DateTime(1999, 11, 20), "02040234328", "HD", false);
Member member1 = new Member("Bao", "1", "Male", new DateTime(1998, 11, 20), "02040234328", "HD", false);
Member member2 = new Member("LA", "2", "Female", new DateTime(2002, 11, 20), "02040234328", "HN", false);
Member member3 = new Member("Tu", "Pham", "Male", new DateTime(2000, 11, 20), "02040234328", "HN", false);
Member member4 = new Member("Ngan", "4", "Female", new DateTime(2000, 11, 20), "02040234328", "HD", false);

listMembers.Add(member);
listMembers.Add(member1);
listMembers.Add(member2);
listMembers.Add(member3);
listMembers.Add(member4);

System.Console.WriteLine("----------Menu-----------");
System.Console.WriteLine("Chon 1. Bai 1: Return a list of members who is Male");
System.Console.WriteLine("Chon 2. Bai 2: Return the oldest one based on “Age”");
System.Console.WriteLine("Chon 3. Bai 3: Return a new listthat contains Full Name only");
System.Console.WriteLine("Chon 4. Bai 4: Return 3 lists");
System.Console.WriteLine("Chon 5. Bai 5: Return the first person who was born in Ha Noi");

int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        //Bai 1: Return a list of members who isMale
        listMembers.ForEach(m =>
        {
            if (m.Gender == "Male")
            {
                m.ShowInfo();
            }
        });
        break;
    case 2:
        //Bai 2: Return the oldest one based on “Age”
        int max;
        max = listMembers[0].Age;
        for (int i = 0; i < listMembers.Count; i++)
        {
            if (max < listMembers[i].Age)
            {
                max = listMembers[i].Age;
            }
        }
        for (int i = 0; i < listMembers.Count; i++)
        {
            if (listMembers[i].Age == max)
            {
                listMembers[i].ShowInfo();
                break;
            }
        }
        break;
    case 3:
        //Bai 3: Return a new listthat contains Full Name only
        List<string> newLs = new List<string>();
        for (int i = 0; i < listMembers.Count; i++)
        {
            string fullName = listMembers[i].FirstName + " " + listMembers[i].LastName;
            newLs.Add(fullName);
        }
        for (int i = 0; i < newLs.Count; i++)
        {
            System.Console.WriteLine(newLs[i]);
        }
        break;
    case 4:
        //Bai 4: Return 3 lists:
        List<Member> member2000 = new List<Member>();
        List<Member> memberGreater2000 = new List<Member>();
        List<Member> memberLess2000 = new List<Member>();

        for (int i = 0; i < listMembers.Count; i++)
        {
            if (listMembers[i].DOB.Year == 2000)
            {
                member2000.Add(listMembers[i]);
            }
            else if (listMembers[i].DOB.Year > 2000)
            {
                memberGreater2000.Add(listMembers[i]);
            }
            else if (listMembers[i].DOB.Year < 2000)
            {
                memberLess2000.Add(listMembers[i]);
            }

        }
        // In cac list ra man hinh
        System.Console.WriteLine("------------Chon list------------");
        System.Console.WriteLine("chon 1. List of members who has birth year greater than 2000");
        System.Console.WriteLine("chon 2. List of members who has birth year less than 2000");
        System.Console.WriteLine("chon 3. List of members who has birth year is 2000");
        int choice2 = Convert.ToInt32(Console.ReadLine());
        switch (choice2)
        {
            case 1:
                for (int i = 0; i < memberGreater2000.Count; i++)
                {
                    memberGreater2000[i].ShowInfo();
                }
                break;
            case 2:
                for (int i = 0; i < memberLess2000.Count; i++)
                {
                    memberLess2000[i].ShowInfo();
                }
                break;
            case 3:
                for (int i = 0; i < member2000.Count; i++)
                {
                    member2000[i].ShowInfo();
                }
                break;
            default:
                System.Console.WriteLine("chon sai");
                break;
        }
        break;
    case 5:
        //Bai 5: Return the first person who was born in Ha Noi.
        int j = 0;
        while (true)
        {

            if (listMembers[j].BirthPlace == "HN")
            {
                listMembers[j].ShowInfo();
                break;
            }
            j++;
        }
        break;
    default:
        System.Console.WriteLine("Vui long nhap lai");
        break;
}









