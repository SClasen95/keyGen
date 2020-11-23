using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyGen {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int i = (int)this.numericUpDown1.Value;
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();
            
           while (i>0) {
                queryBuilder.setQuery("INSERT INTO claves (clave,estado) VALUES (@clave,@estado)");
                queryBuilder.addParam("@clave", KeyGen.generarKey());
                queryBuilder.addParam("@estado", "Disponible");
                DBConnection.getInstance().abm(queryBuilder);
                i--;
            }

        }
    }
}
