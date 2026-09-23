namespace checkUsername
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            bool duzdur = true;

            if (username.Length < 8)
                duzdur = false;

            if (username.Contains("*") || username.Contains(" ") || username.Contains("#"))
                duzdur = false;

            if (char.IsDigit(username[0]))
                duzdur = false;

            bool boyukHerf = false;
            bool reqem = false;

            for (int i = 0; i < username.Length; i++)
            {
                if (char.IsUpper(username[i]))
                    boyukHerf = true;

                if (char.IsDigit(username[i]))
                    reqem = true;
            }

            if (boyukHerf == false)
                duzdur = false;

            if (reqem == false)
                duzdur = false;

            if (duzdur)
                MessageBox.Show("Username düzgündür");
            else
                MessageBox.Show("Username düzgün deyil");
        }
    }
}