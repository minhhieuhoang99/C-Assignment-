

using System;
using System.Collections.Generic; 
using System.Linq; 
namespace pj1
{
    class Program
    {
          
        public class member
            {
                public string First_Name ;       
                public string Last_Name ;
                public DateTime Date_Of_Birth ;     
                public string Gender ;
                public int Phone_Number ;
                public string Birth_Place ;
                public int Age ;
                public bool Is_Graduated ;
                public member(string First_Name,string Last_Name,DateTime Date_Of_Birth,string Gender,int Phone_Number,string Birth_Place,int Age,bool Is_Graduated)
                {
                    this.First_Name= First_Name; 
                    this.Last_Name=Last_Name; 
                    this.Date_Of_Birth= Date_Of_Birth; 
                    this.Gender= Gender ;
                    this.Phone_Number= Phone_Number;
                    this.Birth_Place = Birth_Place;
                    this.Age= Age;
                    this.Is_Graduated= Is_Graduated;
                }
            }
        static int CalculateAge(DateTime dateOfBirth)  
            
            {  
                int age = 0;  
                age = DateTime.Now.Year - dateOfBirth.Year;  
                if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)  
                    age = age - 1;  
            
                return (int)age;  
            } 

        static void GetMaleMember(List<member> memberList)
            
            {
                foreach (member member in memberList)
                    {
                        if(member.Gender=="nam")
                            { 
                                Console.WriteLine("member: {0},{1},{2},{3},{4},{5},{6},{7}", member.First_Name,member.Last_Name,member.Date_Of_Birth,member.Gender,member.Phone_Number,member.Birth_Place,member.Age,member.Is_Graduated);
                            }

                    }
            }
        static int GetMaxAge(List<int> list)
            
            {
                if (list.Count == 0)
                {
                    throw new InvalidOperationException("Empty list");
                }
                int maxAge = 0;
                foreach (int type in list)
                {
                    if (type > maxAge)
                    {
                        maxAge = type;
                    }
                }
                return maxAge;
            }

        static void GetOldest(List<member> list)
            
            {
                List<int> agesList = new List<int>();

                foreach (var member in list)
                {
                    var age = CalculateAge(member.Date_Of_Birth);
                    agesList.Add(age);
                    // Console.WriteLine(age);
                }
                int oldest = GetMaxAge(agesList);
                Console.WriteLine("The oldest Age is : "+" "+oldest+" "+" year old");
            }

        static void GetFullName(List<member> memberlist)
            
            {
                foreach (var member in memberlist)
                {
                    Console.WriteLine(member.First_Name + " "+ member.Last_Name);
                }
            }

        static void CompareYearOfBirth(List<member> memberlist, string condition)
            
            {
                switch (condition)
                {
                    case "equal":
                    foreach (var member in memberlist)
                    {
                        if (member.Date_Of_Birth.Year == 2000)
                        {
                            Console.WriteLine(member.First_Name + " "+ member.Last_Name);
                        }
                        
                    }
                        break;
                    case "greater":
                    foreach (var member in memberlist)
                    {
                        if (member.Date_Of_Birth.Year < 2000)
                        {
                            Console.WriteLine(member.First_Name + " "+ member.Last_Name);
                        }
                    }
                        break;
                    case "less":
                    foreach (var member in memberlist)
                    {
                        if (member.Date_Of_Birth.Year > 2000)
                        {
                            Console.WriteLine(member.First_Name + " "+ member.Last_Name);
                        }
                    }
                        break;
                    default:
                        break;
                }
            }
        static void GetBornHN(List<member> memberlist)
            
            {   
                List<string> hnList = new List<string>();
                foreach (var member in memberlist)
                {
                    
                    if (member.Birth_Place == "HN")
                    {
                        string name = member.First_Name + " "+ member.Last_Name;
                        hnList.Add(name);
                    }
                }
                var firstElement = hnList.First();
                Console.WriteLine( firstElement);
            }


        public static void SubMenu(List<member> memberList)
            
            {
                Console.WriteLine("Please chose the function:");
                Console.WriteLine("1: Return the list of members who has birth year is 2000.");
                Console.WriteLine("2: Return the list of members who has birth year > 2000.");
                Console.WriteLine("3: Return the list of members who has birth year < 2000.");
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
                List<member> memberList = new List<member>();
                memberList.Add(new member("nguyen van","A",new DateTime(1999,09,24),"nam",1234567890,"HN",22,false));
                memberList.Add(new member("nguyen van","B",new DateTime(1999,09,24),"nam",1234567890,"QN",22,true));
                memberList.Add(new member("nguyen van","C",new DateTime(1997,09,24),"nam",1234567890,"HN",24,false));
                memberList.Add(new member("nguyen van","D",new DateTime(1998,09,24),"nam",1234567890,"QN",23,true));
                memberList.Add(new member("nguyen van","E",new DateTime(1999,09,24),"nam",1234567890,"HN",22,false));
                memberList.Add(new member("nguyen van","F",new DateTime(1999,09,24),"nam",1234567890,"TB",22,true));
                memberList.Add(new member("nguyen van","G",new DateTime(1991,09,24),"nam",1234567890,"ST",30,false));
                memberList.Add(new member("nguyen van","H",new DateTime(1999,09,24),"nam",1234567890,"HN",22,true));
                memberList.Add(new member("nguyen van","I",new DateTime(1991,09,24),"nam",1234567890,"HN",30,false));
                memberList.Add(new member("nguyen van","K",new DateTime(2000,09,24),"nam",1234567890,"HN",21,true));
                memberList.Add(new member("nguyen van","A",new DateTime(2003,09,24),"nam",1234567890,"HN",19,false));
                memberList.Add(new member("tran thi","B",new DateTime(1999,09,24),"nu",1234567890,"HN",22,false));
                memberList.Add(new member("tran thi","C",new DateTime(2003,09,24),"nu",1234567890,"TB",19,true));
                memberList.Add(new member("tran thi","D",new DateTime(1999,09,24),"nu",1234567890,"DN",22,false));
                memberList.Add(new member("tran thi","E",new DateTime(1998,09,24),"nu",1234567890,"TS",23,true));
                memberList.Add(new member("tran thi","F",new DateTime(1999,09,24),"nu",1234567890,"HN",22,false));
                memberList.Add(new member("tran thi","G",new DateTime(1997,09,24),"nu",1234567890,"BN",24,true));
                memberList.Add(new member("tran thi","H",new DateTime(1999,09,24),"nu",1234567890,"HN",22,false));
                memberList.Add(new member("tran thi","I",new DateTime(2001,09,24),"nu",1234567890,"HCM",19,true));
                memberList.Add(new member("tran thi","K",new DateTime(1999,09,24),"nu",1234567890,"HN",22,false));
    
                Console.WriteLine("1: Return the list of members who is male.");
                Console.WriteLine("2: Return the oldest member base on 'Age'.");
                Console.WriteLine("3: Return a new list that contains Full Name only.");
                Console.WriteLine("4: Compare year of birth function.");
                Console.WriteLine("5: Return the first people who was born in 'Ha Noi'.");
                Console.WriteLine("6: Exit.");

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
            }
    }     
     
    
}
