using System;

namespace practice3
{
  class Person
  {
    public string firstName;
    public string lastName;
    public int age;
    public enum Genders : int { Male, Female };
    public Genders gender;
    public Person(string _firstName, string _lastName, int _age, Genders _gender)
    {
      firstName = _firstName;
      lastName = _lastName;
      age = _age;
      gender = _gender;
    }
    public override string ToString()
    {
      return firstName + " " + lastName + " (" + gender + "), age " + age;
    }
  }

  class Manager : Person
  {
    public string phoneNumber;
    public string officeLocation;
    public Manager(string _firstName, string _lastName, int _age, Genders _gender, string
_phoneNumber, string _officeLocation) : base(_firstName, _lastName, _age, _gender)
    {
      phoneNumber = _phoneNumber; 
      officeLocation = _officeLocation;
    }
    public override string ToString()
    {
      return base.ToString() + ", " + phoneNumber + ", " + officeLocation;
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Manager p = new Manager("Tony", "Allen", 32, Manager.Genders.Male,"88005553535","Wall Street");
      Console.WriteLine(p);
    }
  }
}
