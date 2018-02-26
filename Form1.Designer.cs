namespace RemotesResourcesExtractor_cSharp
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
            this.tinyPngCB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.appsPrefixTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.remotesDestTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.remotesRootPathTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.removeCommentsCB = new System.Windows.Forms.CheckBox();
            this.tinyPngCB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tinyPngCB
            // 
            this.tinyPngCB.Controls.Add(this.label2);
            this.tinyPngCB.Controls.Add(this.appsPrefixTB);
            this.tinyPngCB.Controls.Add(this.label1);
            this.tinyPngCB.Controls.Add(this.remotesDestTB);
            this.tinyPngCB.Controls.Add(this.label6);
            this.tinyPngCB.Controls.Add(this.remotesRootPathTB);
            this.tinyPngCB.Location = new System.Drawing.Point(12, 12);
            this.tinyPngCB.Name = "tinyPngCB";
            this.tinyPngCB.Size = new System.Drawing.Size(447, 148);
            this.tinyPngCB.TabIndex = 22;
            this.tinyPngCB.TabStop = false;
            this.tinyPngCB.Text = "Remotes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Apps Prefix";
            // 
            // appsPrefixTB
            // 
            this.appsPrefixTB.AllowDrop = true;
            this.appsPrefixTB.Location = new System.Drawing.Point(170, 112);
            this.appsPrefixTB.Name = "appsPrefixTB";
            this.appsPrefixTB.Size = new System.Drawing.Size(242, 20);
            this.appsPrefixTB.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Remotes Destination Path";
            // 
            // remotesDestTB
            // 
            this.remotesDestTB.AllowDrop = true;
            this.remotesDestTB.Location = new System.Drawing.Point(170, 70);
            this.remotesDestTB.Name = "remotesDestTB";
            this.remotesDestTB.Size = new System.Drawing.Size(242, 20);
            this.remotesDestTB.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Remotes Root Path";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // remotesRootPathTB
            // 
            this.remotesRootPathTB.AllowDrop = true;
            this.remotesRootPathTB.Location = new System.Drawing.Point(170, 27);
            this.remotesRootPathTB.Name = "remotesRootPathTB";
            this.remotesRootPathTB.Size = new System.Drawing.Size(242, 20);
            this.remotesRootPathTB.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeCommentsCB
            // 
            this.removeCommentsCB.AutoSize = true;
            this.removeCommentsCB.Location = new System.Drawing.Point(21, 166);
            this.removeCommentsCB.Name = "removeCommentsCB";
            this.removeCommentsCB.Size = new System.Drawing.Size(218, 17);
            this.removeCommentsCB.TabIndex = 23;
            this.removeCommentsCB.Text = "Remove comments from strings.xml files?";
            this.removeCommentsCB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 271);
            this.Controls.Add(this.removeCommentsCB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tinyPngCB);
            this.Name = "Form1";
            this.Text = "Resources Extractor";
            this.tinyPngCB.ResumeLayout(false);
            this.tinyPngCB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox tinyPngCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox remotesRootPathTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox remotesDestTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox appsPrefixTB;
        private System.Windows.Forms.CheckBox removeCommentsCB;
    }
}

