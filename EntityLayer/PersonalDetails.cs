using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{

    public class PersonalDetails
    {
        public string customerName;
        public string CustomerName
        {

            get
            {
                return customerName;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a valid Name");
                }
                else
                {
                    customerName = value;
                }
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {

            get
            {
                return phoneNumber;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a valid Phone Number");
                }
                else
                {
                    phoneNumber = value;
                }
            }
        }
        private string pan;
        public string PAN
        {

            get
            {
                return pan;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a valid PAN Number");
                }
                else
                {
                    pan = value;
                }
            }
        }

        public string aadhar;
        public string Aadhar
        {

            get
            {
                return aadhar;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a Valid Aadhar Number");
                }
                else
                {
                    aadhar = value;
                }
            }
        }


        public DateTime DOB { get; set; }

        public string email;
        public string Email
        {

            get
            {
                return email;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a valid Email ID");
                }
                else
                {
                    email = value;
                }
            }
        }

        public string address;
        public string Address
        {

            get
            {
                return address;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a valid address");
                }
                else
                {
                    address = value;
                }
            }
        }
        public int AccountId { get; set; }



        public PersonalDetails()
        {
            //CustomerName = "Not Mentioned";
            //PhoneNumber = "Not mentioned";
            //PAN = "Not Mentioned";
            //Aadhar = "Not Mentioned";
            //DOB = new DateTime(2000, 01, 01);
            //Email = "Not Mentioned";
            //Address = "Not Mentioned";
            //AccountId = 0;


        }
        public PersonalDetails(string customername, string phonenumber, string pan, string aadhar, DateTime dob, string email, string address)
        {
            CustomerName = customername;
            PhoneNumber = phonenumber;
            PAN = pan;
            Aadhar = aadhar;
            DOB = dob;
            Email = email;
            Address = address;
        }
    }
}