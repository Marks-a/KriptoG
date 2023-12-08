
namespace KriptoG
{
    partial class Form1
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
            this.plainTextField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cypherTextField = new System.Windows.Forms.TextBox();
            this.secretKeyField = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plainTextField
            // 
            this.plainTextField.Location = new System.Drawing.Point(12, 40);
            this.plainTextField.Name = "plainTextField";
            this.plainTextField.Size = new System.Drawing.Size(290, 20);
            this.plainTextField.TabIndex = 0;
            this.plainTextField.TextChanged += new System.EventHandler(this.plainTextField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plain Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Secret Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cypher Text";
            // 
            // cypherTextField
            // 
            this.cypherTextField.Location = new System.Drawing.Point(15, 142);
            this.cypherTextField.Name = "cypherTextField";
            this.cypherTextField.Size = new System.Drawing.Size(287, 20);
            this.cypherTextField.TabIndex = 4;
            this.cypherTextField.TextChanged += new System.EventHandler(this.cypherTextField_TextChanged);
            // 
            // secretKeyField
            // 
            this.secretKeyField.Location = new System.Drawing.Point(395, 40);
            this.secretKeyField.Name = "secretKeyField";
            this.secretKeyField.Size = new System.Drawing.Size(168, 20);
            this.secretKeyField.TabIndex = 5;
            this.secretKeyField.TextChanged += new System.EventHandler(this.secretKeyField_TextChanged);
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(395, 102);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(168, 23);
            this.encrypt.TabIndex = 6;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(395, 138);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(168, 23);
            this.decrypt.TabIndex = 7;
            this.decrypt.Text = "Decrpyt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 238);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.secretKeyField);
            this.Controls.Add(this.cypherTextField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plainTextField);
            this.Name = "Form1";
            this.Text = "KriptoGraph";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plainTextField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cypherTextField;
        private System.Windows.Forms.TextBox secretKeyField;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
    }
}

