using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace zadacha
{
    class Program
    {
        static bool tabak = false;
        static bool bumaga = false;
        static bool spichki = false;

        static Thread Thread_K_Tabak;
        static Thread Thread_K_Bumaga;
        static Thread Thread_K_Spichki;
        static Thread Thread_Barman;
        static void Main(string[] args)
        {



            //Thread_K_Tabak = new Thread(K_Tabak);
            //Thread_K_Bumaga = new Thread(K_Bumaga);
            //Thread_K_Spichki = new Thread(K_Spichki);
            //Thread_Barman = new Thread(Barman);

            //Thread_K_Spichki.Name = "Курильщик, имеющий спички,";
            //Thread_K_Bumaga.Name = "Курильщик, имеющий бумагу,";
            //Thread_K_Tabak.Name = "Курильщик, имеющий табак,";

            //Thread_K_Spichki.Start();
            //Thread_K_Bumaga.Start();
            //Thread_K_Tabak.Start();
            //Thread_Barman.Start();

            while (true)
            {

                Thread_K_Tabak = new Thread(K_Tabak);
                Thread_K_Bumaga = new Thread(K_Bumaga);
                Thread_K_Spichki = new Thread(K_Spichki);
                Thread_Barman = new Thread(Barman);

                Thread_K_Spichki.Name = "Курильщик, имеющий спички,";
                Thread_K_Bumaga.Name = "Курильщик, имеющий бумагу,";
                Thread_K_Tabak.Name = "Курильщик, имеющий табак,";

                Thread_K_Spichki.Start();
                //Thread_K_Spichki.Join();
                Thread_K_Bumaga.Start();
                //Thread_K_Bumaga.Join();
                Thread_K_Tabak.Start();
                //Thread_K_Tabak.Join();
                Thread_Barman.Start();
                Thread_Barman.Join();
            }


        }

        static void Barman()
        {

            if (bumaga & spichki)
            {
                Console.WriteLine(Thread_K_Tabak.Name + " курит");
                
                Thread.Sleep(1000);
                bumaga = false;
                spichki = false;
            }
            else if (tabak & spichki)
            {
                Console.WriteLine(Thread_K_Bumaga.Name + " курит");
                
                Thread.Sleep(1000);
                tabak = false;
                spichki = false;
            }
            else if (bumaga & tabak)
            {
                Console.WriteLine(Thread_K_Spichki.Name + " курит");
                
                Thread.Sleep(1000);
                bumaga = false;
                tabak = false;
            }

        }

        static void K_Tabak()
        {

            if ((bumaga != true | spichki != true) & tabak != true)
            {
                tabak = true;
                Console.WriteLine(Thread_K_Tabak.Name + " выложил свой компонент на стол");
            }
            

        }

        static void K_Bumaga()
        {

            if ((tabak != true | spichki != true) & bumaga != true)
            {
                bumaga = true;
                Console.WriteLine(Thread_K_Bumaga.Name + " выложил свой компонент на стол");
            }
            
        }

        static void K_Spichki()
        {

            if ((bumaga != true | tabak != true) & spichki != true)
            {
                spichki = true;
                Console.WriteLine(Thread_K_Spichki.Name + " выложил свой компонент на стол");
            }
            
        }


        //static void K_Tabak()
        //{
        //    while (true)
        //    {
        //        if ((bumaga != true | spichki != true) & tabak != true)
        //        {

        //            tabak = true;
        //            //Console.WriteLine(Thread.CurrentThread.Name + " выложил свой компонент на стол");

        //        }
        //        else if (bumaga == true & spichki == true)
        //        {
        //            bumaga = false;
        //            spichki = false;
        //            Console.WriteLine(Thread.CurrentThread.Name + " курит");
        //            Thread.Sleep(1500);


        //        }
        //    }
        //}

        //static void K_Bumaga()
        //{
        //    while (true)
        //    {
        //        if ((tabak != true | spichki != true) & bumaga != true)
        //        {

        //            bumaga = true;
        //            //Console.WriteLine(Thread.CurrentThread.Name + " выложил свой компонент на стол");

        //        }
        //        else if (tabak == true & spichki == true)
        //        {
        //            tabak = false;
        //            spichki = false;
        //            Console.WriteLine(Thread.CurrentThread.Name + " курит");
        //            Thread.Sleep(1500);
        //        }
        //    }

        //}

        //static void K_Spichki()
        //{
        //    while (true)
        //    {
        //        if ((bumaga != true | tabak != true) & spichki != true)
        //        {

        //            spichki = true;
        //            //Console.WriteLine(Thread.CurrentThread.Name + " выложил свой компонент на стол");

        //        }
        //        else if (bumaga == true & tabak == true)
        //        {

        //            bumaga = false;
        //            tabak = false;
        //            Console.WriteLine(Thread.CurrentThread.Name + " курит");
        //            Thread.Sleep(1500);
        //        }
        //    }

        //}

    }
}
