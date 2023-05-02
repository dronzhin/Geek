package DZOOP5.presenters;

import DZOOP5.models.Table;

import java.util.Collection;
import java.util.Date;

public interface Model {

    Collection<Table> loadTables();

    int reservationTable(Date reservationDate, int tableNo, String name);
    public boolean deleteReservationTable(int idTable);
    public int changeReservationTable(int oldReservation, Date reservationDate, int tableNo, String name);
    public void showReservationsOnTable(int reservationId);

}
