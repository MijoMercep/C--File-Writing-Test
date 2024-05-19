using System;
using System.IO;
namespace ZDK1;

class Program
{
    static void Main(string[] args)
    {   Console.WriteLine("Unesite ime datoteke: ");
        string imeDatoteke = Console.ReadLine();
        List<int> lista = new List<int>();
        Dictionary<string, int> imeDict = new Dictionary<string, int>();
    string ime;
            
            int godinaRodjenja = 0;
StreamWriter streamWriter = new StreamWriter(imeDatoteke);
            while(true){
            Console.WriteLine("Unesite vaše ime:");
            ime = Console.ReadLine();
            if(ime == ""){
                break;
            }else{
                streamWriter.WriteLine(ime);
                Console.WriteLine("Unesite vašu godinu rođenja:");
            try{godinaRodjenja = int.Parse(Console.ReadLine());
            streamWriter.WriteLine(godinaRodjenja);
            imeDict.Add(ime, godinaRodjenja);}
            catch{
                Console.WriteLine("Nije unesen broj");
                break;
            }
            }
            
            }

            
           Console.WriteLine("Podaci su uspješno spremljeni.");
           foreach (var i in imeDict)
            {
                Console.WriteLine($"Ime: {i.Key}, Godina rođenja: {i.Value}");
                lista.Add(i.Value);
            }
            
            lista.Sort();
            
            int dob = 0;
            foreach (var i in imeDict)
            {
                dob = 2024 - i.Value;
                if(i.Value == lista[0]){
                    Console.WriteLine("Najstarije osoba je: " + i.Key + " a ima: " + dob + " godina.");
                }
            }
            streamWriter.Close();
    }
}
