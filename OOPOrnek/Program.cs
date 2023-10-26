using OOPOrnek;
using OOPOrnek.Abstracts;
using OOPOrnek.Constructor;
using OOPOrnek.Overrides;
using OOPOrnek.SOLID;
using System.Reflection;

#region Inveon Bootcamp - 1. Gün



//ClassIsmi nesnemizinAdi = new ClassIsmi();
Insan i = new Insan();
i.ad = "ibrahim";
i.soyad = "Gökyar";
i.Uyu("Hakan", "Yılmaz");


Araba a = new Araba();
a.marka = "bmw";
a.model = "x5";
a.Git(a.marka, a.model);


Anne an = new Anne();
an.ad = "fahriye";
an.soyad = "Gökyar";
an.Uyu(an.ad, an.soyad);
an.EkranaYaz(an.ad, an.soyad);
an.Oku(an.ad);
an.Dinle(an.ad);
an.Yaz(an.ad);


Baba b = new Baba();
b.ad = "Kasım";
b.soyad = "Gökyar";
b.EkranaYaz(b.ad, b.soyad);


Cocuk c = new Cocuk();
c.ad = "ibrahim";
c.soyad = "Gökyar";
c.EkranaYaz(c.ad, c.soyad);

Console.WriteLine();



AkilliCocuk ak = new AkilliCocuk();
ak.ad = "Akıllı";
ak.soyad = "Çocuk";
ak.EkranaYaz(ak.ad, ak.soyad);
ak.AskereGit(ak.ad);
ak.EhliyetAl(ak.ad);
ak.KlubeGit(ak.ad);


UsluCocuk us = new UsluCocuk();
us.ad = "Uslu";
us.soyad = "Çocuk";
us.EkranaYaz(us.ad, us.soyad);
us.AskereGit(us.ad);
us.EhliyetAl(us.ad);


HiperAktifCocuk hp = new HiperAktifCocuk();
hp.ad = "Hiperaktif";
hp.soyad = "Çocuk";
hp.EkranaYaz(hp.ad, hp.soyad);
hp.EhliyetAl(hp.ad);

Console.WriteLine();



GenelMudur gm = new GenelMudur();
Mudur m = new Mudur();
Programci p = new Programci();
Stajyer s = new Stajyer();

double toplamMaas = 0;
toplamMaas += gm.MaasinizNedir();
toplamMaas += m.MaasinizNedir();
toplamMaas += p.MaasinizNedir();
toplamMaas += s.MaasinizNedir();

Console.WriteLine($"Çalışanların toplam maaşı {toplamMaas} TL'dir.");

Console.WriteLine();



Matematik mat = new Matematik();
Console.WriteLine(mat.Topla(1, 3));
Console.WriteLine(mat.Topla(1, 3, 5));

Console.WriteLine();



Insan insan1 = new Insan();
Insan insan2 = new Insan("Oğuzhan", "Durmaz");
Insan insan3 = new Insan("Oğuzhan", "Durmaz", 23, 23000, true);

Console.WriteLine();



Goz goz = new Goz("Kahverengi", "abc");
Kulak kulak = new Kulak("Kepçe");
Burun burun = new Burun("Kemerli");
Kafa kafa = new Kafa(goz, burun, kulak);
YeniInsan yeni = new YeniInsan(kafa, "Inveon", "Bootcamp");
yeni.EkranaYaz();
Console.WriteLine();
goz.renk = "Mavi";
yeni.EkranaYaz();

Console.WriteLine();


DbLog dbLog = new DbLog();
XmlLog xmlLog = new XmlLog();
dbLog.LogYaz("303 nolu hata kodu oluştu");
xmlLog.LogYaz("404 nolu hata kodu oluştu");

Console.WriteLine();


#endregion

Console.WriteLine();

#region Inveon Bootcamp - 2. Gün


Child ch = new Child();
ch.Yaz();


Console.WriteLine();
Console.WriteLine();
#endregion

Console.WriteLine();

#region Inveon Bootcamp - 3. Gün

Type t = typeof(MyClass);
MethodInfo[] mi = t.GetMethods();
foreach (var info in mi)
{
    ParameterInfo[] pi = info.GetParameters();
    Console.WriteLine($"Metod adı : {info.Name} \n Dönüş Tipi : {info.ReturnType}");
    if (pi.Length > 0)
        Console.WriteLine("parametre var");
    for (int iX = 0; iX < pi.Length; iX++)
    {
        Console.WriteLine($"{iX + 1}. Parametre:\n\t Dönüş Değeri:{pi[iX].ParameterType.Name}\n\t Adı:{pi[iX].Name}");
    }
}





#endregion

Console.ReadKey();