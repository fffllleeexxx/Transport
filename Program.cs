using System.Diagnostics;
using TransportCompany.Transport;

List<Transport> transport = new List<Transport>();


//лодки
List<Boat> boat = new List<Boat>();
Boat boat1 = new Boat(100, "black", "vb123", "Z1", true, 0, "v86");
Boat boat2 = new Boat(10, "red", "M500", "Z1", true, 0, "v86");
Boat boat3 = new Boat(10000, "green", "ZXCQWE", "Z1", true, 0, "v86");
boat.Add(boat1);
boat.Add(boat2);
boat.Add(boat3);
transport.Add(boat1);
transport.Add(boat2);
transport.Add(boat3);


//машины
List<Car> car = new List<Car>();
Car car1 = new Car(150, "black", "a6", "Y1", true, 0, "v86");
Car car2 = new Car(210, "red", "Q5", "Y1", true, 0, "v86");
Car car3 = new Car(230, "green", "jklsdngkj", "Y1", true, 0, "v86");
car.Add(car1);
car.Add(car2);
car.Add(car3);
transport.Add(car1);
transport.Add(car2);
transport.Add(car3);


//велосипеды
List<Bicycle> bicycle = new List<Bicycle>();
Bicycle bic1 = new Bicycle(150, "black", "a6", "Y1", true, 0, "v86");
Bicycle bic2 = new Bicycle(210, "red", "Q5", "Y1", true, 0, "v86");
Bicycle bic3 = new Bicycle(230, "green", "jklsdngkj", "Y1", true, 0, "v86");
bicycle.Add(bic1);
bicycle.Add(bic2);
bicycle.Add(bic3);
transport.Add(bic1);
transport.Add(bic2);
transport.Add(bic3);


//мотоциклы
List<Motocycle> motocycle = new List<Motocycle>();
Motocycle moto1 = new Motocycle(150, "black", "a6", "Y1", true, 0, "v86");
Motocycle moto2 = new Motocycle(210, "red", "Q5", "Y1", true, 0, "v86");
Motocycle moto3 = new Motocycle(230, "green", "jklsdngkj", "Y1", true, 0, "v86");
motocycle.Add(moto1);
motocycle.Add(moto2);
motocycle.Add(moto3);
transport.Add(moto1);
transport.Add(moto2);
transport.Add(moto3);

//самокаты
List<Scooter> scooter = new List<Scooter>();
Scooter sct1 = new Scooter(150, "black", "a6", "Y1", true, 0, "v86");
Scooter sct2 = new Scooter(210, "red", "Q5", "Y1", true, 0, "v86");
Scooter sct3 = new Scooter(230, "green", "jklsdngkj", "Y1", true, 0, "v86");
scooter.Add(sct1);
scooter.Add(sct2);
scooter.Add(sct3);
transport.Add(sct1);
transport.Add(sct2);
transport.Add(sct2);


