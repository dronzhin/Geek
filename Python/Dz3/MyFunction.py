def InputNumber(request = "Введите число: "):
    answer = input(request)
    while 1:
        if answer.isdigit():
            break
        answer = input(request)
    return int(answer)

def AddNumbersInList(list = [], count = 0):
    for i in range(count):
        list.append(InputNumber("Введите число в массив - "))