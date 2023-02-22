summTwoNumbers = int(input("Введите сумму чисел: "))
multiplicationTwoNumbers = int(input("Введите произведение двух чисел: "))
answer1 = 0
answer2 = 0
for i in range(1, summTwoNumbers):
    for j in range(1, summTwoNumbers):
        if i + j == summTwoNumbers and i * j == multiplicationTwoNumbers:
            answer1 = i
            answer2 = j
            break
if answer1 == 0:
    print("Ты, что мне загадал, попробуй сам посчитать")
else:
    print(f"Первое число равно {answer1}, второе число равно {answer2}")
