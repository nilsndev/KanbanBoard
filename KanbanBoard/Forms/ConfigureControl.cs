using KanbanBoard.DS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KanbanBoard.Forms{
    public partial class ConfigureControl : Form{
        bool removeIndexFromBoard = false;
        bool _clearing = false;
        public ConfigureControl(){
            InitializeComponent();
        }
        private void cancel_button1_Click(object sender, EventArgs e){
            this.DialogResult = DialogResult.Cancel;
        }
        private void backColor_button1_Click(object sender, EventArgs e){
            this.colorDialog1.Color = this.backColor_textBox1.BackColor;
            this.colorDialog1.ShowDialog();
            this.backColor_textBox1.BackColor = colorDialog1.Color;
            this.colorDialog1.Dispose();
        }
        private void foreColor_button1_Click(object sender, EventArgs e){
            this.colorDialog1.Color = this.backColor_textBox1.ForeColor;
            this.colorDialog1.ShowDialog();
            this.foreColor_textBox1.BackColor = colorDialog1.Color;
            this.colorDialog1.Dispose();
        }
        private void font_button1_Click(object sender, EventArgs e){
            this.fontDialog1.ShowDialog();
            this.font_textBox1.Font = fontDialog1.Font;
            this.font_textBox1.Text = fontDialog1.Font.ToString();
            this.fontDialog1.Dispose();
        }
        private void save_button1_Click(object sender, EventArgs e){
            if(this.Text == "Edit Board"){
                saveBoardData();
            }
            else if(this.Text == "Edit WorkField"){
                saveWorkFieldData();
            }
           
            this.DialogResult = DialogResult.OK;
        }
        void saveBoardData(){
            FontConverter fc = new FontConverter();
            ColorConverter cc = new ColorConverter();
            this.workFields_countLabel1.Text = this.index_comboBox1.Items.Count.ToString();
            this.board_nameLabel1.Text = this.Text_textBox1.Text;
            this.workFields_countLabel1.Text = this.index_comboBox1.Items.Count.ToString();
            this.fore_colorLabel1.Text = cc.ConvertToString(foreColor_textBox1.BackColor);
            this.back_colorLabel1.Text = cc.ConvertToString(backColor_textBox1.BackColor);
            this.board_fontLabel1.Text = fc.ConvertToString(font_textBox1.Font);
            if (_clearing){

            }
            this.boardSettingsBindingSource.EndEdit();
            this.boardSettingsTableAdapter.Update(knbanBoard_ds.BoardSettings);
        }
        void saveWorkFieldData(){
            FontConverter fc = new FontConverter();
            ColorConverter cc = new ColorConverter();
            this.workField_nameLabel1.Text = this.Text_textBox1.Text;
            this.workField_fontLabel1.Text = fc.ConvertToString(font_textBox1.Font);
            this.fore_colorLabel3.Text = cc.ConvertToString(foreColor_textBox1.BackColor);
            this.back_colorLabel3.Text = cc.ConvertToString(backColor_textBox1.BackColor);
            this.workFieldSettingsBindingSource.EndEdit();
            this.workFieldSettingsTableAdapter.Update(knbanBoard_ds.workFieldSettings);
        }
        private void ConfigureControl_Load(object sender, EventArgs e){
            long tag = Convert.ToInt64(this.control_tag_label1.Text);
            if (this.Text == "Edit Board"){
                this.boardSettingsTableAdapter.FillBy_ID(knbanBoard_ds.BoardSettings, tag);
            }
            else if(this.Text == "Edit WorkField"){
                this.workFieldSettingsTableAdapter.FillBy_ID(knbanBoard_ds.workFieldSettings,tag);
            }
        }
        private void width_textBox1_TextChanged(object sender, EventArgs e){
        }
        private void remove_Index_button1_Click(object sender, EventArgs e){
            this.onlyBoard_groupBox1.Enabled = false;
            removeIndexFromBoard = true;
        }
        public bool clearing(){
            return _clearing;
        }
        public int checkIndexRemoved(){
            if (removeIndexFromBoard){
                return this.index_comboBox1.SelectedIndex;
            }
            return -1;
        }
        private void clear_button1_Click(object sender, EventArgs e){
            this.index_comboBox1.Items.Clear();
            this.onlyBoard_groupBox1.Enabled = false;
            _clearing = true;
        }

        private void Text_textBox1_TextChanged(object sender, EventArgs e){
            //if(this.Text_textBox1.Text == "")
        }
    }
}
