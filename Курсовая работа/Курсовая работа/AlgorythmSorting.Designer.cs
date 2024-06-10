namespace Курсовая_работа
{
    partial class AlgorythmSorting
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInputArray;
        private System.Windows.Forms.ComboBox cmbSortingAlgorithm;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txtSortedArray;
        private System.Windows.Forms.Label lblElapsedTime;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInputArray = new System.Windows.Forms.TextBox();
            this.cmbSortingAlgorithm = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtSortedArray = new System.Windows.Forms.TextBox();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInputArray
            // 
            this.txtInputArray.Location = new System.Drawing.Point(12, 41);
            this.txtInputArray.Name = "txtInputArray";
            this.txtInputArray.Size = new System.Drawing.Size(233, 27);
            this.txtInputArray.TabIndex = 0;
            // 
            // cmbSortingAlgorithm
            // 
            this.cmbSortingAlgorithm.FormattingEnabled = true;
            this.cmbSortingAlgorithm.Items.AddRange(new object[] {
            "Сортировка выбором",
            "Сортировка вставкой",
            "Сортировка слиянием",
            "Сортировка пирамидой"});
            this.cmbSortingAlgorithm.Location = new System.Drawing.Point(273, 40);
            this.cmbSortingAlgorithm.Name = "cmbSortingAlgorithm";
            this.cmbSortingAlgorithm.Size = new System.Drawing.Size(213, 28);
            this.cmbSortingAlgorithm.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 80);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(233, 35);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtSortedArray
            // 
            this.txtSortedArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSortedArray.Location = new System.Drawing.Point(273, 85);
            this.txtSortedArray.Name = "txtSortedArray";
            this.txtSortedArray.ReadOnly = true;
            this.txtSortedArray.Size = new System.Drawing.Size(213, 30);
            this.txtSortedArray.TabIndex = 3;
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblElapsedTime.Location = new System.Drawing.Point(34, 131);
            this.lblElapsedTime.Name = "lblВремя выполнения";
            this.lblElapsedTime.Size = new System.Drawing.Size(192, 20);
            this.lblElapsedTime.TabIndex = 4;
            this.lblElapsedTime.Text = "Время выполнения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Заполните поле массивом";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(282, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите сортировку";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(508, 171);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.txtSortedArray);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cmbSortingAlgorithm);
            this.Controls.Add(this.txtInputArray);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Sorting Algorithms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
