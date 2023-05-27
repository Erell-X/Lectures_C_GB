
string text = "Ракета испытывает со стороны среды действие сил трения и " 
            + "давления на поверхности. Значения этих сил и законы их " 
            + "распределения зависят от скорости полёта. "
            + "Статическая составляющая сил атмосферного давления " 
            + "уже была нами учтена при выводе выражения тяги.";

string Replace (string text, char oldSymbol, char newSymbol) // описание метода
{
  string result = String.Empty; // введение переменной result, равной пустой строке
  int length = text.Length;     // введение переменной длины, равной длине текста   

  for (int pro=0; pro<length; pro++)
  {
    if (text[pro] == oldSymbol) result = result + $"{newSymbol}";
    else result = result + $"{text[pro]}";
  }
  return result;
}

string TextPro = Replace (text, 'в', 'В');
System.Console.WriteLine();
System.Console.WriteLine(TextPro);
System.Console.WriteLine();