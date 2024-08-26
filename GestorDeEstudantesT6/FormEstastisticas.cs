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
    public partial class FormEstastisticas : Form
    {
        public FormEstastisticas()
        {
            InitializeComponent();
        }

        Color corPainelTotal;
        Color corPainelMeninos;
        Color corPainelMeninas;

        private void FormEstastisticas_Load(object sender, EventArgs e)
        {
            corPainelTotal = panelTotalDeAlunos.BackColor;
            corPainelMeninos = panelMeninos.BackColor;
            corPainelMeninas = panelMeninas.BackColor;
        }

        private void labelTotalDeAlunos_MouseEnter(object sender, EventArgs e)
        {
            panelTotalDeAlunos.BackColor = Color.Black;
            labelTotalDeAlunos.ForeColor = corPainelTotal;
        }

        private void labelTotalDeAlunos_MouseLeave(object sender, EventArgs e)
        {
            panelTotalDeAlunos.BackColor = corPainelTotal;
            labelTotalDeAlunos.ForeColor = Color.Black;
        }

        private void labelMeninos_MouseEnter(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Black;
            labelMeninos.ForeColor = corPainelMeninos;
        }

        private void labelMeninos_MouseLeave(object sender, EventArgs e)
        {
            panelMeninos.BackColor = corPainelMeninos;
            labelMeninos.ForeColor= Color.Black;
        }
    }
}
