using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace SensorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            int row, col;
            for (row = 0; row < maxSid; row++)
            {
                for (col = 0; col < moving_avg_size - 1; col++)
                {
                    an_sensor_history[row, col] = an_sensor_history[row, col + 1];
                }
            }

            //Get analog values
            for (row = 0; row < maxSid; row++)
            {
                an_sensor_history[row, moving_avg_size - 1] = Sensor_values.analog_value(row);
                an_sensor_avg[row, 0] = 0;//Set average value array into zero

                for (col = 0; col < moving_avg_size; col++)
                {
                    an_sensor_avg[row, 0] = an_sensor_avg[row, 0] + an_sensor_history[row, col];
                }
                an_sensor_avg[row, 0] = an_sensor_avg[row, 0] / moving_avg_size;
                string tb_name = "txtAn" + (row + 1).ToString();
                TextBox tb = Controls.Find(tb_name, true).FirstOrDefault() as TextBox;
                if (tb != null) tb.Text = an_sensor_avg[row, 0].ToString("F3");
            }

            //Get digital values
            dg_sensor = Sensor_values.digital_value();
            txtDg1.Text = dg_sensor.ToString();

            //Date and time
            string[] date_time_details = new string[2];
            date_time_details = Sensor_values.date_time(sampling_interval);
            txt_rec_time.Text = date_time_details[0];
            txtSamplingTime.Text = date_time_details[1];

            timerSampling.Interval = sampling_interval; // here time in milliseconds
            //timerSampling.Tick += timerSampling_Tick;
            timerSampling.Start();
            btnSampling.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //Define global variables
        static int moving_avg_size = 4;
        static int maxSid = 2;
        double[,] an_sensor_history = new double[maxSid, moving_avg_size];
        double[,] an_sensor_avg = new double[maxSid, 1];
        double dg_sensor;
        int sampling_interval = 1200;//Miliseconds
        int logging_interval = 52000;//Miliseconds
        Sensor Sensor_values = new Sensor();//Define sensor object

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Intialization sensor values
            int row,col;
            for (row = 0; row < maxSid; row++)
            {
                for (col = 0; col < moving_avg_size; col++)
                {
                    an_sensor_history[row, col] = 0.0F;
                }
            }  
        }

        private void timerSampling_Tick(object sender, EventArgs e)
        {
            btnSampling.Enabled = true;
            timerSampling.Stop();
            if (radioContSam.Checked)
            {              
                btnSampling.PerformClick();
                btnSampling.Enabled = false;
            }

        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            String file_name = "log_data.csv";
            String path = Environment.CurrentDirectory + "/" + file_name;
            if (!File.Exists(path))
            {
                File.CreateText(path);
                MessageBox.Show("File created success");
                
            }



            if (txtAn1.Text == "") {
                MessageBox.Show("No sensor values are found to log");
            }
            else {
                try
                {
                    txtFileName.Text = file_name;
                    string newline = txtAn1.Text + " , " + txtAn2.Text + " , " + txtDg1.Text + " , " + txt_rec_time.Text;
                    using (StreamWriter sw = new StreamWriter(path, append: true))
                    {
                        sw.WriteLine(newline); 
                    }
                    string[] date_time_details = new string[2];
                    date_time_details = Sensor_values.date_time(logging_interval);
                    txtLoggingTime.Text = date_time_details[1];
                    timerLogging.Interval = logging_interval; // here time in milliseconds
                    timerLogging.Start();
                    btnLogging.Enabled = false;
                    int lines = File.ReadAllLines(path).Length;
                    txtNoRec.Text = lines.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("File is open cannot access the file");
                    return;
                }
            }
        }

        private void timerLogging_Tick(object sender, EventArgs e)
        {
            btnLogging.Enabled = true;
            timerLogging.Stop();
            if (radioContLog.Checked)
            {
                btnLogging.PerformClick();
                btnLogging.Enabled = false;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is connected to the two analog sensors and one digital sensor. Sampling time is 1.2 seconds and loggin time is 52 seconds. Digital sensor voltage range is from -5V to 5V. Moving average filter with 4 samples have been used for filtering analog signal","Input Information", System.Windows.Forms.MessageBoxButtons.OK);
        }
    }
}
