namespace UI
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
            textBoxNumberOfNumbers = new TextBox();
            labelNumburOfNumbers = new Label();
            buttonAddRows = new Button();
            dataGridViewNumbers = new DataGridView();
            buttonCalculate = new Button();
            textBoxResult = new TextBox();
            labelResult = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNumbers).BeginInit();
            SuspendLayout();
            // 
            // textBoxNumberOfNumbers
            // 
            textBoxNumberOfNumbers.Location = new Point(117, 9);
            textBoxNumberOfNumbers.Name = "textBoxNumberOfNumbers";
            textBoxNumberOfNumbers.Size = new Size(125, 27);
            textBoxNumberOfNumbers.TabIndex = 0;
            // 
            // labelNumburOfNumbers
            // 
            labelNumburOfNumbers.AutoSize = true;
            labelNumburOfNumbers.Location = new Point(19, 16);
            labelNumburOfNumbers.Name = "labelNumburOfNumbers";
            labelNumburOfNumbers.Size = new Size(92, 20);
            labelNumburOfNumbers.TabIndex = 1;
            labelNumburOfNumbers.Text = "Брой числа:";
            // 
            // buttonAddRows
            // 
            buttonAddRows.Location = new Point(26, 45);
            buttonAddRows.Name = "buttonAddRows";
            buttonAddRows.Size = new Size(216, 36);
            buttonAddRows.TabIndex = 2;
            buttonAddRows.Text = "Добави редове";
            buttonAddRows.UseVisualStyleBackColor = true;
            buttonAddRows.Click += buttonAddRows_Click;
            // 
            // dataGridViewNumbers
            // 
            dataGridViewNumbers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNumbers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewNumbers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNumbers.Location = new Point(29, 87);
            dataGridViewNumbers.Name = "dataGridViewNumbers";
            dataGridViewNumbers.RowHeadersWidth = 51;
            dataGridViewNumbers.RowTemplate.Height = 29;
            dataGridViewNumbers.Size = new Size(213, 284);
            dataGridViewNumbers.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(26, 380);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(216, 58);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Калкулирай";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(258, 45);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(392, 393);
            textBoxResult.TabIndex = 5;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(258, 12);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(189, 20);
            labelResult.TabIndex = 6;
            labelResult.Text = "Резултат от изчисленията:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(labelResult);
            Controls.Add(textBoxResult);
            Controls.Add(buttonCalculate);
            Controls.Add(dataGridViewNumbers);
            Controls.Add(buttonAddRows);
            Controls.Add(labelNumburOfNumbers);
            Controls.Add(textBoxNumberOfNumbers);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNumbers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumberOfNumbers;
        private Label labelNumburOfNumbers;
        private Button buttonAddRows;
        private DataGridView dataGridViewNumbers;
        private Button buttonCalculate;
        private TextBox textBoxResult;
        private Label labelResult;
    }
}