
namespace Phi_AssignmentPRN
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lablelSearch = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lalbelCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(803, 527);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(637, 44);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(124, 28);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Delete Member";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(144, 482);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(88, 39);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(25, 482);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(88, 39);
            this.btInsert.TabIndex = 3;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 27);
            this.txtSearch.TabIndex = 4;
            // 
            // lablelSearch
            // 
            this.lablelSearch.AutoSize = true;
            this.lablelSearch.Location = new System.Drawing.Point(12, 22);
            this.lablelSearch.Name = "lablelSearch";
            this.lablelSearch.Size = new System.Drawing.Size(53, 20);
            this.lablelSearch.TabIndex = 5;
            this.lablelSearch.Text = "Search";
            this.lablelSearch.Click += new System.EventHandler(this.lablelSearch_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(278, 21);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(91, 20);
            this.labelFilter.TabIndex = 6;
            this.labelFilter.Text = "Filter by City";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(463, 21);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(117, 20);
            this.labelCountry.TabIndex = 7;
            this.labelCountry.Text = "Filter by Country";
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(278, 44);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(151, 28);
            this.cbCity.TabIndex = 8;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(463, 44);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(151, 28);
            this.cbCountry.TabIndex = 9;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(259, 482);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(88, 39);
            this.btRefresh.TabIndex = 10;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lalbelCountry);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.labelCity);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.labelPass);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.btRefresh);
            this.groupBox1.Controls.Add(this.btInsert);
            this.groupBox1.Location = new System.Drawing.Point(831, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 536);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(10, 69);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(24, 20);
            this.labelId.TabIndex = 22;
            this.labelId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(80, 62);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(267, 27);
            this.txtId.TabIndex = 21;
            // 
            // lalbelCountry
            // 
            this.lalbelCountry.AutoSize = true;
            this.lalbelCountry.Location = new System.Drawing.Point(10, 332);
            this.lalbelCountry.Name = "lalbelCountry";
            this.lalbelCountry.Size = new System.Drawing.Size(60, 20);
            this.lalbelCountry.TabIndex = 20;
            this.lalbelCountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(80, 329);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(267, 27);
            this.txtCountry.TabIndex = 19;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(13, 277);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(34, 20);
            this.labelCity.TabIndex = 18;
            this.labelCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(80, 274);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(267, 27);
            this.txtCity.TabIndex = 17;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(13, 226);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 20);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(267, 27);
            this.txtEmail.TabIndex = 15;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(10, 168);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(70, 20);
            this.labelPass.TabIndex = 14;
            this.labelPass.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(80, 165);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(267, 27);
            this.txtPass.TabIndex = 13;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 120);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 20);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(267, 27);
            this.txtName.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.lablelSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lablelSearch;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lalbelCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
    }
}

