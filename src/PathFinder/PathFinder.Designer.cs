namespace PathFinder
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
            this.labelPlaces = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listPlaces = new System.Windows.Forms.ListBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPathFinder
            // 
            this.labelPathFinder.AutoSize = true;
            this.labelPathFinder.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathFinder.Location = new System.Drawing.Point(478, 28);
            this.labelPathFinder.Name = "labelPathFinder";
            this.labelPathFinder.Size = new System.Drawing.Size(252, 49);
            this.labelPathFinder.TabIndex = 1;
            this.labelPathFinder.Text = "PATH FINDER";
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
            this.labelStart.Location = new System.Drawing.Point(56, 426);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(128, 29);
            this.labelStart.TabIndex = 7;
            this.labelStart.Text = "Start point:";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnd.Location = new System.Drawing.Point(56, 516);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(116, 29);
            this.labelEnd.TabIndex = 8;
            this.labelEnd.Text = "End point:";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStart.Location = new System.Drawing.Point(61, 460);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(187, 32);
            this.textBoxStart.TabIndex = 9;
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnd.Location = new System.Drawing.Point(60, 548);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(187, 32);
            this.textBoxEnd.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(472, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 582);
            this.panel1.TabIndex = 11;
            // 
            // buttonVisualize
            // 
            this.buttonVisualize.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisualize.Location = new System.Drawing.Point(60, 593);
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
            this.labelNotif.Location = new System.Drawing.Point(66, 651);
            this.labelNotif.Name = "labelNotif";
            this.labelNotif.Size = new System.Drawing.Size(0, 29);
            this.labelNotif.TabIndex = 13;
            // 
            // labelPlaces
            // 
            this.labelPlaces.AutoSize = true;
            this.labelPlaces.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaces.Location = new System.Drawing.Point(59, 279);
            this.labelPlaces.Name = "labelPlaces";
            this.labelPlaces.Size = new System.Drawing.Size(83, 29);
            this.labelPlaces.TabIndex = 15;
            this.labelPlaces.Text = "Places:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "GENERATE PLACES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_generate);
            // 
            // listPlaces
            // 
            this.listPlaces.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPlaces.FormattingEnabled = true;
            this.listPlaces.ItemHeight = 24;
            this.listPlaces.Location = new System.Drawing.Point(64, 311);
            this.listPlaces.Name = "listPlaces";
            this.listPlaces.ScrollAlwaysVisible = true;
            this.listPlaces.Size = new System.Drawing.Size(335, 100);
            this.listPlaces.TabIndex = 17;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(60, 171);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(103, 36);
            this.buttonBrowse.TabIndex = 18;
            this.buttonBrowse.Text = "BROWSE";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelFile
            // 
            this.labelFile.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(69, 133);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(204, 29);
            this.labelFile.TabIndex = 19;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxFile.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFile.Location = new System.Drawing.Point(60, 130);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.ReadOnly = true;
            this.textBoxFile.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxFile.Size = new System.Drawing.Size(213, 32);
            this.textBoxFile.TabIndex = 20;
            // 
            // PathFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1222, 768);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.listPlaces);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPlaces);
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
            this.Controls.Add(this.labelPathFinder);
            this.Name = "PathFinder";
            this.Text = "Path Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPathFinder;
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
        private System.Windows.Forms.Label labelPlaces;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listPlaces;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.TextBox textBoxFile;
    }
}

