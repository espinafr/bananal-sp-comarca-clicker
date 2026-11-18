namespace crik
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            mulaLabel = new Label();
            farmBar = new ProgressBar();
            farmarBtn = new Button();
            detalhesLabel = new Label();
            missoesBtn = new Button();
            shopBtn = new Button();
            SuspendLayout();
            // 
            // mulaLabel
            // 
            resources.ApplyResources(mulaLabel, "mulaLabel");
            mulaLabel.BackColor = Color.Transparent;
            mulaLabel.ForeColor = Color.Yellow;
            mulaLabel.Name = "mulaLabel";
            // 
            // farmBar
            // 
            resources.ApplyResources(farmBar, "farmBar");
            farmBar.ForeColor = Color.Yellow;
            farmBar.Name = "farmBar";
            farmBar.Step = 1;
            // 
            // farmarBtn
            // 
            resources.ApplyResources(farmarBtn, "farmarBtn");
            farmarBtn.BackColor = Color.FromArgb(255, 255, 192);
            farmarBtn.Name = "farmarBtn";
            farmarBtn.UseVisualStyleBackColor = false;
            farmarBtn.Click += farmarBtn_Click;
            // 
            // detalhesLabel
            // 
            resources.ApplyResources(detalhesLabel, "detalhesLabel");
            detalhesLabel.BackColor = Color.FromArgb(255, 255, 192);
            detalhesLabel.Name = "detalhesLabel";
            // 
            // missoesBtn
            // 
            resources.ApplyResources(missoesBtn, "missoesBtn");
            missoesBtn.BackColor = Color.FromArgb(255, 255, 192);
            missoesBtn.Name = "missoesBtn";
            missoesBtn.UseVisualStyleBackColor = false;
            missoesBtn.Click += missoesBtn_Click;
            // 
            // shopBtn
            // 
            resources.ApplyResources(shopBtn, "shopBtn");
            shopBtn.BackColor = Color.FromArgb(255, 255, 192);
            shopBtn.Name = "shopBtn";
            shopBtn.UseVisualStyleBackColor = false;
            shopBtn.Click += shopBtn_Click;
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_tela_2026_11_12_140410;
            Controls.Add(shopBtn);
            Controls.Add(missoesBtn);
            Controls.Add(detalhesLabel);
            Controls.Add(farmarBtn);
            Controls.Add(farmBar);
            Controls.Add(mulaLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "mainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Load += mainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mulaLabel;
        private ProgressBar farmBar;
        private Button farmarBtn;
        private Label detalhesLabel;
        private Button missoesBtn;
        private Button shopBtn;
    }
}
