// https://petlja.org/sr-Cyrl-RS/kurs/14606/5/1318
// https://petlja.org/sr-Latn-RS/kurs/14606/4/1314
// https://petlja.org/sr-Cyrl-RS/kurs/14606/35/1394
// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/02%20Tipovi_detaljniji_pregled/02%20celobrojni_tip/02%20Baratanje_bitovima
// https://github.com/draganilicnis/R1_T03_02_Int_Stoperica_Ver_001_2024/blob/main/R1_T03_02_Int_Stoperica_Ver_001_2024.cs
// https://onlinegdb.com/uAOWGsVIV_

using System;
using System.Diagnostics;
using System.Numerics;

class R1_T03_02_Int_Stoperica_Ver_001_2024
{
    static public int N = 1000 * 1000 * 1000;
    static public int B = 1000 * 1000 * 1000 + 7;
    static void Main()
    {

        Stopwatch t = new Stopwatch();

        Console.Write("++".PadLeft(24) + "--".PadLeft(17) + "*2".PadLeft(17) + "/2".PadLeft(17) + "%2".PadLeft(17) + "<<1".PadLeft(17) + ">>1".PadLeft(17));

        // int      4B  = 32b   = 2 ^ 31 =   2 * 10^8     =             2 147 483 647
        int a = B;
        Console.WriteLine(); Console.Write("int:".PadRight(8));
        t.Start(); Ceo_001_int_001_sab(a); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_001_int_002_odu(a); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_001_int_003_mno(a); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_001_int_004_del(a); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_001_int_005_mod(a); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_001_int_006_mn2(a); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_001_int_007_de2(a); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        // uint     4B  = 32b   = 2 ^ 32 =   4 * 10^8     =             4 294 967 295
        uint b = (uint)B;
        Console.WriteLine(); Console.Write("uint:".PadRight(8));
        t.Start(); Ceo_001_uint_001_sab(b); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_001_uint_002_odu(b); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_001_uint_003_mno(b); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_001_uint_004_del(b); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_001_uint_005_mod(b); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_001_uint_006_mn2(b); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_001_uint_007_de2(b); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        // long      8B  = 64b   = 2 ^ 63 =  9 * 10^18   =  9 223 372 036 854 775 807
        long c = (long)B;
        Console.WriteLine(); Console.Write("long:".PadRight(8));
        t.Start(); Ceo_002_long_001_sab(c); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_002_long_002_odu(c); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_002_long_003_mno(c); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_002_long_004_del(c); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_002_long_005_mod(c); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_002_long_006_mn2(c); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_002_long_007_de2(c); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        // ulong     8B  = 64b   = 2 ^ 64 = 18 * 10^18   = 18 446 744 073 709 551 615
        ulong d = (ulong)B;
        Console.WriteLine(); Console.Write("ulong:".PadRight(8));
        t.Start(); Ceo_002_ulong_001_sab(d); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_002_ulong_002_odu(d); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_002_ulong_003_mno(d); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_002_ulong_004_del(d); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_002_ulong_005_mod(d); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_002_ulong_006_mn2(d); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_002_ulong_007_de2(d); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        // Int64      8B  = 64b   = 2 ^ 63 =  9 * 10^18  =  9 223 372 036 854 775 807
        Int64 e = (Int64)B;
        Console.WriteLine(); Console.Write("Int64:".PadRight(8));
        t.Start(); Ceo_003_Int64_001_sab(e); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_003_Int64_002_odu(e); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_003_Int64_003_mno(e); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_003_Int64_004_del(e); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_003_Int64_005_mod(e); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_003_Int64_006_mn2(e); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_003_Int64_007_de2(e); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        // UInt64     8B  = 64b   = 2 ^ 64 = 18 * 10^18  = 18 446 744 073 709 551 615
        UInt64 f = (UInt64)B;
        Console.WriteLine(); Console.Write("UInt64:".PadRight(8));
        t.Start(); Ceo_003_UInt64_001_sab(f); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_003_UInt64_002_odu(f); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_003_UInt64_003_mno(f); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_003_UInt64_004_del(f); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_003_UInt64_005_mod(f); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_003_UInt64_006_mn2(f); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_003_UInt64_007_de2(f); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        // short      2B  = 16b   = 2 ^ 15 = 32 * 10^3  =                     32 767
        short g = (short)B;
        Console.WriteLine(); Console.Write("short:".PadRight(8));
        t.Start(); Ceo_004_short_001_sab(g); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_004_short_002_odu(g); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_004_short_003_mno(g); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_004_short_004_del(g); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_004_short_005_mod(g); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_004_short_006_mn2(g); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_004_short_007_de2(g); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        // ushort      2B  = 16b   = 2 ^ 16 = 65 * 10^3  =                     65 535
        ushort h = (ushort)B;
        Console.WriteLine(); Console.Write("ushort:".PadRight(8));
        t.Start(); Ceo_004_ushort_001_sab(h); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_004_ushort_002_odu(h); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_004_ushort_003_mno(h); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_004_ushort_004_del(h); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_004_ushort_005_mod(h); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_004_ushort_006_mn2(h); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_004_ushort_007_de2(h); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        // sbyte      1B  =  8b     = 2 ^ 8 =            =                        255
        sbyte k = (sbyte)B;
        Console.WriteLine(); Console.Write("sbyte:".PadRight(8));
        t.Start(); Ceo_005_sbyte_001_sab(k); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_005_sbyte_002_odu(k); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_005_sbyte_003_mno(k); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_005_sbyte_004_del(k); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_005_sbyte_005_mod(k); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_005_sbyte_006_mn2(k); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_005_sbyte_007_de2(k); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        // byte       1B  =  8b     = 2 ^ 7 =            =                        127
        byte l = (byte)B;
        Console.WriteLine(); Console.Write("byte:".PadRight(8));
        t.Start(); Ceo_005_byte_001_sab(l); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_005_byte_002_odu(l); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_005_byte_003_mno(l); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_005_byte_004_del(l); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_005_byte_005_mod(l); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_005_byte_006_mn2(l); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_005_byte_007_de2(l); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        // BigInteger
        BigInteger G = (BigInteger)B;
        Console.WriteLine(); Console.Write("BigIntr:".PadRight(8));
        t.Start(); Ceo_006_BigInteger_001_sab(G); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_006_BigInteger_002_odu(G); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_006_BigInteger_003_mno(G); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_006_BigInteger_004_del(G); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_006_BigInteger_005_mod(G); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_006_BigInteger_006_mn2(G); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Ceo_006_BigInteger_007_de2(G); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        // float      4B  =  32b    =
        float x = (float)B;
        Console.WriteLine(); Console.Write("float:".PadRight(8));
        t.Start(); Real_001_float_001_sab(x); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Real_001_float_002_odu(x); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Real_001_float_003_mno(x); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Real_001_float_004_del(x); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Real_001_float_005_mod(x); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        // t.Start(); Real_001_float_006_mn2(x); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        // t.Start(); Real_001_float_007_de2(x); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        // double     8B  =  64b    =
        double y = (double)B;
        Console.WriteLine(); Console.Write("double:".PadRight(8));
        t.Start(); Real_002_double_001_sab(y); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Real_002_double_002_odu(y); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Real_002_double_003_mno(y); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Real_002_double_004_del(y); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Real_002_double_005_mod(y); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        // t.Start(); Real_002_double_006_mn2(y); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        // t.Start(); Real_002_double_007_de2(y); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        // decimal   16B  = 128b    =
        decimal z = (decimal)B;
        Console.WriteLine(); Console.Write("decimal:".PadRight(8));
        t.Start(); Real_003_decimal_001_sab(z); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Real_003_decimal_002_odu(z); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Real_003_decimal_003_mno(z); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Real_003_decimal_004_del(z); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        t.Start(); Real_003_decimal_005_mod(z); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        // t.Start(); Real_003_decimal_006_mn2(z); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();
        // t.Start(); Real_003_decimal_007_de2(z); t.Stop(); Console.Write(t.Elapsed + " "); t.Reset();

        Console.WriteLine();
    }

