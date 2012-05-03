using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PoMToolkit
{
    public partial class BaseForm : Form
    {
        protected bool _saved;

        public bool Saved
        {
            get { return _saved; }
            set { }
        }

        public virtual void save()
        {
        }

        
        public BaseForm()
        {
            InitializeComponent();
        }
    }
}
