package DZOOP7.Agency;

import DZOOP7.Seekers.Observer;
import DZOOP7.Vacancies.Vacancy;

public interface Publisher {

    void registerObserver(Observer observer);

    void removeObserver(Observer observer);

    void sendOffer(String nameCompany, Vacancy vacancy, double salary);

}
