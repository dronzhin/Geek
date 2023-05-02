package DZOOP5.models;

import DZOOP5.presenters.Model;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Date;

public class TableModel implements Model {


    private Collection<Table> tables;


    /**
     * Получение списка всех столиков
     * @return столики
     */
    public Collection<Table> loadTables(){
        if (tables == null){
            tables = new ArrayList<>();

            tables.add(new Table());
            tables.add(new Table());
            tables.add(new Table());
            tables.add(new Table());
            tables.add(new Table());

        }
        return tables;
    }

    /**
     * Бронирование столика
     * @param reservationDate Дата бронирования
     * @param tableNo номер столика
     * @param name имя клиента
     * @return номер брони
     */
    public int reservationTable(Date reservationDate, int tableNo, String name){
        for (Table table : tables){
            if (table.getNo() == tableNo){
                Reservation reservation = new Reservation(reservationDate, name);
                table.getReservations().add(reservation);
                return reservation.getId();
            }
        }
        return -1;
        //throw new RuntimeException("Невозможно забронировать столик.");
    }



    //TODO: Разработать самостоятельно в рамках домашней работы
    public int changeReservationTable(int oldReservation, Date reservationDate, int tableNo, String name){
        boolean delete = deleteReservationTable(oldReservation);
        if(delete){
            return reservationTable(reservationDate, tableNo, name);
        }
        return -1;
    }
    public boolean deleteReservationTable(int idTable){
        for (Table table : tables){
            for (Reservation id: table.getReservations()) {
                if(id.getId() == idTable){
                    table.getReservations().remove(id);
                    return true;
                }
            }
        }
        return false;
    }
    public void showReservationsOnTable(int no){
        for (Table table : tables){
                if(table.getNo() == no){
                    System.out.println();
                    System.out.println("Номера ID брони на столике - " + no);
                    for (Reservation res: table.getReservations()) {
                        System.out.println(res.getId());
                    }
                    if(table.getReservations().size() == 0){
                        System.out.println("Ничего не забронировано");
                    }
                    System.out.println();
            }
        }
    }
}
