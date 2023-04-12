﻿namespace PathFinder
{
    partial class PathFinder
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
            this.labelPathFinder = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelMethod = new System.Windows.Forms.Label();
            this.buttonUCS = new System.Windows.Forms.RadioButton();
            this.buttonA = new System.Windows.Forms.RadioButton();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonVisualize = new System.Windows.Forms.Button();
            this.labelNotif = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPlaces = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPathFinder
            // 
            this.labelPathFinder.AutoSize = true;
            this.labelPathFinder.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathFinder.Location = new System.Drawing.Point(394, 24);
            this.labelPathFinder.Name = "labelPathFinder";
            this.labelPathFinder.Size = new System.Drawing.Size(252, 49);
            this.labelPathFinder.TabIndex = 1;
            this.labelPathFinder.Text = "PATH FINDER";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileName.Location = new System.Drawing.Point(60, 131);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(187, 32);
            this.textBoxFileName.TabIndex = 2;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(56, 98);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(111, 29);
            this.labelFileName.TabIndex = 3;
            this.labelFileName.Text = "Filename:";
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMethod.Location = new System.Drawing.Point(296, 108);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(99, 29);
            this.labelMethod.TabIndex = 4;
            this.labelMethod.Text = "Method:";
            // 
            // buttonUCS
            // 
            this.buttonUCS.AutoSize = true;
            this.buttonUCS.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUCS.Location = new System.Drawing.Point(301, 144);
            this.buttonUCS.Name = "buttonUCS";
            this.buttonUCS.Size = new System.Drawing.Size(70, 28);
            this.buttonUCS.TabIndex = 5;
            this.buttonUCS.TabStop = true;
            this.buttonUCS.Text = "UCS";
            this.buttonUCS.UseVisualStyleBackColor = true;
            // 
            // buttonA
            // 
            this.buttonA.AutoSize = true;
            this.buttonA.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.Location = new System.Drawing.Point(301, 178);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(57, 28);
            this.buttonA.TabIndex = 6;
            this.buttonA.TabStop = true;
            this.buttonA.Text = "A*";
            this.buttonA.UseVisualStyleBackColor = true;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(56, 367);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(128, 29);
            this.labelStart.TabIndex = 7;
            this.labelStart.Text = "Start point:";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnd.Location = new System.Drawing.Point(56, 457);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(116, 29);
            this.labelEnd.TabIndex = 8;
            this.labelEnd.Text = "End point:";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStart.Location = new System.Drawing.Point(61, 401);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(187, 32);
            this.textBoxStart.TabIndex = 9;
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnd.Location = new System.Drawing.Point(60, 489);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(187, 32);
            this.textBoxEnd.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(472, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 395);
            this.panel1.TabIndex = 11;
            // 
            // buttonVisualize
            // 
            this.buttonVisualize.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisualize.Location = new System.Drawing.Point(60, 534);
            this.buttonVisualize.Name = "buttonVisualize";
            this.buttonVisualize.Size = new System.Drawing.Size(111, 36);
            this.buttonVisualize.TabIndex = 12;
            this.buttonVisualize.Text = "VISUALIZE";
            this.buttonVisualize.UseVisualStyleBackColor = true;
            this.buttonVisualize.Click += new System.EventHandler(this.buttonVisualize_Click);
            // 
            // labelNotif
            // 
            this.labelNotif.AutoSize = true;
            this.labelNotif.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotif.Location = new System.Drawing.Point(66, 592);
            this.labelNotif.Name = "labelNotif";
            this.labelNotif.Size = new System.Drawing.Size(0, 29);
            this.labelNotif.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(61, 253);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(334, 95);
            this.textBox1.TabIndex = 14;
            // 
            // labelPlaces
            // 
            this.labelPlaces.AutoSize = true;
            this.labelPlaces.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaces.Location = new System.Drawing.Point(59, 220);
            this.labelPlaces.Name = "labelPlaces";
            this.labelPlaces.Size = new System.Drawing.Size(83, 29);
            this.labelPlaces.TabIndex = 15;
            this.labelPlaces.Text = "Places:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "GENERATE PLACES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_generate);
            // 
            // PathFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1077, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPlaces);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNotif);
            this.Controls.Add(this.buttonVisualize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxEnd);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonUCS);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.labelPathFinder);
            this.Name = "PathFinder";
            this.Text = "Path Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPathFinder;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.RadioButton buttonUCS;
        private System.Windows.Forms.RadioButton buttonA;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVisualize;
        private System.Windows.Forms.Label labelNotif;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPlaces;
        private System.Windows.Forms.Button button1;
    }
}

