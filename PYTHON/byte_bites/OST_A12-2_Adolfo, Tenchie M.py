box = 7

for i in range(box):
    for j in range(box):
        if i == 0 or i == box - 1 or j == 0 or j == box - 1:
            print("*", end=" ")  
        else:
            print(" ", end=" ")  
    print()  
