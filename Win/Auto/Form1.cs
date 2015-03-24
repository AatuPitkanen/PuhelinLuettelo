using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        Asunto[] asunto;

        public Form1()
        {
            InitializeComponent();
           
            connect();
        
        }

        public void getAsunnot()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from dbo.Asunto", this.conn);
            DataTable table = new DataTable();
            ad.Fill(table);
            asunto = new Asunto[table.Rows.Count];
            this.henkiloAsunto.Items.Clear();
            this.asuntoMenu.Items.Clear();
            this.henkiloAsunto.Items.Add("ei_asuntoa");
            this.asuntoMenu.Items.Add("ei_asuntoa");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                //asunto[i] = new Asunto((int)table.Rows[i][0], (string)table.Rows[i][1], (int)table.Rows[i][2], (int)table.Rows[i][3], (int)table.Rows[i][4], Convert.ToBoolean((byte)table.Rows[i][5]));
                // Console.WriteLine(asunto[i].id + " | " + asunto[i].osoite + " | "+(asunto[i].omistus ? "Omistus":"Ei omistus"));
                // this.henkiloAsunto.Items.Add(asunto[i].osoite);
                //this.asuntoMenu.Items.Add(asunto[i].osoite);
            }
        }

        public void addAsunto()
        {
            try
            {
                string query = "insert into dbo.Asunto values(@id,@osoite,@ala,@huoneet,(select id from dbo.Asuntotyyppi where selite=@tyyppi),@omistus)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", this.asuntoId.Text);
                cmd.Parameters.Add("@osoite", this.asuntoOsoite.Text);
                cmd.Parameters.Add("@ala", this.asuntoAla.Text);
                cmd.Parameters.Add("@huoneet", this.asuntoHuoneet.Text);
                cmd.Parameters.Add("@tyyppi", this.asuntoTyyppi.SelectedItem.ToString());
                cmd.Parameters.Add("@omistus", (this.asuntoOmistus.Checked ? "1" : "0"));

                Console.WriteLine(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            getAsunnot();
        }

        //Kanta yhteydenmääritys
        public void connect()
        {
            try
            {
                this.conn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=AsuntoLuettelo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

      
        public void showAsunnot()
        {

            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("select * from dbo.Asunto", this.conn);
                DataTable table = new DataTable();
                ad.Fill(table);
                dataGridView1.DataSource = table;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }



        private void asunnotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAsunnot();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addAsunto();
            showAsunnot();
        }


        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            Console.WriteLine("asdsdasdasd");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            poistaAsunto();
            showAsunnot();
        }

        private void poistaAsunto()
        {
            try
            {
                string query = "delete from dbo.Asunto where id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", this.asuntoID_poista.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
    public class Asunto
    {
        public int id, tyyppi, ala, huoneita;
        public bool omistus;
        public string osoite;
        public Asunto(int id, String osoite, int ala, int huoneita, int tyyppi, bool omistus)
        {
            this.id = id; this.osoite = osoite; this.ala = ala; this.huoneita = huoneita; this.tyyppi = tyyppi; this.omistus = omistus;
        }
    }
}
