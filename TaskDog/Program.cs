// задача про собаку

int count =0;
int distance =10000;
int firstFriendSpeed =1;
int secondFriendSpeed =2;
int dogSpeed =5;
int friend =2;
int Time =0;

while (distance>=10)
{
     if (friend==1)
     {
         Time=distance/(firstFriendSpeed+dogSpeed);
         friend=2;
     }
     else
     {
         Time=distance/(secondFriendSpeed+dogSpeed);
         friend=1;
     }
     distance = distance -(firstFriendSpeed+secondFriendSpeed)*Time;
     Console.WriteLine($"дистанция " + distance);
     count++;
     
}
     Console.WriteLine($"Количество кругов " + count);

