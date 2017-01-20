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
            this.txt_6 = new System.Windows.Forms.TextBox();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.txt_4 = new System.Windows.Forms.TextBox();
            this.txt_5 = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.Combobox_class = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_race = new System.Windows.Forms.ComboBox();
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
            this.btn_next.Location = new System.Drawing.Point(166, 333);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // txt_6
            // 
            this.txt_6.Location = new System.Drawing.Point(0, 277);
            this.txt_6.Name = "txt_6";
            this.txt_6.Size = new System.Drawing.Size(100, 20);
            this.txt_6.TabIndex = 2;
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(0, 39);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(100, 20);
            this.txt_1.TabIndex = 3;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(0, 84);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(100, 20);
            this.txt_2.TabIndex = 4;
            // 
            // txt_3
            // 
            this.txt_3.Location = new System.Drawing.Point(0, 143);
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(100, 20);
            this.txt_3.TabIndex = 5;
            // 
            // txt_4
            // 
            this.txt_4.Location = new System.Drawing.Point(0, 191);
            this.txt_4.Name = "txt_4";
            this.txt_4.Size = new System.Drawing.Size(100, 20);
            this.txt_4.TabIndex = 6;
            // 
            // txt_5
            // 
            this.txt_5.Location = new System.Drawing.Point(0, 233);
            this.txt_5.Name = "txt_5";
            this.txt_5.Size = new System.Drawing.Size(100, 20);
            this.txt_5.TabIndex = 7;
            // 
            // c
            // 
            this.c.FormattingEnabled = true;
            this.c.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.c.Location = new System.Drawing.Point(139, 37);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(121, 21);
            this.c.TabIndex = 8;
            this.c.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.comboBox3.Location = new System.Drawing.Point(139, 189);
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
            this.comboBox4.Location = new System.Drawing.Point(139, 143);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
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
            this.label2.Location = new System.Drawing.Point(308, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Character class";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 231);
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
            // StatRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_race);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Combobox_class);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.c);
            this.Controls.Add(this.txt_5);
            this.Controls.Add(this.txt_4);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.txt_6);
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
        private System.Windows.Forms.TextBox txt_6;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.TextBox txt_4;
        private System.Windows.Forms.TextBox txt_5;
        private System.Windows.Forms.ComboBox c;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ComboBox Combobox_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_race;
    }
}