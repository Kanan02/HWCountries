using System;
using System.Linq;

namespace CodefirstCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryContext db = new CountryContext();
            while (true)
            {
                Console.WriteLine("Choose query:");
                Console.WriteLine("1.Participants  2.Sports 3.Countries 4.GetPartById 5.GetSportById 6.GetCountryById");
                int choice=int.Parse(Console.ReadLine());
                int id = 0;
                switch (choice)
                {
                    
                    case 1:
                        foreach (var item in db.Participants.ToList())
                        {
                            Console.WriteLine(item.Id+" "+item.Firstname+" "+item.LastName+" "+item.Country.CountryName);
                        }
                        break;
                    case 2:
                        foreach (var item in db.Sports.ToList())
                        {
                            Console.WriteLine(item.Id + " " + item.SportName );
                        }
                        break;
                    case 3:
                        foreach (var item in db.Countries.ToList())
                        {
                            Console.WriteLine(item.Id + " " + item.CountryName);
                        }
                        break;
                    case 4:
                        id = int.Parse(Console.ReadLine());
                        foreach (var item in db.Participants.ToList())
                        {
                            if (item.Id==id)
                            {
                                
                                Console.WriteLine(item.Firstname + " " + item.LastName + " " + item.Country.CountryName );
                                foreach (var medal in item.ParticipantMedals.ToList())
                                {
                                    Console.WriteLine(medal.Medal.MedalType);
                                }
                                break;
                            }
                        }
                        break;
                    case 5:
                        id = int.Parse(Console.ReadLine());
                        foreach (var item in db.Sports.ToList())
                        {
                            if (item.Id == id)
                            {
                                Console.WriteLine(item.SportName + " " + item.Participants.ToList().Count + " ");                                
                                break;
                            }
                        }
                        break;
                    case 6:
                        id = int.Parse(Console.ReadLine());
                        foreach (var item in db.Countries.ToList())
                        {
                            if (item.Id == id)
                            {
                                int sp = 0;
                                int med = 0;
                                foreach (var part in item.Participants.ToList())
                                {
                                    if (part.Sport != null)
                                    {
                                        sp++;
                                    }
                                    med+=part.ParticipantMedals.Count;
                                  
                                }
                                Console.WriteLine(item.CountryName + " " + item.Participants.ToList().Count + " "+sp+" "+med);
                                
                                break;
                            }
                        }
                        break;

                    default:
                        break;


                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
