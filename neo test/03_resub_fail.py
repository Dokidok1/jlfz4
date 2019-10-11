import pytest
import resubmit

def test_resub():
    resu = 5
    resul = resubmit.resub(resu)
    assert resul