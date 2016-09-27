namespace One_Question_Quiz
{
    partial class frmOneQuestionQuiz
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.grbRadiobattons = new System.Windows.Forms.GroupBox();
            this.rdo4 = new System.Windows.Forms.RadioButton();
            this.rdo6 = new System.Windows.Forms.RadioButton();
            this.rdo5 = new System.Windows.Forms.RadioButton();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.grbRadiobattons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(266, 37);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(126, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "what are you doing now?";
            this.lblQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbRadiobattons
            // 
            this.grbRadiobattons.Controls.Add(this.rdo4);
            this.grbRadiobattons.Controls.Add(this.rdo6);
            this.grbRadiobattons.Controls.Add(this.rdo5);
            this.grbRadiobattons.Controls.Add(this.rdo3);
            this.grbRadiobattons.Controls.Add(this.rdo2);
            this.grbRadiobattons.Controls.Add(this.rdo1);
            this.grbRadiobattons.Location = new System.Drawing.Point(164, 53);
            this.grbRadiobattons.Name = "grbRadiobattons";
            this.grbRadiobattons.Size = new System.Drawing.Size(343, 352);
            this.grbRadiobattons.TabIndex = 1;
            this.grbRadiobattons.TabStop = false;
            this.grbRadiobattons.Enter += new System.EventHandler(this.grbRadiobattons_Enter);
            // 
            // rdo4
            // 
            this.rdo4.AutoSize = true;
            this.rdo4.Location = new System.Drawing.Point(203, 121);
            this.rdo4.Name = "rdo4";
            this.rdo4.Size = new System.Drawing.Size(46, 17);
            this.rdo4.TabIndex = 5;
            this.rdo4.TabStop = true;
            this.rdo4.Text = "rdo4";
            this.rdo4.UseVisualStyleBackColor = true;
            this.rdo4.CheckedChanged += new System.EventHandler(this.re5_CheckedChanged);
            // 
            // rdo6
            // 
            this.rdo6.AutoSize = true;
            this.rdo6.Location = new System.Drawing.Point(203, 261);
            this.rdo6.Name = "rdo6";
            this.rdo6.Size = new System.Drawing.Size(46, 17);
            this.rdo6.TabIndex = 4;
            this.rdo6.TabStop = true;
            this.rdo6.Text = "rdo6";
            this.rdo6.UseVisualStyleBackColor = true;
            this.rdo6.CheckedChanged += new System.EventHandler(this.re4_CheckedChanged);
            // 
            // rdo5
            // 
            this.rdo5.AutoSize = true;
            this.rdo5.Location = new System.Drawing.Point(203, 180);
            this.rdo5.Name = "rdo5";
            this.rdo5.Size = new System.Drawing.Size(46, 17);
            this.rdo5.TabIndex = 3;
            this.rdo5.TabStop = true;
            this.rdo5.Text = "rdo5";
            this.rdo5.UseVisualStyleBackColor = true;
            this.rdo5.CheckedChanged += new System.EventHandler(this.re3_CheckedChanged);
            // 
            // rdo3
            // 
            this.rdo3.AutoSize = true;
            this.rdo3.Location = new System.Drawing.Point(92, 261);
            this.rdo3.Name = "rdo3";
            this.rdo3.Size = new System.Drawing.Size(46, 17);
            this.rdo3.TabIndex = 2;
            this.rdo3.TabStop = true;
            this.rdo3.Text = "rdo3";
            this.rdo3.UseVisualStyleBackColor = true;
            this.rdo3.CheckedChanged += new System.EventHandler(this.re2_CheckedChanged);
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Location = new System.Drawing.Point(92, 180);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(46, 17);
            this.rdo2.TabIndex = 1;
            this.rdo2.TabStop = true;
            this.rdo2.Text = "rdo2";
            this.rdo2.UseVisualStyleBackColor = true;
            this.rdo2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Location = new System.Drawing.Point(92, 121);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(46, 17);
            this.rdo1.TabIndex = 0;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "rdo1";
            this.rdo1.UseVisualStyleBackColor = true;
            this.rdo1.CheckedChanged += new System.EventHandler(this.re0_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(637, 246);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmOneQuestionQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 433);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grbRadiobattons);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmOneQuestionQuiz";
            this.Text = "One Question Quiz";
            this.Load += new System.EventHandler(this.lblQuestion_Load);
            this.grbRadiobattons.ResumeLayout(false);
            this.grbRadiobattons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox grbRadiobattons;
        private System.Windows.Forms.RadioButton rdo4;
        private System.Windows.Forms.RadioButton rdo6;
        private System.Windows.Forms.RadioButton rdo5;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.Label lblResult;
    }
}

