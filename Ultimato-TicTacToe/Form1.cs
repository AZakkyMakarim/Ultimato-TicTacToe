using System.Runtime.Intrinsics.X86;
using System.Timers;

namespace Ultimato_TicTacToe
{
    public partial class Form1 : Form
    {
        char player = 'O';
        int skorO = 0;
        int skorX = 0;

        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Enabled = false;
            tableLayoutPanel2.Enabled = false;
            tableLayoutPanel3.Enabled = false;
            tableLayoutPanel4.Enabled = false;
            tableLayoutPanel5.Enabled = false;
            tableLayoutPanel6.Enabled = false;
            tableLayoutPanel7.Enabled = false;
            tableLayoutPanel8.Enabled = false;
            tableLayoutPanel9.Enabled = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player = 'O';
            b1.Enabled = true; b1.Text = ""; b1.BackColor = Color.White;
            b2.Enabled = true; b2.Text = ""; b2.BackColor = Color.White;
            b3.Enabled = true; b3.Text = ""; b3.BackColor = Color.White;
            b4.Enabled = true; b4.Text = ""; b4.BackColor = Color.White;
            b5.Enabled = true; b5.Text = ""; b5.BackColor = Color.White;
            b6.Enabled = true; b6.Text = ""; b6.BackColor = Color.White;
            b7.Enabled = true; b7.Text = ""; b7.BackColor = Color.White;
            b8.Enabled = true; b8.Text = ""; b8.BackColor = Color.White;
            b9.Enabled = true; b9.Text = ""; b9.BackColor = Color.White;
            b10.Enabled = true; b10.Text = ""; b10.BackColor = Color.White;
            b11.Enabled = true; b11.Text = ""; b11.BackColor = Color.White;
            b12.Enabled = true; b12.Text = ""; b12.BackColor = Color.White;
            b13.Enabled = true; b13.Text = ""; b13.BackColor = Color.White;
            b14.Enabled = true; b14.Text = ""; b14.BackColor = Color.White;
            b15.Enabled = true; b15.Text = ""; b15.BackColor = Color.White;
            b16.Enabled = true; b16.Text = ""; b16.BackColor = Color.White;
            b17.Enabled = true; b17.Text = ""; b17.BackColor = Color.White;
            b18.Enabled = true; b18.Text = ""; b18.BackColor = Color.White;
            b19.Enabled = true; b19.Text = ""; b19.BackColor = Color.White;
            b20.Enabled = true; b20.Text = ""; b20.BackColor = Color.White;
            b21.Enabled = true; b21.Text = ""; b21.BackColor = Color.White;
            b22.Enabled = true; b22.Text = ""; b22.BackColor = Color.White;
            b23.Enabled = true; b23.Text = ""; b23.BackColor = Color.White;
            b24.Enabled = true; b24.Text = ""; b24.BackColor = Color.White;
            b25.Enabled = true; b25.Text = ""; b25.BackColor = Color.White;
            b26.Enabled = true; b26.Text = ""; b26.BackColor = Color.White;
            b27.Enabled = true; b27.Text = ""; b27.BackColor = Color.White;
            b28.Enabled = true; b28.Text = ""; b28.BackColor = Color.White;
            b29.Enabled = true; b29.Text = ""; b29.BackColor = Color.White;
            b30.Enabled = true; b30.Text = ""; b30.BackColor = Color.White;
            b31.Enabled = true; b31.Text = ""; b31.BackColor = Color.White;
            b32.Enabled = true; b32.Text = ""; b32.BackColor = Color.White;
            b33.Enabled = true; b33.Text = ""; b33.BackColor = Color.White;
            b34.Enabled = true; b34.Text = ""; b34.BackColor = Color.White;
            b35.Enabled = true; b35.Text = ""; b35.BackColor = Color.White;
            b36.Enabled = true; b36.Text = ""; b36.BackColor = Color.White;
            b37.Enabled = true; b37.Text = ""; b37.BackColor = Color.White;
            b38.Enabled = true; b38.Text = ""; b38.BackColor = Color.White;
            b39.Enabled = true; b39.Text = ""; b39.BackColor = Color.White;
            b40.Enabled = true; b40.Text = ""; b40.BackColor = Color.White;
            b41.Enabled = true; b41.Text = ""; b41.BackColor = Color.White;
            b42.Enabled = true; b42.Text = ""; b42.BackColor = Color.White;
            b43.Enabled = true; b43.Text = ""; b43.BackColor = Color.White;
            b44.Enabled = true; b44.Text = ""; b44.BackColor = Color.White;
            b45.Enabled = true; b45.Text = ""; b45.BackColor = Color.White;
            b46.Enabled = true; b46.Text = ""; b46.BackColor = Color.White;
            b47.Enabled = true; b47.Text = ""; b47.BackColor = Color.White;
            b48.Enabled = true; b48.Text = ""; b48.BackColor = Color.White;
            b49.Enabled = true; b49.Text = ""; b49.BackColor = Color.White;
            b50.Enabled = true; b50.Text = ""; b50.BackColor = Color.White;
            b51.Enabled = true; b51.Text = ""; b51.BackColor = Color.White;
            b52.Enabled = true; b52.Text = ""; b52.BackColor = Color.White;
            b53.Enabled = true; b53.Text = ""; b53.BackColor = Color.White;
            b54.Enabled = true; b54.Text = ""; b54.BackColor = Color.White;
            b55.Enabled = true; b55.Text = ""; b55.BackColor = Color.White;
            b56.Enabled = true; b56.Text = ""; b56.BackColor = Color.White;
            b57.Enabled = true; b57.Text = ""; b57.BackColor = Color.White;
            b58.Enabled = true; b58.Text = ""; b58.BackColor = Color.White;
            b59.Enabled = true; b59.Text = ""; b59.BackColor = Color.White;
            b60.Enabled = true; b60.Text = ""; b60.BackColor = Color.White;
            b61.Enabled = true; b61.Text = ""; b61.BackColor = Color.White;
            b62.Enabled = true; b62.Text = ""; b62.BackColor = Color.White;
            b63.Enabled = true; b63.Text = ""; b63.BackColor = Color.White;
            b64.Enabled = true; b64.Text = ""; b64.BackColor = Color.White;
            b65.Enabled = true; b65.Text = ""; b65.BackColor = Color.White;
            b66.Enabled = true; b66.Text = ""; b66.BackColor = Color.White;
            b67.Enabled = true; b67.Text = ""; b67.BackColor = Color.White;
            b68.Enabled = true; b68.Text = ""; b68.BackColor = Color.White;
            b69.Enabled = true; b69.Text = ""; b69.BackColor = Color.White;
            b70.Enabled = true; b70.Text = ""; b70.BackColor = Color.White;
            b71.Enabled = true; b71.Text = ""; b71.BackColor = Color.White;
            b72.Enabled = true; b72.Text = ""; b72.BackColor = Color.White;
            b73.Enabled = true; b73.Text = ""; b73.BackColor = Color.White;
            b74.Enabled = true; b74.Text = ""; b74.BackColor = Color.White;
            b75.Enabled = true; b75.Text = ""; b75.BackColor = Color.White;
            b76.Enabled = true; b76.Text = ""; b76.BackColor = Color.White;
            b77.Enabled = true; b77.Text = ""; b77.BackColor = Color.White;
            b78.Enabled = true; b78.Text = ""; b78.BackColor = Color.White;
            b79.Enabled = true; b79.Text = ""; b79.BackColor = Color.White;
            b80.Enabled = true; b80.Text = ""; b80.BackColor = Color.White;
            b81.Enabled = true; b81.Text = ""; b81.BackColor = Color.White;
            tableLayoutPanel1.Enabled = true;
            tableLayoutPanel2.Enabled = false;
            tableLayoutPanel3.Enabled = false;
            tableLayoutPanel4.Enabled = false;
            tableLayoutPanel5.Enabled = false;
            tableLayoutPanel6.Enabled = false;
            tableLayoutPanel7.Enabled = false;
            tableLayoutPanel8.Enabled = false;
            tableLayoutPanel9.Enabled = false;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rulesnya simple, siapa yang skornya lebih banyak, dia yang menang");
        }

