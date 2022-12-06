using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemaForms
{
    public partial class Form1 : Form
    {
        private Semaforo sem;
        public Form1()
        {
            InitializeComponent();
            this.sem = new Semaforo();
            atualizarPic();
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            sem.setVerde(radRua1.Checked ? 1 : 2);
            atualizarPic();
        }

        private void atualizarPic()
        {
            picRua1.Image = sem.getEstado(1) == 1 ? Properties.Resources.SemaGreen : sem.getEstado(1) == 2 ? Properties.Resources.SemaYello : Properties.Resources.semaRed;
            picRua2.Image = sem.getEstado(2) == 1 ? Properties.Resources.SemaGreen : sem.getEstado(2) == 2 ? Properties.Resources.SemaYello : Properties.Resources.semaRed;
            lblEstado.Text = sem.getEstado().ToString();
            lblEstadoByte.Text = sem.getEstadoByte();
        }

        private void btnAmarelo_Click(object sender, EventArgs e)
        {
            sem.setAmarelo(radRua1.Checked ? 1 : 2);
            atualizarPic();
        }

        private void btnVerm_Click(object sender, EventArgs e)
        {
            sem.setVermelho(radRua1.Checked ? 1 : 2);
            atualizarPic();
        }

        private void tmrCiclo_Tick(object sender, EventArgs e)
        {
            if (sem.getEstado(1) == 1)
            {
                sem.setAmarelo(1);
                sem.setVermelho(2);
            }
            else
            {
                if (sem.getEstado(1) == 2)
                {
                    sem.setVermelho(1);
                    sem.setVerde(2);
                }
                else
                {
                    sem.setVerde(1);
                    sem.setAmarelo(2);

                }
            }
            atualizarPic();
        }

        private void btnCiclo_Click(object sender, EventArgs e)
        {
            btnCiclo.Text = (btnCiclo.Text != "Iniciar" ? "Iniciar" : "Parar");
            tmrCiclo.Interval = int.Parse(txtTick.Text);
            tmrCiclo.Enabled = (btnCiclo.Text != "Iniciar");
            grpManual.Enabled = (btnCiclo.Text != "Parar");
        }
    }
}
