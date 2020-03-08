using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGameForm
{
    public partial class Name : Form
    {
        private string name;
        

        public Name()
        {
            InitializeComponent();
        }


        public string getName()
        {
            return name;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            
            Close();
        }
    }
}
