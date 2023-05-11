/*
 * Created by SharpDevelop.
 * User: Norbert
 * Date: 18.05.2022
 * Time: 21:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace operacje_na_danych
{
	class Osoba
	{
		private string imie, nazwisko;
		uint wiek;
		public Osoba(string im, string nazw, uint _wiek)
		{
			this.imie = im;
			this.nazwisko = nazw;
			this.wiek = _wiek;
		}
		public void Wypisz()
		{
			Console.WriteLine("Jesteś {0} {1} i masz {2} lat", imie, nazwisko, wiek);
		}
	}
	class Student : Osoba
	{
		string wydzial, nr_indexu;
		public Student(string nazw, string im, uint _wiek, string wydz, string nr) : base(im, nazw, _wiek)
		{
			wydzial = wydz;
			nr_indexu = nr;
		}
		public void Wypisz()
		{
			base.Wypisz();
			Console.WriteLine("Twój wydział to:{0} i nr indexu:{1}", wydzial, nr_indexu);
		}

	}
	class Program
	{
		public static void Main(string[] args)
		{
			Osoba ja = new Osoba("Aleks", "Spychała", 18);
			ja.Wypisz();
			Student test = new Student("Aleks", "Spychała", 18, "Informatyka", "JSB451S");
			test.Wypisz();

			uint ile;
			Console.WriteLine("Podaj ilość studentów");
			ile = uint.Parse(Console.ReadLine());
			Student[] studenci = new Student[ile + 2];
			studenci[0] = new Student("Jan", "Dobski", 18, "Kombinacja Alpejska", "ADS456");
			studenci[1] = new Student("Kacper", "Młodzianowski", 17, "Miganie", "Sgrrt");
			for (int i = 2; i < studenci.Length; i++)
			{
				Console.WriteLine("Podaj imię i nazwisko, wiek, wydział, numer indexu dla {0} studenta:", i + 1);
				studenci[i] = new Student(Console.ReadLine(), Console.ReadLine(), uint.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
			}
			Console.WriteLine("1 - Lista studentów\n2 - według numeru\n3 - wdług nazwiska\n4 - Z danego wydziału\n5 - Koniec");
			uint opcja = uint.Parse(Console.ReadLine());
			switch (opcja)
			{
				case 1:
					Console.WriteLine("Lista studentów:");
					for (int i = 0; i < studenci.Length; i++)
					{
						Console.WriteLine("Student numer {0} : ", i + 1);
						studenci[i].Wypisz();
					}
					break;
				case 2:
					uint num = uint.Parse(Console.ReadLine());
					Console.WriteLine("Student numer {0} : ", num);
					studenci[num].Wypisz();
					break;
				case 3:
					//StartWith
					break;
			}


			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}