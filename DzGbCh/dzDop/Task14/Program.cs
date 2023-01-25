// У нас есть кеш - N $ , мы хотим сохранить его от инфляции, кладем в банк и получаем раз в год M % , через сколько лет у нас получится купить квартиру за K $,
// при том , что цена квартиры также растет на Q % если этот процент больше или равен N , то вывести в консоль безысходность


bool exit = false;
    
while (exit == false)
{
    System.Console.WriteLine();
    System.Console.Write("Сколько полижите в банк? : ");
    string deposit = Console.ReadLine();
    System.Console.Write("Под какой процент положите? : ");
    string percent = Console.ReadLine();
    System.Console.Write("Сколько стоит квартира? : ");
    string price = Console.ReadLine();
    System.Console.Write("Сколько инфляция составляет процентов? : ");
    string inflation = Console.ReadLine();
    int intDeposit;
    int intPercent;
    int intInflation;
    int intPrice;
    int year = 0;
    if (int.TryParse(deposit, out intDeposit) == true && int.TryParse(percent, out intPercent) == true &&
     int.TryParse(price, out intPrice) == true && int.TryParse(inflation, out intInflation) == true)
    {
        if (intDeposit > intPrice) 
        {
        System.Console.WriteLine("Можешь квартиру купить сразу");
        }
        else
        {
            if (intInflation >= intPercent)
            {
                System.Console.WriteLine("Лучше пробухай деньги, больше пользы");
            }
            else
            {
                while (intDeposit < intPrice)
                {
                    intDeposit = intDeposit + intDeposit*intPercent/100;
                    intPrice = intPrice + intPrice*intInflation/100;
                    year++;
                    System.Console.WriteLine($"{year} год. На депозите у Вас - {intDeposit}. Квартира стоит - {intPrice}.");
                }
            }
        }
        System.Console.WriteLine($"На {year} год. Вы сможете купить квартиру!");
        exit = true;
    }
   else
    {
        System.Console.WriteLine("Введено было не число");
    }
}