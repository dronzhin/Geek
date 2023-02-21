userNumber = int(input("Введите число: \n"))
result = 0
while userNumber > 0:
    result += userNumber % 10
    userNumber = userNumber // 10
print(f"Сумма цифр числа равна {result}")