    // int
    static void Ceo_001_int_001_sab(int B) { for (int i = 0; i < N; i++) B++; }
    static void Ceo_001_int_002_odu(int B) { for (int i = 0; i < N; i++) B--; }
    static void Ceo_001_int_003_mno(int B) { for (int i = 0; i < N; i++) B = B * 2;  }
    static void Ceo_001_int_004_del(int B) { for (int i = 0; i < N; i++) B = B / 2;  }
    static void Ceo_001_int_005_mod(int B) { for (int i = 0; i < N; i++) B = B % 2;  }
    static void Ceo_001_int_006_mn2(int B) { for (int i = 0; i < N; i++) B = B << 1; }
    static void Ceo_001_int_007_de2(int B) { for (int i = 0; i < N; i++) B = B >> 1; }

    // uint
    static void Ceo_001_uint_001_sab(uint B) { for (int i = 0; i < N; i++) B++;  }
    static void Ceo_001_uint_002_odu(uint B) { for (int i = 0; i < N; i++) B--;  }
    static void Ceo_001_uint_003_mno(uint B) { for (int i = 0; i < N; i++) B = B * 2;  }
    static void Ceo_001_uint_004_del(uint B) { for (int i = 0; i < N; i++) B = B / 2;  }
    static void Ceo_001_uint_005_mod(uint B) { for (int i = 0; i < N; i++) B = B % 2;  }
    static void Ceo_001_uint_006_mn2(uint B) { for (int i = 0; i < N; i++) B = B << 1; }
    static void Ceo_001_uint_007_de2(uint B) { for (int i = 0; i < N; i++) B = B >> 1; }

