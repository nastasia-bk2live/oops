using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace GameOfLIfe
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int countGeneration;
        private bool[,] field;
        private bool[,] prew_field;
        private int resolution1;
        private int resolution2;
        private int rows;
        private int cols;
        private int interval;
        private int neighborsCount;
        private string namefail;
        
        public Form1()
        {
            InitializeComponent();

        }
        private void b_off()
        {
            nUD_height.Enabled = false;
            nUD_width.Enabled = false;
            nUD_dens.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            nUD_interval.Enabled = false;
        }
        private void b_on()
        {
            nUD_height.Enabled = true;
            nUD_width.Enabled = true;
            nUD_dens.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            nUD_interval.Enabled = true;
        }
        private void all_false(int cols, int rows)
        {
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = false;
                }
            }
        }
        private void StartGame()
        {
            if (timer1.Enabled)
                return;
            

            countGeneration = 0;
            
            

            if (comboBox1.SelectedIndex == 0)
            {
                rows = (int)nUD_height.Value;
                cols = (int)nUD_width.Value;
                field = new bool[cols, rows];
                prew_field = new bool[cols, rows];

                resolution1 = pictureBox1.Height / rows;
                resolution2 = pictureBox1.Width / cols;
                Random random = new Random();
                for (int x = 0; x < cols; x++)
                {
                    for (int y = 0; y < rows; y++)
                    {
                        field[x, y] = random.Next((int)nUD_dens.Value) == 0;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                rows = (int)nUD_height.Value;
                cols = (int)nUD_width.Value;
                field = new bool[cols, rows];
                prew_field = new bool[cols, rows];

                resolution1 = pictureBox1.Height / rows;
                resolution2 = pictureBox1.Width / cols;
                all_false(cols, rows);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                StreamReader input = new StreamReader(namefail);
                cols = int.Parse(input.ReadLine());
                rows = int.Parse(input.ReadLine());

                resolution1 = pictureBox1.Height / rows;
                resolution2 = pictureBox1.Width / cols;
                field = new bool[cols, rows];
                prew_field = new bool[cols, rows];
                all_false(cols, rows);
                string sx, sy;
                int _x, _y;
                sx = input.ReadLine();
                while (sx != null)
                {
                    sy = input.ReadLine();
                    _x = int.Parse(sx);
                    _y = int.Parse(sy);
                    field[_x, _y] = true;
                    sx = input.ReadLine();
                }
                input.Close();

            }
           
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (field[x, y])
                        graphics.FillRectangle(Brushes.LightGreen, x * resolution2, y * resolution1, resolution2 - 1, resolution1 - 1);
                    else graphics.FillRectangle(Brushes.Gray, x * resolution2, y * resolution1, resolution2 - 1, resolution1 - 1);
                }
            }
            Text = $"Поколение {countGeneration}";
            
        }

        private int CountNeighbors_tor(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int col = (x + i + cols) % cols;
                    int row = (y + j + rows) % rows;
                    var hasLife = field[col, row];
                    var isSelfChecking = col == x && row == y;
                    if (hasLife && !isSelfChecking)
                        count++;
                }
            }
            return count;
        }

        private int CountNeighbors_field(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int col = x + i;
                    int row = y + j;
                    if (col >= 0 && row >= 0 && row < rows && col < cols)
                    {
                        var hasLife = field[col, row];
                        var isSelfChecking = col == x && row == y;
                        if (hasLife && !isSelfChecking)
                            count++;
                    }
                }
            }
            return count;
        }
        private int CountNeighbors_cylinder(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int col = (x + i + cols) % cols;
                    int row = y + j;
                    if (row >= 0 && row < rows)
                    {
                        var hasLife = field[col, row];
                        var isSelfChecking = col == x && row == y;
                        if (hasLife && !isSelfChecking)
                            count++;
                    }
                }
            }
            return count;
        }


        private void NextGeneration()
        {
            graphics.Clear(Color.Black);

            var newfierd = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        neighborsCount = CountNeighbors_field(x, y);
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        neighborsCount = CountNeighbors_cylinder(x, y);
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        neighborsCount = CountNeighbors_tor(x, y);
                    }
                    
                    var hasLife = field[x, y];

                    if (!hasLife && neighborsCount == 3)
                        newfierd[x, y] = true;
                    else if (hasLife && (neighborsCount < 2 || neighborsCount > 3))
                        newfierd[x, y] = false;
                    else newfierd[x, y] = field[x, y];
                    if (hasLife)
                        graphics.FillRectangle(Brushes.LightGreen, x * resolution2, y * resolution1, resolution2 - 1, resolution1 - 1);
                    else graphics.FillRectangle(Brushes.Gray, x * resolution2, y * resolution1, resolution2 - 1, resolution1 - 1);
                }
            }
            prew_field = field;
            field = newfierd;
            pictureBox1.Refresh();
            Text = $"Поколение {++countGeneration}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            b_off();
            interval = (int)nUD_interval.Value;
            timer1.Interval = interval;
            timer1.Start();
        }

        private void StopGame()
        {
            if (!timer1.Enabled)
                return;
            timer1.Stop();
            b_on();
        }

        private void b_stop_Click(object sender, EventArgs e)
        {
            StopGame();
        }
        private bool vMousePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {  
            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution2;
                var y = e.Location.Y / resolution1;
                if (vMousePosition(x, y))
                {
                    field[x, y] = true;
                    if (field[x, y])
                        graphics.FillRectangle(Brushes.LightGreen, x * resolution2, y * resolution1, resolution2 - 1, resolution1 - 1);
                    else graphics.FillRectangle(Brushes.Gray, x * resolution2, y * resolution1, resolution2 - 1, resolution1 - 1);
                    pictureBox1.Refresh();
                }

            }
            if(e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution2;
                var y = e.Location.Y / resolution1;
                if (vMousePosition(x, y))
                {
                    field[x, y] = false;
                    if (!field[x, y])
                        graphics.FillRectangle(Brushes.Gray, x * resolution2, y * resolution1, resolution2 - 1, resolution1 - 1);
                    else graphics.FillRectangle(Brushes.Gray, x * resolution2, y * resolution1, resolution2 - 1, resolution1 - 1);
                    pictureBox1.Refresh();
                }
            }
        }

        private void b_create_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            all_false(cols, rows);
            graphics.Clear(Color.Black);
            pictureBox1.Refresh();
            countGeneration = 0;
            Text = $"Поколение {countGeneration}";

        }

        private void b_step_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void linkLabel1_DoubleClick(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                namefail = saveFileDialog.FileName;
            }
            StreamWriter save = new StreamWriter(namefail);
            save.WriteLine(cols);
            save.WriteLine(rows);
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (prew_field[x, y])
                    {
                        save.WriteLine(x);
                        save.WriteLine(y);
                    }
                }
            }
            save.Close();
        }

        private void b_openfail_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                namefail = openFileDialog.FileName;
            }
        }
    }
}
