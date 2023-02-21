userNumber = int(input("Введите число: \n"))
if userNumber % 6 != 0:
    print("Нет решения")
else:
    pety = int(userNumber/6)
    katy = pety * 4
    serega = pety
    print(f"Петя сделал {pety} журавлей")
    print(f"Катя сделал {katy} журавлей")
    print(f"Сережа сделал {serega} журавлей")