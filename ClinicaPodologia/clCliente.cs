using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Imaging;


namespace ClinicaPodologia
{
    public class ClassCliente
    {

        public int ID_Cliente { set; get; }
        public string Nome { set; get; }
        public string Sexo { set; get; }
        public string CEP { set; get; }
        public string Numero { set; get; }
        public string Logradouro { set; get; }
        public string Bairro { set; get; }
        public string Cidade { set; get; }
        public string UF { set; get; }
        public string Celular { set; get; }
        public string Telefone { set; get; }
        public DateTime Nascimento { set; get; }
        public string Email { set; get; }
        public string Profissao { set; get; }
        public string Etnia { set; get; }
        public string PraticaEsporte { set; get; }
        public string Frequencia { set; get; }
        public string NumeroCalcado { set; get; }
        public string MaterialCalcado { set; get; }
        public string TipoCalcado { set; get; }
        public string DestroCanhoto { set; get; }
        public string FormatoUnha { set; get; }
        public int Onicoatrofia { set; get; }
        public int Onicocriptose { set; get; }
        public int Onicorrexe { set; get; }
        public int Granuloma { set; get; }
        public int Onicogrifose { set; get; }
        public int AlteracaoCor { set; get; }
        public int Onicolise { set; get; }
        public int Onicofose { set; get; }
        public int Onicomicose { set; get; }
        public int ExostoseUngueal { set; get; }
        public int PsoriaseUnha { set; get; }
        public int Ungueal { set; get; }
        public string AlteracoesLaminas { set; get; }
        public int HaluxVagusD { set; get; }
        public int HaluxVagusE { set; get; }
        public int HaluxRigidusD { set; get; }
        public int HaluxRigidusE { set; get; }
        public int DedosGarrasMartelo { set; get; }
        public int EsporaoCalcaneo { set; get; }
        public int Perodactilia { set; get; }
        public int PeCavo { set; get; }
        public int PePlano { set; get; }
        public string AlteracaoOrtopedica { set; get; }
        public string CirurgiaMMII { set; get; }
        public string TratamentoMedicamento { set; get; }
        public string Alergico { set; get; }
        public string AlergicoSim { set; get; }
        public string PatologiaAdquirida { set; get; }
        public string Diabete { set; get; }
        public string Etilista { set; get; }
        public string Tabagismo { set; get; }
        public string DST { set; get; }
        public string FamiliaDiabete { set; get; }
        public string AlteracaoPressao { set; get; }
        public string GravidezLactacao { set; get; }
        public string Cardiopatia { set; get; }
        public string OutrasPatologias { set; get; }
        public int Bromidrose { set; get; }
        public int Neuropatica { set; get; }
        public int Anidrose { set; get; }
        public int Hiperhidrose { set; get; }
        public int Disidrose { set; get; }
        public int Isquemica { set; get; }
        public int Frieira { set; get; }
        public int PsoriasePele { set; get; }
        public int TineaPedis { set; get; }
        public int MalPerfurante { set; get; }
        public int Fissuras { set; get; }
        public string AlteracaoPele { set; get; }
        public string Monofilamento { set; get; }
        public string Diapasao { set; get; }
        public string Digitopressao { set; get; }
        public string Pulsos { set; get; }
        public int NormalD { set; get; }
        public int PalidoD { set; get; }
        public int CianotipoD { set; get; }
        public int NormalE { set; get; }
        public int PalidoE { set; get; }
        public int CianotipoE { set; get; }
        //public string NomePeDireito { set; get; }
        //public string NomePeEsquerdo { set; get; }
        //public byte[] PeDireito { set; get; }
        //public byte[] PeEsquerdo { set; get; }





        private int cod;
        


        conectaBD BD = new conectaBD();



