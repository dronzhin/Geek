# Задача 16: Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
# *Пример:*
# 5
#     1 2 3 4 5
#     3
#     -> 1

import MyFunction

lengthOfArray = MyFunction.InputNumber("Введите длину массива - ")
myArray = []
for i in range(lengthOfArray):
    myArray.append(MyFunction.InputNumber("Введите число в массив - "))
findNumber = MyFunction.InputNumber("Введите число для поиска - ")
print(f"Число {findNumber} встречает {myArray.count(findNumber)} раз(а)")