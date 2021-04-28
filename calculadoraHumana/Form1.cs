using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraHumana
{
    
    public partial class Form1 : Form
    {
        TimeSpan tiempo;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbfacil.Checked==true)
            {
                lblfacil.Visible = true;
                lblinter.Visible = false;
                lbldificil.Visible = false;

            }
        }

        public void verificar()
        {
            bool bl1 = false, bl2 = false, bl3 = false, bl4 = false, bl5 = false, bl6 = false;
            timer1.Stop();
            if (rdbsuma.Checked == true)
            {
                if (tiempo.Seconds == 0)
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                    {
                        MessageBox.Show("Verifique si los campos esten llenos");
                        timer1.Start();
                    }
                    else
                    {


                        if (Int32.Parse(textBox1.Text) == Int32.Parse(label1.Text) + Int32.Parse(label7.Text))
                        {
                            bl1 = true;
                            textBox1.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            textBox1.BackColor = Color.LightPink;
                        }

                        if (Int32.Parse(textBox2.Text) == Int32.Parse(label2.Text) + Int32.Parse(label8.Text))
                        {
                            bl2 = true;
                            textBox2.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            textBox2.BackColor = Color.LightPink;
                        }

                        if (Int32.Parse(textBox3.Text) == Int32.Parse(label3.Text) + Int32.Parse(label9.Text))
                        {
                            bl3 = true;
                            textBox3.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            textBox3.BackColor = Color.LightPink;
                        }

                        if (Int32.Parse(textBox4.Text) == Int32.Parse(label4.Text) + Int32.Parse(label10.Text))
                        {
                            bl4 = true;
                            textBox4.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            textBox4.BackColor = Color.LightPink;
                        }

                        if (Int32.Parse(textBox5.Text) == Int32.Parse(label5.Text) + Int32.Parse(label11.Text))
                        {
                            bl5 = true;
                            textBox5.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            textBox5.BackColor = Color.LightPink;
                        }

                        if (Int32.Parse(textBox6.Text) == Int32.Parse(label6.Text) + Int32.Parse(label12.Text))
                        {
                            bl6 = true;
                            textBox6.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            textBox6.BackColor = Color.LightPink;
                        }
                        if (bl1 == true && bl2 == true && bl3 == true && bl4 == true && bl5 == true && bl6 == true)
                        {
                            MessageBox.Show("Felicidades usted ha ganado", "Felicitaciones", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Usted ah perdido", "Perdedor");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usted ah perdido", "Perdedor");
                }
                btnlimpiar.Visible = true;
            }
            else if (rbdmult.Checked == true)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("Verifique si los campos esten llenos");
                    timer1.Start();
                }
                else
                {
                    if (tiempo.Seconds == 0)
                    {
                        if (Int32.Parse(textBox1.Text) == Int32.Parse(label1.Text) * Int32.Parse(label7.Text))
                        {
                            bl1 = true;
                            textBox1.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            textBox1.BackColor = Color.LightPink;
                        }

                        if (Int32.Parse(textBox2.Text) == Int32.Parse(label2.Text) * Int32.Parse(label8.Text))
                        {
                            bl2 = true;
                            textBox2.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            textBox2.BackColor = Color.LightPink;
                        }

                        if (Int32.Parse(textBox3.Text) == Int32.Parse(label3.Text) * Int32.Parse(label9.Text))
                        {
                            bl3 = true;
                            textBox3.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            textBox3.BackColor = Color.LightPink;
                        }

                        if (Int32.Parse(textBox4.Text) == Int32.Parse(label4.Text) * Int32.Parse(label10.Text))
                        {
                            bl4 = true;
                            textBox4.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            textBox4.BackColor = Color.LightPink;
                        }

                        if (Int32.Parse(textBox5.Text) == Int32.Parse(label5.Text) * Int32.Parse(label11.Text))
                        {
                            bl5 = true;
                            textBox5.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            textBox5.BackColor = Color.LightPink;
                        }

                        if (Int32.Parse(textBox6.Text) == Int32.Parse(label6.Text) * Int32.Parse(label12.Text))
                        {
                            bl6 = true;
                            textBox6.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            textBox6.BackColor = Color.LightPink;
                        }
                        if (bl1 == true && bl2 == true && bl3 == true && bl4 == true && bl5 == true && bl6 == true)
                        {
                            MessageBox.Show("FELICIDADES, HA GANADO", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("HA PERDIDO", "PERDEDOR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("HA PERDIDO", "PERDEDOR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }

        }
        int min, seg;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblfacil.Visible = false;
            lblinter.Visible = false;
            lbldificil.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtinter.Checked == true)
            {
                lblinter.Visible = true;
                lbldificil.Visible = false;
                lblfacil.Visible = false;
            }
        }
        

        private void rbddificil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbddificil.Checked == true)
            {
                lbldificil.Visible = true;
                lblfacil.Visible = false;
                lblinter.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            btnlimpiar.Visible = false;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;

            Random aleatorio = new Random();
            int num1,num2,num3,num4,num5,num6,num7,num8,num9,num10,num11,num12;

            if (rdbsuma.Checked==false && rbdmult.Checked==false)
            {
                MessageBox.Show("Escoja la operación","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (rdbfacil.Checked == true)
                {
                    num1 = aleatorio.Next(1, 9);
                    label1.Text = num1.ToString();
                    num2 = aleatorio.Next(1, 9);
                    label2.Text = num2.ToString();
                    num3 = aleatorio.Next(1, 9);
                    label3.Text = num3.ToString();
                    num4 = aleatorio.Next(1, 9);
                    label4.Text = num4.ToString();
                    num5 = aleatorio.Next(1, 9);
                    label5.Text = num5.ToString();
                    num6 = aleatorio.Next(1, 9);
                    label6.Text = num6.ToString();
                    num7 = aleatorio.Next(1, 9);
                    label7.Text = num7.ToString();
                    num8 = aleatorio.Next(1, 9);
                    label8.Text = num8.ToString();
                    num9 = aleatorio.Next(1, 9);
                    label9.Text = num9.ToString();
                    num10 = aleatorio.Next(1, 9);
                    label10.Text = num10.ToString();
                    num11 = aleatorio.Next(1, 9);
                    label11.Text = num11.ToString();
                    num12 = aleatorio.Next(1, 9);
                    label12.Text = num12.ToString();
                }

                    if (rbtinter.Checked == true)
                    {
                        num1 = aleatorio.Next(10, 99);
                        label1.Text = num1.ToString();
                        num2 = aleatorio.Next(10, 99);
                        label2.Text = num2.ToString();
                        num3 = aleatorio.Next(10, 99);
                        label3.Text = num3.ToString();
                        num4 = aleatorio.Next(10, 99);
                        label4.Text = num4.ToString();
                        num5 = aleatorio.Next(10, 99);
                        label5.Text = num5.ToString();
                        num6 = aleatorio.Next(10, 90);
                        label6.Text = num6.ToString();
                        num7 = aleatorio.Next(10, 99);
                        label7.Text = num7.ToString();
                        num8 = aleatorio.Next(10, 99);
                        label8.Text = num8.ToString();
                        num9 = aleatorio.Next(10, 99);
                        label9.Text = num9.ToString();
                        num10 = aleatorio.Next(10, 99);
                        label10.Text = num10.ToString();
                        num11 = aleatorio.Next(10, 99);
                        label11.Text = num11.ToString();
                        num12 = aleatorio.Next(10, 99);
                        label12.Text = num12.ToString();
                    }
                if (rbddificil.Checked==true)
                {
                    num1 = aleatorio.Next(100, 999);
                    label1.Text = num1.ToString();
                    num2 = aleatorio.Next(100, 999);
                    label2.Text = num2.ToString();
                    num3 = aleatorio.Next(100, 999);
                    label3.Text = num3.ToString();
                    num4 = aleatorio.Next(100, 999);
                    label4.Text = num4.ToString();
                    num5 = aleatorio.Next(100, 999);
                    label5.Text = num5.ToString();
                    num6 = aleatorio.Next(100, 999);
                    label6.Text = num6.ToString();
                    num7 = aleatorio.Next(100, 999);
                    label7.Text = num7.ToString();
                    num8 = aleatorio.Next(100, 999);
                    label8.Text = num8.ToString();
                    num9 = aleatorio.Next(100, 999);
                    label9.Text = num9.ToString();
                    num10 = aleatorio.Next(100, 999);
                    label10.Text = num10.ToString();
                    num11 = aleatorio.Next(100, 999);
                    label11.Text = num11.ToString();
                    num12 = aleatorio.Next(100, 999);
                    label12.Text = num12.ToString();
                }
            }
            timer1.Start();
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbsuma.Checked==true)
            {
                label19.Text = label20.Text = label21.Text = label22.Text = label23.Text = label24.Text = "+";
            }
        }

        private void rbdmult_CheckedChanged(object sender, EventArgs e)
        {
            if (rbdmult.Checked==true)
            {
                label19.Text = label20.Text = label21.Text = label22.Text = label23.Text = label24.Text = "x";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=" " && textBox2.Text!=" " && textBox3.Text!=" " && textBox4.Text!=" " && textBox5.Text!=" " && textBox6.Text!=" ")
            {
                verificar();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox2.Text = "";
            textBox2.BackColor = Color.White;
            textBox3.Text = "";
            textBox3.BackColor = Color.White;
            textBox4.Text = "";
            textBox4.BackColor = Color.White;
            textBox5.Text = "";
            textBox5.BackColor = Color.White;
            textBox6.Text = "";
            textBox6.BackColor = Color.White;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            btnlimpiar.Visible = true;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            timer1.Stop();
            label_milesimas.Text = "TIEMPO: 00 : 00 : 00" ;
            button1.Visible = true;
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox2.Text = "";
            textBox2.BackColor = Color.White;
            textBox3.Text = "";
            textBox3.BackColor = Color.White;
            textBox4.Text = "";
            textBox4.BackColor = Color.White;
            textBox5.Text = "";
            textBox5.BackColor = Color.White;
            textBox6.Text = "";
            textBox6.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (seg==0)
            {
                min += 00;
                seg = 46;

            }
            seg -= 1;
            label_milesimas.Text = "TIEMPO: 00 : 00 : "+ seg.ToString();

            if (seg ==5 || seg == 4 || seg == 3 || seg == 2 || seg == 1)
            {
                label_milesimas.ForeColor = Color.Red;
                label_milesimas.Font = new Font("Tahoma", 14, FontStyle.Bold);
            }
            if (seg == 0)
            {
                timer1.Stop();
                MessageBox.Show("SE ACABO EL TIEMPO","JUEGO TERMINADO",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                label_milesimas.Visible=false;
                btnlimpiar.Visible = true;
                button1.Visible = true;

            }
        }

    }
}
