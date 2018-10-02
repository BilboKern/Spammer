using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace MessageSpammer
{
    public partial class spammer : Form
    {
        public spammer()
        {
            InitializeComponent();

        }
        InputSimulator inputSim = new InputSimulator();

        private void start_Click(object sender, EventArgs e)
        {
       
            String text = message.Text;
            int times = Convert.ToInt32(spamtimes.Text);
            int delays = Convert.ToInt16(delay.Text);
            if(delays < 20 || delays > 100) delays = 30;
            delays = delays * 1000;
            if (text == "" || text == null) text = "Spam!";
            System.Threading.Thread.Sleep(delays);
            for (int i = times; i >= 1; i--){
                inputSim.Keyboard.TextEntry(text);
                inputSim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
