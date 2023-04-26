package DZOOP3;

import DZOOP3.Employees.*;

import java.util.Random;

public class Methods {
    private static Random random = new Random();

    /**
     * TODO: 2. Переработать метод generateEmployee(). Метод должен возвращать
     * любого случайного сотрудника разного типа (Worker, Freelancer)
     * @return
     */
    public static Worker generateEmployee(){
        String[] names = new String[] { "Анатолий", "Глеб", "Клим", "Мартин", "Лазарь", "Владлен", "Клим", "Панкратий", "Рубен", "Герман" };
        String[] surnames = new String[] { "Григорьев", "Фокин", "Шестаков", "Хохлов", "Шубин", "Бирюков", "Копылов", "Горбунов", "Лыткин", "Соколов" };

        int salary = random.nextInt(900, 1500);
        int salaryIndex = random.nextInt(28, 31);
        int age = random.nextInt(20, 60);

        return new Worker(names[random.nextInt(10)], surnames[random.nextInt(10)],salary * salaryIndex, age);

    }
    public static Employee newGenerateEmployee(){
        String[] names = new String[] { "Анатолий", "Глеб", "Клим", "Мартин", "Лазарь", "Владлен", "Клим", "Панкратий", "Рубен", "Герман" };
        String[] surnames = new String[] { "Григорьев", "Фокин", "Шестаков", "Хохлов", "Шубин", "Бирюков", "Копылов", "Горбунов", "Лыткин", "Соколов" };
        Employee result;

        int speciality = random.nextInt(5);
        int salary = random.nextInt(600, 2000);
        int salaryIndex = random.nextInt(20, 60);
        int age = random.nextInt(20, 60);

        if(speciality == 0) {
            result = new Designer(names[random.nextInt(10)], surnames[random.nextInt(10)],salary, age);
        } else if (speciality == 1) {
            result = new Programmer(names[random.nextInt(10)], surnames[random.nextInt(10)],salary, age);
        } else if (speciality == 2) {
            result = new Worker(names[random.nextInt(10)], surnames[random.nextInt(10)],salary * salaryIndex, age);
        } else if (speciality == 3) {
            result = new Economist(names[random.nextInt(10)], surnames[random.nextInt(10)],salary * salaryIndex, age);
        } else {
            result = new Engineer(names[random.nextInt(10)], surnames[random.nextInt(10)], salary * salaryIndex, age);
        }
        return result;
    }
}
