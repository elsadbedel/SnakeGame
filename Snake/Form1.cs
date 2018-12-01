using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ButtonSNake.Left = 0;
            timer1.Interval =50;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            En.Text = this.Width.ToString();
            Uzunluq.Text = this.Height.ToString();
        }

        int posLeft = 0;
        public void SolaHereket()
        {
            posLeft -= 20;
            ButtonSNake.Left = posLeft;

            if (ButtonSNake.Left >= this.Width)
            {
                posLeft = 0;
                ButtonSNake.Left = 0;
            }

        }
        public void SagaHereket()
        {
            posLeft += 20;
            ButtonSNake.Left = posLeft;

            if (ButtonSNake.Left >= this.Width)
            {
                posLeft = 0;
                ButtonSNake.Left = 0;
            }


        }
        int posTop = 0;
        public void AsagiHereket()
        {
            posTop += 20;
            ButtonSNake.Top = posTop;

            if (ButtonSNake.Top >= this.Height)
            {
                posTop = 0;
                ButtonSNake.Top = 0;
            }


        }
        public void YuxariHereket()
        {
            posTop -= 20;
            ButtonSNake.Top = posTop;

            if (ButtonSNake.Top >= this.Height)
            {
                posTop = 0;
                ButtonSNake.Top = 0;
            }


        }


        int Hereket = 0;
        private void ButtonSNake_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.S:
                    //asagi

                    Hereket = 1;
                    timer1.Start();
                    break;
                case Keys.W:
                    //yuxari
                    Hereket = 2;
                    timer1.Start();

                    break;
                case Keys.A:
                    //Sola
                    Hereket = 3;
                    timer1.Start();

                    break;
                case Keys.D:
                    //saga
                    SagaHereket();
                    timer1.Start();
                    Hereket = 4;

                    break;
                default:
                    timer1.Stop();
                    break;
            }
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            switch (Hereket)
            {
                case 1:
                    AsagiHereket();
                    break;
                case 2:
                    YuxariHereket();
                    break;
                case 3:
                    SolaHereket();
                    break;
                case 4:
                    SagaHereket();
                    break;
                default:
                    break;
            }
        }
    }
}
