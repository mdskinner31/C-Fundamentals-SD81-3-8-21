using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycles, Spaceship, Planes, Boats }
    public class Vehicle
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public double Mileage { get; set; }

        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set; }

        public Vehicle() { }

        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = typeOfVehicle;

        }
        public void TrunOn()
        {
            IsRunning = true;
            Console.WriteLine("You turn the vehicle on.");
        }
        public void TurnOff()
        {
            Console.WriteLine("You turn off the vehicle.");
            IsRunning = false;
        }
        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }

        public void IndicateRight()
        {
            RightIndicator.TurnOnFlasher();
            LeftIndicator.TurnOffFlasher();
        }

        public void IndiateLeft()
        {
            LeftIndicator.TurnOnFlasher();
            RightIndicator.TurnOffFlasher();
        }
        public void TurnOnHazards()
        {
            RightIndicator.TurnOnFlasher();
            LeftIndicator.TurnOnFlasher();

        }
        public void ClearIndicator()
        {
            RightIndicator.TurnOffFlasher();
            LeftIndicator.TurnOffFlasher();

        }






    }
    public class Indicator
    {
        public bool IsFlashing { get; private set; }

        public void TurnOnFlasher()
        {
            IsFlashing = true;

        }
        public void TurnOffFlasher()
        {

            IsFlashing = false;
          
            

            
        }
    }

    

}
