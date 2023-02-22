from Dz2 import MyFunction

userNumber = MyFunction.InputNumber()
answer = ""
number = 2
while userNumber >= number:
    answer += " " + str(number)
    number *= 2
print(answer)