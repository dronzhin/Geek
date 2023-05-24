package DZOOP7.Seekers;

import java.util.Arrays;
import java.util.List;

public class Master implements Observer {

    private String name;
    private double salary;
    private List<String> vacancies;

    public List<String> getVacancies() {
        return vacancies;
    }

    public Master(String name) {
        this.name = name;
        salary = 80000;
        vacancies = Arrays.asList("Вакансия 2","Вакансия 3");
    }

    @Override
    public void receiveOffer(String nameCompany, double salary) {
        if (this.salary < salary){
            System.out.printf("Специалист %s >>> Мне нужна эта работа! [%s - %f]\n",
                    name, nameCompany, salary);
            this.salary = salary;
        }
        else{
            System.out.printf("Специалист %s >>> Я найду работу получше! [%s - %f]\n",
                    name, nameCompany, salary);
        }
    }
}