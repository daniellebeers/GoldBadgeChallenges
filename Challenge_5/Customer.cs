using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public class Customer
    {

        //Constructor
        public Customer(string firstName, string lastName, string Type)
        {
            FirstName = firstName;
            LastName = lastName;
            Type = type;
        }

        //Properties

   
        public string FirstName
        {
            get => _firstName;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("You must enter a customer name.");

                _firstName = value;
            }
        }

        

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (value <= Potential)
                {
                    throw new Exception("Number of years cannot be negative or zero.");
                }
                _numOfYears = value;
            }
        }
        
        private string _firstName;
        public string FirstName
        {
            get => _firstName;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("You must enter a customer name.");

                _firstName = value;
            }
        }

        public string LastName { get; set; }

        
        //Methods -has to have a verb in it
        public string SendCustomerMessage()
        {
            string message = "Default message";

            if (Type >= Potential)
            {
                message = "Thank you for being a member. Here is a coupon!";
                return message;
            }


            if (NumOfYears >= )
            {
                message = "thank you for being a gold member";
                return message;
            }

            return "Default return";



         public override string ToString()
         {
            string stringToReturn = $"{CustomerID}\t{FirstName}\t{LastName}\t{NumOfYears}";
            return stringToReturn;
            }
    }

    }
}
