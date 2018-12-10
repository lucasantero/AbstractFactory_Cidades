using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory_Cidades
{
    public partial class Form1 : Form
    {
        FabricaAbstrata pais;

        public Form1()
        {
            InitializeComponent();
            CB_Pais.DataSource = FabricaAbstrata.GetListaDePaises();
            CB_Pais.SelectedItem = null;
            CB_Cidade.SelectedItem = null;
            CB_Cidade.Enabled = false;
        }

        private void MostrarCidade(ICidade cidade)
        {
            string texto = 
            TB_Painel.Text = $"Nome:{cidade.Nome}\r\n" +
            $"País: {pais.Pais}\r\n" +
            $"Numero de Habitantes: {cidade.NumeroDeHabitantes}\r\n" +
            $"Curiosidades: {cidade.Curiosidades}";
            TB_Painel.Text = texto;
        }

        private void CB_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Cidade.SelectedItem != null)
                CB_Cidade.SelectedItem = null;
            if (TB_Painel.Text != "")
                TB_Painel.Text = "";
            if (CB_Pais.SelectedItem != null)
            {
                pais = FabricaAbstrata.getPais((string)CB_Pais.SelectedItem);
                CB_Cidade.DataSource = pais.GetListaCidades();
                CB_Cidade.SelectedItem = null;
                CB_Cidade.Enabled = true;
            }
        }

        private void CB_Cidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Cidade.SelectedItem != null)
            {
                ICidade cidade = pais.getCidade((string)CB_Cidade.SelectedItem);
                MostrarCidade(cidade);
            }
            else
            {
                TB_Painel.Text = "";
            }
        }


    }
}