    // long
    static void Ceo_002_long_001_sab(long B) { for (int i = 0; i < N; i++) B++; }
    static void Ceo_002_long_002_odu(long B) { for (int i = 0; i < N; i++) B--; }
    static void Ceo_002_long_003_mno(long B) { for (int i = 0; i < N; i++) B = B * 2;  }
    static void Ceo_002_long_004_del(long B) { for (int i = 0; i < N; i++) B = B / 2;  }
    static void Ceo_002_long_005_mod(long B) { for (int i = 0; i < N; i++) B = B % 2;  }
    static void Ceo_002_long_006_mn2(long B) { for (int i = 0; i < N; i++) B = B << 1; }
    static void Ceo_002_long_007_de2(long B) { for (int i = 0; i < N; i++) B = B >> 1; }
    
    // ulong
    static void Ceo_002_ulong_001_sab(ulong B) { for (int i = 0; i < N; i++) B++; }
    static void Ceo_002_ulong_002_odu(ulong B) { for (int i = 0; i < N; i++) B--; }
    static void Ceo_002_ulong_003_mno(ulong B) { for (int i = 0; i < N; i++) B = B * 2; }
    static void Ceo_002_ulong_004_del(ulong B) { for (int i = 0; i < N; i++) B = B / 2; }
    static void Ceo_002_ulong_005_mod(ulong B) { for (int i = 0; i < N; i++) B = B % 2; }
    static void Ceo_002_ulong_006_mn2(ulong B) { for (int i = 0; i < N; i++) B = B << 1; }
    static void Ceo_002_ulong_007_de2(ulong B) { for (int i = 0; i < N; i++) B = B >> 1; }

    // Int64
    static void Ceo_003_Int64_001_sab(Int64 B)  { for (int i = 0; i < N; i++) B++; }
    static void Ceo_003_Int64_002_odu(Int64 B)  { for (int i = 0; i < N; i++) B--; }
    static void Ceo_003_Int64_003_mno(Int64 B)  { for (int i = 0; i < N; i++) B = B * 2;  }
    static void Ceo_003_Int64_004_del(Int64 B)  { for (int i = 0; i < N; i++) B = B / 2;  }
    static void Ceo_003_Int64_005_mod(Int64 B)  { for (int i = 0; i < N; i++) B = B % 2;  }
    static void Ceo_003_Int64_006_mn2(Int64 B)  { for (int i = 0; i < N; i++) B = B << 1; }
    static void Ceo_003_Int64_007_de2(Int64 B)  { for (int i = 0; i < N; i++) B = B >> 1; }

