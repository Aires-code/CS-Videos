using System;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace Softwaredevelopment
{
   public partial class Form1 : Form
   {
      static void Main()
      {
        Form Form1 = new Form();
        Form1.Name = "App. Video 1";
        TextBox Label1 = new TextBox();
        Button Button1 = new Button();

        Button1.Location = new System.Drawing.Point(0, 0);
        Button1.AutoSize = true;
        Button1.Text = "Button";

        Label1.Location = new System.Drawing.Point(0, 20);
        Label1.AutoSize = true;
        Label1.Text = "Input";
        

      Form1.Controls.Add(Button1);
      Form1.Controls.Add(Label1);
      Form1.ShowDialog();
        }
    }
}
