using AccesoCSBD;
using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCongreso {
    public partial class Procedimiento : Form {
        public Procedimiento() {
            InitializeComponent();
        }

        OleDbConnection cnOracle;
        OleDbParameter par,par1;
        OleDbCommand procAlm;
        String institucion,institución2;
        Comunes comunes = new Comunes();


    

        GestorBD.GestorBD GestorBD;
        DataSet dsOrganización = new DataSet();
        DataSet dsAux = new DataSet();
        //private const int OK = 1;


        String cadSql, auxIn;

        private void procfun_Click(object sender, EventArgs e) {
            
            Procedimiento pro = new Procedimiento();
            pro.Show();

            cnOracle = new OleDbConnection("Provider= MSDAORA; Data source=oracle;" + "User id=bd03; Password=marbar");
            cnOracle.Open();
            procAlm = new OleDbCommand();
            procAlm.Connection = cnOracle;

            //Especificar elLlamado al procedimiento 

            procAlm.CommandText = "masPatrocinios";
            procAlm.CommandType = CommandType.StoredProcedure;
            institucion =  comboBox1.Text ;
            institución2 =  comboBox2.Text;

            
            par = new OleDbParameter("nom1", institucion);
            par1 = new OleDbParameter("nom2", institución2);
            procAlm.Parameters.Add(par);
            procAlm.Parameters.Add(par1);

            //Especificar los parametros de salida 

            //falta checar el codigo de aqui abajoooooooo
            par = new OleDbParameter("result", OleDbType.Char, 10, ParameterDirection.Output, false, 10, 0, "res", DataRowVersion.Current, 0);
            procAlm.Parameters.Add(par);
            try {
                procAlm.ExecuteNonQuery();
                
                // recuperar parametros de salida
                String res = Convert.ToString(procAlm.Parameters["result"].Value);
                MessageBox.Show("Mayor número de congresos por: " + res);
            }
            catch (OleDbException err) {
                MessageBox.Show(err.Message);
            }
            cnOracle.Close();
        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void Procedimiento_Load(object sender, EventArgs e) {
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd03", "marbar", "oracle");

            //2 Muesta en el grid los datos de los alumnos

            cadSql = "select * from tOrganización";
            GestorBD.consBD(cadSql, "tOrganización", dsOrganización);
            dsGeneral.DataSource = dsOrganización.Tables["tOrganización"];
            comunes.cargaCombo(comboBox1, dsOrganización, "tOrganización", "NomOrg");
            comunes.cargaCombo(comboBox2, dsOrganización, "tOrganización", "NomOrg");
        }

    }
}
