namespace FunctionalProgramming;

public class Combinators
{
    // Combinator Lambda Expression

    // I 𝜆a.a
    public static A I<A>(A input) => input;
    // K 𝜆ab.a
    public static Func<B, A> K<A, B>(A input) => (_) => input;
    // W 𝜆ab.abb
    public static Func<A, B> W<A, B>(Func<A, A, B> f) => (x) => f(x, x);
    // C 𝜆abc.acb
    public static Func<B, A, C> C<A, B, C>(Func<A, B, C> f) => (x, y) => f(y, x);
    // B 𝜆abc.a(bc)
    public static Func<A, C> B<A, B, C>(Func<B, C> f, Func<A, B> g) => (x) => f(g(x));
    // S 𝜆abc.ac(bc)
    public static Func<A, C> S<A, B, C>(Func<B, B, C> f, Func<A, B> g) => (x) => f(g(x), g(x));
    // D 𝜆abcd.ab(cd)
    public static Func<C, A, D> D<A, B, C, D>(Func<C, B, D> f, Func<A, B> g) => (x, y) => f(x, g(y));
    // B1 𝜆abcd.a(bcd)
    public static Func<A, B, D> B_1<A, B, C, D>(Func<C, D> f, Func<A, B, C> g) => (x, y) => f(g(x, y));
    // Ψ 𝜆abcd.a(bc)(bd)
    public static Func<A, A, C> Psi<A, B, C>(Func<B, B, C> f, Func<A, B> g) => (x, y) => f(g(x), g(y));
    // Φ 𝜆abcd.a(bd)(cd)
    public static Func<A, D> Phi<A, B, C, D>(Func<A, B> f, Func<B, C, D> g, Func<A, C> h) => (x) => g(f(x), h(x));
    // D2 𝜆abcde.a(bd)(ce)
    public static Func<A, B, E> D_2<A, B, C, D, E>(Func<A, C> f, Func<C, D, E> g, Func<B, D> h) => (x, y) => g(f(x), h(y));
    // Φ1 𝜆abcde.a(bde)(cde)
    public static Func<A, B, E> Phi_1<A, B, C, D, E>(Func<C, D, E> f, Func<A, B, C> g, Func<A, B, D> h) => (x, y) => f(g(x, y), h(x, y));
    // not part of the original combinators but useful
    public static A Left<A, B>(A x, B _y) => x;//K
    public static B Right<A, B>(A _x, B y) => y;//CK

    // TODO: Implement the following combinators
    // E 𝜆abcde.ab(cde)
    // Ê 𝜆abcdefg.a(bde)(cfg)
}
