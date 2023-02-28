# Задача 18: Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X.
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
# *Пример:*
# 5
#     1 2 3 4 5
#     6
#     -> 5

import math
import MyFunction

lengthOfList = MyFunction.InputNumber("Введите длину массива - ")
myList = []
MyFunction.AddNumbersInList(myList, lengthOfList)
findNumber = MyFunction.InputNumber("Введите число для поиска - ")
similarNumberInList = myList[0]
differenceBetweenNumbers = 1000
for i in range(1, lengthOfList):
    if math.fabs(myList[i]-findNumber) < differenceBetweenNumbers:
        differenceBetweenNumbers = math.fabs(myList[i]-findNumber)
        similarNumberInList = myList[i]
if similarNumberInList > findNumber:
    if findNumber - differenceBetweenNumbers in myList: similarNumberInList = findNumber - differenceBetweenNumbers
print(f"Самое близкое число в списке - {int(similarNumberInList)}")