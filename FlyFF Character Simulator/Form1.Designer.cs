namespace FlyFF_Character_Simulator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.intro = new System.Windows.Forms.TabPage();
            this.basic = new System.Windows.Forms.TabPage();
            this.SexBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weapons = new System.Windows.Forms.TabPage();
            this.armor = new System.Windows.Forms.TabPage();
            this.jewelry = new System.Windows.Forms.TabPage();
            this.fashion = new System.Windows.Forms.TabPage();
            this.buffs = new System.Windows.Forms.TabPage();
            this.pets = new System.Windows.Forms.TabPage();
            this.limited = new System.Windows.Forms.TabPage();
            this.manual = new System.Windows.Forms.TabPage();
            this.credits = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.basic.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.intro);
            this.tabControl1.Controls.Add(this.basic);
            this.tabControl1.Controls.Add(this.weapons);
            this.tabControl1.Controls.Add(this.armor);
            this.tabControl1.Controls.Add(this.jewelry);
            this.tabControl1.Controls.Add(this.fashion);
            this.tabControl1.Controls.Add(this.buffs);
            this.tabControl1.Controls.Add(this.pets);
            this.tabControl1.Controls.Add(this.limited);
            this.tabControl1.Controls.Add(this.manual);
            this.tabControl1.Controls.Add(this.credits);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 722);
            this.tabControl1.TabIndex = 0;
            // 
            // intro
            // 
            this.intro.Location = new System.Drawing.Point(4, 25);
            this.intro.Name = "intro";
            this.intro.Padding = new System.Windows.Forms.Padding(3);
            this.intro.Size = new System.Drawing.Size(760, 693);
            this.intro.TabIndex = 0;
            this.intro.Text = "Intro";
            this.intro.UseVisualStyleBackColor = true;
            // 
            // basic
            // 
            this.basic.Controls.Add(this.SexBox);
            this.basic.Controls.Add(this.label1);
            this.basic.Location = new System.Drawing.Point(4, 25);
            this.basic.Name = "basic";
            this.basic.Padding = new System.Windows.Forms.Padding(3);
            this.basic.Size = new System.Drawing.Size(760, 693);
            this.basic.TabIndex = 1;
            this.basic.Text = "Basic Info";
            this.basic.UseVisualStyleBackColor = true;
            // 
            // SexBox
            // 
            this.SexBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexBox.FormattingEnabled = true;
            this.SexBox.Location = new System.Drawing.Point(9, 28);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(121, 24);
            this.SexBox.TabIndex = 1;
            this.SexBox.SelectedIndexChanged += new System.EventHandler(this.SexBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character Type:";
            // 
            // weapons
            // 
            this.weapons.Location = new System.Drawing.Point(4, 25);
            this.weapons.Name = "weapons";
            this.weapons.Size = new System.Drawing.Size(760, 693);
            this.weapons.TabIndex = 2;
            this.weapons.Text = "Weapons";
            this.weapons.UseVisualStyleBackColor = true;
            // 
            // armor
            // 
            this.armor.Location = new System.Drawing.Point(4, 25);
            this.armor.Name = "armor";
            this.armor.Size = new System.Drawing.Size(760, 693);
            this.armor.TabIndex = 3;
            this.armor.Text = "Armor";
            this.armor.UseVisualStyleBackColor = true;
            // 
            // jewelry
            // 
            this.jewelry.Location = new System.Drawing.Point(4, 25);
            this.jewelry.Name = "jewelry";
            this.jewelry.Size = new System.Drawing.Size(760, 693);
            this.jewelry.TabIndex = 4;
            this.jewelry.Text = "Jewelry";
            this.jewelry.UseVisualStyleBackColor = true;
            // 
            // fashion
            // 
            this.fashion.Location = new System.Drawing.Point(4, 25);
            this.fashion.Name = "fashion";
            this.fashion.Size = new System.Drawing.Size(760, 693);
            this.fashion.TabIndex = 5;
            this.fashion.Text = "Fashion";
            this.fashion.UseVisualStyleBackColor = true;
            // 
            // buffs
            // 
            this.buffs.Location = new System.Drawing.Point(4, 25);
            this.buffs.Name = "buffs";
            this.buffs.Size = new System.Drawing.Size(760, 693);
            this.buffs.TabIndex = 6;
            this.buffs.Text = "Buffs/Skills";
            this.buffs.UseVisualStyleBackColor = true;
            // 
            // pets
            // 
            this.pets.Location = new System.Drawing.Point(4, 25);
            this.pets.Name = "pets";
            this.pets.Size = new System.Drawing.Size(760, 693);
            this.pets.TabIndex = 7;
            this.pets.Text = "Pets";
            this.pets.UseVisualStyleBackColor = true;
            // 
            // limited
            // 
            this.limited.Location = new System.Drawing.Point(4, 25);
            this.limited.Name = "limited";
            this.limited.Size = new System.Drawing.Size(760, 693);
            this.limited.TabIndex = 8;
            this.limited.Text = "Limited";
            this.limited.UseVisualStyleBackColor = true;
            // 
            // manual
            // 
            this.manual.Location = new System.Drawing.Point(4, 25);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(760, 693);
            this.manual.TabIndex = 9;
            this.manual.Text = "Manual Bonus";
            this.manual.UseVisualStyleBackColor = true;
            // 
            // credits
            // 
            this.credits.Location = new System.Drawing.Point(4, 25);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(760, 693);
            this.credits.TabIndex = 10;
            this.credits.Text = "Credits";
            this.credits.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 723);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.basic.ResumeLayout(false);
            this.basic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage intro;
        private System.Windows.Forms.TabPage basic;
        private System.Windows.Forms.TabPage weapons;
        private System.Windows.Forms.TabPage armor;
        private System.Windows.Forms.TabPage jewelry;
        private System.Windows.Forms.TabPage fashion;
        private System.Windows.Forms.TabPage buffs;
        private System.Windows.Forms.TabPage pets;
        private System.Windows.Forms.TabPage limited;
        private System.Windows.Forms.TabPage manual;
        private System.Windows.Forms.TabPage credits;
        private System.Windows.Forms.ComboBox SexBox;
        private System.Windows.Forms.Label label1;

    }
}

