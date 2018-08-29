
import collections.abc
import math

class MyMapping(collections.abc.Mapping):
    def function(self):
        pass

    def get(self, key, default = None):

        return super().get(key, default)


tau = math.tau
pi = math.pi
if math.isclose(tau, pi * 2):
    print("Indeed, t = 2p")
else: 
    print("Oh no, my clircles are broken")
