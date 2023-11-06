using System.IO.Ports;

namespace Bluetooth
{
    public partial class Form1 : Form
    {
        SerialPort bluetoothConnection = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            UpdateAvailableDevices();
        }

        private void UpdateAvailableDevices()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxDevices.Items.AddRange(ports);

            if (comboBoxDevices.Items.Count > 0)
            {
                comboBoxDevices.SelectedIndex = comboBoxDevices.Items.Count - 1;
            }
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            {
                if (comboBoxDevices.SelectedItem == null)
                {
                    MessageBox.Show("Please select a device to connect.");
                    return;
                }

                string selectedPort = comboBoxDevices.SelectedItem.ToString();

                if (!bluetoothConnection.IsOpen)
                {
                    bluetoothConnection.PortName = selectedPort;
                    bluetoothConnection.BaudRate = 9600; // Set your appropriate baud rate

                    try
                    {
                        bluetoothConnection.Open();
                        lblStatus.Text = "Connected to " + selectedPort;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Already connected to a device. Disconnect first.");
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (bluetoothConnection.IsOpen)
            {
                bluetoothConnection.Close();
                lblStatus.Text = "Disconnected";
            }
            else
            {
                MessageBox.Show("No device is currently connected.");
            }
        }

        private void updateDevices_Click(object sender, EventArgs e)
        {
            comboBoxDevices.Items.Clear();
            UpdateAvailableDevices();
        }
    }
}