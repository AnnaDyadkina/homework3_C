// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int value = PrintMessageGetNumber("Введите число");
string result = "";
switch (value)
{
  case > 0:
  for (int i=1; i<=value; i++)
  {
    if (i==value) {
      result = result + Math.Pow(i, 3);
    }
    else{
      result = result + Math.Pow(i, 3) + ",";
    }
  }
  break;
  case < 0:
  for (int i=-1; i>=value; i--)
  {
    if (i==value) {
      result = result + Math.Pow(i, 3);
    }
    else{
      result = result + Math.Pow(i, 3) + ",";
    }
  }
  break;
  default:
    result = "0";
    break;  
}

Console.WriteLine(result);
int PrintMessageGetNumber (string message)
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine());
  return number;
}
