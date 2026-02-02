// ========= DISCLAIMER - Sylvester's Crib =========
// This source code was written and implemented by me inside Visual Studio.
// I did not copy a completed project from another person or submit AI-generated
// code as-is.
//
// I used ChatGPT strictly as a support tool to help me:
// - brainstorm features and UI ideas
// - understand WinForms concepts
// - troubleshoot logic
//
// All final decisions, edits, testing, and understanding of this code
// were done by me in my own words.
// ================================================


// Allows access to basic system functionality
using System;

// Allows access to Windows Forms UI controls
using System.Windows.Forms;


// Namespace for my project
namespace Sylvesters_Crib
{
    // Main form class for the application
    public partial class MainForm : Form
    {
        // These integers track Sylvester’s needs as percentages (0–100)

        int hunger = 0;        // How hungry Sylvester is
        int thirst = 0;        // How thirsty Sylvester is
        int cleanliness = 0;   // How clean Sylvester is
        int happiness = 0;     // How happy Sylvester is


        // Constructor runs when the form is created
        public MainForm()
        {
            // Initializes all controls created in the Designer
            InitializeComponent();

            // MainForm
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
            Load += MainForm_Load;

        }


        // Runs once when the form finishes loading
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Sync progress bars with starting values
            UpdateStatusBars();

            UpdateStatusBars();
            picAction.Image = Properties.Resources.Needy;
            picAction.Visible = true;
        }

        // Returns true if celebration GIF was shown
        private bool CheckForCompletion()
        {
            if (hunger == 100 || thirst == 100 || cleanliness == 100 || happiness == 100)
            {
                ShowActionGif(Properties.Resources.Dance);
                return true;
            }

            return false;
        }


        // Updates the UI to reflect current stat values
        // This method ONLY displays values, it does NOT change logic
        // Updates progress bars only when values actually change
        private void UpdateStatusBars()
        {
            if (progressHunger.Value != hunger)
                progressHunger.Value = hunger;

            if (progressThirst.Value != thirst)
                progressThirst.Value = thirst;

            if (progressCleanliness.Value != cleanliness)
                progressCleanliness.Value = cleanliness;

            if (progressHappiness.Value != happiness)
                progressHappiness.Value = happiness;
        }

        // Shows a temporary GIF inside the form without affecting logic
        private void ShowActionGif(Image gif)
        {
            picAction.Image = gif;      // Set the GIF
            picAction.Visible = true;   // Show it

        }


        // =========================
        // FEED ME PANEL
        // =========================

        // Kibble: increases hunger more than happiness
        private void btnKibble_Click(object sender, EventArgs e)
        {
            hunger = Math.Min(hunger + 20, 100);      // main effect
            happiness = Math.Min(happiness + 5, 100); // small bonus

            UpdateStatusBars();

            bool completed = CheckForCompletion();

            if (!completed)
            {
                ShowActionGif(Image.FromFile("kibblewetfood.gif"));
            }
        }

        // Wet Food: increases hunger more than happiness
        private void btnWetFood_Click(object sender, EventArgs e)
        {
            hunger = Math.Min(hunger + 30, 100);      // main effect
            happiness = Math.Min(happiness + 10, 100); // smaller effect

            UpdateStatusBars();

            bool completed = CheckForCompletion();

            if (!completed)
            {
                ShowActionGif(Image.FromFile("kibblewetfood.gif"));
            }
        }

        // Water: increases thirst and a small happiness boost
        private void btnWater_Click(object sender, EventArgs e)
        {
            thirst = Math.Min(thirst + 25, 100);      // main effect
            happiness = Math.Min(happiness + 5, 100); // small bonus

            UpdateStatusBars();

            bool completed = CheckForCompletion();

            if (!completed)
            {
                ShowActionGif(Image.FromFile("water.gif"));
            }
        }

        // Treats / Snacks: ONLY increase happiness
        private void btnTreats_Click(object sender, EventArgs e)
        {
            happiness = Math.Min(happiness + 20, 100);

            UpdateStatusBars();

            bool completed = CheckForCompletion();

            if (!completed)
            {
                ShowActionGif(Image.FromFile("treats.gif"));
            }
        }

        // =========================
        // CARE PANEL
        // =========================

        // Clean Litter Box: increases cleanliness more than happiness
        private void btnLitter_Click(object sender, EventArgs e)
        {
            cleanliness = Math.Min(cleanliness + 30, 100); // main effect
            happiness = Math.Min(happiness + 5, 100);      // small bonus

            UpdateStatusBars();

            bool completed = CheckForCompletion();

            if (!completed)
            {
                ShowActionGif(Image.FromFile("litter.gif"));
            }
        }

        // Wash Me: ONLY increases cleanliness
        private void btnBath_Click(object sender, EventArgs e)
        {
            cleanliness = Math.Min(cleanliness + 25, 100);

            UpdateStatusBars();

            bool completed = CheckForCompletion();

            if (!completed)
            {
                ShowActionGif(Image.FromFile("wash.gif"));
            }
        }

        // Pet Me: ONLY increases happiness
        private void btnPet_Click(object sender, EventArgs e)
        {
            happiness = Math.Min(happiness + 20, 100);

            UpdateStatusBars();

            CheckForCompletion();

            ShowActionGif(Properties.Resources.petMe);

        }

        // Vet: decreases happiness slightly (stressful visit)
        private void btnVet_Click(object sender, EventArgs e)
        {
            happiness = Math.Max(happiness - 10, 0);

            UpdateStatusBars();

            bool completed = CheckForCompletion();

            if (!completed)
            {
                ShowActionGif(Image.FromFile("vet.gif"));
            }
        }

        // Runs when the "New Day / Reset" button is clicked
        private void btnNewDay_Click(object sender, EventArgs e)
        {
            // Reset all simulation values back to zero
            // This represents starting a fresh day with Sylvester

            hunger = 0;        // Sylvester starts the day hungry
            thirst = 0;        // Needs fresh water
            cleanliness = 0;   // Needs cleaning
            happiness = 0;     // Mood resets

            // Update the progress bars to match the reset values
            UpdateStatusBars();

            // Reset the animation back to idle
            picAction.Image = Properties.Resources.sleepy;
            picAction.Visible = true;


        }

    }

}
