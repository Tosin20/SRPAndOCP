namespace SRPAndOCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome on board");
            Console.WriteLine("Select Hospital-1,Customer-2");
            string choice = Console.ReadLine();
            choice.ToLower();



            if (choice == "hospital")    // condition for type of uer; hospital or customer
            {
                Hospital hospital = new Hospital();
                Console.WriteLine("Enter Hospital Name: ");
                hospital.HospitalName = Console.ReadLine();
                string firstHosp = hospital.HospitalName;
                Console.WriteLine("Your discounted fee is:" + hospital.GenerateDiscounta());
            }
            else if (choice == "customer")
            {
                Customer customer = new Customer();
                Console.WriteLine("Enter Customer Name: ");
                customer.CustomerName = Console.ReadLine();
                string firstcust = customer.CustomerName;
                Console.WriteLine("Your discounted fee is: " + customer.GenerateDiscountb());
            }

           

         }



            
          
       
    }
}