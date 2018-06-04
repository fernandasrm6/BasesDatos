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
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
         

        }
//        5. Un formulario para que dado el nombre de un autor (a través de un combo box) y una fecha
//(por medio de un DateTimePicker), se muestren todos los artículos que ha presentado (o
//presentará) a partir de esa fecha, detallando por cada artículo: co-autores, nombre de la
//institución en que trabaja el autor, si el artículo fue financiado o no, nombre del congreso y
//fecha de presentación, y total de congresos en que se ha presentado (incluidos en los que se
//presentará). Emplea únicamente los objetos no gráficos de ADO.Net.
        GestorBD.GestorBD GestorBD;
        DataSet dsAutores = new DataSet();
         DataSet dsAux = new DataSet();
        //private const int OK = 1;
        Comunes comunes = new Comunes();
        String cadSql,aux;

        //date'2016-08-10'
        private void dateT_ValueChanged(object sender, EventArgs e) {
      
            
            cadSql = "select distinct art.nomart, art.idart, org.nomorg, beca.clase, con.nomcon, con.fechaini " +
     "from tartículo art, tescribió es, tbeca beca, tcongreso con, tparticipó par, torganización org, tautor au " +
     " where art.idart = par.idart and es.idart = art.idart and con.idcon = par.idcon and beca.idorg = org.idorg and es.idautor = au.idautor and au.noma = '" + cBox.Text + "' and con.FechaIni>= date '" + dateT.Text +
     "' order by nomorg ";
            GestorBD.consBD(cadSql, "a", dsAux);
            dsGeneral.DataSource = dsAux.Tables["a"];
        }
        private void dsGeneral_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //AQUI NO VA NADA
        }

        private void Compras_Load(object sender, EventArgs e) {
            //1. Hace la conexion a la BD
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd03", "marbar", "oracle");

            //2 Muesta en el grid los datos de los alumnos

            cadSql = "select * from tautor";
            GestorBD.consBD(cadSql, "Autor", dsAutores);
            dsGeneral.DataSource = dsAutores.Tables["Autor"];
            comunes.cargaCombo(cBox, dsAutores, "Autor", "NomA");
        }

        private void cBox_SelectedIndexChanged(object sender, EventArgs e) {
            //String fecha = datepicker BLAH BAH CONCATENAR
            String fecha = dateT.Text;
            dsAux = new DataSet();

            cadSql = "select distinct art.nomart, art.idart, org.nomorg, beca.clase, con.nomcon, con.fechaini " +
           "from tartículo art, tescribió es, tbeca beca, tcongreso con, tparticipó par, torganización org, tautor au " +
           " where art.idart = par.idart and es.idart = art.idart and con.idcon = par.idcon and beca.idorg = org.idorg and es.idautor = au.idautor and au.noma = '" + cBox.Text +
           "' order by nomorg ";
       
            GestorBD.consBD(cadSql, "a", dsAux);
            dsGeneral.DataSource = dsAux.Tables["a"];
            aux = cBox.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
    }
}
