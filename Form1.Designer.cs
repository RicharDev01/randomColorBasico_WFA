
namespace RandomColor
{
  partial class ColorPicker
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnRandom = new System.Windows.Forms.Button();
      this.txtRGB = new System.Windows.Forms.Label();
      this.btnCopy = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnRandom
      // 
      this.btnRandom.Location = new System.Drawing.Point(79, 44);
      this.btnRandom.Name = "btnRandom";
      this.btnRandom.Size = new System.Drawing.Size(105, 50);
      this.btnRandom.TabIndex = 0;
      this.btnRandom.Text = "Random";
      this.btnRandom.UseVisualStyleBackColor = true;
      this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
      // 
      // txtRGB
      // 
      this.txtRGB.AutoSize = true;
      this.txtRGB.BackColor = System.Drawing.SystemColors.ControlLight;
      this.txtRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
      this.txtRGB.Location = new System.Drawing.Point(46, 139);
      this.txtRGB.Name = "txtRGB";
      this.txtRGB.Size = new System.Drawing.Size(0, 25);
      this.txtRGB.TabIndex = 1;
      // 
      // btnCopy
      // 
      this.btnCopy.Location = new System.Drawing.Point(92, 201);
      this.btnCopy.Name = "btnCopy";
      this.btnCopy.Size = new System.Drawing.Size(80, 27);
      this.btnCopy.TabIndex = 2;
      this.btnCopy.Text = "copiar color";
      this.btnCopy.UseVisualStyleBackColor = true;
      this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
      // 
      // ColorPicker
      // 
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.btnCopy);
      this.Controls.Add(this.txtRGB);
      this.Controls.Add(this.btnRandom);
      this.Name = "ColorPicker";
      this.Text = "Random Color";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnRandom;
    private System.Windows.Forms.Label txtRGB;
    private System.Windows.Forms.Button btnCopy;
  }
}

