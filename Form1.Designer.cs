namespace WindowsFormsApp4
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numAmountH = new System.Windows.Forms.NumericUpDown();
            this.numAmountW = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.daysForCuring = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.incubationDays = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.variety = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.radius = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.contacts = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysForCuring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incubationDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variety)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contacts)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.contacts);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.radius);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.variety);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.incubationDays);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.daysForCuring);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.nextBtn);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.numAmountH);
            this.splitContainer1.Panel1.Controls.Add(this.numAmountW);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 642);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 0;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(114, 516);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(91, 41);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Длина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ширина";
            // 
            // numAmountH
            // 
            this.numAmountH.Location = new System.Drawing.Point(97, 91);
            this.numAmountH.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numAmountH.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numAmountH.Name = "numAmountH";
            this.numAmountH.Size = new System.Drawing.Size(120, 22);
            this.numAmountH.TabIndex = 3;
            this.numAmountH.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numAmountW
            // 
            this.numAmountW.Location = new System.Drawing.Point(97, 47);
            this.numAmountW.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numAmountW.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numAmountW.Name = "numAmountW";
            this.numAmountW.Size = new System.Drawing.Size(120, 22);
            this.numAmountW.TabIndex = 2;
            this.numAmountW.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 639);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дни выздоровления";
            // 
            // daysForCuring
            // 
            this.daysForCuring.Location = new System.Drawing.Point(97, 146);
            this.daysForCuring.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.daysForCuring.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysForCuring.Name = "daysForCuring";
            this.daysForCuring.Size = new System.Drawing.Size(120, 22);
            this.daysForCuring.TabIndex = 8;
            this.daysForCuring.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Инкубационный период";
            // 
            // incubationDays
            // 
            this.incubationDays.Location = new System.Drawing.Point(97, 199);
            this.incubationDays.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.incubationDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.incubationDays.Name = "incubationDays";
            this.incubationDays.Size = new System.Drawing.Size(120, 22);
            this.incubationDays.TabIndex = 10;
            this.incubationDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Вероятность заражения";
            // 
            // variety
            // 
            this.variety.DecimalPlaces = 1;
            this.variety.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.variety.Location = new System.Drawing.Point(97, 254);
            this.variety.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.variety.Name = "variety";
            this.variety.Size = new System.Drawing.Size(120, 22);
            this.variety.TabIndex = 12;
            this.variety.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Радиус перемещения";
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(97, 308);
            this.radius.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.radius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(120, 22);
            this.radius.TabIndex = 14;
            this.radius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Контактов в день";
            // 
            // contacts
            // 
            this.contacts.Location = new System.Drawing.Point(97, 362);
            this.contacts.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.contacts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(120, 22);
            this.contacts.TabIndex = 16;
            this.contacts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 642);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAmountH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysForCuring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incubationDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variety)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numAmountW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAmountH;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown daysForCuring;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown incubationDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown variety;
        private System.Windows.Forms.NumericUpDown radius;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown contacts;
        private System.Windows.Forms.Label label7;
    }
}

