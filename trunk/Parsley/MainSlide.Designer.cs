﻿namespace Parsley {
  partial class MainSlide {
    /// <summary> 
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary> 
    /// Erforderliche Methode für die Designerunterstützung. 
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSlide));
      this._btn_example = new Parsley.UI.ParsleyButton();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // _btn_example
      // 
      this._btn_example.Anchor = System.Windows.Forms.AnchorStyles.None;
      this._btn_example.BackColor = System.Drawing.Color.White;
      this._btn_example.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
      this._btn_example.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this._btn_example.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._btn_example.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this._btn_example.Image = ((System.Drawing.Image)(resources.GetObject("_btn_example.Image")));
      this._btn_example.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this._btn_example.Location = new System.Drawing.Point(88, 178);
      this._btn_example.Name = "_btn_example";
      this._btn_example.Size = new System.Drawing.Size(300, 60);
      this._btn_example.TabIndex = 0;
      this._btn_example.Text = "Run Examples";
      this._btn_example.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this._btn_example.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this._btn_example.UseVisualStyleBackColor = true;
      this._btn_example.Click += new System.EventHandler(this._btn_example_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this._btn_example, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 417);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // MainSlide
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "MainSlide";
      this.Size = new System.Drawing.Size(477, 417);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Parsley.UI.ParsleyButton _btn_example;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  }
}
