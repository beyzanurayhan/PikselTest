using System.Diagnostics;

namespace PikselTest
{
    public partial class PikselTestForm : Form
    {
        public PikselTestForm()
        {
            InitializeComponent();
        }

        private void PikselTestForm_Load(object sender, EventArgs e)
        {
            

        }



        private void btn_black_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_black.Dock = DockStyle.Fill;
            btn_black.BringToFront();
            MessageBox.Show("Çıkmak için escape tuşuna basınız.");

        }

        private void btn_white_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_white.Dock = DockStyle.Fill;
            btn_white.BringToFront();
            MessageBox.Show("Çıkmak için escape tuşuna basınız.");
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_red.Dock = DockStyle.Fill;
            btn_red.BringToFront();
            MessageBox.Show("Çıkmak için escape tuşuna basınız.", "Piksel Testi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_green.Dock = DockStyle.Fill;
            btn_green.BringToFront();
            MessageBox.Show("Çıkmak için escape tuşuna basınız.", "Piksel Testi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_blue.Dock = DockStyle.Fill;
            btn_blue.BringToFront();
            MessageBox.Show("Çıkmak için escape tuşuna basınız.", "Piksel Testi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_yellow.Dock = DockStyle.Fill;            
            btn_yellow.BringToFront();
            MessageBox.Show("Çıkmak için escape tuşuna basınız.", "Piksel Testi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_turquoise_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_turquoise.Dock = DockStyle.Fill;
            btn_turquoise.BringToFront();
            MessageBox.Show("Çıkmak için escape tuşuna basınız.", "Piksel Testi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_purple_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_purple.Dock = DockStyle.Fill;
            btn_purple.BringToFront();
            MessageBox.Show("Çıkmak için escape tuşuna basınız.", "Piksel Testi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_gray_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_gray.Dock = DockStyle.Fill;
            btn_gray.BringToFront();
            MessageBox.Show("Çıkmak için escape tuşuna basınız.", "Piksel Testi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btn_black_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_black.Dock = DockStyle.None;
                btn_black.SendToBack();

                Size = new Size(410, 437);
            }
        }

        private void btn_white_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_white.Dock = DockStyle.None;
                btn_white.SendToBack();
            }
        }

        private void btn_red_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_red.Dock = DockStyle.None;
                btn_red.SendToBack();
            }
        }

        private void btn_green_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_green.Dock = DockStyle.None;
                btn_green.SendToBack();
            }
        }

        private void btn_blue_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_blue.Dock = DockStyle.None;
                btn_blue.SendToBack();
            }
        }

        private void btn_yellow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_yellow.Dock = DockStyle.None;
                btn_yellow.SendToBack();
            }
        }

        private void btn_turquoise_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_turquoise.Dock = DockStyle.None;
                btn_turquoise.SendToBack();
            }
        }

        private void btn_purple_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_purple.Dock = DockStyle.None;
                btn_purple.SendToBack();
            }
        }

        private void btn_gray_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_gray.Dock = DockStyle.None;
                btn_gray.SendToBack();
            }
        }

        private void btn_startTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test işlemine başlamadan önce lütfen ekranınızın temiz olduğundan emin olunuz.", "Piksel Testi",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}