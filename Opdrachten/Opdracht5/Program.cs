using System;
using System.Threading;

namespace Opdracht5
{
    class Program
    {static void SchrijfLog(object output) => Console.WriteLine(output.ToString());
            
            static int Som(int get1 = 8, int get2 = 2){
                SchrijfLog("- SOM -");
                return get1 + get2;
            }

            static int Verschil(int get1 = 8, int get2 = 2){
                SchrijfLog("- VERSCHIL -");
                return get1 - get2;
            }

            static int Product(int get1 = 8 , int get2 = 2){
                SchrijfLog("- PRODUCT -");
                return get1 * get2;
            }

            static double Quotiënt(int get1 = 8, int get2 = 2){
                SchrijfLog("- QUOTIËNT -");
                return (double)get1 / get2;
            }
            static int Modulo(int getal1, int getal2){
                SchrijfLog("- MODULO -");
                return getal1%getal2;
            }
            static int Verhogen(int getal){
                SchrijfLog("- VERHOGEN -");
                return ++getal;
            }

            static int Verlagen(int getal){
                SchrijfLog("- VERLAGEN -");
                return --getal;
            }
            static int WillekeurigGetal(int min, int max){
                Random rnd = new Random();
                int res = rnd.Next(min, max);
                return res;
            }
            static int WillekeurigGetal(){
                Random rnd = new Random();
                int res = rnd.Next();
                return res;
            }

            static string Fibonacci (int aantal = 5){
                SchrijfLog("- FIBONACCI -");
                ulong a = 1;
                ulong b = 0;
                string result = "De fibonacci reeks van " + aantal + " getallen is: " + b + " " + a;            
                for (int i = 0; i < aantal-2; i++)
                {
                    ulong c = b;
                    b = a;
                    a = c + a;
                    result = result + " " + a;
                }
                return result;
            }

            static string Faculteit(int getal = 10){
                SchrijfLog("- FACULTEIT -");
                uint teller = 1;
                ulong result= 1;
                while (teller <= getal)
                {   
                    result*=teller;
                    teller++;
                }
                return "De faculteit van "+ getal + " is " + result + ".";
            }

            static string GenereerLottoRooster(){
                int iter = 0;
                int [] myArray = new int [6];
                for (int i = 0; i < 6; i++)
                {
                    int rnd = WillekeurigGetal(1,45);
                    int pos = Array.IndexOf(myArray, rnd);
                    while (pos != -1)
                    {   
                        rnd = WillekeurigGetal(1,45);
                        pos = Array.IndexOf(myArray, rnd);
                    }
                    myArray[iter] = rnd;
                    iter++;
                }
                string res = "";
                foreach (int getal in myArray)
                {
                    res+=getal.ToString();
                    res+= " ";
                }
                return res;
            }
            static void LottoTrekking(){
                // SchrijfLog("- LOTTOTREKKING -");
                int iter = 0;
                int [] myArray = new int [6];
                SchrijfLog("Lottotrekking: ");
                for (int i = 0; i < 6; i++)
                {
                    int rnd = WillekeurigGetal(1,45);
                    int pos = Array.IndexOf(myArray, rnd);
                    while (pos != -1)
                    {   
                        rnd = WillekeurigGetal(1,45);
                        pos = Array.IndexOf(myArray, rnd);
                    }
                    myArray[iter] = rnd;
                    SchrijfLog(rnd);
                    iter++;
                    Thread.Sleep(5000);
                }
            }

            static string GenereerEuroMillionsRooster(){
                int iter = 0;
                int [] numArray = new int [5];
                int [] starArray = new int [2];
                for (int i = 0; i < 5; i++)
                {
                    int rnd = WillekeurigGetal(1,50);
                    int pos = Array.IndexOf(numArray, rnd);
                    while (pos != -1)
                    {   
                        rnd = WillekeurigGetal(1,50);
                        pos = Array.IndexOf(numArray, rnd);
                    }
                    numArray[iter] = rnd;
                    iter++;
                }
                iter = 0;
                for (int i = 0; i < 2; i++)
                {
                    int rnd = WillekeurigGetal(1,12);
                    int pos = Array.IndexOf(starArray, rnd);
                    while (pos != -1)
                    {   
                        rnd = WillekeurigGetal(1,12);
                        pos = Array.IndexOf(starArray, rnd);
                    }
                    starArray[iter] = rnd;
                    iter++;
                }
                string res = "";
                foreach (int getal in numArray)
                {
                    res+=getal.ToString();
                    res+= " ";
                }
                foreach (int getal in starArray)
                {
                    res+=getal.ToString();
                    res+= " ";
                }
                return res;
            }

