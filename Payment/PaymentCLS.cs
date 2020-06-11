using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    public abstract class PaymentCLS
    {
        public abstract string PaymentType {get;}
        public abstract float PaymentAmount { get; set; }
    }   

    public class PhysicalProduct: PaymentCLS
    {
        private readonly string _paymentType;
        private float _paymentAmount;
        public PhysicalProduct(float amount)
        {
            _paymentType = "Physical Product";
            _paymentAmount = amount;
            // Generate Slip
            Console.WriteLine("Generated Slip of {0}", amount);
            Console.WriteLine("Sending Commision to Agent of {0} ", amount * .1);
        }
        public override string PaymentType
        {
            get { return _paymentType; }
        }

        public override float PaymentAmount
        {
            get { return _paymentAmount; }
            set { _paymentAmount = value; }
        }
    }

    class Books : PaymentCLS
    {
        private readonly string _paymentType;
        private float _paymentAmount;
        public Books(float amount)
        {
            _paymentType = "Books";
            _paymentAmount = amount;

            //Generate Duplicate
            Console.WriteLine("Generating Duplicate of {0} ", amount);
            Console.WriteLine("Sending Commision to Agent of {0} ", amount*.1);
        }
        public override string PaymentType
        {
            get { return _paymentType; }
        }

        public override float PaymentAmount
        {
            get { return _paymentAmount; }
            set { _paymentAmount = value; }
        }
    }

    class Membership : PaymentCLS
    {
        private readonly string _paymentType;
        private float _paymentAmount;
        public Membership(int amount)
        {
            _paymentType = "Membership";
            _paymentAmount = amount;
            //Activate Membership
            Console.WriteLine("Activating Membership with Recharge of {0} ", amount);
            Console.WriteLine("Calling a Function to send Mail");
        }
        public override string PaymentType
        {
            get { return _paymentType; }
        }

        public override float PaymentAmount
        {
            get { return _paymentAmount; }
            set { _paymentAmount = value; }
        }
    }

    class UpgradeMembership : PaymentCLS
    {
        private readonly string _paymentType;
        private float _paymentAmount;

        public UpgradeMembership(int amount)
        {
            _paymentType = "UpgradeMembership";
            _paymentAmount = amount;
            Console.WriteLine("Upgrading Membership on recharge of Amount {0} ", amount);
            Console.WriteLine("Calling a Function to send Mail");
        }
        public override string PaymentType
        {
            get { return _paymentType; }
        }

        public override float PaymentAmount
        {
            get { return _paymentAmount; }
            set { _paymentAmount = value; }
        }
    }

    class LearningSki : PaymentCLS
    {
        private readonly string _paymentType;
        private float _paymentAmount;
        public LearningSki(int amount)
        {
            _paymentType = "LearningSki";
            _paymentAmount = amount;
            // Free First Aid Video
            Console.WriteLine("Adding a Free Video");
        }
        public override string PaymentType
        {
            get { return _paymentType; }
        }

        public override float PaymentAmount
        {
            get { return _paymentAmount; }
            set { _paymentAmount = value; }
        }
    }

    public abstract class PaymentTypeFact
    {
        public abstract PaymentCLS GetPayment();
    }

    // Physical Product
    public class PhysicalProductFact: PaymentTypeFact
    {
        private int amount;
        public PhysicalProductFact(int amt)
        {
            amount = amt;
        }
        public override PaymentCLS GetPayment()
        {
            return new PhysicalProduct(amount);
        }
    }

    // Books
    class BooksFact : PaymentTypeFact
    {
        private int amount;
        public BooksFact(int amt)
        {
            amount = amt;
        }
        public override PaymentCLS GetPayment()
        {
            return new Books(amount);
        }
    }
}
