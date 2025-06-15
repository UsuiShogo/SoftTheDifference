namespace Timer
{
    partial class FormTimer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textSetTime = new TextBox();
            label2 = new Label();
            buttonStart = new Button();
            label3 = new Label();
            textRemainingTime = new TextBox();
            label4 = new Label();
            timerControl = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 38);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "時間指定";
            // 
            // textSetTime
            // 
            textSetTime.Location = new Point(152, 35);
            textSetTime.Name = "textSetTime";
            textSetTime.Size = new Size(148, 23);
            textSetTime.TabIndex = 1;
            textSetTime.Text = "10";
            textSetTime.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(80, 96);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(258, 31);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "スタート!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 170);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "残り時間";
            // 
            // textRemainingTime
            // 
            textRemainingTime.Location = new Point(175, 167);
            textRemainingTime.Name = "textRemainingTime";
            textRemainingTime.Size = new Size(133, 23);
            textRemainingTime.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 173);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 6;
            label4.Text = "秒";
            // 
            // timerControl
            // 
            timerControl.Interval = 1000;
            timerControl.Tick += timerControl_Tick;
            // 
            // FormTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 263);
            Controls.Add(label4);
            Controls.Add(textRemainingTime);
            Controls.Add(label3);
            Controls.Add(buttonStart);
            Controls.Add(label2);
            Controls.Add(textSetTime);
            Controls.Add(label1);
            Name = "FormTimer";
            Text = "タイマー";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textSetTime;
        private Label label2;
        private Button buttonStart;
        private Label label3;
        private TextBox textRemainingTime;
        private Label label4;
        private System.Windows.Forms.Timer timerControl;
    }
}
