diamond = 5

for i in range(diamond):
    for j in range(diamond - i - 1):
        print(" ", end="")
    for j in range(2 * i + 1):
        print("*", end="")
    print()  

for i in range(diamond - 2, -1, -1):
    for j in range(diamond - i - 1):
        print(" ", end="")
    for j in range(2 * i + 1):
        print("*", end="")
    print() 
