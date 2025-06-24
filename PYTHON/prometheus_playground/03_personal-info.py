#!/usr/bin/env python3

space: str = " "
fname: str = input("Enter your first name >>> ")
lname: str = input("Enter your last name >>> ")
loc: str = input("Enter your location >>> ")
age: int = int(input("Enter your age >>> "))
print(space.join((fname,lname,loc,str(age))))
