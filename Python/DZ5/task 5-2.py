# Задача 28: Напишите рекурсивную функцию sum(a, b), возвращающую сумму двух целых неотрицательных чисел. Из всех арифметических операций допускаются только +1 и -1. Также нельзя использовать циклы.
# *Пример:*
# 2 2
#     4

import MyFunction

def summNumbers(number1, number2):
    if number2 == 0:
        return number1
    return summNumbers(number1, number2 - 1) + 1

number1 = MyFunction.InputNumber("Введите первое положительное число - ")
number2 = MyFunction.InputNumber("Введите второе положительное число - ")

print(summNumbers(number1, number2))