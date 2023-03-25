using System;

namespace Bank_Blood.BusinessLogicLayer
{
    class AppUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public DateTime DataAdded { get; set; }
        public string ProfilePicture { get; set; }
    }
}
