import pytest
import contact

def test_contactta():
    taname = "jason"
    result = contact.cont(taname)
    assert result