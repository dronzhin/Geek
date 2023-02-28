# Задача 16: Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
# *Пример:*
# 5
#     1 2 3 4 5
#     3
#     -> 1

import MyFunction

lengthOfList = MyFunction.InputNumber("Введите длину массива - ")
myList = []
MyFunction.AddNumbersInList(myList, lengthOfList)
findNumber = MyFunction.InputNumber("Введите число для поиска - ")
print(f"Число {findNumber} встречает {myList.count(findNumber)} раз(а)")