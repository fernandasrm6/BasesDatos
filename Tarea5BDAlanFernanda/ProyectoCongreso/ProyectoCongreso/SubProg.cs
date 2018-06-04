using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCongreso {
    public partial class Subprogramas : Form {
        public Subprogramas() {
            InitializeComponent();
        }
        // Variable para la conexión 
        OleDbConnection cnOracle;
        OleDbParameter par;
        OleDbCommand procAlm;
        String institucion;
        //        e-- Define una función que reciba como entrada el nombre de una empresa/institución y entregue como salida la cantidad de congresos que ha patrocinado. Utilicela en el siguiente inciso 

        //create or replace 
        //function cantidadDeCongresos (con char) return integer is 
        //  cantCon integer;
        //begin
        //  select count(*) into cantCOn 
        //  from TOrganización org, TCongreso c, TOrganizador o
        //  where org.IdOrg=o.IdOrg and c.IdCon=o.IdOrg and org.nomOrg=con;  
        //  return cantCon;

        private void button2_Click(object sender, EventArgs e) {

            Función fu = new Función();
            fu.Show();


        }

        private void button1_Click(object sender, EventArgs e) {
            Procedimiento pro = new Procedimiento();
            pro.Show();

        }
    }
}

