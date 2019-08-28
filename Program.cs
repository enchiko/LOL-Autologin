using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOLKOv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Program By EnchikO Started **");
            try
            {
                using (StreamReader sr = new StreamReader("time.txt"))
                {
                    String line = sr.ReadToEnd();
                    int time = int.Parse(line);
                    
                    try
                    {
                        using (StreamReader sr2 = new StreamReader("pass.txt"))
                        {
                            String pass = sr2.ReadToEnd();
                            
                            Process.Start("E:\\lol\\LeagueClient.exe");
                            Thread.Sleep(200);
                            Console.WriteLine();
                            Console.WriteLine(" --------------------");                           
                            Console.WriteLine("| Running Lol Client |");
                            Console.WriteLine(" --------------------");
                            Console.WriteLine();
                            Thread.Sleep(500);
                            Console.WriteLine(" -------------------------------------------------------------------");
                            Console.WriteLine("| Time was set to {0} seconds. After {0} it will write your password    | ",  (time / 1000));
                            Console.WriteLine(" -------------------------------------------------------------------");
                            Console.WriteLine();
                            
                            for (int i = (time/1000); i >= 1; i--)
                            {
                                Console.WriteLine("** {0} **", + i);
                                Thread.Sleep(5000);

                            }
                                                      
                            Process.Start("E:\\lol\\LeagueClient.exe");
                            Thread.Sleep(800);
                            SendKeys.SendWait(pass);
                            Thread.Sleep(300);
                            SendKeys.SendWait("{ENTER}");

                        }

                    }
                    catch (IOException)
                    {
                        Console.WriteLine("no password text file found");
                        Console.ReadKey();
                    }
                }

            }
            catch (IOException)
            {
                Console.WriteLine("no time text file found");
                Console.ReadKey();
            }
        }
    }
}
