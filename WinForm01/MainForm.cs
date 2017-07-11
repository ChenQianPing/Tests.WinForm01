using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm01
{
    public partial class MainForm : Form
    {
        private readonly ChildForm _loginForm = new ChildForm();

        public MainForm()
        {
            InitializeComponent();

            _loginForm.TitleChanged +=
                new ChildForm.TitleChangedEventHandler(FormTitleChanged);
        }

        protected void FormTitleChanged(object sender, ChildForm.TitleChangedEventArgs e)
        {
            this.Text = e.Title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
        }

    }
}
