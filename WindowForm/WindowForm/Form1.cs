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
    public partial class Form1 : System.Windows.Forms.Form
    {
        class CustomForm : Form
        {
            public CustomForm()
            {
                Text = "제목글자";
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

            Label mlabel = new Label()
            {
                Text = "글자",
                Location = new Point(10, 120)
            };
            LinkLabel mlinklLabel = new LinkLabel()
            {
                Text = "메모장",
                Location = new Point(10, 150)
            };

            mlinklLabel.Click += LabelClick;

            Controls.Add(mlabel);
            Controls.Add(mlinklLabel);

            // 체크 박스
            CheckBox checkBox1 = new CheckBox() { };
            CheckBox checkBox2 = new CheckBox() { };
            CheckBox checkBox3 = new CheckBox() { };
            Button btn = new Button();

            checkBox1.Text = "Potato";
            checkBox2.Text = "Tomato";
            checkBox3.Text = "Banana";
            btn.Text = "클릭";

            checkBox1.Location = new Point(150, 80);
            checkBox2.Location = new Point(150, 100);
            checkBox3.Location = new Point(150, 120);
            btn.Location = new Point(150, 150);

            btn.Click += BtnClick;

            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            Controls.Add(btn);

            // 라디오 버튼
            GroupBox gBox1 = new GroupBox();
            GroupBox gBox2 = new GroupBox();
            RadioButton radio1 = new RadioButton();
            RadioButton radio2 = new RadioButton();
            RadioButton radio3 = new RadioButton();
            RadioButton radio4 = new RadioButton();
            Button btn2 = new Button();

            gBox1.Text = "채소";
            gBox2.Text = "과일";
            radio1.Text = "Potato";
            radio2.Text = "Tomato";
            radio3.Text = "Banana";
            radio4.Text = "Apple";
            btn2.Text = "클릭";

            gBox1.Size = new Size(100, 100);
            gBox2.Size = new Size(100, 100);

            gBox1.Location = new Point(300, 50);
            gBox2.Location = new Point(400, 50);
            radio1.Location = new Point(10, 30);
            radio2.Location = new Point(10, 60);
            radio3.Location = new Point(10, 30);
            radio4.Location = new Point(10, 60);
            btn2.Location = new Point(300, 150);

            btn2.Click += RadioClick;

            gBox1.Controls.Add(radio1);
            gBox1.Controls.Add(radio2);
            gBox2.Controls.Add(radio3);
            gBox2.Controls.Add(radio4);

            Controls.Add(gBox1);
            Controls.Add(gBox2);
            Controls.Add(btn2);

            productBindingSource.Add(new Product() { Name="Potato", Price=500 });
            productBindingSource.Add(new Product() { Name="Apple", Price=700 });
            productBindingSource.Add(new Product() { Name="Tomato", Price=400 });
            productBindingSource.Add(new Product() { Name="Banana", Price=600 });
            productBindingSource.Add(new Product() { Name="Melon", Price=1000 });
            productBindingSource.Add(new Product() { Name="Cherry", Price= 800 });


            comboBox1.SelectedIndexChanged += DateSelect;
            listBox1.SelectedIndexChanged += DateSelect;

        }

        private void DateSelect(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                ComboBox comboBox = (ComboBox)sender;
                Product product = (Product)comboBox.SelectedItem;
                //MessageBox.Show(comboBox.SelectedValue.ToString());
                MessageBox.Show(product.Name + " : " + product.Price);
            }
            else if (sender is ListBox)
            {
                ListBox listBox = (ListBox)sender;
                Product product = (Product)listBox.SelectedItem;
                //MessageBox.Show(listBox.SelectedValue.ToString());
                //MessageBox.Show(product.Name + " : " + product.Price);
            }
        }

        private void RadioClick(object sender, EventArgs e)
        {
            foreach (var outerItem in Controls)
            {
                if (outerItem is GroupBox)
                {
                    foreach (var innerItem in ((GroupBox)outerItem).Controls)
                    {
                        RadioButton radio = innerItem as RadioButton;
                        if (radio != null && radio.Checked)
                        {
                            MessageBox.Show(radio.Text);
                        }
                    }
                }
            }
        }

        private void BtnClick(object sender, EventArgs e)
        {
            List<String> list = new List<string>();
            foreach (var item in Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    if (checkBox.Checked)
                    {
                        list.Add(checkBox.Text);
                    }
                }
            }

            MessageBox.Show(string.Join(", ", list));
        }



        private void LabelClick(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("http://naver.com");
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("종료");
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
            CustomForm form = new CustomForm();
            form.MdiParent = this;
            form.Show();
            //form.ShowDialog(); // 모달 타입
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
