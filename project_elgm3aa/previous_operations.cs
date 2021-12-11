using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace project_elgm3aa
{
    public partial class previous_operations : Form
    {
        public previous_operations()
        {
            InitializeComponent();
            label4.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            var dt1 = DateTime.Now;
            string dates = dt1.ToString("dddd, dd MMMM yyyy");
            label3.Text = dates;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string path = Path.Combine(Environment.CurrentDirectory, @"textfile\", "prevop.txt");   
            string str = File.ReadAllText(path);
            if (String.IsNullOrEmpty(str))
            {
                MessageBox.Show("لا يوجد عمليات سابقة لعرضها","خطأ");
            }
            else           
                ReceiptTextbox2.Text=str;
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"textfile\", "prevop.txt");
            string str = File.ReadAllText(path);
            if (String.IsNullOrEmpty(str))
            {
                MessageBox.Show("لا يوجد عمليات سابقة لمسحها", "! خطأ");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("هل انت متاكد انك تريد مسح جميع العمليات السابقة", "مسح العمليات", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    File.WriteAllText(path, "");
                    ReceiptTextbox2.Clear();
                }
            }
        }
        
        private void SearchTextbtn_TextChanged(object sender, EventArgs e)
        {


           
            
        }
        bool nextres = false;
        int coun = 0;
        int coun2 = 0;
        private void btnsearch_Click(object sender, EventArgs e)
        {
            nextres = false;
            ReceiptTextbox2.SelectionStart = 0;
            ReceiptTextbox2.SelectAll();
            ReceiptTextbox2.SelectionBackColor = Color.Snow;
            coun = 0;
            bool found = false;
            string word = SearchTextbtn.Text;
                int start = 0;
                int end = ReceiptTextbox2.Text.LastIndexOf(SearchTextbtn.Text);
                while(start<end)
                {
                    int wordStartIndex = ReceiptTextbox2.Find(word, start,ReceiptTextbox2.TextLength, RichTextBoxFinds.None);
                    if(wordStartIndex>-1)
                    {
                    
                        ReceiptTextbox2.SelectionBackColor = Color.Yellow;
                        coun++;
                        found = true;
                    }
                    
                    start = ReceiptTextbox2.Text.IndexOf(SearchTextbtn.Text,start)+1 ;
                }
            
            if (found==false)
            {
                MessageBox.Show("لم يتم العثور على هذة الكلمة ", "خطأ");
            }
            else
            {
                nextres = true;
                MessageBox.Show(" تم العثور على الكلمة "+coun+" مرة");
            }
            coun2 = coun;
       
        }
        int start1 = 0;
        int counres = 0;
        private void btnnextres_Click(object sender, EventArgs e)
        {
            if (nextres)
            {
                ReceiptTextbox2.SelectionBackColor = Color.Yellow;
                string word = SearchTextbtn.Text;



                int wordStartIndex = ReceiptTextbox2.Find(word, start1, ReceiptTextbox2.TextLength, RichTextBoxFinds.None);
                if (wordStartIndex != -1)
                        {
                            
                            ReceiptTextbox2.SelectionBackColor = Color.OrangeRed;
                            ReceiptTextbox2.ScrollToCaret();
                            counres++;
                        
                        }
                start1 = ReceiptTextbox2.Text.IndexOf(SearchTextbtn.Text, start1) + 1;

                if (counres == coun2)
                {
                    MessageBox.Show("لا يوجد كلمات اخرى للنزول اليها ");
                    start1 = 0;
                    counres = 0;

                }

            }
            else
            {
                MessageBox.Show("لا يوجد كلمات للنزول اليها ", "خطأ");
            }
            
        }
    }
}
