list = [1, 2, 2, 3, 2, 3, 4, 1]
list = sorted(list)
print(list)
count_number = 0
count = 1
for i in range(len(list) - 1):
    if list[i] == list[i + 1]:
        count += 1
    else:
        count_number += count // 2
        count = 1
print(count_number)

