namespace App_kunishi
{
    partial class app
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
            botao = new Button();
            label1 = new Label();
            input_text = new TextBox();
            SuspendLayout();
            // 
            // botao
            // 
            botao.Cursor = Cursors.Hand;
            botao.Location = new Point(415, 115);
            botao.Name = "botao";
            botao.Size = new Size(75, 23);
            botao.TabIndex = 0;
            botao.Text = "Procurar";
            botao.UseVisualStyleBackColor = true;
            botao.Click += botao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 91);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Digite o CEP:";
            label1.Click += label1_Click;
            // 
            // input_text
            // 
            input_text.Cursor = Cursors.IBeam;
            input_text.Location = new Point(142, 115);
            input_text.Name = "input_text";
            input_text.Size = new Size(267, 23);
            input_text.TabIndex = 2;
            input_text.TextChanged += input_text_TextChanged;
            // 
            // app
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(input_text);
            Controls.Add(label1);
            Controls.Add(botao);
            Name = "app";
            Text = "Form1";
            Load += App_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao;
        private Label label1;
        private TextBox input_text;
    }
}