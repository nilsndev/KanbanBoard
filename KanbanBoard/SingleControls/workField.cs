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
namespace KanbanBoard{
    public partial class workField : UserControl{
        Settings settings =new Settings();
        public workField(){
            InitializeComponent();
        }
        private void edit_pictureBox1_Click(object sender, EventArgs e){
            ConfigureControl configCon = new ConfigureControl();
            configCon.Text = "Edit WorkField"; 
            configCon.control_tag_label1.Text = this.wf_id_label1.Text;
            Settings.newValues(this, workField_textBox1, configCon);
            configCon.ShowDialog();
            if (configCon.DialogResult == DialogResult.OK){
                SaveReloadConfiguration(configCon);
            }
            configCon.Close();
        }
        void SaveReloadConfiguration(ConfigureControl configCon){
            Settings.saveConfiguration(settings, configCon);
            Settings.LoadConfiguration(this,workField_textBox1,configCon,settings);
            workField_textBox1.BackColor = settings.BackColor;
            workField_textBox1.Text = settings.Text;
            workFieldSettingsBindingSource.EndEdit();
            workFieldSettingsTableAdapter.Update(knbanBoard_ds.workFieldSettings);
            
        }
        private void workField_Load(object sender, EventArgs e){
            
        }
        public void fill_workfield(){
            this.workFieldSettingsTableAdapter.FillBy_ID(knbanBoard_ds.workFieldSettings, Convert.ToInt64(this.wf_id_label1.Text));
        }
    }
}
