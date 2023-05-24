package DZOOP7.Seekers;

import java.util.Arrays;
import java.util.List;

public class Administrator implements Observer {

    private String name;
    private double salary;

    public List<String> getVacancies() {
        return vacancies;
    }

    private List<String> vacancies;

    public Administrator(String name) {
        this.name = name;
        salary = 25000;
        vacancies = Arrays.asList("Вакансия 2");
    }

    @Override
    public void receiveOffer(String nameCompany, double salary) {
        if (this.salary < salary){
            System.out.printf("Офисный рабочий %s >>> Мне нужна эта работа! [%s - %f]\n",
                    name, nameCompany, salary);
            this.salary = salary;
        }
        else{
            System.out.printf("Офисный рабочий %s >>> Я найду работу получше! [%s - %f]\n",
                    name, nameCompany, salary);
        }
    }
}