using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Portal_Speedrunning_Guide_App
{
    
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            //form2.Deactivate += form2_Deactivate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BGImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.Text = "Main Menu";
        }

        private void BTStart_Click(object sender, EventArgs e)
        {

            if (form2 == null)
            {
                form2 = new Form2();

                form2.FormClosed += form2_FormClosed;

                form2.Show();

                BTStart.Enabled = false;
            }

            
        }
        
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2 = null;
            BTStart.Enabled = true;
        }
    }
}
