package DZOOP3.Employees;

import DZOOP3.Employee;

public class Economist extends Employee {

    public Economist(String firstName, String surName, double salary) {
        super(firstName, surName, salary);
    }

    @Override
    public double calculateSalary() {
        return salary;
    }
    private static final int minSalary = 40000;
    private static final int maxSalary = 100000;
    {
        salary = (salary >= minSalary && salary <= maxSalary)? salary: (salary < minSalary)? minSalary : maxSalary;
    }

    @Override
    public String toString() {
        return String.format("%s %s; Экономист; Среднемесячная заработная плата: %.2f рублей.",
                surName, firstName, calculateSalary());
    }
    @Override
    public int getMinSalary() {
        return minSalary;
    }
}

