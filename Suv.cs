using System;

//The suv class inherits 
public class suv : car
{
  private int numGears;
  private string engineType;

  //Default constructor
  public suv()
  {

  }

  //This constructor calls the base constructor Car to initialise the variables passed through the SUV constructor call
  public suv(string make, string model, string fuelType, int engineSize, int numSeats, double topSpeed, int numGears, string engineType): base(make, model, fuelType, engineSize, numSeats, topSpeed)
  {
    this.numGears = numGears;
    this.engineType = engineType;
  }

  public int NumGears
  {
    get
    {
      return numGears;
    }
    set
    {
      this.numGears = numGears;
    }
  }

  public string EngineType
  {
    get
    {
      return engineType;
    }
    set
    {
      this.engineType = value;
    }
  }
}
