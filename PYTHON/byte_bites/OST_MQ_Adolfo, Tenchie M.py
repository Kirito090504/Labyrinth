while True: 
    print("Hello, Student!")

    IT100 = 2100
    PE1 = 1500
    COMP2 = 2500
    GED1 = 2100

    total_bill = int

    Stud_Type = int(input("Choose: \n New Student (1)  \n Old Student (2): "))
    
    if Stud_Type == 1:
        print("Welcome New Student")
    
        s_name = str(input("Enter your Name: "))
        s_bday = str(input("Enter your Birthday: "))
        s_address = str(input("Enter your Address: "))

        print("IT100        Php2,100.00")
        print("PE1          Php1,500.00")
        print("COMP2        Php2,500.00") 
        print("GED1         Php2,100.00")

        enrollment = str(input("Do you want to enroll? Y/N"))

        match enrollment:
            case "Y":
                print("Enrollment Summary: ")
                print("     Student Name: " + s_name) 
                print("     Birthday:" + s_bday)
                print("     Address: " + s_address)

                print("Subjects to be Enrolled: ")
                print("     IT100        Php2,100.00")
                print("     PE1          Php1,500.00")
                print("     COMP2        Php2,500.00") 
                print("     GED1         Php2,100.00")

                total_bill = IT100 + PE1 + COMP2 + GED1

                print("The total bill would be: ", total_bill)
    
            case "N": 
                print("Thanks for inquiring!")

    elif Stud_Type == 2: 
        print("Welcomeback to our loyal student!")

        s_name = str(input("Enter your Name: "))
        s_bday = str(input("Enter your Birthday: "))
        s_address = str(input("Enter your Address: "))

        print("Subject choices: \n NET1      Php2,500.00 \n ENG22   Php2,100.00 \n ITP3        Php2,500.00 \n ITE6        Php2,100.00 \n CWTS     Php2,000.00")
        print("COMP6  Php2,500.00 \n ITP13      Php2,100.00 \n ITP5        Php2,500.00 \n ITP10      Php2,100.00 \n WAM1    Php2,500.00")

        subject_pricing = {
            'NET1': 2500.00,
            'ENG22': 2100.00,
            'ITP3': 2500.00,
            'ITE6': 2100.00,
            'CWTS': 2000.00,
            'COMP6': 2500.00,
            'ITP13': 2100.00,
            'ITP5': 2500.00,
            'ITP10': 2100.00,
            'WAM1': 2500.00
    }

        print("Choose 4 Subjects to Enroll")
        for subject, value in subject_pricing.items():
            print(f"{subject} {value}")

        sub1 = input("1st Subject: ")
        sub2 = input("2nd Subject: ")
        sub3 = input("3rd Subject: ")
        sub4 = input("4th Subject: ")

        total_bill = subject_pricing.get(sub1, 0) + subject_pricing.get(sub2, 0) + subject_pricing.get(sub3, 0) + subject_pricing.get(sub4, 0) 

        print("Enrollment Summary: ")
        print("     Student Name: " + s_name) 
        print("     Birthday:" + s_bday)
        print("     Address: " + s_address)

        print("Subjects to be Enrolled: ")
        print(f"{sub1}")
        print(f"{sub2}")
        print(f"{sub3}") 
        print(f"{sub4}")

        print("The total bill would be: ", total_bill)

    else: 
        print("Invalid choice. Please choose 1 or 2")

    new_enrollment = input("Do you want another enrollment? (Y/N)")
    if new_enrollment.upper() != 'Y':
        break