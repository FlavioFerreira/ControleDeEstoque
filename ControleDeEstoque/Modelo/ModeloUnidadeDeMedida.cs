using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUnidadeDeMedida
    {
        public ModeloUnidadeDeMedida()
        {
            this.Umedcod = 0;
            this.Umednome = "";
        }

        public ModeloUnidadeDeMedida(int cod, String nome)
        {
            this.Umedcod = cod;
            this.Umednome = nome;
        }

        private int umed_cod;

        public int Umedcod
        {
            get { return this.umed_cod; }

            set { this.umed_cod = value; }
        }

        private String umed_nome;

        public String Umednome
        {
            get { return this.umed_nome; }

            set { this.umed_nome = value; }
        }


    }
}
