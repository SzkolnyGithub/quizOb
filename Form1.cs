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
using Newtonsoft.Json;

namespace pytaniaBadowski4c
{
    public partial class Form1 : Form
    {
        int currentIndex = 0;
        List<pytanieC> pytania = new List<pytanieC>();
        char[] odpowiedzi;
        public Form1()
        {
            InitializeComponent();
            string text = File.ReadAllText("../../../pytania.txt");
            pytania = JsonConvert.DeserializeObject<List<pytanieC>>(text);
            odpowiedzi = new char[pytania.Count];
            end.Visible = false;
            end.Enabled = false;
            loadScreen();
        }
        private void loadScreen()
        {
            odp11.Checked = false;
            odp22.Checked = false;
            odp33.Checked = false;
            odp44.Checked = false;
            //test.Text = odpowiedzi[currentIndex].ToString();
            if (currentIndex == pytania.Count-1)
            {
                next.Enabled = false;
                end.Visible = true;
                end.Enabled = true;
            } else
            {
                next.Enabled = true;
            }
            if(currentIndex >= pytania.Count)
            {
                currentIndex--;
                return;
            }
            pyt.Text = pytania[currentIndex].pytanie;
            if(currentIndex == 0)
            {
                back.Enabled = false;
            } else
            {
                back.Enabled = true;
            }
            odp11.Text = pytania[currentIndex].odp1;
            odp22.Text = pytania[currentIndex].odp2;
            odp33.Text = pytania[currentIndex].odp3;
            odp44.Text = pytania[currentIndex].odp4;
        }

        private void back_Click(object sender, EventArgs e)
        {
            currentIndex--;
            loadScreen();
        }

        private void next_Click(object sender, EventArgs e)
        {
            currentIndex++;
            loadScreen();
        }

        private void odp11_CheckedChanged(object sender, EventArgs e)
        {
            odpowiedzi[currentIndex] = pytania[currentIndex].odp1[0];
        }

        private void odp22_CheckedChanged(object sender, EventArgs e)
        {
            odpowiedzi[currentIndex] = pytania[currentIndex].odp2[0];
        }

        private void odp33_CheckedChanged(object sender, EventArgs e)
        {
            if(pytania[currentIndex].odp3 == "" || pytania[currentIndex].odp3 == null)
            {
                odp33.Text = "Brak odpowiedzi";
                return;
            }
            odpowiedzi[currentIndex] = pytania[currentIndex].odp3[0];
        }

        private void odp44_CheckedChanged(object sender, EventArgs e)
        {
            if (pytania[currentIndex].odp4 == "" || pytania[currentIndex].odp4 == null)
            {
                odp44.Text = "Brak odpowiedzi";
                return;
            }
            odpowiedzi[currentIndex] = pytania[currentIndex].odp4[0];
        }

        private void end_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i < odpowiedzi.Length; i++)
            {
                //test.Text += odpowiedzi[i].ToString() + " " + pytania[i].popOdp + "\n";
                if (odpowiedzi[i].ToString() == pytania[i].popOdp)
                {
                    sum++;
                }
            }
            MessageBox.Show("Zdobyłeś " + sum + "/" + odpowiedzi.Length + " puntków.", "Quiz zakończony!");
        }
    }
}