// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.WriteLine("Hello, World!");
double Xa = PrintMessageGetNumber ("Введите X первого числа");
double Ya = PrintMessageGetNumber ("Введите Y первого числа");
double Za = PrintMessageGetNumber ("Введите Z первого числа");
double Xb = PrintMessageGetNumber ("Введите X второго числа");
double Yb = PrintMessageGetNumber ("Введите Y второго числа");
double Zb = PrintMessageGetNumber ("Введите Z второго числа");

Console.WriteLine(Distance(Xa, Xb, Ya, Yb, Za, Zb));

double PrintMessageGetNumber (string message)
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine());
  return number;
}

double Distance (double X1, double X2, double Y1, double Y2, double Z1, double Z2)
{
  double result = Math.Sqrt(Math.Pow(X1-X2, 2) + Math.Pow(Y1-Y2, 2) + Math.Pow(Z1-Z2, 2));
  return result;
}
