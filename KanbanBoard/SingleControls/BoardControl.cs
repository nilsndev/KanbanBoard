using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KanbanBoard.Forms;
using KanbanBoard.DS;
using KanbanBoard.DS.knbanBoard_dsTableAdapters;

namespace KanbanBoard{
    public partial class BoardControl : UserControl{
        int workCount = 0;
        public List<workField> workFields = new List<workField>();
        Settings settings = new Settings();
        int margin = 20;
        public BoardControl(){
            InitializeComponent();
        }
        private void addCard_label1_Click(object sender, EventArgs e){
            workField wf = new workField();
            wf.Tag = workFields.Count.ToString();
            wf.Width = this.Width - 50;
            wf.Height = this.Height /8;
            if (workFields.Count== 0){
                wf.Location = new Point(10, 10);
            }
            else{
                wf.Location=new Point(10,
                workFields[workCount-1].Location.Y+wf.Height+margin);
            }
            workFields.Add(wf);
            workCount++;
            this.boardSettingsTableAdapter.FillBy_ID(knbanBoard_ds.BoardSettings,Convert.ToInt64(this.Tag));
            this.workFields_countLabel1.Text =workCount.ToString();
            this.boardSettingsBindingSource.EndEdit();
            this.boardSettingsTableAdapter.Update(knbanBoard_ds.BoardSettings);
            saveAddedWorkFieldInData();
            workFields[workCount -1].wf_id_label1.Text = iDLabel3.Text;
            this.FieldAcces_panel1.Controls.Add(workFields[workCount-1]);
        }
        void saveAddedWorkFieldInData(){
            this.workFieldSettingsBindingSource.AddNew();
            this.workField_nameLabel1.Text = "Text";
            this.board_indexLabel1.Text = this.Tag.ToString();
            this.workfield_ID_of_BoardLabel1.Text = workCount.ToString();
            this.workFieldSettingsBindingSource.EndEdit();
            this.workFieldSettingsTableAdapter.Update(this.knbanBoard_ds.workFieldSettings);
        }
        //edit somoething here
        void reAddWorkList(){
            for (int i = 0; i < workCount; i++){
                workField wf = new workField();
                
                wf.Tag = workFields.Count.ToString();
                wf.Width = this.Width - 50;
                wf.Height = this.Height / 8;
                if (workFields.Count == 0){
                    wf.Location = new Point(10, 10);
                }
                else{
                    wf.Location = new Point(10,
                    workFields[i - 1].Location.Y + wf.Height + margin);
                }
                this.workFieldSettingsTableAdapter.FillBy_boardIndex_andWFINDEX(knbanBoard_ds.workFieldSettings, Convert.ToInt64(this.Tag), i + 1);
                wf.workField_textBox1.Text = this.workField_nameLabel1.Text;
                loadWorkFieldColor(wf);
                wf.wf_id_label1.Text = this.iDLabel3.Text;
                wf.fill_workfield();
                workFields.Add(wf);
                this.FieldAcces_panel1.Controls.Add(workFields[i]);
            }
        }
        //=============================================
        void loadWorkFieldColor(workField wf){
            FontConverter fc = new FontConverter();
            ColorConverter cc = new ColorConverter();
            if(back_colorLabel1.Text != ""){
                wf.BackColor = (Color)cc.ConvertFromString(back_colorLabel1.Text);
            }
            if(fore_colorLabel1.Text != ""){
                wf.ForeColor = (Color)cc.ConvertFromString(fore_colorLabel1.Text);
            }
            if(workField_fontLabel1.Text != ""){
                wf.Font = (Font)fc.ConvertFromString(workField_fontLabel1.Text);
            }
        }
        private void editBoard_pictureBox1_Click(object sender, EventArgs e){
            ConfigureControl configCon = new ConfigureControl();
            configCon.Text = "Edit Board";
            loadConfigControlValues(configCon);
            configCon.control_tag_label1.Text = this.Tag.ToString();
            configCon.ShowDialog();
            if (configCon.DialogResult == DialogResult.OK){
                saveConfiguration(configCon);
                reLoadConfiguration(configCon);
                this.addCard_label1.Font = boardName_textBox1.Font;
                this.addCard_label1.ForeColor = boardName_textBox1.ForeColor;
            }
            if (configCon.DialogResult == DialogResult.Cancel){
                configCon.Close();
            }
            this.boardSettingsBindingSource.EndEdit();
            this.boardSettingsTableAdapter.Update(knbanBoard_ds.BoardSettings);
            
        }
        void fillComboBox(ConfigureControl configCon){
            for (int i = 0; i < workFields.Count; i++){
                configCon.index_comboBox1.Items.Add(i);
            }
            configCon.index_comboBox1.SelectedIndex = 0;
        }
        void loadConfigControlValues(ConfigureControl configCon){
            if(workFields.Count != 0){
                configCon.Width = 540;
                fillComboBox(configCon);
            }
            Settings.newValues(this,boardName_textBox1,configCon);
        }
        void saveConfiguration(ConfigureControl configCon){
            Settings.saveConfiguration(settings, configCon);
            if (configCon.clearing()){
                workFields.Clear();
                this.workFieldSettingsTableAdapter.FillBy_Only_Board_Index(knbanBoard_ds.workFieldSettings,Convert.ToInt64(this.Tag));
                this.workFieldSettingsTableAdapter.ClearFullBoard(Convert.ToInt64(this.Tag));
                this.FieldAcces_panel1.Controls.Clear();
                this.workFieldSettingsBindingSource.EndEdit();
                this.workFieldSettingsTableAdapter.Update(knbanBoard_ds.workFieldSettings);
                workCount = 0;
                return;
            }
            int index = configCon.checkIndexRemoved();
            if (index != -1){
                this.workFieldSettingsTableAdapter.FillBy_boardIndex_andWFINDEX(knbanBoard_ds.workFieldSettings, Convert.ToInt64(this.Tag), index + 1);
                workFields.RemoveAt(index);
                this.workFieldSettingsTableAdapter.DeleteSingleWorkField(Convert.ToInt64(this.Tag), index + 1);
                reloadIndexOfBoard(index);
                this.workFieldSettingsBindingSource.EndEdit();
                this.workFieldSettingsTableAdapter.Update(knbanBoard_ds.workFieldSettings);
                workCount = 0; 
                reloadWorkList();
            }
        }
        void reloadIndexOfBoard(int index){
            for(int i = index + 1; i <workCount; i++){
                this.workFieldSettingsTableAdapter.FillBy_boardIndex_andWFINDEX(knbanBoard_ds.workFieldSettings,Convert.ToInt64(this.Tag), i+ 1);
                this.workfield_ID_of_BoardLabel1.Text = (i).ToString();
                this.workFieldSettingsBindingSource.EndEdit();
                this.workFieldSettingsTableAdapter.Update(knbanBoard_ds.workFieldSettings);
            }
        }
        void reloadWorkList(){
            this.FieldAcces_panel1.Controls.Clear();
            for (int i = 0; i < workFields.Count; i++){
                if(i == 0){
                    workFields[i].Location = new Point(10, 10);
                }
                else if (workFields[i] == null){
                }
                else{
                    workFields[i].Location = new Point(10,
                    workFields[workCount - 1].Location.Y + workFields[i].Height + margin);
                }
                this.FieldAcces_panel1.Controls.Add(workFields[i]);
                workCount++;
            }
        }
        void reLoadConfiguration(ConfigureControl configCon){
            Settings.LoadConfiguration(this,boardName_textBox1,configCon,settings);
        }
        private void FieldAcces_panel1_Paint(object sender, PaintEventArgs e){
        }

        private void boardName_textBox1_TextChanged(object sender, EventArgs e){
        }
        private void top_panel1_Paint(object sender, PaintEventArgs e){
        }
        private void BoardControl_Load(object sender, EventArgs e){
            this.boardSettingsTableAdapter.FillBy_ID(knbanBoard_ds.BoardSettings, Convert.ToInt64(this.Tag));
            this.workFieldSettingsTableAdapter.Fill(knbanBoard_ds.workFieldSettings);
            workCount = Convert.ToInt32(this.workFields_countLabel1.Text);
            reAddWorkList();
            this.FieldAcces_panel1.Dock = DockStyle.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
