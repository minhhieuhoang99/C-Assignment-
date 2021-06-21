using System;
using System.Collections.Generic;
using System.Linq;
namespace pj1
{
    class Program
    {
        static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;
            return (int)age;
        }

        static void GetMaleMember(List<Member> memberList)
        {
            foreach (Member member in memberList)
            {
                if (member.gender1 == "nam")
                {
                    Console.WriteLine($"The Male Member : {member.firstName1} {member.lastName1} ");
                }
            }
        }

        static void GetOldest(List<Member> memberList)
        {
            var oldest = (from member in memberList
                          select member.age1).Max();
            var oldestMember = (from member in memberList
                                where member.age1 == oldest
                                select $" {member.firstName1} {member.lastName1}").First();
            Console.WriteLine($"The oldest Member is : {oldestMember}  {oldest} year old");
            // List<string> maxAgeList = new List<string>();
            // foreach (Member member in memberList)
            // {
            //     if (member.age1 == oldest)
            //     {
            //         string maxAgeName = member.firstName1 + " " + member.lastName1;
            //         maxAgeList.Add(maxAgeName);
            //     }
            // }
            // Console.WriteLine($"The oldest Member is : {maxAgeList.First()}  {oldest} year old");
        }

        static void GetFullName(List<Member> memberList)
        {
            foreach (var member in memberList)
            {
                Console.WriteLine($"Full Name Member : {member.firstName1} {member.lastName1} ");
            }
        }

        static void CompareYearOfBirth(List<Member> memberList, string condition)
        {
            switch (condition)
            {
                case "equal":
                    foreach (var member in memberList)
                    {
                        if (member.dateOfBirth1.Year == 2000)
                        {
                            Console.WriteLine($"Member Year of Birth = 2000: {member.firstName1} {member.lastName1} ");
                        }

                    }
                    break;
                case "greater":
                    foreach (var member in memberList)
                    {
                        if (member.dateOfBirth1.Year < 2000)
                        {
                            Console.WriteLine($"Member Year of Birth < 2000: {member.firstName1} {member.lastName1} ");
                        }
                    }
                    break;
                case "less":
                    foreach (var member in memberList)
                    {
                        if (member.dateOfBirth1.Year > 2000)
                        {
                            Console.WriteLine($"Member Year of Birth > 2000: {member.firstName1} {member.lastName1} ");
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        static void GetBornHN(List<Member> memberList)
        {
            // var bornInHN = (from member in memberList
            //                 where member.birthPlace1 == "HN"
            //                 select member.firstName1 + member.lastName1
            //          ).First();
            // Console.WriteLine($"Member was born in Ha Noi is: {bornInHN}");
            foreach (var i in memberList)
            {
                if (i.birthPlace1 == "HN")
                {
                    Console.WriteLine($"Member Born in Ha Noi : {i.firstName1} {i.lastName1} ");
                    break;
                }
                else
                {
                    Console.WriteLine($"Nobody Was Born in Ha Noi ");
                    break;
                }

            }
        }

        public static void SubMenu(List<Member> memberList)
        {
            Console.WriteLine("Please chose the function:");
            Console.WriteLine("1: Return the list of Members who has birth year is 2000.");
            Console.WriteLine("2: Return the list of Members who has birth year > 2000.");
            Console.WriteLine("3: Return the list of Members who has birth year < 2000.");
            Console.WriteLine("4: Back.");
            string selection = Console.ReadLine();
            switch (int.Parse(selection))
            {
                case 1:
                    CompareYearOfBirth(memberList, "equal");
                    break;
                case 2:
                    CompareYearOfBirth(memberList, "greater");
                    break;
                case 3:
                    CompareYearOfBirth(memberList, "less");
                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            List<Member> memberList = new List<Member>();
            memberList.Add(new Member("nguyen van", "A", new DateTime(1999, 09, 24), "nam", 1234567890, "HCM", 21, false));
            memberList.Add(new Member("nguyen van", "B", new DateTime(1999, 09, 24), "nam", 1234567890, "QN", 21, true));
            memberList.Add(new Member("nguyen van", "C", new DateTime(1997, 09, 24), "nam", 1234567890, "HN", 23, false));
            memberList.Add(new Member("nguyen van", "D", new DateTime(1998, 09, 24), "nam", 1234567890, "QN", 22, true));
            memberList.Add(new Member("nguyen van", "E", new DateTime(1999, 09, 24), "nam", 1234567890, "HCM", 21, false));
            memberList.Add(new Member("nguyen van", "F", new DateTime(1999, 09, 24), "nam", 1234567890, "TB", 21, true));
            memberList.Add(new Member("nguyen van", "G", new DateTime(1991, 09, 24), "nam", 1234567890, "ST", 29, false));
            memberList.Add(new Member("nguyen van", "H", new DateTime(1999, 09, 24), "nam", 1234567890, "HCM", 21, true));
            memberList.Add(new Member("nguyen van", "I", new DateTime(1991, 09, 24), "nam", 1234567890, "HCM", 29, false));
            memberList.Add(new Member("nguyen van", "K", new DateTime(2000, 09, 24), "nam", 1234567890, "HN", 20, true));
            memberList.Add(new Member("nguyen van", "A", new DateTime(2003, 09, 24), "nam", 1234567890, "HCM", 18, false));
            memberList.Add(new Member("tran thi", "B", new DateTime(1999, 09, 24), "nu", 1234567890, "HCM", 21, false));
            memberList.Add(new Member("tran thi", "C", new DateTime(2003, 09, 24), "nu", 1234567890, "TB", 18, true));
            memberList.Add(new Member("tran thi", "D", new DateTime(1999, 09, 24), "nu", 1234567890, "DN", 21, false));
            memberList.Add(new Member("tran thi", "E", new DateTime(1998, 09, 24), "nu", 1234567890, "TS", 22, true));
            memberList.Add(new Member("tran thi", "F", new DateTime(1999, 09, 24), "nu", 1234567890, "HCM", 23, false));
            memberList.Add(new Member("tran thi", "G", new DateTime(1997, 09, 24), "nu", 1234567890, "BN", 23, true));
            memberList.Add(new Member("tran thi", "H", new DateTime(1999, 09, 24), "nu", 1234567890, "HN", 21, false));
            memberList.Add(new Member("tran thi", "I", new DateTime(2001, 09, 24), "nu", 1234567890, "HCM", 18, true));
            memberList.Add(new Member("tran thi", "K", new DateTime(1999, 09, 24), "nu", 1234567890, "HCM", 21, false));

        Menu:
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("| Please chose the function:                                  |");
            Console.WriteLine("| 1: Return the list of Members who is male.                  |");
            Console.WriteLine("| 2: Return the oldest Member base on 'Age'.                  |");
            Console.WriteLine("| 3: Return a new list that contains Full Name only.          |");
            Console.WriteLine("| 4: Compare year of birth function.                          |");
            Console.WriteLine("| 5: Return the first people who was born in 'Ha Noi'.        |");
            Console.WriteLine("| 6: Exit.                                                    |");
            Console.WriteLine("---------------------------------------------------------------");

            string selection = Console.ReadLine();

            switch (int.Parse(selection))
            {
                case 1:
                    GetMaleMember(memberList);
                    break;
                case 2:
                    GetOldest(memberList);
                    break;
                case 3:
                    GetFullName(memberList);
                    break;
                case 4:
                    SubMenu(memberList);
                    break;
                case 5:
                    GetBornHN(memberList);
                    break;
                case 6:
                    return;
            }
            goto Menu;
        }
    }
}
