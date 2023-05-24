package DZOOP7.Agency;
import DZOOP7.Agency.Publisher;
import DZOOP7.Seekers.Observer;
import DZOOP7.Vacancies.Vacancy;

import java.util.ArrayList;
import java.util.List;

/**
 * Агенство по поиску сотрудников
 */
public class JobAgency implements Publisher {

    private List<Observer> observers = new ArrayList<>();

    @Override
    public void registerObserver(Observer observer) {
        observers.add(observer);
    }

    @Override
    public void removeObserver(Observer observer) {
        observers.remove(observer);
    }

    /**
     * Реализация рассылки сообщений
     * @param nameCompany
     * @param salary
     */
    @Override
    public void sendOffer(String nameCompany, Vacancy vacancy, double salary) {
        for (Observer observer : observers){
            for (String vac: observer.getVacancies()) {
                if(vac == vacancy.getJobTitle()){
                    observer.receiveOffer(nameCompany, salary);
                }
            }
        }
    }
}