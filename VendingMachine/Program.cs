namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Items List:");
            Console.WriteLine("[A] " + "Water " + "- 1.00lv.");
            Console.WriteLine("[B] " + "Brownie " + "- 2.50lv.");
            Console.WriteLine("[C] " + "Napkins " + "- 0.50lv.");
            Console.WriteLine("Please choose an item!");


            string input = Console.ReadLine();

            if (input == "a" || input == "A")
            {
                Console.WriteLine("You've selected water, would you like to buy something else?");
                string input2 = Console.ReadLine();
                if (input2 == "yes" || input2 == "y" || input2 == "Yes" )
                {

                }
            }

            else if (input == "b" || input == "b")
            {
                Console.WriteLine("You've selected Brownie, would you like to buy something else?");
                string input2 = Console.ReadLine();
                if (input2 == "yes" || input2 == "y" || input2 == "Yes")
                {

                }
            }

            else if (input == "c" || input == "c")
            {
                Console.WriteLine("You've selected Napkins, would you like to buy something else?");
                string input2 = Console.ReadLine();
                if (input2 == "yes" || input2 == "y" || input2 == "Yes")
                {

                }
            }

        }
    }
}
