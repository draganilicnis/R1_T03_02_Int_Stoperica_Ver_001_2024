// https://petlja.org/sr-Cyrl-RS/kurs/14606/5/1318
// https://petlja.org/sr-Latn-RS/kurs/14606/4/1314
// https://petlja.org/sr-Cyrl-RS/kurs/14606/35/1394
// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/02%20Tipovi_detaljniji_pregled/02%20celobrojni_tip/02%20Baratanje_bitovima
// https://github.com/draganilicnis/R1_T03_02_Int_Stoperica_Ver_001_2024/blob/main/R1_T03_02_Int_Stoperica_Ver_001_2024.cs
// https://onlinegdb.com/ZSDtZwcIY

#include <iostream>
#include <chrono>
#include <cstdint>
#include <iomanip>

using namespace std;
using namespace chrono;

const int N = 1000000000;
const int B = 1000000007;

void Ceo_001_int_001_sab(int B) { for (int i = 0; i < N; i++) B++; }
void Ceo_001_int_002_odu(int B) { for (int i = 0; i < N; i++) B--; }
void Ceo_001_int_003_mno(int B) { for (int i = 0; i < N; i++) B *= 2; }
void Ceo_001_int_004_del(int B) { for (int i = 0; i < N; i++) B /= 2; }
void Ceo_001_int_005_mod(int B) { for (int i = 0; i < N; i++) B %= 2; }
void Ceo_001_int_006_mn2(int B) { for (int i = 0; i < N; i++) B <<= 1; }
void Ceo_001_int_007_de2(int B) { for (int i = 0; i < N; i++) B >>= 1; }

void measure_execution(void (*func)(int), int B, const string& label) 
{
    auto start = high_resolution_clock::now();
    func(B);
    auto stop = high_resolution_clock::now();
    auto duration = duration_cast<milliseconds>(stop - start);
    cout << label << ": " << duration.count() << " ms" << endl;
}

int main() 
{
    cout << setw(24) << "++" << setw(17) << "--" << setw(17) << "*2" << setw(17) << "/2" << setw(17) << "%2" << setw(17) << "<<1" << setw(17) << ">>1" << endl;

    int a = B;
    cout << "int: ";
    measure_execution(Ceo_001_int_001_sab, a, "++");
    measure_execution(Ceo_001_int_002_odu, a, "--");
    measure_execution(Ceo_001_int_003_mno, a, "*2");
    measure_execution(Ceo_001_int_004_del, a, "/2");
    measure_execution(Ceo_001_int_005_mod, a, "%2");
    measure_execution(Ceo_001_int_006_mn2, a, "<<1");
    measure_execution(Ceo_001_int_007_de2, a, ">>1");

    // Dodatak za ostale tipove kao uint, long, ulong, itd. sledi ovde po istom obrascu.
    
    return 0;
}
