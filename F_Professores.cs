using System;
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
    public partial class F_Professores : Form
    {
        public F_Professores()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_idProfessor.Clear();
            tb_nomeProfessor.Clear();
            mtb_telefone.Clear();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_Professores_Load(object sender, EventArgs e)
        {
            string vquery = @" SELECT 
            N_IDPROFESSOR as 'ID',
            T_NOMEPROFESSOR as 'Nome do Professor',
            T_TELEFONE as 'Contato do Professor'
            FROM tb_professores
            ORDER BY N_IDPROFESSOR";
            dgv_professores.DataSource = Banco.dql(vquery);
            dgv_professores.Columns[0].Width = 60;
            dgv_professores.Columns[1].Width = 170;
            dgv_professores.Columns[2].Width = 100;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string vquery;
            if (tb_idProfessor.Text == "")
            {
                vquery = @"INSERT INTO tb_professores (T_NOMEPROFESSOR, T_TELEFONE) 
                         VALUES ('" + tb_nomeProfessor.Text + "', '" + mtb_telefone.Text + "')";

            }
            else
            {
                vquery = @"UPDATE tb_professores SET T_NOMEPROFESSOR = '"+ tb_nomeProfessor.Text +"', T_TELEFONE = '"+mtb_telefone.Text+ "' WHERE N_IDPROFESSOR=" +tb_idProfessor.Text;
            }
            
            Banco.dml(vquery);
            string vquerry = @"SELECT 
            N_IDPROFESSOR as 'ID',
            T_NOMEPROFESSOR as 'Nome do Professor',
            T_TELEFONE as 'Contato do Professor'
            FROM tb_professores
            ORDER BY N_IDPROFESSOR";
            dgv_professores.DataSource = Banco.dql(vquerry);
        }

        private void tb_idProfessor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                string vquery = @"DELETE FROM tb_professores WHERE N_IDPROFESSOR=" + tb_idProfessor.Text;
                Banco.dml(vquery);
                dgv_professores.Rows.Remove(dgv_professores.CurrentRow);
            }
        }

        private void dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if(contlinhas  > 0)
            {
                DataTable dt = new DataTable();


                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquerry = @"
                SELECT *
                FROM tb_professores
                WHERE N_IDPROFESSOR=" + vid;
                dt = Banco.dql(vquerry);


                tb_idProfessor.Text = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                tb_nomeProfessor.Text = dt.Rows[0].Field<String>("T_NOMEPROFESSOR");
                mtb_telefone.Text = dt.Rows[0].Field<String>("T_TELEFONE");
            }
        }
    }
}
