package DZOOP7;

import DZOOP7.Agency.JobAgency;
import DZOOP7.Seekers.Administrator;
import DZOOP7.Seekers.Master;
import DZOOP7.Seekers.Worker;
import DZOOP7.Vacancies.Vacancy;
import DZOOP7.Vacancies.Vacancy1;
import DZOOP7.Vacancies.Vacancy2;

public class Program {

    /**
     * TODO: 1.Доработать приложение, поработать с шаблоном проектирования Observer
     *   добавить новый тип соискателя.
     *   **.2 Добавить новую сущность "Вакансия", компания должна рассылать вакансии.
     *   **.3 Предусмотреть тип вакансии (enum)
     * @param args
     */
    public static void main(String[] args) {

        JobAgency jobAgency = new JobAgency();
        Company geekBrains = new Company("GeekBrains", 70000, jobAgency);
        Company google = new Company("Google", 100000, jobAgency);
        Company yandex = new Company("Yandex", 120000, jobAgency);

        Master ivanov = new Master("Ivanov");
        Administrator petrov = new Administrator("Petrov");
        Worker sidorov = new Worker("Sidorov");

        jobAgency.registerObserver(ivanov);
        jobAgency.registerObserver(petrov);
        jobAgency.registerObserver(sidorov);

        Vacancy vac1 = new Vacancy1("Описание 1");
        vac1.addResponsibily("Обязанность 1");
        vac1.addResponsibily("Обязанность 2");
        vac1.addResponsibily("Обязанность 3");

        Vacancy vac2 = new Vacancy2("Описание 1");
        vac2.addResponsibily("Обязанность 1");
        vac2.addResponsibily("Обязанность 2");
        vac2.addResponsibily("Обязанность 3");



        for(int i = 0; i < 5; i++){
            geekBrains.needEmployee(vac2);
            google.needEmployee(vac2);
            yandex.needEmployee(vac2);
            System.out.println();
        }

        System.out.println(vac2);

    }

}
