﻿using System;
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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenuPrincipa inserirEstudante = new FormMenuPrincipa();
            inserirEstudante.Show();
        }

        private void listarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaEstudantes listarEstudantes = new FormListaEstudantes();
            listarEstudantes.Show();
        }
    }
}
