using System;

class mpv : car
{
  private bool fourWheelDrive;

  public mpv(string make, string model, string fuelType, int engineSize, int numSeats, double topSpeed, bool fourWheelDrive): base (make, model, fuelType, engineSize, numSeats, topSpeed)
  {
    this.fourWheelDrive = fourWheelDrive;
  }

}