    // UInt64
    static void Ceo_003_UInt64_001_sab(UInt64 B) { for (int i = 0; i < N; i++) B++;  }
    static void Ceo_003_UInt64_002_odu(UInt64 B) { for (int i = 0; i < N; i++) B--;  }
    static void Ceo_003_UInt64_003_mno(UInt64 B) { for (int i = 0; i < N; i++) B = B * 2;  }
    static void Ceo_003_UInt64_004_del(UInt64 B) { for (int i = 0; i < N; i++) B = B / 2;  }
    static void Ceo_003_UInt64_005_mod(UInt64 B) { for (int i = 0; i < N; i++) B = B % 2;  }
    static void Ceo_003_UInt64_006_mn2(UInt64 B) { for (int i = 0; i < N; i++) B = B << 1; }
    static void Ceo_003_UInt64_007_de2(UInt64 B) { for (int i = 0; i < N; i++) B = B >> 1; }

    // short
    static void Ceo_004_short_001_sab(short B) { for (int i = 0; i < N; i++) B++; }
    static void Ceo_004_short_002_odu(short B) { for (int i = 0; i < N; i++) B--; }
    static void Ceo_004_short_003_mno(short B) { for (int i = 0; i < N; i++) B *= 2; }      // ne kompajlira B = B * 2;
    static void Ceo_004_short_004_del(short B) { for (int i = 0; i < N; i++) B /= 2; }      // ne kompajlira B = B / 2;
    static void Ceo_004_short_005_mod(short B) { for (int i = 0; i < N; i++) B %= 2; }      // ne kompajlira B = B % 2;
    static void Ceo_004_short_006_mn2(short B) { for (int i = 0; i < N; i++) B <<= 1; }     // ne kompajlira B = B << 1;
    static void Ceo_004_short_007_de2(short B) { for (int i = 0; i < N; i++) B >>= 1; }     // ne kompajlira B = B >> 1;

    // ushort
    static void Ceo_004_ushort_001_sab(ushort B) { for (int i = 0; i < N; i++) B++; }
    static void Ceo_004_ushort_002_odu(ushort B) { for (int i = 0; i < N; i++) B--; }
    static void Ceo_004_ushort_003_mno(ushort B) { for (int i = 0; i < N; i++) B *= 2; }    // ne kompajlira B = B * 2;
    static void Ceo_004_ushort_004_del(ushort B) { for (int i = 0; i < N; i++) B /= 2; }    // ne kompajlira B = B / 2;
    static void Ceo_004_ushort_005_mod(ushort B) { for (int i = 0; i < N; i++) B %= 2; }    // ne kompajlira B = B % 2;
    static void Ceo_004_ushort_006_mn2(ushort B) { for (int i = 0; i < N; i++) B <<= 1; }   // ne kompajlira B = B << 1;
    static void Ceo_004_ushort_007_de2(ushort B) { for (int i = 0; i < N; i++) B >>= 1; }   // ne kompajlira B = B >> 1;

    // sbyte
    static void Ceo_005_sbyte_001_sab(sbyte B) { for (int i = 0; i < N; i++) B++; }
    static void Ceo_005_sbyte_002_odu(sbyte B) { for (int i = 0; i < N; i++) B--; }
    static void Ceo_005_sbyte_003_mno(sbyte B) { for (int i = 0; i < N; i++) B *= 2; }      // ne kompajlira B = B * 2;
    static void Ceo_005_sbyte_004_del(sbyte B) { for (int i = 0; i < N; i++) B /= 2; }      // ne kompajlira B = B / 2;
    static void Ceo_005_sbyte_005_mod(sbyte B) { for (int i = 0; i < N; i++) B %= 2; }      // ne kompajlira B = B % 2;
    static void Ceo_005_sbyte_006_mn2(sbyte B) { for (int i = 0; i < N; i++) B <<= 1; }     // ne kompajlira B = B << 1;
    static void Ceo_005_sbyte_007_de2(sbyte B) { for (int i = 0; i < N; i++) B >>= 1; }     // ne kompajlira B = B >> 1;

