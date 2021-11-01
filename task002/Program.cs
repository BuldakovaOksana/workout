// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
// Создать на его основе масив B, отбрасывая те, которые
// больше среднего арифметического элементов A

int index=0;
int [] array=new int [10];

while (index<array.Length)
{
  array[index]=new Random().Next(10,100);
  index++;   
}
index=0;
Console.WriteLine("Массив А");
while (index<array.Length)
{
     int arrayA=array[index];
     Console.WriteLine(arrayA);
     index++;
}

Console.WriteLine();
Console.WriteLine("ср. арифметическое");
index=0;
int sum=0;
int result=0;
while (index<array.Length)
{
     sum=sum+array[index];
     index++;
}
result=sum/array.Length;
Console.WriteLine(result);

Console.WriteLine();
Console.WriteLine("Массив B");
index=0;

while (index<array.Length)
{
     
     if (array[index]<result)
     {
         
         Console.WriteLine(array[index]);
         
     }
     index++;
}