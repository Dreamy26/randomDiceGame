using System;

namespace randomDiceGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            // you can also hard cold the roll using:
            // roll1 = 6;

            int total = roll1 + roll2 + roll3;

            // sum up three dice rools and save the value to the TOTAL varible
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


            // if total is greater than 14 "You Win!"
            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;   
                }
                else
                {
                    Console.WriteLine("You rolled doubles! +2 bonus total!");
                    total += 2;
                }
            }

            // if total is less grater than or equal to 15 "You Win!"
            if (total >= 16)
            {
                Console.WriteLine("You WIN a new CAR!");
            }
            else if (total >= 10)
            {
                Console.WriteLine("You Win a new LAPTOP");
            }
            else if (total == 7)
            {
                Console.WriteLine("You win a trip for two!");
            }
            else
            {
                Console.WriteLine("You win a Kitten!");
            }
        }
    }
}
