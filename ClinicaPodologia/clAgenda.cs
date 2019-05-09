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
    public class ClassAgenda
    {

        public int ID_Agenda { set; get; }
        public DateTime Hora { set; get; }
        public DateTime Dia { set; get; }
        public int ID_Servico { set; get; }
        public int ID_Cliente { set; get; }
        public int TempoConsulta { get; set; }
        public DateTime HoraInicio { set; get; }
        public DateTime HoraFim { set; get; }
        public int ID_Profissional { set; get; }





        conectaBD BD = new conectaBD();

        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO Agendamento (Hora, Dia, ID_Servico, ID_Profissional) " +
                                        " values ('{0}','{1}','{2}','{3}')", Hora.ToShortTimeString(), Dia.ToShortDateString(), ID_Servico, ID_Profissional) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {

                    try
                    {
                        BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO Realiza (ID_Cliente, ID_Agenda, TempoConsulta) " +
                                        " values ('{0}','{1}','{2}')", ID_Cliente, id, TempoConsulta);

                        BD.ExecutaComando();


                        MessageBox.Show("Agendamento com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Agendamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;

        }

        public void Atualiza()
        {
            try
            {
                int exOK = 0;

                BD._sql = String.Format("UPDATE Agendamento SET Hora = '{0}', Dia = '{1}', ID_Profissional = '{2}', ID_Cliente = '{3}' " +
                    "  WHERE ID_Agenta = '{4}'", Hora, Dia, ID_Servico, ID_Cliente, ID_Agenda);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao atualizar Notas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BD._sql = String.Format("UPDATE Realiza SET ID_Cliente = '{0}', TempoConsulta = '{1}' " +
                    "  WHERE ID_Agenta = '{2}'", ID_Cliente, TempoConsulta, ID_Agenda);
                    MessageBox.Show("Notas atualizada com sucesso!", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public DataTable PesquisaPorNome(String nome_pesquisa)
        {
            try
            {


                BD._sql = "SELECT N.Cod_turma, T.Turma, N.Cod_aluno, A.Nome, N.Nota1 as 'Nota 1', N.Nota2 as 'Nota 2', N.Media as 'Média', N.Faltas, T.Inicio_turma, N.Cod_notas, N.Bimestre, N.Ano " +
                          "FROM Aluno A, Turma T, Notas N " +
                          "WHERE A.Cod_aluno = N.Cod_aluno " +
                          "AND N.Cod_turma = T.Cod_turma " +
                          "AND A.Nome LIKE  '%" + nome_pesquisa + "%'";


                return BD.ExecutaSelect();


            }
            catch (Exception)
            {

            }

            return null;

        }

        public void Apagar(int id_apagar)
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM Realiza WHERE ID_Agenda = '{0}'", id_apagar);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar Realiza", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        int exOK2 = 0;
                        BD._sql = String.Format("DELETE FROM Agendamento WHERE ID_Agenda = '{0}'", id_apagar);

                        exOK2 = BD.ExecutaComando(false);

                        if (exOK2 < 0)
                        {
                            MessageBox.Show("Erro ao deletar Agendamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cliente deletado da agenda com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        public DataTable PesquisaPorData(String data_pesquisa, int cod_profissional)
        {
            try
            {


                BD._sql = " SELECT A.Hora, ISNULL(C.Nome,'') AS Cliente, C.ID_Cliente, A.Dia, Pf.ID_Profissional, P.ID_Prontuario, P.Prontuario, A.ID_Agenda, R.TempoConsulta AS 'Tempo da Consulta', S.ID_Servico, CR.ID_ContaRecebe, S.Valor AS 'Valor a Pagar', CR.ValorRecebe AS 'Valor Recebido' " +
                             "FROM Agendamento A " +
                             "INNER JOIN Realiza R ON R.ID_Agenda = A.ID_Agenda " +
                             "INNER JOIN Cliente C ON C.ID_Cliente = R.ID_Cliente " +
                             "LEFT JOIN Prontuario P ON C.ID_Cliente = P.ID_Cliente " +
                             "INNER JOIN Servico S ON S.ID_Servico = A.ID_Servico " +
                             "LEFT JOIN Profissional Pf ON Pf.ID_Profissional = A.ID_Profissional " +
                             "LEFT JOIN ContaRecebe CR ON A.ID_Agenda = CR.ID_Agenda " +
                             "WHERE A.Dia = '" + data_pesquisa + "' AND Pf.ID_Profissional = " + cod_profissional + " " +
                             "UNION ALL " +
                             "SELECT I.Hora, '' AS Cliente, NULL AS ID_Cliente, NULL AS Dia, NULL AS ID_Profissional, NULL AS ID_Prontuario, NULL AS Prontuario, NULL AS ID_Agenda, NULL AS TempoConsulta, NULL AS ID_Servico, NULL AS ID_ContaRecebe, NULL AS Valor, NULL AS ValorRecebe " +
                             "FROM INTERVALO I " +
                             "WHERE Hora NOT IN (SELECT Hora FROM Agendamento A " +
                                                  "INNER JOIN Realiza R ON R.ID_Agenda = A.ID_Agenda " +
                                                  "INNER JOIN Cliente C ON C.ID_Cliente = R.ID_Cliente " +
                                                  "LEFT JOIN Prontuario P ON C.ID_Cliente = P.ID_Cliente " +
                                                  "INNER JOIN Servico S ON S.ID_Servico = A.ID_Servico " +
                                                  "LEFT JOIN Profissional Pf ON Pf.ID_Profissional = A.ID_Profissional " +
                                                  "LEFT JOIN ContaRecebe CR ON A.ID_Agenda = CR.ID_Agenda " +
                                                  "WHERE A.Dia = '" + data_pesquisa + "' AND Pf.ID_Profissional = " + cod_profissional + " ) " +
                             "AND Hora BETWEEN (SELECT AtendimentoInicio FROM Profissional WHERE ID_Profissional = " + cod_profissional + ") " +
                              "AND (SELECT AtendimentoFim FROM Profissional WHERE ID_Profissional = " + cod_profissional + ") " +
                              "ORDER BY HORA ";


                return BD.ExecutaSelect();


            }
            catch (Exception)
            {

            }

            return null;

        }

        public DataTable VerificaAgenda()
        {

            try
            {



                BD._sql = "SELECT * FROM Agendamento A " +
                    "INNER JOIN Servico S ON A.ID_Servico = S.ID_Servico " +
                    "INNER JOIN Atende Ad ON S.ID_Servico = Ad.ID_Servico " +
                    "INNER JOIN Profissional P ON P.ID_Profissional = Ad.ID_Profissional " +
                    "WHERE dia = '" + Dia + "' AND Hora BETWEEN '" + HoraInicio + "' AND '" + HoraFim + "'  AND P.ID_Profissional = '" + ID_Profissional + "' ";


                return BD.ExecutaSelect();





            }
            catch (Exception)
            {

            }

            return null;

        }

        public DataTable VerificaTodasAgendas()
        {
            try
            {


                BD._sql = "SELECT A.Dia, A.Hora, C.Nome AS 'Cliente', Pf.Nome AS 'Profissional' " +
                    "FROM Agendamento A " +
                    "INNER JOIN Realiza R ON A.ID_Agenda = R.ID_Agenda " +
                    "INNER JOIN Cliente C ON R.ID_Cliente = C.ID_Cliente " +
                    "INNER JOIN Servico S ON S.ID_Servico = A.ID_Servico " +
                    "INNER JOIN Atende Ad ON Ad.ID_Servico = S.ID_Servico " +
                    "INNER JOIN Profissional Pf ON Pf.ID_Profissional = Ad.ID_Profissional " +
                    "WHERE dia = '" + Dia + "'  AND C.ID_CLIENTE = " + ID_Cliente + " AND Hora BETWEEN '" + HoraInicio + "' AND '" + HoraFim + "'";


                return BD.ExecutaSelect();


            }
            catch (Exception)
            {

            }

            return null;

        }




    }
}

