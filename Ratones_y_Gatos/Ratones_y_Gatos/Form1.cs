using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int width;
        int height;

        public Form1()
        {
            InitializeComponent();
            grilla.RowHeadersVisible = false;
            grilla.ColumnHeadersVisible = false;
            grilla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            grilla.AllowUserToResizeRows = false;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            grilla.AllowUserToResizeColumns = false;

            width = grilla.Width;
            height = grilla.Height;
        }
        Manager mimanager;
        bool haygato = true;
        int x, r, y, g, pasos = 0;



        private void btgenerar_Click(object sender, EventArgs e)
        {
            
            if (tbancho.Text == "" || tblargo.Text == "" || cgato.Text == "" || craton.Text == "")
                MessageBox.Show("Macri gato");
            else
            {
                btpaso.Enabled = true;
                groupBox1.Enabled = false;
                btgenerar.Enabled  = false;
                button1.Enabled = false;
                
                g = Convert.ToInt32(cgato.Text);
                x = Convert.ToInt32(tbancho.Text);
                y = Convert.ToInt32(tblargo.Text);
                r = Convert.ToInt32(craton.Text);

                mimanager = new Manager(haygato, x, y, r, g);

                grilla.ColumnCount = x;
                grilla.RowCount = y;

                for (int i = 0; i < x; i++)
                    grilla.Columns[i].Width = width / x;
                for (int i = 0; i < y; i++)
                    grilla.Rows[i].Height = height / y;

                CargarLista();
                Actualizar();
            }
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbancho.Text = "15";
            tblargo.Text = "15";
            cgato.Text = "0";
            craton.Text = "10";

        }

        public void Actualizar()
        {
            grilla.Rows.Clear();
            grilla.ColumnCount = mimanager.W;
            grilla.RowCount = mimanager.H;

            for (int i = 0; i < x; i++)
                grilla.Columns[i].Width = width / x;
            for (int i = 0; i < y; i++)
                grilla.Rows[i].Height = height / y;
           

            for (int i = 0; i < mimanager.animales.Count; i++){
                Animal animal = (Animal)mimanager.animales[i];
                if (animal is Raton)
                    grilla.Rows[animal.posY].Cells[animal.posX].Value += "R";
                else
                    grilla.Rows[animal.posY].Cells[animal.posX].Value += "G ";  
            }
           
            for (int i = 0; i < mimanager.quesos.Count; i++){
                Queso queso = (Queso)mimanager.quesos[i];
                grilla.Rows[queso.posY].Cells[queso.posX].Value += "Q ";
            }
            int gvivos = 0, rvivos = 0;
            for (int i = 0; i < mimanager.animales.Count; i++)
            {
                if (mimanager.animales[i] is Gato)
                    gvivos++;
                else rvivos++;
            }
            tbgvivos.Text = Convert.ToString(gvivos);
            tbrvivos.Text = Convert.ToString(rvivos);
            lbdias.Text = Convert.ToString(pasos / 10);
     
            if (rvivos == 0)
            {
                MessageBox.Show("Ya no hay ratones en mi bota");
                groupBox1.Enabled = true;
                btgenerar.Enabled = true;
                button1.Enabled = true;
                tbancho.Clear(); 
                tblargo.Clear(); 
                craton.Clear(); 
                cgato.Text = "0"; 
                lbdias.Text = "--"; 
                tbgvivos.Text = "--"; 
                tbrvivos.Text = "--";
                info.Items.Clear();
                grilla.Rows.Clear();
                grilla.Columns.Clear();
                pasos = 0;
               
            }
            rvivos = 0; 
            gvivos = 0; 
        }

        private void btpaso_Click(object sender, EventArgs e)
        {
            AcceptButton = btpaso;
            btpaso.Enabled = false;
            pasos++;
            ArrayList comibles = new ArrayList();
            comibles = (ArrayList)mimanager.quesos.Clone();
            
            comibles.InsertRange(comibles.Count, mimanager.animales);
            for (int i = 0; i < mimanager.animales.Count; i++){
                ((Animal)mimanager.animales[i]).Mover();
                ((Animal)mimanager.animales[i]).Comer(comibles);
            }

            mimanager.CheckAgua();
            mimanager.checkRatones();
            mimanager.CheckMuerte();
            
            
            CargarLista();
            Actualizar();
            btpaso.Enabled = true;
        }

        public void CargarLista()
        {
            info.Items.Clear();
            for (int i = 0; i < mimanager.animales.Count; i++)
                info.Items.Add(mimanager.animales[i].ToString());

            for (int i = 0; i < mimanager.quesos.Count; i++)
                info.Items.Add(mimanager.quesos[i].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void tbancho_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void tbancho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void craton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tblargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void cgato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btpaso_Enter(object sender, EventArgs e)
        {
            
        }



       
    }

}