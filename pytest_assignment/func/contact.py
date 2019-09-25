TA = ["jaboc","jason","veemo"]

def cont(name):
    if name in TA:
        nextstep = True
        print("YOU CAN LEAVE A MESSAGE NOW")
    else:
        nextstep = False
        print("THIS TA IS NOT IN THIS COURSE")
    return nextstep
