user_string = input().lower()
vowels = "аяуюоеёэи"
# "пара-ра-рам рам-пам-папам па-ра-па-да"
user_list = user_string.split()
list = []
count = 0
for word in user_list:
    for symbol in word:
        if symbol in vowels:
            count += 1
    list.append(count)
    count = 0
print(list)
if len(set(list)) == 1:
    print("Парам пам-пам")
else:
    print("Пам парам")