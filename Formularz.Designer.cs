
namespace FormularzDanych
{
    partial class Formularz
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonWczytaj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            int y = 10;
            for (int i = 1; i <= 15; i++)
            {
                var tb = this.Controls["textBox" + i] as System.Windows.Forms.TextBox;
                tb.Location = new System.Drawing.Point(10, y);
                tb.Width = 400;
                y += 25;
            }
            this.buttonZapisz.Location = new System.Drawing.Point(450, 10);
            this.buttonZapisz.Size = new System.Drawing.Size(120, 30);
            this.buttonZapisz.Text = "Zapisz do bazy";
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            this.buttonWczytaj.Location = new System.Drawing.Point(450, 50);
            this.buttonWczytaj.Size = new System.Drawing.Size(120, 30);
            this.buttonWczytaj.Text = "Wczytaj dane";
            this.buttonWczytaj.Click += new System.EventHandler(this.buttonWczytaj_Click);
            this.dataGridView1.Location = new System.Drawing.Point(10, 400);
            this.dataGridView1.Size = new System.Drawing.Size(600, 200);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.buttonWczytaj);
            for (int i = 1; i <= 15; i++)
            {
                this.Controls.Add(this.Controls["textBox" + i]);
            }
            this.ClientSize = new System.Drawing.Size(640, 620);
            this.Text = "Formularz danych";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonWczytaj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
    }
}
