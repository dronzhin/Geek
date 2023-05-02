package DZOOP5;

import DZOOP5.models.TableModel;
import DZOOP5.presenters.BookingPresenter;
import DZOOP5.views.BookingView;

import java.util.Date;

public class Main {

    /**
     * TODO: ДОМАШНЯЯ РАБОТА
     * Метод changeReservationTable должен ЗАРАБОТАТЬ!
     *
     * @param args аргументы командной строки
     */
    public static void main(String[] args) {
        TableModel model = new TableModel();
        BookingView view = new BookingView();
        BookingPresenter bookingPresenter = new BookingPresenter(model, view);

        bookingPresenter.loadTables();
        bookingPresenter.updateView();


        view.reservationTable(new Date(), 2, "Станислав");
        view.showReservationsOnTable(2);
        view.changeReservationTable(1001, new Date(), 3, "Станислав");
        view.showReservationsOnTable(3);
        view.deleteReservationTable(1002);
        view.showReservationsOnTable(3);


    }

}