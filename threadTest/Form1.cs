using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threadTest
{
    #region подписка на событие
    //public partial class Form1 : Form
    //{
    //    static bool flag = true;
    //    delegate void DelUpdate();

    //    public Form1()
    //    {
    //        InitializeComponent();
    //    }

    //    private void Form1_Load(object sender, EventArgs e)
    //    {
    //        Data.ValueChanged += upd;

    //        System.Timers.Timer test_timer = new System.Timers.Timer();
    //        test_timer.Interval = 100;
    //        test_timer.Elapsed += timer1_Tick;
    //        test_timer.Start();

    //        Data.A = true;
    //    }

    //    private void timer1_Tick(object sender, EventArgs e)
    //    {
    //        Data.A = !Data.A;
    //    }

    //    public void upd()
    //    {
    //        radioButton1.Checked = Data.A;
    //    }
    //    public void upd(object sender, EventArgs e)
    //    {
    //        DelUpdate _delUpdate = upd;
    //        radioButton1.Invoke(_delUpdate);
    //    }

    //    private void button1_Click(object sender, EventArgs e)
    //    {
    //        if (flag)
    //        {
    //            flag = false;
    //        }
    //        else
    //        {
    //            flag = true;
    //        }
    //    }
    //}
    #endregion

    #region только через делегат
    public partial class Form1 : Form
    {
        static bool flag = true;
        delegate void DelUpdate();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data.ValueChanged += upd;


            System.Timers.Timer test_timer = new System.Timers.Timer();
            test_timer.Interval = 2000;
            test_timer.Elapsed += timer1_Tick;
            test_timer.Start();

            Data.A = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //DelUpdate _delUpdate = upd;

            Data.A = !Data.A;
            //radioButton1.Invoke(_delUpdate);
        }

        public void upd()
        {
            radioButton1.Checked = Data.A;
        }
        public void upd(object sender, EventArgs e)
        {
            //radioButton1.Checked = Data.A;
            DelUpdate _delUpdate = upd;
            radioButton1.Invoke(_delUpdate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
        }
    }
    #endregion
}
