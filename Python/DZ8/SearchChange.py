import ReadShow

def enter_infomation():
    parametrs = ['surname', 'name', 'patronumic', 'phone_numbers']
    contact = ''
    for i in parametrs:
        while True:
            info = input(f"Enter {i} ")
            if info.strip():
                contact += info + " "
                break
    return contact.strip()

def search_contact(file_base):
    contact = enter_infomation()
    base = ReadShow.read_record(file_base)
    for i in base:
        if contact.find(i):
            print(f"{contact} есть в базе")
            return contact
        else:
            print(f"{contact} нет в базе")
            return -1
    base.close()

def change_contact(file_base):
    print("Введите контакт, который хотите заменить")
    contact = search_contact(file_base)
    base = ReadShow.read_record(file_base)
    file = open(file_base, 'w', encoding='utf-8')
    if contact != -1:
        print("Введите контакт, который хотите заменить")
        new_contact = enter_infomation()
        for i in range(len(base)):
            if contact == base[i]:
                base[i] = new_contact
        for j in base:
            file.write(j)
            file.write("\n")

    file.close()