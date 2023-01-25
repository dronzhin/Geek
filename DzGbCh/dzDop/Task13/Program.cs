// Задать N и вывести # до N елочкой 
// пример
// N = 3;
//   # 
//  ###
bool exit = false;
string insert(char sym, int count)
{
    return new string(sym, count);
}
    
while (exit == false)
{
    System.Console.WriteLine();
    System.Console.Write("Введите число для елки : ");
    string number = Console.ReadLine();
    int intNumber;
    if (int.TryParse(number, out intNumber) == true)
    {

        if (intNumber%2 == 1)
        {
            char sym = '#';
            char sym1 = ' ';
            for (int i = 1; i <= intNumber; i +=2)
            {
                System.Console.WriteLine(insert(sym1, (intNumber-i)/2) + insert(sym, i)+ insert(sym1, (intNumber-i)/2));
            }
        }
        exit = true;
    }
   else
    {
        System.Console.WriteLine("Введено было не число");
    }
}