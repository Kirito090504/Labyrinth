#!/usr/bin/env python3

import random

i = 0
n = []
while i < 10:
    # insert random numbers to n
    n.append(random.randint(0,10))
    i += 1

for num in n:
    # tell whether num is even or odd
    print("Even" if num % 2 == 0 else "Odd")
