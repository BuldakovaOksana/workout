// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
// Создать на его основе масив B, отбрасывая те, которые
// чётные

int index = 0;
int [] array= new int [10];
Console.WriteLine("Массив А");
while (index<array.Length)
{
    array[index]=new Random().Next(10,100);
    Console.WriteLine(array[index]);
    index++;
}

Console.WriteLine();
Console.WriteLine("Массив B");
index=0;

while (index<array.Length)
{
     if (array[index]%2!=0)
     {
         Console.WriteLine(array[index]);
     }
     index++;
}