            static void EuroMillionsTrekking(){
                int iter = 0;
                int [] numArray = new int [5];
                int [] starArray = new int [2];
                SchrijfLog("EuroMillionsTrekking".ToUpper());
                SchrijfLog("De getallen zijn: ");
                for (int i = 0; i < 5; i++)
                {
                    int rnd = WillekeurigGetal(1,50);
                    int pos = Array.IndexOf(numArray, rnd);
                    while (pos != -1)
                    {   
                        rnd = WillekeurigGetal(1,50);
                        pos = Array.IndexOf(numArray, rnd);
                    }
                    for (int j = 0; j < 15; j++)
                    {
                    Console.Write(WillekeurigGetal(1,50));
                    Thread.Sleep(200);
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    }
                    numArray[iter] = rnd;
                    SchrijfLog(rnd);
                    iter++;
                    Thread.Sleep(2000);
                }
                iter = 0;
                SchrijfLog("De sterren zijn: ");
                for (int i = 0; i < 2; i++)
                {
                    int rnd = WillekeurigGetal(1,12);
                    int pos = Array.IndexOf(starArray, rnd);
                    while (pos != -1)
                    {   
                        rnd = WillekeurigGetal(1,12);
                        pos = Array.IndexOf(starArray, rnd);
                    }
                    for (int j = 0; j < 15; j++)
                    {
                    Console.Write(WillekeurigGetal(1,12));
                    Thread.Sleep(200);
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    }

                    starArray[iter] = rnd;
                    SchrijfLog(rnd);
                    iter++;
                    Thread.Sleep(2000);
                }
            }

            static string GetStartOfString(string input, int lengte){
                return input.Substring(0, lengte);
            }

            static string GenerateAccount(string type, string vnaam, string anaam){
                string code =""; 
                if (type.ToLower() == "docent")
                {
                    string kvnaam = GetStartOfString(vnaam, 4);
                    string kanaam = GetStartOfString(anaam, 2);
                    code = kvnaam.ToLower() + kanaam.ToLower() + "@arteveldehs.be";
                }
                else if(type.ToLower() == "student"){
                    string kvnaam = GetStartOfString(vnaam, 4);
                    string kanaam = GetStartOfString(anaam, 4);
                    code = kvnaam.ToLower() + kanaam.ToLower() + "@student.arteveldehs.be";
                } else
                {
                    SchrijfLog("Foute waarden meegegeven.");
                }
                return code;
            }

            static string ValideerIBAN(string code){
                code = code.Replace( " ", "" );
                string land = GetStartOfString(code,2).ToLower();
                int controleGetal = Int32.Parse(code.Substring(2, 2));
                string temp = "";
                foreach (char c in land)
                {
                    temp+= (int) c - 87;
                }
                temp += code.Substring(2, 2);
                long temp2 = Convert.ToInt64(code.Substring(4, code.Length-4) + temp);
                if (code.Length != 16 || land != "be" || controleGetal < 2 || controleGetal > 98 || temp2%97 != 1)
                {
                    return code + " is geen geldig IBAN-nummer.";
                } else {
                    return code + " is een geldig IBAN-nummer.";
                }
            }

        static void Main(string[] args)
        {
            SchrijfLog(Som(5,6));
            SchrijfLog(Verschil(8,5));
            SchrijfLog(Quotiënt(8,4));
            SchrijfLog(Product(5,3));
            SchrijfLog(Modulo(9,2));
            SchrijfLog(Verhogen(7));
            SchrijfLog(Verlagen(8));
            SchrijfLog(WillekeurigGetal());
            SchrijfLog(WillekeurigGetal(0,80));

            SchrijfLog(GenereerLottoRooster());
            LottoTrekking();

            SchrijfLog(GenereerEuroMillionsRooster());
            EuroMillionsTrekking();

            try
            {
                SchrijfLog(GenerateAccount(args[0], args[1], args[2]));
            }
            catch (System.IndexOutOfRangeException){
                SchrijfLog("Er werden te weinig argumenten meegegeven voor de account generator (moet 3 zijn)");
            }
            catch (System.Exception)
            {
                SchrijfLog("Er is een probleem");
            }

            SchrijfLog(ValideerIBAN("BE07 7390 1412 0066"));

            SchrijfLog(Faculteit(5));
            SchrijfLog(Fibonacci(10));

        }
    }
}