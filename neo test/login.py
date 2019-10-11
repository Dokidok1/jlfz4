def checkname(user_input): 
    try:
       val = str(user_input)
       print("Yes input string is an string.")
       print("Input is: ", val)
    except ValueError:
       print("That's not an int!")
       print("No.. input string is not an Integer. It's a string")

def checkpass(user2):
    try:
       val = str(user2)
       print("this password is valid.")
    except ValueError:
       print("please enter valid password")
       print("No.. input string is not an Integer. It's a string")
