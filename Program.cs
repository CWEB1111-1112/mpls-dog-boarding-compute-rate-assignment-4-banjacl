using System;
//Jackson Band 4/16/21      //I tried pulling down the files from the repository, but it wouldn't run with my version of .net Core so I had to create my own application.
namespace assignment_four
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global Declarations
            int numOfDays, serviceTotal;
            string dogName, services, response;

            Console.WriteLine("Welcome to the Dog Boarding Service Cost Calculator!");
            Console.WriteLine("What is your dogs name?");
            dogName = Console.ReadLine();
            Console.WriteLine($"How many days will {dogName} be with us?");
            numOfDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Will you be using any add on service codes today? (yes or no)");
            services = Console.ReadLine();
            while(services != "yes" || services != "no"){
                Console.WriteLine("Please enter either yes or no.");
                services = Console.ReadLine();
                if(services == "yes" || services == "no"){
                    break;
                }
            }
            if(services == "no"){
                serviceTotal = computeRate1(numOfDays);
                Console.WriteLine($"The total cost for {dogName} for {numOfDays} days with no additional services wll be ${serviceTotal}.");
            }else if(services == "yes"){
                Console.WriteLine("Please enter A for bathing and grooming services, or C for bathing only.");
                response = Console.ReadLine();
                while(response != "A" || response != "C"){
                    Console.WriteLine("Invalid code. Please enter either A or C.");
                    response = Console.ReadLine();
                    if(response == "A" || response == "C"){
                        break;
                    }
                }
                
                serviceTotal = computeRate2(numOfDays, response);
                Console.WriteLine($"The total cost for {dogName} for {numOfDays} days with add-on code [{response}] will be ${serviceTotal}.");
            }else{
                Console.WriteLine("Please enter either yes or no.");
            }
        }

        //Overloaded method with one argument
        static int computeRate1(int numOfDays)
        {
            int TOTAL;
            TOTAL = numOfDays * 75;

            return TOTAL;
        }



        //Overloaded method with two arguments
        static int computeRate2(int numOfDays, string response)
        {
            int TOTAL = 0;
            
            if(response == "A"){
                TOTAL = numOfDays * 169;
            }else if(response == "C"){
                TOTAL = numOfDays * 112;
            }

            return TOTAL;
            
        }
    }
}

