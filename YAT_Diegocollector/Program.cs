using System;
using System.Collections.Generic;
using System.Linq;

namespace YAT_Diegocollector
{
    // Диего увлекается коллекционированием наклеек. На каждой из них написано число, и каждый коллекционер
    // мечтает собрать наклейки со всеми встречающимися числами.
    // Диего собрал N наклеек, некоторые из которых, возможно, совпадают. Как-то раз к нему пришли K коллекционеров.
    // i-й из них собрал все наклейки с номерами не меньшими, чем pi.
    // Напишите программу, которая поможет каждому из коллекционеров определить, сколько недостающих ему наклеек есть
    // у Диего. Разумеется, гостей Диего не интересуют повторные экземпляры наклеек.

    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = {100, 1, 50};
            //int[] needNumbers = {300, 0, 75};

            // 3
            // 100 1 50
            // 3
            // 300 0 75


            // int.TryParse(Console.ReadLine(), out int cnt);
            // string cntString = Console.ReadLine();
            // int.TryParse(Console.ReadLine(), out int needcnt);
            // string needCntString = Console.ReadLine();

            int cnt = 10;
            string cntString = "100 1 50 10 15 44 95 1 35 15";
            int needcnt = 15;
            string needCntString = "300 0 75 50 46 85 46 14 34 68 47 55 23 1 35";
                
            Console.WriteLine("v1-----------");
            Diegocollector(cnt, cntString, needcnt, needCntString);
            Console.WriteLine("v2-----------");
            Diegocollectorv2(cnt, cntString, needcnt, needCntString);
            Console.WriteLine("v3-----------");
            Diegocollectorv3(cnt, cntString, needcnt, needCntString);
        }


        // ver1
        
        private static void Diegocollector(int cnt, string cntString, int needcnt, string needCntString)
        {
            string[] cntArr = cntString.Split(" ");

            // у диего надо убрать не уникальные наклейки
            var clearCntArr = cntArr.Distinct().ToArray();


            int[] intCnt = new int[clearCntArr.Length]; // длина уникального массива

            for (int i = 0; i < intCnt.Length; i++)
            {
                intCnt[i] = int.Parse(clearCntArr[i]);
            }

            int[] intNeedCnt = new int[needcnt];
            string[] needCntArr = needCntString.Split(" ");
            for (int i = 0; i < intNeedCnt.Length; i++)
            {
                intNeedCnt[i] = int.Parse(needCntArr[i]);
            }

            foreach (var needNumber in intNeedCnt)
            {
                int count = 0;
                foreach (var number in intCnt)
                {
                    if (needNumber > number)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
        }
        
        // ver2
        
        private static void Diegocollectorv2(int cnt, string cntString, int needcnt, string needCntString)
        {
            var cntArr = cntString?.Split(' ')?.Select(Int32.Parse)?.ToList().Distinct();
            
            var  needCnt = needCntString?.Split(' ')?.Select(Int32.Parse)?.ToList();
            
            foreach (var needNumber in needCnt)
            {
                int count = 0;
                foreach (var number in cntArr)
                {
                    if (needNumber > number)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
        
        // ver3
        
        private static void Diegocollectorv3(int result, string cntString, int needcnt, string needCntString)
        {
       
            var cntArr = cntString?.Split(' ')?.Select(Int32.Parse).OrderBy(a => a).Distinct()?.ToList();
            
            Dictionary<int, int> cntArrD = new Dictionary<int, int>();
            
            
            for (int i = 0; i < cntArr.Count; i++)
            {
                cntArrD.Add(i, cntArr[i]);
            }
            
            var needCnt = needCntString?.Split(' ')?.Select(Int32.Parse)?.ToList();
            
            foreach (var needNumber in needCnt)
            {
                int count = 0;

                for (int i = 0; i < cntArrD.Count; i++)
                {
                        if (needNumber > cntArrD[i])
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                }
                
                Console.WriteLine(count);
            }
            
        }
        
        // ver4  бинарный поиск вместо перебора ?
        
        
    }
}