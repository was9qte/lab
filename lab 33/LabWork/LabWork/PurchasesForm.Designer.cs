namespace LabWork
{
    partial class PurchasesForm
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
            this.PurchasesDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveCsvBsvutton = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchasesDataGridView
            // 
            this.PurchasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchasesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Price,
            this.Quantity});
            this.PurchasesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.PurchasesDataGridView.Name = "PurchasesDataGridView";
            this.PurchasesDataGridView.Size = new System.Drawing.Size(343, 150);
            this.PurchasesDataGridView.TabIndex = 0;
            // 
            // SaveCsvBsvutton
            // 
            this.SaveCsvBsvutton.Location = new System.Drawing.Point(12, 156);
            this.SaveCsvBsvutton.Name = "SaveCsvBsvutton";
            this.SaveCsvBsvutton.Size = new System.Drawing.Size(75, 23);
            this.SaveCsvBsvutton.TabIndex = 1;
            this.SaveCsvBsvutton.Text = "Сохранить";
            this.SaveCsvBsvutton.UseVisualStyleBackColor = true;
            this.SaveCsvBsvutton.Click += new System.EventHandler(this.SaveCsvBsvutton_Click);
            // 
            // Product
            // 
            this.Product.HeaderText = "Товар";
            this.Product.Name = "Product";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Количество";
            this.Quantity.Name = "Quantity";
            // 
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 190);
            this.Controls.Add(this.SaveCsvBsvutton);
            this.Controls.Add(this.PurchasesDataGridView);
            this.Name = "PurchasesForm";
            this.Text = "Покупки";
            ((System.ComponentModel.ISupportInitialize)(this.PurchasesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PurchasesDataGridView;
        private System.Windows.Forms.Button SaveCsvBsvutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}