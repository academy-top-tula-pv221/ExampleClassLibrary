using System.Text.Json.Serialization;

namespace ExampleClassLibrary
{
    public partial class User
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

        public override bool Equals(Object? other)
        {
            if (other == null) return false;
            
            return this.Name!.Equals((other as User)?.Name) && this.Age.Equals((other as User)?.Age);
        }

        public override int GetHashCode()
        {
            return Age!.GetHashCode();
        }
    }
}