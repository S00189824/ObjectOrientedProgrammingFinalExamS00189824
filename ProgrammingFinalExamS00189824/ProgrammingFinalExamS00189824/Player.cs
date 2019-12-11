using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFinalExamS00189824
{
    public enum Position
    {
        GoalKeeper,
        Defender,
        Midfielder,
        Forward
    }

    class Player
    {
        string[] firstNames = {
                "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
                "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
                "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};


        string[] lastNames = {
                "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
                "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
                "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"
            };
        
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position PreferredPosition { get; set; }
        DateTime DOB { get; set; }
        public int Age { get; set; }

        //constructor
        public Player(string firstname,string lastname,Position position,DateTime dob,int age)
        {
            FirstName = firstname;
            LastName = lastname;
            PreferredPosition = position;
            DOB = dob;
            Age = age;
        }

        public void CreatePlayer(string[] firstname,string[] lastname)
        {
            Random r = new Random();
            // trying to do random but cant figure it out
        }



        public override string ToString()
        {
            return string.Format(FirstName + " " + LastName + " " + (Age) + " " +  PreferredPosition); 
        }
    }
}
