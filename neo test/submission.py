course_enrolled =  ["cs2380","cs4320","cs2810"]
assignment_opened = ["lab1","lab2","lab3"]
def course_penal(enter_course):
    if enter_course in course_enrolled:
        nextstep = True
        print("choose a assignment")
    else:
        nextstep = False
        print("you did not enroll this course")
    return nextstep

def choose_ass(enter_ass):
    if enter_ass in assignment_opened:
        nex = True
        print("this assignment is avaliable to submit")
    else:
        nex = False
        print("this assignment is not opened")
    return nex