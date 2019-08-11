//älterer code. TODO neuschreiben ggf in mehreren Sprachen
void cc() { Console.Clear(); }   
void cr() { Console.ReadKey(); } 
byte Sleeptimer = 90;
void sleepy() { System.Threading.Thread.Sleep(Sleeptimer); }
string[] Loading = { @"-- ", @"\  ", @"|  ", @"/  " };
            string[] completemsg = { "Loading", " complete!" };
            for (byte i = 0; i <= 10; i++)
            {
                foreach (var symbols in Loading)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(symbols + completemsg[0]); 
                    sleepy();
                    cc();
                    if (i == 14) { 
                        try {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(completemsg[0], completemsg[1]);

                            cc();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        catch (Exception) {
                           Console.WriteLine("Error 1");
                            cr();
                        }
                    }
                }
            }
