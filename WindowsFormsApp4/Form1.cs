using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
       
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            int tmp = 0;

       
                int.TryParse(hsec.Text, out tmp);
                tmp--;
        
           

              
                    int tmp_s = 0;
            if (Convert.ToInt32(second.Text) != 0 && (Convert.ToInt32(minut.Text) != 0) || Convert.ToInt32(hour.Text) != 0)
            {
                if (tmp <= 0)
                {

                    int.TryParse(second.Text, out tmp_s);
                    second.Text = Convert.ToString(tmp_s - 1);
                    hsec.Text = "99";
                    progressBar1.Value++;

                    if (tmp_s == 0)
                    {
                        int tmp_hour = 0;
                        int.TryParse(minut.Text, out tmp_hour);
                        if (Convert.ToInt32(hour.Text) != 0)
                        {
                            if (tmp_hour == 0)
                            {
                                int tmp2 = 0;

                                int.TryParse(hour.Text, out tmp2);
                                hour.Text = Convert.ToString(tmp2 - 1);
                                minut.Text = "59";
                            }
                            else
                            {
                                minut.Text = Convert.ToString(tmp_hour - 1);
                            }
                            second.Text = Convert.ToString(59);
                        }
                    }

                }
                else
                {
                    this.hsec.Text = tmp.ToString();
                }
            }
            else if (Convert.ToInt32(minut.Text) > 0)
            {
                if (tmp <= 0)
                {

                    int.TryParse(second.Text, out tmp_s);
                    second.Text = Convert.ToString(tmp_s - 1);
                    if (tmp_s == 0)
                    {
                        int tmp_hour = 0;
                        int.TryParse(minut.Text, out tmp_hour);
                        minut.Text = Convert.ToString(tmp_hour - 1);
                        second.Text = "59";


                    }
                    hsec.Text = "99";
                    progressBar1.Value++;
                }


                this.hsec.Text = tmp.ToString();

            }
            else if (Convert.ToInt32(second.Text) > 0)
            {

                if (tmp <= 0)
                {
                    int.TryParse(second.Text, out tmp_s);
                    second.Text = Convert.ToString(tmp_s - 1);
                    hsec.Text = "99";
                    progressBar1.Value++;
                }
                else
                    this.hsec.Text = tmp.ToString();


            }
            else if(tmp!=-1)
            {
               
                this.hsec.Text = tmp.ToString();
            }
            else
            {
                progressBar1.Value = progressBar1.Maximum;
                timer1.Stop();
                timer1.Tag = "Stop";

            }
       
     
           
         
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 2;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Tag = "Start";
            progressBar1.Value = 0;
            progressBar1.Maximum = (Convert.ToInt32(second.Text) + Convert.ToInt32(minut.Text) * 60 + Convert.ToInt32(hour.Text) * 60 * 60)+1;

            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Tag = "Stop";
        }
        private void ResetAll2()
        {
            s2.Text = "0";
            m2.Text = "0";
            h2.Text = "0";
            timer1.Tag = "Start";
        }
        private void button5_Click(object sender, EventArgs e)
        {
           
                ResetAll2();
            
                
            
           
        }
        private void ResetTimer()
        {
            timer1.Stop();
            
            progressBar1.Value = 0;
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tag = "Stop";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            second.Text = s2.Text;
            hour.Text = m2.Text;
            minut.Text = h2.Text;
        }
        private void ResetAll1()
        {
            hsec.Text = "0";
            second.Text = "0";
            hour.Text = "0";
            minut.Text = "0";
        }
        private async  void ShowMesText()
        {
            MessgeText.Visible = true;
            await  Task.Delay(1500);
            MessgeText.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
        if (timer1.Tag == "Stop")
        {
            ResetAll1();
            ResetTimer();
        }
        else
            {
                ShowMesText();


            }
        }
    }
}
