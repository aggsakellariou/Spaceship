using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp102
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<int> ScoreList = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("score.ser", FileMode.Open, FileAccess.Read);
            Score score = (Score)formatter.Deserialize(stream);
            stream.Close();

            ScoreList.Add(score.Number1);
            ScoreList.Add(score.Number2);
            ScoreList.Add(score.Number3);
            ScoreList.Add(score.Number4);
            ScoreList.Add(score.Number5);
            ScoreList.Add(score.Number6);
            ScoreList.Add(score.Number7);
            ScoreList.Add(score.Number8);
            ScoreList.Add(score.Number9);
            ScoreList.Add(score.Number10);

            var message = string.Join(Environment.NewLine, ScoreList.ToArray());
            MessageBox.Show(message,"TOP SCORE");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
