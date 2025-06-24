num_rows = 5
num_cols = 7

for row in range(num_rows):
  for col in range(num_cols):
    if (row == 0 or row == num_rows - 1) and (col == 0 or col == num_cols - 1):
      print(' * ', end='')
    else:
      print(' * ', end='')
  print()  