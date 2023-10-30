using System.Drawing;
using System.Reflection;

namespace TransportCompany.Transport
{
    public class Boat : Transport
    {
        private int boatWheel;
        public override int Wheels { get { return boatWheel; } set { boatWheel = 0; } }
        public Boat(int _moveSpeed, string _color, string _model, string _rightsCategory, bool _rent, int _wheels, string _motor)
        {
            MoveSpeed = _moveSpeed;
            Color = _color;
            Model = _model;
            RightsCategory = _rightsCategory;
            Rent = _rent;
            Wheels = _wheels;
            Motor = _motor;
        }

        public override void Print(List<Transport> boat)
        {
            int number = 1;
            foreach (Boat _boat in boat)
            {

                Console.WriteLine(number + "." + " " + _boat.Model + " " + _boat.Color + " " + _boat.MoveSpeed + " " + _boat.Motor);
                number++;

            }
        }
    }
}
