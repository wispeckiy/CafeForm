using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CafeForm.Classes
{
    public class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            
            foreach (Control control in form.Controls)
            {
                if(control is Label)
                {
                    Label label = (Label)control;
                    label.Text = "";
                }
                if(control is Button)
                {
                    Button button = (Button)control;
                    button.Enabled = false;
                    button.Visible = false;
                }
                if(control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.Visible = false;
                }
            }
        }

        public static void ResetEndRoundControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if(control.Name == "WinLoseimg")control.Visible = true;
                if(control.Name == "button5")control.Enabled = true;
                if (control.Name == "button5") control.Visible = true;
                if (control.Name == "button1") control.Enabled = false;
                if (control.Name == "button2") control.Enabled = false;
                if (control.Name == "button3") control.Enabled = false;
            }
        }
    }
}
