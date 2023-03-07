import MyFunction

length_list = MyFunction.InputNumber("Введите длину массива - ")
list = MyFunction.CreateRandomList(length_list, -20, 30)
print(list)
min_number = int(input("Введите минимальное значение - "))
max_number = MyFunction.InputNumber("Введите максимальное значение - ")
result = []
for i in range(length_list):
    if min_number <= list[i] <= max_number:
        result.append(i)
print(result)