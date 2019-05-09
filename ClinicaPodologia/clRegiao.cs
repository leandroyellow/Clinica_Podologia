using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace ClinicaPodologia
{
    public class ClassRegiao
    {
        public int Id_UF { set; get; }
        public string Nome_estado { set; get; }
        public string Nome_municipio { set; get; }
        public string UF { set; get; }
        public string Regiao { set; get; }

        conectaBD BD = new conectaBD();


        /*
        public DataTable PesquisaPorID(String IdUF)
        {
            try
            {
                BD._sql = "SELECT C.id_cliente as 'Id', C.nome as 'Nome', C.cpf as 'CPF', " +
                                 " C.data_nascimento as 'Nascimento', C.email as 'Email', L.UF, C.ID_UF" +
                "  FROM CLIENTE C " +
                "       LEFT JOIN LOCAL_UF L ON C.ID_UF = L.ID_UF" +
                "  WHERE C.nome LIKE '%" + nome_pesquisa + "%'";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }
        */



        public DataTable lista_uf()
        {
            try
            {
                BD._sql = "SELECT DISTINCT Id_uf, UF FROM Regiao  order by UF";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataTable lista_cidade(String cidade)
        {
            try
            {
                BD._sql = "SELECT  UF,  Nome_municipio FROM Regiao  " +
                    "WHERE UF = '" + cidade +

                    "  '  order by Nome_municipio";

                return BD.ExecutaSelect();

            }
            catch (Exception)
            {

            }
            return null;
        }

        public DataTable lista_cidade_todas()
        {
            try
            {
                BD._sql = "SELECT DISTINCT UF, Nome_municipio FROM Regiao  order by Nome_municipio";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }
            return null;
        }

    }
}
