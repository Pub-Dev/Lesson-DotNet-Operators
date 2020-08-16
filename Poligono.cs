namespace Operators
{
    public class Poligono
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }
        public int LadoD { get; set; }
        public int Perimetro => LadoA + LadoB + LadoC + LadoD;

        public Poligono()
        {
        }

        public Poligono(int ladoA, int ladoB, int ladoC, int ladoD)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
            LadoD = ladoD;
        }

        public static Poligono operator +(Poligono poligonoA, Poligono poligonoB)
        {
            return new Poligono()
            {
                LadoA = poligonoA.LadoA + poligonoB.LadoA,
                LadoB = poligonoA.LadoB + poligonoB.LadoB,
                LadoC = poligonoA.LadoC + poligonoB.LadoC,
                LadoD = poligonoA.LadoD + poligonoB.LadoD,
            };
        }

        public static Poligono operator -(Poligono poligonoA, Poligono poligonoB)
        {
            return new Poligono()
            {
                LadoA = poligonoA.LadoA - poligonoB.LadoA,
                LadoB = poligonoA.LadoB - poligonoB.LadoB,
                LadoC = poligonoA.LadoC - poligonoB.LadoC,
                LadoD = poligonoA.LadoD - poligonoB.LadoD,
            };
        }

        public static Poligono operator *(Poligono poligonoA, Poligono poligonoB)
        {
            return new Poligono()
            {
                LadoA = poligonoA.LadoA * poligonoB.LadoA,
                LadoB = poligonoA.LadoB * poligonoB.LadoB,
                LadoC = poligonoA.LadoC * poligonoB.LadoC,
                LadoD = poligonoA.LadoD * poligonoB.LadoD,
            };
        }

        public static Poligono operator /(Poligono poligonoA, Poligono poligonoB)
        {
            return new Poligono()
            {
                LadoA = poligonoA.LadoA / poligonoB.LadoA,
                LadoB = poligonoA.LadoB / poligonoB.LadoB,
                LadoC = poligonoA.LadoC / poligonoB.LadoC,
                LadoD = poligonoA.LadoD / poligonoB.LadoD,
            };
        }

        public static Poligono operator ++(Poligono poligono)
        {
            poligono.LadoA++;
            poligono.LadoB++;
            poligono.LadoC++;
            poligono.LadoD++;

            return poligono;
        }

        public static Poligono operator --(Poligono poligono)
        {
            poligono.LadoA--;
            poligono.LadoB--;
            poligono.LadoC--;
            poligono.LadoD--;

            return poligono;
        }

        public static bool operator >(Poligono poligonoA, Poligono poligonoB)
        {
            return poligonoA.Perimetro > poligonoB.Perimetro;
        }

        public static bool operator <(Poligono poligonoA, Poligono poligonoB)
        {
            return poligonoA.Perimetro < poligonoB.Perimetro;
        }

        public static bool operator >=(Poligono poligonoA, Poligono poligonoB)
        {
            return poligonoA.Perimetro >= poligonoB.Perimetro;
        }

        public static bool operator <=(Poligono poligonoA, Poligono poligonoB)
        {
            return poligonoA.Perimetro <= poligonoB.Perimetro;
        }

        public static bool operator ==(Poligono poligonoA, Poligono poligonoB)
        {
            return poligonoA.Perimetro == poligonoB.Perimetro;
        }

        public static bool operator !=(Poligono poligonoA, Poligono poligonoB)
        {
            return poligonoA.Perimetro != poligonoB.Perimetro;
        }

        public static explicit operator Poligono(Quadrado retangulo)
        {
            return new Poligono()
            {
                LadoA = retangulo.LadoA,
                LadoB = retangulo.LadoA,
                LadoC = retangulo.LadoA,
                LadoD = retangulo.LadoA
            };
        }

        public static implicit operator Poligono(Retangulo retangulo)
        {
            return new Poligono()
            {
                LadoA = retangulo.LadoA,
                LadoB = retangulo.LadoB,
                LadoC = retangulo.LadoA,
                LadoD = retangulo.LadoB
            };
        }

        public override string ToString()
        {
            return $"LadoA = {LadoA}\nLadoB = {LadoB}\nLadoC = {LadoC}\nLadoD = {LadoD}";
        }
    }
}