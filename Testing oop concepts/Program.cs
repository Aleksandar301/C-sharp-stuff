namespace Testing_oop_concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating the players
            Player player1 = new Player();
            Player player2 = new Player("Aleksandar", 23);

            // checking the second player name and age
            Console.WriteLine("Checking the first players stats");
            Console.WriteLine("Name: " + player2.GetName() + "\nAge: " + player2.GetAge());

            // Changing the first players name and age
            player1.SetName("Marko");
            player1.SetAge(19);

            // checking the first players name and age
            Console.WriteLine("Checking the second players stats");
            Console.WriteLine("Name: " + player1.GetName());
            Console.WriteLine("Age: " + player1.GetAge());
        }

        class Player {
            // player variables
            private string name = "Undefined";
            private int age = 0;

            // constructors
            public Player() 
            {
                Console.WriteLine("The player has been created!");
            }
            public Player(string name, int age)
            {
                this.name = name;
                this.age = age;
                Console.WriteLine($"The Player with name {name} and age {age} is created!");
            }
            // setters
            public void SetName(string name) 
            {
                this.name = name;
            }
            public void SetAge(int age)
            {
                this.age = age;
            }
            // getters
            public string GetName()
            {
                return this.name;
            }
            public int GetAge()
            {
                return this.age;
            }
        }
    }
}