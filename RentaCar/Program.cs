using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
using RentaCar;

Rental.AddCar(new Car(1, "opel", "astra", "34lyd58", false, 10000));
Rental.AddCustomer(new Customer(2, "burak", "osek", "531"));
Rental.ArabaListe();
Rental.Hire(2, 1);