        private void button_Click1(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            if (player == 'O')
            {
                bt.BackColor = Color.Aquamarine;
                bt.Text = "O";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    b1.Enabled = false; b1.Text = "O"; b1.BackColor = Color.Aquamarine;
                    b2.Enabled = false; b2.Text = "O"; b2.BackColor = Color.Aquamarine;
                    b3.Enabled = false; b3.Text = "O"; b3.BackColor = Color.Aquamarine;
                    b4.Enabled = false; b4.Text = "O"; b4.BackColor = Color.Aquamarine;
                    b5.Enabled = false; b5.Text = "O"; b5.BackColor = Color.Aquamarine;
                    b6.Enabled = false; b6.Text = "O"; b6.BackColor = Color.Aquamarine;
                    b7.Enabled = false; b7.Text = "O"; b7.BackColor = Color.Aquamarine;
                    b8.Enabled = false; b8.Text = "O"; b8.BackColor = Color.Aquamarine;
                    b9.Enabled = false; b9.Text = "O"; b9.BackColor = Color.Aquamarine;
                    skorO++;
                }
                player = 'X';
            }
            else if (player == 'X')
            {
                bt.BackColor = Color.OrangeRed;
                bt.Text = "X";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    b1.Enabled = false; b1.Text = "X"; b1.BackColor = Color.OrangeRed;
                    b2.Enabled = false; b2.Text = "X"; b2.BackColor = Color.OrangeRed;
                    b3.Enabled = false; b3.Text = "X"; b3.BackColor = Color.OrangeRed;
                    b4.Enabled = false; b4.Text = "X"; b4.BackColor = Color.OrangeRed;
                    b5.Enabled = false; b5.Text = "X"; b5.BackColor = Color.OrangeRed;
                    b6.Enabled = false; b6.Text = "X"; b6.BackColor = Color.OrangeRed;
                    b7.Enabled = false; b7.Text = "X"; b7.BackColor = Color.OrangeRed;
                    b8.Enabled = false; b8.Text = "X"; b8.BackColor = Color.OrangeRed;
                    b9.Enabled = false; b9.Text = "X"; b9.BackColor = Color.OrangeRed;
                    skorX++;
                }
                player = 'O';
            }
            if (b1.Enabled == false && b2.Enabled == false && b3.Enabled == false &&
                b4.Enabled == false && b5.Enabled == false && b6.Enabled == false &&
                b7.Enabled == false && b8.Enabled == false && b9.Enabled == false)
            {
                tableLayoutPanel2.Enabled = true;
            }
        }
        private void button_Click2(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            if (player == 'O')
            {
                bt.BackColor = Color.Aquamarine;
                bt.Text = "O";
                if ((b10.Text == b11.Text && b11.Text == b12.Text && b11.Text != "") ||
                    (b13.Text == b14.Text && b14.Text == b15.Text && b14.Text != "") ||
                    (b16.Text == b17.Text && b17.Text == b18.Text && b17.Text != "") ||
                    (b10.Text == b13.Text && b13.Text == b16.Text && b13.Text != "") ||
                    (b11.Text == b14.Text && b14.Text == b17.Text && b14.Text != "") ||
                    (b12.Text == b15.Text && b15.Text == b18.Text && b15.Text != "") ||
                    (b10.Text == b14.Text && b14.Text == b18.Text && b14.Text != "") ||
                    (b12.Text == b14.Text && b14.Text == b16.Text && b14.Text != ""))
                {
                    b10.Enabled = false; b10.Text = "O"; b10.BackColor = Color.Aquamarine;
                    b11.Enabled = false; b11.Text = "O"; b11.BackColor = Color.Aquamarine;
                    b12.Enabled = false; b12.Text = "O"; b12.BackColor = Color.Aquamarine;
                    b13.Enabled = false; b13.Text = "O"; b13.BackColor = Color.Aquamarine;
                    b14.Enabled = false; b14.Text = "O"; b14.BackColor = Color.Aquamarine;
                    b15.Enabled = false; b15.Text = "O"; b15.BackColor = Color.Aquamarine;
                    b16.Enabled = false; b16.Text = "O"; b16.BackColor = Color.Aquamarine;
                    b17.Enabled = false; b17.Text = "O"; b17.BackColor = Color.Aquamarine;
                    b18.Enabled = false; b18.Text = "O"; b18.BackColor = Color.Aquamarine;
                    skorO++;
                }
                player = 'X';
            }
            else if (player == 'X')
            {
                bt.BackColor = Color.OrangeRed;
                bt.Text = "X";
                if ((b10.Text == b11.Text && b11.Text == b12.Text && b11.Text != "") ||
                    (b13.Text == b14.Text && b14.Text == b15.Text && b14.Text != "") ||
                    (b16.Text == b17.Text && b17.Text == b18.Text && b17.Text != "") ||
                    (b10.Text == b13.Text && b13.Text == b16.Text && b13.Text != "") ||
                    (b11.Text == b14.Text && b14.Text == b17.Text && b14.Text != "") ||
                    (b12.Text == b15.Text && b15.Text == b18.Text && b15.Text != "") ||
                    (b10.Text == b14.Text && b14.Text == b18.Text && b14.Text != "") ||
                    (b12.Text == b14.Text && b14.Text == b16.Text && b14.Text != ""))
                {
                    b10.Enabled = false; b10.Text = "X"; b10.BackColor = Color.OrangeRed;
                    b11.Enabled = false; b11.Text = "X"; b11.BackColor = Color.OrangeRed;
                    b12.Enabled = false; b12.Text = "X"; b12.BackColor = Color.OrangeRed;
                    b13.Enabled = false; b13.Text = "X"; b13.BackColor = Color.OrangeRed;
                    b14.Enabled = false; b14.Text = "X"; b14.BackColor = Color.OrangeRed;
                    b15.Enabled = false; b15.Text = "X"; b15.BackColor = Color.OrangeRed;
                    b16.Enabled = false; b16.Text = "X"; b16.BackColor = Color.OrangeRed;
                    b17.Enabled = false; b17.Text = "X"; b17.BackColor = Color.OrangeRed;
                    b18.Enabled = false; b18.Text = "X"; b18.BackColor = Color.OrangeRed;
                    skorX++;
                }
                player = 'O';
            }
            if (b10.Enabled == false && b11.Enabled == false && b12.Enabled == false &&
                b13.Enabled == false && b14.Enabled == false && b15.Enabled == false &&
                b16.Enabled == false && b17.Enabled == false && b18.Enabled == false)
            {
                tableLayoutPanel3.Enabled = true;
            }
        }

        private void button_Click3(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            if (player == 'O')
            {
                bt.BackColor = Color.Aquamarine;
                bt.Text = "O";
                if ((b19.Text == b20.Text && b20.Text == b21.Text && b20.Text != "") ||
                    (b22.Text == b23.Text && b23.Text == b24.Text && b23.Text != "") ||
                    (b25.Text == b26.Text && b26.Text == b27.Text && b26.Text != "") ||
                    (b19.Text == b22.Text && b22.Text == b25.Text && b22.Text != "") ||
                    (b20.Text == b23.Text && b23.Text == b26.Text && b23.Text != "") ||
                    (b21.Text == b24.Text && b24.Text == b27.Text && b24.Text != "") ||
                    (b19.Text == b23.Text && b23.Text == b27.Text && b23.Text != "") ||
                    (b21.Text == b23.Text && b23.Text == b25.Text && b23.Text != ""))
                {
                    b19.Enabled = false; b19.Text = "O"; b19.BackColor = Color.Aquamarine;
                    b20.Enabled = false; b20.Text = "O"; b20.BackColor = Color.Aquamarine;
                    b21.Enabled = false; b21.Text = "O"; b21.BackColor = Color.Aquamarine;
                    b22.Enabled = false; b22.Text = "O"; b22.BackColor = Color.Aquamarine;
                    b23.Enabled = false; b23.Text = "O"; b23.BackColor = Color.Aquamarine;
                    b24.Enabled = false; b24.Text = "O"; b24.BackColor = Color.Aquamarine;
                    b25.Enabled = false; b25.Text = "O"; b25.BackColor = Color.Aquamarine;
                    b26.Enabled = false; b26.Text = "O"; b26.BackColor = Color.Aquamarine;
                    b27.Enabled = false; b27.Text = "O"; b27.BackColor = Color.Aquamarine;
                    skorO++;
                }
                player = 'X';
            }
            else if (player == 'X')
            {
                bt.BackColor = Color.OrangeRed;
                bt.Text = "X";
                if ((b19.Text == b20.Text && b20.Text == b21.Text && b20.Text != "") ||
                    (b22.Text == b23.Text && b23.Text == b24.Text && b23.Text != "") ||
                    (b25.Text == b26.Text && b26.Text == b27.Text && b26.Text != "") ||
                    (b19.Text == b22.Text && b22.Text == b25.Text && b22.Text != "") ||
                    (b20.Text == b23.Text && b23.Text == b26.Text && b23.Text != "") ||
                    (b21.Text == b24.Text && b24.Text == b27.Text && b24.Text != "") ||
                    (b19.Text == b23.Text && b23.Text == b27.Text && b23.Text != "") ||
                    (b21.Text == b23.Text && b23.Text == b25.Text && b23.Text != ""))
                {
                    b19.Enabled = false; b19.Text = "X"; b19.BackColor = Color.OrangeRed;
                    b20.Enabled = false; b20.Text = "X"; b20.BackColor = Color.OrangeRed;
                    b21.Enabled = false; b21.Text = "X"; b21.BackColor = Color.OrangeRed;
                    b22.Enabled = false; b22.Text = "X"; b22.BackColor = Color.OrangeRed;
                    b23.Enabled = false; b23.Text = "X"; b23.BackColor = Color.OrangeRed;
                    b24.Enabled = false; b24.Text = "X"; b24.BackColor = Color.OrangeRed;
                    b25.Enabled = false; b25.Text = "X"; b25.BackColor = Color.OrangeRed;
                    b26.Enabled = false; b26.Text = "X"; b26.BackColor = Color.OrangeRed;
                    b27.Enabled = false; b27.Text = "X"; b27.BackColor = Color.OrangeRed;
                    skorX++;
                }
                player = 'O';
            }
            if (b19.Enabled == false && b20.Enabled == false && b21.Enabled == false &&
                b22.Enabled == false && b23.Enabled == false && b24.Enabled == false &&
                b25.Enabled == false && b26.Enabled == false && b27.Enabled == false)
            {
                tableLayoutPanel4.Enabled = true;
            }
        }

        private void button_Click4(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            if (player == 'O')
            {
                bt.BackColor = Color.Aquamarine;
                bt.Text = "O";
                if ((b28.Text == b29.Text && b29.Text == b30.Text && b29.Text != "") ||
                    (b31.Text == b32.Text && b32.Text == b33.Text && b32.Text != "") ||
                    (b34.Text == b35.Text && b35.Text == b36.Text && b35.Text != "") ||
                    (b28.Text == b31.Text && b31.Text == b34.Text && b31.Text != "") ||
                    (b29.Text == b32.Text && b32.Text == b35.Text && b32.Text != "") ||
                    (b30.Text == b33.Text && b33.Text == b36.Text && b33.Text != "") ||
                    (b28.Text == b32.Text && b32.Text == b36.Text && b32.Text != "") ||
                    (b30.Text == b32.Text && b32.Text == b34.Text && b32.Text != ""))
                {
                    b28.Enabled = false; b28.Text = "O"; b28.BackColor = Color.Aquamarine;
                    b29.Enabled = false; b29.Text = "O"; b29.BackColor = Color.Aquamarine;
                    b30.Enabled = false; b30.Text = "O"; b30.BackColor = Color.Aquamarine;
                    b31.Enabled = false; b31.Text = "O"; b31.BackColor = Color.Aquamarine;
                    b32.Enabled = false; b32.Text = "O"; b32.BackColor = Color.Aquamarine;
                    b33.Enabled = false; b33.Text = "O"; b33.BackColor = Color.Aquamarine;
                    b34.Enabled = false; b34.Text = "O"; b34.BackColor = Color.Aquamarine;
                    b35.Enabled = false; b35.Text = "O"; b35.BackColor = Color.Aquamarine;
                    b36.Enabled = false; b36.Text = "O"; b36.BackColor = Color.Aquamarine;
                    skorO++;
                }
                player = 'X';
            }
            else if (player == 'X')
            {
                bt.BackColor = Color.OrangeRed;
                bt.Text = "X";
                if ((b28.Text == b29.Text && b29.Text == b30.Text && b29.Text != "") ||
                    (b31.Text == b32.Text && b32.Text == b33.Text && b32.Text != "") ||
                    (b34.Text == b35.Text && b35.Text == b36.Text && b35.Text != "") ||
                    (b28.Text == b31.Text && b31.Text == b34.Text && b31.Text != "") ||
                    (b29.Text == b32.Text && b32.Text == b35.Text && b32.Text != "") ||
                    (b30.Text == b33.Text && b33.Text == b36.Text && b33.Text != "") ||
                    (b28.Text == b32.Text && b32.Text == b36.Text && b32.Text != "") ||
                    (b30.Text == b32.Text && b32.Text == b34.Text && b32.Text != ""))
                {
                    b28.Enabled = false; b28.Text = "X"; b28.BackColor = Color.OrangeRed;
                    b29.Enabled = false; b29.Text = "X"; b29.BackColor = Color.OrangeRed;
                    b30.Enabled = false; b30.Text = "X"; b30.BackColor = Color.OrangeRed;
                    b31.Enabled = false; b31.Text = "X"; b31.BackColor = Color.OrangeRed;
                    b32.Enabled = false; b32.Text = "X"; b32.BackColor = Color.OrangeRed;
                    b33.Enabled = false; b33.Text = "X"; b33.BackColor = Color.OrangeRed;
                    b34.Enabled = false; b34.Text = "X"; b34.BackColor = Color.OrangeRed;
                    b35.Enabled = false; b35.Text = "X"; b35.BackColor = Color.OrangeRed;
                    b36.Enabled = false; b36.Text = "X"; b36.BackColor = Color.OrangeRed;
                    skorX++;
                }
                player = 'O';
            }
            if (b28.Enabled == false && b29.Enabled == false && b30.Enabled == false &&
                b31.Enabled == false && b32.Enabled == false && b33.Enabled == false &&
                b34.Enabled == false && b35.Enabled == false && b36.Enabled == false)
            {
                tableLayoutPanel5.Enabled = true;
            }
        }

        private void button_Click5(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            if (player == 'O')
            {
                bt.BackColor = Color.Aquamarine;
                bt.Text = "O";
                if ((b37.Text == b38.Text && b38.Text == b39.Text && b38.Text != "") ||
                    (b40.Text == b41.Text && b41.Text == b42.Text && b41.Text != "") ||
                    (b43.Text == b44.Text && b44.Text == b45.Text && b44.Text != "") ||
                    (b37.Text == b40.Text && b40.Text == b43.Text && b40.Text != "") ||
                    (b38.Text == b41.Text && b41.Text == b44.Text && b41.Text != "") ||
                    (b39.Text == b42.Text && b42.Text == b45.Text && b42.Text != "") ||
                    (b37.Text == b41.Text && b41.Text == b45.Text && b41.Text != "") ||
                    (b39.Text == b41.Text && b41.Text == b43.Text && b41.Text != ""))
                {
                    b37.Enabled = false; b37.Text = "O"; b37.BackColor = Color.Aquamarine;
                    b38.Enabled = false; b38.Text = "O"; b38.BackColor = Color.Aquamarine;
                    b39.Enabled = false; b39.Text = "O"; b39.BackColor = Color.Aquamarine;
                    b40.Enabled = false; b40.Text = "O"; b40.BackColor = Color.Aquamarine;
                    b41.Enabled = false; b41.Text = "O"; b41.BackColor = Color.Aquamarine;
                    b42.Enabled = false; b42.Text = "O"; b42.BackColor = Color.Aquamarine;
                    b43.Enabled = false; b43.Text = "O"; b43.BackColor = Color.Aquamarine;
                    b44.Enabled = false; b44.Text = "O"; b44.BackColor = Color.Aquamarine;
                    b45.Enabled = false; b45.Text = "O"; b45.BackColor = Color.Aquamarine;
                    skorO++;
                }
                player = 'X';
            }
            else if (player == 'X')
            {
                bt.BackColor = Color.OrangeRed;
                bt.Text = "X";
                if ((b37.Text == b38.Text && b38.Text == b39.Text && b38.Text != "") ||
                    (b40.Text == b41.Text && b41.Text == b42.Text && b41.Text != "") ||
                    (b43.Text == b44.Text && b44.Text == b45.Text && b44.Text != "") ||
                    (b37.Text == b40.Text && b40.Text == b43.Text && b40.Text != "") ||
                    (b38.Text == b41.Text && b41.Text == b44.Text && b41.Text != "") ||
                    (b39.Text == b42.Text && b42.Text == b45.Text && b42.Text != "") ||
                    (b37.Text == b41.Text && b41.Text == b45.Text && b41.Text != "") ||
                    (b39.Text == b41.Text && b41.Text == b43.Text && b41.Text != ""))
                {
                    b37.Enabled = false; b37.Text = "X"; b37.BackColor = Color.OrangeRed;
                    b38.Enabled = false; b38.Text = "X"; b38.BackColor = Color.OrangeRed;
                    b39.Enabled = false; b39.Text = "X"; b39.BackColor = Color.OrangeRed;
                    b40.Enabled = false; b40.Text = "X"; b40.BackColor = Color.OrangeRed;
                    b41.Enabled = false; b41.Text = "X"; b41.BackColor = Color.OrangeRed;
                    b42.Enabled = false; b42.Text = "X"; b42.BackColor = Color.OrangeRed;
                    b43.Enabled = false; b43.Text = "X"; b43.BackColor = Color.OrangeRed;
                    b44.Enabled = false; b44.Text = "X"; b44.BackColor = Color.OrangeRed;
                    b45.Enabled = false; b45.Text = "X"; b45.BackColor = Color.OrangeRed;
                    skorX++;
                }
                player = 'O';
            }
            if (b37.Enabled == false && b38.Enabled == false && b39.Enabled == false &&
                b40.Enabled == false && b41.Enabled == false && b42.Enabled == false &&
                b43.Enabled == false && b44.Enabled == false && b45.Enabled == false)
            {
                tableLayoutPanel6.Enabled = true;
            }
        }

        private void button_Click6(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            if (player == 'O')
            {
                bt.BackColor = Color.Aquamarine;
                bt.Text = "O";
                if ((b46.Text == b47.Text && b47.Text == b48.Text && b47.Text != "") ||
                    (b49.Text == b50.Text && b50.Text == b51.Text && b50.Text != "") ||
                    (b52.Text == b53.Text && b53.Text == b54.Text && b53.Text != "") ||
                    (b46.Text == b49.Text && b49.Text == b52.Text && b49.Text != "") ||
                    (b47.Text == b50.Text && b50.Text == b53.Text && b50.Text != "") ||
                    (b48.Text == b51.Text && b51.Text == b54.Text && b51.Text != "") ||
                    (b46.Text == b50.Text && b50.Text == b54.Text && b50.Text != "") ||
                    (b48.Text == b50.Text && b50.Text == b52.Text && b50.Text != ""))
                {
                    b46.Enabled = false; b46.Text = "O"; b46.BackColor = Color.Aquamarine;
                    b47.Enabled = false; b47.Text = "O"; b47.BackColor = Color.Aquamarine;
                    b48.Enabled = false; b48.Text = "O"; b48.BackColor = Color.Aquamarine;
                    b49.Enabled = false; b49.Text = "O"; b49.BackColor = Color.Aquamarine;
                    b50.Enabled = false; b50.Text = "O"; b50.BackColor = Color.Aquamarine;
                    b51.Enabled = false; b51.Text = "O"; b51.BackColor = Color.Aquamarine;
                    b52.Enabled = false; b52.Text = "O"; b52.BackColor = Color.Aquamarine;
                    b53.Enabled = false; b53.Text = "O"; b53.BackColor = Color.Aquamarine;
                    b54.Enabled = false; b54.Text = "O"; b54.BackColor = Color.Aquamarine;
                    skorO++;
                }
                player = 'X';
            }
            else if (player == 'X')
            {
                bt.BackColor = Color.OrangeRed;
                bt.Text = "X";
                if ((b46.Text == b47.Text && b47.Text == b48.Text && b47.Text != "") ||
                    (b49.Text == b50.Text && b50.Text == b51.Text && b50.Text != "") ||
                    (b52.Text == b53.Text && b53.Text == b54.Text && b53.Text != "") ||
                    (b46.Text == b49.Text && b49.Text == b52.Text && b49.Text != "") ||
                    (b47.Text == b50.Text && b50.Text == b53.Text && b50.Text != "") ||
                    (b48.Text == b51.Text && b51.Text == b54.Text && b51.Text != "") ||
                    (b46.Text == b50.Text && b50.Text == b54.Text && b50.Text != "") ||
                    (b48.Text == b50.Text && b50.Text == b52.Text && b50.Text != ""))
                {
                    b46.Enabled = false; b46.Text = "X"; b46.BackColor = Color.OrangeRed;
                    b47.Enabled = false; b47.Text = "X"; b47.BackColor = Color.OrangeRed;
                    b48.Enabled = false; b48.Text = "X"; b48.BackColor = Color.OrangeRed;
                    b49.Enabled = false; b49.Text = "X"; b49.BackColor = Color.OrangeRed;
                    b50.Enabled = false; b50.Text = "X"; b50.BackColor = Color.OrangeRed;
                    b51.Enabled = false; b51.Text = "X"; b51.BackColor = Color.OrangeRed;
                    b52.Enabled = false; b52.Text = "X"; b52.BackColor = Color.OrangeRed;
                    b53.Enabled = false; b53.Text = "X"; b53.BackColor = Color.OrangeRed;
                    b54.Enabled = false; b54.Text = "X"; b54.BackColor = Color.OrangeRed;
                    skorX++;
                }
                player = 'O';
            }
            if (b46.Enabled == false && b47.Enabled == false && b48.Enabled == false &&
                b49.Enabled == false && b50.Enabled == false && b51.Enabled == false &&
                b52.Enabled == false && b53.Enabled == false && b54.Enabled == false)
            {
                tableLayoutPanel7.Enabled = true;
            }
        }

        private void button_Click7(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            if (player == 'O')
            {
                bt.BackColor = Color.Aquamarine;
                bt.Text = "O";
                if ((b55.Text == b56.Text && b56.Text == b57.Text && b56.Text != "") ||
                    (b58.Text == b59.Text && b59.Text == b60.Text && b59.Text != "") ||
                    (b61.Text == b62.Text && b62.Text == b63.Text && b62.Text != "") ||
                    (b55.Text == b58.Text && b58.Text == b61.Text && b58.Text != "") ||
                    (b56.Text == b59.Text && b59.Text == b62.Text && b59.Text != "") ||
                    (b57.Text == b60.Text && b60.Text == b63.Text && b60.Text != "") ||
                    (b55.Text == b59.Text && b59.Text == b63.Text && b59.Text != "") ||
                    (b57.Text == b59.Text && b59.Text == b61.Text && b59.Text != ""))
                {
                    b55.Enabled = false; b55.Text = "O"; b55.BackColor = Color.Aquamarine;
                    b56.Enabled = false; b56.Text = "O"; b56.BackColor = Color.Aquamarine;
                    b57.Enabled = false; b57.Text = "O"; b57.BackColor = Color.Aquamarine;
                    b58.Enabled = false; b58.Text = "O"; b58.BackColor = Color.Aquamarine;
                    b59.Enabled = false; b59.Text = "O"; b59.BackColor = Color.Aquamarine;
                    b60.Enabled = false; b60.Text = "O"; b60.BackColor = Color.Aquamarine;
                    b61.Enabled = false; b61.Text = "O"; b61.BackColor = Color.Aquamarine;
                    b62.Enabled = false; b62.Text = "O"; b62.BackColor = Color.Aquamarine;
                    b63.Enabled = false; b63.Text = "O"; b63.BackColor = Color.Aquamarine;
                    skorO++;
                }
                player = 'X';
            }
            else if (player == 'X')
            {
                bt.BackColor = Color.OrangeRed;
                bt.Text = "X";
                if ((b55.Text == b56.Text && b56.Text == b57.Text && b56.Text != "") ||
                    (b58.Text == b59.Text && b59.Text == b60.Text && b59.Text != "") ||
                    (b61.Text == b62.Text && b62.Text == b63.Text && b62.Text != "") ||
                    (b55.Text == b58.Text && b58.Text == b61.Text && b58.Text != "") ||
                    (b56.Text == b59.Text && b59.Text == b62.Text && b59.Text != "") ||
                    (b57.Text == b60.Text && b60.Text == b63.Text && b60.Text != "") ||
                    (b55.Text == b59.Text && b59.Text == b63.Text && b59.Text != "") ||
                    (b57.Text == b59.Text && b59.Text == b61.Text && b59.Text != ""))
                {
                    b55.Enabled = false; b55.Text = "X"; b55.BackColor = Color.OrangeRed;
                    b56.Enabled = false; b56.Text = "X"; b56.BackColor = Color.OrangeRed;
                    b57.Enabled = false; b57.Text = "X"; b57.BackColor = Color.OrangeRed;
                    b58.Enabled = false; b58.Text = "X"; b58.BackColor = Color.OrangeRed;
                    b59.Enabled = false; b59.Text = "X"; b59.BackColor = Color.OrangeRed;
                    b60.Enabled = false; b60.Text = "X"; b60.BackColor = Color.OrangeRed;
                    b61.Enabled = false; b61.Text = "X"; b61.BackColor = Color.OrangeRed;
                    b62.Enabled = false; b62.Text = "X"; b62.BackColor = Color.OrangeRed;
                    b63.Enabled = false; b63.Text = "X"; b63.BackColor = Color.OrangeRed;
                    skorX++;
                }
                player = 'O';
            }
            if (b55.Enabled == false && b56.Enabled == false && b57.Enabled == false &&
                b58.Enabled == false && b59.Enabled == false && b60.Enabled == false &&
                b61.Enabled == false && b62.Enabled == false && b63.Enabled == false)
            {
                tableLayoutPanel8.Enabled = true;
            }
        }

        private void button_Click8(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            if (player == 'O')
            {
                bt.BackColor = Color.Aquamarine;
                bt.Text = "O";
                if ((b64.Text == b65.Text && b65.Text == b66.Text && b65.Text != "") ||
                    (b67.Text == b68.Text && b68.Text == b69.Text && b68.Text != "") ||
                    (b70.Text == b71.Text && b71.Text == b72.Text && b71.Text != "") ||
                    (b64.Text == b67.Text && b67.Text == b70.Text && b67.Text != "") ||
                    (b65.Text == b68.Text && b68.Text == b71.Text && b68.Text != "") ||
                    (b66.Text == b69.Text && b69.Text == b72.Text && b69.Text != "") ||
                    (b64.Text == b68.Text && b68.Text == b72.Text && b68.Text != "") ||
                    (b66.Text == b68.Text && b68.Text == b70.Text && b68.Text != ""))
                {
                    b64.Enabled = false; b64.Text = "O"; b64.BackColor = Color.Aquamarine;
                    b65.Enabled = false; b65.Text = "O"; b65.BackColor = Color.Aquamarine;
                    b66.Enabled = false; b66.Text = "O"; b66.BackColor = Color.Aquamarine;
                    b67.Enabled = false; b67.Text = "O"; b67.BackColor = Color.Aquamarine;
                    b68.Enabled = false; b68.Text = "O"; b68.BackColor = Color.Aquamarine;
                    b69.Enabled = false; b69.Text = "O"; b69.BackColor = Color.Aquamarine;
                    b70.Enabled = false; b70.Text = "O"; b70.BackColor = Color.Aquamarine;
                    b71.Enabled = false; b71.Text = "O"; b71.BackColor = Color.Aquamarine;
                    b72.Enabled = false; b72.Text = "O"; b72.BackColor = Color.Aquamarine;
                    skorO++;
                }
                player = 'X';
            }
            else if (player == 'X')
            {
                bt.BackColor = Color.OrangeRed;
                bt.Text = "X";
                if ((b64.Text == b65.Text && b65.Text == b66.Text && b65.Text != "") ||
                    (b67.Text == b68.Text && b68.Text == b69.Text && b68.Text != "") ||
                    (b70.Text == b71.Text && b71.Text == b72.Text && b71.Text != "") ||
                    (b64.Text == b67.Text && b67.Text == b70.Text && b67.Text != "") ||
                    (b65.Text == b68.Text && b68.Text == b71.Text && b68.Text != "") ||
                    (b66.Text == b69.Text && b69.Text == b72.Text && b69.Text != "") ||
                    (b64.Text == b68.Text && b68.Text == b72.Text && b68.Text != "") ||
                    (b66.Text == b68.Text && b68.Text == b70.Text && b68.Text != ""))
                {
                    b64.Enabled = false; b64.Text = "X"; b64.BackColor = Color.OrangeRed;
                    b65.Enabled = false; b65.Text = "X"; b65.BackColor = Color.OrangeRed;
                    b66.Enabled = false; b66.Text = "X"; b66.BackColor = Color.OrangeRed;
                    b67.Enabled = false; b67.Text = "X"; b67.BackColor = Color.OrangeRed;
                    b68.Enabled = false; b68.Text = "X"; b68.BackColor = Color.OrangeRed;
                    b69.Enabled = false; b69.Text = "X"; b69.BackColor = Color.OrangeRed;
                    b70.Enabled = false; b70.Text = "X"; b70.BackColor = Color.OrangeRed;
                    b71.Enabled = false; b71.Text = "X"; b71.BackColor = Color.OrangeRed;
                    b72.Enabled = false; b72.Text = "X"; b72.BackColor = Color.OrangeRed;
                    skorX++;
                }
                player = 'O';
            }
            if (b64.Enabled == false && b65.Enabled == false && b66.Enabled == false &&
                b67.Enabled == false && b68.Enabled == false && b69.Enabled == false &&
                b70.Enabled == false && b71.Enabled == false && b72.Enabled == false)
            {
                tableLayoutPanel9.Enabled = true;
            }
        }

        public void button_Click9(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            if (player == 'O')
            {
                bt.BackColor = Color.Aquamarine;
                bt.Text = "O";
                if ((b73.Text == b74.Text && b74.Text == b75.Text && b74.Text != "") ||
                    (b76.Text == b77.Text && b77.Text == b78.Text && b77.Text != "") ||
                    (b79.Text == b80.Text && b80.Text == b81.Text && b80.Text != "") ||
                    (b73.Text == b76.Text && b76.Text == b79.Text && b76.Text != "") ||
                    (b74.Text == b77.Text && b77.Text == b80.Text && b77.Text != "") ||
                    (b75.Text == b78.Text && b78.Text == b81.Text && b78.Text != "") ||
                    (b73.Text == b77.Text && b77.Text == b81.Text && b77.Text != "") ||
                    (b75.Text == b77.Text && b77.Text == b79.Text && b77.Text != ""))
                {
                    b73.Enabled = false; b73.Text = "O"; b73.BackColor = Color.Aquamarine;
                    b74.Enabled = false; b74.Text = "O"; b74.BackColor = Color.Aquamarine;
                    b75.Enabled = false; b75.Text = "O"; b75.BackColor = Color.Aquamarine;
                    b76.Enabled = false; b76.Text = "O"; b76.BackColor = Color.Aquamarine;
                    b77.Enabled = false; b77.Text = "O"; b77.BackColor = Color.Aquamarine;
                    b78.Enabled = false; b78.Text = "O"; b78.BackColor = Color.Aquamarine;
                    b79.Enabled = false; b79.Text = "O"; b79.BackColor = Color.Aquamarine;
                    b80.Enabled = false; b80.Text = "O"; b80.BackColor = Color.Aquamarine;
                    b81.Enabled = false; b81.Text = "O"; b81.BackColor = Color.Aquamarine;
                    skorO++;
                }
                player = 'X';
            }
            else if (player == 'X')
            {
                bt.BackColor = Color.OrangeRed;
                bt.Text = "X";
                if ((b73.Text == b74.Text && b74.Text == b75.Text && b74.Text != "") ||
                    (b76.Text == b77.Text && b77.Text == b78.Text && b77.Text != "") ||
                    (b79.Text == b80.Text && b80.Text == b81.Text && b80.Text != "") ||
                    (b73.Text == b76.Text && b76.Text == b79.Text && b76.Text != "") ||
                    (b74.Text == b77.Text && b77.Text == b80.Text && b77.Text != "") ||
                    (b75.Text == b78.Text && b78.Text == b81.Text && b78.Text != "") ||
                    (b73.Text == b77.Text && b77.Text == b81.Text && b77.Text != "") ||
                    (b75.Text == b77.Text && b77.Text == b79.Text && b77.Text != ""))
                {
                    b73.Enabled = false; b73.Text = "X"; b73.BackColor = Color.OrangeRed;
                    b74.Enabled = false; b74.Text = "X"; b74.BackColor = Color.OrangeRed;
                    b75.Enabled = false; b75.Text = "X"; b75.BackColor = Color.OrangeRed;
                    b76.Enabled = false; b76.Text = "X"; b76.BackColor = Color.OrangeRed;
                    b77.Enabled = false; b77.Text = "X"; b77.BackColor = Color.OrangeRed;
                    b78.Enabled = false; b78.Text = "X"; b78.BackColor = Color.OrangeRed;
                    b79.Enabled = false; b79.Text = "X"; b79.BackColor = Color.OrangeRed;
                    b80.Enabled = false; b80.Text = "X"; b80.BackColor = Color.OrangeRed;
                    b81.Enabled = false; b81.Text = "X"; b81.BackColor = Color.OrangeRed;
                    skorX++;
                }
                player = 'O';
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String skorAkhirO = skorO.ToString();
            String skorAkhirX = skorX.ToString();
            if (skorO > skorX)
            {
                MessageBox.Show($"O menang dengan skor {skorAkhirO} : {skorAkhirX}");
            }
            else if (skorO < skorX)
            {
                MessageBox.Show($"X menang dengan skor {skorAkhirX} : {skorAkhirO}");
            }
            else
            {
                MessageBox.Show($"Hasilnya draw dengan skor {skorAkhirO} : {skorAkhirX}");
            }
        }
    }
}