using System;

namespace RentaCar;

public class Car
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Plate { get; set; }
    public Boolean RentalStatus { get; set; }
    public decimal DailyRate { get; set; }

    public Car(int id, string brand, string model, string plate, Boolean rentalStatus, decimal dailyRate)
    {
        Id = id;
        Brand = brand;
        Model = model;
        Plate = plate;
        RentalStatus = rentalStatus;
        DailyRate = dailyRate;
    }

    public string BilgiGoster()
    {
        return $"{Id} {Brand} {Model} {Plate} {RentalStatus} {DailyRate}";
    }
}

