namespace crik
{
    partial class MissoesForm
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
            missoesPanel = new FlowLayoutPanel();
            missoesTituloLabel = new Label();
            mulaLabel = new Label();
            panel1 = new Panel();
            recompensaLabel = new Label();
            missoesPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // missoesPanel
            // 
            missoesPanel.BackColor = Color.Transparent;
            missoesPanel.BorderStyle = BorderStyle.FixedSingle;
            missoesPanel.Controls.Add(panel1);
            missoesPanel.Location = new Point(12, 60);
            missoesPanel.Name = "missoesPanel";
            missoesPanel.Size = new Size(776, 378);
            missoesPanel.TabIndex = 0;
            // 
            // missoesTituloLabel
            // 
            missoesTituloLabel.AutoSize = true;
            missoesTituloLabel.BackColor = Color.Transparent;
            missoesTituloLabel.Font = new Font("Ravie", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            missoesTituloLabel.ForeColor = Color.FromArgb(128, 255, 128);
            missoesTituloLabel.Location = new Point(12, 9);
            missoesTituloLabel.Name = "missoesTituloLabel";
            missoesTituloLabel.Size = new Size(475, 48);
            missoesTituloLabel.TabIndex = 1;
            missoesTituloLabel.Text = "POSTO DE MISSÕES";
            missoesTituloLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mulaLabel
            // 
            mulaLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mulaLabel.AutoSize = true;
            mulaLabel.BackColor = Color.FromArgb(0, 64, 0);
            mulaLabel.Font = new Font("Poor Richard", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mulaLabel.ForeColor = Color.Yellow;
            mulaLabel.Location = new Point(696, 19);
            mulaLabel.Name = "mulaLabel";
            mulaLabel.Size = new Size(92, 22);
            mulaLabel.TabIndex = 2;
            mulaLabel.Text = "0 bananas";
            mulaLabel.TextAlign = ContentAlignment.MiddleRight;
            mulaLabel.SizeChanged += corrigirOffset;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(recompensaLabel);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // recompensaLabel
            // 
            recompensaLabel.AutoSize = true;
            recompensaLabel.ForeColor = Color.Yellow;
            recompensaLabel.Location = new Point(36, 52);
            recompensaLabel.Name = "recompensaLabel";
            recompensaLabel.Size = new Size(127, 15);
            recompensaLabel.TabIndex = 0;
            recompensaLabel.Text = "50 milhões de bananas";
            // 
            // MissoesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_tela_2026_11_12_164634;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(mulaLabel);
            Controls.Add(missoesTituloLabel);
            Controls.Add(missoesPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MissoesForm";
            Text = "missões";
            Load += MissoesForm_Load;
            missoesPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel missoesPanel;
        private Label missoesTituloLabel;
        private Label mulaLabel;
        private Panel panel1;
        private Label recompensaLabel;
    }
}