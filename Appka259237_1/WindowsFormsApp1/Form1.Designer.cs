namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bigTextBox = new System.Windows.Forms.TextBox();
            this.smallTextBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.number_of_itemsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_FastSort = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_BestValueSort = new System.Windows.Forms.RadioButton();
            this.radioButton_BestRatioSort = new System.Windows.Forms.RadioButton();
            this.radioButton_DPAlgorithm = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigTextBox
            // 
            this.bigTextBox.Location = new System.Drawing.Point(30, 77);
            this.bigTextBox.Multiline = true;
            this.bigTextBox.Name = "bigTextBox";
            this.bigTextBox.Size = new System.Drawing.Size(388, 333);
            this.bigTextBox.TabIndex = 0;
            // 
            // smallTextBox
            // 
            this.smallTextBox.Location = new System.Drawing.Point(446, 186);
            this.smallTextBox.Name = "smallTextBox";
            this.smallTextBox.Size = new System.Drawing.Size(272, 22);
            this.smallTextBox.TabIndex = 1;
            this.smallTextBox.TextChanged += new System.EventHandler(this.smallTextBox_TextChanged);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(511, 395);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(126, 66);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(446, 142);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(272, 22);
            this.capacityTextBox.TabIndex = 3;
            // 
            // number_of_itemsTextBox
            // 
            this.number_of_itemsTextBox.Location = new System.Drawing.Point(446, 98);
            this.number_of_itemsTextBox.Name = "number_of_itemsTextBox";
            this.number_of_itemsTextBox.Size = new System.Drawing.Size(272, 22);
            this.number_of_itemsTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of items to generate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Max capacity of backpack:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seed:";
            // 
            // radioButton_FastSort
            // 
            this.radioButton_FastSort.AutoSize = true;
            this.radioButton_FastSort.Location = new System.Drawing.Point(10, 21);
            this.radioButton_FastSort.Name = "radioButton_FastSort";
            this.radioButton_FastSort.Size = new System.Drawing.Size(81, 20);
            this.radioButton_FastSort.TabIndex = 8;
            this.radioButton_FastSort.TabStop = true;
            this.radioButton_FastSort.Text = "Fast Sort";
            this.radioButton_FastSort.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_DPAlgorithm);
            this.groupBox1.Controls.Add(this.radioButton_BestRatioSort);
            this.groupBox1.Controls.Add(this.radioButton_BestValueSort);
            this.groupBox1.Controls.Add(this.radioButton_FastSort);
            this.groupBox1.Location = new System.Drawing.Point(446, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 134);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort type:";
            // 
            // radioButton_BestValueSort
            // 
            this.radioButton_BestValueSort.AutoSize = true;
            this.radioButton_BestValueSort.Location = new System.Drawing.Point(10, 47);
            this.radioButton_BestValueSort.Name = "radioButton_BestValueSort";
            this.radioButton_BestValueSort.Size = new System.Drawing.Size(120, 20);
            this.radioButton_BestValueSort.TabIndex = 9;
            this.radioButton_BestValueSort.TabStop = true;
            this.radioButton_BestValueSort.Text = "Best Value Sort";
            this.radioButton_BestValueSort.UseVisualStyleBackColor = true;
            // 
            // radioButton_BestRatioSort
            // 
            this.radioButton_BestRatioSort.AutoSize = true;
            this.radioButton_BestRatioSort.Location = new System.Drawing.Point(10, 73);
            this.radioButton_BestRatioSort.Name = "radioButton_BestRatioSort";
            this.radioButton_BestRatioSort.Size = new System.Drawing.Size(146, 20);
            this.radioButton_BestRatioSort.TabIndex = 10;
            this.radioButton_BestRatioSort.TabStop = true;
            this.radioButton_BestRatioSort.Text = "Best V/W Ratio Sort";
            this.radioButton_BestRatioSort.UseVisualStyleBackColor = true;
            // 
            // radioButton_DPAlgorithm
            // 
            this.radioButton_DPAlgorithm.AutoSize = true;
            this.radioButton_DPAlgorithm.Location = new System.Drawing.Point(10, 99);
            this.radioButton_DPAlgorithm.Name = "radioButton_DPAlgorithm";
            this.radioButton_DPAlgorithm.Size = new System.Drawing.Size(173, 20);
            this.radioButton_DPAlgorithm.TabIndex = 11;
            this.radioButton_DPAlgorithm.TabStop = true;
            this.radioButton_DPAlgorithm.Text = "DP Algorithm (not ready)";
            this.radioButton_DPAlgorithm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number_of_itemsTextBox);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.smallTextBox);
            this.Controls.Add(this.bigTextBox);
            this.Name = "Form1";
            this.Text = "Plecak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bigTextBox;
        private System.Windows.Forms.TextBox smallTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox number_of_itemsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_FastSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_DPAlgorithm;
        private System.Windows.Forms.RadioButton radioButton_BestRatioSort;
        private System.Windows.Forms.RadioButton radioButton_BestValueSort;
    }
}

