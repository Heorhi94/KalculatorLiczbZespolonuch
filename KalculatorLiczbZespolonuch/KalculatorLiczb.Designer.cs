namespace KalculatorLiczbZespolonuch
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textResult = new System.Windows.Forms.TextBox();
            this.tableOperations = new System.Windows.Forms.TableLayoutPanel();
            this.bGetHashCode = new System.Windows.Forms.Button();
            this.bEquals = new System.Windows.Forms.Button();
            this.bOnDouble = new System.Windows.Forms.Button();
            this.bInDouble = new System.Windows.Forms.Button();
            this.bLess = new System.Windows.Forms.Button();
            this.bMore = new System.Windows.Forms.Button();
            this.bnotEquals = new System.Windows.Forms.Button();
            this.blogicequals = new System.Windows.Forms.Button();
            this.bdivide = new System.Windows.Forms.Button();
            this.bmultiply = new System.Windows.Forms.Button();
            this.bminus = new System.Windows.Forms.Button();
            this.bplus = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bExit = new System.Windows.Forms.Button();
            this.textVal1Real = new System.Windows.Forms.TextBox();
            this.textVal2Real = new System.Windows.Forms.TextBox();
            this.textVal1Imgnr = new System.Windows.Forms.TextBox();
            this.textVal2Imgnr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.tableOperations.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textResult
            // 
            this.textResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textResult.ForeColor = System.Drawing.SystemColors.Window;
            this.textResult.Location = new System.Drawing.Point(3, 107);
            this.textResult.Margin = new System.Windows.Forms.Padding(0);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(309, 80);
            this.textResult.TabIndex = 1;
            // 
            // tableOperations
            // 
            this.tableOperations.ColumnCount = 4;
            this.tableOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableOperations.Controls.Add(this.bGetHashCode, 0, 2);
            this.tableOperations.Controls.Add(this.bEquals, 0, 2);
            this.tableOperations.Controls.Add(this.bOnDouble, 0, 2);
            this.tableOperations.Controls.Add(this.bInDouble, 0, 2);
            this.tableOperations.Controls.Add(this.bLess, 3, 1);
            this.tableOperations.Controls.Add(this.bMore, 2, 1);
            this.tableOperations.Controls.Add(this.bnotEquals, 1, 1);
            this.tableOperations.Controls.Add(this.blogicequals, 0, 1);
            this.tableOperations.Controls.Add(this.bdivide, 3, 0);
            this.tableOperations.Controls.Add(this.bmultiply, 2, 0);
            this.tableOperations.Controls.Add(this.bminus, 1, 0);
            this.tableOperations.Controls.Add(this.bplus, 0, 0);
            this.tableOperations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableOperations.Location = new System.Drawing.Point(0, 193);
            this.tableOperations.Name = "tableOperations";
            this.tableOperations.RowCount = 3;
            this.tableOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableOperations.Size = new System.Drawing.Size(416, 373);
            this.tableOperations.TabIndex = 2;
            // 
            // bGetHashCode
            // 
            this.bGetHashCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bGetHashCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bGetHashCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bGetHashCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bGetHashCode.Location = new System.Drawing.Point(104, 248);
            this.bGetHashCode.Margin = new System.Windows.Forms.Padding(0);
            this.bGetHashCode.Name = "bGetHashCode";
            this.bGetHashCode.Size = new System.Drawing.Size(104, 125);
            this.bGetHashCode.TabIndex = 11;
            this.bGetHashCode.Text = "Hash Code";
            this.bGetHashCode.UseVisualStyleBackColor = false;
            this.bGetHashCode.Click += new System.EventHandler(this.bGetHashCode_Click);
            // 
            // bEquals
            // 
            this.bEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bEquals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEquals.Location = new System.Drawing.Point(0, 248);
            this.bEquals.Margin = new System.Windows.Forms.Padding(0);
            this.bEquals.Name = "bEquals";
            this.bEquals.Size = new System.Drawing.Size(104, 125);
            this.bEquals.TabIndex = 10;
            this.bEquals.Text = "Equals";
            this.bEquals.UseVisualStyleBackColor = false;
            this.bEquals.Click += new System.EventHandler(this.bEquals_Click);
            // 
            // bOnDouble
            // 
            this.bOnDouble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bOnDouble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bOnDouble.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bOnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOnDouble.Location = new System.Drawing.Point(312, 248);
            this.bOnDouble.Margin = new System.Windows.Forms.Padding(0);
            this.bOnDouble.Name = "bOnDouble";
            this.bOnDouble.Size = new System.Drawing.Size(104, 125);
            this.bOnDouble.TabIndex = 9;
            this.bOnDouble.Text = "From double";
            this.bOnDouble.UseVisualStyleBackColor = false;
            this.bOnDouble.Click += new System.EventHandler(this.bOnDouble_Click);
            // 
            // bInDouble
            // 
            this.bInDouble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bInDouble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bInDouble.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bInDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bInDouble.Location = new System.Drawing.Point(208, 248);
            this.bInDouble.Margin = new System.Windows.Forms.Padding(0);
            this.bInDouble.Name = "bInDouble";
            this.bInDouble.Size = new System.Drawing.Size(104, 125);
            this.bInDouble.TabIndex = 8;
            this.bInDouble.Text = "In double";
            this.bInDouble.UseVisualStyleBackColor = false;
            this.bInDouble.Click += new System.EventHandler(this.bInDouble_Click);
            // 
            // bLess
            // 
            this.bLess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bLess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLess.Location = new System.Drawing.Point(312, 124);
            this.bLess.Margin = new System.Windows.Forms.Padding(0);
            this.bLess.Name = "bLess";
            this.bLess.Size = new System.Drawing.Size(104, 124);
            this.bLess.TabIndex = 7;
            this.bLess.Text = "<";
            this.bLess.UseVisualStyleBackColor = false;
            this.bLess.Click += new System.EventHandler(this.bLess_Click);
            // 
            // bMore
            // 
            this.bMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bMore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMore.Location = new System.Drawing.Point(208, 124);
            this.bMore.Margin = new System.Windows.Forms.Padding(0);
            this.bMore.Name = "bMore";
            this.bMore.Size = new System.Drawing.Size(104, 124);
            this.bMore.TabIndex = 6;
            this.bMore.Text = ">";
            this.bMore.UseVisualStyleBackColor = false;
            this.bMore.Click += new System.EventHandler(this.bMore_Click);
            // 
            // bnotEquals
            // 
            this.bnotEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bnotEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnotEquals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnotEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnotEquals.Location = new System.Drawing.Point(104, 124);
            this.bnotEquals.Margin = new System.Windows.Forms.Padding(0);
            this.bnotEquals.Name = "bnotEquals";
            this.bnotEquals.Size = new System.Drawing.Size(104, 124);
            this.bnotEquals.TabIndex = 5;
            this.bnotEquals.Text = "!=";
            this.bnotEquals.UseVisualStyleBackColor = false;
            this.bnotEquals.Click += new System.EventHandler(this.bnotEquals_Click);
            // 
            // blogicequals
            // 
            this.blogicequals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.blogicequals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blogicequals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.blogicequals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blogicequals.Location = new System.Drawing.Point(0, 124);
            this.blogicequals.Margin = new System.Windows.Forms.Padding(0);
            this.blogicequals.Name = "blogicequals";
            this.blogicequals.Size = new System.Drawing.Size(104, 124);
            this.blogicequals.TabIndex = 4;
            this.blogicequals.Text = "==";
            this.blogicequals.UseVisualStyleBackColor = false;
            this.blogicequals.Click += new System.EventHandler(this.blogicequals_Click);
            // 
            // bdivide
            // 
            this.bdivide.BackColor = System.Drawing.SystemColors.Highlight;
            this.bdivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bdivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bdivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bdivide.Location = new System.Drawing.Point(312, 0);
            this.bdivide.Margin = new System.Windows.Forms.Padding(0);
            this.bdivide.Name = "bdivide";
            this.bdivide.Size = new System.Drawing.Size(104, 124);
            this.bdivide.TabIndex = 3;
            this.bdivide.Text = "÷";
            this.bdivide.UseVisualStyleBackColor = false;
            this.bdivide.Click += new System.EventHandler(this.bdivide_Click);
            // 
            // bmultiply
            // 
            this.bmultiply.BackColor = System.Drawing.SystemColors.Highlight;
            this.bmultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmultiply.Location = new System.Drawing.Point(208, 0);
            this.bmultiply.Margin = new System.Windows.Forms.Padding(0);
            this.bmultiply.Name = "bmultiply";
            this.bmultiply.Size = new System.Drawing.Size(104, 124);
            this.bmultiply.TabIndex = 2;
            this.bmultiply.Text = "×";
            this.bmultiply.UseVisualStyleBackColor = false;
            this.bmultiply.Click += new System.EventHandler(this.bmultiply_Click);
            // 
            // bminus
            // 
            this.bminus.BackColor = System.Drawing.SystemColors.Highlight;
            this.bminus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bminus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bminus.Location = new System.Drawing.Point(104, 0);
            this.bminus.Margin = new System.Windows.Forms.Padding(0);
            this.bminus.Name = "bminus";
            this.bminus.Size = new System.Drawing.Size(104, 124);
            this.bminus.TabIndex = 1;
            this.bminus.Text = "-";
            this.bminus.UseVisualStyleBackColor = false;
            this.bminus.Click += new System.EventHandler(this.bminus_Click);
            // 
            // bplus
            // 
            this.bplus.BackColor = System.Drawing.SystemColors.Highlight;
            this.bplus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bplus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bplus.Location = new System.Drawing.Point(0, 0);
            this.bplus.Margin = new System.Windows.Forms.Padding(0);
            this.bplus.Name = "bplus";
            this.bplus.Size = new System.Drawing.Size(104, 124);
            this.bplus.TabIndex = 0;
            this.bplus.Text = "+";
            this.bplus.UseVisualStyleBackColor = false;
            this.bplus.Click += new System.EventHandler(this.bplus_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.bExit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textVal1Real, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textVal2Real, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textVal1Imgnr, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textVal2Imgnr, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bExit
            // 
            this.bExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.bExit.Image = ((System.Drawing.Image)(resources.GetObject("bExit.Image")));
            this.bExit.Location = new System.Drawing.Point(373, 3);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(40, 25);
            this.bExit.TabIndex = 6;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // textVal1Real
            // 
            this.textVal1Real.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textVal1Real.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textVal1Real.ForeColor = System.Drawing.SystemColors.Window;
            this.textVal1Real.Location = new System.Drawing.Point(141, 54);
            this.textVal1Real.Name = "textVal1Real";
            this.textVal1Real.Size = new System.Drawing.Size(132, 22);
            this.textVal1Real.TabIndex = 8;
            this.textVal1Real.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textVal1Real.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textVal1Real_KeyPress);
            // 
            // textVal2Real
            // 
            this.textVal2Real.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textVal2Real.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textVal2Real.ForeColor = System.Drawing.SystemColors.Window;
            this.textVal2Real.Location = new System.Drawing.Point(279, 54);
            this.textVal2Real.Name = "textVal2Real";
            this.textVal2Real.Size = new System.Drawing.Size(134, 22);
            this.textVal2Real.TabIndex = 9;
            this.textVal2Real.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textVal2Real.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textVal1Real_KeyPress);
            // 
            // textVal1Imgnr
            // 
            this.textVal1Imgnr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textVal1Imgnr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textVal1Imgnr.ForeColor = System.Drawing.SystemColors.Window;
            this.textVal1Imgnr.Location = new System.Drawing.Point(141, 80);
            this.textVal1Imgnr.Name = "textVal1Imgnr";
            this.textVal1Imgnr.Size = new System.Drawing.Size(132, 22);
            this.textVal1Imgnr.TabIndex = 10;
            this.textVal1Imgnr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textVal1Imgnr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textVal1Real_KeyPress);
            // 
            // textVal2Imgnr
            // 
            this.textVal2Imgnr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textVal2Imgnr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textVal2Imgnr.ForeColor = System.Drawing.SystemColors.Window;
            this.textVal2Imgnr.Location = new System.Drawing.Point(279, 80);
            this.textVal2Imgnr.Name = "textVal2Imgnr";
            this.textVal2Imgnr.Size = new System.Drawing.Size(134, 22);
            this.textVal2Imgnr.TabIndex = 11;
            this.textVal2Imgnr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textVal2Imgnr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textVal1Real_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Real Part";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Imaginary Part";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(141, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Z1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(279, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Z2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClear.Location = new System.Drawing.Point(315, 107);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(98, 80);
            this.bClear.TabIndex = 3;
            this.bClear.Text = "C";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(416, 566);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.tableOperations);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalculator";
            this.tableOperations.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.TableLayoutPanel tableOperations;
        private System.Windows.Forms.Button bLess;
        private System.Windows.Forms.Button bMore;
        private System.Windows.Forms.Button bnotEquals;
        private System.Windows.Forms.Button blogicequals;
        private System.Windows.Forms.Button bdivide;
        private System.Windows.Forms.Button bmultiply;
        private System.Windows.Forms.Button bminus;
        private System.Windows.Forms.Button bplus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TextBox textVal1Real;
        private System.Windows.Forms.TextBox textVal2Real;
        private System.Windows.Forms.TextBox textVal1Imgnr;
        private System.Windows.Forms.TextBox textVal2Imgnr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bGetHashCode;
        private System.Windows.Forms.Button bEquals;
        private System.Windows.Forms.Button bOnDouble;
        private System.Windows.Forms.Button bInDouble;
    }
}

