// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// возрастания

int index = 0;
int[]array=new int [10];
int minValue=-100;
int maxValue=100;
Console.WriteLine("Массив А");

while (index<array.Length)
{
     array[index]=new Random().Next(minValue, maxValue+1);
     Console.WriteLine(array[index]);
     index++;
}

Console.WriteLine();
Console.WriteLine("Массив B");
index=0;
int count=array[0];
Console.WriteLine(count);
while (index<array.Length)
{
     if (array[index]>count)
     {
         Console.WriteLine(array[index]);
         count=array[index];
         
     }
     index++;
}