while (true)
{
    int freeBoatCount = boat.Count;
    int freeCarCount = car.Count;
    int freeBicCount = bicycle.Count;
    int freeMotoCount = motocycle.Count;
    int freeSctCount = scooter.Count;

    Console.WriteLine("Какой транспорт вы хотите арендовать? На выбор есть лодки, машины, велосипеды, мотоциклы, самокаты. ");
    string transportType = Console.ReadLine();
    if (transportType == "boat" || transportType == "Boat" || transportType == "лодка")
    {
        Console.WriteLine($"Сейчас свободны {freeBoatCount} лодки:");
        int number = 1;
        foreach (Boat _boat in boat)
        {

            Console.WriteLine(number + "." + " " + _boat.Model + " " + _boat.Color + " " + _boat.MoveSpeed + " " + _boat.Motor + " " + _boat.Wheels);
            number++;

        }

        Console.WriteLine("Какую лодку выбираете? (напишите номер)");
        int targetNumber = Convert.ToInt32(Console.ReadLine());
        if (targetNumber <= freeBoatCount)
        {
            Console.WriteLine($"За вами забронирована лодка номер {targetNumber}");
            boat[targetNumber - 1].Rent = false;
            boat.Remove(boat[targetNumber - 1]);
        }
        else { Console.WriteLine("Нет такой лодки"); }

        Console.WriteLine("Хорошей поездки");
    }
    else if (transportType == "Car" || transportType == "car" || transportType == "машина")
    {
        int number = 1;
        Console.WriteLine($"Сейчас свободны {freeCarCount} машины:");
        foreach (Car _car in car)
        {

            Console.WriteLine(number + "." + " " + _car.Model + " " + _car.Color + " " + _car.MoveSpeed + " " + _car.Motor);
            number++;

        }

        Console.WriteLine("Какую машину выбираете? (напишите номер)");
        int targetNumber = Convert.ToInt32(Console.ReadLine());
        if (targetNumber <= freeCarCount)
        {
            Console.WriteLine($"За вами забронирована машина номер {targetNumber}");
            car[targetNumber - 1].Rent = false;
            car.Remove(car[targetNumber - 1]);
        }
        else { Console.WriteLine("Нет такой машины"); }

        Console.WriteLine("Хорошей поездки");
    }
    else if (transportType == "bicycle" || transportType == "Bicycle" || transportType == "велосипед")
    {
        int number = 1;
        Console.WriteLine($"Сейчас свободны {freeBicCount} велосипеда:");
        foreach (Bicycle bic in bicycle)
        {

            Console.WriteLine(number + "." + " " + bic.Model + " " + bic.Color + " " + bic.MoveSpeed + " " + bic.Motor);
            number++;

        }

        Console.WriteLine("Какой велосипед выбираете? (напишите номер)");
        int targetNumber = Convert.ToInt32(Console.ReadLine());
        if (targetNumber <= freeBicCount)
        {
            Console.WriteLine($"За вами забронирован велосипед номер {targetNumber}");
            bicycle[targetNumber - 1].Rent = false;
            bicycle.Remove(bicycle[targetNumber - 1]);
        }
        else { Console.WriteLine("Нет такого велосипеда"); }

        Console.WriteLine("Хорошей поездки");
    }
    else if (transportType == "motocycle" || transportType == "Motocycle" || transportType == "мотоцикл")
    {
        int number = 1;
        Console.WriteLine($"Сейчас свободны {freeMotoCount} мотоцикла:");
        foreach (Motocycle moto in motocycle)
        {

            Console.WriteLine(number + "." + " " + moto.Model + " " + moto.Color + " " + moto.MoveSpeed + " " + moto.Motor);
            number++;

        }

        Console.WriteLine("Какой мотоцикл выбираете? (напишите номер)");
        int targetNumber = Convert.ToInt32(Console.ReadLine());
        if (targetNumber <= freeMotoCount)
        {
            Console.WriteLine($"За вами забронирован велосипед номер {targetNumber}");
            motocycle[targetNumber - 1].Rent = false;
            motocycle.Remove(motocycle[targetNumber - 1]);
        }
        else { Console.WriteLine("Нет такого мотоцикла"); }

        Console.WriteLine("Хорошей поездки");
    }
    else if (transportType == "scooter" || transportType == "Scooter" || transportType == "самокат")
    {
        int number = 1;
        Console.WriteLine($"Сейчас свободны {freeSctCount} самоката:");
        foreach (Scooter sct in scooter)
        {

            Console.WriteLine(number + "." + " " + sct.Model + " " + sct.Color + " " + sct.MoveSpeed + " " + sct.Motor);
            number++;

        }

        Console.WriteLine("Какой самокат выбираете? (напишите номер)");
        int targetNumber = Convert.ToInt32(Console.ReadLine());
        if (targetNumber <= freeSctCount)
        {
            Console.WriteLine($"За вами забронирован самокат номер {targetNumber}");
            scooter[targetNumber - 1].Rent = false;
            scooter.Remove(scooter[targetNumber - 1]);
        }
        else { Console.WriteLine("Нет такого самоката"); }

        Console.WriteLine("Хорошей поездки");
    }

}
