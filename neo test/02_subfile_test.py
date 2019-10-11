import submission2
import pytest


def test_subfile():
    file = "doc"
    sub = submission2.submitfile(file)
    assert sub