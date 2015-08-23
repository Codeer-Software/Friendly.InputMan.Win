using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Target
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void ConnectTextBoxTextChanged()
        {
            _textBox.TextChanged += delegate { MessageBox.Show(""); };
        }
        void ConnectComboBoxTextChanged()
        {
            _comboBox.TextChanged += delegate { MessageBox.Show(""); };
        }
        void ConnectComboBoxTextMaxLengthChanged()
        {
            _comboBox.TextChanged += delegate { MessageBox.Show(""); };
        }
        void ConnectMultiLineTextBoxChanged()
        {
            _multiLineText.TextChanged += delegate { MessageBox.Show(""); };
        }
        void ConnectSJISTextBoxTextChanged()
        {
            _textBoxShiftJIS.TextChanged += delegate { MessageBox.Show(""); };
        }
        void ConnectSJISComboBoxTextChanged()
        {
            _comboBox_ShiftJIS.TextChanged += delegate { MessageBox.Show(""); };
        }
    }
}
