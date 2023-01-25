using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorApplication
{
    class Sensor
    {
        /*double dVal;
        int sId;
        Random rSenVal;
        public Sensor(int id)
        {
            sId = id;
            rSenVal = new Random(10);
            MessageBox.Show(id.ToString());
            dVal = 0.0F;
        }
        public double GetValue()
        {
            dVal += rSenVal.Next(10);
            MessageBox.Show(dVal.ToString());
            return dVal;
        }
        public int GetSensId()
        {
            return sId;
        }*/

        public double analog_value(int id) {
            Random rnd = new Random();
            return ((rnd.NextDouble() + id*1.0F)-(-5))/(5-(-5));
        }

        public int digital_value() {
            int[] volt = new int[] {-5 , 5};
            Random random = new Random();
            return volt[random.Next(2)];
        }

        public string[] date_time(int delay_time) {
            DateTime now = DateTime.Now;
            string[] date_time_details = new string[2];
            date_time_details[0] = now.Year.ToString() + "." + now.Month.ToString("00") + "." + now.Day.ToString("00") + " at " ;
            int Hr = now.Hour;
            if (Hr < 13)
            {
                date_time_details[0] = date_time_details[0] + Hr.ToString("00") + ":" + now.Minute.ToString("00") + ":" + now.Second.ToString("00") + "." + now.Millisecond.ToString("000") + " AM";
            }
            else
            {
                date_time_details[0] = date_time_details[0] + (Hr - 12).ToString("00") + ":" + now.Minute.ToString("00") + ":" + now.Second.ToString("00") + "." + now.Millisecond.ToString("000") + " PM";
            }


            now = now.AddMilliseconds(delay_time);
            Hr = now.Hour;
            if (Hr < 13)
            {
                date_time_details[1] = Hr.ToString("00") + ":" + now.Minute.ToString("00") + ":" + now.Second.ToString("00") + "." + now.Millisecond.ToString("000") + " AM";
            }
            else
            {
                date_time_details[1] = (Hr - 12).ToString("00") + ":" + now.Minute.ToString("00") + ":" + now.Second.ToString("00") + "." + now.Millisecond.ToString("000") + " PM";
            }
            return date_time_details;
        }
    }
}
