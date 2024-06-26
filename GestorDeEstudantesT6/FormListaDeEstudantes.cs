﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT6
{
    public partial class FormListaDeEstudantes : Form
    {
        public FormListaDeEstudantes()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormListaDeEstudantes_Load(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");
            dataGridViewListaDeEstudantes.ReadOnly = true; 
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn(); 
            dataGridViewListaDeEstudantes.RowTemplate.Height = 80; 
            dataGridViewListaDeEstudantes.DataSource = estudante.getEstudantes(comando); 
            colunaDeFotos = (DataGridViewImageColumn) dataGridViewListaDeEstudantes.Columns[7]; 
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch; 
            dataGridViewListaDeEstudantes.AllowUserToAddRows = false;
        }

        private void dataGridViewListaDeEstudantes_DoubleClick(object sender, EventArgs e)
        {
            FormAtualizarApagarAlunos formAtualizarApagarAlunos = new FormAtualizarApagarAlunos();
            formAtualizarApagarAlunos.Show();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridViewListaDeEstudantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
