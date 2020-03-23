using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {
        public ModeloCategoria()
        {
            this.cat_cod = 0;
            this.cat_nome = "";
        }

        public ModeloCategoria(int catcod, String nome)
        {
            this.cat_cod = catcod;
            this.cat_nome = nome;
        }

        private int cat_cod;

        public int Cat_cod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value;}

        }

        private String cat_nome;

        public String Cat_nome
        {
            get { return this.cat_nome; }
            set { this.cat_nome = value; }
        }
    }
}
