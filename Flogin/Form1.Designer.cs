namespace Flogin
{
    partial class Form1
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
            panel1 = new Panel();
            label1 = new Label();
            txt_name = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            txt_pass = new TextBox();
            BTN_Login = new Button();
            BTN_Exit = new Button();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_name);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 48);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 16);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(111, 8);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(209, 23);
            txt_name.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_pass);
            panel2.Location = new Point(12, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 48);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 16);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(111, 8);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(209, 23);
            txt_pass.TabIndex = 1;
            // 
            // BTN_Login
            // 
            BTN_Login.Location = new Point(83, 127);
            BTN_Login.Name = "BTN_Login";
            BTN_Login.Size = new Size(75, 23);
            BTN_Login.TabIndex = 2;
            BTN_Login.Text = "OK";
            BTN_Login.UseVisualStyleBackColor = true;
            BTN_Login.Click += BTN_Login_Click;
            // 
            // BTN_Exit
            // 
            BTN_Exit.Location = new Point(224, 127);
            BTN_Exit.Name = "BTN_Exit";
            BTN_Exit.Size = new Size(75, 23);
            BTN_Exit.TabIndex = 4;
            BTN_Exit.Text = "Exit";
            BTN_Exit.UseVisualStyleBackColor = true;
            BTN_Exit.Click += BTN_Exit_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 176);
            Controls.Add(BTN_Exit);
            Controls.Add(BTN_Login);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(383, 215);
            MinimumSize = new Size(383, 215);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txt_name;
        private Panel panel2;
        private Label label2;
        private TextBox txt_pass;
        private Button BTN_Login;
        private Button BTN_Exit;
        private ErrorProvider errorProvider;
    }
}