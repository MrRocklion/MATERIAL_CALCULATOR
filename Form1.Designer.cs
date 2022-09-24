namespace MATERIAL_CALCULATOR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.num2 = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSum = new MaterialSkin.Controls.MaterialButton();
            this.num1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.result = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 201);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 346);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.43396F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.56604F));
            this.tableLayoutPanel2.Controls.Add(this.num2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSum, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.num1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.result, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(265, 346);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.AnimateReadOnly = false;
            this.num2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.num2, 2);
            this.num2.Depth = 0;
            this.num2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.num2.Hint = "Número 2";
            this.num2.LeadingIcon = null;
            this.num2.Location = new System.Drawing.Point(13, 143);
            this.num2.MaxLength = 50;
            this.num2.MouseState = MaterialSkin.MouseState.OUT;
            this.num2.Multiline = false;
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(239, 50);
            this.num2.TabIndex = 3;
            this.num2.Text = "";
            this.num2.TrailingIcon = null;
            // 
            // btnSum
            // 
            this.btnSum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.SetColumnSpan(this.btnSum, 2);
            this.btnSum.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSum.Depth = 0;
            this.btnSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSum.HighEmphasis = true;
            this.btnSum.Icon = null;
            this.btnSum.Location = new System.Drawing.Point(14, 211);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSum.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSum.Name = "btnSum";
            this.btnSum.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSum.Size = new System.Drawing.Size(237, 53);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "sumar";
            this.btnSum.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSum.UseAccentColor = false;
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // num1
            // 
            this.num1.AnimateReadOnly = false;
            this.num1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.num1, 2);
            this.num1.Depth = 0;
            this.num1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.num1.Hint = "Número 1";
            this.num1.LeadingIcon = null;
            this.num1.Location = new System.Drawing.Point(13, 78);
            this.num1.MaxLength = 50;
            this.num1.MouseState = MaterialSkin.MouseState.OUT;
            this.num1.Multiline = false;
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(239, 50);
            this.num1.TabIndex = 2;
            this.num1.Text = "";
            this.num1.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel2.SetColumnSpan(this.materialLabel1, 2);
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Location = new System.Drawing.Point(13, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel1.Size = new System.Drawing.Size(239, 65);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Suma Dos Números";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(13, 270);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(115, 66);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Resultado:";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Depth = 0;
            this.result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.result.Location = new System.Drawing.Point(134, 270);
            this.result.MouseState = MaterialSkin.MouseState.HOVER;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(118, 66);
            this.result.TabIndex = 6;
            this.result.Text = "0";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton btnSum;
        private MaterialSkin.Controls.MaterialTextBox num1;
        private MaterialSkin.Controls.MaterialTextBox num2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel result;
    }
}