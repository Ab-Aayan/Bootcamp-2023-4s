using System.Text;
using System.Threading.Tasks;


namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert Your Card");
            Console.WriteLine("Wait a few seconds");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Enter Your PIN >>>>");
            int pin = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Amount");
            int money=int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Welcome To ATM >>>>");
            Console.WriteLine("Please Enter Your Pin");
            int pass = int.Parse(Console.ReadLine());

            if(pass == pin)
            {
                Console.WriteLine("Choose An Option >>>>");
                Console.WriteLine("1.Cash Withdrawn \n2.Balance Check \n3.Add Money \n4.Pin Change");
                Console.WriteLine("Please Enter The Number Only >>>");
                string option = Console.ReadLine();
                if(option == "1")
                {
                    Console.WriteLine("Enter The Amount You Want To Withdrawn >>");
                    int amount=int.Parse(Console.ReadLine());
                    if(amount <= money)
                    {
                        Console.WriteLine("1.Yes \n 2.No");
                        Console.WriteLine("Please Enter the Number Only >>");
                        int show = int.Parse(Console.ReadLine());

                        if(show == 1)
                        {
                            Console.WriteLine("Your Tramsaction has been succesfully");
                            Thread.Sleep(3000);

                            Console.WriteLine("Your Currenet Amount is: {0}", money - amount);

                        }
                        else
                        {
                            Console.WriteLine("Thanks for Using Our ATM Service >>");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your Don't Have Enough Balance >>");
                    }
                }
                if (option == "2")
                {
                    Console.WriteLine("Your Currenet Amount is: {0}", money);

                }

                if (option == "3")
                {
                    Console.WriteLine("Enter The Amount You Want To Add >>");
                    int addamount = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your Currenet Amount is: {0}", money + addamount);

                }
                if (option == "4")
                {
                    Console.WriteLine("Enter Your Old PIN Number >>");
                    int oldpin = int.Parse(Console.ReadLine());
                    if (oldpin== pin)
                    {
                        Console.WriteLine("Enter Your New PIN");
                        int newpin = int.Parse(Console.ReadLine());
                        Console.WriteLine("Wait a few seconds");
                        Thread.Sleep(5000);
                        Console.WriteLine("Your PIN was successfully changed");



                    }
                    else
                    {
                        Console.WriteLine("Sorry Your Old PIN is Incorrect");

                    }

                }
               

            }
            else
            {
                Console.WriteLine("Please Enter A Valid PIN >>>>");

            };
            Console.ReadLine();

        }
    }
}