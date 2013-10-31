
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace prac5
{
	
	public partial class MainForm : Form
	{
		double peso, dol, conver;
		
		public MainForm()
		{
			
			InitializeComponent();
			
		}
			
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
		
        void Button1Click(object sender, EventArgs e){
			
          if(double.TryParse(textBox1.Text, out peso) &&
			double.TryParse(textBox2.Text, out conver)
            && peso!=0 && conver!=0){

         dol = peso/conver;
         
		textBox3.Text = dol.ToString();
        }

       else{
       MessageBox.Show("Error con los datos");
			}
		}
	}
}
