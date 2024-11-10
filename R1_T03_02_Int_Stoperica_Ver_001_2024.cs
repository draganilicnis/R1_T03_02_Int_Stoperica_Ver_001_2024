// https://petlja.org/sr-Cyrl-RS/kurs/14606/5/1318
// https://petlja.org/sr-Latn-RS/kurs/14606/4/1314
// https://petlja.org/sr-Cyrl-RS/kurs/14606/35/1394
// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/02%20Tipovi_detaljniji_pregled/02%20celobrojni_tip/02%20Baratanje_bitovima
// https://github.com/draganilicnis/R1_T03_02_Int_Stoperica_Ver_001_2024/blob/main/R1_T03_02_Int_Stoperica_Ver_001_2024.cs
// https://onlinegdb.com/ZSDtZwcIY
// https://onlinegdb.com/88ASgLVFD
// https://onlinegdb.com/X7ERYOfOU

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


// REZULTATI 

/*
C# OnlineGDB: https://onlinegdb.com/QupDRQjoQ

                      ++               --               *2               /2               %2              <<1              >>1
int:    00:00:00.9201468 00:00:00.9283657 00:00:00.9106450 00:00:01.0817125 00:00:01.3405708 00:00:00.6175557 00:00:00.6038955 
uint:   00:00:00.9318461 00:00:00.9200838 00:00:00.6047586 00:00:00.6014235 00:00:00.9105435 00:00:00.9100992 00:00:00.5987334 
long:   00:00:00.6682331 00:00:00.9528981 00:00:00.9350758 00:00:04.7671023 00:00:01.3562716 00:00:00.9462691 00:00:00.7262528 
ulong:  00:00:00.6867910 00:00:00.9021327 00:00:00.9161652 00:00:04.4619863 00:00:05.6551221 00:00:00.6366433 00:00:00.6027188 
Int64:  00:00:00.9229261 00:00:00.9157343 00:00:00.6226334 00:00:04.7621903 00:00:01.3485301 00:00:00.6012704 00:00:00.6262902 
UInt64: 00:00:00.8987681 00:00:00.9144271 00:00:00.6143741 00:00:04.4694268 00:00:05.6628086 00:00:00.6052313 00:00:00.9576353 
short:  00:00:03.7894548 00:00:03.8950303 00:00:03.8948368 00:00:05.2227220 00:00:06.7822809 00:00:03.9157493 00:00:03.8898552 
ushort: 00:00:03.8982576 00:00:03.8095285 00:00:03.8942766 00:00:05.2085078 00:00:06.4965903 00:00:03.7980113 00:00:03.7005045 
sbyte:  00:00:03.6028276 00:00:03.7026336 00:00:03.7809403 00:00:05.1143697 00:00:06.3994438 00:00:03.6972960 00:00:03.8084528 
byte:   00:00:03.6964864 00:00:03.6952703 00:00:03.7047267 00:00:04.2965741 00:00:04.9897620 00:00:03.7124544 00:00:03.8836970 
BigIntr:
float:  00:00:10.8130425 00:00:10.8047309 00:00:10.7994241 00:00:19.7820813 00:00:25.6049272 
double: 00:00:11.0179696 00:00:11.0863583 00:00:11.0950819 00:00:22.2100357 00:00:30.6884181 
decimal:00:01:08.8011607 00:01:10.0148801 System.OverflowException: Value was either too large or too small for a Decimal.


C# VS 2019: Redirekcijom *.TXT 
                      ++               --               *2               /2               %2              <<1              >>1
int:    00:00:01.7867974 00:00:01.7803528 00:00:01.7918411 00:00:01.5619725 00:00:02.1038035 00:00:01.8634577 00:00:01.7837800 
uint:   00:00:01.7835857 00:00:01.7872151 00:00:01.7791819 00:00:01.7656087 00:00:01.7768150 00:00:01.7752692 00:00:01.7665929 
long:   00:00:01.7544842 00:00:01.7578414 00:00:01.7219933 00:00:10.5247120 00:00:10.7628779 00:00:01.7743182 00:00:01.7695844 
ulong:  00:00:01.7421032 00:00:01.7627967 00:00:01.7201902 00:00:08.5813615 00:00:08.7400467 00:00:01.7737703 00:00:01.7638150 
Int64:  00:00:01.7419107 00:00:01.7596317 00:00:01.7242386 00:00:10.5983414 00:00:10.7695742 00:00:01.7784337 00:00:01.7581670 
UInt64: 00:00:01.7580573 00:00:01.7497935 00:00:01.7369552 00:00:08.6293818 00:00:08.7385678 00:00:01.7722412 00:00:01.7758508 
short:  00:00:04.4756934 00:00:04.4679108 00:00:04.4826403 00:00:05.7451981 00:00:06.3874642 00:00:04.4954541 00:00:04.4711046 
ushort: 00:00:04.4774093 00:00:04.4772328 00:00:04.4796052 00:00:05.7472203 00:00:06.2684953 00:00:04.5060472 00:00:04.5127414 
sbyte:  00:00:04.9315537 00:00:05.0387547 00:00:04.6367698 00:00:05.7737419 00:00:06.2520812 00:00:04.5000326 00:00:04.4861848 
byte:   00:00:04.4779579 00:00:04.4734556 00:00:04.4984694 00:00:05.7969500 00:00:06.2493694 00:00:04.4889400 00:00:04.4801282 
BigIntr:00:00:17.7206866 00:00:18.2798020 mnogo
BigIntr:00:00:17.5886143 00:00:17.9043064 99:99:99.9999999 00:00:24.3117896 00:00:24.4988437 99:99:99.9999999 00:00:30.2347254 
float:  00:00:02.2627368 00:00:02.2534814 00:00:02.2587283 00:00:02.2604022 00:00:09.0215005 
double: 00:00:02.2454230 00:00:02.2513285 00:00:02.2453302 00:00:02.2572743 00:00:08.5388379 
decimal:00:00:14.3832645 00:00:14.3415102 00:00:13.3759006 00:00:21.3681939 00:00:17.6074352 



C# VS 2019: Redirekcijom *.TXT 1000 puta manje (umesto do milijarde do milion)
                      ++               --               *2               /2               %2              <<1              >>1
int:    00:00:00.0019129 00:00:00.0020114 00:00:00.0020198 00:00:00.0017096 00:00:00.0021687 00:00:00.0019022 00:00:00.0018568 
uint:   00:00:00.0018412 00:00:00.0018395 00:00:00.0018399 00:00:00.0018707 00:00:00.0018897 00:00:00.0018556 00:00:00.0018454 
long:   00:00:00.0018467 00:00:00.0019037 00:00:00.0018990 00:00:00.0110291 00:00:00.0112339 00:00:00.0021132 00:00:00.0018712 
ulong:  00:00:00.0017726 00:00:00.0017842 00:00:00.0017476 00:00:00.0096246 00:00:00.0089379 00:00:00.0019231 00:00:00.0019440 
Int64:  00:00:00.0018098 00:00:00.0017864 00:00:00.0017474 00:00:00.0105016 00:00:00.0111619 00:00:00.0018498 00:00:00.0017963 
UInt64: 00:00:00.0017675 00:00:00.0017997 00:00:00.0017413 00:00:00.0087085 00:00:00.0089254 00:00:00.0018571 00:00:00.0018564 
short:  00:00:00.0044755 00:00:00.0044480 00:00:00.0044433 00:00:00.0066613 00:00:00.0062825 00:00:00.0049535 00:00:00.0046361 
ushort: 00:00:00.0046248 00:00:00.0046384 00:00:00.0056011 00:00:00.0060238 00:00:00.0068499 00:00:00.0048866 00:00:00.0046230 
sbyte:  00:00:00.0048248 00:00:00.0046519 00:00:00.0048876 00:00:00.0061541 00:00:00.0064206 00:00:00.0045697 00:00:00.0049906 
byte:   00:00:00.0046161 00:00:00.0045687 00:00:00.0045576 00:00:00.0063081 00:00:00.0064117 00:00:00.0045782 00:00:00.0045210 
BigIntr:00:00:00.0193126 00:00:00.0200692 00:00:28.2562924 00:00:00.0278958 00:00:00.0283207 00:00:39.2113935 00:00:00.0320261 
float:  00:00:00.0025728 00:00:00.0023956 00:00:00.0023595 00:00:00.0025219 00:00:00.0082088 
double: 00:00:00.0022882 00:00:00.0025705 00:00:00.0026495 00:00:00.0022870 00:00:00.0084875 
decimal:00:00:00.0169445 00:00:00.0170605 00:00:00.0154766 00:00:00.0191120 00:00:00.0164298 


C# VS 2019: Redirekcijom *.TXT 100 puta manje (umesto do milijarde do 10 miliona)
                      ++               --               *2               /2               %2              <<1              >>1
int:    00:00:00.0183218 00:00:00.0181298 00:00:00.0188908 00:00:00.0157957 00:00:00.0209675 00:00:00.0181001 00:00:00.0185600 
uint:   00:00:00.0177378 00:00:00.0179071 00:00:00.0195312 00:00:00.0191614 00:00:00.0181161 00:00:00.0183382 00:00:00.0178964 
long:   00:00:00.0173991 00:00:00.0181360 00:00:00.0172411 00:00:00.1074009 00:00:00.1104827 00:00:00.0178246 00:00:00.0181529 
ulong:  00:00:00.0178114 00:00:00.0183738 00:00:00.0184211 00:00:00.0879715 00:00:00.0885701 00:00:00.0182060 00:00:00.0189817 
Int64:  00:00:00.0181775 00:00:00.0181148 00:00:00.0173447 00:00:00.1083108 00:00:00.1101733 00:00:00.0177779 00:00:00.0176427 
UInt64: 00:00:00.0179884 00:00:00.0166420 00:00:00.0179678 00:00:00.0912223 00:00:00.0880577 00:00:00.0177245 00:00:00.0180011 
short:  00:00:00.0457295 00:00:00.0462842 00:00:00.0455107 00:00:00.0577179 00:00:00.0628085 00:00:00.0466358 00:00:00.0460385 
ushort: 00:00:00.0455682 00:00:00.0450608 00:00:00.0459839 00:00:00.0579729 00:00:00.0633878 00:00:00.0446806 00:00:00.0466841 
sbyte:  00:00:00.0451221 00:00:00.0453783 00:00:00.0447273 00:00:00.0586360 00:00:00.0641027 00:00:00.0446836 00:00:00.0450428 
byte:   00:00:00.0454059 00:00:00.0469763 00:00:00.0458956 00:00:00.0585653 00:00:00.0662989 00:00:00.0462097 00:00:00.0467816 
BigIntr:00:00:00.1977768 00:00:00.1911049 01:13:03.3699613 00:00:00.2543732 00:00:00.2591008 01:39:36.4901845 00:00:00.3301029 
float:  00:00:00.0235790 00:00:00.0243807 00:00:00.0246717 00:00:00.0241135 00:00:00.0943435 
double: 00:00:00.0236759 00:00:00.0246561 00:00:00.0230518 00:00:00.0235278 00:00:00.0921408 
decimal:00:00:00.1470631 00:00:00.1510353 00:00:00.1331371 00:00:00.2205229 00:00:00.1941209 


 */
