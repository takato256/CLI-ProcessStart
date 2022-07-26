using System;
using System.Diagnostics;
using System.IO;

namespace ProcessStart
{
    class Program
    {
        static void Main(string[] args)
        {
            //下記のPythonスクリプトへのファイルパスを記述する
            string myPythonApp = "test.py";


            var myProcess = new Process
            {
                StartInfo = new ProcessStartInfo("python.exe")
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = myPythonApp
                }
            };

            myProcess.Start();
            StreamReader myStreamReader = myProcess.StandardOutput;
            while (true)
            {
                string myString = myStreamReader.ReadLine();
                Console.WriteLine(myString);
            }
            myProcess.Close();

        }
    }
}