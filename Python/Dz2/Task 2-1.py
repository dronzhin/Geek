countOfCoins = int(input("Введите количество монеток: "))
count0 = 0
count1 = 0
for i in range(countOfCoins):
    currentCoin = input("Введите текущую монетку, где 0 - орел, а 1 - решка: ")
    if currentCoin == "0":
        count0 += 1
    elif currentCoin == "1":
        count1 += 1
    else:
        print("Тебе же сказали 0 или 1, о чем ты думаешь")
        i -= 1
if count1 < count0:
    print(f"Необходимо перевернуть {count1} раз(а) монетку решка")
elif count1 > count0:
    print(f"Необходимо перевернуть {count0} раз(а) монетку орел")
else:
    print(f"Ни в чем себе не отказывай переворачивай {count1} раз(а), хоть орла, хоть решку")
