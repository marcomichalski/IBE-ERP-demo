using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPdemo
{
    public partial class NotifyBox : Form
    {
        public NotifyBox(string message, string title)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;// Or wherever 

            
            lblMessage.Text = "\r\n" + message;
            this.Text = title;
        }

        
       
    }
}
