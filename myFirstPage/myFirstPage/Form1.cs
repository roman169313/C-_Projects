namespace myFirstPage
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //add your code here
            MessageBox.Show("welcome everybody in c# calss");
        }

        private void btnDisplay1_Click(object sender, EventArgs e)
        {
            //add your code here
            MessageBox.Show("exit yes");
            Application.Exit();//for program exits
            //this.close(); for this form exits.
        }
    }
}