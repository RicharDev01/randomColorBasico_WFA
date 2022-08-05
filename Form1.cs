using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomColor
{
  public partial class ColorPicker : Form
  {
    public ColorPicker()
    {
      InitializeComponent();
    }

    private void btnRandom_Click(object sender, EventArgs e)
    {
      Random ran = new Random();

      int numRed = ran.Next(255);
      int numGreen = ran.Next(255);
      int numBlue = ran.Next(255);

      this.BackColor = Color.FromArgb(numRed, numGreen, numBlue);

      txtRGB.Text = $"RGB({numRed}, {numGreen}, {numBlue})";

    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
      Clipboard.SetData(DataFormats.Text, txtRGB.Text);
      DialogResult msg = MessageBox.Show($"Color {txtRGB.Text} copiado", "Portapapeles", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
