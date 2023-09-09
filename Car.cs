using System;

public class car
{

//Protected instances variables can be accessed in the class and classes which inherit from this class
protected string make;
protected string model;
protected string fuelType;
protected int engineSize;
protected int numSeats;
protected double topSpeed;

//Default constructor
public car()
{

}

//Constructor whic requires 5 parameters to be passednt engineSize, i
public car(string make, string model, string fuelType, int numSeats)

{
  this.make=make;
  this.model=model;
  this.fuelType=fuelType;
  this.engineSize=engineSize;
  this.numSeats=numSeats;
}

//Constructor with fields
public car(string make, string model, string fuelType, int engineSize, int numSeats, double topSpeed)
{
  this.make=make;
  this.model=model;
  this.fuelType=fuelType;
  this.engineSize=engineSize;
  this.numSeats=numSeats;
  this.topSpeed=topSpeed;
}

//GET/SET property methods 
public string Make
{
  get
  {
    return make;
  }

  set
  {
    make=value;
  }
}

public string Model
{
  get
  {
    return model;
  }

  set
  {
    model=value;
  }
}

public string FuelType
{
  get
  {
    return fuelType;
  }

  set
  {
    fuelType=value;
  }
}

public int EngineSize
{
  get
  {
    return engineSize;
  }

  set
  {
    engineSize=value;
  }
}

public int NumSeats
{
  get
  {
    return numSeats;
  }

  set
  {
    numSeats=value;
  }
}

public double TopSpeed
{
  get
  {
    return topSpeed;
  }
  
 
}

//This method will increase the top speed by 
public void increaseTopSpeed(int increaseAmount)
{
  if(increaseAmount>20)
  {
    Console.WriteLine("You can only increase the top speed by 20.");
  }
  else
  {
    if((topSpeed+increaseAmount)>140)
    {
      topSpeed=140;
    }
    else
    {
      topSpeed=topSpeed+increaseAmount;
    }
  }
}
}
