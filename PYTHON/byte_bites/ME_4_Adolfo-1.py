def trackbudgetexpenses():
    budget = int(input("Input how much is your budget: "))

    school = int(input("Input your expenses on School: "))
    electricty = int(input("Input your expenses on Electricity: "))
    internet = int(input("Input your expenses on Internet: "))
    water = int(input("Input your expenses on Water: "))
    house = int(input("Input your expenses on Rent/House: "))
    grocery = int(input("Input your expenses on Grocery: "))
    selfcare = int(input("Input your expenses on Self-Care(haircut, etc.): "))
    transportation = int(input("Transportation: "))
    other = int (input("Enter your other expenses: "))

    total_expenses = school + electricty + internet + water + house + grocery + selfcare + transportation + other

    rembud = budget - total_expenses 

    expenditure = (budget - total_expenses) / budget * 100  

    summary = print(f"You have spent {total_expenses} out of {budget}\n Your remaining budget is {rembud} \n You have spent {expenditure}% of your budget")

    return summary

print ({trackbudgetexpenses()})