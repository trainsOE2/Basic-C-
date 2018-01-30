using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string flag = null;
            

           
                Stopwatch stopWatch = new Stopwatch();
                var command1 = Console.ReadLine();
                TimeSpan ts = new TimeSpan();
            while (command1 != "exit")
            {

                if ((command1 == "start")&&(flag == null))
                    {
                        //ts = TimeSpan.Zero;
                        stopWatch.Start();
                        //ts = stopWatch.Elapsed;
                        /*string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);*/
                        Console.WriteLine("Stopwatch started...");
                        flag = "1";
                    }

                else if ((command1 == "stop") && (flag == "1"))
                    {
                        stopWatch.Stop();
                        ts = stopWatch.Elapsed;
                        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                        Console.WriteLine("RunTime " + elapsedTime);
                        flag = "0";
                    }

                    else if((command1 == "stop")&&(flag == "0"))
                    {
                        Console.WriteLine("Stopwatch never started in the first place. Are you drunk?!!");
                    }

                    else if((command1 == "start")&&(flag == "1"))
                    {
                        Console.WriteLine("Stopwatch is running, type reset to start again and then type start");  
                    }

                    else if (command1 == "reset")
                    {
                        //stopWatch.Reset();
                        ts = TimeSpan.Zero;
                        //Console.WriteLine("{0:00}:{1:00}:{2:00}.{3:00}",
                                                        //ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                        flag = "null";
                    }

                   

                    else if ((command1 == "start") && (flag == "0"))
                    {
                        stopWatch.Start();
                        ts = stopWatch.Elapsed;
                        /*string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);*/
                        Console.WriteLine("Stopwatch is lapping" );
                        flag = "1";
                    }
                    
                    command1 = Console.ReadLine();

            }

        }

    }
}
