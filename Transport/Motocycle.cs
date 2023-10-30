using System.Drawing;
using System.Reflection;

namespace TransportCompany.Transport
{
    public class Motocycle : Transport
    {
        public Motocycle(int _moveSpeed, string _color, string _model, string _rightsCategory, bool _rent, int _wheels, string _motor)
        {
            MoveSpeed = _moveSpeed;
            Color = _color;
            Model = _model;
            RightsCategory = _rightsCategory;
            Rent = _rent;
            Wheels = _wheels;
            Motor = _motor;
        }
    }
}