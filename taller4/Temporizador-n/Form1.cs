using System.Diagnostics;

namespace Temporizador_n
{
    public partial class Form1 : Form
    {
        Thread trd;
        int second = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            txtComentario.Text = txtComentario.Text + "\r\n" + DateTime.Now.ToString() + " |Ejecutando tarea de sincronizacion de Datos DEMO |";
            second = second + 1;
            if (second >= 10)
            {
                timer1.Stop();
                MessageBox.Show("Exiting timer...");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            CheckForIllegalCrossThreadCalls = false;
            Thread trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();
        }

        void ThreadTask()
        {
            try
            {
                int stp;
                int newval;
                Random rnd = new Random();
                while (true)
                {
                    stp = this.pBAvance.Step * rnd.Next(0, 5);
                    newval = this.pBAvance.Value + stp;
                    if (newval > this.pBAvance.Maximum)
                        newval = this.pBAvance.Maximum;
                    else if (newval < this.pBAvance.Minimum)
                        newval = this.pBAvance.Minimum;
                    this.pBAvance.Value = newval;
                    Thread.Sleep(100);
                    lblAvance.Text = newval.ToString() + " MB procesados...";
                    if (newval >= pBAvance.Maximum)
                    {
                        lblAvance.Text = newval.ToString() + " MB procesados... Proceso terminado";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepcion registrada");
            }
        }


    }
}