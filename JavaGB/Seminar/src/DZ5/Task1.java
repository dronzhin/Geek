package DZ5;

import DZ5.Methods.PhoneBook;

public class Task1 {
    public static void main(String[] args) {
        PhoneBook myPhone = new PhoneBook();
        myPhone.showContact();
        myPhone.addContact("Иванов Иван", "+79091234560");
        myPhone.addContact("Иванов Петр", "+79091234561");
        myPhone.addContact("Иванов Иван", "+79091234562");
        myPhone.addContact("Иванов Денис", "+79091234563");
        myPhone.addContact("Иванов Игорь", "+79091234564");
        myPhone.showContact();
        myPhone.removeContactName("Иванов Дмитрий");
        myPhone.removeContactName("Иванов Денис");
        myPhone.showContact();
    }

}
