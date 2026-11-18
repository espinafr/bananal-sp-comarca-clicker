namespace crik
{
    partial class LojaForm
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
            mulaLabel = new Label();
            pictureBox1 = new PictureBox();
            colaboradoresPanel = new Panel();
            panel1 = new Panel();
            totalColabLabel = new Label();
            colabBuy100Btn = new Button();
            colabBuy10Btn = new Button();
            colabBuy1Btn = new Button();
            tituloColabLabel = new Label();
            descricaoColabLabel = new Label();
            colabQntdLabel = new Label();
            colabDescrQntdLabel = new Label();
            producaoColabLabel = new Label();
            homenzinhoColabPicture = new PictureBox();
            pictureBox2 = new PictureBox();
            colaboradoresBtn = new Button();
            upgradesBtn = new Button();
            extrasBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            colaboradoresPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homenzinhoColabPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // mulaLabel
            // 
            mulaLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mulaLabel.AutoSize = true;
            mulaLabel.BackColor = Color.FromArgb(0, 64, 0);
            mulaLabel.Font = new Font("Poor Richard", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mulaLabel.ForeColor = Color.Yellow;
            mulaLabel.Location = new Point(615, 9);
            mulaLabel.Name = "mulaLabel";
            mulaLabel.Size = new Size(92, 22);
            mulaLabel.TabIndex = 3;
            mulaLabel.Text = "0 bananas";
            mulaLabel.TextAlign = ContentAlignment.MiddleRight;
            mulaLabel.Resize += corrigirOffset;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.colab;
            pictureBox1.Location = new Point(12, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 362);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // colaboradoresPanel
            // 
            colaboradoresPanel.BackColor = Color.Transparent;
            colaboradoresPanel.BackgroundImageLayout = ImageLayout.None;
            colaboradoresPanel.Controls.Add(panel1);
            colaboradoresPanel.Controls.Add(colabQntdLabel);
            colaboradoresPanel.Controls.Add(colabDescrQntdLabel);
            colaboradoresPanel.Controls.Add(producaoColabLabel);
            colaboradoresPanel.Controls.Add(homenzinhoColabPicture);
            colaboradoresPanel.Controls.Add(pictureBox1);
            colaboradoresPanel.Location = new Point(12, 176);
            colaboradoresPanel.Name = "colaboradoresPanel";
            colaboradoresPanel.Size = new Size(695, 411);
            colaboradoresPanel.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(totalColabLabel);
            panel1.Controls.Add(colabBuy100Btn);
            panel1.Controls.Add(colabBuy10Btn);
            panel1.Controls.Add(colabBuy1Btn);
            panel1.Controls.Add(tituloColabLabel);
            panel1.Controls.Add(descricaoColabLabel);
            panel1.Location = new Point(289, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 249);
            panel1.TabIndex = 10;
            // 
            // totalColabLabel
            // 
            totalColabLabel.BackColor = Color.Transparent;
            totalColabLabel.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalColabLabel.ForeColor = Color.DarkGoldenrod;
            totalColabLabel.Location = new Point(24, 224);
            totalColabLabel.Name = "totalColabLabel";
            totalColabLabel.Size = new Size(322, 16);
            totalColabLabel.TabIndex = 10;
            totalColabLabel.Text = "total: 100 bananas";
            // 
            // colabBuy100Btn
            // 
            colabBuy100Btn.Cursor = Cursors.Hand;
            colabBuy100Btn.Font = new Font("Engravers MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colabBuy100Btn.ForeColor = Color.Red;
            colabBuy100Btn.Location = new Point(239, 147);
            colabBuy100Btn.Name = "colabBuy100Btn";
            colabBuy100Btn.Size = new Size(75, 64);
            colabBuy100Btn.TabIndex = 9;
            colabBuy100Btn.Text = "100";
            colabBuy100Btn.UseVisualStyleBackColor = true;
            colabBuy100Btn.Click += colabBuy100Btn_Click;
            // 
            // colabBuy10Btn
            // 
            colabBuy10Btn.Cursor = Cursors.Hand;
            colabBuy10Btn.Font = new Font("Engravers MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colabBuy10Btn.ForeColor = Color.Red;
            colabBuy10Btn.Location = new Point(146, 147);
            colabBuy10Btn.Name = "colabBuy10Btn";
            colabBuy10Btn.Size = new Size(75, 64);
            colabBuy10Btn.TabIndex = 8;
            colabBuy10Btn.Text = "10";
            colabBuy10Btn.UseVisualStyleBackColor = true;
            colabBuy10Btn.Click += colabBuy10Btn_Click;
            // 
            // colabBuy1Btn
            // 
            colabBuy1Btn.Cursor = Cursors.Hand;
            colabBuy1Btn.Font = new Font("Engravers MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colabBuy1Btn.ForeColor = Color.Red;
            colabBuy1Btn.Location = new Point(53, 147);
            colabBuy1Btn.Name = "colabBuy1Btn";
            colabBuy1Btn.Size = new Size(75, 64);
            colabBuy1Btn.TabIndex = 7;
            colabBuy1Btn.Text = "1";
            colabBuy1Btn.UseVisualStyleBackColor = true;
            colabBuy1Btn.Click += colabBuy1Btn_Click;
            // 
            // tituloColabLabel
            // 
            tituloColabLabel.AutoSize = true;
            tituloColabLabel.BackColor = Color.Transparent;
            tituloColabLabel.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tituloColabLabel.Location = new Point(24, 21);
            tituloColabLabel.Name = "tituloColabLabel";
            tituloColabLabel.Size = new Size(311, 46);
            tituloColabLabel.TabIndex = 5;
            tituloColabLabel.Text = "Bem-vindo à área de \r\ncontratação de colaboradores!";
            tituloColabLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descricaoColabLabel
            // 
            descricaoColabLabel.BackColor = Color.Transparent;
            descricaoColabLabel.Location = new Point(24, 77);
            descricaoColabLabel.Name = "descricaoColabLabel";
            descricaoColabLabel.Size = new Size(322, 67);
            descricaoColabLabel.TabIndex = 6;
            descricaoColabLabel.Text = "Selecione abaixo a quantidade de colaboradores que deseja contratar e em seguida clique no nosso caro ao lado para contratá-los!\r\nA cada contratação, o preço da próxima sobe em 10%";
            // 
            // colabQntdLabel
            // 
            colabQntdLabel.BackColor = Color.White;
            colabQntdLabel.Font = new Font("Engravers MT", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            colabQntdLabel.ForeColor = Color.Red;
            colabQntdLabel.Location = new Point(54, 203);
            colabQntdLabel.Name = "colabQntdLabel";
            colabQntdLabel.Size = new Size(127, 56);
            colabQntdLabel.TabIndex = 9;
            colabQntdLabel.Text = "1";
            colabQntdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // colabDescrQntdLabel
            // 
            colabDescrQntdLabel.AutoSize = true;
            colabDescrQntdLabel.BackColor = Color.White;
            colabDescrQntdLabel.Location = new Point(48, 188);
            colabDescrQntdLabel.Name = "colabDescrQntdLabel";
            colabDescrQntdLabel.Size = new Size(142, 15);
            colabDescrQntdLabel.TabIndex = 8;
            colabDescrQntdLabel.Text = "clique aqui para contratar";
            // 
            // producaoColabLabel
            // 
            producaoColabLabel.BackColor = Color.Transparent;
            producaoColabLabel.ForeColor = SystemColors.Control;
            producaoColabLabel.Location = new Point(0, 391);
            producaoColabLabel.Name = "producaoColabLabel";
            producaoColabLabel.Size = new Size(695, 20);
            producaoColabLabel.TabIndex = 7;
            producaoColabLabel.Text = "Atualmente 1 colaborador gera 1 bananas a cada 2 segundos";
            producaoColabLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // homenzinhoColabPicture
            // 
            homenzinhoColabPicture.BackColor = Color.Transparent;
            homenzinhoColabPicture.Image = Properties.Resources.colab;
            homenzinhoColabPicture.Location = new Point(12, 31);
            homenzinhoColabPicture.Name = "homenzinhoColabPicture";
            homenzinhoColabPicture.Size = new Size(220, 362);
            homenzinhoColabPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            homenzinhoColabPicture.TabIndex = 4;
            homenzinhoColabPicture.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.olagostaria;
            pictureBox2.Location = new Point(84, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(564, 116);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // colaboradoresBtn
            // 
            colaboradoresBtn.BackColor = Color.DeepSkyBlue;
            colaboradoresBtn.Enabled = false;
            colaboradoresBtn.FlatStyle = FlatStyle.Flat;
            colaboradoresBtn.Font = new Font("Engravers MT", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            colaboradoresBtn.Location = new Point(99, 147);
            colaboradoresBtn.Name = "colaboradoresBtn";
            colaboradoresBtn.Size = new Size(179, 23);
            colaboradoresBtn.TabIndex = 7;
            colaboradoresBtn.Text = "colaboradores";
            colaboradoresBtn.UseVisualStyleBackColor = false;
            // 
            // upgradesBtn
            // 
            upgradesBtn.BackColor = Color.DeepSkyBlue;
            upgradesBtn.Enabled = false;
            upgradesBtn.FlatStyle = FlatStyle.Flat;
            upgradesBtn.Font = new Font("Engravers MT", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            upgradesBtn.Location = new Point(284, 147);
            upgradesBtn.Name = "upgradesBtn";
            upgradesBtn.Size = new Size(179, 23);
            upgradesBtn.TabIndex = 8;
            upgradesBtn.Text = "UPGRADES";
            upgradesBtn.UseVisualStyleBackColor = false;
            // 
            // extrasBtn
            // 
            extrasBtn.BackColor = Color.DeepSkyBlue;
            extrasBtn.Enabled = false;
            extrasBtn.FlatStyle = FlatStyle.Flat;
            extrasBtn.Font = new Font("Engravers MT", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            extrasBtn.Location = new Point(469, 147);
            extrasBtn.Name = "extrasBtn";
            extrasBtn.Size = new Size(179, 23);
            extrasBtn.TabIndex = 9;
            extrasBtn.Text = "EXTRAS";
            extrasBtn.UseVisualStyleBackColor = false;
            // 
            // LojaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lojabananal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(719, 614);
            Controls.Add(extrasBtn);
            Controls.Add(upgradesBtn);
            Controls.Add(colaboradoresBtn);
            Controls.Add(colaboradoresPanel);
            Controls.Add(mulaLabel);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LojaForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "loja tem de tudo e um pouco + de BANANAL SP";
            Load += LojaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            colaboradoresPanel.ResumeLayout(false);
            colaboradoresPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)homenzinhoColabPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mulaLabel;
        private PictureBox pictureBox1;
        private Panel colaboradoresPanel;
        private PictureBox pictureBox2;
        private Button colaboradoresBtn;
        private Button upgradesBtn;
        private Button extrasBtn;
        private Label descricaoColabLabel;
        private Label tituloColabLabel;
        private Label colabDescrQntdLabel;
        private Label producaoColabLabel;
        private Label colabQntdLabel;
        private PictureBox homenzinhoColabPicture;
        private Panel panel1;
        private Button colabBuy1Btn;
        private Label totalColabLabel;
        private Button colabBuy100Btn;
        private Button colabBuy10Btn;
    }
}