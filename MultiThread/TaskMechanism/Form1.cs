namespace TaskMechanism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(counter);
            MessageBox.Show("Bitti");
        }

        async Task counter()
        {
            for (int i = 0; i <= 10000; i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = (i / 100);
            }
            //return Task.CompletedTask;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Parallel.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HEa");
        }
    }
}