using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSubCategoria
    {
        public ModeloSubCategoria()
        {
            this.cat_cod = 0;
            this.scat_cod = 0;
            this.scat_nome = "";
        }

        public ModeloSubCategoria(int scatcod, int catcod, String snome )
        {
            this.cat_cod = catcod;
            this.scat_cod = scatcod;
            this.scat_nome = snome;
        }


        private int scat_cod;
        public int Scat_cod
        {
            get { return this.scat_cod; }
            set { this.scat_cod = value; }

        }

        private int cat_cod;
        public int Cat_cod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }

        }

        private String scat_nome;
        public String Scat_nome
        {
            get { return this.scat_nome; }
            set { this.scat_nome = value; }
        }
    }
}
