# Задача 26:  Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
# *Пример:*
# A = 3; B = 5 -> 243 (3⁵)
#     A = 2; B = 3 -> 8

import MyFunction

def calculate_degree(number, degree):
    if degree == 1:
        return number
    return calculate_degree(number, degree - 1) * number

number = MyFunction.InputNumber("Введите число, которую хотите ввести в степень - ")
degree = MyFunction.InputNumber("Введите степень - ")

print(calculate_degree(number, degree))