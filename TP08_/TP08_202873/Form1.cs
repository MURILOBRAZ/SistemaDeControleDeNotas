using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP08_202873
{
    public partial class Form1 : Form
    {
        #region VARIAVEIS GLOBAIS
        double n1, n2, n3, n4, mediaF;
        #endregion

        public Form1()
        {
            InitializeComponent();
            btnCad.Enabled = false;
            tbxDisciplina.Focus();
        }

        #region Habilitar Botão
        private void tbx4Bi_TextChanged(object sender, EventArgs e)
        {
            if (tbxDisciplina.Text.Length > 0 && tbxMatricula.Text.Length > 0 && tbxSerie.Text.Length > 0 && tbx1Bi.Text.Length > 0 && tbx2Bi.Text.Length > 0 && tbx3Bi.Text.Length > 0 && tbx4Bi.Text.Length > 0)
            {
                btnCad.Enabled = true;
                Media();
            }
        }

        private void tbx3Bi_TextChanged(object sender, EventArgs e)
        {
            if (tbxDisciplina.Text.Length > 0 && tbxMatricula.Text.Length > 0 && tbxSerie.Text.Length > 0 && tbx1Bi.Text.Length > 0 && tbx2Bi.Text.Length > 0 && tbx3Bi.Text.Length > 0 && tbx4Bi.Text.Length > 0)
            {
                btnCad.Enabled = true;
                Media();
            }
        }

        private void tbx2Bi_TextChanged(object sender, EventArgs e)
        {
            if (tbxDisciplina.Text.Length > 0 && tbxMatricula.Text.Length > 0 && tbxSerie.Text.Length > 0 && tbx1Bi.Text.Length > 0 && tbx2Bi.Text.Length > 0 && tbx3Bi.Text.Length > 0 && tbx4Bi.Text.Length > 0)
            {
                btnCad.Enabled = true;
                Media();
            }
        }

        private void tbx1Bi_TextChanged(object sender, EventArgs e)
        {
            if (tbxDisciplina.Text.Length > 0 && tbxMatricula.Text.Length > 0 && tbxSerie.Text.Length > 0 && tbx1Bi.Text.Length > 0 && tbx2Bi.Text.Length > 0 && tbx3Bi.Text.Length > 0 && tbx4Bi.Text.Length > 0)
            {
                btnCad.Enabled = true;
                Media();
            }
        }
        #endregion

        #region FILTRO
        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            switch (cbxProcurar.Text)
            {
                case "Disciplina":
                    bscControle.Filter = "Disciplina like '%" + tbxFiltro.Text + "%'"; break;
                case "Série":
                    bscControle.Filter = "Série like '%" + tbxFiltro.Text + "%'"; break;
                case "Matrícula":
                    bscControle.Filter = "Matrícula like '%" + tbxFiltro.Text + "%'"; break;
                case "Conceito":
                    bscControle.Filter = "Conceito like '%" + tbxFiltro.Text + "%'"; break;
                default:
                    tbxFiltro.Clear();
                    MessageBox.Show("Escolha uma opção", "Erro");
                    break;
            }

        }
        #endregion

        #region KeyPRESS

        private void tbx1Bi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 8 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region LIXO
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tbxDisciplina_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void tbxMatricula_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region Coluna/Linha
        private void MenuLinha_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < dtsControle.Tables["ControleTab"].Rows.Count; i++)
                {
                    SW.WriteLine(dtsControle.Tables["ControleTab"].Rows[i]["Disciplina"]);
                    SW.WriteLine(dtsControle.Tables["ControleTab"].Rows[i]["Série"]);
                    SW.WriteLine(dtsControle.Tables["ControleTab"].Rows[i]["Matrícula"]);
                    SW.WriteLine(dtsControle.Tables["ControleTab"].Rows[i]["Nota1"]);
                    SW.WriteLine(dtsControle.Tables["ControleTab"].Rows[i]["Nota2"]);
                    SW.WriteLine(dtsControle.Tables["ControleTab"].Rows[i]["Nota3"]);
                    SW.WriteLine(dtsControle.Tables["ControleTab"].Rows[i]["Nota4"]);
                    SW.WriteLine(dtsControle.Tables["ControleTab"].Rows[i]["Média"]);
                    SW.WriteLine(dtsControle.Tables["ControleTab"].Rows[i]["Conceito"]);
                    SW.WriteLine(string.Empty); //pula linha entre um registro e outro
                }
                SW.Dispose(); //Libera todos os recursos usados pelo Componente
            }
        }

        private void MenuColuna_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < dtsControle.Tables["ControleTab"].Rows.Count; i++)
                {
                    string Disciplina = dtgControle.Rows[i].Cells[0].Value.ToString();
                    string Série = dtgControle.Rows[i].Cells[1].Value.ToString();
                    string Matrícula = dtgControle.Rows[i].Cells[2].Value.ToString();
                    string Nota1 = dtgControle.Rows[i].Cells[3].Value.ToString();
                    string Nota2 = dtgControle.Rows[i].Cells[4].Value.ToString();
                    string Nota3 = dtgControle.Rows[i].Cells[5].Value.ToString();
                    string Nota4 = dtgControle.Rows[i].Cells[6].Value.ToString();
                    string Media = dtgControle.Rows[i].Cells[7].Value.ToString();
                    string Conceito = dtgControle.Rows[i].Cells[8].Value.ToString();
                     
                    SW.WriteLine("Nome da Dsciplina: " + Disciplina + " | " + "Série: " + Série + " | " + "RA: " + Matrícula + " | " + "Nota 1°Bimestre: " + Nota1 + " | " + "Nota 2°Bimestre: " +  Nota2 + " | " + "Nota 3°Bimestre: " + Nota3 + " | " + "Nota 4°Bimestre: " + Nota4);
                }
                SW.Dispose();
            }
        }
        #endregion

        #region FECHAR
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Encerrando o Controle de Notas",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;

        }
        #endregion

        #region BOTÃO
        private void btnCad_Click(object sender, EventArgs e)
        {
            if (tbxDisciplina.Text.Length > 0 && tbxMatricula.Text.Length > 0)
            {

            dtgControle.Enabled = true;
            DataRow novalinha = dtsControle.Tables["ControleTab"].NewRow();
            novalinha["Disciplina"] = tbxDisciplina.Text.ToString();
            novalinha["Série"] = tbxSerie.Text.ToString();
            novalinha["Matrícula"] = tbxMatricula.Text.ToString();
            novalinha["Nota1"] = tbx1Bi.Text.ToString();
            novalinha["Nota2"] = tbx2Bi.Text.ToString();
            novalinha["Nota3"] = tbx2Bi.Text.ToString();
            novalinha["Nota4"] = tbx2Bi.Text.ToString();
            novalinha["Média"] = tbxMfinal.Text.ToString();
            novalinha["Conceito"] = tbxConceito.Text.ToString();
            dtsControle.Tables[0].Rows.Add(novalinha);
            tbxDisciplina.Clear(); tbxSerie.Clear(); tbxMatricula.Clear(); tbx1Bi.Clear(); tbx2Bi.Clear(); tbx3Bi.Clear(); tbx4Bi.Clear();
            tbxMfinal.Clear();
            tbxConceito.Clear();
            n1 = 0; n2 = 0; n3 = 0; n4 = 0; mediaF = 0;
            dtgControle.Enabled = false;
            btnCad.Enabled = false;

            }
            else
            {
                MessageBox.Show("Todos os campos devem estar completos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region MÉDIA
        private void Media()
        {
            n1 = Convert.ToDouble(tbx1Bi.Text);
            n2 = Convert.ToDouble(tbx2Bi.Text);
            n3 = Convert.ToDouble(tbx3Bi.Text);
            n4 = Convert.ToDouble(tbx4Bi.Text);

            mediaF = (n1 + n2 + n3 + n4) / 4;

            tbxMfinal.Text = Convert.ToString(mediaF);

            if (mediaF < 6)
            {
                tbxConceito.Text = "REPROVADO";
                tbxConceito.ForeColor = Color.Red;
            }
            else
            {
                tbxConceito.Text = "APROVADO";
                tbxConceito.ForeColor = Color.Blue;
            }
            
        }
        #endregion
    }
}
