namespace assignment7_AlekseiPant
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalCorrect = new System.Windows.Forms.TextBox();
            this.totalIncorrect = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.testResultBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxIncorrect = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name:";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(200, 51);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(200, 20);
            this.fileName.TabIndex = 1;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(110, 115);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(99, 23);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "Calculate Results";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateButton);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(225, 115);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearButton);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(320, 115);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitButton);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(100, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Correct:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(100, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Incorrect:";
            // 
            // totalCorrect
            // 
            this.totalCorrect.Location = new System.Drawing.Point(200, 269);
            this.totalCorrect.Name = "totalCorrect";
            this.totalCorrect.ReadOnly = true;
            this.totalCorrect.Size = new System.Drawing.Size(100, 20);
            this.totalCorrect.TabIndex = 7;
            // 
            // totalIncorrect
            // 
            this.totalIncorrect.Location = new System.Drawing.Point(200, 319);
            this.totalIncorrect.Name = "totalIncorrect";
            this.totalIncorrect.ReadOnly = true;
            this.totalIncorrect.Size = new System.Drawing.Size(100, 20);
            this.totalIncorrect.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(100, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Test Result:";
            // 
            // testResultBox
            // 
            this.testResultBox.Location = new System.Drawing.Point(200, 219);
            this.testResultBox.Name = "testResultBox";
            this.testResultBox.ReadOnly = true;
            this.testResultBox.Size = new System.Drawing.Size(200, 20);
            this.testResultBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(100, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "List of Incorrect Questions:";
            // 
            // listBoxIncorrect
            // 
            this.listBoxIncorrect.FormattingEnabled = true;
            this.listBoxIncorrect.Location = new System.Drawing.Point(100, 400);
            this.listBoxIncorrect.Name = "listBoxIncorrect";
            this.listBoxIncorrect.Size = new System.Drawing.Size(200, 95);
            this.listBoxIncorrect.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.listBoxIncorrect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.testResultBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalIncorrect);
            this.Controls.Add(this.totalCorrect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Driver’s License Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalCorrect;
        private System.Windows.Forms.TextBox totalIncorrect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox testResultBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxIncorrect;
    }
}

