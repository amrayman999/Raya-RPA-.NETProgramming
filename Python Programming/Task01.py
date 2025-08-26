import random

def GenerateRandomPassword(length = 12):
   if length < 12:
      raise ValueError("Password length should be at least 12 characters.")
   capital = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
   small = "abcdefghijklmnopqrstuvwxyz"
   numbers = "0123456789" 
   special = "!@#$%^&*"

   all = small + capital + numbers + special
   password = [
        random.choice(capital),
        random.choice(special)
    ]
   password += [random.choice(all) for _ in range(length - 2)]
   random.shuffle(password)
   return "".join(password)

print(GenerateRandomPassword(10))
    