using System;

class MainClass 
{
  public static void Main (string[] args) 
  
  {
    string make, model;
    car [] garage = new car[4];
    //Create an instance of a SUV 
    for(int i=0;i<4;i++)
    {
      car newCar = new car();
      Console.WriteLine("Enter car make");
      make = Console.ReadLine();
      newCar.Make = make;
      Console.WriteLine("Enter car model");
      model = Console.ReadLine();
      newCar.Model = model;
      garage[i] = newCar;
    }
    int numSeats = 0;
    foreach(car newCar in garage)
    {
      if(newCar.Make=="seat")
      {
        numSeats++;
      }
    }

    Console.WriteLine("The number of seats is "+numSeats);


    
  }
}
