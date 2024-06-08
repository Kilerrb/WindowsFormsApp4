using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form4 : Form
    {
  
        private int count = 0;

        public Form4()
        {
            InitializeComponent();
            serialPort2.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);


        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
         
            string indata = serialPort2.ReadLine();
            this.Invoke(new MethodInvoker(delegate {
                labelcount.Text = "Person(s) In Room: " + indata;
            }));
        }

       

        private void label_count_Click(object sender, EventArgs e)
        {
            count++;
            Label label = sender as Label;
            if (label != null)
            {
                label.Text = $"Person(s) in Room: {count}";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // يمكن تركه فارغًا إذا لم يكن هناك حاجة إلى تحميل إضافي
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            foreach (string port in SerialPort.GetPortNames())
            {
                try
                {
                    serialPort2.PortName = port;
                    serialPort2.Open();
                    if (serialPort2.IsOpen)
                    {
                        status.Text = "Connection Status: Connected";
                    }
                }
                catch (Exception x)
                {
                    
                }

            }
        }
    }
}
