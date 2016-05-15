using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02
{
    public class Students
    {
        public string[] name;
        public int[] chinese, english, math, number;
        int size, i, temp;
        string temp1;

        public int I
        {
            get
            {
                return i;
            }
            set
            {
                i = value;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }
        }

        public void Init(int num)
        {
            name = new string[num];
            chinese = new int[num];
            english = new int[num];
            math = new int[num];
            number = new int[num];
            size = num;
            i = 0;
            return;
        }

        public void Sorting()
        {
            for (int j = 1; j < size; ++j)
            {
                for(int k = j; k > 0;  --k)
                {
                    if (chinese[k] < chinese[k - 1])
                    {
                        temp = chinese[k - 1];
                        chinese[k - 1] = chinese[k];
                        chinese[k] = temp;

                        temp = english[k - 1];
                        english[k - 1] = english[k];
                        english[k] = temp;

                        temp = math[k - 1];
                        math[k - 1] = math[k];
                        math[k] = temp;

                        temp = number[k - 1];
                        number[k - 1] = number[k];
                        number[k] = temp;

                        temp1 = name[k - 1];
                        name[k - 1] = name[k];
                        name[k] = temp1;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool con = true, set = false;
            int mode;
            Students stu = new Students();

            while(!set)
            {
                Console.WriteLine("1> 輸入 2>印出 3> 排序(以國文成績排序) -1>離開");
                mode = int.Parse(Console.ReadLine());
                if(mode == 1)
                {
                    Console.WriteLine("請輸入班級人數: (僅第一次輸入需要使用)");
                    stu.Init(int.Parse(Console.ReadLine()));
                    set = true;
                }
                else if(mode == -1)
                {
                    con = false;
                    Console.WriteLine("再見");
                    Console.Read();

                    break;
                }
                else
                {
                    Console.WriteLine("未初使化");
                }
            }


            while (con)
            {
                Console.WriteLine("1> 輸入 2>印出 3> 排序(以國文成績排序) -1>離開");
                mode = int.Parse(Console.ReadLine());

                switch (mode)
                {
                    case 1:
                        if (stu.I < stu.Size)
                        {
                            Console.WriteLine("請輸入座號：");
                            stu.number[stu.I] = int.Parse(Console.ReadLine()); ;
                            Console.WriteLine("請輸入姓名：");
                            stu.name[stu.I] = Console.ReadLine().ToString();
                            Console.WriteLine("請輸入國文成績：");
                            stu.chinese[stu.I] = int.Parse(Console.ReadLine());
                            Console.WriteLine("請輸入英文成績：");
                            stu.english[stu.I] = int.Parse(Console.ReadLine());
                            Console.WriteLine("請輸入數學成績：");
                            stu.math[stu.I] = int.Parse(Console.ReadLine());
                            ++stu.I;
                        }
                        else
                        {
                            Console.WriteLine("人數已滿");
                        }

                        break;
                    case 2:
                        Console.WriteLine("座號\t國文\t英文\t數學\t姓名");
                        Console.WriteLine("=====================================");
                        for (int i = 0; i < stu.Size; ++i)
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", stu.number[i], stu.chinese[i], stu.english[i], stu.math[i], stu.name[i]);
                        }

                        break;
                    case 3:
                        stu.Sorting();

                        break;
                    case -1:
                        con = false;
                        Console.WriteLine("再見");
                        Console.Read();

                        break;
                    default:
                        Console.WriteLine("錯誤mode，請重新輸入");

                        break;
                }
            }
        }
    }
}
