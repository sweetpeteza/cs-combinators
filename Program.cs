using static System.Console;
using static System.String;
using static FunctionalProgramming.Combinators;

WriteLine("I: ({0}) -> {1}", 42, I(42)); // Outputs 42
WriteLine("W: ((x, y) => x * y)({0}) -> {1}", 3, W<int, int>((x, y) => x * y)(3)); // Outputs 9
WriteLine("C: ((x, y) => x - y)({0}, {1}) -> {2}", 5, 3, C<int, int, int>((x, y) => x - y)(5, 3)); // Outputs -2
WriteLine("B: ((x) => x.ToUpper(), (x) => new string(x.Where(c => !\"aeiouAEIOU\".Contains(c)).ToArray()))({0}) -> {1}", "hello world", B<string, string, string>((x) => x.ToUpper(), (x) => new string(x.Where(c => !"aeiouAEIOU".Contains(c)).ToArray()))("hello world")); // Outputs "HLL WRLD"
WriteLine("S: ((x, y) => x + y, (x) => x * 2)({0}) -> {1}", 3, S<int, int, int>((x, y) => x + y, (x) => x * 2)(3)); // Outputs 12
WriteLine("D: ((x, y) => x + y, (x) => x * 2)({0}, {1}) -> {2}", 3, 4, D<int, int, int, int>((x, y) => x + y, (x) => x * 2)(3, 4)); // Outputs 11
WriteLine("B_1: ((x) => x * 2, (x, y) => x + y)({0}, {1}) -> {2}", 3, 4, B_1<int, int, int, int>((x) => x * 2, (x, y) => x + y)(3, 4)); // Outputs 14
WriteLine("Psi: ((x, y) => x + y, (x) => x * 2)({0}, {1}) -> {2}", 4, 5, Psi<int, int, int>((x, y) => x + y, (x) => x * 2)(4, 5)); // Outputs 18
WriteLine("Phi: ((x) => x * 2, (x, y) => x + y, (x) => x + 1)({0}) -> {1}", 3, Phi<int, int, int, int>((x) => x * 2, (x, y) => x + y, (x) => x + 1)(3)); // Outputs 10
WriteLine("D_2: ((x) => x * 2, (x, y) => x + y, (x) => x + 1)({0}, {1}) -> {2}", 3, 4, D_2<int, int, int, int, int>((x) => x * 2, (x, y) => x + y, (x) => x + 1)(3, 4)); // Outputs 11
WriteLine("Phi_1: ((x, y) => x + y, (x, y) => (x + y) * 2, (x, y) => x - y)({0}, {1}) -> {2}", 3, 4, Phi_1<int, int, int, int, int>((x, y) => x + y, (x, y) => (x + y) * 2, (x, y) => x - y)(3, 4)); // Outputs 13
WriteLine("Left: ({0}, {1}) -> {2}", 42, "hello", Left(42, "hello")); // Outputs 42
WriteLine("Right: ({0}, {1}) -> {2}", 42, "hello", Right(42, "hello")); // Outputs 100
