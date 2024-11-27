using System;
using System.Diagnostics;

namespace RentaCar;

public static class Rental
{
    public static List<Car> Cars = new List<Car>();
    public static List<Customer> Customers = new List<Customer>();

    public static void AddCar(Car car) //method
    {
        Cars.Add(car);
    }
    public static void AddCustomer(Customer customer) //parametreli method
    {
        Customers.Add(customer);
    }

    public static void ArabaListe() //method
    {
        foreach (var araba in Cars)
        {
            Console.WriteLine(araba.BilgiGoster());
        }
    }

    public static void Hire(int customerId, int carId) //method
    {
        Car car = Cars.Find(a => carId == a.Id); //Find methodu ile araba id'sine göre araba bulunur.
        car.RentalStatus = true;
        Console.WriteLine($"Günlük kiralık bedeli: {car.DailyRate}");

        Customer customers = Customers.Find(c => customerId == c.Id);
        Console.WriteLine($"{customers.Name} kullanıcısına {car.Model} araba hayırlı olsun...");
    }
}

