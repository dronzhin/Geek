side1 = int(input("Введите количество долек 1 стороны - "))
side2 = int(input("Введите количество долек 2 стороны - "))
numberOfPieces = int(input("Введите количество долек, которые нужно обломить - "))
if side1 * side2 < numberOfPieces:
    print("Нет, нельзя")
elif numberOfPieces % side1 == 0:
    print("Да, можно")
elif numberOfPieces % side2 == 0:
    print("Да, можно")
else:
    print("Нет, нельзя")