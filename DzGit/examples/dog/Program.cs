int count = 0;
int distance = new Random().Next(5000, 20000);
Console.WriteLine("Растояние между друзьями - " + distance + " м.");
int minDistance = new Random().Next(100, 500);
Console.WriteLine("Минимальное растояние, которое должно стать между друзьями - " + minDistance + " м.");
int firstFrendSpeed = new Random().Next(3, 5);
Console.WriteLine("Скорость первого друга - " + firstFrendSpeed + " м/ч");
int secondFrendSpeed = new Random().Next(1, 3);
Console.WriteLine("Скорость второго друга - " + secondFrendSpeed + " м/ч");
int dogSpeed = new Random().Next(5, 10);
Console.WriteLine("Скорость собаки - " + dogSpeed + " м/ч");
int friend = 1;
int Time = 0;

while (distance > minDistance){
    if (friend == 1){
        Time = distance/(dogSpeed - secondFrendSpeed);
        friend = 2;
        }
    else{
        Time = distance/(dogSpeed + firstFrendSpeed);
        friend = 1;
    }
    count++;
    distance = distance - (firstFrendSpeed - secondFrendSpeed) * Time;
}
Console.WriteLine("Собака пробежит - " + count + " раз.");