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
    class BLLCategoria
    {
        private DALConexao conexao;

        public BLLCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo)
        {
            if(modelo.Cat_nome.Trim().Length == 0)
            {
                throw new Exception("O nomde da Categoria é Obrigatório!");

            }

            modelo.Cat_nome = modelo.Cat_nome.ToUpper();

            DALCategoria DAOObj = new DALCategoria(conexao);
            DAOObj.Incluir(modelo);
        }

        public void Alterar(ModeloCategoria modelo)
        {
            if(modelo.Cat_cod <= 0)
            {
                throw new Exception("O código da Categoria é Obrigatório!");
            }
            if (modelo.Cat_nome.Trim().Length == 0)
            {
                throw new Exception("O nomde da Categoria é Obrigatório!");

            }

            modelo.Cat_nome = modelo.Cat_nome.ToUpper();

            DALCategoria DAOObj = new DALCategoria(conexao);
            DAOObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCategoria DAOObj = new DALCategoria(conexao);
            DAOObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCategoria DAOObj = new DALCategoria(conexao);
            return DAOObj.Localizar(valor);
        }

        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            DALCategoria DAOObj = new DALCategoria(conexao);
            return DAOObj.CarregaModeloCategoria(codigo);
        }

    }
}
