userNumber = input("Введите число: \n")
sideFirst = int(userNumber[0]) + int(userNumber[1]) + int(userNumber[2])
sideSecond = int(userNumber[3]) + int(userNumber[4]) + int(userNumber[5])
if sideFirst == sideSecond:
    print("У тебя счастливый билет")
else:
    print("Катайся дальше, ты неудачник")