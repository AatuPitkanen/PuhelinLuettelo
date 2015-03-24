using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class NaytaHenkilot : System.Web.UI.Page
    {
        SqlConnection conn;
        Asuntotyyppi[] astyyppi;
        Sukupuoli[] sukupuoli;
        Asunto[] asunto;
        DataGrid dataGridView1;
        protected void Page_Load(object sender, EventArgs e)
        {
            dataGridView1 = new DataGrid();
            connect();
            if (!Page.IsPostBack)
            {
                getSukupuolet();
                getAsunnot();
                getAsuntotyypit();
                showHenkilot();
            }
            
        }

        private void connect()
        {
            try
            {
                this.conn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=AsuntoLuettelo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void showHenkilot()
        {

            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("select * from dbo.Henkilo", this.conn);
                DataTable table = new DataTable();
                ad.Fill(table);
                GridView1.DataSource = table;
                GridView1.DataBind();
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
                GridView1.DataSource = table;
                GridView1.DataBind();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        protected void henkiloNappi_Click(object sender, EventArgs e)
        {
            showHenkilot();
        }

        protected void asunnotNappi_Click(object sender, EventArgs e)
        {
            showAsunnot();
        }
        public void getAsuntotyypit()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from dbo.Asuntotyyppi", this.conn);
            DataTable table = new DataTable();
            ad.Fill(table);
            astyyppi = new Asuntotyyppi[table.Rows.Count];
            this.atyyppi.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                astyyppi[i] = new Asuntotyyppi((int)table.Rows[i][0], (string)table.Rows[i][1]);
                Console.WriteLine(astyyppi[i].id + " | " + astyyppi[i].selite);
                this.atyyppi.Items.Add(astyyppi[i].selite);
            }
        }
        public void getSukupuolet()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from dbo.Sukupuoli", this.conn);
            DataTable table = new DataTable();
            ad.Fill(table);
            sukupuoli = new Sukupuoli[table.Rows.Count];
            this.sukupuoliList.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                sukupuoli[i] = new Sukupuoli((int)table.Rows[i][0], (string)table.Rows[i][1]);
                Console.WriteLine(sukupuoli[i].id + " | " + sukupuoli[i].selite);
                this.sukupuoliList.Items.Add(sukupuoli[i].selite);
            }
        }
        public void getAsunnot()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from dbo.Asunto", this.conn);
            DataTable table = new DataTable();
            ad.Fill(table);
            asunto = new Asunto[table.Rows.Count];
            this.asunnotLista.Items.Clear();
            this.asunnotLista.Items.Add("ei_asuntoa");
            this.asunnotLista2.Items.Clear();
            this.asunnotLista2.Items.Add("ei_asuntoa");
            for (int i = 0; i < table.Rows.Count; i++)
            {
             //   asunto[i] = new Asunto((int)table.Rows[i][0], (string)table.Rows[i][1], (int)table.Rows[i][2], (int)table.Rows[i][3], (int)table.Rows[i][4], Convert.ToBoolean((byte)table.Rows[i][5]));
                //Console.WriteLine(asunto[i].id + " | " + asunto[i].osoite + " | "+(asunto[i].omistus ? "Omistus":"Ei omistus"));
              //  this.asunnotLista.Items.Add(asunto[i].osoite);
               // this.asunnotLista2.Items.Add(asunto[i].osoite);
            }
        }

        public void addAsunto()
        {
            //Console.WriteLine("Attempting to add asunto: " + this.asuntoId.Text + this.asuntoOsoite.Text + this.asuntoAla.Text + this.asuntoHuoneet.Text + this.asuntoTyyppi.SelectedItem.ToString());
            try
            {
                string query = "insert into dbo.Asunto values(@id,@osoite,@ala,@huoneet,(select id from dbo.Asuntotyyppi where selite=@tyyppi),@omistus)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", this.aID.Text);
                cmd.Parameters.Add("@osoite", this.aosoite.Text);
                cmd.Parameters.Add("@ala", this.aala.Text);
                cmd.Parameters.Add("@huoneet", this.ahlkm.Text);
                cmd.Parameters.Add("@tyyppi", this.atyyppi.SelectedItem.ToString());
                cmd.Parameters.Add("@omistus", (this.aomistus.Checked ? "1" : "0"));

                Console.WriteLine(cmd.CommandText);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            getAsunnot();
        }
        public void addHenkilo()
        {
            try
            {
                string query = "insert into dbo.Henkilo values(@id,@etunimi,@sukunimi,@syntymaaika,(select id from dbo.Sukupuoli where selite=@sukupuoli),(select id from dbo.Asunto where osoite=@asunto))";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", this.hID.Text);
                cmd.Parameters.Add("@etunimi",this.henimi.Text);
                cmd.Parameters.Add("@sukunimi",this.hsnimi.Text);
                cmd.Parameters.Add("@syntymaaika", this.hsaika.Text);
                cmd.Parameters.Add("@sukupuoli",this.sukupuoliList.SelectedItem.Text);
                cmd.Parameters.Add("@asunto", this.asunnotLista.SelectedItem.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void poistaHenkilo()
        {
            try
            {
                string query = "delete from dbo.Henkilo where id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", this.hID_poista.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void poistaAsunto()
        {
            try
            {
                string query = "delete from dbo.Asunto where id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", this.aID_poista.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            poistaHenkilo();
            showHenkilot();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            poistaAsunto();
            showAsunnot();
        }

        protected void lisaaHenkilo_Click(object sender, EventArgs e)
        {
            addHenkilo();
            showHenkilot();
        }

        protected void lisaaAsunto_Click(object sender, EventArgs e)
        {
            addAsunto();
            showAsunnot();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            vaihdaAsuntoa();
            showHenkilot();
        }

        private void vaihdaAsuntoa()
        {
            try
            {
                string query = "update dbo.Henkilo set asunto=(select id from dbo.Asunto where osoite=@asunto) where id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", this.hID2.Text);
                cmd.Parameters.Add("@asunto", this.asunnotLista2.SelectedItem.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }

}