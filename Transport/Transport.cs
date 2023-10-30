namespace TransportCompany.Transport;

public abstract class Transport
{
    private int moveSpeed;
    private string color;
    private string model;
    private string rightsCategory;
    private bool rent;
    private int wheels;
    private string motor;

    public int MoveSpeed { get { return moveSpeed; } set { moveSpeed = value; } }
    public string Color { get { return color; } set { color = value; } }
    public string Model { get { return model; } set { model = value; } }
    public string RightsCategory { get { return rightsCategory; } set { rightsCategory = value; } }
    public bool Rent { get { return rent; } set { rent = value; } }
    public virtual int Wheels { get { return wheels; } set { wheels = value; } }
    public string Motor { get { return motor; } set { motor = value; } }

    public virtual void Print(List<Transport> tr)
    {
        int number = 1;
        foreach (Transport _tr in tr)
        {

            Console.WriteLine(number + "." + " " + _tr.Model + " " + _tr.Color + " " + _tr.MoveSpeed + " " + _tr.Motor);
            number++;

        }
    }

}
