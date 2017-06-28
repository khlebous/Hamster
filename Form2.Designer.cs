namespace wf1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boardSizeComboBox = new System.Windows.Forms.ComboBox();
            this.ActiveButtinsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ClicksToEndNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonSquare = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MyCancelButton = new System.Windows.Forms.Button();
            this.MyOkButton = new System.Windows.Forms.Button();
            this.radioButtonRound = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveButtinsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClicksToEndNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // boardSizeComboBox
            // 
            this.boardSizeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boardSizeComboBox.FormattingEnabled = true;
            this.boardSizeComboBox.Location = new System.Drawing.Point(152, 6);
            this.boardSizeComboBox.Name = "boardSizeComboBox";
            this.boardSizeComboBox.Size = new System.Drawing.Size(136, 21);
            this.boardSizeComboBox.TabIndex = 0;
            this.boardSizeComboBox.Text = "4 x 4";
            // 
            // ActiveButtinsNumericUpDown
            // 
            this.ActiveButtinsNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActiveButtinsNumericUpDown.Location = new System.Drawing.Point(152, 39);
            this.ActiveButtinsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ActiveButtinsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ActiveButtinsNumericUpDown.Name = "ActiveButtinsNumericUpDown";
            this.ActiveButtinsNumericUpDown.Size = new System.Drawing.Size(136, 20);
            this.ActiveButtinsNumericUpDown.TabIndex = 1;
            this.ActiveButtinsNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ClicksToEndNumericUpDown
            // 
            this.ClicksToEndNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClicksToEndNumericUpDown.Location = new System.Drawing.Point(152, 72);
            this.ClicksToEndNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ClicksToEndNumericUpDown.Name = "ClicksToEndNumericUpDown";
            this.ClicksToEndNumericUpDown.Size = new System.Drawing.Size(136, 20);
            this.ClicksToEndNumericUpDown.TabIndex = 2;
            this.ClicksToEndNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Board size:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of active buttons:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of clicks to end:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radioButtonSquare, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.boardSizeComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ActiveButtinsNumericUpDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ClicksToEndNumericUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonRound, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00031F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99907F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00031F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00031F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 169);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // radioButtonSquare
            // 
            this.radioButtonSquare.AutoSize = true;
            this.radioButtonSquare.Checked = true;
            this.radioButtonSquare.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonSquare.Location = new System.Drawing.Point(6, 102);
            this.radioButtonSquare.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButtonSquare.Name = "radioButtonSquare";
            this.radioButtonSquare.Size = new System.Drawing.Size(98, 27);
            this.radioButtonSquare.TabIndex = 7;
            this.radioButtonSquare.TabStop = true;
            this.radioButtonSquare.Text = "Square Buttons";
            this.radioButtonSquare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonSquare.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.MyCancelButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MyOkButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(150, 135);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(141, 31);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // MyCancelButton
            // 
            this.MyCancelButton.Location = new System.Drawing.Point(3, 3);
            this.MyCancelButton.Name = "MyCancelButton";
            this.MyCancelButton.Size = new System.Drawing.Size(62, 20);
            this.MyCancelButton.TabIndex = 0;
            this.MyCancelButton.Text = "Cancel";
            this.MyCancelButton.UseVisualStyleBackColor = true;
            this.MyCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MyOkButton
            // 
            this.MyOkButton.Location = new System.Drawing.Point(73, 3);
            this.MyOkButton.Name = "MyOkButton";
            this.MyOkButton.Size = new System.Drawing.Size(62, 20);
            this.MyOkButton.TabIndex = 1;
            this.MyOkButton.Text = "OK";
            this.MyOkButton.UseVisualStyleBackColor = true;
            this.MyOkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // radioButtonRound
            // 
            this.radioButtonRound.AutoSize = true;
            this.radioButtonRound.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonRound.Location = new System.Drawing.Point(153, 102);
            this.radioButtonRound.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButtonRound.Name = "radioButtonRound";
            this.radioButtonRound.Size = new System.Drawing.Size(96, 27);
            this.radioButtonRound.TabIndex = 8;
            this.radioButtonRound.Text = "Round Buttons";
            this.radioButtonRound.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 169);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 162);
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ActiveButtinsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClicksToEndNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox boardSizeComboBox;
        private System.Windows.Forms.NumericUpDown ActiveButtinsNumericUpDown;
        private System.Windows.Forms.NumericUpDown ClicksToEndNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button MyCancelButton;
        private System.Windows.Forms.Button MyOkButton;
        private System.Windows.Forms.RadioButton radioButtonSquare;
        private System.Windows.Forms.RadioButton radioButtonRound;
    }
}