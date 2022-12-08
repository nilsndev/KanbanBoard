namespace KanbanBoard.Forms
{
    partial class ConfigureControl
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
            System.Windows.Forms.Label workFields_countLabel;
            System.Windows.Forms.Label board_nameLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label board_fontLabel;
            System.Windows.Forms.Label fore_colorLabel;
            System.Windows.Forms.Label back_colorLabel;
            System.Windows.Forms.Label iDLabel2;
            System.Windows.Forms.Label workField_nameLabel;
            System.Windows.Forms.Label board_indexLabel;
            System.Windows.Forms.Label workfield_ID_of_BoardLabel;
            System.Windows.Forms.Label fore_colorLabel2;
            System.Windows.Forms.Label back_colorLabel2;
            System.Windows.Forms.Label workField_fontLabel;
            this.Text_textBox1 = new System.Windows.Forms.TextBox();
            this.text_label1 = new System.Windows.Forms.Label();
            this.color_groupBox1 = new System.Windows.Forms.GroupBox();
            this.foreColor_button1 = new System.Windows.Forms.Button();
            this.foreColor_textBox1 = new System.Windows.Forms.TextBox();
            this.foreColor_label1 = new System.Windows.Forms.Label();
            this.backColor_button1 = new System.Windows.Forms.Button();
            this.backColor_textBox1 = new System.Windows.Forms.TextBox();
            this.backColor_label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.text_groupBox2 = new System.Windows.Forms.GroupBox();
            this.font_button1 = new System.Windows.Forms.Button();
            this.font_label1 = new System.Windows.Forms.Label();
            this.font_textBox1 = new System.Windows.Forms.TextBox();
            this.save_button1 = new System.Windows.Forms.Button();
            this.cancel_button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.onlyBoard_groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_button1 = new System.Windows.Forms.Button();
            this.remove_Index_button1 = new System.Windows.Forms.Button();
            this.index_comboBox1 = new System.Windows.Forms.ComboBox();
            this.workFieldCount_label1 = new System.Windows.Forms.Label();
            this.ds_groupBox1 = new System.Windows.Forms.GroupBox();
            this.workFieldgroupBox1 = new System.Windows.Forms.GroupBox();
            this.workField_fontLabel1 = new System.Windows.Forms.Label();
            this.workFieldSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knbanBoard_ds = new KanbanBoard.DS.knbanBoard_ds();
            this.back_colorLabel3 = new System.Windows.Forms.Label();
            this.fore_colorLabel3 = new System.Windows.Forms.Label();
            this.workfield_ID_of_BoardLabel1 = new System.Windows.Forms.Label();
            this.board_indexLabel1 = new System.Windows.Forms.Label();
            this.workField_nameLabel1 = new System.Windows.Forms.Label();
            this.iDLabel3 = new System.Windows.Forms.Label();
            this.dataForSingleBoard_groupBox1 = new System.Windows.Forms.GroupBox();
            this.back_colorLabel1 = new System.Windows.Forms.Label();
            this.boardSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fore_colorLabel1 = new System.Windows.Forms.Label();
            this.board_fontLabel1 = new System.Windows.Forms.Label();
            this.workFields_countLabel1 = new System.Windows.Forms.Label();
            this.board_nameLabel1 = new System.Windows.Forms.Label();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.boardSettingsTableAdapter = new KanbanBoard.DS.knbanBoard_dsTableAdapters.BoardSettingsTableAdapter();
            this.tableAdapterManager = new KanbanBoard.DS.knbanBoard_dsTableAdapters.TableAdapterManager();
            this.control_tag_label1 = new System.Windows.Forms.Label();
            this.workFieldSettingsTableAdapter = new KanbanBoard.DS.knbanBoard_dsTableAdapters.workFieldSettingsTableAdapter();
            workFields_countLabel = new System.Windows.Forms.Label();
            board_nameLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            board_fontLabel = new System.Windows.Forms.Label();
            fore_colorLabel = new System.Windows.Forms.Label();
            back_colorLabel = new System.Windows.Forms.Label();
            iDLabel2 = new System.Windows.Forms.Label();
            workField_nameLabel = new System.Windows.Forms.Label();
            board_indexLabel = new System.Windows.Forms.Label();
            workfield_ID_of_BoardLabel = new System.Windows.Forms.Label();
            fore_colorLabel2 = new System.Windows.Forms.Label();
            back_colorLabel2 = new System.Windows.Forms.Label();
            workField_fontLabel = new System.Windows.Forms.Label();
            this.color_groupBox1.SuspendLayout();
            this.text_groupBox2.SuspendLayout();
            this.onlyBoard_groupBox1.SuspendLayout();
            this.ds_groupBox1.SuspendLayout();
            this.workFieldgroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workFieldSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knbanBoard_ds)).BeginInit();
            this.dataForSingleBoard_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // workFields_countLabel
            // 
            workFields_countLabel.AutoSize = true;
            workFields_countLabel.Location = new System.Drawing.Point(17, 39);
            workFields_countLabel.Name = "workFields_countLabel";
            workFields_countLabel.Size = new System.Drawing.Size(113, 16);
            workFields_countLabel.TabIndex = 6;
            workFields_countLabel.Text = "work Fields count:";
            // 
            // board_nameLabel
            // 
            board_nameLabel.AutoSize = true;
            board_nameLabel.Location = new System.Drawing.Point(17, 62);
            board_nameLabel.Name = "board_nameLabel";
            board_nameLabel.Size = new System.Drawing.Size(83, 16);
            board_nameLabel.TabIndex = 8;
            board_nameLabel.Text = "board name:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(17, 85);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 10;
            iDLabel.Text = "ID:";
            // 
            // board_fontLabel
            // 
            board_fontLabel.AutoSize = true;
            board_fontLabel.Location = new System.Drawing.Point(17, 113);
            board_fontLabel.Name = "board_fontLabel";
            board_fontLabel.Size = new System.Drawing.Size(70, 16);
            board_fontLabel.TabIndex = 11;
            board_fontLabel.Text = "board font:";
            // 
            // fore_colorLabel
            // 
            fore_colorLabel.AutoSize = true;
            fore_colorLabel.Location = new System.Drawing.Point(21, 143);
            fore_colorLabel.Name = "fore_colorLabel";
            fore_colorLabel.Size = new System.Drawing.Size(66, 16);
            fore_colorLabel.TabIndex = 12;
            fore_colorLabel.Text = "fore color:";
            // 
            // back_colorLabel
            // 
            back_colorLabel.AutoSize = true;
            back_colorLabel.Location = new System.Drawing.Point(17, 171);
            back_colorLabel.Name = "back_colorLabel";
            back_colorLabel.Size = new System.Drawing.Size(73, 16);
            back_colorLabel.TabIndex = 13;
            back_colorLabel.Text = "back color:";
            // 
            // iDLabel2
            // 
            iDLabel2.AutoSize = true;
            iDLabel2.Location = new System.Drawing.Point(21, 27);
            iDLabel2.Name = "iDLabel2";
            iDLabel2.Size = new System.Drawing.Size(23, 16);
            iDLabel2.TabIndex = 0;
            iDLabel2.Text = "ID:";
            // 
            // workField_nameLabel
            // 
            workField_nameLabel.AutoSize = true;
            workField_nameLabel.Location = new System.Drawing.Point(17, 50);
            workField_nameLabel.Name = "workField_nameLabel";
            workField_nameLabel.Size = new System.Drawing.Size(108, 16);
            workField_nameLabel.TabIndex = 2;
            workField_nameLabel.Text = "work Field name:";
            // 
            // board_indexLabel
            // 
            board_indexLabel.AutoSize = true;
            board_indexLabel.Location = new System.Drawing.Point(17, 72);
            board_indexLabel.Name = "board_indexLabel";
            board_indexLabel.Size = new System.Drawing.Size(81, 16);
            board_indexLabel.TabIndex = 4;
            board_indexLabel.Text = "board index:";
            // 
            // workfield_ID_of_BoardLabel
            // 
            workfield_ID_of_BoardLabel.AutoSize = true;
            workfield_ID_of_BoardLabel.Location = new System.Drawing.Point(17, 95);
            workfield_ID_of_BoardLabel.Name = "workfield_ID_of_BoardLabel";
            workfield_ID_of_BoardLabel.Size = new System.Drawing.Size(133, 16);
            workfield_ID_of_BoardLabel.TabIndex = 6;
            workfield_ID_of_BoardLabel.Text = "workfield ID of Board:";
            // 
            // fore_colorLabel2
            // 
            fore_colorLabel2.AutoSize = true;
            fore_colorLabel2.Location = new System.Drawing.Point(17, 126);
            fore_colorLabel2.Name = "fore_colorLabel2";
            fore_colorLabel2.Size = new System.Drawing.Size(66, 16);
            fore_colorLabel2.TabIndex = 8;
            fore_colorLabel2.Text = "fore color:";
            // 
            // back_colorLabel2
            // 
            back_colorLabel2.AutoSize = true;
            back_colorLabel2.Location = new System.Drawing.Point(14, 142);
            back_colorLabel2.Name = "back_colorLabel2";
            back_colorLabel2.Size = new System.Drawing.Size(73, 16);
            back_colorLabel2.TabIndex = 10;
            back_colorLabel2.Text = "back color:";
            // 
            // workField_fontLabel
            // 
            workField_fontLabel.AutoSize = true;
            workField_fontLabel.Location = new System.Drawing.Point(14, 165);
            workField_fontLabel.Name = "workField_fontLabel";
            workField_fontLabel.Size = new System.Drawing.Size(95, 16);
            workField_fontLabel.TabIndex = 12;
            workField_fontLabel.Text = "work Field font:";
            // 
            // Text_textBox1
            // 
            this.Text_textBox1.Location = new System.Drawing.Point(12, 39);
            this.Text_textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.Text_textBox1.Name = "Text_textBox1";
            this.Text_textBox1.Size = new System.Drawing.Size(269, 22);
            this.Text_textBox1.TabIndex = 0;
            this.Text_textBox1.TextChanged += new System.EventHandler(this.Text_textBox1_TextChanged);
            // 
            // text_label1
            // 
            this.text_label1.AutoSize = true;
            this.text_label1.Location = new System.Drawing.Point(8, 20);
            this.text_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text_label1.Name = "text_label1";
            this.text_label1.Size = new System.Drawing.Size(33, 16);
            this.text_label1.TabIndex = 1;
            this.text_label1.Text = "Text";
            // 
            // color_groupBox1
            // 
            this.color_groupBox1.Controls.Add(this.foreColor_button1);
            this.color_groupBox1.Controls.Add(this.foreColor_textBox1);
            this.color_groupBox1.Controls.Add(this.foreColor_label1);
            this.color_groupBox1.Controls.Add(this.backColor_button1);
            this.color_groupBox1.Controls.Add(this.backColor_textBox1);
            this.color_groupBox1.Controls.Add(this.backColor_label1);
            this.color_groupBox1.Location = new System.Drawing.Point(12, 161);
            this.color_groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.color_groupBox1.Name = "color_groupBox1";
            this.color_groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.color_groupBox1.Size = new System.Drawing.Size(292, 133);
            this.color_groupBox1.TabIndex = 2;
            this.color_groupBox1.TabStop = false;
            this.color_groupBox1.Text = "Color";
            // 
            // foreColor_button1
            // 
            this.foreColor_button1.Location = new System.Drawing.Point(184, 87);
            this.foreColor_button1.Margin = new System.Windows.Forms.Padding(4);
            this.foreColor_button1.Name = "foreColor_button1";
            this.foreColor_button1.Size = new System.Drawing.Size(100, 28);
            this.foreColor_button1.TabIndex = 5;
            this.foreColor_button1.Text = "ForeColor";
            this.foreColor_button1.UseVisualStyleBackColor = true;
            this.foreColor_button1.Click += new System.EventHandler(this.foreColor_button1_Click);
            // 
            // foreColor_textBox1
            // 
            this.foreColor_textBox1.Location = new System.Drawing.Point(8, 90);
            this.foreColor_textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.foreColor_textBox1.Name = "foreColor_textBox1";
            this.foreColor_textBox1.ReadOnly = true;
            this.foreColor_textBox1.Size = new System.Drawing.Size(167, 22);
            this.foreColor_textBox1.TabIndex = 7;
            // 
            // foreColor_label1
            // 
            this.foreColor_label1.AutoSize = true;
            this.foreColor_label1.Location = new System.Drawing.Point(8, 70);
            this.foreColor_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foreColor_label1.Name = "foreColor_label1";
            this.foreColor_label1.Size = new System.Drawing.Size(67, 16);
            this.foreColor_label1.TabIndex = 6;
            this.foreColor_label1.Text = "ForeColor";
            // 
            // backColor_button1
            // 
            this.backColor_button1.Location = new System.Drawing.Point(184, 36);
            this.backColor_button1.Margin = new System.Windows.Forms.Padding(4);
            this.backColor_button1.Name = "backColor_button1";
            this.backColor_button1.Size = new System.Drawing.Size(100, 28);
            this.backColor_button1.TabIndex = 3;
            this.backColor_button1.Text = "BackColor";
            this.backColor_button1.UseVisualStyleBackColor = true;
            this.backColor_button1.Click += new System.EventHandler(this.backColor_button1_Click);
            // 
            // backColor_textBox1
            // 
            this.backColor_textBox1.Location = new System.Drawing.Point(8, 39);
            this.backColor_textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.backColor_textBox1.Name = "backColor_textBox1";
            this.backColor_textBox1.ReadOnly = true;
            this.backColor_textBox1.Size = new System.Drawing.Size(167, 22);
            this.backColor_textBox1.TabIndex = 4;
            // 
            // backColor_label1
            // 
            this.backColor_label1.AutoSize = true;
            this.backColor_label1.Location = new System.Drawing.Point(8, 20);
            this.backColor_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backColor_label1.Name = "backColor_label1";
            this.backColor_label1.Size = new System.Drawing.Size(70, 16);
            this.backColor_label1.TabIndex = 3;
            this.backColor_label1.Text = "BackColor";
            // 
            // text_groupBox2
            // 
            this.text_groupBox2.Controls.Add(this.font_button1);
            this.text_groupBox2.Controls.Add(this.font_label1);
            this.text_groupBox2.Controls.Add(this.font_textBox1);
            this.text_groupBox2.Controls.Add(this.text_label1);
            this.text_groupBox2.Controls.Add(this.Text_textBox1);
            this.text_groupBox2.Location = new System.Drawing.Point(16, 17);
            this.text_groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.text_groupBox2.Name = "text_groupBox2";
            this.text_groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.text_groupBox2.Size = new System.Drawing.Size(288, 133);
            this.text_groupBox2.TabIndex = 3;
            this.text_groupBox2.TabStop = false;
            this.text_groupBox2.Text = "Text";
            // 
            // font_button1
            // 
            this.font_button1.Location = new System.Drawing.Point(180, 87);
            this.font_button1.Margin = new System.Windows.Forms.Padding(4);
            this.font_button1.Name = "font_button1";
            this.font_button1.Size = new System.Drawing.Size(100, 28);
            this.font_button1.TabIndex = 4;
            this.font_button1.Text = "Font";
            this.font_button1.UseVisualStyleBackColor = true;
            this.font_button1.Click += new System.EventHandler(this.font_button1_Click);
            // 
            // font_label1
            // 
            this.font_label1.AutoSize = true;
            this.font_label1.Location = new System.Drawing.Point(8, 70);
            this.font_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.font_label1.Name = "font_label1";
            this.font_label1.Size = new System.Drawing.Size(33, 16);
            this.font_label1.TabIndex = 3;
            this.font_label1.Text = "Font";
            // 
            // font_textBox1
            // 
            this.font_textBox1.Location = new System.Drawing.Point(12, 90);
            this.font_textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.font_textBox1.Name = "font_textBox1";
            this.font_textBox1.ReadOnly = true;
            this.font_textBox1.Size = new System.Drawing.Size(159, 22);
            this.font_textBox1.TabIndex = 2;
            // 
            // save_button1
            // 
            this.save_button1.Location = new System.Drawing.Point(16, 323);
            this.save_button1.Margin = new System.Windows.Forms.Padding(4);
            this.save_button1.Name = "save_button1";
            this.save_button1.Size = new System.Drawing.Size(129, 46);
            this.save_button1.TabIndex = 4;
            this.save_button1.Text = "Save";
            this.save_button1.UseVisualStyleBackColor = true;
            this.save_button1.Click += new System.EventHandler(this.save_button1_Click);
            // 
            // cancel_button1
            // 
            this.cancel_button1.Location = new System.Drawing.Point(163, 323);
            this.cancel_button1.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_button1.Name = "cancel_button1";
            this.cancel_button1.Size = new System.Drawing.Size(141, 46);
            this.cancel_button1.TabIndex = 5;
            this.cancel_button1.Text = "Cancel";
            this.cancel_button1.UseVisualStyleBackColor = true;
            this.cancel_button1.Click += new System.EventHandler(this.cancel_button1_Click);
            // 
            // onlyBoard_groupBox1
            // 
            this.onlyBoard_groupBox1.Controls.Add(this.clear_button1);
            this.onlyBoard_groupBox1.Controls.Add(this.remove_Index_button1);
            this.onlyBoard_groupBox1.Controls.Add(this.index_comboBox1);
            this.onlyBoard_groupBox1.Controls.Add(this.workFieldCount_label1);
            this.onlyBoard_groupBox1.Location = new System.Drawing.Point(335, 17);
            this.onlyBoard_groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.onlyBoard_groupBox1.Name = "onlyBoard_groupBox1";
            this.onlyBoard_groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.onlyBoard_groupBox1.Size = new System.Drawing.Size(320, 208);
            this.onlyBoard_groupBox1.TabIndex = 6;
            this.onlyBoard_groupBox1.TabStop = false;
            this.onlyBoard_groupBox1.Text = "Only Board";
            // 
            // clear_button1
            // 
            this.clear_button1.Location = new System.Drawing.Point(171, 134);
            this.clear_button1.Margin = new System.Windows.Forms.Padding(4);
            this.clear_button1.Name = "clear_button1";
            this.clear_button1.Size = new System.Drawing.Size(129, 46);
            this.clear_button1.TabIndex = 4;
            this.clear_button1.Text = "CLEAR";
            this.clear_button1.UseVisualStyleBackColor = true;
            this.clear_button1.Click += new System.EventHandler(this.clear_button1_Click);
            // 
            // remove_Index_button1
            // 
            this.remove_Index_button1.Location = new System.Drawing.Point(33, 134);
            this.remove_Index_button1.Margin = new System.Windows.Forms.Padding(4);
            this.remove_Index_button1.Name = "remove_Index_button1";
            this.remove_Index_button1.Size = new System.Drawing.Size(129, 46);
            this.remove_Index_button1.TabIndex = 3;
            this.remove_Index_button1.Text = "Remove Index";
            this.remove_Index_button1.UseVisualStyleBackColor = true;
            this.remove_Index_button1.Click += new System.EventHandler(this.remove_Index_button1_Click);
            // 
            // index_comboBox1
            // 
            this.index_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.index_comboBox1.FormattingEnabled = true;
            this.index_comboBox1.Location = new System.Drawing.Point(33, 70);
            this.index_comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.index_comboBox1.Name = "index_comboBox1";
            this.index_comboBox1.Size = new System.Drawing.Size(265, 24);
            this.index_comboBox1.TabIndex = 2;
            // 
            // workFieldCount_label1
            // 
            this.workFieldCount_label1.AutoSize = true;
            this.workFieldCount_label1.Location = new System.Drawing.Point(29, 39);
            this.workFieldCount_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workFieldCount_label1.Name = "workFieldCount_label1";
            this.workFieldCount_label1.Size = new System.Drawing.Size(145, 16);
            this.workFieldCount_label1.TabIndex = 1;
            this.workFieldCount_label1.Text = "Select WorkField Index";
            // 
            // ds_groupBox1
            // 
            this.ds_groupBox1.Controls.Add(this.workFieldgroupBox1);
            this.ds_groupBox1.Controls.Add(this.dataForSingleBoard_groupBox1);
            this.ds_groupBox1.Location = new System.Drawing.Point(730, 17);
            this.ds_groupBox1.Name = "ds_groupBox1";
            this.ds_groupBox1.Size = new System.Drawing.Size(610, 482);
            this.ds_groupBox1.TabIndex = 7;
            this.ds_groupBox1.TabStop = false;
            this.ds_groupBox1.Text = "Data";
            // 
            // workFieldgroupBox1
            // 
            this.workFieldgroupBox1.Controls.Add(workField_fontLabel);
            this.workFieldgroupBox1.Controls.Add(this.workField_fontLabel1);
            this.workFieldgroupBox1.Controls.Add(back_colorLabel2);
            this.workFieldgroupBox1.Controls.Add(this.back_colorLabel3);
            this.workFieldgroupBox1.Controls.Add(fore_colorLabel2);
            this.workFieldgroupBox1.Controls.Add(this.fore_colorLabel3);
            this.workFieldgroupBox1.Controls.Add(workfield_ID_of_BoardLabel);
            this.workFieldgroupBox1.Controls.Add(this.workfield_ID_of_BoardLabel1);
            this.workFieldgroupBox1.Controls.Add(board_indexLabel);
            this.workFieldgroupBox1.Controls.Add(this.board_indexLabel1);
            this.workFieldgroupBox1.Controls.Add(workField_nameLabel);
            this.workFieldgroupBox1.Controls.Add(this.workField_nameLabel1);
            this.workFieldgroupBox1.Controls.Add(iDLabel2);
            this.workFieldgroupBox1.Controls.Add(this.iDLabel3);
            this.workFieldgroupBox1.Location = new System.Drawing.Point(30, 234);
            this.workFieldgroupBox1.Name = "workFieldgroupBox1";
            this.workFieldgroupBox1.Size = new System.Drawing.Size(321, 227);
            this.workFieldgroupBox1.TabIndex = 7;
            this.workFieldgroupBox1.TabStop = false;
            this.workFieldgroupBox1.Text = "WorkField";
            // 
            // workField_fontLabel1
            // 
            this.workField_fontLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "workField_font", true));
            this.workField_fontLabel1.Location = new System.Drawing.Point(115, 165);
            this.workField_fontLabel1.Name = "workField_fontLabel1";
            this.workField_fontLabel1.Size = new System.Drawing.Size(100, 23);
            this.workField_fontLabel1.TabIndex = 13;
            this.workField_fontLabel1.Text = "label1";
            // 
            // workFieldSettingsBindingSource
            // 
            this.workFieldSettingsBindingSource.DataMember = "workFieldSettings";
            this.workFieldSettingsBindingSource.DataSource = this.knbanBoard_ds;
            // 
            // knbanBoard_ds
            // 
            this.knbanBoard_ds.DataSetName = "knbanBoard_ds";
            this.knbanBoard_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // back_colorLabel3
            // 
            this.back_colorLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "back_color", true));
            this.back_colorLabel3.Location = new System.Drawing.Point(93, 142);
            this.back_colorLabel3.Name = "back_colorLabel3";
            this.back_colorLabel3.Size = new System.Drawing.Size(100, 23);
            this.back_colorLabel3.TabIndex = 11;
            this.back_colorLabel3.Text = "label1";
            // 
            // fore_colorLabel3
            // 
            this.fore_colorLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "fore_color", true));
            this.fore_colorLabel3.Location = new System.Drawing.Point(89, 126);
            this.fore_colorLabel3.Name = "fore_colorLabel3";
            this.fore_colorLabel3.Size = new System.Drawing.Size(100, 23);
            this.fore_colorLabel3.TabIndex = 9;
            this.fore_colorLabel3.Text = "label1";
            // 
            // workfield_ID_of_BoardLabel1
            // 
            this.workfield_ID_of_BoardLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "workfield_ID_of_Board", true));
            this.workfield_ID_of_BoardLabel1.Location = new System.Drawing.Point(156, 95);
            this.workfield_ID_of_BoardLabel1.Name = "workfield_ID_of_BoardLabel1";
            this.workfield_ID_of_BoardLabel1.Size = new System.Drawing.Size(100, 23);
            this.workfield_ID_of_BoardLabel1.TabIndex = 7;
            this.workfield_ID_of_BoardLabel1.Text = "label1";
            // 
            // board_indexLabel1
            // 
            this.board_indexLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "board_index", true));
            this.board_indexLabel1.Location = new System.Drawing.Point(104, 72);
            this.board_indexLabel1.Name = "board_indexLabel1";
            this.board_indexLabel1.Size = new System.Drawing.Size(100, 23);
            this.board_indexLabel1.TabIndex = 5;
            this.board_indexLabel1.Text = "label1";
            // 
            // workField_nameLabel1
            // 
            this.workField_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "workField_name", true));
            this.workField_nameLabel1.Location = new System.Drawing.Point(131, 50);
            this.workField_nameLabel1.Name = "workField_nameLabel1";
            this.workField_nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.workField_nameLabel1.TabIndex = 3;
            this.workField_nameLabel1.Text = "label1";
            // 
            // iDLabel3
            // 
            this.iDLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workFieldSettingsBindingSource, "ID", true));
            this.iDLabel3.Location = new System.Drawing.Point(50, 27);
            this.iDLabel3.Name = "iDLabel3";
            this.iDLabel3.Size = new System.Drawing.Size(100, 23);
            this.iDLabel3.TabIndex = 1;
            this.iDLabel3.Text = "label1";
            // 
            // dataForSingleBoard_groupBox1
            // 
            this.dataForSingleBoard_groupBox1.Controls.Add(back_colorLabel);
            this.dataForSingleBoard_groupBox1.Controls.Add(this.back_colorLabel1);
            this.dataForSingleBoard_groupBox1.Controls.Add(fore_colorLabel);
            this.dataForSingleBoard_groupBox1.Controls.Add(this.fore_colorLabel1);
            this.dataForSingleBoard_groupBox1.Controls.Add(board_fontLabel);
            this.dataForSingleBoard_groupBox1.Controls.Add(this.board_fontLabel1);
            this.dataForSingleBoard_groupBox1.Controls.Add(workFields_countLabel);
            this.dataForSingleBoard_groupBox1.Controls.Add(this.workFields_countLabel1);
            this.dataForSingleBoard_groupBox1.Controls.Add(board_nameLabel);
            this.dataForSingleBoard_groupBox1.Controls.Add(this.board_nameLabel1);
            this.dataForSingleBoard_groupBox1.Controls.Add(iDLabel);
            this.dataForSingleBoard_groupBox1.Controls.Add(this.iDLabel1);
            this.dataForSingleBoard_groupBox1.Location = new System.Drawing.Point(30, 21);
            this.dataForSingleBoard_groupBox1.Name = "dataForSingleBoard_groupBox1";
            this.dataForSingleBoard_groupBox1.Size = new System.Drawing.Size(257, 194);
            this.dataForSingleBoard_groupBox1.TabIndex = 6;
            this.dataForSingleBoard_groupBox1.TabStop = false;
            this.dataForSingleBoard_groupBox1.Text = "KanbanBoard";
            // 
            // back_colorLabel1
            // 
            this.back_colorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "back_color", true));
            this.back_colorLabel1.Location = new System.Drawing.Point(96, 171);
            this.back_colorLabel1.Name = "back_colorLabel1";
            this.back_colorLabel1.Size = new System.Drawing.Size(100, 23);
            this.back_colorLabel1.TabIndex = 14;
            this.back_colorLabel1.Text = "label1";
            // 
            // boardSettingsBindingSource
            // 
            this.boardSettingsBindingSource.DataMember = "BoardSettings";
            this.boardSettingsBindingSource.DataSource = this.knbanBoard_ds;
            // 
            // fore_colorLabel1
            // 
            this.fore_colorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "fore_color", true));
            this.fore_colorLabel1.Location = new System.Drawing.Point(93, 143);
            this.fore_colorLabel1.Name = "fore_colorLabel1";
            this.fore_colorLabel1.Size = new System.Drawing.Size(100, 23);
            this.fore_colorLabel1.TabIndex = 13;
            this.fore_colorLabel1.Text = "label1";
            // 
            // board_fontLabel1
            // 
            this.board_fontLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "board_font", true));
            this.board_fontLabel1.Location = new System.Drawing.Point(93, 113);
            this.board_fontLabel1.Name = "board_fontLabel1";
            this.board_fontLabel1.Size = new System.Drawing.Size(100, 23);
            this.board_fontLabel1.TabIndex = 12;
            this.board_fontLabel1.Text = "label1";
            // 
            // workFields_countLabel1
            // 
            this.workFields_countLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "workFields_count", true));
            this.workFields_countLabel1.Location = new System.Drawing.Point(136, 39);
            this.workFields_countLabel1.Name = "workFields_countLabel1";
            this.workFields_countLabel1.Size = new System.Drawing.Size(100, 23);
            this.workFields_countLabel1.TabIndex = 7;
            this.workFields_countLabel1.Text = "label1";
            // 
            // board_nameLabel1
            // 
            this.board_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "board_name", true));
            this.board_nameLabel1.Location = new System.Drawing.Point(136, 62);
            this.board_nameLabel1.Name = "board_nameLabel1";
            this.board_nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.board_nameLabel1.TabIndex = 9;
            this.board_nameLabel1.Text = "label1";
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardSettingsBindingSource, "ID", true));
            this.iDLabel1.Location = new System.Drawing.Point(136, 85);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDLabel1.TabIndex = 11;
            this.iDLabel1.Text = "label1";
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
            // control_tag_label1
            // 
            this.control_tag_label1.AutoSize = true;
            this.control_tag_label1.Location = new System.Drawing.Point(1151, 301);
            this.control_tag_label1.Name = "control_tag_label1";
            this.control_tag_label1.Size = new System.Drawing.Size(0, 16);
            this.control_tag_label1.TabIndex = 8;
            // 
            // workFieldSettingsTableAdapter
            // 
            this.workFieldSettingsTableAdapter.ClearBeforeFill = true;
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 379);
            this.Controls.Add(this.control_tag_label1);
            this.Controls.Add(this.ds_groupBox1);
            this.Controls.Add(this.onlyBoard_groupBox1);
            this.Controls.Add(this.cancel_button1);
            this.Controls.Add(this.save_button1);
            this.Controls.Add(this.text_groupBox2);
            this.Controls.Add(this.color_groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "s";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigureControl";
            this.Load += new System.EventHandler(this.ConfigureControl_Load);
            this.color_groupBox1.ResumeLayout(false);
            this.color_groupBox1.PerformLayout();
            this.text_groupBox2.ResumeLayout(false);
            this.text_groupBox2.PerformLayout();
            this.onlyBoard_groupBox1.ResumeLayout(false);
            this.onlyBoard_groupBox1.PerformLayout();
            this.ds_groupBox1.ResumeLayout(false);
            this.workFieldgroupBox1.ResumeLayout(false);
            this.workFieldgroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workFieldSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knbanBoard_ds)).EndInit();
            this.dataForSingleBoard_groupBox1.ResumeLayout(false);
            this.dataForSingleBoard_groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label text_label1;
        private System.Windows.Forms.GroupBox color_groupBox1;
        private System.Windows.Forms.Label backColor_label1;
        private System.Windows.Forms.Button backColor_button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button foreColor_button1;
        private System.Windows.Forms.Label foreColor_label1;
        private System.Windows.Forms.GroupBox text_groupBox2;
        private System.Windows.Forms.Label font_label1;
        private System.Windows.Forms.Button font_button1;
        private System.Windows.Forms.Button save_button1;
        private System.Windows.Forms.Button cancel_button1;
        public System.Windows.Forms.TextBox Text_textBox1;
        public System.Windows.Forms.TextBox backColor_textBox1;
        public System.Windows.Forms.TextBox foreColor_textBox1;
        public System.Windows.Forms.TextBox font_textBox1;
        public System.Windows.Forms.GroupBox onlyBoard_groupBox1;
        private System.Windows.Forms.Label workFieldCount_label1;
        public System.Windows.Forms.ComboBox index_comboBox1;
        private System.Windows.Forms.Button remove_Index_button1;
        private System.Windows.Forms.Button clear_button1;
        public System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox ds_groupBox1;
        private DS.knbanBoard_ds knbanBoard_ds;
        private System.Windows.Forms.BindingSource boardSettingsBindingSource;
        private DS.knbanBoard_dsTableAdapters.BoardSettingsTableAdapter boardSettingsTableAdapter;
        private DS.knbanBoard_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox dataForSingleBoard_groupBox1;
        private System.Windows.Forms.Label workFields_countLabel1;
        private System.Windows.Forms.Label board_nameLabel1;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.GroupBox workFieldgroupBox1;
        public System.Windows.Forms.Label control_tag_label1;
        private System.Windows.Forms.BindingSource workFieldSettingsBindingSource;
        private DS.knbanBoard_dsTableAdapters.workFieldSettingsTableAdapter workFieldSettingsTableAdapter;
        private System.Windows.Forms.Label board_fontLabel1;
        private System.Windows.Forms.Label fore_colorLabel1;
        private System.Windows.Forms.Label back_colorLabel1;
        private System.Windows.Forms.Label workField_fontLabel1;
        private System.Windows.Forms.Label back_colorLabel3;
        private System.Windows.Forms.Label fore_colorLabel3;
        private System.Windows.Forms.Label workfield_ID_of_BoardLabel1;
        private System.Windows.Forms.Label board_indexLabel1;
        private System.Windows.Forms.Label workField_nameLabel1;
        private System.Windows.Forms.Label iDLabel3;
    }
}