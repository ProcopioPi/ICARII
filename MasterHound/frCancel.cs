using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasterHound
{
    public partial class frCancel : Form
    {
        public PictureBox _CANVAS;

        public frCancel()
        {
            InitializeComponent();

            _CANVAS = PCT_CANVAS;
        }
    }
}
