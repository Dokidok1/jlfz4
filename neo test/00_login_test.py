import login
import pytest

def test_login():
    username = "12asa"
    login.checkname(username)
    assert  isinstance(username, str)

def test_password():
    password = "asasad"
    login.checkpass(password)
    assert isinstance(password,str)