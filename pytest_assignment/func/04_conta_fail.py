import pytest
import contact

def test_contactta():
    taname = "mason"
    result = contact.cont(taname)
    assert result