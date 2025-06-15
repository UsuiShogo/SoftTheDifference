namespace SlackPost
{
    partial class FormSlackPost
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
            button2 = new Button();
            butPost = new Button();
            txtPost = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(477, 364);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // butPost
            // 
            butPost.Location = new Point(179, 200);
            butPost.Name = "butPost";
            butPost.Size = new Size(77, 29);
            butPost.TabIndex = 2;
            butPost.Text = "投稿";
            butPost.UseVisualStyleBackColor = true;
            butPost.Click += butPost_Click;
            // 
            // txtPost
            // 
            txtPost.Location = new Point(12, 28);
            txtPost.Multiline = true;
            txtPost.Name = "txtPost";
            txtPost.Size = new Size(244, 156);
            txtPost.TabIndex = 3;
            // 
            // FormSlackPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(txtPost);
            Controls.Add(butPost);
            Controls.Add(button2);
            Name = "FormSlackPost";
            Text = "Slack投稿";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button butPost;
        private TextBox txtPost;
    }
}
