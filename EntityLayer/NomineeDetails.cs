using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class NomineeDetails
    {
        private string nomineeName;
        public string NomineeName
        {
            get
            {
                return nomineeName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please enter a Nominee Name");
                }
                else
                {
                    nomineeName = value;
                }
            }
        }

        public string relation;
        public string Relation
        {
            get
            {
                return relation;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please mention the relation between Nominee and you");
                }
                else
                {
                    relation = value;
                }
            }
        }

        private string phonenumber;
        public string PhoneNumber
        {
            get
            {
                return phonenumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please enter a Valid Phone number of Nominee");
                }
                else
                {
                    phonenumber = value;
                }
            }
        }

        public string nomineeAddress;
        public string NomineeAddress
        {

            get
            {
                return nomineeAddress;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a valid Email ID");
                }
                else
                {
                    nomineeAddress = value;
                }
            }
        }
        public int AccountId { get; set; }

        public NomineeDetails()
        {
            //NomineeName = "Not Metioned";
            //Relation = "Not Metioned";
            //PhoneNumber = "Not Metioned";
            //NomineeAddress = "Not Metioned";
            //AccountId = 0;
        }
        public NomineeDetails(string nomineename, string relation, string phonenumber, string nomineeadress)
        {
            NomineeName = nomineename;
            Relation = relation;
            PhoneNumber = phonenumber;
            NomineeAddress = nomineeadress;
        }
    }
}