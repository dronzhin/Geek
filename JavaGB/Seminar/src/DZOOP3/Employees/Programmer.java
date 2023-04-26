package DZOOP3.Employees;

import DZOOP3.Employee;

public class Programmer extends Employee {

    public Programmer(String firstName, String surName, double salary, int age) {
        super(firstName, surName, salary, age);
    }
    private static final int workingHoursPerDay = 6;
    private static final int workingDaysPerMonth = 10;
    private static final int minSalary = 1000;
    private static final int maxSalary = 1800;
    {
        salary = (salary >= minSalary && salary <= maxSalary)? salary: (salary < minSalary)? minSalary : maxSalary;
    }
    @Override
    public double calculateSalary() {
        return salary * workingHoursPerDay * workingDaysPerMonth;
    }
    @Override
    public String toString() {
        return String.format("%s %s; Программист; возраст %d; Заработная плата в час: %.2f рублей; Среднемесячная заработная плата: %.2f рублей.",
                surName, firstName, age, salary, calculateSalary());
    }
    @Override
    public int getMinSalary() {
        return minSalary;
    }
}