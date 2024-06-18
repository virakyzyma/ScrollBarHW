namespace ScrollBarHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int value = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        this.Invoke(new EventHandler(delegate
                        {
                            button1.Left += 1;
                        }));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Thread.Sleep(100 - value);
                }
            });
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            value = hScrollBar1.Value;
        }
    }
}
