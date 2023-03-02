
import random
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

def CreateRandomList(length, min = 0, max = 50):
    list = []
    for i in range(length):
        list.append(random.randint(min, max))
    return list

