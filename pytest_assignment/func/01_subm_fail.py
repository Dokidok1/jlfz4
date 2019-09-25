import submission
import pytest


def test_sub():
    course = "jojo"
    sub = submission.course_penal(course)
    assert sub
def test_assign():
    assign = "jojo"
    init = submission.choose_ass(assign)
    assert init