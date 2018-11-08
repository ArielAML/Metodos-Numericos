namespace MN_Derivacion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fx = new System.Windows.Forms.Label();
            this.C4 = new System.Windows.Forms.TextBox();
            this.tdd = new System.Windows.Forms.Label();
            this.txi = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.Label();
            this.th = new System.Windows.Forms.TextBox();
            this.der = new System.Windows.Forms.Label();
            this.cbtdd = new System.Windows.Forms.ComboBox();
            this.cberr = new System.Windows.Forms.ComboBox();
            this.cbder = new System.Windows.Forms.ComboBox();
            this.Xi = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.bcalcular = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tRdA = new System.Windows.Forms.TextBox();
            this.bSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.C3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.C2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fx
            // 
            this.fx.AutoSize = true;
            this.fx.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fx.Location = new System.Drawing.Point(38, 58);
            this.fx.Name = "fx";
            this.fx.Size = new System.Drawing.Size(36, 18);
            this.fx.TabIndex = 0;
            this.fx.Text = "f(x) :";
            this.fx.Click += new System.EventHandler(this.label1_Click);
            // 
            // C4
            // 
            this.C4.Location = new System.Drawing.Point(75, 58);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(32, 20);
            this.C4.TabIndex = 1;
            // 
            // tdd
            // 
            this.tdd.AutoSize = true;
            this.tdd.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdd.Location = new System.Drawing.Point(27, 95);
            this.tdd.Name = "tdd";
            this.tdd.Size = new System.Drawing.Size(141, 18);
            this.tdd.TabIndex = 2;
            this.tdd.Text = "Tipo de diferenciacion :";
            // 
            // txi
            // 
            this.txi.Location = new System.Drawing.Point(300, 132);
            this.txi.Name = "txi";
            this.txi.Size = new System.Drawing.Size(58, 20);
            this.txi.TabIndex = 3;
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err.Location = new System.Drawing.Point(27, 131);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(47, 18);
            this.err.TabIndex = 4;
            this.err.Text = "Error :";
            // 
            // th
            // 
            this.th.Location = new System.Drawing.Point(291, 170);
            this.th.Name = "th";
            this.th.Size = new System.Drawing.Size(58, 20);
            this.th.TabIndex = 5;
            // 
            // der
            // 
            this.der.AutoSize = true;
            this.der.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.der.Location = new System.Drawing.Point(26, 172);
            this.der.Name = "der";
            this.der.Size = new System.Drawing.Size(70, 18);
            this.der.TabIndex = 6;
            this.der.Text = "Derivada :";
            // 
            // cbtdd
            // 
            this.cbtdd.FormattingEnabled = true;
            this.cbtdd.Items.AddRange(new object[] {
            "Hacia adelante",
            "Centrada",
            "Hacia atras"});
            this.cbtdd.Location = new System.Drawing.Point(170, 92);
            this.cbtdd.Name = "cbtdd";
            this.cbtdd.Size = new System.Drawing.Size(121, 21);
            this.cbtdd.TabIndex = 7;
            this.cbtdd.SelectedIndexChanged += new System.EventHandler(this.cbtdd_SelectedIndexChanged);
            // 
            // cberr
            // 
            this.cberr.FormattingEnabled = true;
            this.cberr.Items.AddRange(new object[] {
            "O(h)",
            "O(h^2)",
            "O(h^4)"});
            this.cberr.Location = new System.Drawing.Point(77, 131);
            this.cberr.Name = "cberr";
            this.cberr.Size = new System.Drawing.Size(121, 21);
            this.cberr.TabIndex = 8;
            // 
            // cbder
            // 
            this.cbder.FormattingEnabled = true;
            this.cbder.Items.AddRange(new object[] {
            "Primer derivada",
            "Segunda derivada"});
            this.cbder.Location = new System.Drawing.Point(102, 172);
            this.cbder.Name = "cbder";
            this.cbder.Size = new System.Drawing.Size(121, 21);
            this.cbder.TabIndex = 9;
            this.cbder.SelectedIndexChanged += new System.EventHandler(this.cbder_SelectedIndexChanged);
            // 
            // Xi
            // 
            this.Xi.AutoSize = true;
            this.Xi.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xi.Location = new System.Drawing.Point(265, 134);
            this.Xi.Name = "Xi";
            this.Xi.Size = new System.Drawing.Size(29, 18);
            this.Xi.TabIndex = 10;
            this.Xi.Text = "Xi :";
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H.Location = new System.Drawing.Point(262, 170);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(23, 18);
            this.H.TabIndex = 11;
            this.H.Text = "h :";
            // 
            // bcalcular
            // 
            this.bcalcular.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcalcular.Location = new System.Drawing.Point(178, 214);
            this.bcalcular.Name = "bcalcular";
            this.bcalcular.Size = new System.Drawing.Size(87, 26);
            this.bcalcular.TabIndex = 12;
            this.bcalcular.Text = "Calcular";
            this.bcalcular.UseVisualStyleBackColor = true;
            this.bcalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(111, 309);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(87, 26);
            this.bBorrar.TabIndex = 13;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Resultado de Aproximacion :";
            // 
            // tRdA
            // 
            this.tRdA.Location = new System.Drawing.Point(271, 264);
            this.tRdA.Name = "tRdA";
            this.tRdA.Size = new System.Drawing.Size(136, 20);
            this.tRdA.TabIndex = 15;
            this.tRdA.TextChanged += new System.EventHandler(this.tRdA_TextChanged);
            // 
            // bSalir
            // 
            this.bSalir.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.Location = new System.Drawing.Point(251, 309);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(87, 26);
            this.bSalir.TabIndex = 16;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(427, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "PRACTICA: DIFERENCIACION NUMERICA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "X^4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "X^3";
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(148, 58);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(32, 20);
            this.C3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "X^2";
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(220, 58);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(32, 20);
            this.C2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "X";
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(290, 58);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(32, 20);
            this.C1.TabIndex = 23;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(350, 58);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(32, 20);
            this.C.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 365);
            this.Controls.Add(this.C);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.tRdA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bcalcular);
            this.Controls.Add(this.H);
            this.Controls.Add(this.Xi);
            this.Controls.Add(this.cbder);
            this.Controls.Add(this.cberr);
            this.Controls.Add(this.cbtdd);
            this.Controls.Add(this.der);
            this.Controls.Add(this.th);
            this.Controls.Add(this.err);
            this.Controls.Add(this.txi);
            this.Controls.Add(this.tdd);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.fx);
            this.Name = "Form1";
            this.Text = "Metodo de Derivacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fx;
        private System.Windows.Forms.TextBox C4;
        private System.Windows.Forms.Label tdd;
        private System.Windows.Forms.TextBox txi;
        private System.Windows.Forms.Label err;
        private System.Windows.Forms.TextBox th;
        private System.Windows.Forms.Label der;
        private System.Windows.Forms.ComboBox cbtdd;
        private System.Windows.Forms.ComboBox cberr;
        private System.Windows.Forms.ComboBox cbder;
        private System.Windows.Forms.Label Xi;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Button bcalcular;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tRdA;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox C3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox C2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox C1;
        private System.Windows.Forms.TextBox C;
    }
}

