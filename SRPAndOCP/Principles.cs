using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPAndOCP
{
    /// <summary>
    /// Application of SRP
    /// The pharmacySubFee class only takes care of charges for both customers and hospitals
    /// </summary>
    public class PharmacySubFee : Hospital
     {                                                          
        public double HospitalCharge { get;} = 3000;
        public double CustomerCharge { get;} = 4000;
        public double HospitalDiscount { get; } = 0.3;
        public double CustomerDiscount { get; } = 0.2;

    }


    /// <summary>
    /// Customers inherit PharmacySub fee and can implement objects of both Pharmacy and hospital since Pharmacy also inherits Hospital
    /// </summary>
    public class Customer : PharmacySubFee
    {
        public string CustomerName { get; set; }
        public double CustomerRegFee { get; set; }
        public void GenerateFee()
        {

            try
            {
                double referenceFee;
                double basicFee = CustomerCharge + ReferenceCharge;

            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }
            

        }
    }

    /// <summary>
    /// Application of Open/Closed Principle; The hospital class extends the Discount class without modifying it.
    /// </summary>
    /// <returns></returns>
    public class Hospital:Discount
    {
        public string HospitalName { get; set; }
        public double ReferenceCharge { get; } = 2000;

        public double HospitalRegFee { get; set; }



        /// <summary>
        /// to calculate class for each class of user
        /// </summary>
        /// <returns></returns>
        public override double GenerateDiscounta()
        {
            PharmacySubFee myPharmFee = new PharmacySubFee();
            double hospitalFee;
            hospitalFee = myPharmFee.HospitalCharge - (myPharmFee.HospitalDiscount * myPharmFee.HospitalCharge);
            return hospitalFee;

        }
        public override double GenerateDiscountb()
        {
            PharmacySubFee myPharmFee = new PharmacySubFee();
            double customerFee;
            customerFee = myPharmFee.CustomerCharge - (myPharmFee.CustomerDiscount * myPharmFee.CustomerCharge);
            return customerFee;

        }

        }





    /// <summary>
    /// to calculate discount for hospital and customer
    /// </summary>
    public abstract class Discount 

    {
        public abstract double GenerateDiscounta ();
        public abstract double GenerateDiscountb();
    }
}
