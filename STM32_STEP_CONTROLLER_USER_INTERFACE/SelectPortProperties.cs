using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Design_Project
{
    public partial class SelectPortProperties : Form
    {
        string[] ports;

        public SelectPortProperties()
        {
            InitializeComponent();
        }

        private void Baglanti_Load(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames();
            cB_serialPort.Items.AddRange(ports);
            if (cB_serialPort.Items.Count != 0) cB_serialPort.SelectedIndex = 0;

            cB_baundRate.SelectedIndex = 6;
            cB_DataBits.SelectedIndex = 3;
            cB_Parity.SelectedIndex = 0;
        }

        private void btn_reflesh_Click(object sender, EventArgs e)
        {
            ports = null;
            cB_serialPort.Text = String.Empty;
            cB_serialPort.Items.Clear();

            ports = SerialPort.GetPortNames();
            cB_serialPort.Items.AddRange(ports);
            if (cB_serialPort.Items.Count != 0) cB_serialPort.SelectedIndex = 0;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if ((cB_serialPort.Items.Count != 0) && (cB_baundRate.Items.Count != 0))
            {
                Controller controller = new Controller();
                ModeSelect modeSelect = new ModeSelect(ref controller, Convert.ToString(cB_serialPort.SelectedItem), Convert.ToInt32(cB_baundRate.SelectedItem), Convert.ToInt32(cB_DataBits.SelectedItem), Static.StringToParity(Convert.ToString(cB_Parity.SelectedItem)));
                modeSelect.Show();
                this.Hide();
            }
        }

        private void SerialReadAndWrite_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            //Environment.Exit(0);
        }
    }
}
