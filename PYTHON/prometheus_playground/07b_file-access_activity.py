devices: list[str] = []

with open("./devices.txt", "a") as f:
    print("Enter a device to add. Type `exit` to save and quit.")
    while True:
        # ask user for new device
        new_item: str = input(" >>> ")
        if new_item == "exit":
            break

        # add device to new devices list
        devices.append(new_item)

    print("All done!")

    # Save to file
    for device in devices:
        f.write(f"{device}\n")
