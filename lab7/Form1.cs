using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        unsafe struct SmallData
        {
            public fixed byte a[16];
        }
        unsafe struct BigData
        {
            public fixed byte a[102400];
        }

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            LinkedList<SmallData> smallList = new LinkedList<SmallData>();
            int startTime, resTime, resFirst;
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                SmallData dat = new SmallData();
                smallList.AddFirst(dat);
            }
            resTime = Environment.TickCount - startTime;
            resFirst = resTime;
            var BigList = new LinkedList<BigData>();
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                BigList.AddFirst(d);
            }
            resTime = Environment.TickCount - startTime;
            MessageBox.Show(string.Format("Ввод в SmallList выполнен за {0:f2} сек. " +
                            "({1:f2} тиков). Ввод в BigList выполнен за {2:f2} сек. ({3:f2} тиков).",
                            (double)resFirst / 1000, resFirst, (double)resTime / 1000, resTime));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LinkedList<SmallData> smallList = new LinkedList<SmallData>();
            for (int i = 0; i < 2500; i++)
            {
                SmallData dat = new SmallData();
                smallList.AddFirst(dat);
            }
            int startTime, resTime, resFirst;
            startTime = Environment.TickCount;
            while(smallList.First != null)
            {
                var a = smallList.First;
                while (a.Next != null)
                    a = a.Next;
                a.List.Remove(a);
            }
            resFirst = Environment.TickCount - startTime;
            var BigList = new LinkedList<BigData>();
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                BigList.AddFirst(d);
            }
            startTime = Environment.TickCount;
            while (BigList.First != null)
            {
                var a = BigList.First;
                while (a.Next != null)
                    a = a.Next;
                a.List.Remove(a);
            }
            resTime = Environment.TickCount - startTime;
            MessageBox.Show(string.Format("Удаление из SmallList выполнено за {0:f2} сек. " +
                "({1:f2} тиков). Удаление из BigList выполнено за {2:f2} сек. ({3:f2} тиков).",
                (double)resFirst / 1000, resFirst, (double)resTime / 1000, resTime));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LinkedList<SmallData> smallList = new LinkedList<SmallData>();
            int startTime, resTime, resFirst;
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                SmallData dat = new SmallData();
                smallList.AddFirst(dat);
            }
            while (smallList.First != null)
            {
                var a = smallList.First;
                while (a.Next != null)
                    a = a.Next;
                a.List.Remove(a);
            }
            resFirst = Environment.TickCount - startTime;
            var BigList = new LinkedList<BigData>();
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                BigList.AddFirst(d);
            }
            while (BigList.First != null)
            {
                var a = BigList.First;
                while (a.Next != null)
                    a = a.Next;
                a.List.Remove(a);
            }
            resTime = Environment.TickCount - startTime;
            MessageBox.Show(string.Format("Взаимодействие с SmallList выполнено за {0:f2} сек. " +
                "({1:f2} тиков). Взаимодействие с BigList выполнено за {2:f2} сек. ({3:f2} тиков).",
                (double)resFirst / 1000, resFirst, (double)resTime / 1000, resTime));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var smallList = new LinkedList<SmallData>();
            int startTime, resTime, resFirst;
            startTime = Environment.TickCount;
            for(int i = 0; i<2500; i++)
            {
                var d = new SmallData();
                smallList.AddFirst(d);
            }
            resTime = Environment.TickCount - startTime;
            resFirst = resTime;
            var BigList = new LinkedList<BigData>();
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                BigList.AddFirst(d);
            }
            resTime = Environment.TickCount - startTime;
            MessageBox.Show(string.Format("Ввод в SmallList выполнен за {0:f2} сек. " +
                            "({1:f2} тиков). Ввод в BigList выполнен за {2:f2} сек. ({3:f2} тиков).",
                            (double)resFirst / 1000, resFirst, (double)resTime / 1000, resTime));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            LinkedList<SmallData> smallList = new LinkedList<SmallData>();
            for (int i = 0; i < 2500; i++)
            {
                SmallData dat = new SmallData();
                smallList.AddFirst(dat);
            }
            int startTime, resTime, resFirst;
            startTime = Environment.TickCount;
            while (smallList.First != null)
            {
                smallList.RemoveFirst();
            }
            resFirst = Environment.TickCount - startTime;
            var BigList = new LinkedList<BigData>();
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                BigList.AddFirst(d);
            }
            startTime = Environment.TickCount;
            while (BigList.First != null)
            {
                BigList.RemoveFirst();
            }
            resTime = Environment.TickCount - startTime;
            MessageBox.Show(string.Format("Удаление из SmallList выполнено за {0:f2} сек. " +
                "({1:f2} тиков). Удаление из BigList выполнено за {2:f2} сек. ({3:f2} тиков).",
                (double)resFirst / 1000, resFirst, (double)resTime / 1000, resTime));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LinkedList<SmallData> smallList = new LinkedList<SmallData>();
            int startTime, resTime, resFirst;
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                SmallData dat = new SmallData();
                for (int j = 0; j < 16; j++)
                smallList.AddFirst(dat);
            }
            while (smallList.First != null)
            {
                smallList.RemoveFirst();
            }
            resFirst = Environment.TickCount - startTime;
            var BigList = new LinkedList<BigData>();
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                BigList.AddFirst(d);
            }
            while (BigList.First != null)
            {
                BigList.RemoveFirst();
            }
            resTime = Environment.TickCount - startTime;
            MessageBox.Show(string.Format("Взаимодействие с SmallList выполнено за {0:f2} сек. " +
                "({1:f2} тиков). Взаимодействие с BigList выполнено за {2:f2} сек. ({3:f2} тиков).",
                (double)resFirst / 1000, resFirst, (double)resTime / 1000, resTime));
        }
        private void button8_Click(object sender, EventArgs e)
        {
            LinkedList<SmallData> li = new LinkedList<SmallData>();
            int startTime, resTime, resFirst;
            startTime = Environment.TickCount;
            for(int i = 0; i < 2500; i++)
            {
                var d = new SmallData();
                li.AddFirst(d);
            }
            resFirst = Environment.TickCount - startTime;
            LinkedList<BigData> BLi = new LinkedList<BigData>();
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                BLi.AddFirst( d );
            }
            resTime = Environment.TickCount - startTime;
            MessageBox.Show(string.Format("Ввод в SmallList выполнен за {0:f2} сек. " +
                "({1:f2} тиков). Ввод в BigList выполнен за {2:f2} сек. ({3:f2} тиков).",
                (double)resFirst/1000, resFirst, (double)resTime/1000, resTime));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LinkedList<SmallData> li = new LinkedList<SmallData>();
            int startTime, resTime, resFirst;
            for (int i = 0; i < 2500; i++)
            {
                var d = new SmallData();
                li.AddFirst(d);
            }
            var a = li.First;
            startTime = Environment.TickCount;
            while (a != null)
            {
                li.Remove(a);
                a = a.Next;
            }
            resFirst = Environment.TickCount - startTime;
            LinkedList<BigData> BLi = new LinkedList<BigData>();
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                BLi.AddFirst(d);
            }
            var b = BLi.First;
            startTime = Environment.TickCount;
            while (b != null)
            {
                BLi.Remove(b);
                b = b.Next;
            }
            resTime = Environment.TickCount - startTime;
            MessageBox.Show(string.Format("Удаление из SmallList выполнено за {0:f2} сек. " +
                "({1:f2} тиков). Удаление из BigList выполнено за {2:f2} сек. ({3:f2} тиков).",
                (double)resFirst / 1000, resFirst, (double)resTime / 1000, resTime));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LinkedList<SmallData> li = new LinkedList<SmallData>();
            int startTime, resTime, resFirst;
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                var d = new SmallData();
                li.AddFirst(d);
            }
            var a = li.First;
            while (a != null)
            {
                li.Remove(a);
                a = a.Next;
            }
            resFirst = Environment.TickCount - startTime;
            LinkedList<BigData> BLi = new LinkedList<BigData>();
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                BLi.AddFirst(d);
            }
            var b = BLi.First;
            while (b != null)
            {
                BLi.Remove(b);
                b = b.Next;
            }
            resTime = Environment.TickCount - startTime;
            MessageBox.Show(string.Format("Взаимодействие с SmallList выполнено за {0:f2} сек. " +
                "({1:f2} тиков). Взаимодействие с BigList выполнено за {2:f2} сек. ({3:f2} тиков).",
                (double)resFirst / 1000, resFirst, (double)resTime / 1000, resTime));
        }
    }
}
