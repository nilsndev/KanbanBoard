namespace KanbanBoard
{
    partial class BoardControl
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
            System.Windows.Forms.Label workFields_countLabel;
            System.Windows.Forms.Label board_nameLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label iDLabel2;
            System.Windows.Forms.Label workField_nameLabel;
            System.Windows.Forms.Label board_indexLabel;
            System.Windows.Forms.Label workfield_ID_of_BoardLabel;
            System.Windows.Forms.Label fore_colorLabel;
            System.Windows.Forms.Label back_colorLabel;
            System.Windows.Forms.Label workField_fontLabel;
            this.FieldAcces_panel1 = new System.Windows.Forms.Panel();
            this.addCard_label1 = new System.Windows.Forms.Label();
            this.top_panel1 = new System.Windows.Forms.Panel();
            this.boardName_textBox1 = new System.Windows.Forms.Label();
            this.editBoard_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.knbanBoard_ds = new KanbanBoard.DS.knbanBoard_ds();
            this.boardSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boardSettingsTableAdapter = new KanbanBoard.DS.knbanBoard_dsTableAdapters.BoardSettingsTableAdapter();
            this.tableAdapterManager = new KanbanBoard.DS.knbanBoard_dsTableAdapters.TableAdapterManager();
            this.workFields_countLabel1 = new System.Windows.Forms.Label();
            this.board_nameLabel1 = new System.Windows.Forms.Label();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.workFieldSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFieldSettingsTableAdapter = new KanbanBoard.DS.knbanBoard_dsTableAdapters.workFieldSettingsTableAdapter();
            this.iDLabel3 = new System.Windows.Forms.Label();
            this.workField_nameLabel1 = new System.Windows.Forms.Label();
            this.board_indexLabel1 = new System.Windows.Forms.Label();
            this.workfield_ID_of_BoardLabel1 = new System.Windows.Forms.Label();
            this.fore_colorLabel1 = new System.Windows.Forms.Label();
            this.back_colorLabel1 = new System.Windows.Forms.Label();
            this.workField_fontLabel1 = new System.Windows.Forms.Label();
            workFields_countLabel = new System.Windows.Forms.Label();
            board_nameLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            iDLabel2 = new System.Windows.Forms.Label();
            workField_nameLabel = new System.Windows.Forms.Label();
            board_indexLabel = new System.Windows.Forms.Label();
            workfield_ID_of_BoardLabel = new System.Windows.Forms.Label();
            fore_colorLabel = new System.Windows.Forms.Label();
            back_colorLabel = new System.Windows.Forms.Label();
            workField_fontLabel = new System.Windows.Forms.Label();
            this.top_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editBoard_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knbanBoard_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFieldSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // workFields_countLabel
            // 
            workFields_countLabel.AutoSize = true;
            workFields_countLabel.Location = new System.Drawing.Point(150, 111);
            workFields_countLabel.Name = "workFields_countLabel";
            workFields_countLabel.Size = new System.Drawing.Size(113, 16);
            workFields_countLabel.TabIndex = 15;
            workFields_countLabel.Text = "work Fields count:";
            // 
            // board_nameLabel
            // 
            board_nameLabel.AutoSize = true;
            board_nameLabel.Location = new System.Drawing.Point(150, 134);
            board_nameLabel.Name = "board_nameLabel";
            board_nameLabel.Size = new System.Drawing.Size(83, 16);
            board_nameLabel.TabIndex = 17;
            board_nameLabel.Text = "board name:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(150, 157);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 19;
            iDLabel.Text = "ID:";
            // 
            // iDLabel2
            // 
            iDLabel2.AutoSize = true;
            iDLabel2.Location = new System.Drawing.Point(150, 250);
            iDLabel2.Name = "iDLabel2";
            iDLabel2.Size = new System.Drawing.Size(23, 16);
            iDLabel2.TabIndex = 20;
            iDLabel2.Text = "ID:";
            // 
            // workField_nameLabel
            // 
            workField_nameLabel.AutoSize = true;
            workField_nameLabel.Location = new System.Drawing.Point(150, 273);
            workField_nameLabel.Name = "workField_nameLabel";
            workField_nameLabel.Size = new System.Drawing.Size(108, 16);
            workField_nameLabel.TabIndex = 22;
            workField_nameLabel.Text = "work Field name:";
            // 
            // board_indexLabel
            // 
            board_indexLabel.AutoSize = true;
            board_indexLabel.Location = new System.Drawing.Point(150, 296);
            board_indexLabel.Name = "board_indexLabel";
            board_indexLabel.Size = new System.Drawing.Size(81, 16);
            board_indexLabel.TabIndex = 24;
            board_indexLabel.Text = "board index:";
            // 
            // workfield_ID_of_BoardLabel
            // 
            workfield_ID_of_BoardLabel.AutoSize = true;
            workfield_ID_of_BoardLabel.Location = new System.Drawing.Point(142, 319);
            workfield_ID_of_BoardLabel.Name = "workfield_ID_of_BoardLabel";
            workfield_ID_of_BoardLabel.Size = new System.Drawing.Size(133, 16);
            workfield_ID_of_BoardLabel.TabIndex = 25;
            workfield_ID_of_BoardLabel.Text = "workfield ID of Board:";
            // 
            // fore_colorLabel
            // 
            fore_colorLabel.AutoSize = true;
            fore_colorLabel.Location = new System.Drawing.Point(142, 344);
            fore_colorLabel.Name = "fore_colorLabel";
            fore_colorLabel.Size = new System.Drawing.Size(66, 16);
            fore_colorLabel.TabIndex = 26;
            fore_colorLabel.Text = "fore color:";
            // 
            // back_colorLabel
            // 
            back_colorLabel.AutoSize = true;
            back_colorLabel.Location = new System.Drawing.Point(135, 367);
            back_colorLabel.Name = "back_colorLabel";
            back_colorLabel.Size = new System.Drawing.Size(73, 16);
            back_colorLabel.TabIndex = 27;
            back_colorLabel.Text = "back color:";
            // 
            // workField_fontLabel
            // 
            workField_fontLabel.AutoSize = true;
            workField_fontLabel.Location = new System.Drawing.Point(135, 398);
            workField_fontLabel.Name = "workField_fontLabel";
            workField_fontLabel.Size = new System.Drawing.Size(95, 16);
            workField_fontLabel.TabIndex = 28;
            workField_fontLabel.Text = "work Field font:";
            // 
            // FieldAcces_panel1
            // 
            this.FieldAcces_panel1.AutoScroll = true;
            this.FieldAcces_panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.FieldAcces_panel1.Location = new System.Drawing.Point(0, 58);
            this.FieldAcces_panel1.Margin = new System.Windows.Forms.Padding(4);
            this.FieldAcces_panel1.Name = "FieldAcces_panel1";
            this.FieldAcces_panel1.Size = new System.Drawing.Size(72, 418);
            this.FieldAcces_panel1.TabIndex = 13;
            this.FieldAcces_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FieldAcces_panel1_Paint);
            // 
            // addCard_label1
            // 
            this.addCard_label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCard_label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addCard_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCard_label1.ForeColor = System.Drawing.Color.Gray;
            this.addCard_label1.Location = new System.Drawing.Point(0, 476);
            this.addCard_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addCard_label1.Name = "addCard_label1";
            this.addCard_label1.Size = new System.Drawing.Size(426, 38);
            this.addCard_label1.TabIndex = 13;
            this.addCard_label1.Text = "Add a card...";
            this.addCard_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCard_label1.Click += new System.EventHandler(this.addCard_label1_Click);
            // 
            // top_panel1
            // 
            this.top_panel1.Controls.Add(this.boardName_textBox1);
            this.top_panel1.Controls.Add(this.editBoard_pictureBox1);
            this.top_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel1.Location = new System.Drawing.Point(0, 0);
            this.top_panel1.Margin = new System.Windows.Forms.Padding(4);
            this.top_panel1.Name = "top_panel1";
            this.top_panel1.Size = new System.Drawing.Size(426, 58);
            this.top_panel1.TabIndex = 14;
            this.top_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.top_panel1_Paint);
            // 
            // boardName_textBox1
            // 
            this.boardName_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardName_textBox1.Location = new System.Drawing.Point(3, 7);
            this.boardName_textBox1.Name = "boardName_textBox1";
            this.boardName_textBox1.Size = new System.Drawing.Size(234, 47);
            this.boardName_textBox1.TabIndex = 17;
            this.boardName_textBox1.Text = "Text";
            this.boardName_textBox1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boardName_textBox1.Click += new System.EventHandler(this.label1_Click);
            // 
            // editBoard_pictureBox1
            // 
            this.editBoard_pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBoard_pictureBox1.Image = global::KanbanBoard.Properties.Resources.meatBallsMenu;
            this.editBoard_pictureBox1.Location = new System.Drawing.Point(369, 7);
            this.editBoard_pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.editBoard_pictureBox1.Name = "editBoard_pictureBox1";
            this.editBoard_pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.editBoard_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editBoard_pictureBox1.TabIndex = 16;
            this.editBoard_pictureBox1.TabStop = false;
            this.editBoard_pictureBox1.Click += new System.EventHandler(this.editBoard_pictureBox1_Click);
            // 
            // knbanBoard_ds
            // 
            this.knbanBoard_ds.DataSetName = "knbanBoard_ds";
            this.knbanBoard_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoardSettingsTableAdapter = this.boardSettingsTableAdapter;
            this.tableAdapterManager.UpdateOrder = KanbanBoard.DS.knbanBoard_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workFieldSettingsTableAdapter = null;
            // 
            // workFields_countLabel1
            // 
            this.workFields_countLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "workFields_count", true));
            this.workFields_countLabel1.Location = new System.Drawing.Point(269, 111);
            this.workFields_countLabel1.Name = "workFields_countLabel1";
            this.workFields_countLabel1.Size = new System.Drawing.Size(100, 23);
            this.workFields_countLabel1.TabIndex = 16;
            this.workFields_countLabel1.Text = "label1";
            // 
            // board_nameLabel1
            // 
            this.board_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "board_name", true));
            this.board_nameLabel1.Location = new System.Drawing.Point(269, 134);
            this.board_nameLabel1.Name = "board_nameLabel1";
            this.board_nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.board_nameLabel1.TabIndex = 18;
            this.board_nameLabel1.Text = "label1";
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "ID", true));
            this.iDLabel1.Location = new System.Drawing.Point(269, 157);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDLabel1.TabIndex = 20;
            this.iDLabel1.Text = "label1";
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
            // iDLabel3
            // 
            this.iDLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "ID", true));
            this.iDLabel3.Location = new System.Drawing.Point(264, 250);
            this.iDLabel3.Name = "iDLabel3";
            this.iDLabel3.Size = new System.Drawing.Size(100, 23);
            this.iDLabel3.TabIndex = 21;
            this.iDLabel3.Text = "label1";
            // 
            // workField_nameLabel1
            // 
            this.workField_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "workField_name", true));
            this.workField_nameLabel1.Location = new System.Drawing.Point(264, 273);
            this.workField_nameLabel1.Name = "workField_nameLabel1";
            this.workField_nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.workField_nameLabel1.TabIndex = 23;
            this.workField_nameLabel1.Text = "label1";
            // 
            // board_indexLabel1
            // 
            this.board_indexLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "board_index", true));
            this.board_indexLabel1.Location = new System.Drawing.Point(264, 296);
            this.board_indexLabel1.Name = "board_indexLabel1";
            this.board_indexLabel1.Size = new System.Drawing.Size(100, 23);
            this.board_indexLabel1.TabIndex = 25;
            this.board_indexLabel1.Text = "label1";
            // 
            // workfield_ID_of_BoardLabel1
            // 
            this.workfield_ID_of_BoardLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "workfield_ID_of_Board", true));
            this.workfield_ID_of_BoardLabel1.Location = new System.Drawing.Point(281, 319);
            this.workfield_ID_of_BoardLabel1.Name = "workfield_ID_of_BoardLabel1";
            this.workfield_ID_of_BoardLabel1.Size = new System.Drawing.Size(100, 23);
            this.workfield_ID_of_BoardLabel1.TabIndex = 26;
            this.workfield_ID_of_BoardLabel1.Text = "label1";
            // 
            // fore_colorLabel1
            // 
            this.fore_colorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "fore_color", true));
            this.fore_colorLabel1.Location = new System.Drawing.Point(214, 344);
            this.fore_colorLabel1.Name = "fore_colorLabel1";
            this.fore_colorLabel1.Size = new System.Drawing.Size(100, 23);
            this.fore_colorLabel1.TabIndex = 27;
            this.fore_colorLabel1.Text = "label1";
            // 
            // back_colorLabel1
            // 
            this.back_colorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "back_color", true));
            this.back_colorLabel1.Location = new System.Drawing.Point(214, 367);
            this.back_colorLabel1.Name = "back_colorLabel1";
            this.back_colorLabel1.Size = new System.Drawing.Size(100, 23);
            this.back_colorLabel1.TabIndex = 28;
            this.back_colorLabel1.Text = "label1";
            // 
            // workField_fontLabel1
            // 
            this.workField_fontLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "workField_font", true));
            this.workField_fontLabel1.Location = new System.Drawing.Point(236, 398);
            this.workField_fontLabel1.Name = "workField_fontLabel1";
            this.workField_fontLabel1.Size = new System.Drawing.Size(100, 23);
            this.workField_fontLabel1.TabIndex = 29;
            this.workField_fontLabel1.Text = "label1";
            // 
            // BoardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.FieldAcces_panel1);
            this.Controls.Add(this.addCard_label1);
            this.Controls.Add(this.top_panel1);
            this.Controls.Add(workField_fontLabel);
            this.Controls.Add(this.workField_fontLabel1);
            this.Controls.Add(back_colorLabel);
            this.Controls.Add(this.back_colorLabel1);
            this.Controls.Add(fore_colorLabel);
            this.Controls.Add(this.fore_colorLabel1);
            this.Controls.Add(workfield_ID_of_BoardLabel);
            this.Controls.Add(this.workfield_ID_of_BoardLabel1);
            this.Controls.Add(iDLabel2);
            this.Controls.Add(this.iDLabel3);
            this.Controls.Add(workField_nameLabel);
            this.Controls.Add(this.workField_nameLabel1);
            this.Controls.Add(board_indexLabel);
            this.Controls.Add(this.board_indexLabel1);
            this.Controls.Add(workFields_countLabel);
            this.Controls.Add(this.workFields_countLabel1);
            this.Controls.Add(board_nameLabel);
            this.Controls.Add(this.board_nameLabel1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BoardControl";
            this.Size = new System.Drawing.Size(426, 514);
            this.Load += new System.EventHandler(this.BoardControl_Load);
            this.top_panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editBoard_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knbanBoard_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFieldSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel FieldAcces_panel1;
        private System.Windows.Forms.Panel top_panel1;
        private System.Windows.Forms.PictureBox editBoard_pictureBox1;
        private DS.knbanBoard_ds knbanBoard_ds;
        private System.Windows.Forms.BindingSource boardSettingsBindingSource;
        private DS.knbanBoard_dsTableAdapters.BoardSettingsTableAdapter boardSettingsTableAdapter;
        private DS.knbanBoard_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label workFields_countLabel1;
        private System.Windows.Forms.Label board_nameLabel1;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.BindingSource workFieldSettingsBindingSource;
        private DS.knbanBoard_dsTableAdapters.workFieldSettingsTableAdapter workFieldSettingsTableAdapter;
        private System.Windows.Forms.Label iDLabel3;
        private System.Windows.Forms.Label workField_nameLabel1;
        private System.Windows.Forms.Label board_indexLabel1;
        private System.Windows.Forms.Label workfield_ID_of_BoardLabel1;
        public System.Windows.Forms.Label addCard_label1;
        public System.Windows.Forms.Label boardName_textBox1;
        private System.Windows.Forms.Label fore_colorLabel1;
        private System.Windows.Forms.Label back_colorLabel1;
        private System.Windows.Forms.Label workField_fontLabel1;
    }
}
