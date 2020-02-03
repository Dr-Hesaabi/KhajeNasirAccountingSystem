using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhajeNasirAccountingSystemUserClient
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Point enter_point;
        bool mouse_down;
        private void Main_Load(object sender, EventArgs e)
        {
            this.Controls.Add(new Controls.Lists { Dock = DockStyle.Top });

            this.Controls.Add(new Controls.Numerics { Dock = DockStyle.Top });

            this.Controls.Add(new Controls.UserProfile { Dock = DockStyle.Top });



            //Label FormBorder = new Label();
            //FormBorder.TextAlign = ContentAlignment.MiddleCenter;
            //FormBorder.BackColor = Color.Red;
            //FormBorder.ForeColor = Color.White;
            //FormBorder.Dock = DockStyle.Top;
            //FormBorder.MouseMove += delegate
            //{
            //    if (mouse_down)
            //    {
            //        Location = Cursor.Position;
            //    }
            //};
            //FormBorder.MouseDown += delegate
            //{
            //    enter_point = Cursor.Position;
            //    mouse_down = true;
            //};
            //FormBorder.MouseUp += delegate
            //{
            //    mouse_down = false;
            //};
            //this.Controls.Add(FormBorder);
        }
    }
}
