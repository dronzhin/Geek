import java.io.FileWriter;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.InputMismatchException;
import java.util.Scanner;
public class Person {
    private String name;
    private String surname;
    private String lastName;
    private String birthday;
    private long phone;
    private String gender;
    private String fullInformation;
    private Scanner scanner = new Scanner(System.in);

    public Person() {
        inputSurname();
        inputName();
        inputLastName();
        inputBirthday();
        inputPhone();
        inputGender();
        fullInformation = surname + " " + name + " " + lastName + " " + phone + " " + gender;
        try(FileWriter in = new FileWriter(surname, true)) {

            in.append(fullInformation + "\n");
        }catch (IOException e){
            throw new RuntimeException("Проблемы с записью файла");
        }
    }

    public void inputName(){
        System.out.println("Введите имя:");
        name = scanner.next();
        if(Methods.CheckNumberInWord(name)){
            throw new PersonStringException("Имя должно состоять только из букв");
        }
    }
    public void inputSurname(){
        System.out.println("Введите фамилию:");
        surname = scanner.next();
        if(Methods.CheckNumberInWord(surname)){
            throw new PersonStringException("Фамилия должна состоять только из букв");
        }
    }
    public void inputLastName(){
        System.out.println("Введите отчество:");
        lastName = scanner.next();
        if(Methods.CheckNumberInWord(lastName)){
            throw new PersonStringException("Отчество должно состоять только из букв");
        }
    }
    public void inputBirthday(){
        System.out.println("Введите день рождения в формате 01.01.2000:");
        birthday = scanner.next();
        Methods.CheckFormatDate(birthday);
    }
    public void inputPhone(){
        System.out.println("Введите телефон:");
        try {
            phone = scanner.nextInt();
        } catch (NumberFormatException e) {
            throw new PhoneNumberException("Телефон, может состоять только из цифр");
        } catch (InputMismatchException e){
            throw new PhoneNumberException("Телефон, может состоять только из цифр");
        }

    }
    public void inputGender(){
        System.out.println("Введите пол (f - женский, m - мужской):");
        gender = scanner.next();
        if(!gender.equals("f") && !gender.equals("m")){
            throw new PersonGenderException("Пол может быть только f - женский, m - мужской");
        }
    }

    public String getName() {
        return name;
    }

    public String getSurname() {
        return surname;
    }

    public String getLastName() {
        return lastName;
    }

    public String getBirthday() {
        return birthday;
    }

    public long getPhone() {
        return phone;
    }

    public String getGender() {
        return gender;
    }

    @Override
    public String toString() {
        return fullInformation;
    }
}
