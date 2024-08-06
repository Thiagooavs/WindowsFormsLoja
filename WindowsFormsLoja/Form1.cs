using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace WindowsFormsLoja
{
    public partial class Form1 : Form
    {
        int Total;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bnt_Produto_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txt_Produto.Text + " / Quant:" + "" + txt_Quantidade.Text + " / R$" + txt_Preco.Text + ",00");
            Total += int.Parse(txt_Preco.Text) * int.Parse(txt_Quantidade.Text);
            lbl_Total.Text = Total.ToString("C");
            
                
        }

        private void bnt_novo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txt_Preco.Text = "";
            txt_Produto.Text = "";
            txt_Quantidade.Text = "";
            lbl_Total.Text = "R$0,00";
            txt_Produto.Focus();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
