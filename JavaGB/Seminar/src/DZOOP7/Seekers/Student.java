package DZOOP7.Seekers;

import DZOOP7.Vacancies.Vacancy2;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Student implements Observer {

    private String name;
    private double salary;
    private List<String> vacancies;

    public List<String> getVacancies() {
        return vacancies;
    }

    public Student(String name) {
        this.name = name;
        salary = 5000;
        vacancies = Arrays.asList("Вакансия 1","Вакансия 2");
    }

    @Override
    public void receiveOffer(String nameCompany, double salary) {
        if (this.salary < salary){
            System.out.printf("Студент %s >>> Мне нужна эта работа! [%s - %f]\n",
                    name, nameCompany, salary);
            this.salary = salary;
        }
        else{
            System.out.printf("Студент %s >>> Я найду работу получше! [%s - %f]\n",
                    name, nameCompany, salary);
        }
    }
}
