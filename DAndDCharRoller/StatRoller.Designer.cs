namespace DAndDCharRoller
{
    partial class StatRoller
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
            this.btn_reroll = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.txt_stat6 = new System.Windows.Forms.TextBox();
            this.txt_stat1 = new System.Windows.Forms.TextBox();
            this.txt_stat2 = new System.Windows.Forms.TextBox();
            this.txt_stat3 = new System.Windows.Forms.TextBox();
            this.txt_stat4 = new System.Windows.Forms.TextBox();
            this.txt_stat5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.Combobox_class = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_race = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbo_law = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_template = new System.Windows.Forms.ComboBox();
            this.cmbo_alighnment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_dicerolls = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_reroll
            // 
            this.btn_reroll.Location = new System.Drawing.Point(12, 323);
            this.btn_reroll.Name = "btn_reroll";
            this.btn_reroll.Size = new System.Drawing.Size(75, 23);
            this.btn_reroll.TabIndex = 0;
            this.btn_reroll.Text = "Reroll";
            this.btn_reroll.UseVisualStyleBackColor = true;
            this.btn_reroll.Click += new System.EventHandler(this.btn_reroll_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(165, 323);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // txt_stat6
            // 
            this.txt_stat6.Enabled = false;
            this.txt_stat6.Location = new System.Drawing.Point(0, 277);
            this.txt_stat6.Name = "txt_stat6";
            this.txt_stat6.Size = new System.Drawing.Size(100, 20);
            this.txt_stat6.TabIndex = 2;
            // 
            // txt_stat1
            // 
            this.txt_stat1.Enabled = false;
            this.txt_stat1.Location = new System.Drawing.Point(0, 39);
            this.txt_stat1.Name = "txt_stat1";
            this.txt_stat1.Size = new System.Drawing.Size(100, 20);
            this.txt_stat1.TabIndex = 3;
            // 
            // txt_stat2
            // 
            this.txt_stat2.Enabled = false;
            this.txt_stat2.Location = new System.Drawing.Point(0, 84);
            this.txt_stat2.Name = "txt_stat2";
            this.txt_stat2.Size = new System.Drawing.Size(100, 20);
            this.txt_stat2.TabIndex = 4;
            // 
            // txt_stat3
            // 
            this.txt_stat3.Enabled = false;
            this.txt_stat3.Location = new System.Drawing.Point(0, 143);
            this.txt_stat3.Name = "txt_stat3";
            this.txt_stat3.Size = new System.Drawing.Size(100, 20);
            this.txt_stat3.TabIndex = 5;
            // 
            // txt_stat4
            // 
            this.txt_stat4.Enabled = false;
            this.txt_stat4.Location = new System.Drawing.Point(0, 191);
            this.txt_stat4.Name = "txt_stat4";
            this.txt_stat4.Size = new System.Drawing.Size(100, 20);
            this.txt_stat4.TabIndex = 6;
            // 
            // txt_stat5
            // 
            this.txt_stat5.Enabled = false;
            this.txt_stat5.Location = new System.Drawing.Point(0, 233);
            this.txt_stat5.Name = "txt_stat5";
            this.txt_stat5.Size = new System.Drawing.Size(100, 20);
            this.txt_stat5.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.comboBox1.Location = new System.Drawing.Point(139, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.comboBox2.Location = new System.Drawing.Point(139, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.comboBox3.Location = new System.Drawing.Point(139, 145);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.comboBox4.Location = new System.Drawing.Point(139, 190);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 10;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.comboBox5.Location = new System.Drawing.Point(139, 232);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 13;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.comboBox6.Location = new System.Drawing.Point(139, 276);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 12;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(417, 109);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Character Name";
            // 
            // Combobox_class
            // 
            this.Combobox_class.FormattingEnabled = true;
            this.Combobox_class.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Magic-User/Mage/Wizard",
            "Monk/Mystic",
            "Paladin",
            "Ranger",
            "Sorcerer",
            "Thief/Rogue",
            "Warlock"});
            this.Combobox_class.Location = new System.Drawing.Point(417, 277);
            this.Combobox_class.Name = "Combobox_class";
            this.Combobox_class.Size = new System.Drawing.Size(121, 21);
            this.Combobox_class.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Character Class";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Race";
            // 
            // comboBox_race
            // 
            this.comboBox_race.FormattingEnabled = true;
            this.comboBox_race.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half-Elves",
            "Half-Orcs",
            "Halfling",
            "Human"});
            this.comboBox_race.Location = new System.Drawing.Point(417, 232);
            this.comboBox_race.Name = "comboBox_race";
            this.comboBox_race.Size = new System.Drawing.Size(121, 21);
            this.comboBox_race.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Alignment";
            // 
            // cmbo_law
            // 
            this.cmbo_law.FormattingEnabled = true;
            this.cmbo_law.Items.AddRange(new object[] {
            "Lawful",
            "neutral",
            "Chaotic"});
            this.cmbo_law.Location = new System.Drawing.Point(385, 145);
            this.cmbo_law.Name = "cmbo_law";
            this.cmbo_law.Size = new System.Drawing.Size(121, 21);
            this.cmbo_law.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Template";
            // 
            // comboBox_template
            // 
            this.comboBox_template.FormattingEnabled = true;
            this.comboBox_template.Location = new System.Drawing.Point(417, 191);
            this.comboBox_template.Name = "comboBox_template";
            this.comboBox_template.Size = new System.Drawing.Size(121, 21);
            this.comboBox_template.TabIndex = 20;
            // 
            // cmbo_alighnment
            // 
            this.cmbo_alighnment.FormattingEnabled = true;
            this.cmbo_alighnment.Items.AddRange(new object[] {
            "good",
            "neutral",
            "evil"});
            this.cmbo_alighnment.Location = new System.Drawing.Point(512, 145);
            this.cmbo_alighnment.Name = "cmbo_alighnment";
            this.cmbo_alighnment.Size = new System.Drawing.Size(121, 21);
            this.cmbo_alighnment.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Change Dice Roll Options";
            // 
            // comboBox_dicerolls
            // 
            this.comboBox_dicerolls.FormattingEnabled = true;
            this.comboBox_dicerolls.Items.AddRange(new object[] {
            "3d6",
            "4d6 drop 1",
            "5d6 drop 2",
            "elite array ",
            "non elite array"});
            this.comboBox_dicerolls.Location = new System.Drawing.Point(139, 10);
            this.comboBox_dicerolls.Name = "comboBox_dicerolls";
            this.comboBox_dicerolls.Size = new System.Drawing.Size(121, 21);
            this.comboBox_dicerolls.TabIndex = 25;
            this.comboBox_dicerolls.SelectedIndexChanged += new System.EventHandler(this.comboBox_dicerolls_SelectedIndexChanged);
            // 
            // StatRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 358);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_dicerolls);
            this.Controls.Add(this.cmbo_alighnment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbo_law);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_template);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_race);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Combobox_class);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_stat5);
            this.Controls.Add(this.txt_stat4);
            this.Controls.Add(this.txt_stat3);
            this.Controls.Add(this.txt_stat2);
            this.Controls.Add(this.txt_stat1);
            this.Controls.Add(this.txt_stat6);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_reroll);
            this.Name = "StatRoller";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.StatRoller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reroll;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TextBox txt_stat6;
        private System.Windows.Forms.TextBox txt_stat1;
        private System.Windows.Forms.TextBox txt_stat2;
        private System.Windows.Forms.TextBox txt_stat3;
        private System.Windows.Forms.TextBox txt_stat4;
        private System.Windows.Forms.TextBox txt_stat5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ComboBox Combobox_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_race;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbo_law;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_template;
        private System.Windows.Forms.ComboBox cmbo_alighnment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_dicerolls;
    }
}