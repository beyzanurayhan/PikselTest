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
            MessageBox.Show("Test işlemine başlamadan önce lütfen ekranınızın temiz olduğundan emin olunuz.");
        }
        

        private void btn_black_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_black.Dock = DockStyle.Fill;
            btn_white.Visible = false;
            btn_red.Visible = false;
            btn_green.Visible = false;
            btn_blue.Visible = false;
            btn_yellow.Visible = false;
            btn_turquoise.Visible = false;
            btn_purple.Visible = false;
            btn_gray.Visible = false;
            MessageBox.Show("Çıkmak için escape tuşuna basınız.");

        }

        private void btn_white_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_white.Dock = DockStyle.Fill;
            btn_black.Visible = false;
            btn_red.Visible = false;
            btn_green.Visible = false;
            btn_blue.Visible = false;
            btn_yellow.Visible = false;
            btn_turquoise.Visible = false;
            btn_purple.Visible = false;
            btn_gray.Visible = false;
            MessageBox.Show("Çıkmak için escape tuşuna basınız.");
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_red.Dock = DockStyle.Fill;
            btn_black.Visible = false;
            btn_white.Visible = false;
            btn_green.Visible = false;
            btn_blue.Visible = false;
            btn_yellow.Visible = false;
            btn_turquoise.Visible = false;
            btn_purple.Visible = false;
            btn_gray.Visible = false;
            MessageBox.Show("Çıkmak için escape tuşuna basınız.");
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_green.Dock = DockStyle.Fill;
            btn_black.Visible = false;
            btn_red.Visible = false;
            btn_white.Visible = false;
            btn_blue.Visible = false;
            btn_yellow.Visible = false;
            btn_turquoise.Visible = false;
            btn_purple.Visible = false;
            btn_gray.Visible = false;
            MessageBox.Show("Çıkmak için escape tuşuna basınız.");
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_blue.Dock = DockStyle.Fill;
            btn_black.Visible = false;
            btn_red.Visible = false;
            btn_green.Visible = false;
            btn_white.Visible = false;
            btn_yellow.Visible = false;
            btn_turquoise.Visible = false;
            btn_purple.Visible = false;
            btn_gray.Visible = false;
            MessageBox.Show("Çıkmak için escape tuşuna basınız.");
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_yellow.Dock = DockStyle.Fill;
            btn_black.Visible = false;
            btn_red.Visible = false;
            btn_green.Visible = false;
            btn_blue.Visible = false;
            btn_white.Visible = false;
            btn_turquoise.Visible = false;
            btn_purple.Visible = false;
            btn_gray.Visible = false;
            MessageBox.Show("Çıkmak için escape tuşuna basınız.");
        }

        private void btn_turquoise_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_turquoise.Dock = DockStyle.Fill;
            btn_black.Visible = false;
            btn_red.Visible = false;
            btn_green.Visible = false;
            btn_blue.Visible = false;
            btn_yellow.Visible = false;
            btn_white.Visible = false;
            btn_purple.Visible = false;
            btn_gray.Visible = false;
            MessageBox.Show("Çıkmak için escape tuşuna basınız.");
        }

        private void btn_purple_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_purple.Dock = DockStyle.Fill;
            btn_black.Visible = false;
            btn_red.Visible = false;
            btn_green.Visible = false;
            btn_blue.Visible = false;
            btn_yellow.Visible = false;
            btn_turquoise.Visible = false;
            btn_white.Visible = false;
            btn_gray.Visible = false;
            MessageBox.Show("Çıkmak için escape tuşuna basınız.");
        }

        private void btn_gray_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            btn_gray.Dock = DockStyle.Fill;
            btn_black.Visible = false;
            btn_red.Visible = false;
            btn_green.Visible = false;
            btn_blue.Visible = false;
            btn_yellow.Visible = false;
            btn_turquoise.Visible = false;
            btn_purple.Visible = false;
            btn_white.Visible = false;
            MessageBox.Show("Çıkmak için escape tuşuna basınız.");
        }


        private void btn_black_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_black.Dock = DockStyle.None;
                btn_white.Visible = true;
                btn_red.Visible = true;
                btn_green.Visible = true;
                btn_blue.Visible = true;
                btn_yellow.Visible = true;
                btn_turquoise.Visible = true;
                btn_purple.Visible = true;
                btn_gray.Visible = true;
            }
        }

        private void btn_white_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_white.Dock = DockStyle.None;
                btn_black.Visible = true;
                btn_red.Visible = true;
                btn_green.Visible = true;
                btn_blue.Visible = true;
                btn_yellow.Visible = true;
                btn_turquoise.Visible = true;
                btn_purple.Visible = true;
                btn_gray.Visible = true;
            }
        }

        private void btn_red_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_red.Dock = DockStyle.None;
                btn_black.Visible = true;
                btn_white.Visible = true;
                btn_green.Visible = true;
                btn_blue.Visible = true;
                btn_yellow.Visible = true;
                btn_turquoise.Visible = true;
                btn_purple.Visible = true;
                btn_gray.Visible = true;
            }
        }

        private void btn_green_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_green.Dock = DockStyle.None;
                btn_black.Visible = true;
                btn_white.Visible = true;
                btn_red.Visible = true;
                btn_blue.Visible = true;
                btn_yellow.Visible = true;
                btn_turquoise.Visible = true;
                btn_purple.Visible = true;
                btn_gray.Visible = true;
            }
        }

        private void btn_blue_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_blue.Dock = DockStyle.None;
                btn_black.Visible = true;
                btn_white.Visible = true;
                btn_green.Visible = true;
                btn_red.Visible = true;
                btn_yellow.Visible = true;
                btn_turquoise.Visible = true;
                btn_purple.Visible = true;
                btn_gray.Visible = true;
            }
        }

        private void btn_yellow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_yellow.Dock = DockStyle.None;
                btn_black.Visible = true;
                btn_white.Visible = true;
                btn_green.Visible = true;
                btn_blue.Visible = true;
                btn_red.Visible = true;
                btn_turquoise.Visible = true;
                btn_purple.Visible = true;
                btn_gray.Visible = true;
            }
        }

        private void btn_turquoise_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_turquoise.Dock = DockStyle.None;
                btn_black.Visible = true;
                btn_white.Visible = true;
                btn_green.Visible = true;
                btn_blue.Visible = true;
                btn_yellow.Visible = true;
                btn_red.Visible = true;
                btn_purple.Visible = true;
                btn_gray.Visible = true;
            }
        }

        private void btn_purple_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_purple.Dock = DockStyle.None;
                btn_black.Visible = true;
                btn_white.Visible = true;
                btn_green.Visible = true;
                btn_blue.Visible = true;
                btn_yellow.Visible = true;
                btn_red.Visible = true;
                btn_turquoise.Visible = true;
                btn_gray.Visible = true;
            }
        }

        private void btn_gray_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                btn_gray.Dock = DockStyle.None;
                btn_black.Visible = true;
                btn_white.Visible = true;
                btn_green.Visible = true;
                btn_blue.Visible = true;
                btn_yellow.Visible = true;
                btn_red.Visible = true;
                btn_turquoise.Visible = true;
                btn_purple.Visible = true;
            }
        }
    }
}