package DZOOP7.Seekers;

import java.util.List;

public interface Observer {

    public void receiveOffer(String nameCompany, double salary);
    public List<String> getVacancies();


}