# Задача 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями).
# Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
# Пользователь вводит 2 числа. n - кол-во элементов первого множества. m - кол-во элементов второго множества.
# Затем пользователь вводит сами элементы множеств.

import MyFunction

myList1 = MyFunction.CreateRandomList(MyFunction.InputNumber("Введите длину первого массива - "), 1, 15)
myList2 = MyFunction.CreateRandomList(MyFunction.InputNumber("Введите длину второго массива массива - "), 1, 15)
myList = myList1 + myList2
myList = sorted(list(set(myList)))
print(myList)
