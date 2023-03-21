import SearchChange
import ReadShow

def add_new_contact(file_base):
    contact = SearchChange.enter_infomation()
    with open(file_base, 'a', encoding='utf-8') as f:
        f.write(contact + '\n')
    return

def delete_contact(file_base):
    contact = SearchChange.enter_infomation()
    base = ReadShow.read_record(file_base)
    print(base)
    file = open(file_base, 'w', encoding='utf-8')
    base.remove(contact)
    print(base)
    for j in base:
        file.write(j)
        file.write("\n")