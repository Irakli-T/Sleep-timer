namespace Таймер
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonSoundChanges = new System.Windows.Forms.Button();
            this.buttonMonitorShutdown = new System.Windows.Forms.Button();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.ButtonWelding = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(104, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выключение произойдет через";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxHour
            // 
            this.textBoxHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(21)))));
            this.textBoxHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHour.ForeColor = System.Drawing.Color.Goldenrod;
            this.textBoxHour.Location = new System.Drawing.Point(160, 107);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(35, 31);
            this.textBoxHour.TabIndex = 1;
            this.textBoxHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHour_KeyPress);
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(21)))));
            this.textBoxMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMinutes.ForeColor = System.Drawing.Color.Goldenrod;
            this.textBoxMinutes.Location = new System.Drawing.Point(225, 107);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(35, 31);
            this.textBoxMinutes.TabIndex = 2;
            this.textBoxMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMinutes_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(191, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ч";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(256, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "М";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.buttonStart.FlatAppearance.BorderSize = 3;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonStart.Location = new System.Drawing.Point(191, 167);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 33);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Запустить";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSoundChanges
            // 
            this.buttonSoundChanges.BackColor = System.Drawing.Color.Transparent;
            this.buttonSoundChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSoundChanges.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.buttonSoundChanges.FlatAppearance.BorderSize = 2;
            this.buttonSoundChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSoundChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSoundChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoundChanges.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonSoundChanges.Location = new System.Drawing.Point(80, 228);
            this.buttonSoundChanges.Name = "buttonSoundChanges";
            this.buttonSoundChanges.Size = new System.Drawing.Size(145, 25);
            this.buttonSoundChanges.TabIndex = 6;
            this.buttonSoundChanges.Text = "Вкл. Снижение звука";
            this.buttonSoundChanges.UseVisualStyleBackColor = false;
            this.buttonSoundChanges.Click += new System.EventHandler(this.buttonSoundChanges_Click);
            // 
            // buttonMonitorShutdown
            // 
            this.buttonMonitorShutdown.BackColor = System.Drawing.Color.Transparent;
            this.buttonMonitorShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMonitorShutdown.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.buttonMonitorShutdown.FlatAppearance.BorderSize = 2;
            this.buttonMonitorShutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMonitorShutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMonitorShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMonitorShutdown.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonMonitorShutdown.Location = new System.Drawing.Point(255, 228);
            this.buttonMonitorShutdown.Name = "buttonMonitorShutdown";
            this.buttonMonitorShutdown.Size = new System.Drawing.Size(145, 25);
            this.buttonMonitorShutdown.TabIndex = 7;
            this.buttonMonitorShutdown.Text = "Выключение монитора";
            this.buttonMonitorShutdown.UseVisualStyleBackColor = false;
            this.buttonMonitorShutdown.Click += new System.EventHandler(this.buttonMonitorShutdown_Click);
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(21)))));
            this.textBoxSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSeconds.ForeColor = System.Drawing.Color.Goldenrod;
            this.textBoxSeconds.Location = new System.Drawing.Point(289, 107);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(35, 31);
            this.textBoxSeconds.TabIndex = 8;
            this.textBoxSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSeconds_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(320, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "С";
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.CloseButton.Location = new System.Drawing.Point(460, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 24);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // ButtonWelding
            // 
            this.ButtonWelding.AutoSize = true;
            this.ButtonWelding.BackColor = System.Drawing.Color.Transparent;
            this.ButtonWelding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonWelding.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonWelding.ForeColor = System.Drawing.Color.Goldenrod;
            this.ButtonWelding.Location = new System.Drawing.Point(439, -8);
            this.ButtonWelding.Name = "ButtonWelding";
            this.ButtonWelding.Size = new System.Drawing.Size(26, 29);
            this.ButtonWelding.TabIndex = 11;
            this.ButtonWelding.Text = "_";
            this.ButtonWelding.Click += new System.EventHandler(this.ButtonWelding_Click);
            this.ButtonWelding.MouseEnter += new System.EventHandler(this.ButtonWelding_MouseEnter);
            this.ButtonWelding.MouseLeave += new System.EventHandler(this.ButtonWelding_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Таймер.Properties.Resources.Фон_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 303);
            this.Controls.Add(this.ButtonWelding);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSeconds);
            this.Controls.Add(this.buttonMonitorShutdown);
            this.Controls.Add(this.buttonSoundChanges);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таймер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSoundChanges;
        private System.Windows.Forms.Button buttonMonitorShutdown;
        private System.Windows.Forms.TextBox textBoxSeconds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label ButtonWelding;
    }
}

