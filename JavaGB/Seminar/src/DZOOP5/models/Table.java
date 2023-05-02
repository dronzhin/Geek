package DZOOP5.models;

import java.util.ArrayList;
import java.util.Collection;

public class Table {

    private  static int counter;
    private final int no;


    private final Collection<Reservation> reservations = new ArrayList<>();

    public Collection<Reservation> getReservations() {
        return reservations;
    }

    public int getNo() {
        return no;
    }

    {
        no = ++counter;
    }

    @Override
    public String toString() {
        return String.format("Столик #%d", no);
    }
}
