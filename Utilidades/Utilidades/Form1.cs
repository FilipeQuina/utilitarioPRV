using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Funcionario> funcionarios;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void Selecionar_botao_Click(object sender, EventArgs e)
        {
            int l;
            int j = 0;
            listView1.Items.Clear();
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "*.prv;*.txt|*.prv;*.txt";
            op.ShowDialog();

            if (op.FileName != "") {
                if (op.CheckFileExists)
                {
                    funcionarios = new List<Funcionario>();
                    StreamReader sr = new StreamReader(op.FileName);

                    while (!sr.EndOfStream)
                    {
                        String line = sr.ReadLine();


                        if (line != "") {
                            String[] linha = line.Split(';');

                            linha[1] = linha[1].Trim();
                            Funcionario funcionario = new Funcionario(linha[0], linha[1], linha[2], true);
                            funcionarios.Add(funcionario);
                        }
                       
                }

                    foreach (Funcionario f in funcionarios)
                    {
                        l = funcionarios.IndexOf(f) + 1;
                        if (!f.validPIS)
                        {
                            listView1.Items.Add(l.ToString()).
                            SubItems.Add(f.nome.Trim());
                            j++;
                        }

                        if (l >= 2999 && j <= 0)
                        {

                            MessageBox.Show("Todos os PIS são válidos");
                        }
                    }
                }
            }
        }
        private void CnpjInicio_TextChanged(object sender, EventArgs e)
        {          
            CnpjFim.Text = CnpjInicio.Text.Replace("-", "").Replace(".", "").Replace("/", "").Replace(" ","");

            lst_historico.Items.Add(CnpjFim.Text);
                
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lst_historico.Items.Clear();
        }
    }
}
