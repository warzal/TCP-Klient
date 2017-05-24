using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TCP_Klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Połącz
            string host = Adres.Text;
            int port = System.Convert.ToInt32(my_port.Value);

            try
            {
                TcpClient klient = new TcpClient(host, port);
                info_o_polaczeniu.Items.Add("Nawiazanio połączenie z " + host + " na koncie:" + port);
                klient.Close();
            }
            catch (Exception ex)
            {
                info_o_polaczeniu.Items.Add("Bład: " + "Nie udało sie nawiązać połaczenia!");
                MessageBox.Show(ex.ToString(), "Błąd");
                
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
