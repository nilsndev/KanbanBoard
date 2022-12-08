using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KanbanBoard{
    public partial class Form1 : Form{
        public List<BoardControl> boardList = new List<BoardControl>();
        public Form1(){
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e){
            this.mdiBoard_panel1.Dock = DockStyle.Fill;
            // TODO: Diese Codezeile lädt Daten in die Tabelle "knbanBoard_ds.BoardSettings". Sie können sie bei Bedarf verschieben oder entfernen.
            this.boardSettingsTableAdapter.Fill(this.knbanBoard_ds.BoardSettings);
            addAutoBoards();
        }
        void addAutoBoards(){
            int x = 80;
            for (int i = 0; i < 3; i++){
                this.boardSettingsTableAdapter.FillBy_ID(knbanBoard_ds.BoardSettings, i + 1);
                BoardControl boardControl = new BoardControl();
                boardControl.Size = new Size(this.Width / 6, this.Height / 2);
                boardControl.boardName_textBox1.Text = this.board_nameLabel1.Text;
                loadBoardColor(boardControl);
                boardControl.Tag = i + 1;
                boardControl.Location = new Point(x, 40);
                x += boardControl.Width+ 80;
                boardList.Add(boardControl);
                this.mdiBoard_panel1.Controls.Add(boardList[i]);
            }
        }
        void loadBoardColor(BoardControl boardControl){
            ColorConverter cc = new ColorConverter();
            FontConverter fc = new FontConverter();
            if (back_colorLabel1.Text != ""){
                boardControl.BackColor = (Color)cc.ConvertFromString(back_colorLabel1.Text);
            }
            if(fore_colorLabel1.Text != ""){
                boardControl.boardName_textBox1.ForeColor = (Color)cc.ConvertFromString(fore_colorLabel1.Text);
                boardControl.addCard_label1.ForeColor = (Color)cc.ConvertFromString(fore_colorLabel1.Text);
            }
            if(board_fontLabel1.Text != ""){
                boardControl.boardName_textBox1.Font = (Font)fc.ConvertFromString(board_fontLabel1.Text);
                boardControl.addCard_label1.Font = (Font)fc.ConvertFromString(board_fontLabel1.Text);
            }
        }
        private void boardControl1_Load(object sender, EventArgs e){
        }
        private void exit_button1_Click(object sender, EventArgs e){
            Application.Exit();
        }
        private void mdiBoard_panel1_Paint(object sender, PaintEventArgs e){
        }
        private void minimize_button2_Click(object sender, EventArgs e){
            this.WindowState = FormWindowState.Minimized;
        }
        private void header_panel1_Paint(object sender, PaintEventArgs e){
        }
    }
}
