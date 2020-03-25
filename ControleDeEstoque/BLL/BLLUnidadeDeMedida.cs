using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLUnidadeDeMedida
    {
        private DALConexao conexao;

        public BLLUnidadeDeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.Umednome.Trim().Length == 0)
            {
                throw new Exception("O nome da Unidade de Medida é Obrigatório!");

            }
            
            modelo.Umednome = modelo.Umednome.ToUpper();

            DALUnidadeDeMedida DAOObj = new DALUnidadeDeMedida(conexao);
            DAOObj.Incluir(modelo);
        }

        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.Umednome.Trim().Length == 0)
            {
                throw new Exception("O nome da Unidade de Medida é Obrigatório!");

            }
            if (modelo.Umedcod <= 0)
            {
                throw new Exception("O código da Unidade de Medida é Obrigatório!");
            }
            
            modelo.Umednome = modelo.Umednome.ToUpper();

            DALUnidadeDeMedida DAOObj = new DALUnidadeDeMedida(conexao);
            DAOObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALUnidadeDeMedida DAOObj = new DALUnidadeDeMedida(conexao);
            DAOObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALUnidadeDeMedida DAOObj = new DALUnidadeDeMedida(conexao);
            return DAOObj.Localizar(valor);
        }

        public int VerificaUnidadeDeMedida(String valor)
        {
            DALUnidadeDeMedida DAOObj = new DALUnidadeDeMedida(conexao);
            return DAOObj.VerificaUnidadeDeMedida(valor);
        }

        public ModeloUnidadeDeMedida CarregaModeloUnidadeDeMedida(int codigo)
        {
            DALUnidadeDeMedida DAOObj = new DALUnidadeDeMedida(conexao);
            return DAOObj.CarregaModeloUnidadeDeMedida(codigo);
        }
    }
}
