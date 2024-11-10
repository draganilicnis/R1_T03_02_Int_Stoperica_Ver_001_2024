// https://petlja.org/sr-Cyrl-RS/kurs/14606/5/1318
// https://petlja.org/sr-Cyrl-RS/kurs/14606/35/1394
// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/02%20Tipovi_detaljniji_pregled/02%20celobrojni_tip/02%20Baratanje_bitovima

using System;
using System.Diagnostics;

class R1_T03_02_Int_Stoperica_Ver_001_2024
{
    static public int N = 1000 * 1000 * 1000;
    static void Main()
    {
        Stopwatch t = new Stopwatch();

        // int      4B  = 32b   = 2 ^ 31 =   2 * 10^8     =             2 147 483 647
        Console.WriteLine(); Console.Write("int   ");
        t.Start(); Ceo_001_int_001_sab(); t.Stop(); Console.Write(" sab: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_001_int_002_odu(); t.Stop(); Console.Write(" odu: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_001_int_003_mno(); t.Stop(); Console.Write(" mno: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_001_int_004_del(); t.Stop(); Console.Write(" del: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_001_int_005_mod(); t.Stop(); Console.Write(" mod: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_001_int_006_mn2(); t.Stop(); Console.Write(" mn2: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_001_int_007_de2(); t.Stop(); Console.Write(" de2: "); Console.Write(t.Elapsed); t.Reset();

        // uint     4B  = 32b   = 2 ^ 32 =   4 * 10^8     =             4 294 967 295
        Console.WriteLine(); Console.Write("uint  ");
        t.Start(); Ceo_001_uint_001_sab(); t.Stop(); Console.Write(" sab: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_001_uint_002_odu(); t.Stop(); Console.Write(" odu: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_001_uint_003_mno(); t.Stop(); Console.Write(" mno: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_001_uint_004_del(); t.Stop(); Console.Write(" del: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_001_uint_005_mod(); t.Stop(); Console.Write(" mod: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_001_uint_006_mn2(); t.Stop(); Console.Write(" mn2: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_001_uint_007_de2(); t.Stop(); Console.Write(" de2: "); Console.Write(t.Elapsed); t.Reset();

        // long      8B  = 64b   = 2 ^ 63 =  9 * 10^18   =  9 223 372 036 854 775 807
        Console.WriteLine(); Console.Write("long  ");
        t.Start(); Ceo_002_long_001_sab(); t.Stop(); Console.Write(" sab: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_002_long_002_odu(); t.Stop(); Console.Write(" odu: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_002_long_003_mno(); t.Stop(); Console.Write(" mno: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_002_long_004_del(); t.Stop(); Console.Write(" del: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_002_long_005_mod(); t.Stop(); Console.Write(" mod: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_002_long_006_mn2(); t.Stop(); Console.Write(" mn2: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_002_long_007_de2(); t.Stop(); Console.Write(" de2: "); Console.Write(t.Elapsed); t.Reset();

        // ulong     8B  = 64b   = 2 ^ 64 = 18 * 10^18   = 18 446 744 073 709 551 615
        Console.WriteLine(); Console.Write("ulong ");
        t.Start(); Ceo_002_ulong_001_sab(); t.Stop(); Console.Write(" sab: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_002_ulong_002_odu(); t.Stop(); Console.Write(" odu: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_002_ulong_003_mno(); t.Stop(); Console.Write(" mno: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_002_ulong_004_del(); t.Stop(); Console.Write(" del: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_002_ulong_005_mod(); t.Stop(); Console.Write(" mod: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_002_ulong_006_mn2(); t.Stop(); Console.Write(" mn2: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_002_ulong_007_de2(); t.Stop(); Console.Write(" de2: "); Console.Write(t.Elapsed); t.Reset();

        // Int64      8B  = 64b   = 2 ^ 63 =  9 * 10^18  =  9 223 372 036 854 775 807
        Console.WriteLine(); Console.Write("Int64 ");
        t.Start(); Ceo_003_Int64_001_sab(); t.Stop(); Console.Write(" sab: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_003_Int64_002_odu(); t.Stop(); Console.Write(" odu: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_003_Int64_003_mno(); t.Stop(); Console.Write(" mno: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_003_Int64_004_del(); t.Stop(); Console.Write(" del: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_003_Int64_005_mod(); t.Stop(); Console.Write(" mod: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_003_Int64_006_mn2(); t.Stop(); Console.Write(" mn2: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_003_Int64_007_de2(); t.Stop(); Console.Write(" de2: "); Console.Write(t.Elapsed); t.Reset();

        // UInt64     8B  = 64b   = 2 ^ 64 = 18 * 10^18  = 18 446 744 073 709 551 615
        Console.WriteLine(); Console.Write("UInt64");
        t.Start(); Ceo_003_UInt64_001_sab(); t.Stop(); Console.Write(" sab: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_003_UInt64_002_odu(); t.Stop(); Console.Write(" odu: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_003_UInt64_003_mno(); t.Stop(); Console.Write(" mno: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_003_UInt64_004_del(); t.Stop(); Console.Write(" del: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_003_UInt64_005_mod(); t.Stop(); Console.Write(" mod: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_003_UInt64_006_mn2(); t.Stop(); Console.Write(" mn2: "); Console.Write(t.Elapsed); t.Reset();
        t.Start(); Ceo_003_UInt64_007_de2(); t.Stop(); Console.Write(" de2: "); Console.Write(t.Elapsed); t.Reset();
    }

    // int
    static void Ceo_001_int_001_sab()
    {
        int B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B++;
    }
    static void Ceo_001_int_002_odu()
    {
        int B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B--;
    }
    static void Ceo_001_int_003_mno()
    {
        int B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B * 2;
    }
    static void Ceo_001_int_004_del()
    {
        int B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B / 2;
    }
    static void Ceo_001_int_005_mod()
    {
        int B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B % 2;
    }
    static void Ceo_001_int_006_mn2()
    {
        int B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B << 2;
    }
    static void Ceo_001_int_007_de2()
    {
        int B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B >> 2;
    }

    // uint
    static void Ceo_001_uint_001_sab()
    {
        uint B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B++;
    }
    static void Ceo_001_uint_002_odu()
    {
        uint B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B--;
    }
    static void Ceo_001_uint_003_mno()
    {
        uint B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B * 2;
    }
    static void Ceo_001_uint_004_del()
    {
        uint B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B / 2;
    }
    static void Ceo_001_uint_005_mod()
    {
        uint B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B % 2;
    }
    static void Ceo_001_uint_006_mn2()
    {
        uint B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B << 2;
    }
    static void Ceo_001_uint_007_de2()
    {
        uint B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B >> 2;
    }

    // long
    static void Ceo_002_long_001_sab()
    {
        long B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B++;
    }
    static void Ceo_002_long_002_odu()
    {
        long B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B--;
    }
    static void Ceo_002_long_003_mno()
    {
        long B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B * 2;
    }
    static void Ceo_002_long_004_del()
    {
        long B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B / 2;
    }
    static void Ceo_002_long_005_mod()
    {
        long B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B % 2;
    }
    static void Ceo_002_long_006_mn2()
    {
        long B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B << 2;
    }
    static void Ceo_002_long_007_de2()
    {
        long B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B >> 2;
    }
    
    // ulong
    static void Ceo_002_ulong_001_sab()
    {
        ulong B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B++;
    }
    static void Ceo_002_ulong_002_odu()
    {
        ulong B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B--;
    }
    static void Ceo_002_ulong_003_mno()
    {
        ulong B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B * 2;
    }
    static void Ceo_002_ulong_004_del()
    {
        ulong B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B / 2;
    }
    static void Ceo_002_ulong_005_mod()
    {
        ulong B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B % 2;
    }
    static void Ceo_002_ulong_006_mn2()
    {
        ulong B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B << 2;
    }
    static void Ceo_002_ulong_007_de2()
    {
        ulong B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B >> 2;
    }

    // Int64
    static void Ceo_003_Int64_001_sab()
    {
        Int64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B++;
    }
    static void Ceo_003_Int64_002_odu()
    {
        Int64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B--;
    }
    static void Ceo_003_Int64_003_mno()
    {
        Int64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B * 2;
    }
    static void Ceo_003_Int64_004_del()
    {
        Int64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B / 2;
    }
    static void Ceo_003_Int64_005_mod()
    {
        Int64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B % 2;
    }
    static void Ceo_003_Int64_006_mn2()
    {
        Int64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B << 2;
    }
    static void Ceo_003_Int64_007_de2()
    {
        Int64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B >> 2;
    }

    // UInt64
    static void Ceo_003_UInt64_001_sab()
    {
        UInt64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B++;
    }
    static void Ceo_003_UInt64_002_odu()
    {
        UInt64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B--;
    }
    static void Ceo_003_UInt64_003_mno()
    {
        UInt64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B * 2;
    }
    static void Ceo_003_UInt64_004_del()
    {
        UInt64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B / 2;
    }
    static void Ceo_003_UInt64_005_mod()
    {
        UInt64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B % 2;
    }
    static void Ceo_003_UInt64_006_mn2()
    {
        UInt64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B << 2;
    }
    static void Ceo_003_UInt64_007_de2()
    {
        UInt64 B = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < N; i++) B = B >> 2;
    }
}
