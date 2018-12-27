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
                for (int j = 0; j < 16; j++)
                {
                    unsafe { dat.a[j] = (byte)j; }
                }
                smallList.AddFirst(dat);
            }
            resTime = Environment.TickCount - startTime;
            resFirst = resTime;
            var BigList = new LinkedList<BigData>();
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                for (int j = 0; j < 102400; j++)
                {
                    unsafe { d.a[j] = (byte)j; }
                }
                BigList.AddFirst(d);
            }
            resTime = Environment.TickCount - startTime;
            MessageBox.Show(string.Format("Ввод в SmallList выполнен за {0:f2} сек. " +
                            "({1:f2} тиков). Ввод в BigList выполнен за {2:f2} сек. ({3:f2} тиков).",
                            (double)resFirst / 1000, resFirst, (double)resTime / 1000, resTime));
        }

        unsafe struct SmallData
        {
            public fixed byte a[16];
        }
        unsafe struct BigData
        {
            public fixed byte a[102400];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LinkedList<SmallData> smallList = new LinkedList<SmallData>();
            for (int i = 0; i < 2500; i++)
            {
                SmallData dat = new SmallData();
                for (int j = 0; j < 16; j++)
                {
                    unsafe { dat.a[j] = (byte)j; }
                }
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
                for (int j = 0; j < 102400; j++)
                {
                    unsafe { d.a[j] = (byte)j; }
                }
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
                for (int j = 0; j < 16; j++)
                {
                    unsafe { dat.a[j] = (byte)j; }
                }
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
                for (int j = 0; j < 102400; j++)
                {
                    unsafe { d.a[j] = (byte)j; }
                }
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
                for (int j = 0; j < 16; j++)
                {
                    unsafe { d.a[j] = (byte)j; }
;                }
                smallList.AddFirst(d);
            }
            resTime = Environment.TickCount - startTime;
            resFirst = resTime;
            var BigList = new LinkedList<BigData>();
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                for (int j = 0; j < 102400; j++)
                {
                    unsafe { d.a[j] = (byte)j; }
                }
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
                for (int j = 0; j < 16; j++)
                {
                    unsafe { dat.a[j] = (byte)j; }
                }
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
                for (int j = 0; j < 102400; j++)
                {
                    unsafe { d.a[j] = (byte)j; }
                }
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
                {
                    unsafe { dat.a[j] = (byte)j; }
                }
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
                for (int j = 0; j < 102400; j++)
                {
                    unsafe { d.a[j] = (byte)j; }
                }
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

        class ListNode<T>
        {
            public T data;
            public ListNode<T> next;
            
        }

        class MyList<T>
        {
            List<ListNode<T>> list = new List<ListNode<T>>();
            public ListNode<T> first; 
            public void AddFirst(ListNode<T> node)
            {
                list.Add(node);
                node.next = first;
                first = node;
            }
            public void Remove(ListNode<T> rem)
            {
                var a = first;
                while (a != null)
                {
                    if (a == rem)
                    {
                        list.Remove(a);
                        break;
                    }
                    a = a.next;
                }
                if (a != null)
                {
                    var b = new ListNode<T>() { data = default(T), next = first };
                    while (!b.next.Equals(a))
                    {
                        b = b.next;
                    }
                    b.next = a.next;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MyList<SmallData> li = new MyList<SmallData>();
            int startTime, resTime, resFirst;
            startTime = Environment.TickCount;
            for(int i = 0; i < 2500; i++)
            {
                var d = new SmallData();
                for(int j = 0; j<16; j++)
                {
                    unsafe { d.a[j] = (byte)j; }
                }
                li.AddFirst(new ListNode<SmallData>() { data = d } );
            }
            resFirst = Environment.TickCount - startTime;
            MyList<BigData> BLi = new MyList<BigData>();
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                for (int j = 0; j < 102400; j++)
                {
                    unsafe { d.a[j] = (byte)j; }
                }
                BLi.AddFirst(new ListNode<BigData>() { data = d });
            }
            resTime = Environment.TickCount - startTime;
            MessageBox.Show(string.Format("Ввод в SmallList выполнен за {0:f2} сек. " +
                "({1:f2} тиков). Ввод в BigList выполнен за {2:f2} сек. ({3:f2} тиков).",
                (double)resFirst/1000, resFirst, (double)resTime/1000, resTime));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MyList<SmallData> li = new MyList<SmallData>();
            int startTime, resTime, resFirst;
            for (int i = 0; i < 2500; i++)
            {
                var d = new SmallData();
                for (int j = 0; j < 16; j++)
                {
                    unsafe { d.a[j] = (byte)j; }
                }
                li.AddFirst(new ListNode<SmallData>() { data = d });
            }
            var a = li.first;
            startTime = Environment.TickCount;
            while (a != null)
            {
                li.Remove(a);
                a = a.next;
            }
            resFirst = Environment.TickCount - startTime;
            MyList<BigData> BLi = new MyList<BigData>();
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                for (int j = 0; j < 102400; j++)
                {
                    unsafe { d.a[j] = (byte)j; }
                }
                BLi.AddFirst(new ListNode<BigData>() { data = d });
            }
            var b = BLi.first;
            startTime = Environment.TickCount;
            while (b != null)
            {
                BLi.Remove(b);
                b = b.next;
            }
            resTime = Environment.TickCount - startTime;
            MessageBox.Show(string.Format("Удаление из SmallList выполнено за {0:f2} сек. " +
                "({1:f2} тиков). Удаление из BigList выполнено за {2:f2} сек. ({3:f2} тиков).",
                (double)resFirst / 1000, resFirst, (double)resTime / 1000, resTime));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MyList<SmallData> li = new MyList<SmallData>();
            int startTime, resTime, resFirst;
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                var d = new SmallData();
                for (int j = 0; j < 16; j++)
                {
                    unsafe { d.a[j] = (byte)j; }
                }
                li.AddFirst(new ListNode<SmallData>() { data = d });
            }
            var a = li.first;
            while (a != null)
            {
                li.Remove(a);
                a = a.next;
            }
            resFirst = Environment.TickCount - startTime;
            MyList<BigData> BLi = new MyList<BigData>();
            startTime = Environment.TickCount;
            for (int i = 0; i < 2500; i++)
            {
                var d = new BigData();
                for (int j = 0; j < 102400; j++)
                {
                    unsafe { d.a[j] = (byte)j; }
                }
                BLi.AddFirst(new ListNode<BigData>() { data = d });
            }
            var b = BLi.first;
            while (b != null)
            {
                BLi.Remove(b);
                b = b.next;
            }
            resTime = Environment.TickCount - startTime;
            MessageBox.Show(string.Format("Взаимодействие с SmallList выполнено за {0:f2} сек. " +
                "({1:f2} тиков). Взаимодействие с BigList выполнено за {2:f2} сек. ({3:f2} тиков).",
                (double)resFirst / 1000, resFirst, (double)resTime / 1000, resTime));
        }
    }
}
