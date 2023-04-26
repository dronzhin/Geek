package DZOOP3.Employees;

import DZOOP3.Employee;


public class Designer extends Employee {

    public Designer(String firstName, String surName, double salary, int age) {
        super(firstName, surName, salary, age);
    }
    private static final int workingHoursPerDay = 5;
    private static final int workingDaysPerMonth = 3;
    private static final int minSalary = 800;
    private static final int maxSalary = 1500;
    {
        salary = (salary >= minSalary && salary <= maxSalary)? salary: (salary < minSalary)? minSalary : maxSalary;
    }

    @Override
    public double calculateSalary() {

        return salary * workingHoursPerDay * workingDaysPerMonth;
    }

    @Override
    public int getMinSalary() {
        return minSalary;
    }

    @Override
    public String toString() {
        return String.format("%s %s; Дизайнер; возраст %d; Заработная плата в час: %.2f рублей; Среднемесячная заработная плата: %.2f рублей.",
                surName, firstName, age, salary, calculateSalary());
    }
}
