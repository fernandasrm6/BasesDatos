using AccesoCSBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCongreso
{
    public partial class Consultas : Form
    {
      
        //atributos
        GestorBD.GestorBD GestorBD;
        String cadSql;
        DataSet dsGeneral = new DataSet();
        Comunes comunes = new Comunes();

    

        public Consultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }

        private void btnB_Click(object sender, EventArgs e)
        {

    
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd03", "marbar", "oracle");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        
//        escribir el nombre de los autores cuyos artículos aparecen en más congresos,
//indicando en cuántos.

        //Autores con más artículos 
        private void button3_Click(object sender, EventArgs e) {
            cadSql = "select au.NomA, count(distinct esc.IdArt) FROM TAutor au, TCongreso con, TParticipó part, TArtículo art, TEscribió esc WHERE au.IdAutor = esc.IdAutor and esc.IdArt = art.IdArt and part.IdArt= art.IdArt and part.IdCon = con.IdCon group by au.NomA, esc.IdArt";
            GestorBD.consBD(cadSql, "Temp", dsGeneral);
            dtgGeneral.DataSource = dsGeneral.Tables["Temp"];
        }

        private void dtgGeneral_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
        // Cantidad de artículos por año en cada institución
        private void button1_Click_1(object sender, EventArgs e) {
            cadSql = "SELECT count(*), ar.IdArt, i.IdOrg, extract(year FROM FechaIni), NomI"+
                    "from ttrabaja t, TInstitución i, TArtículo ar, TAutor au, TParticipó p, TCongreso co, TEscribió e"+
                    "where t.IdOrg= i.IdOrg and au.IdAutor= t.IdAutor and au.IdAutor=e.IdAutor and e.IdArt= ar.IdArt and ar.IdArt= p.IdArt and p.IdCon= co.IdCon"+
                    "group by NomI,ar.IdArt, i.IdOrg, extract(year FROM FechaIni)"+
                        "order by  extract(year FROM FechaIni)";
            GestorBD.consBD(cadSql, "Temp", dsGeneral);
            dtgGeneral.DataSource = dsGeneral.Tables["Temp"];
        }
        //Nombre y país de instituciones que otorgaron becas
// Consulta: listar el nombre y el país de las instituciones que otorgaron becas que generaron
//artículos que se presentaron en congresos patrocinados por esas instituciones.
        private void button2_Click(object sender, EventArgs e) {
            cadSql = "SELECT distinct org.nomOrg, ins.País"+
                        "FROM TOrganización org, TInstitución ins, TBeca beca, TArtículo art, TParticipó P, TOrganizador organ"+
                            "WHERE org.IdOrg = organ.IdOrg and ins.IdOrg = org.IdOrg and ins.IdOrg = beca.IdOrg and beca.IdArt = art.IdArt and art.IdArt = p.IdArt ";
            GestorBD.consBD(cadSql, "Temp", dsGeneral);
            dtgGeneral.DataSource = dsGeneral.Tables["Temp"];
        }
        //Monto total de financiamiento por empresas 
        private void button4_Click(object sender, EventArgs e) {
            cadSql = "select org.NomOrg, organ.Monto"+
                        "from TOrganizador organ, TOrganización org, TEmpresa em,  TCongreso con"+
                    "where organ.idOrg= org.IdOrg and em.idOrg= org.IdOrg and organ.idCon = con.IdCon";
            GestorBD.consBD(cadSql, "Temp", dsGeneral);
            dtgGeneral.DataSource = dsGeneral.Tables["Temp"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

