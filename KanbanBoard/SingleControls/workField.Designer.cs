namespace KanbanBoard
{
    partial class workField
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label board_indexLabel;
            System.Windows.Forms.Label workFields_countLabel;
            this.edit_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wf_id_label1 = new System.Windows.Forms.Label();
            this.workField_textBox1 = new System.Windows.Forms.Label();
            this.knbanBoard_ds = new KanbanBoard.DS.knbanBoard_ds();
            this.workFieldSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFieldSettingsTableAdapter = new KanbanBoard.DS.knbanBoard_dsTableAdapters.workFieldSettingsTableAdapter();
            this.tableAdapterManager = new KanbanBoard.DS.knbanBoard_dsTableAdapters.TableAdapterManager();
            this.boardSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boardSettingsTableAdapter = new KanbanBoard.DS.knbanBoard_dsTableAdapters.BoardSettingsTableAdapter();
            this.board_indexLabel1 = new System.Windows.Forms.Label();
            this.workFields_countLabel1 = new System.Windows.Forms.Label();
            board_indexLabel = new System.Windows.Forms.Label();
            workFields_countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edit_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knbanBoard_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFieldSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // board_indexLabel
            // 
            board_indexLabel.AutoSize = true;
            board_indexLabel.Location = new System.Drawing.Point(64, 9);
            board_indexLabel.Name = "board_indexLabel";
            board_indexLabel.Size = new System.Drawing.Size(95, 20);
            board_indexLabel.TabIndex = 4;
            board_indexLabel.Text = "board index:";
            // 
            // workFields_countLabel
            // 
            workFields_countLabel.AutoSize = true;
            workFields_countLabel.Location = new System.Drawing.Point(64, 7);
            workFields_countLabel.Name = "workFields_countLabel";
            workFields_countLabel.Size = new System.Drawing.Size(136, 20);
            workFields_countLabel.TabIndex = 6;
            workFields_countLabel.Text = "work Fields count:";
            // 
            // edit_pictureBox1
            // 
            this.edit_pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.edit_pictureBox1.Image = global::KanbanBoard.Properties.Resources.edit_icon;
            this.edit_pictureBox1.Location = new System.Drawing.Point(3, 41);
            this.edit_pictureBox1.Name = "edit_pictureBox1";
            this.edit_pictureBox1.Size = new System.Drawing.Size(55, 47);
            this.edit_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edit_pictureBox1.TabIndex = 1;
            this.edit_pictureBox1.TabStop = false;
            this.edit_pictureBox1.Click += new System.EventHandler(this.edit_pictureBox1_Click);
            // 
            // wf_id_label1
            // 
            this.wf_id_label1.AutoSize = true;
            this.wf_id_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wf_id_label1.Location = new System.Drawing.Point(27, 1);
            this.wf_id_label1.Name = "wf_id_label1";
            this.wf_id_label1.Size = new System.Drawing.Size(25, 26);
            this.wf_id_label1.TabIndex = 2;
            this.wf_id_label1.Text = "0";
            // 
            // workField_textBox1
            // 
            this.workField_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workField_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workField_textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knbanBoard_ds, "workFieldSettings.workField_name", true));
            this.workField_textBox1.Location = new System.Drawing.Point(3, 1);
            this.workField_textBox1.Name = "workField_textBox1";
            this.workField_textBox1.Size = new System.Drawing.Size(361, 37);
            this.workField_textBox1.TabIndex = 3;
            this.workField_textBox1.Text = "Text";
            this.workField_textBox1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // knbanBoard_ds
            // 
            this.knbanBoard_ds.DataSetName = "knbanBoard_ds";
            this.knbanBoard_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workFieldSettingsBindingSource
            // 
            this.workFieldSettingsBindingSource.DataMember = "workFieldSettings";
            this.workFieldSettingsBindingSource.DataSource = this.knbanBoard_ds;
            // 
            // workFieldSettingsTableAdapter
            // 
            this.workFieldSettingsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoardSettingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KanbanBoard.DS.knbanBoard_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workFieldSettingsTableAdapter = this.workFieldSettingsTableAdapter;
            // 
            // boardSettingsBindingSource
            // 
            this.boardSettingsBindingSource.DataMember = "BoardSettings";
            this.boardSettingsBindingSource.DataSource = this.knbanBoard_ds;
            // 
            // boardSettingsTableAdapter
            // 
            this.boardSettingsTableAdapter.ClearBeforeFill = true;
            // 
            // board_indexLabel1
            // 
            this.board_indexLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "board_index", true));
            this.board_indexLabel1.Location = new System.Drawing.Point(207, 10);
            this.board_indexLabel1.Name = "board_indexLabel1";
            this.board_indexLabel1.Size = new System.Drawing.Size(100, 23);
            this.board_indexLabel1.TabIndex = 5;
            this.board_indexLabel1.Text = "label1";
            // 
            // workFields_countLabel1
            // 
            this.workFields_countLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "workFields_count", true));
            this.workFields_countLabel1.Location = new System.Drawing.Point(239, 7);
            this.workFields_countLabel1.Name = "workFields_countLabel1";
            this.workFields_countLabel1.Size = new System.Drawing.Size(100, 23);
            this.workFields_countLabel1.TabIndex = 7;
            this.workFields_countLabel1.Text = "label1";
            // 
            // workField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.workField_textBox1);
            this.Controls.Add(this.edit_pictureBox1);
            this.Controls.Add(this.wf_id_label1);
            this.Controls.Add(board_indexLabel);
            this.Controls.Add(this.board_indexLabel1);
            this.Controls.Add(workFields_countLabel);
            this.Controls.Add(this.workFields_countLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "workField";
            this.Size = new System.Drawing.Size(367, 91);
            this.Load += new System.EventHandler(this.workField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edit_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knbanBoard_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFieldSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox edit_pictureBox1;
        private System.Windows.Forms.BindingSource workFieldSettingsBindingSource;
        private DS.knbanBoard_ds knbanBoard_ds;
        private DS.knbanBoard_dsTableAdapters.workFieldSettingsTableAdapter workFieldSettingsTableAdapter;
        private DS.knbanBoard_dsTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.Label wf_id_label1;
        public System.Windows.Forms.Label workField_textBox1;
        private System.Windows.Forms.BindingSource boardSettingsBindingSource;
        private DS.knbanBoard_dsTableAdapters.BoardSettingsTableAdapter boardSettingsTableAdapter;
        private System.Windows.Forms.Label board_indexLabel1;
        private System.Windows.Forms.Label workFields_countLabel1;
    }
}
