// Вид1

// void Method1()
// {
//   System.Console.WriteLine("Автор: Erell_X");
// }
// Method1();


// Вид2

void Method2(string msg1)
{
  Console.WriteLine(msg1);
}
// Method2(msg: "Текст сообщения");

void Method22(string msg2, int count)
{
  int i = 0;
  while (i < count)
  {
    Console.WriteLine(msg2);
    i++;
  }
}
// Method22(msg2:"Текст", count: 4);
// Method22(count: 4, msg2:"Текст");



// Вид3
int Method3()
{
  return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// Вид4
string Method4(int count, string text)
{
  int i = 0;

  string result = String.Empty; 

  while (count > i)
  {
    result = result + text;
    i++;
  }
  return result;
}
string res = Method4(10, "Ракета");
Console.WriteLine(res);