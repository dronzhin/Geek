package DZOOP3.Employees;

import DZOOP3.Employee;

public class Engineer extends Employee {

    public Engineer(String firstName, String surName, double salary) {
        super(firstName, surName, salary);
    }
    private static final int minSalary = 50000;
    private static final int maxSalary = 120000;
    {
        salary = (salary >= minSalary && salary <= maxSalary)? salary: (salary < minSalary)? minSalary : maxSalary;
    }
    @Override
    public double calculateSalary() {
        return salary;
    }

    @Override
    public String toString() {
        return String.format("%s %s; Инженер; Среднемесячная заработная плата: %.2f рублей.",
                surName, firstName, calculateSalary());
    }
    @Override
    public int getMinSalary() {
        return minSalary;
    }
}
