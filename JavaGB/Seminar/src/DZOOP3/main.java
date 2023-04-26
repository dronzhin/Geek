package DZOOP3;

import DZOOP3.Employees.Economist;
import DZOOP3.Employees.Programmer;
import DZOOP3.Employees.Worker;

import java.util.Arrays;

import static DZOOP3.Methods.*;

public class main {
    public static void main(String[] args) {
        Employee[] employees = new Employee[20];
        for (int i = 0; i < employees.length; i++){
            employees[i] = newGenerateEmployee();
        }
        MyFunction.printArray(employees);
        System.out.println("----------");
        Arrays.stream(employees).filter(x -> x.calculateSalary() > 50000).sorted().forEach(System.out::println);
        System.out.println("----------");
        Arrays.stream(employees).filter(x -> x instanceof Programmer || x instanceof Economist).
                sorted((x1,x2)-> Integer.compare(x1.getMinSalary(), x2.getMinSalary())).forEach(System.out::println);
    }
}
