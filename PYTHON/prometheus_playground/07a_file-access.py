with open("./devices.txt",'r') as f:
    for item in f.read().splitlines():
        print(item)
