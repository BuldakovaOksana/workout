// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, 
// элементы, которые больше 8

int index=0;
int minValue=-100;
int maxValue=100;
int []array=new int [10];
Console.WriteLine("Массив A");
while (index<array.Length)
{
     array[index]=new Random().Next(minValue, maxValue);
     Console.WriteLine(array[index]);
     index++;
}

Console.WriteLine();
Console.WriteLine("Массив B");
index=0;
int count=8;
while (index<array.Length)
{
     if (array[index]<count)
     {
      Console.WriteLine(array[index]);   
     }
     index++;
}