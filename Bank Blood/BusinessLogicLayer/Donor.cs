using System;
using System.Reflection;

namespace Bank_Blood.BusinessLogicLayer
{
    public class Donor
    {
        public int DonorId { get; set; }
        public string LastName { get; set; }
        public string ForstName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public int BloodId { get; set; }
        public DateTime Date { get; set; }
        public string ProfilePicture { get; set; }


    }
}
