import MyFunction

start = MyFunction.InputNumber("Введите число с которого начинается прогрессия - ")
step = MyFunction.InputNumber("Введите шаг прогрессии - ")
length = MyFunction.InputNumber("Введите количество элементов прогрессии - ")
result = [start]
for i in range(1, length):
    result.append(result[i-1] + step)
print(result)