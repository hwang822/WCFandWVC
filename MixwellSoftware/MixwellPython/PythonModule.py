from math import sin, cos, radians
import sys

def make_dot_string(x):
    return ' '*int(10*cos(radians(x))+10) + '0'

assert make_dot_string(90) == '           0'
assert make_dot_string(180) == '0'

def main():
    for i in range(10000000):
        s = make_dot_string(i)

if __name__ == "__main__":
    sys.exit(int(main() or 0))
    
