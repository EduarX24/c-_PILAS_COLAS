
namespace pilas
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.rbPop = new System.Windows.Forms.RadioButton();
            this.rbPeek = new System.Windows.Forms.RadioButton();
            this.lbPila = new System.Windows.Forms.ListBox();
            this.lbCopiaPila = new System.Windows.Forms.ListBox();
            this.lbImprimir = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elemento";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(69, 35);
            this.txtElemento.Multiline = true;
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(94, 26);
            this.txtElemento.TabIndex = 1;
            this.txtElemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElemento_KeyPress);
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(169, 35);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(104, 27);
            this.btnPush.TabIndex = 2;
            this.btnPush.Text = "Push / Apilar";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pila Original";
            // 
            // rbCopy
            // 
            this.rbCopy.AutoSize = true;
            this.rbCopy.Location = new System.Drawing.Point(121, 114);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(55, 17);
            this.rbCopy.TabIndex = 4;
            this.rbCopy.TabStop = true;
            this.rbCopy.Text = "Copiar";
            this.rbCopy.UseVisualStyleBackColor = true;
            this.rbCopy.CheckedChanged += new System.EventHandler(this.rbCopy_CheckedChanged);
            // 
            // rbPop
            // 
            this.rbPop.AutoSize = true;
            this.rbPop.Location = new System.Drawing.Point(224, 114);
            this.rbPop.Name = "rbPop";
            this.rbPop.Size = new System.Drawing.Size(99, 17);
            this.rbPop.TabIndex = 5;
            this.rbPop.TabStop = true;
            this.rbPop.Text = "Pop / Desapilar";
            this.rbPop.UseVisualStyleBackColor = true;
            this.rbPop.CheckedChanged += new System.EventHandler(this.rbPop_CheckedChanged);
            // 
            // rbPeek
            // 
            this.rbPeek.AutoSize = true;
            this.rbPeek.Location = new System.Drawing.Point(363, 116);
            this.rbPeek.Name = "rbPeek";
            this.rbPeek.Size = new System.Drawing.Size(131, 17);
            this.rbPeek.TabIndex = 6;
            this.rbPeek.TabStop = true;
            this.rbPeek.Text = "Peek / Primero en Pila";
            this.rbPeek.UseVisualStyleBackColor = true;
            this.rbPeek.CheckedChanged += new System.EventHandler(this.rbPeek_CheckedChanged);
            // 
            // lbPila
            // 
            this.lbPila.FormattingEnabled = true;
            this.lbPila.Location = new System.Drawing.Point(15, 146);
            this.lbPila.Name = "lbPila";
            this.lbPila.Size = new System.Drawing.Size(93, 186);
            this.lbPila.TabIndex = 7;
            // 
            // lbCopiaPila
            // 
            this.lbCopiaPila.FormattingEnabled = true;
            this.lbCopiaPila.Location = new System.Drawing.Point(121, 146);
            this.lbCopiaPila.Name = "lbCopiaPila";
            this.lbCopiaPila.Size = new System.Drawing.Size(93, 186);
            this.lbCopiaPila.TabIndex = 8;
            // 
            // lbImprimir
            // 
            this.lbImprimir.FormattingEnabled = true;
            this.lbImprimir.Location = new System.Drawing.Point(230, 146);
            this.lbImprimir.Name = "lbImprimir";
            this.lbImprimir.Size = new System.Drawing.Size(264, 186);
            this.lbImprimir.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 358);
            this.Controls.Add(this.lbImprimir);
            this.Controls.Add(this.lbCopiaPila);
            this.Controls.Add(this.lbPila);
            this.Controls.Add(this.rbPeek);
            this.Controls.Add(this.rbPop);
            this.Controls.Add(this.rbCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbCopy;
        private System.Windows.Forms.RadioButton rbPop;
        private System.Windows.Forms.RadioButton rbPeek;
        private System.Windows.Forms.ListBox lbPila;
        private System.Windows.Forms.ListBox lbCopiaPila;
        private System.Windows.Forms.ListBox lbImprimir;
    }
}

