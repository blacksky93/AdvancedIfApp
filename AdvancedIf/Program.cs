namespace AdvancedIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is your first name: ");
            string? firstname = Console.ReadLine();

            //Console.Write("What is your last name: ");
            //string? lastName = Console.ReadLine();

            //if (firstName.ToLower() == "tim" && 
            //    lastName.ToLower() == "corey")
            //{
            //    Console.WriteLine("Hello Mr.Corey");
            //}
            //else if (firstName.ToLower() == "tim")
            //{
            //    Console.WriteLine("Hello, you have a cool first name.");
            //}
            //else if (lastName.ToLower() == "corey")
            //{
            //    Console.WriteLine("You have a cool last name.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry you don't have a cooler name!");
            //}



            int age = 100;
            if (age >= 100)
            {
                Console.WriteLine("You are up there in years.");
            }


        }
    }
}
