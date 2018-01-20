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

## fibonacchi tömb elemeinek kiíratása

A tomb minden elemét bejárjuk és új sorba formázottan kiírjuk.
A formázás során a 0. paraméter {0} felveszi az i, az 1. paramtéer {1} felveszi a tomb i-edik elemének tomb[i] értékét.

## Probléma

Az 50 elemő tömb feltöltése során - mivel a sorozat nagyon gyorsan nő  - **túlcsordulás lép fel**.


44. elem: 701408733
45. elem: 1134903170
46. elem: 1836311903
47. elem: -1323752223
48. elem: 512559680
49. elem: -811192543

Ez a 47. elemnél látható, így meg kell változtatni a tömb elemeinek típusát.
A típust int -ről ulong-ra változtattam, így:

- az előjeles 32 bites egész szám (**int**) lehetséges legnagyobb értékét (2 147 483 647)
- előjel nélküli 64bites egészre (**ulong**) cseréljük (18 446 744 073 709 551 615)



