// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue].
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// знакочередования

int index=0;
int minValue=-100;
int maxValue=100;
int[]array=new int [10];
Console.WriteLine("Массив A");
while (index<array.Length)
{
     array[index]=new Random().Next(minValue, maxValue+1);
     Console.WriteLine(array[index]);
     index++;
}
Console.WriteLine("Массив B");
index=1;
int indexA=array[0];
Console.WriteLine(indexA);
while (index<array.Length)
{
     if (indexA<0 && array[index]>0)
     {
         Console.WriteLine(array[index]);
         indexA=array[index];
     }

     if (indexA>0 && array[index]<0)
     {
         Console.WriteLine(array[index]);
         indexA=array[index];
     }
     index++;
}