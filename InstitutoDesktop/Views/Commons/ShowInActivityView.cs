using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDesktop.Views.Commons
{
    public partial class ShowInActivityView : Form
    {
        public string Message
        {
            set
            {
                lblMessage.Text = value;
            }
        }

        public ShowInActivityView()
        {
            InitializeComponent();
            this.TopMost = true; // Establece la ventana como siempre en la parte superior


        }
    }
}
