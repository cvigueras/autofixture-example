namespace Autofixture.Example.App
{
    public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public int Age { get; set; }
        

        public User(string name,
                    string lastName,
                    string city,
                    string phoneNumber,
                    string gender,
                    string email,
                    string mobileNumber,
                    int age)
        {
            Name = name;
            LastName = lastName;
            City = city;
            PhoneNumber = phoneNumber;
            Gender = gender;
            Email = email;
            MobileNumber = mobileNumber;
            Age = age;
        }
    }
}
