using System.Text.Json.Serialization;

namespace ExampleClassLibrary
{
    public class User
    {
        public string? Name { set; get; }

        //[JsonIgnore]
        //[JsonPropertyName("UserAge")]
        public int Age { set; get; }
        public Address? Address { set; get; }
        public User() { }

        public User(string? name, int age)
        {
            Name = name;
            Age = age;
        }
        public User(string? name, int age, Address address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public override string ToString()
        {
            return $"User name: {Name}, age: {Age}, address: {Address}";
        }
    }
}