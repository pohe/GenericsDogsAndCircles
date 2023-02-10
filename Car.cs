using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles
{
    public class Car: IComparable<Car>
    {
        public string LicensePlate { get; set; }
        public string Model { get; set; }

        public Car(string licensePlate, string model)
        {
            LicensePlate= licensePlate;
            Model= model;
        }

        public override string ToString()
        {
            return $"{Model} {LicensePlate}";
        }

        public int CompareTo(Car? other)
        {
            //if (Model.CompareTo(other.Model)<0)
            //    return -1 ;
            //else if (Model.CompareTo(other.Model) > 0)
            //    return 1;
            //return 0 ;
            return Model.CompareTo(other.Model)*-1;
        }
    }
}
