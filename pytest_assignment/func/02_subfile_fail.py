import submission2
import pytest


def test_subfile():
    file = "ggg"
    sub = submission2.submitfile(file)
    assert sub