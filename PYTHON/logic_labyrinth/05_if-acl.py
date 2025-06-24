#!/usr/bin/env python3

import random

num = random.randint(0,10)
guess = int(input("Enter your guess (0-10) >>> "))

if guess > num:
    print("Your guess is greater than the number.")

elif guess < num:
    print("Your guess is less than the number.")

else:
    print("You have guessed the number!")

print(f"The number is {num}.")
