using System;

namespace challenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            // your code goes below

            if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days \nRenew Now and save 10%");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day! \nRenew now and save 20%");
                discountPercentage = 20;
            }
            if (discountPercentage == 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%");
            }
        }
    }
}
