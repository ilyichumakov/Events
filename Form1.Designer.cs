namespace Events
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.lamp1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lamp2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lamp3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lamp1Cnt = new System.Windows.Forms.Label();
            this.lamp2Cnt = new System.Windows.Forms.Label();
            this.lamp3Cnt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(53, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 23);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Turn On 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.SwitchTurn);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(53, 130);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 23);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Turn On 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.SwitchTurn);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(53, 159);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(102, 23);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Turn On 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.SwitchTurn);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox4.Location = new System.Drawing.Point(53, 188);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(112, 23);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "Turn On All";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // lamp1
            // 
            this.lamp1.BackColor = System.Drawing.Color.Snow;
            this.lamp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lamp1.Location = new System.Drawing.Point(301, 61);
            this.lamp1.Name = "lamp1";
            this.lamp1.Size = new System.Drawing.Size(157, 164);
            this.lamp1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(339, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(355, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            // 
            // lamp2
            // 
            this.lamp2.BackColor = System.Drawing.Color.Snow;
            this.lamp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lamp2.Location = new System.Drawing.Point(548, 61);
            this.lamp2.Name = "lamp2";
            this.lamp2.Size = new System.Drawing.Size(157, 164);
            this.lamp2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(586, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 28);
            this.label5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(602, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 3;
            // 
            // lamp3
            // 
            this.lamp3.BackColor = System.Drawing.Color.Snow;
            this.lamp3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lamp3.Location = new System.Drawing.Point(798, 61);
            this.lamp3.Name = "lamp3";
            this.lamp3.Size = new System.Drawing.Size(157, 164);
            this.lamp3.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(836, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 28);
            this.label8.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(852, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Счётчик различных цветов";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(297, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(658, 114);
            this.label4.TabIndex = 4;
            // 
            // lamp1Cnt
            // 
            this.lamp1Cnt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lamp1Cnt.Location = new System.Drawing.Point(301, 9);
            this.lamp1Cnt.Name = "lamp1Cnt";
            this.lamp1Cnt.Size = new System.Drawing.Size(157, 47);
            this.lamp1Cnt.TabIndex = 4;
            this.lamp1Cnt.Text = "0";
            this.lamp1Cnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lamp2Cnt
            // 
            this.lamp2Cnt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lamp2Cnt.Location = new System.Drawing.Point(544, 9);
            this.lamp2Cnt.Name = "lamp2Cnt";
            this.lamp2Cnt.Size = new System.Drawing.Size(157, 47);
            this.lamp2Cnt.TabIndex = 4;
            this.lamp2Cnt.Text = "0";
            this.lamp2Cnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lamp3Cnt
            // 
            this.lamp3Cnt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lamp3Cnt.Location = new System.Drawing.Point(798, 9);
            this.lamp3Cnt.Name = "lamp3Cnt";
            this.lamp3Cnt.Size = new System.Drawing.Size(157, 47);
            this.lamp3Cnt.TabIndex = 4;
            this.lamp3Cnt.Text = "0";
            this.lamp3Cnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(49, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 47);
            this.label7.TabIndex = 4;
            this.label7.Text = "Счётчик включений";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 463);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lamp3Cnt);
            this.Controls.Add(this.lamp2Cnt);
            this.Controls.Add(this.lamp1Cnt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lamp3);
            this.Controls.Add(this.lamp2);
            this.Controls.Add(this.lamp1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label lamp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lamp2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lamp3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lamp1Cnt;
        private System.Windows.Forms.Label lamp2Cnt;
        private System.Windows.Forms.Label lamp3Cnt;
        private System.Windows.Forms.Label label7;
    }
}

