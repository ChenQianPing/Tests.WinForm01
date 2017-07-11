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
    public partial class ChildForm : Form
    {
        // 事件参数类
        public class TitleChangedEventArgs : EventArgs 
        {
            public string Title { get; set; } = "";
        }
        
        // 声明委托
        public delegate void TitleChangedEventHandler(object sender, TitleChangedEventArgs e);

        // 定义事件
        public event TitleChangedEventHandler TitleChanged;

        public ChildForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var e1 = new TitleChangedEventArgs {Title = "Login sucessed"};

            // 触发事件
            OnTitleChanged(e1);
        }

        // 触发事件的方法
        protected virtual void OnTitleChanged(TitleChangedEventArgs e)
        {
            TitleChanged?.Invoke(this, e);
        }
    }
}
