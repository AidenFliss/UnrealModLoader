
namespace UnrealModLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.modsListBox1 = new System.Windows.Forms.CheckedListBox();
            this.applyButton1 = new System.Windows.Forms.Button();
            this.modLabel1 = new System.Windows.Forms.Label();
            this.changePathButton1 = new System.Windows.Forms.Button();
            this.gamePathText1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.changePathButton2 = new System.Windows.Forms.Button();
            this.refreshButton1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.launchGameButton1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // modsListBox1
            // 
            this.modsListBox1.FormattingEnabled = true;
            this.modsListBox1.Items.AddRange(new object[] {
            "Mods appear here"});
            this.modsListBox1.Location = new System.Drawing.Point(12, 171);
            this.modsListBox1.Name = "modsListBox1";
            this.modsListBox1.Size = new System.Drawing.Size(289, 289);
            this.modsListBox1.TabIndex = 0;
            // 
            // applyButton1
            // 
            this.applyButton1.Location = new System.Drawing.Point(13, 469);
            this.applyButton1.Name = "applyButton1";
            this.applyButton1.Size = new System.Drawing.Size(288, 23);
            this.applyButton1.TabIndex = 1;
            this.applyButton1.Text = "Apply Changes";
            this.applyButton1.UseVisualStyleBackColor = true;
            this.applyButton1.Click += new System.EventHandler(this.applyButton1_Click);
            // 
            // modLabel1
            // 
            this.modLabel1.AutoSize = true;
            this.modLabel1.Location = new System.Drawing.Point(139, 160);
            this.modLabel1.Name = "modLabel1";
            this.modLabel1.Size = new System.Drawing.Size(33, 13);
            this.modLabel1.TabIndex = 2;
            this.modLabel1.Text = "Mods";
            // 
            // changePathButton1
            // 
            this.changePathButton1.Location = new System.Drawing.Point(277, 109);
            this.changePathButton1.Name = "changePathButton1";
            this.changePathButton1.Size = new System.Drawing.Size(24, 23);
            this.changePathButton1.TabIndex = 3;
            this.changePathButton1.Text = "...";
            this.changePathButton1.UseVisualStyleBackColor = true;
            this.changePathButton1.Click += new System.EventHandler(this.changePathButton1_Click);
            // 
            // gamePathText1
            // 
            this.gamePathText1.Location = new System.Drawing.Point(13, 111);
            this.gamePathText1.Name = "gamePathText1";
            this.gamePathText1.ReadOnly = true;
            this.gamePathText1.Size = new System.Drawing.Size(258, 20);
            this.gamePathText1.TabIndex = 4;
            this.gamePathText1.Text = "Path to Game (paks folder)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unreal Engine Mod Loader\r\nThis only supports games that load additional .pak file" +
    "s\r\nAll mod paks must start with \"pakchunk99-\" for it to work";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Path to disabled mods";
            // 
            // changePathButton2
            // 
            this.changePathButton2.Location = new System.Drawing.Point(276, 83);
            this.changePathButton2.Name = "changePathButton2";
            this.changePathButton2.Size = new System.Drawing.Size(24, 23);
            this.changePathButton2.TabIndex = 6;
            this.changePathButton2.Text = "...";
            this.changePathButton2.UseVisualStyleBackColor = true;
            this.changePathButton2.Click += new System.EventHandler(this.changePathButton2_Click);
            // 
            // refreshButton1
            // 
            this.refreshButton1.Location = new System.Drawing.Point(13, 56);
            this.refreshButton1.Name = "refreshButton1";
            this.refreshButton1.Size = new System.Drawing.Size(288, 23);
            this.refreshButton1.TabIndex = 8;
            this.refreshButton1.Text = "Refresh";
            this.refreshButton1.UseVisualStyleBackColor = true;
            this.refreshButton1.Click += new System.EventHandler(this.refreshButton1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(258, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Path to Game (exe file)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // launchGameButton1
            // 
            this.launchGameButton1.Location = new System.Drawing.Point(13, 498);
            this.launchGameButton1.Name = "launchGameButton1";
            this.launchGameButton1.Size = new System.Drawing.Size(288, 23);
            this.launchGameButton1.TabIndex = 11;
            this.launchGameButton1.Text = "Launch Game";
            this.launchGameButton1.UseVisualStyleBackColor = true;
            this.launchGameButton1.Click += new System.EventHandler(this.launchGameButton1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(155, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(157, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Close Window after Launch";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 525);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.launchGameButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refreshButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.changePathButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamePathText1);
            this.Controls.Add(this.changePathButton1);
            this.Controls.Add(this.modLabel1);
            this.Controls.Add(this.applyButton1);
            this.Controls.Add(this.modsListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Unreal Mod Loader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox modsListBox1;
        private System.Windows.Forms.Button applyButton1;
        private System.Windows.Forms.Label modLabel1;
        private System.Windows.Forms.Button changePathButton1;
        private System.Windows.Forms.TextBox gamePathText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button changePathButton2;
        private System.Windows.Forms.Button refreshButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button launchGameButton1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

