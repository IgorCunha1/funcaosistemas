using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FI.AtividadeEntrevista.DML;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoCliente
    {
        /// <summary>
        /// Inclui um novo cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        public long Incluir(DML.Cliente cliente)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            return cli.Incluir(cliente);
        }

        public long IncluirBeneficiario(DML.Beneficiario beneficiario)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            return cli.IncluirBeneficiario(beneficiario);
        }

        /// <summary>
        /// Altera um cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        public void Alterar(DML.Cliente cliente)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            cli.Alterar(cliente);
        }

        public void AlterarBeneficiario(Beneficiario beneficiario)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            cli.AlterarBeneficiario(beneficiario);
        }

        /// <summary>
        /// Consulta o cliente pelo id
        /// </summary>
        /// <param name="id">id do cliente</param>
        /// <returns></returns>
        public DML.Cliente Consultar(long id)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            return cli.Consultar(id);
        }

        public Beneficiario ConsultarBeneficiario(long id)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            return cli.ConsultarBeneficiario(id);
        }

        /// <summary>
        /// Excluir o cliente pelo id
        /// </summary>
        /// <param name="id">id do cliente</param>
        /// <returns></returns>
        public void Excluir(long id)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            cli.Excluir(id);
        }
        public void ExcluirBeneficiario(long id)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            cli.ExcluirBeneficiario(id);
        }

        /// <summary>
        /// Lista os clientes
        /// </summary>
        public List<DML.Cliente> Listar()
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            return cli.Listar();
        }

        /// <summary>
        /// Lista os clientes
        /// </summary>
        public List<DML.Cliente> Pesquisa(int iniciarEm, int quantidade, string campoOrdenacao, bool crescente, out int qtd)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            return cli.Pesquisa(iniciarEm,  quantidade, campoOrdenacao, crescente, out qtd);
        }

        public List<DML.Beneficiario> PesquisaBeneficiario(int iniciarEm, int quantidade, string campoOrdenacao, bool crescente, long idCliente, out int qtd)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            return cli.PesquisaBeneficiario(iniciarEm, quantidade, campoOrdenacao, crescente, idCliente, out qtd);
        }


        /// <summary>
        /// VerificaExistencia
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        public bool VerificarExistencia(string CPF)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            return cli.VerificarExistencia(CPF);
        }

       
    }
}
