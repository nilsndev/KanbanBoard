namespace KanbanBoard
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

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
            System.Windows.Forms.Label board_fontLabel;
            System.Windows.Forms.Label fore_colorLabel;
            System.Windows.Forms.Label back_colorLabel;
            this.header_panel1 = new System.Windows.Forms.Panel();
            this.minimize_button2 = new System.Windows.Forms.Button();
            this.exit_button1 = new System.Windows.Forms.Button();
            this.kanBan_label2 = new System.Windows.Forms.Label();
            this.mdiBoard_panel1 = new System.Windows.Forms.Panel();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFields_countLabel1 = new System.Windows.Forms.Label();
            this.boardSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knbanBoard_ds = new KanbanBoard.DS.knbanBoard_ds();
            this.board_nameLabel1 = new System.Windows.Forms.Label();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.board_fontLabel1 = new System.Windows.Forms.Label();
            this.fore_colorLabel1 = new System.Windows.Forms.Label();
            this.back_colorLabel1 = new System.Windows.Forms.Label();
            this.boardSettingsTableAdapter = new KanbanBoard.DS.knbanBoard_dsTableAdapters.BoardSettingsTableAdapter();
            this.tableAdapterManager = new KanbanBoard.DS.knbanBoard_dsTableAdapters.TableAdapterManager();
            workFields_countLabel = new System.Windows.Forms.Label();
            board_nameLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            board_fontLabel = new System.Windows.Forms.Label();
            fore_colorLabel = new System.Windows.Forms.Label();
            back_colorLabel = new System.Windows.Forms.Label();
            this.header_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knbanBoard_ds)).BeginInit();
            this.SuspendLayout();
            // 
            // workFields_countLabel
            // 
            workFields_countLabel.AutoSize = true;
            workFields_countLabel.Location = new System.Drawing.Point(938, 421);
            workFields_countLabel.Name = "workFields_countLabel";
            workFields_countLabel.Size = new System.Drawing.Size(136, 20);
            workFields_countLabel.TabIndex = 3;
            workFields_countLabel.Text = "work Fields count:";
            // 
            // board_nameLabel
            // 
            board_nameLabel.AutoSize = true;
            board_nameLabel.Location = new System.Drawing.Point(938, 446);
            board_nameLabel.Name = "board_nameLabel";
            board_nameLabel.Size = new System.Drawing.Size(98, 20);
            board_nameLabel.TabIndex = 5;
            board_nameLabel.Text = "board name:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(938, 471);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(30, 20);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // board_fontLabel
            // 
            board_fontLabel.AutoSize = true;
            board_fontLabel.Location = new System.Drawing.Point(938, 511);
            board_fontLabel.Name = "board_fontLabel";
            board_fontLabel.Size = new System.Drawing.Size(86, 20);
            board_fontLabel.TabIndex = 8;
            board_fontLabel.Text = "board font:";
            // 
            // fore_colorLabel
            // 
            fore_colorLabel.AutoSize = true;
            fore_colorLabel.Location = new System.Drawing.Point(938, 547);
            fore_colorLabel.Name = "fore_colorLabel";
            fore_colorLabel.Size = new System.Drawing.Size(79, 20);
            fore_colorLabel.TabIndex = 10;
            fore_colorLabel.Text = "fore color:";
            // 
            // back_colorLabel
            // 
            back_colorLabel.AutoSize = true;
            back_colorLabel.Location = new System.Drawing.Point(938, 584);
            back_colorLabel.Name = "back_colorLabel";
            back_colorLabel.Size = new System.Drawing.Size(85, 20);
            back_colorLabel.TabIndex = 12;
            back_colorLabel.Text = "back color:";
            // 
            // header_panel1
            // 
            this.header_panel1.Controls.Add(this.minimize_button2);
            this.header_panel1.Controls.Add(this.exit_button1);
            this.header_panel1.Controls.Add(this.kanBan_label2);
            this.header_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel1.Location = new System.Drawing.Point(0, 0);
            this.header_panel1.Name = "header_panel1";
            this.header_panel1.Size = new System.Drawing.Size(1455, 95);
            this.header_panel1.TabIndex = 2;
            this.header_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.header_panel1_Paint);
            // 
            // minimize_button2
            // 
            this.minimize_button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_button2.BackgroundImage = global::KanbanBoard.Properties.Resources.minimize_icon;
            this.minimize_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize_button2.Location = new System.Drawing.Point(1275, 14);
            this.minimize_button2.Name = "minimize_button2";
            this.minimize_button2.Size = new System.Drawing.Size(75, 75);
            this.minimize_button2.TabIndex = 5;
            this.minimize_button2.UseVisualStyleBackColor = true;
            this.minimize_button2.Click += new System.EventHandler(this.minimize_button2_Click);
            // 
            // exit_button1
            // 
            this.exit_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button1.BackgroundImage = global::KanbanBoard.Properties.Resources.exit_Icon;
            this.exit_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_button1.Location = new System.Drawing.Point(1368, 12);
            this.exit_button1.Name = "exit_button1";
            this.exit_button1.Size = new System.Drawing.Size(75, 75);
            this.exit_button1.TabIndex = 4;
            this.exit_button1.UseVisualStyleBackColor = true;
            this.exit_button1.Click += new System.EventHandler(this.exit_button1_Click);
            // 
            // kanBan_label2
            // 
            this.kanBan_label2.AutoSize = true;
            this.kanBan_label2.BackColor = System.Drawing.Color.Transparent;
            this.kanBan_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kanBan_label2.ForeColor = System.Drawing.Color.Black;
            this.kanBan_label2.Location = new System.Drawing.Point(3, 14);
            this.kanBan_label2.Name = "kanBan_label2";
            this.kanBan_label2.Size = new System.Drawing.Size(331, 55);
            this.kanBan_label2.TabIndex = 3;
            this.kanBan_label2.Text = "KanbanBoard";
            // 
            // mdiBoard_panel1
            // 
            this.mdiBoard_panel1.AutoScroll = true;
            this.mdiBoard_panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.mdiBoard_panel1.Location = new System.Drawing.Point(0, 95);
            this.mdiBoard_panel1.Name = "mdiBoard_panel1";
            this.mdiBoard_panel1.Size = new System.Drawing.Size(662, 716);
            this.mdiBoard_panel1.TabIndex = 3;
            this.mdiBoard_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.mdiBoard_panel1_Paint);
            // 
            // workFields_countLabel1
            // 
            this.workFields_countLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "workFields_count", true));
            this.workFields_countLabel1.Location = new System.Drawing.Point(1113, 421);
            this.workFields_countLabel1.Name = "workFields_countLabel1";
            this.workFields_countLabel1.Size = new System.Drawing.Size(100, 23);
            this.workFields_countLabel1.TabIndex = 4;
            this.workFields_countLabel1.Text = "label1";
            // 
            // boardSettingsBindingSource
            // 
            this.boardSettingsBindingSource.DataMember = "BoardSettings";
            this.boardSettingsBindingSource.DataSource = this.knbanBoard_ds;
            // 
            // knbanBoard_ds
            // 
            this.knbanBoard_ds.DataSetName = "knbanBoard_ds";
            this.knbanBoard_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // board_nameLabel1
            // 
            this.board_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "board_name", true));
            this.board_nameLabel1.Location = new System.Drawing.Point(1113, 446);
            this.board_nameLabel1.Name = "board_nameLabel1";
            this.board_nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.board_nameLabel1.TabIndex = 6;
            this.board_nameLabel1.Text = "label1";
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "ID", true));
            this.iDLabel1.Location = new System.Drawing.Point(1113, 471);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDLabel1.TabIndex = 8;
            this.iDLabel1.Text = "label1";
            // 
            // board_fontLabel1
            // 
            this.board_fontLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "board_font", true));
            this.board_fontLabel1.Location = new System.Drawing.Point(1049, 511);
            this.board_fontLabel1.Name = "board_fontLabel1";
            this.board_fontLabel1.Size = new System.Drawing.Size(100, 23);
            this.board_fontLabel1.TabIndex = 9;
            this.board_fontLabel1.Text = "label1";
            // 
            // fore_colorLabel1
            // 
            this.fore_colorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "fore_color", true));
            this.fore_colorLabel1.Location = new System.Drawing.Point(1042, 547);
            this.fore_colorLabel1.Name = "fore_colorLabel1";
            this.fore_colorLabel1.Size = new System.Drawing.Size(100, 23);
            this.fore_colorLabel1.TabIndex = 11;
            this.fore_colorLabel1.Text = "label1";
            // 
            // back_colorLabel1
            // 
            this.back_colorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "back_color", true));
            this.back_colorLabel1.Location = new System.Drawing.Point(1051, 584);
            this.back_colorLabel1.Name = "back_colorLabel1";
            this.back_colorLabel1.Size = new System.Drawing.Size(100, 23);
            this.back_colorLabel1.TabIndex = 13;
            this.back_colorLabel1.Text = "label1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1455, 811);
            this.Controls.Add(this.mdiBoard_panel1);
            this.Controls.Add(this.header_panel1);
            this.Controls.Add(back_colorLabel);
            this.Controls.Add(this.back_colorLabel1);
            this.Controls.Add(fore_colorLabel);
            this.Controls.Add(this.fore_colorLabel1);
            this.Controls.Add(board_fontLabel);
            this.Controls.Add(this.board_fontLabel1);
            this.Controls.Add(workFields_countLabel);
            this.Controls.Add(this.workFields_countLabel1);
            this.Controls.Add(board_nameLabel);
            this.Controls.Add(this.board_nameLabel1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KanbanBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header_panel1.ResumeLayout(false);
            this.header_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knbanBoard_ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel header_panel1;
        private System.Windows.Forms.Panel mdiBoard_panel1;
        private System.Windows.Forms.Label kanBan_label2;
        private System.Windows.Forms.Button minimize_button2;
        private System.Windows.Forms.Button exit_button1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DS.knbanBoard_ds knbanBoard_ds;
        private System.Windows.Forms.BindingSource boardSettingsBindingSource;
        private DS.knbanBoard_dsTableAdapters.BoardSettingsTableAdapter boardSettingsTableAdapter;
        private DS.knbanBoard_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label workFields_countLabel1;
        private System.Windows.Forms.Label board_nameLabel1;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.Label board_fontLabel1;
        private System.Windows.Forms.Label fore_colorLabel1;
        private System.Windows.Forms.Label back_colorLabel1;
    }
}