    // byte
    static void Ceo_005_byte_001_sab(byte B) { for (int i = 0; i < N; i++) B++; }
    static void Ceo_005_byte_002_odu(byte B) { for (int i = 0; i < N; i++) B--; }
    static void Ceo_005_byte_003_mno(byte B) { for (int i = 0; i < N; i++) B *= 2; }        // ne kompajlira B = B * 2;
    static void Ceo_005_byte_004_del(byte B) { for (int i = 0; i < N; i++) B /= 2; }        // ne kompajlira B = B / 2;
    static void Ceo_005_byte_005_mod(byte B) { for (int i = 0; i < N; i++) B %= 2; }        // ne kompajlira B = B % 2;
    static void Ceo_005_byte_006_mn2(byte B) { for (int i = 0; i < N; i++) B <<= 1; }       // ne kompajlira B = B << 1;
    static void Ceo_005_byte_007_de2(byte B) { for (int i = 0; i < N; i++) B >>= 1; }       // ne kompajlira B = B >> 1;

    // BigInteger
    static void Ceo_006_BigInteger_001_sab(BigInteger B) { for (int i = 0; i < N; i++) B++; }
    static void Ceo_006_BigInteger_002_odu(BigInteger B) { for (int i = 0; i < N; i++) B--; }
    static void Ceo_006_BigInteger_003_mno(BigInteger B) { for (int i = 0; i < N; i++) B = B * 2; } 
    static void Ceo_006_BigInteger_004_del(BigInteger B) { for (int i = 0; i < N; i++) B = B / 2; } 
    static void Ceo_006_BigInteger_005_mod(BigInteger B) { for (int i = 0; i < N; i++) B = B % 2; }
    static void Ceo_006_BigInteger_006_mn2(BigInteger B) { for (int i = 0; i < N; i++) B = B << 1; }
    static void Ceo_006_BigInteger_007_de2(BigInteger B) { for (int i = 0; i < N; i++) B = B >> 1; }

    // float
    static void Real_001_float_001_sab(float B) { for (int i = 0; i < N; i++) B++; }
    static void Real_001_float_002_odu(float B) { for (int i = 0; i < N; i++) B--; }
    static void Real_001_float_003_mno(float B) { for (int i = 0; i < N; i++) B = B * 2; }
    static void Real_001_float_004_del(float B) { for (int i = 0; i < N; i++) B = B / 2; }
    static void Real_001_float_005_mod(float B) { for (int i = 0; i < N; i++) B = B % 2; }
    // static void Real_001_float_006_mn2(float B) { for (int i = 0; i < N; i++) B = B << 1; }     // ne kompajlira B = B << 1;
    // static void Real_001_float_007_de2(float B) { for (int i = 0; i < N; i++) B = B >> 1; }     // ne kompajlira B = B >> 1;

    // double
    static void Real_002_double_001_sab(double B) { for (int i = 0; i < N; i++) B++; }
    static void Real_002_double_002_odu(double B) { for (int i = 0; i < N; i++) B--; }
    static void Real_002_double_003_mno(double B) { for (int i = 0; i < N; i++) B = B * 2; }
    static void Real_002_double_004_del(double B) { for (int i = 0; i < N; i++) B = B / 2; }
    static void Real_002_double_005_mod(double B) { for (int i = 0; i < N; i++) B = B % 2; }
    // static void Real_002_double_006_mn2(double B) { for (int i = 0; i < N; i++) B = B << 1; }   // ne kompajlira B = B << 1;
    // static void Real_002_double_007_de2(double B) { for (int i = 0; i < N; i++) B = B >> 1; }   // ne kompajlira B = B >> 1;

    // decimal
    static void Real_003_decimal_001_sab(decimal B) { for (int i = 0; i < N; i++) B++; }
    static void Real_003_decimal_002_odu(decimal B) { for (int i = 0; i < N; i++) B--; }
    static void Real_003_decimal_003_mno(decimal B) { for (int i = 0; i < N; i++) B = B * 2; }
    static void Real_003_decimal_004_del(decimal B) { for (int i = 0; i < N; i++) B = B / 2; }
    static void Real_003_decimal_005_mod(decimal B) { for (int i = 0; i < N; i++) B = B % 2; }
    // static void Real_003_decimal_006_mn2(decimal B) { for (int i = 0; i < N; i++) B = B << 1; } // ne kompajlira B = B << 1;
    // static void Real_003_decimal_007_de2(decimal B) { for (int i = 0; i < N; i++) B = B >> 1; } // ne kompajlira B = B >> 1;

}


/*
 

 */
