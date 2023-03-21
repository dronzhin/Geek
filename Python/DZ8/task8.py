import ReadShow
import AddDelete
import SearchChange

def main_menu(file_base):
    play = True
    while play:
        answer = input("Phone books: \n"
                       "1. Show all records\n"
                       "2. Add a records\n"
                       "3. Search a records\n"
                       "4. Change\n"
                       "5. Delete\n"
                       "6. Exit\n")
        match answer:
            case "1":
                ReadShow.show_all(file_base)
            case "2":
                AddDelete.add_new_contact(file_base)
            case "3":
                SearchChange.search_contact(file_base)
            case "4":
                SearchChange.change_contact(file_base)
            case "5":
                AddDelete.delete_contact(file_base)
            case "6":
                play = False
            case _:
                print("Try again!\n")
file_base = "base.txt"
main_menu(file_base)
