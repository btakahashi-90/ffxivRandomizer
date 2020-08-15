namespace ffxivRando
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
            this.cBox = new System.Windows.Forms.ListBox();
            this.qBox = new System.Windows.Forms.ListBox();
            this.tanks = new System.Windows.Forms.Button();
            this.healers = new System.Windows.Forms.Button();
            this.melee = new System.Windows.Forms.Button();
            this.ranged = new System.Windows.Forms.Button();
            this.magic = new System.Windows.Forms.Button();
            this.selectAll = new System.Windows.Forms.Button();
            this.clearClasses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBox
            // 
            this.cBox.FormattingEnabled = true;
            this.cBox.Items.AddRange(new object[] {
            "Paladin",
            "Warrior",
            "Dark Knight",
            "Gunbreaker",
            "White Mage",
            "Scholar",
            "Astrologian",
            "Monk",
            "Dragoon",
            "Ninja",
            "Samurai",
            "Bard",
            "Machinist",
            "Dancer",
            "Black Mage",
            "Summoner",
            "Red Mage"});
            this.cBox.Location = new System.Drawing.Point(191, 33);
            this.cBox.Name = "cBox";
            this.cBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.cBox.Size = new System.Drawing.Size(144, 225);
            this.cBox.TabIndex = 1;
            // 
            // qBox
            // 
            this.qBox.FormattingEnabled = true;
            this.qBox.Items.AddRange(new object[] {
            "Expert",
            "Level 80 Dungeon",
            "Level 50/60/70 Dungeon",
            "Leveling",
            "Trials",
            "MSQ",
            "Guildhests",
            "Alliance Raids",
            "Normal Raids"});
            this.qBox.Location = new System.Drawing.Point(12, 33);
            this.qBox.Name = "qBox";
            this.qBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.qBox.Size = new System.Drawing.Size(144, 121);
            this.qBox.TabIndex = 2;
            // 
            // tanks
            // 
            this.tanks.Location = new System.Drawing.Point(367, 61);
            this.tanks.Name = "tanks";
            this.tanks.Size = new System.Drawing.Size(81, 23);
            this.tanks.TabIndex = 3;
            this.tanks.Text = "Tanks";
            this.tanks.UseVisualStyleBackColor = true;
            // 
            // healers
            // 
            this.healers.Location = new System.Drawing.Point(367, 90);
            this.healers.Name = "healers";
            this.healers.Size = new System.Drawing.Size(81, 23);
            this.healers.TabIndex = 4;
            this.healers.Text = "Healers";
            this.healers.UseVisualStyleBackColor = true;
            // 
            // melee
            // 
            this.melee.Location = new System.Drawing.Point(367, 120);
            this.melee.Name = "melee";
            this.melee.Size = new System.Drawing.Size(81, 23);
            this.melee.TabIndex = 5;
            this.melee.Text = "Melee DPS";
            this.melee.UseVisualStyleBackColor = true;
            // 
            // ranged
            // 
            this.ranged.Location = new System.Drawing.Point(367, 150);
            this.ranged.Name = "ranged";
            this.ranged.Size = new System.Drawing.Size(81, 23);
            this.ranged.TabIndex = 6;
            this.ranged.Text = "Ranged DPS";
            this.ranged.UseVisualStyleBackColor = true;
            // 
            // magic
            // 
            this.magic.Location = new System.Drawing.Point(367, 180);
            this.magic.Name = "magic";
            this.magic.Size = new System.Drawing.Size(81, 23);
            this.magic.TabIndex = 7;
            this.magic.Text = "Magic DPS";
            this.magic.UseVisualStyleBackColor = true;
            // 
            // selectAll
            // 
            this.selectAll.Location = new System.Drawing.Point(367, 33);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(81, 23);
            this.selectAll.TabIndex = 8;
            this.selectAll.Text = "All";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
            // 
            // clearClasses
            // 
            this.clearClasses.Location = new System.Drawing.Point(191, 265);
            this.clearClasses.Name = "clearClasses";
            this.clearClasses.Size = new System.Drawing.Size(144, 23);
            this.clearClasses.TabIndex = 9;
            this.clearClasses.Text = "Clear Selected";
            this.clearClasses.UseVisualStyleBackColor = true;
            this.clearClasses.Click += new System.EventHandler(this.clearClasses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 386);
            this.Controls.Add(this.clearClasses);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.magic);
            this.Controls.Add(this.ranged);
            this.Controls.Add(this.melee);
            this.Controls.Add(this.healers);
            this.Controls.Add(this.tanks);
            this.Controls.Add(this.qBox);
            this.Controls.Add(this.cBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox cBox;
        private System.Windows.Forms.ListBox qBox;
        private System.Windows.Forms.Button tanks;
        private System.Windows.Forms.Button healers;
        private System.Windows.Forms.Button melee;
        private System.Windows.Forms.Button ranged;
        private System.Windows.Forms.Button magic;
        private System.Windows.Forms.Button selectAll;
        private System.Windows.Forms.Button clearClasses;
    }
}

