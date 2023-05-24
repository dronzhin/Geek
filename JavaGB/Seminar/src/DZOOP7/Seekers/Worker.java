package DZOOP7.Seekers;

import java.util.Arrays;
import java.util.List;

public class Worker implements Observer {

    private String name;
    private double salary;
    private List<String> vacancies;

    public List<String> getVacancies() {
        return vacancies;
    }

    public Worker(String name) {
        this.name = name;
        salary = 40000;
        vacancies = Arrays.asList("Вакансия 1");
    }

    @Override
    public void receiveOffer(String nameCompany, double salary) {
        if (this.salary < salary){
            System.out.printf("Рабочий %s >>> Мне нужна эта работа! [%s - %f]\n",
                    name, nameCompany, salary);
            this.salary = salary;
        }
        else{
            System.out.printf("Рабочий %s >>> Я найду работу получше! [%s - %f]\n",
                    name, nameCompany, salary);
        }
    }
}