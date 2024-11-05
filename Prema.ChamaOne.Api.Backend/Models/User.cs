namespace Prema.ChamaOne.Api.Backend.Models
{

    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Enabled { get; set; }
        public Attributes Attributes { get; set; }
    }


    public class Attributes
    {
        public int MemberId { get; set; }
    }

    public class UserData
    {
        public int member_id { get; set; }
        public string user_id { get; set; }
    }
}
