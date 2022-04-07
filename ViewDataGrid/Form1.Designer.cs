
namespace ViewDataGrid
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodiTIDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodiTIDataSet = new ViewDataGrid.ProdiTIDataSet();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new ViewDataGrid.ProdiTIDataSetTableAdapters.MahasiswaTableAdapter();
            this.mahasiswa1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswa1TableAdapter = new ViewDataGrid.ProdiTIDataSetTableAdapters.Mahasiswa1TableAdapter();
            this.nilaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nilaiTableAdapter = new ViewDataGrid.ProdiTIDataSetTableAdapters.NilaiTableAdapter();
            this.mataKuliahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mataKuliahTableAdapter = new ViewDataGrid.ProdiTIDataSetTableAdapters.MataKuliahTableAdapter();
            this.mahasiswaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userMhsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userMhsTableAdapter = new ViewDataGrid.ProdiTIDataSetTableAdapters.UserMhsTableAdapter();
            this.mahasiswaCobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswa_CobaTableAdapter = new ViewDataGrid.ProdiTIDataSetTableAdapters.Mahasiswa_CobaTableAdapter();
            this.mahasiswaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswa1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaCobaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKNilaiNIM1920BF5CBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswa1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaCobaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODIDataSet = new ViewDataGrid.PRODIDataSet();
            this.mahasiswaBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter1 = new ViewDataGrid.PRODIDataSetTableAdapters.mahasiswaTableAdapter();
            this.nimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamahasiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgllahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMhsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaCobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaCobaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKNilaiNIM1920BF5CBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaCobaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nimDataGridViewTextBoxColumn,
            this.namamahasiswaDataGridViewTextBoxColumn,
            this.jeniskelDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.tgllahirDataGridViewTextBoxColumn,
            this.idprodiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mahasiswaBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(40, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1273, 387);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prodiTIDataSetBindingSource
            // 
            this.prodiTIDataSetBindingSource.DataSource = this.prodiTIDataSet;
            this.prodiTIDataSetBindingSource.Position = 0;
            this.prodiTIDataSetBindingSource.CurrentChanged += new System.EventHandler(this.prodiTIDataSetBindingSource_CurrentChanged);
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // mahasiswa1BindingSource
            // 
            this.mahasiswa1BindingSource.DataMember = "Mahasiswa1";
            this.mahasiswa1BindingSource.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // mahasiswa1TableAdapter
            // 
            this.mahasiswa1TableAdapter.ClearBeforeFill = true;
            // 
            // nilaiBindingSource
            // 
            this.nilaiBindingSource.DataMember = "Nilai";
            this.nilaiBindingSource.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // nilaiTableAdapter
            // 
            this.nilaiTableAdapter.ClearBeforeFill = true;
            // 
            // mataKuliahBindingSource
            // 
            this.mataKuliahBindingSource.DataMember = "MataKuliah";
            this.mataKuliahBindingSource.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // mataKuliahTableAdapter
            // 
            this.mataKuliahTableAdapter.ClearBeforeFill = true;
            // 
            // mahasiswaBindingSource1
            // 
            this.mahasiswaBindingSource1.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource1.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // userMhsBindingSource
            // 
            this.userMhsBindingSource.DataMember = "UserMhs";
            this.userMhsBindingSource.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // userMhsTableAdapter
            // 
            this.userMhsTableAdapter.ClearBeforeFill = true;
            // 
            // mahasiswaCobaBindingSource
            // 
            this.mahasiswaCobaBindingSource.DataMember = "Mahasiswa_Coba";
            this.mahasiswaCobaBindingSource.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // mahasiswa_CobaTableAdapter
            // 
            this.mahasiswa_CobaTableAdapter.ClearBeforeFill = true;
            // 
            // mahasiswaBindingSource2
            // 
            this.mahasiswaBindingSource2.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource2.DataSource = this.prodiTIDataSet;
            // 
            // mahasiswa1BindingSource1
            // 
            this.mahasiswa1BindingSource1.DataMember = "Mahasiswa1";
            this.mahasiswa1BindingSource1.DataSource = this.prodiTIDataSetBindingSource;
            this.mahasiswa1BindingSource1.CurrentChanged += new System.EventHandler(this.mahasiswa1BindingSource1_CurrentChanged);
            // 
            // mahasiswaBindingSource3
            // 
            this.mahasiswaBindingSource3.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource3.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // mahasiswaCobaBindingSource1
            // 
            this.mahasiswaCobaBindingSource1.DataMember = "Mahasiswa_Coba";
            this.mahasiswaCobaBindingSource1.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // fKNilaiNIM1920BF5CBindingSource
            // 
            this.fKNilaiNIM1920BF5CBindingSource.DataMember = "FK__Nilai__NIM__1920BF5C";
            this.fKNilaiNIM1920BF5CBindingSource.DataSource = this.mahasiswa1BindingSource1;
            // 
            // mahasiswaBindingSource4
            // 
            this.mahasiswaBindingSource4.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource4.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // mahasiswa1BindingSource2
            // 
            this.mahasiswa1BindingSource2.DataMember = "Mahasiswa1";
            this.mahasiswa1BindingSource2.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // mahasiswaCobaBindingSource2
            // 
            this.mahasiswaCobaBindingSource2.DataMember = "Mahasiswa_Coba";
            this.mahasiswaCobaBindingSource2.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // pRODIDataSet
            // 
            this.pRODIDataSet.DataSetName = "PRODIDataSet";
            this.pRODIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource5
            // 
            this.mahasiswaBindingSource5.DataMember = "mahasiswa";
            this.mahasiswaBindingSource5.DataSource = this.pRODIDataSet;
            // 
            // mahasiswaTableAdapter1
            // 
            this.mahasiswaTableAdapter1.ClearBeforeFill = true;
            // 
            // nimDataGridViewTextBoxColumn
            // 
            this.nimDataGridViewTextBoxColumn.DataPropertyName = "nim";
            this.nimDataGridViewTextBoxColumn.HeaderText = "nim";
            this.nimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nimDataGridViewTextBoxColumn.Name = "nimDataGridViewTextBoxColumn";
            this.nimDataGridViewTextBoxColumn.Width = 125;
            // 
            // namamahasiswaDataGridViewTextBoxColumn
            // 
            this.namamahasiswaDataGridViewTextBoxColumn.DataPropertyName = "nama_mahasiswa";
            this.namamahasiswaDataGridViewTextBoxColumn.HeaderText = "nama_mahasiswa";
            this.namamahasiswaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namamahasiswaDataGridViewTextBoxColumn.Name = "namamahasiswaDataGridViewTextBoxColumn";
            this.namamahasiswaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jeniskelDataGridViewTextBoxColumn
            // 
            this.jeniskelDataGridViewTextBoxColumn.DataPropertyName = "jenis_kel";
            this.jeniskelDataGridViewTextBoxColumn.HeaderText = "jenis_kel";
            this.jeniskelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jeniskelDataGridViewTextBoxColumn.Name = "jeniskelDataGridViewTextBoxColumn";
            this.jeniskelDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // tgllahirDataGridViewTextBoxColumn
            // 
            this.tgllahirDataGridViewTextBoxColumn.DataPropertyName = "tgl_lahir";
            this.tgllahirDataGridViewTextBoxColumn.HeaderText = "tgl_lahir";
            this.tgllahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tgllahirDataGridViewTextBoxColumn.Name = "tgllahirDataGridViewTextBoxColumn";
            this.tgllahirDataGridViewTextBoxColumn.Width = 125;
            // 
            // idprodiDataGridViewTextBoxColumn
            // 
            this.idprodiDataGridViewTextBoxColumn.DataPropertyName = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.HeaderText = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprodiDataGridViewTextBoxColumn.Name = "idprodiDataGridViewTextBoxColumn";
            this.idprodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "EmployeeDetails";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMhsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaCobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaCobaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKNilaiNIM1920BF5CBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaCobaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource prodiTIDataSetBindingSource;
        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ProdiTIDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.BindingSource mahasiswa1BindingSource;
        private ProdiTIDataSetTableAdapters.Mahasiswa1TableAdapter mahasiswa1TableAdapter;
        private System.Windows.Forms.BindingSource nilaiBindingSource;
        private ProdiTIDataSetTableAdapters.NilaiTableAdapter nilaiTableAdapter;
        private System.Windows.Forms.BindingSource mataKuliahBindingSource;
        private ProdiTIDataSetTableAdapters.MataKuliahTableAdapter mataKuliahTableAdapter;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource1;
        private System.Windows.Forms.BindingSource userMhsBindingSource;
        private ProdiTIDataSetTableAdapters.UserMhsTableAdapter userMhsTableAdapter;
        private System.Windows.Forms.BindingSource mahasiswaCobaBindingSource;
        private ProdiTIDataSetTableAdapters.Mahasiswa_CobaTableAdapter mahasiswa_CobaTableAdapter;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource2;
        private System.Windows.Forms.BindingSource mahasiswaCobaBindingSource1;
        private System.Windows.Forms.BindingSource mahasiswa1BindingSource1;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource3;
        private System.Windows.Forms.BindingSource fKNilaiNIM1920BF5CBindingSource;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource4;
        private System.Windows.Forms.BindingSource mahasiswa1BindingSource2;
        private System.Windows.Forms.BindingSource mahasiswaCobaBindingSource2;
        private PRODIDataSet pRODIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource5;
        private PRODIDataSetTableAdapters.mahasiswaTableAdapter mahasiswaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamahasiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgllahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodiDataGridViewTextBoxColumn;
    }
}