        public int Salvar()
        {
            int id = 0;
            try
            {
                //BD.setParameter

                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO Cliente (Nome, Sexo, CEP, Numero, Logradouro, Bairro, " +
                                                                  "Cidade, UF, Celular, Telefone, Nascimento, Email, Profissao, Etnia, " +
                                                                  "PraticaEsporte, Frequencia, NumeroCalcado, MaterialCalcado, TipoCalcado, " +
                                                                  "DestroCanhoto, FormatoUnha, Onicoatrofia, Onicocriptose, Onicorrexe, " +
                                                                  "Granuloma, Onicogrifose, AlteracaoCor, Onicolise, Onicofose, Onicomicose, " +
                                                                  "ExostoseUngueal, PsoriaseUnha, Ungueal, AlteracoesLaminas, HaluxVagusD, " +
                                                                  "HaluxVagusE, HaluxRigidusD, HaluxRigidusE, DedosGarrasMartelo, EsporaoCalcaneo, " +
                                                                  "Perodactilia, PeCavo, PePlano, AlteracaoOrtopedica, CirurgiaMMII, TratamentoMedicamento, " +
                                                                  "Alergico, AlergicoSim, PatologiaAdquirida, Diabete, Etilista, Tabagismo, DST, " +
                                                                  "FamiliaDiabete, AlteracaoPressao, GravidezLactacao, Cardiopatia, OutrasPatologias, " +
                                                                  "Bromidrose, Neuropatica, Anidrose, Hiperhidrose, Disidrose, Isquemica, Frieira, " +
                                                                  "PsoriasePele, TineaPedis, MalPerfurante, Fissuras, AlteracaoPele, Monofilamento, " +
                                                                  "Diapasao, Digitopressao, Pulsos, NormalD, PalidoD, CianotipoD, NormalE, PalidoE, " +
                                                                  "CianotipoE) " +
                                        " values ('{0}','{1}','{2}','{3}','{4}','{5}'," +
                                                 "'{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}'," +
                                                 "'{14}','{15}','{16}','{17}','{18}'," +
                                                 "'{19}','{20}','{21}','{22}','{23}'," +
                                                 "'{24}','{25}','{26}','{27}','{28}','{29}'," +
                                                 "'{30}','{31}','{32}','{33}','{34}'," +
                                                 "'{35}','{36}','{37}','{38}','{39}'," +
                                                 "'{40}','{41}','{42}','{43}','{44}','{45}'," +
                                                 "'{46}','{47}','{48}','{49}','{50}','{51}','{52}'," +
                                                 "'{53}','{54}','{55}','{56}','{57}'," +
                                                 "'{58}','{59}','{60}','{61}','{62}','{63}','{64}'," +
                                                 "'{65}','{66}','{67}','{68}','{69}','{70}'," +
                                                 "'{71}','{72}','{73}','{74}','{75}','{76}','{77}','{78}'," +
                                                 "'{79}' )", 
                                                                   Nome, Sexo, CEP, Numero, Logradouro, Bairro, 
                                                                   Cidade, UF, Celular, Telefone, Nascimento.ToShortDateString(), Email, Profissao, Etnia, 
                                                                   PraticaEsporte, Frequencia, NumeroCalcado, MaterialCalcado, TipoCalcado, 
                                                                   DestroCanhoto, FormatoUnha, Onicoatrofia, Onicocriptose, Onicorrexe,
                                                                   Granuloma, Onicogrifose, AlteracaoCor, Onicolise, Onicofose, Onicomicose, 
                                                                   ExostoseUngueal, PsoriaseUnha, Ungueal, AlteracoesLaminas, HaluxVagusD, 
                                                                   HaluxVagusE, HaluxRigidusD, HaluxRigidusE, DedosGarrasMartelo, EsporaoCalcaneo, 
                                                                   Perodactilia, PeCavo, PePlano, AlteracaoOrtopedica, CirurgiaMMII, TratamentoMedicamento, 
                                                                   Alergico, AlergicoSim, PatologiaAdquirida, Diabete, Etilista, Tabagismo, DST, 
                                                                   FamiliaDiabete, AlteracaoPressao, GravidezLactacao, Cardiopatia, OutrasPatologias, 
                                                                   Bromidrose, Neuropatica, Anidrose, Hiperhidrose, Disidrose, Isquemica, Frieira, 
                                                                   PsoriasePele, TineaPedis, MalPerfurante, Fissuras, AlteracaoPele, Monofilamento, 
                                                                   Diapasao, Digitopressao, Pulsos, NormalD, PalidoD, CianotipoD, NormalE, PalidoE, 
                                                                   CianotipoE) + "; SELECT SCOPE_IDENTITY();";


                
                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    cod = id;

                    MessageBox.Show(String.Format("Cliente cadastrado com sucesso!\nID do Cliente é {0}", cod));

                    
                    

                    //, "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                BD._sql = String.Format("UPDATE Cliente SET Nome = '{0}', Sexo = '{1}', CEP = '{2}', Numero = '{3}', Logradouro = '{4}', " +
                                        "Bairro = '{5}', Cidade = '{6}', UF = '{7}', Celular = '{8}', Telefone = '{9}', Nascimento = '{10}', " +
                                        "Email = '{11}', Profissao = '{12}', Etnia = '{13}', PraticaEsporte = '{14}', Frequencia = '{15}', " +
                                        "NumeroCalcado = '{16}', MaterialCalcado = '{17}', TipoCalcado = '{18}', DestroCanhoto = '{19}', " +
                                        "FormatoUnha = '{20}', Onicoatrofia = '{21}', Onicocriptose = '{22}', Onicorrexe = '{23}', Granuloma = '{24}', " +
                                        "Onicogrifose = '{25}', AlteracaoCor = '{26}', Onicolise = '{27}', Onicofose = '{28}', Onicomicose = '{29}', " +
                                        "ExostoseUngueal = '{30}', PsoriaseUnha = '{31}', Ungueal = '{32}', AlteracoesLaminas = '{33}', HaluxVagusD = '{34}', " +
                                        "HaluxVagusE = '{35}', HaluxRigidusD = '{36}', HaluxRigidusE = '{37}', DedosGarrasMartelo = '{38}', " +
                                        "EsporaoCalcaneo = '{39}', Perodactilia = '{40}', PeCavo = '{41}', PePlano = '{42}', AlteracaoOrtopedica = '{43}', " +
                                        "CirurgiaMMII = '{44}', TratamentoMedicamento = '{45}', Alergico = '{46}', AlergicoSim = '{47}', " +
                                        "PatologiaAdquirida = '{48}', Diabete = '{49}', Etilista = '{50}', Tabagismo = '{51}', DST = '{52}', " +
                                        "FamiliaDiabete = '{53}', AlteracaoPressao = '{54}', GravidezLactacao = '{55}', Cardiopatia = '{56}', " +
                                        "OutrasPatologias = '{57}', Bromidrose = '{58}', Neuropatica = '{59}', Anidrose = '{60}', Hiperhidrose = '{61}', " +
                                        "Disidrose = '{62}', Isquemica = '{63}', Frieira = '{64}', PsoriasePele = '{65}', TineaPedis = '{66}', " +
                                        "MalPerfurante = '{67}', Fissuras = '{68}', AlteracaoPele = '{69}', Monofilamento = '{70}', Diapasao = '{71}', " +
                                        "Digitopressao = '{72}', Pulsos = '{73}', NormalD = '{74}', PalidoD = '{75}', CianotipoD = '{76}', NormalE = '{77}', " +
                                        "PalidoE = '{78}', CianotipoE = '{79}'" +
                    "  WHERE ID_Cliente = '{80}'", Nome, Sexo, CEP, Numero, Logradouro, Bairro, Cidade, UF, Celular, Telefone, Nascimento,
                                                   Email, Profissao, Etnia, PraticaEsporte, Frequencia,
                                                   NumeroCalcado, MaterialCalcado, TipoCalcado, DestroCanhoto,
                                                   FormatoUnha, Onicoatrofia, Onicocriptose, Onicorrexe, Granuloma,
                                                   Onicogrifose, AlteracaoCor, Onicolise, Onicofose, Onicomicose,
                                                   ExostoseUngueal, PsoriaseUnha, Ungueal, AlteracoesLaminas, HaluxVagusD,
                                                   HaluxVagusE, HaluxRigidusD, HaluxRigidusE, DedosGarrasMartelo,
                                                   EsporaoCalcaneo, Perodactilia, PeCavo, PePlano, AlteracaoOrtopedica,
                                                   CirurgiaMMII, TratamentoMedicamento, Alergico, AlergicoSim,
                                                   PatologiaAdquirida, Diabete, Etilista, Tabagismo, DST,
                                                   FamiliaDiabete, AlteracaoPressao, GravidezLactacao, Cardiopatia,
                                                   OutrasPatologias, Bromidrose, Neuropatica, Anidrose, Hiperhidrose,
                                                   Disidrose, Isquemica, Frieira, PsoriasePele, TineaPedis,
                                                   MalPerfurante, Fissuras, AlteracaoPele, Monofilamento, Diapasao, 
                                                   Digitopressao, Pulsos, NormalD, PalidoD, CianotipoD, NormalE, 
                                                   PalidoE, CianotipoE, ID_Cliente);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao atualizar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cliente atualizado com sucesso!", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


                BD._sql = "SELECT C.ID_Cliente, Nome as 'Nome', C.Sexo as 'Sexo', C.CEP as 'CEP', C.Numero as 'Número', C.Logradouro as 'Endereço', " +
                                 "C.Bairro as 'Bairro', C.Cidade, C.UF, C.Celular, C.Telefone, " +
                                 "C.Nascimento, C.Email, C.Profissao as 'Profissão', C.Etnia, C.PraticaEsporte as 'Pratica Esporte', " +
                                 "C.Frequencia as 'Frequência', C.NumeroCalcado as 'Número do Calçado', C.MaterialCalcado as 'Material do Calçado', C.TipoCalcado as 'Tipo de Calçado', C.DestroCanhoto as 'Destro ou Canhoto', " +
                                 "C.FormatoUnha as 'Formato da Unha', C.Onicoatrofia, C.Onicocriptose, C.Onicorrexe, C.Granuloma, " +
                                 "C.Onicogrifose, C.AlteracaoCor, C.Onicolise, C.Onicofose, C.Onicomicose, " +
                                 "C.ExostoseUngueal, C.PsoriaseUnha, C.Ungueal, C.AlteracoesLaminas, C.HaluxVagusD, " +
                                 "C.HaluxVagusE, C.HaluxRigidusD, C.HaluxRigidusE, C.DedosGarrasMartelo, C.EsporaoCalcaneo, " +
                                 "C.Perodactilia, C.PeCavo, C.PePlano, C.AlteracaoOrtopedica, C.CirurgiaMMII, " +
                                 "C.TratamentoMedicamento, C.Alergico, C.AlergicoSim, C.PatologiaAdquirida, C.Diabete, " +
                                 "C.Etilista, C.Tabagismo, C.DST, C.FamiliaDiabete, C.AlteracaoPressao, " +
                                 "C.GravidezLactacao, C.Cardiopatia, C.OutrasPatologias, C.Bromidrose, C.Neuropatica, " +
                                 "C.Anidrose, C.Hiperhidrose, C.Disidrose, C.Isquemica, C.Frieira, " +
                                 "C.PsoriasePele, C.TineaPedis, C.MalPerfurante, C.Fissuras, C.AlteracaoPele, " +
                                 "C.Monofilamento, C.Diapasao, C.Digitopressao, C.Pulsos, C.NormalD, " +
                                 "C.PalidoD, C.CianotipoD, C.NormalE, C.PalidoE, C.CianotipoE, " +
                                 "P.ID_Prontuario, P.Prontuario " +
                                 "FROM Cliente C " +
                                 "LEFT JOIN Prontuario P ON C.ID_Cliente = P.ID_Cliente " +
                                 "WHERE Nome LIKE '%" + nome_pesquisa + "%' ORDER BY Nome";

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
                BD._sql = String.Format("DELETE FROM Cliente WHERE ID_Cliente = '{0}'", id_apagar);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente deletado com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        public DataTable Pesquisa_Cliente()
        {
            try
            {


                BD._sql = "SELECT ID_Cliente as 'Id', Nome as 'Nome' " +
               "  FROM Cliente  ORDER BY Nome" ;

                return BD.ExecutaSelect();


            }
            catch (Exception)
            {

            }

            return null;

        }


    }
}

