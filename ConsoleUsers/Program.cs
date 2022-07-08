using System;

/*
valiodar si el usaurio existe o se debe registrar
*/
namespace ConsoleUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string []  arrayUsername = new string[10];
            int i = 0;
            
            while(true){
                Console.WriteLine("enter username");
                string name = Console.ReadLine();
                int index = Array.IndexOf(arrayUsername, name);
                if(index==-1){
                    if(i>=10){
                        Console.WriteLine("ya te pasaste");
                        return;
                    }
                    arrayUsername[i++]=name;
                }else{
                    Console.WriteLine($"{name} is already in the array");
                }
            }
        }
    }
}
