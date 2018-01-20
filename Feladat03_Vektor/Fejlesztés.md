## Fibonacci sorozat

- Létrehozunk egy egész típusú 50 elemű tömböt
- készítünk egy függvényt, amely generálja a soron követekező fibonacci sorozat elemet.
- Készítünk egy kiíró fügvényt, amely kiírja egymás alá a tömben tárolt elemeket.

### A Main főprogram
- tartalmazza a generált tömböt
- meghívja 50-szer a fibonacci elemt generáló függvényt
- kiíratjuk a tömb elemeit

## fibonacchi elemek elhelyezése tömbben

        public static void  fibonacchiTombFeltotles(ref int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                if (i== 0) { tomb[0] = 0; }
                if (i== 1) { tomb[1] = 1; }
                tomb[i] = tomb[i - 2] + tomb[i - 1];
            }
        }

Az algoritmus a cím szerint átadott tombot feltölti a fibbonacchi sorozat elemeivel.
Mivel a tomb deklarálásakor meg kell adni a tömb hosszát ezért tudjuk feltolteni a teljes hosszig.

