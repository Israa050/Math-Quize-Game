
namespace Math_Game
{
    partial class frmMathQuize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMathQuize));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdbOption1 = new System.Windows.Forms.RadioButton();
            this.rdbOption2 = new System.Windows.Forms.RadioButton();
            this.rdbOption3 = new System.Windows.Forms.RadioButton();
            this.rdbOption4 = new System.Windows.Forms.RadioButton();
            this.grbSummary = new System.Windows.Forms.GroupBox();
            this.lblPrecentage = new System.Windows.Forms.Label();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.lblOperationType = new System.Windows.Forms.Label();
            this.lblQuestionsType = new System.Windows.Forms.Label();
            this.lblQuizeLevel = new System.Windows.Forms.Label();
            this.lblQuestionN = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.grbOptions = new System.Windows.Forms.GroupBox();
            this.txtUserInput = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbSummary.SuspendLayout();
            this.grbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(130, 35);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(232, 46);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Q1: 25 + 16 = ";
            // 
            // rdbOption1
            // 
            this.rdbOption1.AutoSize = true;
            this.rdbOption1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption1.Location = new System.Drawing.Point(34, 43);
            this.rdbOption1.Name = "rdbOption1";
            this.rdbOption1.Size = new System.Drawing.Size(66, 37);
            this.rdbOption1.TabIndex = 1;
            this.rdbOption1.TabStop = true;
            this.rdbOption1.Text = "25";
            this.rdbOption1.UseVisualStyleBackColor = true;
            this.rdbOption1.CheckedChanged += new System.EventHandler(this.rdbOption_CheckedChanged);
            // 
            // rdbOption2
            // 
            this.rdbOption2.AutoSize = true;
            this.rdbOption2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption2.Location = new System.Drawing.Point(34, 109);
            this.rdbOption2.Name = "rdbOption2";
            this.rdbOption2.Size = new System.Drawing.Size(66, 37);
            this.rdbOption2.TabIndex = 2;
            this.rdbOption2.TabStop = true;
            this.rdbOption2.Text = "30";
            this.rdbOption2.UseVisualStyleBackColor = true;
            this.rdbOption2.CheckedChanged += new System.EventHandler(this.rdbOption_CheckedChanged);
            // 
            // rdbOption3
            // 
            this.rdbOption3.AutoSize = true;
            this.rdbOption3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption3.Location = new System.Drawing.Point(163, 43);
            this.rdbOption3.Name = "rdbOption3";
            this.rdbOption3.Size = new System.Drawing.Size(66, 37);
            this.rdbOption3.TabIndex = 3;
            this.rdbOption3.TabStop = true;
            this.rdbOption3.Text = "45";
            this.rdbOption3.UseVisualStyleBackColor = true;
            this.rdbOption3.CheckedChanged += new System.EventHandler(this.rdbOption_CheckedChanged);
            // 
            // rdbOption4
            // 
            this.rdbOption4.AutoSize = true;
            this.rdbOption4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption4.Location = new System.Drawing.Point(163, 109);
            this.rdbOption4.Name = "rdbOption4";
            this.rdbOption4.Size = new System.Drawing.Size(66, 37);
            this.rdbOption4.TabIndex = 4;
            this.rdbOption4.TabStop = true;
            this.rdbOption4.Text = "55";
            this.rdbOption4.UseVisualStyleBackColor = true;
            this.rdbOption4.CheckedChanged += new System.EventHandler(this.rdbOption_CheckedChanged);
            // 
            // grbSummary
            // 
            this.grbSummary.Controls.Add(this.lblPrecentage);
            this.grbSummary.Controls.Add(this.lblGameResult);
            this.grbSummary.Controls.Add(this.lblOperationType);
            this.grbSummary.Controls.Add(this.lblQuestionsType);
            this.grbSummary.Controls.Add(this.lblQuizeLevel);
            this.grbSummary.Controls.Add(this.lblQuestionN);
            this.grbSummary.Controls.Add(this.lblOperation);
            this.grbSummary.Controls.Add(this.lblCounter);
            this.grbSummary.Controls.Add(this.label2);
            this.grbSummary.Controls.Add(this.lblResult);
            this.grbSummary.Controls.Add(this.label1);
            this.grbSummary.Controls.Add(this.lblType);
            this.grbSummary.Controls.Add(this.lblLevel);
            this.grbSummary.Controls.Add(this.lblNumber);
            this.grbSummary.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSummary.Location = new System.Drawing.Point(498, 35);
            this.grbSummary.Name = "grbSummary";
            this.grbSummary.Size = new System.Drawing.Size(356, 383);
            this.grbSummary.TabIndex = 5;
            this.grbSummary.TabStop = false;
            this.grbSummary.Text = "Summary";
            // 
            // lblPrecentage
            // 
            this.lblPrecentage.AutoSize = true;
            this.lblPrecentage.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecentage.Location = new System.Drawing.Point(128, 293);
            this.lblPrecentage.Name = "lblPrecentage";
            this.lblPrecentage.Size = new System.Drawing.Size(34, 24);
            this.lblPrecentage.TabIndex = 13;
            this.lblPrecentage.Text = "0%";
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameResult.Location = new System.Drawing.Point(86, 340);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(61, 24);
            this.lblGameResult.TabIndex = 12;
            this.lblGameResult.Text = "Result";
            // 
            // lblOperationType
            // 
            this.lblOperationType.AutoSize = true;
            this.lblOperationType.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperationType.Location = new System.Drawing.Point(119, 207);
            this.lblOperationType.Name = "lblOperationType";
            this.lblOperationType.Size = new System.Drawing.Size(91, 24);
            this.lblOperationType.TabIndex = 11;
            this.lblOperationType.Text = "Operation";
            // 
            // lblQuestionsType
            // 
            this.lblQuestionsType.AutoSize = true;
            this.lblQuestionsType.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionsType.Location = new System.Drawing.Point(165, 160);
            this.lblQuestionsType.Name = "lblQuestionsType";
            this.lblQuestionsType.Size = new System.Drawing.Size(136, 24);
            this.lblQuestionsType.TabIndex = 10;
            this.lblQuestionsType.Text = "Questions Type";
            // 
            // lblQuizeLevel
            // 
            this.lblQuizeLevel.AutoSize = true;
            this.lblQuizeLevel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizeLevel.Location = new System.Drawing.Point(134, 107);
            this.lblQuizeLevel.Name = "lblQuizeLevel";
            this.lblQuizeLevel.Size = new System.Drawing.Size(105, 24);
            this.lblQuizeLevel.TabIndex = 9;
            this.lblQuizeLevel.Text = "Quize Level";
            // 
            // lblQuestionN
            // 
            this.lblQuestionN.AutoSize = true;
            this.lblQuestionN.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionN.Location = new System.Drawing.Point(196, 60);
            this.lblQuestionN.Name = "lblQuestionN";
            this.lblQuestionN.Size = new System.Drawing.Size(160, 24);
            this.lblQuestionN.TabIndex = 8;
            this.lblQuestionN.Text = "Questions Number";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(18, 207);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(96, 24);
            this.lblOperation.TabIndex = 7;
            this.lblOperation.Text = "Operation:";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(86, 247);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(55, 24);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Timer:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(18, 340);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(71, 24);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Precentage:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(18, 160);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(141, 24);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Questions Type:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(18, 107);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(110, 24);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "Quize Level:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(18, 60);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(165, 24);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Questions Number:";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(190, 297);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(106, 41);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(498, 449);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(106, 41);
            this.btnStartGame.TabIndex = 7;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnExist
            // 
            this.btnExist.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.Location = new System.Drawing.Point(748, 449);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(106, 41);
            this.btnExist.TabIndex = 8;
            this.btnExist.Text = "Exist";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(180, 492);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(69, 33);
            this.lbTime.TabIndex = 14;
            this.lbTime.Text = "Time";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(21, 492);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(67, 33);
            this.lbDate.TabIndex = 13;
            this.lbDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(621, 449);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 41);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Rest";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.txtUserInput);
            this.grbOptions.Controls.Add(this.rdbOption1);
            this.grbOptions.Controls.Add(this.rdbOption2);
            this.grbOptions.Controls.Add(this.rdbOption3);
            this.grbOptions.Controls.Add(this.rdbOption4);
            this.grbOptions.Location = new System.Drawing.Point(104, 107);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Size = new System.Drawing.Size(292, 159);
            this.grbOptions.TabIndex = 17;
            this.grbOptions.TabStop = false;
            // 
            // txtUserInput
            // 
            this.txtUserInput.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserInput.Location = new System.Drawing.Point(86, 18);
            this.txtUserInput.Mask = "00000";
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(100, 49);
            this.txtUserInput.TabIndex = 18;
            this.txtUserInput.ValidatingType = typeof(int);
            this.txtUserInput.TextChanged += new System.EventHandler(this.txtUserInput_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMathQuize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 549);
            this.Controls.Add(this.grbOptions);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.grbSummary);
            this.Controls.Add(this.lblQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMathQuize";
            this.Text = "frmMathQuize";
            this.Load += new System.EventHandler(this.frmMathQuize_Load);
            this.grbSummary.ResumeLayout(false);
            this.grbSummary.PerformLayout();
            this.grbOptions.ResumeLayout(false);
            this.grbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdbOption1;
        private System.Windows.Forms.RadioButton rdbOption2;
        private System.Windows.Forms.RadioButton rdbOption3;
        private System.Windows.Forms.RadioButton rdbOption4;
        private System.Windows.Forms.GroupBox grbSummary;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblGameResult;
        private System.Windows.Forms.Label lblOperationType;
        private System.Windows.Forms.Label lblQuestionsType;
        private System.Windows.Forms.Label lblQuizeLevel;
        private System.Windows.Forms.Label lblQuestionN;
        private System.Windows.Forms.GroupBox grbOptions;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox txtUserInput;
        private System.Windows.Forms.Label lblPrecentage;
    }
}