﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {
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
