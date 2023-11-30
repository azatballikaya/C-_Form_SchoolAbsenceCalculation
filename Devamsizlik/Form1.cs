using System.Security.Cryptography.X509Certificates;

namespace Devamsizlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Control(int index,string value, string [][] dizi, List<string> tamGun, List<string> yarimGun,List<string> cikmisSayilar)
        {
            
            int counter = 1;
            if (!cikmisSayilar.Contains(value))
            {
                for (int i = index + 1; i < 6; i++)
                {
                    for (int j = 0; j < dizi[i].Length; j++)
                    {

                        if (dizi[i][j] == value)
                            counter++;


                    }
                }
                if (counter >= 4)
                {
                    tamGun.Add(value);
                }
                else
                {
                    yarimGun.Add(value);
                }
                cikmisSayilar.Add(value);
            }
          
            

        }
        List<string> tamGun=new List<string>();
        List<string> yarimGun=new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            //string[] ders1 = textBox1.Text.Split(' ');
            //List<string> ders1List=new List<string>();
            //string[] ders2 = textBox1.Text.Split(' ');
            //List<string> ders2List = new List<string>();
            //string[] ders3 = textBox1.Text.Split(' ');
            //List<string> ders3List = new List<string>();
            //string[] ders4 = textBox1.Text.Split(' ');
            //List<string> ders4List = new List<string>();
            //string[] ders5 = textBox1.Text.Split(' ');
            //List<string> ders5List = new List<string>();
            //string[] ders6 = textBox1.Text.Split(' ');
            //List<string> ders6List = new List<string>();
            List<string>[] derslistArray = new List<string>[6];
            // List<string>[] derslistArray = new List<string>[6];
            
            string[][] dersString = new string[6][];
            List <string> tamGun= new List<string>();
            List <string> yarimGun= new List<string>();
            List <string> cikmisSayilar = new List<string>();

            dersString[0]=  textBox1.Text.Split(',');
            dersString[1] = textBox2.Text.Split(',');
            dersString[2] = textBox3.Text.Split(',');
            dersString[3] = textBox4.Text.Split(',');
            dersString[4] = textBox5.Text.Split(',');
            dersString[5] = textBox6.Text.Split(',');
            int j = 0;
           for(int i = 0;i<6;i++)
            {
                for (j = 0; j < dersString[i].Length;j++) {
                    Control(i, dersString[i][j], dersString, tamGun, yarimGun,cikmisSayilar);
                
                }
            }
            foreach(string item in tamGun)
            {
                label2.Text =label2.Text+" "+ item;
            }
            foreach (string item in yarimGun)
            {
                label4.Text=label4.Text+" "+ item;
            }
            //for (int i = 0; i < textboxList.Length; i++)
            //{
            //    dersString[i] = textboxList[i].Text.Split(' ');
            //}
            //int[] dizi = { 5, 9, 7, 8, 1 };
            ////label1.Text=dizi.FirstOrDefault(x => x == 7).ToString();

            //for (int i = 0; i < textboxList.Length; i++)
            //{
            //    for (int j = 0; j < dersString[i].Length; j++)
            //    {
            //        derslistArray[i][j] = dersString[i][j].ToString();
            //    }
            //}
            // label1.Text = derslistArray[0][1].ToString();


            //for (int i = 0;i<6;i++)
            //{
            //    dersString[i] = textboxList[i].Text.Split(' ');
            //}
            //for(int i = 0;i<6;i++)
            //{
            //    for(int j = 0; j < dersString[i].Length;j++)
            //    {
            //        if (dersString[i + 1].Contains(dersString[i][j]))
            //        {

            //        }
            //    }
            //}

            //dersString[1] = textBox2.Text.Split(' ');
            //dersString[2] = textBox3.Text.Split(' ');
            //dersString[3] = textBox4.Text.Split(' ');
            //dersString[4] = textBox5.Text.Split(' ');
            //dersString[5] = textBox6.Text.Split(' ');
            //for(int i = 0;i<6;i++)
            //{
            //    derslistArray[i].AddRange(dersString[i]);
            //}
            //label1.Text= derslistArray[0][1];



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
