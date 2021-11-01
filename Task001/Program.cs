// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
// Создать на его основе масив B, отбрасывая те, которые

// нарушают порядок возрастания
int index=0;
int [] array=new int[10];
while (index<10)
{
     array[index]=new Random().Next(10,100);
     index++;
}
 

 index =0;
 Console.WriteLine("Массив А");
 while (index<10)
 {
     int arrayA=array[index];
     Console.WriteLine(arrayA);
     index++; 
 }

Console.WriteLine();
Console.WriteLine("Массив B");

index=0;
int count=array[0];
Console.WriteLine(count);
while (index<10)
{
     if (count<array[index])
     {
         Console.WriteLine(array[index]);
         count=array[index];

     }
     index++;
}

 
