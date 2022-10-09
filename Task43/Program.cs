Console.Write("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());


double XСoordinate(double b1, double b2, double k1, double k2)
{
    double x = (b1-b2) / (k2-k1);
    return x;
}

double YСoordinate(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}

double x = XСoordinate(b1,b2,k1,k2);
double y = YСoordinate(b1,k1,x);
Console.WriteLine($"Точки пересечения двух прямых -> [{x};{y}]");


