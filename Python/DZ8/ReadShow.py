import os.path

def read_record(file_base):
    if not os.path.isfile(file_base):
        with open(file_base, 'w'):
            return []
    with open(file_base, encoding="utf8") as f:
        all_data = [i.strip() for i in f]
        return all_data

def show_all(file_base):
    all_data = read_record(file_base)
    if all_data:
        print(*all_data, sep="\n")
    else:
        print("Empty data")