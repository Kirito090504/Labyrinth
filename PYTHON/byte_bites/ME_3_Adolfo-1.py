def findlostitem():
    lostitem = str(input("Input the lost item: "))

    if lostitem == "Umbrella":
        print("The Umbrella has been found!")
    elif lostitem == "Ear pods":
        print("The Ear pods has been found!")
    elif lostitem == "Pink Wallet":
        print("The Pink Wallet has been found!")
    elif lostitem == "Teddy Bear":
        print("The Teddy Bear has been found!")
    elif lostitem == "Water Bottle":
        print("The Water Bottle has been found!")
    elif lostitem != ["Umbrella", "Ear pods", "Pink Wallet", "Teddy Bear", "Water Bottle"]:
        print("Sorry, the item is not in the list")
  
    return lostitem

print({findlostitem()})