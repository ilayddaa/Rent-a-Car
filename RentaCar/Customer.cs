using System;

namespace RentaCar;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }

    public Customer(int id, string name, string surname, string phoneNumber)
    {
        Id = id;
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;
    }
}
