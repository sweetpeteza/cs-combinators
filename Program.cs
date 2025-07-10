using static System.Console;
using static FunctionalProgramming.Combinators;

Func<int, int, int> multiply = (x, y) => x * y;
Func<int, int, int> minus = (x, y) => x - y;
Func<string, string> toUpper = (x) => x.ToUpper();
Func<string, string> removeVowels = (x) => new string(x.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
Func<int, int, int> add = (x, y) => x + y;
Func<int, int> doubleIt = (x) => x * 2;
Func <int, int> increment = (x) => x + 1;
Func <int, int, int> addAndDouble = (x, y) => (x + y) * 2;

WriteLine(
"""
SETUP:
-------
Func<int, int, int> multiply = (x, y) => x * y;
Func<int, int, int> minus = (x, y) => x - y;
Func<string, string> toUpper = (x) => x.ToUpper();
Func<string, string> removeVowels = (x) => new string(x.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
Func<int, int, int> add = (x, y) => x + y;
Func<int, int> doubleIt = (x) => x * 2;
Func <int, int> increment = (x) => x + 1;
Func <int, int, int> addAndDouble = (x, y) => (x + y) * 2;
-------
""");

WriteLine(
"""
Combinators:
-------
""");

WriteLine("I: ({0}) -> {1}", 42, I(42)); // Outputs 42

WriteLine("W: ((x, y) => x * y)({0}) -> {1}", 3, W(multiply)(3)); // Outputs 9

WriteLine("C: ((x, y) => x - y)({0}, {1}) -> {2}", 5, 3, C(minus)(5, 3)); // Outputs -2

WriteLine("B: (toUpper, removeVowels)({0}) -> {1}", "hello world", B(toUpper, removeVowels)("hello world")); // Outputs "HLL WRLD"

WriteLine("S: (add, doubleIt)({0}) -> {1}", 3, S(add, doubleIt)(3)); // Outputs 12

WriteLine("D: (add, doubleIt)({0}, {1}) -> {2}", 3, 4, D(add, doubleIt)(3, 4)); // Outputs 11

WriteLine("B_1: ((x) => x * 2, (x, y) => x + y)({0}, {1}) -> {2}", 3, 4, B_1(doubleIt, add)(3, 4)); // Outputs 14

WriteLine("Psi: ((x, y) => x + y, (x) => x * 2)({0}, {1}) -> {2}", 4, 5, Psi(add, doubleIt)(4, 5)); // Outputs 18

WriteLine("Phi: ((x) => x * 2, (x, y) => x + y, (x) => x + 1)({0}) -> {1}", 3, Phi(doubleIt, add, increment)(3)); // Outputs 10

WriteLine("D_2: (doubleIt, add, increment)({0}, {1}) -> {2}", 3, 4, D_2(doubleIt, add, increment)(3, 4)); // Outputs 11

WriteLine("Phi_1: (add, addAndDouble, minus)({0}, {1}) -> {2}", 3, 4, Phi_1(add, addAndDouble, minus)(3, 4)); // Outputs 13

WriteLine("Left: ({0}, {1}) -> {2}", 42, "hello", Left(42, "hello")); // Outputs 42

WriteLine("Right: ({0}, {1}) -> {2}", 42, "hello", Right(42, "hello")); // Outputs 100
