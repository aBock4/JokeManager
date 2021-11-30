using JokeManagerNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace jokeGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            //clear the results
            goodResultlbl.Visible = false;
            badResultlbl.Visible = false;

            //declare Strings to hold user input
            String UCID;
            String joke;

            //get the contents of the TextBox 'UCIDtxt' into input String
            UCID = UCIDtxt.Text;

            //get the contents of the TextBox 'Joketxt into input String
            joke = Joketxt.Text;

            //Reference the JokeManager class
            //adds the joke to the database using the user input
            int status = JokeManager.SaveJoke(UCID, joke);

            //if added, show that it was a success else show that it was unsuccessful
            if(status == -1)
            {
                goodResultlbl.Visible = true;
            } else
            {
                badResultlbl.Visible = true;
            }
           
        }

    }
}
