using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForm
{
    public partial class Form1 : Form
    {
        class CustomForm : Form
        {
            public CustomForm()
            {
                Text = "제목 글자";
            }
        }

        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
            /*
            myButton.Text = "코드에서 변경";
            myButton.Width = 100;

            for (int i = 0; i < 5; i++)
            {
                Button button1 = new Button();
                Controls.Add(button1);
                button1.Location = new Point(13, 13 + (23 + 3) * (i+1));
                button1.Text = "동적 "+ i +" 생성";
            }
             */
            myButton.Click += Custom_Click;
            FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("내용");
            MessageBox.Show("내용", "제목");
            //MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);
            DialogResult result;
            do
            {
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);
            } while (result == DialogResult.Retry);
        }
    
        private void Custom_Click(object sender, EventArgs e)
        {
            textBox1.Text += "@";
            label1.Text += "@";

            Button self = (Button)sender;
            self.Text = "";
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            label1.Text += "+";
        }

        private int elaspedTimer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elaspedTimer++;
            textBox1.Text = elaspedTimer%60 + "초 경과";
            label1.Text = (elaspedTimer/60) + "분 경과";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CustomForm formA = new CustomForm();
            formA.MdiParent = this; // 모달에서는 MDI사용불가
            formA.Show(); // 모달리스(Modeless) 
            //formA.ShowDialog(); // 모달(Modal)
        }
    }
}
