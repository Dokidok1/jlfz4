import submission
import pytest


def test_sub():
    course = "cs2810"
    sub = submission.course_penal(course)
    assert sub
def test_assign():
    assign = "lab1"
    init = submission.choose_ass(assign)
    assert init