﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void abreForm(int nivel, Form f)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "---";
            pb_led.Image = Properties.Resources.led_vermelho;
            Globais.nivel = 0;
            Globais.logado = false;

        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if(Globais.nivel >= 2)
                {

                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            abreForm(1, f_NovoUsuario);
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestãoUsuarios f_GestãoUsuarios = new F_GestãoUsuarios();
            abreForm(1, f_GestãoUsuarios);
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                F_NovoAluno f_NovoAluno = new F_NovoAluno();
                abreForm(1, f_NovoAluno);
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();
            abreForm(2, f_Horarios);
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Professores f_Professores = new F_Professores();
            abreForm(2, f_Professores);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestãoDeTurmas f_GestãoDeTurmas = new F_GestãoDeTurmas();
            abreForm(2, f_GestãoDeTurmas);
        }

        private void gestãoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestãoDeAlunos f_GestãoDeAlunos = new F_GestãoDeAlunos();
            abreForm(1, f_GestãoDeAlunos);
        }
    }
}
