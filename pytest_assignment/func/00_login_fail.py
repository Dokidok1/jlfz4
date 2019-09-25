import login
import pytest

def test_login():
    username = "12asa"
    login.checkname(username)
    assert  isinstance(username, int)

def test_password():
    password = "asasad"
    login.checkpass(password)
    assert isinstance(password,int)