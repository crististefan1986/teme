using System.Collections.Generic;

namespace GrupeDeSange
{
    public static class GrupeDeSange
    {
        public static List<Grupe> CompatibilCu(Grupe grupa)
        {
            switch (grupa)
            {
                case Grupe.A:
                    return new List<Grupe> { Grupe.A, Grupe.Zero };
                case Grupe.B:
                    return new List<Grupe> { Grupe.B, Grupe.Zero };
                case Grupe.AB:
                    return new List<Grupe> { Grupe.A, Grupe.B, Grupe.AB, Grupe.Zero };
                case Grupe.Zero:
                    return new List<Grupe> { Grupe.Zero };
            }

            throw new System.Exception("Nu s-a putut gasi o grupa compatibila!!");
        }
    }

    public enum Grupe
    {
        Zero = 1,
        A = 2,
        B = 3,
        AB = 4
    }
}
