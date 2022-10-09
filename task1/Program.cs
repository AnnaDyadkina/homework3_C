// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Console.WriteLine("Hello, World!");
string number = PrintMessageInputNumber("Введите пятизначное число");
string result = "";
  if (number.Length == 5) {
    for (int i = number.Length-1; i >= 0; i--)
    {
      result = result + number[i];
    }
    if (result == number)
    {
      Console.WriteLine("Да");
    }
    else {
      Console.WriteLine("Нет");
    }
  }
  else
  {
    Console.WriteLine("Это не пятизначное число");
  }

string PrintMessageInputNumber (string message)
{
  Console.WriteLine(message);
  string value = Console.ReadLine();
  int numberValue = int.Parse(value);
  numberValue = Math.Abs(numberValue);
  value = numberValue.ToString();
  return value;
}
