namespace DataViewDemo
{
    partial class Form1
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
            this.btnCreateDataTable = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.vGrid = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnPrimeniFilter = new System.Windows.Forms.Button();
            this.btnPrimeniSort = new System.Windows.Forms.Button();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.btnFilterSort = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateDataTable
            // 
            this.btnCreateDataTable.Location = new System.Drawing.Point(12, 38);
            this.btnCreateDataTable.Name = "btnCreateDataTable";
            this.btnCreateDataTable.Size = new System.Drawing.Size(187, 39);
            this.btnCreateDataTable.TabIndex = 0;
            this.btnCreateDataTable.Text = "Create Data table";
            this.btnCreateDataTable.UseVisualStyleBackColor = true;
            this.btnCreateDataTable.Click += new System.EventHandler(this.btnCreateDataTable_Click);
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 122);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(776, 150);
            this.Grid.TabIndex = 1;
            // 
            // vGrid
            // 
            this.vGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vGrid.Location = new System.Drawing.Point(12, 288);
            this.vGrid.Name = "vGrid";
            this.vGrid.Size = new System.Drawing.Size(776, 150);
            this.vGrid.TabIndex = 2;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(222, 12);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(187, 20);
            this.txtFilter.TabIndex = 3;
            // 
            // btnPrimeniFilter
            // 
            this.btnPrimeniFilter.Location = new System.Drawing.Point(222, 38);
            this.btnPrimeniFilter.Name = "btnPrimeniFilter";
            this.btnPrimeniFilter.Size = new System.Drawing.Size(187, 39);
            this.btnPrimeniFilter.TabIndex = 4;
            this.btnPrimeniFilter.Text = "Filter data";
            this.btnPrimeniFilter.UseVisualStyleBackColor = true;
            this.btnPrimeniFilter.Click += new System.EventHandler(this.btnPrimeniFilter_Click);
            // 
            // btnPrimeniSort
            // 
            this.btnPrimeniSort.Location = new System.Drawing.Point(435, 38);
            this.btnPrimeniSort.Name = "btnPrimeniSort";
            this.btnPrimeniSort.Size = new System.Drawing.Size(187, 39);
            this.btnPrimeniSort.TabIndex = 6;
            this.btnPrimeniSort.Text = "Sort";
            this.btnPrimeniSort.UseVisualStyleBackColor = true;
            this.btnPrimeniSort.Click += new System.EventHandler(this.btnPrimeniSort_Click);
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(435, 12);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(187, 20);
            this.txtSort.TabIndex = 5;
            this.txtSort.Text = "Index DESC";
            // 
            // btnFilterSort
            // 
            this.btnFilterSort.Location = new System.Drawing.Point(639, 38);
            this.btnFilterSort.Name = "btnFilterSort";
            this.btnFilterSort.Size = new System.Drawing.Size(149, 39);
            this.btnFilterSort.TabIndex = 7;
            this.btnFilterSort.Text = "Filter and sort";
            this.btnFilterSort.UseVisualStyleBackColor = true;
            this.btnFilterSort.Click += new System.EventHandler(this.btnFilterSort_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(27, 461);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(233, 74);
            this.btnSaveData.TabIndex = 8;
            this.btnSaveData.Text = "Save data";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(408, 461);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(233, 74);
            this.btnLoadData.TabIndex = 9;
            this.btnLoadData.Text = "Load data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.btnFilterSort);
            this.Controls.Add(this.btnPrimeniSort);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.btnPrimeniFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.vGrid);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnCreateDataTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDataTable;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridView vGrid;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnPrimeniFilter;
        private System.Windows.Forms.Button btnPrimeniSort;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Button btnFilterSort;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnLoadData;
    }
}

