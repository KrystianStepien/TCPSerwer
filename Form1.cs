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
using System.Net;

namespace TPCSerwer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private TcpListener serwer = null;
        private TcpClient klient = null;

        private void przycisk_start_Click(object sender, EventArgs e)
        {
            IPAddress adresIP = null;
            try
            {
                adresIP = IPAddress.Parse(Adres.Text);
            }
            catch
            {
                MessageBox.Show("Błędny format adresu IP", "Błąd");
                Adres.Text = string.Empty;
                return;
            }
            int port = System.Convert.ToInt16(my_port.Value);
            try
            {
                serwer = new TcpListener(adresIP, port);
                serwer.Start();

                klient = serwer.AcceptTcpClient();
                info_o_poloczeniu.Items.Add("Nawiązano połaczenie!");

                przycisk_start.Enabled = false;
                przycisk_stop.Enabled = true;
                klient.Close();
                serwer.Stop();
            }
            catch(Exception ex)
            {
                info_o_poloczeniu.Items.Add("Błąd inicjacji serwera!");
                MessageBox.Show(ex.ToString(), "Błąd");
            }
        }
    }
}
