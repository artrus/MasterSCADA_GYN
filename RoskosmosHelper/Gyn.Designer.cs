namespace RoskosmosHelper
{
    partial class Gyn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Open = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox_InputFile = new System.Windows.Forms.TextBox();
            this.RichTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Open
            // 
            this.Button_Open.Location = new System.Drawing.Point(516, 7);
            this.Button_Open.Name = "Button_Open";
            this.Button_Open.Size = new System.Drawing.Size(75, 23);
            this.Button_Open.TabIndex = 0;
            this.Button_Open.Text = "Open";
            this.Button_Open.UseVisualStyleBackColor = true;
            this.Button_Open.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Input file";
            // 
            // TextBox_InputFile
            // 
            this.TextBox_InputFile.Location = new System.Drawing.Point(65, 9);
            this.TextBox_InputFile.Name = "TextBox_InputFile";
            this.TextBox_InputFile.ReadOnly = true;
            this.TextBox_InputFile.Size = new System.Drawing.Size(435, 20);
            this.TextBox_InputFile.TabIndex = 2;
            // 
            // RichTextBox_Log
            // 
            this.RichTextBox_Log.Location = new System.Drawing.Point(6, 19);
            this.RichTextBox_Log.Name = "RichTextBox_Log";
            this.RichTextBox_Log.Size = new System.Drawing.Size(764, 252);
            this.RichTextBox_Log.TabIndex = 3;
            this.RichTextBox_Log.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RichTextBox_Log);
            this.groupBox1.Location = new System.Drawing.Point(12, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 277);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // Gyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBox_InputFile);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button_Open);
            this.Name = "Gyn";
            this.Text = "MasterSCADA GYN";
            this.Load += new System.EventHandler(this.Gyn_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Open;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TextBox_InputFile;
        private System.Windows.Forms.RichTextBox RichTextBox_Log;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

