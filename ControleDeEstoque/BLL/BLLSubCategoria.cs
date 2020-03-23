using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLSubCategoria
    {
        private DALConexao conexao;

        public BLLSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            if (modelo.Scat_nome.Trim().Length == 0)
            {
                throw new Exception("O nomde da Sub-Categoria é Obrigatório!");

            }
            if(modelo.Cat_cod <= 0)
            {
                throw new Exception("O código da Categoria é Obrigatório!");
            }

            modelo.Scat_nome = modelo.Scat_nome.ToUpper();

            DALSubCategoria DAOObj = new DALSubCategoria(conexao);
            DAOObj.Incluir(modelo);
        }

        public void Alterar(ModeloSubCategoria modelo)
        {
            if (modelo.Scat_nome.Trim().Length == 0)
            {
                throw new Exception("O nomde da Sub-Categoria é Obrigatório!");

            }
            if (modelo.Cat_cod <= 0)
            {
                throw new Exception("O código da Categoria é Obrigatório!");
            }
            if (modelo.Scat_cod <= 0)
            {
                throw new Exception("O código da Sub-Categoria é Obrigatório!");
            }

            modelo.Scat_nome = modelo.Scat_nome.ToUpper();

            DALSubCategoria DAOObj = new DALSubCategoria(conexao);
            DAOObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALSubCategoria DAOObj = new DALSubCategoria(conexao);
            DAOObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALSubCategoria DAOObj = new DALSubCategoria(conexao);
            return DAOObj.Localizar(valor);
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            DALSubCategoria DAOObj = new DALSubCategoria(conexao);
            return DAOObj.CarregaModeloSubCategoria(codigo);
        }
    }
}
