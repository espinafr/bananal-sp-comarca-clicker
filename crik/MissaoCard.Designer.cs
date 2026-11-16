namespace crik
{
    partial class MissaoCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing) components?.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tituloLabel = new Label();
            recompensaLabel = new Label();
            dificuldadeLabel = new Label();
            verButton = new Button();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.BackColor = Color.Transparent;
            tituloLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloLabel.ForeColor = Color.FromArgb(0, 64, 0);
            tituloLabel.Location = new Point(3, 4);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(181, 20);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "frênesi de bananas insanooo MALUCAGEM";
            tituloLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // recompensaLabel
            // 
            recompensaLabel.BackColor = Color.Transparent;
            recompensaLabel.Font = new Font("Georgia", 9F, FontStyle.Italic);
            recompensaLabel.ForeColor = Color.Yellow;
            recompensaLabel.Location = new Point(5, 24);
            recompensaLabel.Name = "recompensaLabel";
            recompensaLabel.Size = new Size(181, 17);
            recompensaLabel.TabIndex = 1;
            recompensaLabel.Text = "5 quintilhões de bananas";
            recompensaLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // dificuldadeLabel
            // 
            dificuldadeLabel.BackColor = Color.Transparent;
            dificuldadeLabel.Font = new Font("Georgia", 9F, FontStyle.Italic);
            dificuldadeLabel.ForeColor = Color.Green;
            dificuldadeLabel.Location = new Point(3, 81);
            dificuldadeLabel.Name = "dificuldadeLabel";
            dificuldadeLabel.Size = new Size(181, 17);
            dificuldadeLabel.TabIndex = 2;
            dificuldadeLabel.Text = "fácil";
            dificuldadeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // verButton
            // 
            verButton.BackColor = Color.Bisque;
            verButton.FlatStyle = FlatStyle.Popup;
            verButton.Font = new Font("Georgia", 8.25F, FontStyle.Bold);
            verButton.ForeColor = Color.FromArgb(0, 64, 0);
            verButton.Location = new Point(50, 55);
            verButton.Name = "verButton";
            verButton.Size = new Size(90, 23);
            verButton.TabIndex = 3;
            verButton.Text = "detalhes";
            verButton.UseVisualStyleBackColor = false;
            verButton.Click += verButton_Click;
            // 
            // MissaoCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            BackgroundImage = Properties.Resources.papel;
            BackgroundImageLayout = ImageLayout.Stretch;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tituloLabel);
            Controls.Add(recompensaLabel);
            Controls.Add(dificuldadeLabel);
            Controls.Add(verButton);
            Name = "MissaoCard";
            Size = new Size(189, 100);
            ResumeLayout(false);
        }

        #endregion

        private Label tituloLabel;
        private Label recompensaLabel;
        private Label dificuldadeLabel;
        private Button verButton;
    }
}
