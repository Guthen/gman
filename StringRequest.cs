using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gman
{
    public partial class StringRequest : Form
    {
        public StringRequest()
        {
            InitializeComponent();
            CenterToParent();
        }

        public string GetText() => tb_string_request.Text;
        public void SetTitle( string title )
        {
            l_title.Text = title;
            this.Text = title;
        }

        private void b_ok_Click( object sender, EventArgs e ) 
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void b_cancel_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
