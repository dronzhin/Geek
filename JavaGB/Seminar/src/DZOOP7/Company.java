package DZOOP7;
import DZOOP7.Agency.Publisher;
import DZOOP7.Vacancies.Vacancy;

import java.util.Random;
public class Company {
    private Random random;
    private String nameCompany;
    private double maxSalary;

    private Publisher jobAgency;

    public Company(String nameCompany, double maxSalary, Publisher jobAgency) {
        this.nameCompany = nameCompany;
        this.maxSalary = maxSalary;
        this.jobAgency = jobAgency;
        random = new Random();
    }

    public void needEmployee(Vacancy vacancy){
        double salary = random.nextDouble(3000, maxSalary);
        jobAgency.sendOffer(nameCompany, vacancy, salary);
    }
}
