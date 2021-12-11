using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace project_elgm3aa
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        double oilp = 21.0, sugerp = 8.5, ricep = 9.0,pastap=5.0,tunap=20.0,aothergoodp;
        //int _1pr = 49,_2pr=99,_3pr=149,_4pr=199,_5pr=224,_6pr=249;
        int pr;
        double oiltp , sugertp , ricetp , pastatp , tunatp,aothergoodstp ;
        double totalmon,totald3m;
        

        private void btn4_Click(object sender, EventArgs e)
        {
            pr = 199;
            btn1.BackColor = Color.FromArgb(227, 227, 227);
            btn4.BackColor = Color.Orange;
            btn3.BackColor = Color.FromArgb(227, 227, 227);
            btn2.BackColor = Color.FromArgb(227, 227, 227);
            btn5.BackColor = Color.FromArgb(227, 227, 227);
            btn6.BackColor = Color.FromArgb(227, 227, 227);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pr = 224;
            btn1.BackColor = Color.FromArgb(227, 227, 227);
            btn5.BackColor = Color.Orange;
            btn3.BackColor = Color.FromArgb(227, 227, 227);
            btn4.BackColor = Color.FromArgb(227, 227, 227);
            btn2.BackColor = Color.FromArgb(227, 227, 227);
            btn6.BackColor = Color.FromArgb(227, 227, 227);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pr = 249;
            btn1.BackColor = Color.FromArgb(227, 227, 227);
            btn6.BackColor = Color.Orange;
            btn3.BackColor = Color.FromArgb(227, 227, 227);
            btn4.BackColor = Color.FromArgb(227, 227, 227);
            btn5.BackColor = Color.FromArgb(227, 227, 227);
            btn2.BackColor = Color.FromArgb(227, 227, 227);
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            
            if (frqtext.Text=="")
            {
                totallab.Text = Convert.ToString(pr);

            }     
            else
            {
                totallab.Text = Convert.ToString(pr + Convert.ToDouble(frqtext.Text));
            }
            totald3m = pr + Convert.ToDouble(frqtext.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pr = 149;
            btn1.BackColor = Color.FromArgb(227, 227, 227);
            btn3.BackColor = Color.Orange;
            btn2.BackColor = Color.FromArgb(227, 227, 227);
            btn4.BackColor = Color.FromArgb(227, 227, 227);
            btn5.BackColor = Color.FromArgb(227, 227, 227);
            btn6.BackColor = Color.FromArgb(227, 227, 227);
        }

        private void zet_CheckedChanged(object sender, EventArgs e)
        {
            if (zet.Checked==true)
            {
                ZetTextbox.Enabled = true;
            }
            else
            {
                ZetTextbox.Enabled = false;
                ZetTextbox.Text = "0";
            }
        }

        private void Sokr_CheckedChanged(object sender, EventArgs e)
        {
            if (Sokr.Checked == true)
            {
                SokrTextbox.Enabled = true;
            }
            else
            {
                SokrTextbox.Enabled = false;
                SokrTextbox.Text = "0";
            }
        }

        private void rice_CheckedChanged(object sender, EventArgs e)
        {
            if (rice.Checked == true)
            {
                RiceTextbox.Enabled = true;
            }
            else
            {
                RiceTextbox.Enabled = false;
                RiceTextbox.Text = "0";
            }
        }

        private void Pasta_CheckedChanged(object sender, EventArgs e)
        {
            if (Pasta.Checked == true)
            {
                PastaTextbox.Enabled = true;
            }
            else
            {
                PastaTextbox.Enabled = false;
                PastaTextbox.Text = "0";
            }
        }

        private void Tuna_CheckedChanged(object sender, EventArgs e)
        {
            if (Tuna.Checked == true)
            {
                TunaTextbox.Enabled = true;
            }
            else
            {
                TunaTextbox.Enabled = false;
                TunaTextbox.Text = "0";
            }
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            if (totald3m-totalmon<0)
            {
                
                MessageBox.Show("على المواطن دفع مبلغ : "+(totalmon-totald3m));
            }
            else if (totald3m - totalmon > 0)
            {
                MessageBox.Show("باقى الدعم : " + (totald3m-totalmon));
            }
            else
            {
                MessageBox.Show("لا يوجد دعم  ");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void frqtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&ch!=8 && ch!=46)
            {
                e.Handled=true;
                MessageBox.Show("خطأ , غير مسموح بالاحرف يمكنك ادخال ارقام فقط");
               
            }
        }

        private void ZetTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("خطأ , غير مسموح بالاحرف يمكنك ادخال ارقام فقط");

            }
        }

        private void SokrTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("خطأ , غير مسموح بالاحرف يمكنك ادخال ارقام فقط");

            }
        }

        private void RiceTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("خطأ , غير مسموح بالاحرف يمكنك ادخال ارقام فقط");

            }
        }

        private void PastaTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("خطأ , غير مسموح بالاحرف يمكنك ادخال ارقام فقط");

            }
        }

        private void TunaTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("خطأ , غير مسموح بالاحرف يمكنك ادخال ارقام فقط");

            }
        }

        private void btnprevop_Click(object sender, EventArgs e)
        {
            previous_operations frm = new previous_operations();
            frm.Show();
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aothergoods_CheckedChanged(object sender, EventArgs e)
        {
            if (aothergoods.Checked == true)
            {
                nameaother.Enabled = true;
                prizeTextbox.Enabled = true;
                sizeaother.Enabled = true;
            }
            else
            {
                nameaother.Enabled =false;
                prizeTextbox.Enabled = false;
                sizeaother.Enabled = false;
            }
        }

        private void prizeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("خطأ , غير مسموح بالاحرف يمكنك ادخال ارقام فقط");

            }
        }

        private void sizeaother_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("خطأ , غير مسموح بالاحرف يمكنك ادخال ارقام فقط");

            }
        }
        bool close = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!close)
            {
                e.Cancel = true;
                this.Hide();
                notifyIcon1.ShowBalloonTip(1, "البركة للسلع التموينية", "البرنامج مازال يعمل فى الخلفية", ToolTipIcon.Info);
            }
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

      

        private void ToolStripMenuItem_Click2(object sender, EventArgs e)
        {
            previous_operations frm = new previous_operations();
            frm.Show();
            
        }

        private void ToolStripMenuItem_Click1(object sender, EventArgs e)
        {
            this.Show();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            close = true;
            Application.Exit();
        }

        private void totallab_Click(object sender, EventArgs e)
        {

        }
       
        private void btnfinsh_Click(object sender, EventArgs e)
        {
             string filename = "prevop.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"textfile\", filename);
            string text = ReceiptTextbox.Text;
           
            if (totald3m - totalmon > 0)
            {
                DialogResult dialog2 = MessageBox.Show("يوجد دعم بقيمة  " + (totald3m - totalmon) + " هل انت متاكد من انهاء العملية ", "تذكير !!!!!", MessageBoxButtons.YesNo);
                if (dialog2 == DialogResult.Yes)
                {
                    File.AppendAllText(path, text);
                    DialogResult dialogResult = MessageBox.Show("هل تود انشاء عمليه جديدة ؟", "تمت الاضافة بنجاح", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        zet.Checked = false;
                        Sokr.Checked = false;
                        Pasta.Checked = false;
                        rice.Checked = false;
                        Tuna.Checked = false;
                        btn1.BackColor = Color.FromArgb(227, 227, 227);
                        btn2.BackColor = Color.FromArgb(227, 227, 227);
                        btn3.BackColor = Color.FromArgb(227, 227, 227);
                        btn4.BackColor = Color.FromArgb(227, 227, 227);
                        btn5.BackColor = Color.FromArgb(227, 227, 227);
                        btn6.BackColor = Color.FromArgb(227, 227, 227);
                        frqtext.Text = "0";
                        totallab.Text = "0";
                        NameofprTextbox.Text = "";
                        totald3m = 0;
                        totalmon = 0;
                        pr = 0;
                        ReceiptTextbox.Clear();
                    }

                }
                else
                {

                }
            }
            else
            {
                File.AppendAllText(path, text);
                DialogResult dialogResult = MessageBox.Show("هل تود انشاء عمليه جديدة ؟", "تمت الاضافة بنجاح", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    zet.Checked = false;
                    Sokr.Checked = false;
                    Pasta.Checked = false;
                    rice.Checked = false;
                    Tuna.Checked = false;
                    btn1.BackColor = Color.FromArgb(227, 227, 227);
                    btn2.BackColor = Color.FromArgb(227, 227, 227);
                    btn3.BackColor = Color.FromArgb(227, 227, 227);
                    btn4.BackColor = Color.FromArgb(227, 227, 227);
                    btn5.BackColor = Color.FromArgb(227, 227, 227);
                    btn6.BackColor = Color.FromArgb(227, 227, 227);
                    frqtext.Text = "0";
                    totallab.Text = "0";
                    NameofprTextbox.Text = "";
                    totald3m = 0;
                    totalmon = 0;
                    pr = 0;
                    ReceiptTextbox.Clear();
                }
                else
                {

                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
            pr = 99;
            btn1.BackColor = Color.FromArgb(227, 227, 227);
            btn2.BackColor = Color.Orange;
            btn3.BackColor = Color.FromArgb(227, 227, 227);
            btn4.BackColor = Color.FromArgb(227, 227, 227);
            btn5.BackColor = Color.FromArgb(227, 227, 227);
            btn6.BackColor = Color.FromArgb(227, 227, 227);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pr = 49;
            btn1.BackColor=Color.Orange;
            btn2.BackColor = Color.FromArgb(227,227,227);
            btn3.BackColor = Color.FromArgb(227, 227, 227);
            btn4.BackColor = Color.FromArgb(227, 227, 227);
            btn5.BackColor = Color.FromArgb(227, 227, 227);
            btn6.BackColor = Color.FromArgb(227, 227, 227);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            zet.Checked = false;
            Sokr.Checked = false;
            Pasta.Checked = false;
            rice.Checked = false;
            Tuna.Checked = false;
            btn1.BackColor = Color.FromArgb(227, 227, 227);
            btn2.BackColor = Color.FromArgb(227, 227, 227);
            btn3.BackColor = Color.FromArgb(227, 227, 227);
            btn4.BackColor = Color.FromArgb(227, 227, 227);
            btn5.BackColor = Color.FromArgb(227, 227, 227);
            btn6.BackColor = Color.FromArgb(227, 227, 227);
            frqtext.Text = "0";
            totallab.Text = "0";
              NameofprTextbox.Text = "";
            totald3m = 0;
            totalmon = 0;
            pr = 0;
            ReceiptTextbox.Clear();

        }
        
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        public void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            dt1 = DateTime.Now;
            string dates = dt1.ToString("dddd, dd MMMM yyyy");
            label3.Text = dates;
        }
        DateTime dt1;
        private void button1_Click(object sender, EventArgs e)
        {
            dt1 = DateTime.Now;
            totalmon = 0;
            double x=0, y=0;
            double f = (pr + Convert.ToDouble(frqtext.Text));
            double oilps, sugerps, riceps, pastaps, tunaps,aothergoodps;
            aothergoodp = Convert.ToDouble(prizeTextbox.Text);
            oilps = Convert.ToDouble(ZetTextbox.Text);
            sugerps = Convert.ToDouble(SokrTextbox.Text);
            riceps = Convert.ToDouble(RiceTextbox.Text);
            pastaps = Convert.ToDouble(PastaTextbox.Text);
            tunaps = Convert.ToDouble(TunaTextbox.Text);
            aothergoodps = Convert.ToDouble(sizeaother.Text);
            oiltp = oilp * oilps;
            sugertp = sugerp * sugerps;
           ricetp = ricep * riceps;
            pastatp = pastap * pastaps;
            tunatp = tunap * tunaps;
            aothergoodstp = aothergoodp * aothergoodps;
            ReceiptTextbox.Clear();
            ReceiptTextbox.AppendText(Environment.NewLine);
            ReceiptTextbox.AppendText("\t          الاسم : " +NameofprTextbox.Text+ Environment.NewLine);
            ReceiptTextbox.AppendText("\t        اجمالى الدعم : " +f+Environment.NewLine);
            ReceiptTextbox.AppendText(Environment.NewLine);
            ReceiptTextbox.AppendText("\t" + dt1 + "\t" + Environment.NewLine);
            ReceiptTextbox.AppendText("\t************************" + Environment.NewLine);
            ReceiptTextbox.AppendText("\t            قائمة السلع" + Environment.NewLine);
            ReceiptTextbox.AppendText("\t************************" + Environment.NewLine);
            ReceiptTextbox.AppendText(Environment.NewLine);
            ReceiptTextbox.AppendText(Environment.NewLine);
            int count = 0;
            if (zet.Checked==true)
            {
                count++;
                ReceiptTextbox.AppendText("" + Convert.ToString(count) +".   "+oilps+ "  زيت :  " + oiltp + " جنية" + Environment.NewLine);
                totalmon += oiltp;
            }
            if (Sokr.Checked == true)
            {
                count++;
                ReceiptTextbox.AppendText("" + Convert.ToString(count) + ".   " + sugerps + "  سكر :  " + sugertp + " جنية" + Environment.NewLine);
                totalmon += sugertp;
            }
            if (rice.Checked == true)
            {
                count++;
                ReceiptTextbox.AppendText("" + Convert.ToString(count) + ".   " + riceps + "  أرز :  " + ricetp + " جنية" + Environment.NewLine);
                totalmon += ricetp;
            }
            if (Pasta.Checked == true)
            {
                count++;
                ReceiptTextbox.AppendText("" + Convert.ToString(count) + ".   " + pastaps + "  مكرونة :  " + pastatp + " جنية" + Environment.NewLine);
                totalmon += pastatp;
            }
            if (Tuna.Checked == true)
            {
                count++;
                ReceiptTextbox.AppendText("" + Convert.ToString(count) + ".   " + tunaps+ "  تونة :  " + tunatp + " جنية" + Environment.NewLine);
                totalmon += tunatp;
            }
            if (aothergoods.Checked == true)
            {
                count++;
                ReceiptTextbox.AppendText("" + Convert.ToString(count) + ".   " + aothergoodps + " "+nameaother.Text+" : " + aothergoodstp + " جنية" + Environment.NewLine);
                totalmon += aothergoodstp;
            }
            if (f - totalmon >= 0)
            {
                x = f - totalmon;
                y = 0;
            }
            else
            {
                x = 0;
                y = totalmon - f;
            }
            ReceiptTextbox.AppendText( Environment.NewLine);
            ReceiptTextbox.AppendText("*****************" + Environment.NewLine);
            ReceiptTextbox.AppendText("   الاجمالى : "+ totalmon+" جنية" + Environment.NewLine);
            ReceiptTextbox.AppendText("    باقى الدعم : "+x +" جنية" + Environment.NewLine);
            ReceiptTextbox.AppendText("   مدفوعات المواطن : "+ y+" جنية" + Environment.NewLine);
            ReceiptTextbox.AppendText( Environment.NewLine);

            ReceiptTextbox.AppendText("***********************************************" + Environment.NewLine);
            ReceiptTextbox.AppendText("***********************************************" + Environment.NewLine);

            ReceiptTextbox.AppendText(Environment.NewLine);
        }
    }
}
