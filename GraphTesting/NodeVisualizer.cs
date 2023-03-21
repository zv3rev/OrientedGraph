using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphTesting
{
    public enum StartOption
    {
        Add,
        Edit,
        Delete
    }
    
   

    public partial class NodeVisualizer : Form
    {
        public int nodeInformation;
        public int nodeId;

        public NodeVisualizer(StartOption startOption)
        {
            InitializeComponent();

            switch (startOption)
            {
                case StartOption.Add:
                    id.ReadOnly = true;
                    nodeInfo.ReadOnly = false;
                    break;
                case StartOption.Edit:
                    id.ReadOnly = true;
                    nodeInfo.ReadOnly = false;                    
                    break;
                case StartOption.Delete:
                    id.ReadOnly = false;
                    nodeInfo.ReadOnly = true;
                    break;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(nodeInfo.Text, out nodeInformation) && !Int32.TryParse(id.Text, out nodeId))
            {
                MessageBox.Show("Допущенна ошибка в одном из полей");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        public void UpdateInfo()
        {
            id.Text = nodeId.ToString();
            nodeInfo.Text = nodeInformation.ToString();
        }
    }
}
