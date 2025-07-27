
namespace Math_Game
{
    partial class MathQuize
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLevel = new System.Windows.Forms.GroupBox();
            this.rdbHard = new System.Windows.Forms.RadioButton();
            this.rdbEasy = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.gbOperation = new System.Windows.Forms.GroupBox();
            this.rdbDivision = new System.Windows.Forms.RadioButton();
            this.rdbMix = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.rdbMultiplay = new System.Windows.Forms.RadioButton();
            this.rdbSub = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbQuestionType = new System.Windows.Forms.GroupBox();
            this.rdbTorF = new System.Windows.Forms.RadioButton();
            this.rdbChoice = new System.Windows.Forms.RadioButton();
            this.rdbGaps = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbLevel.SuspendLayout();
            this.gbOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbQuestionType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Game";
            // 
            // gbLevel
            // 
            this.gbLevel.Controls.Add(this.rdbHard);
            this.gbLevel.Controls.Add(this.rdbEasy);
            this.gbLevel.Controls.Add(this.rdbMedium);
            this.gbLevel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLevel.Location = new System.Drawing.Point(251, 141);
            this.gbLevel.Name = "gbLevel";
            this.gbLevel.Size = new System.Drawing.Size(351, 101);
            this.gbLevel.TabIndex = 1;
            this.gbLevel.TabStop = false;
            this.gbLevel.Text = "Game Level";
            // 
            // rdbHard
            // 
            this.rdbHard.AutoSize = true;
            this.rdbHard.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHard.Location = new System.Drawing.Point(239, 57);
            this.rdbHard.Name = "rdbHard";
            this.rdbHard.Size = new System.Drawing.Size(78, 30);
            this.rdbHard.TabIndex = 3;
            this.rdbHard.Tag = "Hard";
            this.rdbHard.Text = "Hard";
            this.rdbHard.UseVisualStyleBackColor = true;
            // 
            // rdbEasy
            // 
            this.rdbEasy.AutoSize = true;
            this.rdbEasy.Checked = true;
            this.rdbEasy.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEasy.Location = new System.Drawing.Point(21, 57);
            this.rdbEasy.Name = "rdbEasy";
            this.rdbEasy.Size = new System.Drawing.Size(74, 30);
            this.rdbEasy.TabIndex = 0;
            this.rdbEasy.TabStop = true;
            this.rdbEasy.Tag = "Easy";
            this.rdbEasy.Text = "Easy";
            this.rdbEasy.UseVisualStyleBackColor = true;
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMedium.Location = new System.Drawing.Point(118, 57);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(100, 30);
            this.rdbMedium.TabIndex = 2;
            this.rdbMedium.Tag = "Medium";
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = true;
            // 
            // gbOperation
            // 
            this.gbOperation.Controls.Add(this.rdbDivision);
            this.gbOperation.Controls.Add(this.rdbMix);
            this.gbOperation.Controls.Add(this.rdbAdd);
            this.gbOperation.Controls.Add(this.rdbMultiplay);
            this.gbOperation.Controls.Add(this.rdbSub);
            this.gbOperation.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperation.Location = new System.Drawing.Point(645, 141);
            this.gbOperation.Name = "gbOperation";
            this.gbOperation.Size = new System.Drawing.Size(168, 249);
            this.gbOperation.TabIndex = 2;
            this.gbOperation.TabStop = false;
            this.gbOperation.Text = "Operation";
            // 
            // rdbDivision
            // 
            this.rdbDivision.AutoSize = true;
            this.rdbDivision.Location = new System.Drawing.Point(12, 163);
            this.rdbDivision.Name = "rdbDivision";
            this.rdbDivision.Size = new System.Drawing.Size(90, 28);
            this.rdbDivision.TabIndex = 5;
            this.rdbDivision.Tag = "Division";
            this.rdbDivision.Text = "Division";
            this.rdbDivision.UseVisualStyleBackColor = true;
            // 
            // rdbMix
            // 
            this.rdbMix.AutoSize = true;
            this.rdbMix.Location = new System.Drawing.Point(12, 209);
            this.rdbMix.Name = "rdbMix";
            this.rdbMix.Size = new System.Drawing.Size(60, 28);
            this.rdbMix.TabIndex = 4;
            this.rdbMix.Tag = "Mix";
            this.rdbMix.Text = "Mix";
            this.rdbMix.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Checked = true;
            this.rdbAdd.Location = new System.Drawing.Point(12, 30);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(98, 28);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Tag = "Addition";
            this.rdbAdd.Text = "Addition";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplay
            // 
            this.rdbMultiplay.AutoSize = true;
            this.rdbMultiplay.Location = new System.Drawing.Point(12, 119);
            this.rdbMultiplay.Name = "rdbMultiplay";
            this.rdbMultiplay.Size = new System.Drawing.Size(139, 28);
            this.rdbMultiplay.TabIndex = 3;
            this.rdbMultiplay.Tag = "Multiplication";
            this.rdbMultiplay.Text = "Multiplication";
            this.rdbMultiplay.UseVisualStyleBackColor = true;
            // 
            // rdbSub
            // 
            this.rdbSub.AutoSize = true;
            this.rdbSub.Location = new System.Drawing.Point(12, 73);
            this.rdbSub.Name = "rdbSub";
            this.rdbSub.Size = new System.Drawing.Size(127, 28);
            this.rdbSub.TabIndex = 2;
            this.rdbSub.Tag = "Subtraction";
            this.rdbSub.Text = "Subtraction";
            this.rdbSub.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(543, 434);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbQuestionType
            // 
            this.gbQuestionType.Controls.Add(this.rdbTorF);
            this.gbQuestionType.Controls.Add(this.rdbChoice);
            this.gbQuestionType.Controls.Add(this.rdbGaps);
            this.gbQuestionType.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuestionType.Location = new System.Drawing.Point(187, 248);
            this.gbQuestionType.Name = "gbQuestionType";
            this.gbQuestionType.Size = new System.Drawing.Size(441, 142);
            this.gbQuestionType.TabIndex = 5;
            this.gbQuestionType.TabStop = false;
            this.gbQuestionType.Text = "Questions Type";
            // 
            // rdbTorF
            // 
            this.rdbTorF.AutoSize = true;
            this.rdbTorF.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTorF.Location = new System.Drawing.Point(303, 49);
            this.rdbTorF.Name = "rdbTorF";
            this.rdbTorF.Size = new System.Drawing.Size(121, 28);
            this.rdbTorF.TabIndex = 3;
            this.rdbTorF.Tag = "TrueOrFalse";
            this.rdbTorF.Text = "True/False";
            this.rdbTorF.UseVisualStyleBackColor = true;
            // 
            // rdbChoice
            // 
            this.rdbChoice.AutoSize = true;
            this.rdbChoice.Checked = true;
            this.rdbChoice.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChoice.Location = new System.Drawing.Point(20, 49);
            this.rdbChoice.Name = "rdbChoice";
            this.rdbChoice.Size = new System.Drawing.Size(153, 28);
            this.rdbChoice.TabIndex = 0;
            this.rdbChoice.TabStop = true;
            this.rdbChoice.Tag = "MultipleChoice";
            this.rdbChoice.Text = "Multiple Choice";
            this.rdbChoice.UseVisualStyleBackColor = true;
            // 
            // rdbGaps
            // 
            this.rdbGaps.AutoSize = true;
            this.rdbGaps.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGaps.Location = new System.Drawing.Point(163, 83);
            this.rdbGaps.Name = "rdbGaps";
            this.rdbGaps.Size = new System.Drawing.Size(145, 28);
            this.rdbGaps.TabIndex = 2;
            this.rdbGaps.Tag = "FillinTheBlank";
            this.rdbGaps.Text = "Fill in the gaps";
            this.rdbGaps.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(699, 514);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 59);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(381, 417);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 59);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Count Down Timer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Questions Number";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(216, 434);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(25, 527);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(67, 33);
            this.lbDate.TabIndex = 11;
            this.lbDate.Text = "Date";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(184, 527);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(69, 33);
            this.lbTime.TabIndex = 12;
            this.lbTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MathQuize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 585);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbQuestionType);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.gbOperation);
            this.Controls.Add(this.gbLevel);
            this.Controls.Add(this.label1);
            this.Name = "MathQuize";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLevel.ResumeLayout(false);
            this.gbLevel.PerformLayout();
            this.gbOperation.ResumeLayout(false);
            this.gbOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbQuestionType.ResumeLayout(false);
            this.gbQuestionType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLevel;
        private System.Windows.Forms.RadioButton rdbEasy;
        private System.Windows.Forms.RadioButton rdbHard;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.GroupBox gbOperation;
        private System.Windows.Forms.RadioButton rdbMultiplay;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.RadioButton rdbSub;
        private System.Windows.Forms.RadioButton rdbDivision;
        private System.Windows.Forms.RadioButton rdbMix;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox gbQuestionType;
        private System.Windows.Forms.RadioButton rdbTorF;
        private System.Windows.Forms.RadioButton rdbChoice;
        private System.Windows.Forms.RadioButton rdbGaps;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
    }
}

