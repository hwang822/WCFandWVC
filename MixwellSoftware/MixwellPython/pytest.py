# pytest it stest frame work
# https://www.youtube.com/watch?v=l32bsaIDoWk
# python provide automation tester  unittest, nose, pytest
# unitest

import mathlib
import pytest
def test_calc_total():
    total = mathlib.calc_total(4, 5)
    assert total == 9
    
def test_calc_mulitiply():
    result = mathlib.calc_mulitiply(10, 3)
    assert result == 30    