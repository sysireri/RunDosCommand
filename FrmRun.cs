using System;
using System.Windows.Forms;

namespace _RunDosCommand
{
    public partial class FrmRun : Form
    {
        public FrmRun()
        {
            InitializeComponent();
        }

        private void butRun_Click(object sender, EventArgs e)
        {

            System.Diagnostics.ProcessStartInfo  objprocessStartInfo = new System.Diagnostics.ProcessStartInfo();
            try
            {
                objprocessStartInfo.CreateNoWindow = false;
                objprocessStartInfo.UseShellExecute = false;
                objprocessStartInfo.FileName = txtProgramm.Text.Trim();
                objprocessStartInfo.Arguments = txtArguments.Text;
                objprocessStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                System.Diagnostics.Process.Start(objprocessStartInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " +  ex.Message);
            }
            finally
            {
            }
        }
    }
}
