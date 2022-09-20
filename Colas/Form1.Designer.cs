
namespace Colas
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
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbCopiar = new System.Windows.Forms.RadioButton();
            this.rbPop = new System.Windows.Forms.RadioButton();
            this.rbPeek = new System.Windows.Forms.RadioButton();
            this.lbCola = new System.Windows.Forms.ListBox();
            this.lbCopiaCola = new System.Windows.Forms.ListBox();
            this.lbImprimir = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elemento";
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Location = new System.Drawing.Point(167, 21);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(76, 27);
            this.btnEnqueue.TabIndex = 1;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(87, 25);
            this.txtElemento.Multiline = true;
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(74, 23);
            this.txtElemento.TabIndex = 2;
            this.txtElemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElemento_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cola Original";
            // 
            // textBuscar
            // 
            this.textBuscar.AutoSize = true;
            this.textBuscar.Location = new System.Drawing.Point(345, 65);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(40, 13);
            this.textBuscar.TabIndex = 4;
            this.textBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(391, 62);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(74, 23);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // rbCopiar
            // 
            this.rbCopiar.AutoSize = true;
            this.rbCopiar.Location = new System.Drawing.Point(134, 132);
            this.rbCopiar.Name = "rbCopiar";
            this.rbCopiar.Size = new System.Drawing.Size(55, 17);
            this.rbCopiar.TabIndex = 6;
            this.rbCopiar.TabStop = true;
            this.rbCopiar.Text = "Copiar";
            this.rbCopiar.UseVisualStyleBackColor = true;
            this.rbCopiar.CheckedChanged += new System.EventHandler(this.rbCopiar_CheckedChanged);
            // 
            // rbPop
            // 
            this.rbPop.AutoSize = true;
            this.rbPop.Location = new System.Drawing.Point(255, 132);
            this.rbPop.Name = "rbPop";
            this.rbPop.Size = new System.Drawing.Size(92, 17);
            this.rbPop.TabIndex = 7;
            this.rbPop.TabStop = true;
            this.rbPop.Text = "Sacar de Cola";
            this.rbPop.UseVisualStyleBackColor = true;
            this.rbPop.CheckedChanged += new System.EventHandler(this.rbPop_CheckedChanged);
            // 
            // rbPeek
            // 
            this.rbPeek.AutoSize = true;
            this.rbPeek.Location = new System.Drawing.Point(353, 132);
            this.rbPeek.Name = "rbPeek";
            this.rbPeek.Size = new System.Drawing.Size(134, 17);
            this.rbPeek.TabIndex = 8;
            this.rbPeek.TabStop = true;
            this.rbPeek.Text = "Peek / Primero en cola";
            this.rbPeek.UseVisualStyleBackColor = true;
            this.rbPeek.CheckedChanged += new System.EventHandler(this.rbPeek_CheckedChanged);
            // 
            // lbCola
            // 
            this.lbCola.FormattingEnabled = true;
            this.lbCola.Location = new System.Drawing.Point(12, 155);
            this.lbCola.Name = "lbCola";
            this.lbCola.Size = new System.Drawing.Size(103, 160);
            this.lbCola.TabIndex = 9;
            // 
            // lbCopiaCola
            // 
            this.lbCopiaCola.FormattingEnabled = true;
            this.lbCopiaCola.Location = new System.Drawing.Point(125, 155);
            this.lbCopiaCola.Name = "lbCopiaCola";
            this.lbCopiaCola.Size = new System.Drawing.Size(103, 160);
            this.lbCopiaCola.TabIndex = 10;
            // 
            // lbImprimir
            // 
            this.lbImprimir.FormattingEnabled = true;
            this.lbImprimir.Location = new System.Drawing.Point(246, 155);
            this.lbImprimir.Name = "lbImprimir";
            this.lbImprimir.Size = new System.Drawing.Size(261, 160);
            this.lbImprimir.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 376);
            this.Controls.Add(this.lbImprimir);
            this.Controls.Add(this.lbCopiaCola);
            this.Controls.Add(this.lbCola);
            this.Controls.Add(this.rbPeek);
            this.Controls.Add(this.rbPop);
            this.Controls.Add(this.rbCopiar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.btnEnqueue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbCopiar;
        private System.Windows.Forms.RadioButton rbPop;
        private System.Windows.Forms.RadioButton rbPeek;
        private System.Windows.Forms.ListBox lbCola;
        private System.Windows.Forms.ListBox lbCopiaCola;
        private System.Windows.Forms.ListBox lbImprimir;
    }
}

