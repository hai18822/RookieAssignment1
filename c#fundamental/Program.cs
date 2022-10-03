// See https://aka.ms/new-console-template for more information


List<Member> listMembers = new List<Member>();

Member member = new Member("Hai", "Le", "Male", new DateTime(1999, 11, 20), "02040234328", "HD", false);
Member member1 = new Member("Bao", "Thanh", "Male", new DateTime(1998, 11, 20), "02040234328", "HD", true);
Member member2 = new Member("LA", "Le", "Female", new DateTime(2002, 11, 20), "02040234328", "Ha Noi", true);
Member member3 = new Member("Tu", "Pham", "Male", new DateTime(2000, 11, 20), "02040234328", "Ha Noi", true);
Member member4 = new Member("Ngan", "Ha", "Female", new DateTime(2000, 11, 20), "02040234328", "HD", false);

listMembers.Add(member);
listMembers.Add(member1);
listMembers.Add(member2);
listMembers.Add(member3);
listMembers.Add(member4);

//Bai 1: Return a list of members who isMale
System.Console.WriteLine("-------------Bai 1----------------");
listMembers.ForEach(m =>
{
    if (m.Gender == "Male")
    {
        m.ShowInfo();
    }
});

// Bai 2: Return the oldest one based on “Age”
uint max = listMembers[0].Age;

for (int i = 0; i < listMembers.Count; i++)
{
    if (max < listMembers[i].Age)
    {
        max = listMembers[i].Age;
    }
}

System.Console.WriteLine("-----------------------Bai 2----------------------------");
for (int i = 0; i < listMembers.Count; i++)
{
    if (listMembers[i].Age == max)
    {
        listMembers[i].ShowInfo();
        break;
    }
}

//Bai 3: Return a new listthat contains Full Name only
List<string> newLs = new List<string>();

for (int i = 0; i < listMembers.Count; i++)
{
    string fullName = listMembers[i].FirstName + " " + listMembers[i].LastName;
    newLs.Add(fullName);
}

System.Console.WriteLine("-----------------------Bai 3----------------------");
for (int i = 0; i < newLs.Count; i++)
{
    System.Console.WriteLine(newLs[i]);
}

//Bai 4: Return 3 lists:
System.Console.WriteLine("-----------------------------Bai 4-----------------------------");

int choice2 = 1;

while (1 <= choice2 && choice2 <= 3)
{
    System.Console.WriteLine("------------Chon list can in ra------------");
    System.Console.WriteLine("Choose 1. List of members who has birth year greater than 2000");
    System.Console.WriteLine("Choose 2. List of members who has birth year less than 2000");
    System.Console.WriteLine("Choose 3. List of members who has birth year is 2000");
    System.Console.WriteLine("Choose 4. Exit");
    
    choice2 = Convert.ToInt32(Console.ReadLine());
    switch (choice2)
    {
        case 1:
            System.Console.WriteLine("List of members who has birth year greater than 2000");
            for (int i = 0; i < listMembers.Count; i++)
            {
                if (listMembers[i].DOB.Year > 2000)
                {
                    listMembers[i].ShowInfo();
                }
            }
            break;
        case 2:
            System.Console.WriteLine("List of members who has birth year less than 2000");
            for (int i = 0; i < listMembers.Count; i++)
            {
                if (listMembers[i].DOB.Year < 2000)
                {
                    listMembers[i].ShowInfo();
                }
            }
            break;
        case 3:
            System.Console.WriteLine("List of members who has birth year is 2000");
            for (int i = 0; i < listMembers.Count; i++)
            {
                if (listMembers[i].DOB.Year == 2000)
                {
                    listMembers[i].ShowInfo();
                }
            }
            break;
        default:
            System.Console.WriteLine("Exit");
            break;
    }
}

//Bai 5: Return the first person who was born in Ha Noi.
int j = 0;
System.Console.WriteLine("------------------------Bai 5-----------------------");
while (j < listMembers.Count)
{
    if (listMembers[j].BirthPlace == "Ha Noi")
    {
        listMembers[j].ShowInfo();
        break;
    }
    j++;
}











