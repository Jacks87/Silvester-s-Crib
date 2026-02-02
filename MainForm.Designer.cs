namespace Sylvesters_Crib
{
    partial class MainForm
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
            ControlPanel = new Panel();
            btnTreats = new Button();
            btnWater = new Button();
            lblFood = new Label();
            btnKibble = new Button();
            btnWetFood = new Button();
            CarePanel = new Panel();
            btnVet = new Button();
            btnPet = new Button();
            btnBath = new Button();
            btnLitter = new Button();
            lblCare = new Label();
            StatusPanel = new Panel();
            lblHappy = new Label();
            lblClean = new Label();
            lblThirsty = new Label();
            progressHappiness = new ProgressBar();
            lblHungry = new Label();
            progressCleanliness = new ProgressBar();
            progressThirst = new ProgressBar();
            progressHunger = new ProgressBar();
            lblStatus = new Label();
            panel1 = new Panel();
            lblGender = new Label();
            lblAge = new Label();
            lblBreed = new Label();
            btnNewDay = new Button();
            picAction = new PictureBox();
            ControlPanel.SuspendLayout();
            CarePanel.SuspendLayout();
            StatusPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAction).BeginInit();
            SuspendLayout();
            // 
            // ControlPanel
            // 
            ControlPanel.Controls.Add(btnTreats);
            ControlPanel.Controls.Add(btnWater);
            ControlPanel.Controls.Add(lblFood);
            ControlPanel.Controls.Add(btnKibble);
            ControlPanel.Controls.Add(btnWetFood);
            ControlPanel.Location = new Point(295, 198);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(322, 147);
            ControlPanel.TabIndex = 0;
            // 
            // btnTreats
            // 
            btnTreats.Location = new Point(69, 95);
            btnTreats.Name = "btnTreats";
            btnTreats.Size = new Size(176, 29);
            btnTreats.TabIndex = 4;
            btnTreats.Text = "Treats / Snacks";
            btnTreats.UseVisualStyleBackColor = true;
            btnTreats.Click += btnTreats_Click;
            // 
            // btnWater
            // 
            btnWater.Location = new Point(213, 50);
            btnWater.Name = "btnWater";
            btnWater.Size = new Size(94, 29);
            btnWater.TabIndex = 3;
            btnWater.Text = "Water";
            btnWater.UseVisualStyleBackColor = true;
            btnWater.Click += btnWater_Click;
            // 
            // lblFood
            // 
            lblFood.AutoSize = true;
            lblFood.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFood.Location = new Point(13, 14);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(59, 17);
            lblFood.TabIndex = 2;
            lblFood.Text = "Feed Me";
            // 
            // btnKibble
            // 
            btnKibble.Location = new Point(13, 50);
            btnKibble.Name = "btnKibble";
            btnKibble.Size = new Size(94, 29);
            btnKibble.TabIndex = 1;
            btnKibble.Text = "Kibble";
            btnKibble.UseVisualStyleBackColor = true;
            btnKibble.Click += btnKibble_Click;
            // 
            // btnWetFood
            // 
            btnWetFood.Location = new Point(113, 50);
            btnWetFood.Name = "btnWetFood";
            btnWetFood.Size = new Size(94, 29);
            btnWetFood.TabIndex = 0;
            btnWetFood.Text = "Wet Food";
            btnWetFood.UseVisualStyleBackColor = true;
            btnWetFood.Click += btnWetFood_Click;
            // 
            // CarePanel
            // 
            CarePanel.Controls.Add(btnVet);
            CarePanel.Controls.Add(btnPet);
            CarePanel.Controls.Add(btnBath);
            CarePanel.Controls.Add(btnLitter);
            CarePanel.Controls.Add(lblCare);
            CarePanel.Location = new Point(652, 198);
            CarePanel.Name = "CarePanel";
            CarePanel.Size = new Size(316, 147);
            CarePanel.TabIndex = 1;
            // 
            // btnVet
            // 
            btnVet.Location = new Point(212, 95);
            btnVet.Name = "btnVet";
            btnVet.Size = new Size(94, 29);
            btnVet.TabIndex = 6;
            btnVet.Text = "Vet";
            btnVet.UseVisualStyleBackColor = true;
            btnVet.Click += btnVet_Click;
            // 
            // btnPet
            // 
            btnPet.Location = new Point(111, 95);
            btnPet.Name = "btnPet";
            btnPet.Size = new Size(94, 29);
            btnPet.TabIndex = 5;
            btnPet.Text = "Pet Me";
            btnPet.UseVisualStyleBackColor = true;
            btnPet.Click += btnPet_Click;
            // 
            // btnBath
            // 
            btnBath.Location = new Point(10, 95);
            btnBath.Name = "btnBath";
            btnBath.Size = new Size(94, 29);
            btnBath.TabIndex = 4;
            btnBath.Text = "Wash Me";
            btnBath.UseVisualStyleBackColor = true;
            btnBath.Click += btnBath_Click;
            // 
            // btnLitter
            // 
            btnLitter.Location = new Point(70, 50);
            btnLitter.Name = "btnLitter";
            btnLitter.Size = new Size(175, 29);
            btnLitter.TabIndex = 2;
            btnLitter.Text = "Clean Litter Box";
            btnLitter.UseVisualStyleBackColor = true;
            btnLitter.Click += btnLitter_Click;
            // 
            // lblCare
            // 
            lblCare.AutoSize = true;
            lblCare.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCare.Location = new Point(17, 14);
            lblCare.Name = "lblCare";
            lblCare.Size = new Size(36, 17);
            lblCare.TabIndex = 0;
            lblCare.Text = "Care";
            // 
            // StatusPanel
            // 
            StatusPanel.Controls.Add(lblHappy);
            StatusPanel.Controls.Add(lblClean);
            StatusPanel.Controls.Add(lblThirsty);
            StatusPanel.Controls.Add(progressHappiness);
            StatusPanel.Controls.Add(lblHungry);
            StatusPanel.Controls.Add(progressCleanliness);
            StatusPanel.Controls.Add(progressThirst);
            StatusPanel.Controls.Add(progressHunger);
            StatusPanel.Controls.Add(lblStatus);
            StatusPanel.Location = new Point(999, 198);
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new Size(272, 269);
            StatusPanel.TabIndex = 2;
            // 
            // lblHappy
            // 
            lblHappy.AutoSize = true;
            lblHappy.Location = new Point(179, 187);
            lblHappy.Name = "lblHappy";
            lblHappy.Size = new Size(60, 20);
            lblHappy.TabIndex = 8;
            lblHappy.Text = "Happy?";
            // 
            // lblClean
            // 
            lblClean.AutoSize = true;
            lblClean.Location = new Point(180, 141);
            lblClean.Name = "lblClean";
            lblClean.Size = new Size(53, 20);
            lblClean.TabIndex = 7;
            lblClean.Text = "Clean?";
            // 
            // lblThirsty
            // 
            lblThirsty.AutoSize = true;
            lblThirsty.Location = new Point(180, 95);
            lblThirsty.Name = "lblThirsty";
            lblThirsty.Size = new Size(59, 20);
            lblThirsty.TabIndex = 6;
            lblThirsty.Text = "Thirsty?";
            // 
            // progressHappiness
            // 
            progressHappiness.Location = new Point(43, 187);
            progressHappiness.Name = "progressHappiness";
            progressHappiness.Size = new Size(125, 29);
            progressHappiness.TabIndex = 5;
            // 
            // lblHungry
            // 
            lblHungry.AutoSize = true;
            lblHungry.Location = new Point(180, 53);
            lblHungry.Name = "lblHungry";
            lblHungry.Size = new Size(64, 20);
            lblHungry.TabIndex = 4;
            lblHungry.Text = "Hungry?";
            // 
            // progressCleanliness
            // 
            progressCleanliness.Location = new Point(43, 141);
            progressCleanliness.Name = "progressCleanliness";
            progressCleanliness.Size = new Size(125, 29);
            progressCleanliness.TabIndex = 3;
            // 
            // progressThirst
            // 
            progressThirst.Location = new Point(43, 95);
            progressThirst.Name = "progressThirst";
            progressThirst.Size = new Size(125, 29);
            progressThirst.TabIndex = 2;
            // 
            // progressHunger
            // 
            progressHunger.Location = new Point(43, 53);
            progressHunger.Name = "progressHunger";
            progressHunger.Size = new Size(125, 29);
            progressHunger.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(14, 14);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 17);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(lblBreed);
            panel1.Location = new Point(395, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 35);
            panel1.TabIndex = 3;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.Firebrick;
            lblGender.Location = new Point(568, 8);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(103, 20);
            lblGender.TabIndex = 2;
            lblGender.Text = "Gender: Male";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.Firebrick;
            lblAge.Location = new Point(292, 7);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(104, 20);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age: 13 years";
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreed.ForeColor = Color.Firebrick;
            lblBreed.Location = new Point(26, 8);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(109, 20);
            lblBreed.TabIndex = 0;
            lblBreed.Text = "Breed: Tuxedo";
            // 
            // btnNewDay
            // 
            btnNewDay.BackColor = Color.Salmon;
            btnNewDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewDay.ForeColor = Color.White;
            btnNewDay.Location = new Point(1108, 12);
            btnNewDay.Name = "btnNewDay";
            btnNewDay.Size = new Size(139, 35);
            btnNewDay.TabIndex = 4;
            btnNewDay.Text = "New Day / Reset";
            btnNewDay.UseVisualStyleBackColor = false;
            btnNewDay.Click += btnNewDay_Click;
            // 
            // picAction
            // 
            picAction.Location = new Point(583, 385);
            picAction.Name = "picAction";
            picAction.Size = new Size(314, 137);
            picAction.SizeMode = PictureBoxSizeMode.StretchImage;
            picAction.TabIndex = 0;
            picAction.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            BackgroundImage = Properties.Resources.Sylvester_s_Crib;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1601, 647);
            Controls.Add(picAction);
            Controls.Add(btnNewDay);
            Controls.Add(panel1);
            Controls.Add(StatusPanel);
            Controls.Add(CarePanel);
            Controls.Add(ControlPanel);
            ForeColor = Color.IndianRed;
            Name = "MainForm";
            Text = "Sylvester's Crib";
            ControlPanel.ResumeLayout(false);
            ControlPanel.PerformLayout();
            CarePanel.ResumeLayout(false);
            CarePanel.PerformLayout();
            StatusPanel.ResumeLayout(false);
            StatusPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ControlPanel;
        private Button btnTreats;
        private Button btnWater;
        private Label lblFood;
        private Button btnKibble;
        private Button btnWetFood;
        private Panel CarePanel;
        private Button btnPet;
        private Button btnBath;
        private Button btnLitter;
        private Label lblCare;
        private Panel StatusPanel;
        private Label lblStatus;
        private Panel panel1;
        private Label lblGender;
        private Label lblAge;
        private Label lblBreed;
        private Button btnVet;
        private Label lblHungry;
        private ProgressBar progressCleanliness;
        private ProgressBar progressThirst;
        private ProgressBar progressHunger;
        private ProgressBar progressHappiness;
        private Label lblHappy;
        private Label lblClean;
        private Label lblThirsty;
        private Button btnNewDay;
        private PictureBox picAction;
    }
}
