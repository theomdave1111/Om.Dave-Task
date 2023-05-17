using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {

        static void task2()
        {
            PoliticalParty p1 = new PoliticalParty()
            {
                Id = 1,
                PartyName = "bjp",
                PartyYear = 2021,
                VoteBankAmount = 1654,
            };
            PoliticalParty p2 = new PoliticalParty()
            {
                Id = 2,
                PartyName = "bjp",
                PartyYear = 2022,
                VoteBankAmount = 4554,
            };
            PoliticalParty p3 = new PoliticalParty()
            {
                Id = 3,
                PartyName = "bjp",
                PartyYear = 2023,
                VoteBankAmount = 4456,
            };
            PoliticalParty p4 = new PoliticalParty()
            {
                Id = 4,
                PartyName = "bjp",
                PartyYear = 2024,
                VoteBankAmount = 8748,
            };
            PoliticalParty p5 = new PoliticalParty()
            {
                Id = 5,
                PartyName = "con",
                PartyYear = 2021,
                VoteBankAmount = 1234,
            };
            PoliticalParty p6 = new PoliticalParty()
            {
                Id = 6,
                PartyName = "con",
                PartyYear = 2022,
                VoteBankAmount = 7435,
            };
            PoliticalParty p7 = new PoliticalParty()
            {
                Id = 7,
                PartyName = "con",
                PartyYear = 2023,
                VoteBankAmount = 5112,
            };
            PoliticalParty p8 = new PoliticalParty()
            {
                Id = 8,
                PartyName = "con",
                PartyYear = 2024,
                VoteBankAmount = 476,
            };
            PoliticalParty p9 = new PoliticalParty()
            {
                Id = 9,
                PartyName = "aap",
                PartyYear = 2021,
                VoteBankAmount = 625,
            };
            PoliticalParty p10 = new PoliticalParty()
            {
                Id = 10,
                PartyName = "aap",
                PartyYear = 2028,
                VoteBankAmount = 3651,
            };
            PoliticalParty p11 = new PoliticalParty()
            {
                Id = 11,
                PartyName = "aap",
                PartyYear = 2029,
                VoteBankAmount = 984,
            };
            PoliticalParty p12 = new PoliticalParty()
            {
                Id = 12,
                PartyName = "oth",
                PartyYear = 2021,
                VoteBankAmount = 165,
            };
            PoliticalParty p13 = new PoliticalParty()
            {
                Id = 13,
                PartyName = "oth",
                PartyYear = 2028,
                VoteBankAmount = 0,
            };

            Dictionary<int, PoliticalParty> party = new Dictionary<int, PoliticalParty>();
            party.Add(p1.Id, p1);
            party.Add(p2.Id, p2);
            party.Add(p3.Id, p3);
            party.Add(p4.Id, p4);
            party.Add(p5.Id, p5);
            party.Add(p6.Id, p6);
            party.Add(p7.Id, p7);
            party.Add(p8.Id, p8);
            party.Add(p9.Id, p9);
            party.Add(p10.Id, p10);
            party.Add(p11.Id, p11);
            party.Add(p12.Id, p12);
            party.Add(p13.Id, p13);

            Console.WriteLine("Enter The Party Name You Want To Search:-");
            string partyName = Console.ReadLine();

            Console.WriteLine("Enter The Year You Want To Search:-");
            int year = Convert.ToInt32(Console.ReadLine());

            string recordNotFound= null;
            int count = 0;

            foreach (var p in party)
            {
                 PoliticalParty party1 = p.Value;            
                if(party1.PartyName == partyName && party1.PartyYear == year)
                {
                    Console.WriteLine("Party Id :- {0}", party1.Id);
                    Console.WriteLine("Party Name :- {0}", party1.PartyName);
                    Console.WriteLine("Party Vote Bank Year :- {0}", party1.PartyYear);
                    Console.WriteLine("Party Vote Bank Amount :- {0}", party1.VoteBankAmount);

                }
                else
                {
                    recordNotFound = "Sorry, but we cant find any record";
                    
                    count++;
                }
              

            }
            if (count>12)
            {
                Console.WriteLine(count);
                Console.WriteLine(recordNotFound + " for {0} of {1}", partyName, year);
            }
            else
            {

                StringBuilder s = new StringBuilder();
                Console.WriteLine("====================================Political Party Details====================================");
                Console.WriteLine("Political Part Name               Year                Vote Bank Amount");
                foreach (var p in party)
                {
                    PoliticalParty party1 = p.Value;
                    Console.WriteLine("{0}                                {1}                 {2}", party1.PartyName, party1.PartyYear, party1.VoteBankAmount);


                }
            }
            

        }
        class PoliticalParty
        {
            public int Id { get; set; }
            public string PartyName { get; set; }
            public int PartyYear { get; set; }
            public int VoteBankAmount { get; set; }
        }
        static void Main(string[] args)
        {
            /*
             Task 2:
                    Create Default List of Political Party&#39;s Data.
                    A. Ask the user for selecting Party Name and year. Display the data related to it Like
                    Below. (Use Dictionary for replacing the tokens.and Use List for Political data)
                    Party Name: {PartyName} - like BJP
                    Party Vote Bank Year: {Year} - like 2024
                    Party Vote Bank Amount: {Amount} - like 105559
                    If the record not found then Display the message as Below.
                    Sorry, but we can&#39;t find any record for {PartyName} of {Year}.
                    B. Display all the records with PartyName,Year and VoteBank.
             */
            try
            {

            task2();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadKey();
        }
    }
}
