using System;

namespace Les6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            try
            {
                // Code die je wilt uitoveren …
                throw new Exception();
            }
            catch (System.Exception)
            {
                // Opvangen van de exception
                throw;
            }
            */

            object o = null;  
            try  
            {  
                int i = (int)o;   // Error  
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("NRE: " + e.Message);
                Console.WriteLine("NRE: " + e.StackTrace); // StackTrace zegt op welke lijn het probleem zich voordoet
            }
            catch (InvalidCastException e)   
            {  
                Console.WriteLine("ICE: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("E: " + e.StackTrace);
            }
            finally
            {
                // Stappen die zeker nog moeten uitgevoerd worden ...
                Console.WriteLine("Finally");
            }
        }
        
        
    }
}
