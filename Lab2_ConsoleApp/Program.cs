using System.Numerics;
class Pupil{
    public virtual void Study(){
        Console.WriteLine("Pupil is studying.");
    }

    public virtual void Read(){
        Console.WriteLine("Pupil is reading.");
    }

    public virtual void Write(){
        Console.WriteLine("Pupil is writing.");
    }

    public virtual void Relax(){
        Console.WriteLine("Pupil is relaxing.");
    }
}

class ExcelentPupil: Pupil{    
    public override void Study()
    {
        Console.WriteLine("Excellent Pupil is studying very hard.");
    }

    public override void Read()
    {
        Console.WriteLine("Excellent Pupil is reading quickly and thoroughly.");
    }

    public override void Write()
    {
        Console.WriteLine("Excellent Pupil is writing with precision.");
    }

    public override void Relax()
    {
        Console.WriteLine("Excellent Pupil is rarely relaxing.");
    }
}

class GoodPupil: Pupil{    
    public override void Study()
    {
        Console.WriteLine("Good Pupil is studying very well.");
    }

    public override void Read()
    {
        Console.WriteLine("Good Pupil is reading normal.");
    }

    public override void Write()
    {
        Console.WriteLine("Good Pupil is writing well.");
    }

    public override void Relax()
    {
        Console.WriteLine("Good Pupil is often relaxing.");
    }
}
class BadPupil: Pupil{    
    public override void Study()
    {
        Console.WriteLine("Bad Pupil is studying very bad.");
    }

    public override void Read()
    {
        Console.WriteLine("Bad Pupil is reading very slowly.");
    }

    public override void Write()
    {
        Console.WriteLine("Bad Pupil is writing agly.");
    }

    public override void Relax()
    {
        Console.WriteLine("Bad Pupil is relaxing always.");
    }
}

class ClassRoom{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        // Гарантируем, что в классе всегда будет 4 ученика, даже если передано меньше
        this.pupils = new Pupil[4];

        for (int i = 0; i < pupils.Length && i < 4; i++)
        {
            this.pupils[i] = pupils[i];
        }

        // Если передано меньше 4 учеников, заполняем оставшиеся места базовыми Pupil
        for (int i = pupils.Length; i < 4; i++)
        {
            this.pupils[i] = new Pupil();
        }
    }
    public void ShowPupilsActions()
    {
        foreach (var pupil in pupils)
        {
            Console.WriteLine("---- Pupil Actions ----");
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine();
        }
    }
}


public class Vehicle
{
    public double X; // Координата X
    public double Y; // Координата Y
    public double Price; // Цена
    public double Speed; // Скорость
    public int YearOfManufacture; // Год выпуска

    // Конструктор базового класса
    public Vehicle(double x, double y, double price, double speed, int yearOfManufacture)
    {
        X = x;
        Y = y;
        Price = price;
        Speed = speed;
        YearOfManufacture = yearOfManufacture;
    }

    // Метод для вывода информации о транспортном средстве
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Координаты: ({X}, {Y})");
        Console.WriteLine($"Цена: {Price} USD");
        Console.WriteLine($"Скорость: {Speed} км/ч");
        Console.WriteLine($"Год выпуска: {YearOfManufacture}");
    }
}

public class Plane : Vehicle
{
    public double Altitude; // Высота полета
    public int PassengerCount; // Количество пассажиров

    // Конструктор для класса Plane
    public Plane(double x, double y, double price, double speed, int yearOfManufacture, double altitude, int passengerCount)
        : base(x, y, price, speed, yearOfManufacture)
    {
        Altitude = altitude;
        PassengerCount = passengerCount;
    }

    // Переопределенный метод для вывода информации о самолете
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Высота полета: {Altitude} м");
        Console.WriteLine($"Количество пассажиров: {PassengerCount}");
    }
}

public class Car : Vehicle
{
    // Конструктор для класса Car
    public Car(double x, double y, double price, double speed, int yearOfManufacture)
        : base(x, y, price, speed, yearOfManufacture)
    {
    }

    // Переопределенный метод для вывода информации об автомобиле
    public override void ShowInfo()
    {
        base.ShowInfo();
    }
}

public class Ship : Vehicle
{
    public int PassengerCount; // Количество пассажиров
    public string Port; // Порт приписки

    // Конструктор для класса Ship
    public Ship(double x, double y, double price, double speed, int yearOfManufacture, int passengerCount, string port)
        : base(x, y, price, speed, yearOfManufacture)
    {
        PassengerCount = passengerCount;
        Port = port;
    }

    // Переопределенный метод для вывода информации о корабле
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество пассажиров: {PassengerCount}");
        Console.WriteLine($"Порт приписки: {Port}");
    }
}


public class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}

public class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}

public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}

class Program{
    static void Main(){

        Console.WriteLine("Задание №1");

        Pupil excelentPupil = new ExcelentPupil();
        Pupil goodPupil = new GoodPupil();
        Pupil badPupil = new BadPupil();

        ClassRoom classRoom = new ClassRoom(excelentPupil, goodPupil, badPupil);
        
        classRoom.ShowPupilsActions();


        Console.WriteLine("Задание №2");

        Plane plane = new Plane(100, 200, 1000000, 850, 2015, 10000, 150);
        Car car = new Car(50, 60, 20000, 150, 2020);
        Ship ship = new Ship(300, 400, 500000, 50, 2010, 500, "New York");

        Console.WriteLine("Информация о самолете:");
        plane.ShowInfo();
        Console.WriteLine();

        Console.WriteLine("Информация об автомобиле:");
        car.ShowInfo();
        Console.WriteLine();

        Console.WriteLine("Информация о корабле:");
        ship.ShowInfo();
        Console.WriteLine();


        Console.WriteLine("Задание №3");

        const string proKey = "pro123";   // Пример ключа для Pro версии
        const string expKey = "exp123";   // Пример ключа для Expert версии

        Console.WriteLine("Введите ключ доступа (pro или exp), либо нажмите Enter для бесплатной версии:");
        string key = Console.ReadLine();

        DocumentWorker worker;

        if (key == proKey)
        {
            worker = new ProDocumentWorker();
            Console.WriteLine("Активирована версия Pro");
        }
        else if (key == expKey)
        {
            worker = new ExpertDocumentWorker();
            Console.WriteLine("Активирована версия Expert");
        }
        else
        {
            worker = new DocumentWorker();
            Console.WriteLine("Активирована бесплатная версия");
        }

        // Использование методов
        worker.OpenDocument();
        worker.EditDocument();
        worker.SaveDocument();
    }
}