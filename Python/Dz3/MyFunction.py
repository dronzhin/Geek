def InputNumber(request = "Введите число: "):
    answer = input(request)
    while 1:
        if answer.isdigit():
            break
        answer = input(request)
    return int(answer)