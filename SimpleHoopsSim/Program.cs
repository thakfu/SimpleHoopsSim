using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleHoopsSim
{


    class Program
    {



        static void Main(string[] args)
        {
            int time;
            int diff;
            int pos;
            int clock;
            int quarter;
            int atlscore = 0;
            int chiscore = 0;
            int aq1 = 0;
            int aq2 = 0;
            int aq3 = 0;
            int aq4 = 0;
            int aot = 0;
            int cq1 = 0;
            int cq2 = 0;
            int cq3 = 0;
            int cq4 = 0;
            int cot = 0;
            int apg = 60;
            int asg = 80;
            int asf = 70;
            int apf = 50;
            int acn = 70;
            int ab1 = 40;
            int ab2 = 40;
            int ab3 = 30;
            int cpg = 80;
            int csg = 90;
            int csf = 70;
            int cpf = 50;
            int ccn = 50;
            int cb1 = 30;
            int cb2 = 30;
            int cb3 = 30;
            int shooter;
            int result;
            int apgp = 0;
            int asgp = 0;
            int asfp = 0;
            int apfp = 0;
            int acnp = 0;
            int cpgp = 0;
            int csgp = 0;
            int csfp = 0;
            int cpfp = 0;
            int ccnp = 0;
            int amade = 0;
            int amiss = 0;
            int cmade = 0;
            int cmiss = 0;
            int flag = 0;


            quarter = 1;
            clock = 720;
            pos = 1;
            int min = 0;
            int sec = 0;
            

            Random rnd = new Random();

            while (quarter < 5)
            {

                while (clock > 0)
                {
                    time = rnd.Next(15, 25);
                    diff = rnd.Next(120, 150);
                    shooter = rnd.Next(1, 6);
                    result = rnd.Next(1, diff);

                    if (pos == 1)
                    {
                        Console.Write("ATL: ");
                        switch (shooter)
                        {
                            case 1:
                                if (apg > result)
                                {
                                    apgp = apgp + 2;
                                    Console.Write("PG shoots and scores!  He has " + apgp + " points");
                                    atlscore = atlscore + 2;
                                    amade = amade + 1;

                                }
                                else
                                {
                                    Console.Write("PG shoots and misses, Chicago takes over.");
                                    amiss = amiss + 1;
                                }
                                break;
                            case 2:
                                if (asg > result)
                                {
                                    asgp = asgp + 2;
                                    Console.Write("SG shoots and scores!  He has " + asgp + " points");
                                    atlscore = atlscore + 2;
                                    amade = amade + 1;

                                }
                                else
                                {
                                    Console.Write("SG shoots and misses, Chicago takes over.");
                                    amiss = amiss + 1;
                                }
                                break;
                            case 3:
                                if (asf > result)
                                {
                                    asfp = asfp + 2;
                                    Console.Write("SF shoots and scores!  He has " + asfp + " points");
                                    atlscore = atlscore + 2;
                                    amade = amade + 1;

                                }
                                else
                                {
                                    Console.Write("SF shoots and misses, Chicago takes over.");
                                    amiss = amiss + 1;
                                }
                                break;
                            case 4:
                                if (apf > result)
                                {
                                    apfp = apfp + 2;
                                    Console.Write("PF shoots and scores!  He has " + apfp + " points");
                                    atlscore = atlscore + 2;
                                    amade = amade + 1;

                                }
                                else
                                {
                                    Console.Write("PF shoots and misses, Chicago takes over.");
                                    amiss = amiss + 1;
                                }
                                break;
                            case 5:
                                if (acn > result)
                                {
                                    acnp = acnp + 2;
                                    Console.Write("C shoots and scores!  He has " + acnp + " points");
                                    atlscore = atlscore + 2;
                                    amade = amade + 1;

                                }
                                else
                                {
                                    Console.Write("C shoots and misses, Rebound to ");
                                    amiss = amiss + 1;
                                    pos = rnd.Next(1, 3);
                                    if (pos == 1)
                                        Console.Write("Atlanta");
                                    else
                                        Console.Write("Chicago");
                                    flag = 1;
                                }
                                break;

                        }
                        if (flag == 0)
                            pos = 2;
                        else
                            flag = 0;
                        Console.Write(" (" + result + ")");
                    }
                    else
                    {
                        Console.Write("CHI: ");
                        switch (shooter)
                        {
                            case 1:
                                if (cpg > result)
                                {
                                    cpgp = cpgp + 2;
                                    Console.Write("PG shoots and scores!  He has " + cpgp + " points");
                                    chiscore = chiscore + 2;
                                    cmade = cmade + 1;
                                }
                                else
                                {
                                    Console.Write("PG shoots and misses, Atlanta takes over.");
                                    cmiss = cmiss + 1;
                                }
                                break;
                            case 2:
                                if (csg > result)
                                {
                                    csgp = csgp + 2;
                                    Console.Write("SG shoots and scores!  He has " + csgp + " points");
                                    chiscore = chiscore + 2;
                                    cmade = cmade + 1;
                                }
                                else
                                {
                                    Console.Write("SG shoots and misses, Atlanta takes over.");
                                    cmiss = cmiss + 1;
                                }
                                break;
                            case 3:
                                if (csf > result)
                                {
                                    csfp = csfp + 2;
                                    Console.Write("SF shoots and scores!  He has " + csfp + " points");
                                    chiscore = chiscore + 2;
                                    cmade = cmade + 1;
                                }
                                else
                                {
                                    Console.Write("SF shoots and misses, Atlanta takes over.");
                                    cmiss = cmiss + 1;
                                }
                                break;
                            case 4:
                                if (cpf > result)
                                {
                                    cpfp = cpfp + 2;
                                    Console.Write("PF shoots and scores!  He has " + cpfp + " points");
                                    chiscore = chiscore + 2;
                                    cmade = cmade + 1;
                                }
                                else
                                {
                                    Console.Write("PF shoots and misses, Atlanta takes over.");
                                    cmiss = cmiss + 1;
                                }
                                break;
                            case 5:
                                if (ccn > result)
                                {
                                    ccnp = ccnp + 2;
                                    Console.Write("C shoots and scores!   He has " + ccnp + " points");
                                    chiscore = chiscore + 2;
                                    cmade = cmade + 1;
                                }
                                else
                                {
                                    Console.Write("C shoots and misses, Rebound to ");
                                    cmiss = cmiss + 1;
                                    pos = rnd.Next(1, 3);
                                    if (pos == 1)
                                        Console.Write("Atlanta");
                                    else
                                        Console.Write("Chicago");
                                    flag = 1;
                                }
                                break;

                        }
                        if (flag == 0)
                            pos = 1;
                        else
                            flag = 0;
                        Console.Write(" (" + result + ")");
                    }
                    clock = clock - time;
                    if (clock < 0)
                        clock = 0;
                    min = clock / 60;
                    sec = clock % 60;
                    
                    string secc = sec.ToString("00");
                    
                    
                    Console.Write("\n");
                    Console.Write("Atlanta: " + atlscore + "  Chicago: " + chiscore);
                    Console.Write("\n");
                    Console.Write("Time Left " + min + ":" + secc);
                    Console.Write("\n");
                    Console.Write("\n");
                    Thread.Sleep(1000);
                    

                }

                switch (quarter)
                {
                    case 1:
                        cq1 = chiscore;
                        aq1 = atlscore;
                        break;
                    case 2:
                        cq2 = chiscore - cq1;
                        aq2 = atlscore - aq1;
                        break;
                    case 3:
                        cq3 = chiscore - (cq1 + cq2);
                        aq3 = atlscore - (aq1 + aq2);
                        break;
                    case 4:
                        cq4 = chiscore - (cq1 + cq2 + cq3);
                        aq4 = atlscore - (aq1 + aq2 + aq3);
                        break;

                }
                quarter = quarter + 1;
                clock = 720;
                int ashot = amade + amiss;
                int cshot = cmade + cmiss;
                Console.WriteLine("BOX SCORE");
                Console.WriteLine("ATL: " + aq1 + " " + aq2 + " " + aq3 + " " + aq4 + " Final: " + atlscore);
                Console.WriteLine("CHI: " + cq1 + " " + cq2 + " " + cq3 + " " + cq4 + " Final: " + chiscore);
                Console.WriteLine("");
                Console.WriteLine("ATL FG = " + amade + "/" + ashot);
                Console.WriteLine("CHI FG = " + cmade + "/" + cshot);
                Console.WriteLine("");
                Console.WriteLine("ATL:  PG: " + apgp + " SG: " + asgp + " SF: " + asfp + " PF: " + apfp + " C: " + acnp);
                Console.WriteLine("CHI:  PG: " + cpgp + " SG: " + csgp + " SF: " + csfp + " PF: " + cpfp + " C: " + ccnp);
                Console.ReadKey();
            }
          

        }
        
    }
}
