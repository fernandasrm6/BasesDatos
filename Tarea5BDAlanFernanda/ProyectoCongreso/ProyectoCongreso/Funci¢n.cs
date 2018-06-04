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
    public partial class Función : Form {
        public Función() {
            InitializeComponent();
        }
        OleDbConnection cnOracle;
        OleDbParameter par;
        OleDbCommand procAlm;
        String institucion;
        Comunes comunes = new Comunes();

        private void Función_Load(object sender, EventArgs e) {
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd03", "marbar", "oracle");

            //2 Muesta en el grid los datos de los alumnos

            cadSql = "select * from tOrganización";
            GestorBD.consBD(cadSql, "Organización", dsOrganización);
            dsGeneral.DataSource = dsOrganización.Tables["Organización"];
            comunes.cargaCombo(comboBox1, dsOrganización, "Organización", "NomOrg");
        }
        GestorBD.GestorBD GestorBD;
        DataSet dsOrganización = new DataSet();
        DataSet dsAux = new DataSet();
        //private const int OK = 1;

       
        String cadSql, auxIn;

        private void button1_Click(object sender, EventArgs e) {
            //1- Abrir la conexión a la BD.
            cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle;" +
              "User ID=bd03;Password=marbar");
            cnOracle.Open();
            procAlm = new OleDbCommand();
            procAlm.Connection = cnOracle;

            //2- Especificar el llamado a la función.
            procAlm.CommandText = "cantidadDeCongresos";
            procAlm.CommandType = CommandType.StoredProcedure;

            //3- Especificar los parámetros:
            // a) Nota: primero hay que definir el tipo de valor que regresará la función.
            par = new OleDbParameter("RETURN_VALUE", OleDbType.Integer,
              4, ParameterDirection.ReturnValue, false, 4, 0, "NomAl", DataRowVersion.Current, 0);
            procAlm.Parameters.Add(par);

            // b) luego hay que definir los parámetros de entrada (uno en este caso).
            String nomInst = "" + comboBox1.Text+ "";
            par = new OleDbParameter("nombre", nomInst);
            procAlm.Parameters.Add(par);

            //4- Ejecutar el procedimiento (en general: el subprograma).
            try {
                procAlm.ExecuteNonQuery();

                //5- Recuperar el valor regresado por la función.
                int cant = Convert.ToInt16(procAlm.Parameters["RETURN_VALUE"].Value);
                MessageBox.Show("Cantidad de congresos de" + nomInst + ": " + cant);
            }
            catch (OleDbException err) {
                MessageBox.Show(err.Message);
            }

            //6- Cerrar la conexión a la BD.
            cnOracle.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            
        }
    }
}
