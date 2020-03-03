using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        static Dictionary<CheckBox, Lamp> switches;
        static Dictionary<Label, Lamp> Counters;
        private ColorCounter cnt;

        public Form1()
        {
            InitializeComponent();
            switches = new Dictionary<CheckBox, Lamp>();
            Counters = new Dictionary<Label, Lamp>();
            switches.Add(checkBox1, new Lamp(lamp1));
            switches.Add(checkBox2, new Lamp(lamp2));
            switches.Add(checkBox3, new Lamp(lamp3));
            Counters.Add(lamp1Cnt, switches[checkBox1]);
            Counters.Add(lamp2Cnt, switches[checkBox2]);
            Counters.Add(lamp3Cnt, switches[checkBox3]);
            cnt = new ColorCounter(new Dictionary<Color, int>() { { lamp1.BackColor, 0 } });
            foreach (KeyValuePair<CheckBox, Lamp> l in switches)
            {
                l.Value.Observers += cnt.IncrementColor;
            }
            foreach (KeyValuePair<Label, Lamp> l in Counters)
            {
                l.Value.CntObservers += ((int k) => l.Key.Text = k.ToString());
            }
            label4.Text = cnt.getStats();
        }

        private void SwitchTurn(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == true)
            {
                switches[(CheckBox)sender].turnOn();
            }
            else switches[(CheckBox)sender].turnOff();
            label4.Text = cnt.getStats();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {            
            if (((CheckBox)sender).Checked == true)
            {
                foreach (KeyValuePair<CheckBox, Lamp> l in switches)
                {
                    l.Key.Checked = true;
                }
            }
            else
            {
                foreach (KeyValuePair<CheckBox, Lamp> l in switches)
                {                    
                    l.Key.Checked = false;                    
                }
            }
            label4.Text = cnt.getStats();
        }
    }
}
