package DZ5.Methods;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class PhoneBook {
    private final Map<String, String> phoneBook = new HashMap<>();
    public void addContact(String name, String phoneNumbers){
        phoneBook.put(name, phoneNumbers);
    }
    public void showContact(){
        System.out.println("Моя телефонная книга:");
        if(phoneBook.size() == 0){
            System.out.println("В телефонной книге нет контактов");
        } else {
            for (Map.Entry<String, String> contact : phoneBook.entrySet()) {
                System.out.println("Контакт: " + contact.getKey() + "\t" + "Телефон: " + contact.getValue());
            }
        }
        System.out.println();
    }
    public void removeContactName(String name){
        if(phoneBook.containsKey(name)){
            phoneBook.remove(name);
            System.out.println(name + " - контакт удален из телефонной книги");
        } else {
            System.out.println(name + " - такого контакта нет в телефонной книге");
        }
        System.out.println();
    }
}
