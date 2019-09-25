import pytest
import resubmit

def test_resub():
    resu = 2
    resul = resubmit.resub(resu)
    assert resul