// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.Write("Введите массив строк через пробел: ");
string[] array = Console.ReadLine().Split(' ');
string [] newArray = new string [array.Length] ;
int a = 0;
int i = 0;
for ( i = 0; i < array.Length; i++)
{
  if (array[i].Length <= 3) 
    {
      newArray[a] = array[i];
      a++;
    }
}
 Console.WriteLine($"Ваш конечный массив: [{string.Join(", ", newArray)}]");

//for ( i = 0; i < a; i++)
//{
//  Console.Write($"{(newArray[i])} ");
//}




