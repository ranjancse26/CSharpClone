using System;

namespace CSharpClone
{
    [Serializable]
    public class Person : ICloneable
    {
        public Person()
        {
            PersonAddress = new Address();
        }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Address PersonAddress { get; set; }

        public object Clone()
        {
            Person newPerson = (Person)this.MemberwiseClone();
            newPerson.PersonAddress = (Address)this.PersonAddress.Clone();
            return newPerson;
        }
    }

    [Serializable]
    public class Address : ICloneable
    {
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
