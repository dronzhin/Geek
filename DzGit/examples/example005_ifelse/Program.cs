Console.Write("Введите имя: ");
string user_name = Console.ReadLine();

if (user_name.ToLower() == "маша")
{
    Console.WriteLine("Да это же Маша!");
}
else
{
   Console.Write("Привет "); 
   Console.Write(user_name); 
}
