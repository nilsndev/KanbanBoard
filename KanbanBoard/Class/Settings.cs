using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using KanbanBoard.Forms;

namespace KanbanBoard{
    public class Settings{
        public Color ForeColor{get;set;}
        public Color BackColor{get;set;}
        public Font Font{get;set;}
        public string Text { get;set;}
        public int Width { get; set; }
        public int Height { get; set; }
        public static void newValues(UserControl userCon,Label tb,ConfigureControl configCon){
            configCon.Text_textBox1.Text = tb.Text;
            configCon.backColor_textBox1.BackColor = userCon.BackColor;
            configCon.foreColor_textBox1.BackColor = tb.ForeColor;
            configCon.font_textBox1.Font = tb.Font;
            configCon.font_textBox1.Text = tb.Font.ToString();
            configCon.fontDialog1.Font = new Font(tb.Font.FontFamily, tb.Font.Size,tb.Font.Style);
        }
        public static void saveConfiguration(Settings settings,ConfigureControl configCon){
            settings.BackColor = configCon.backColor_textBox1.BackColor;
            settings.ForeColor = configCon.foreColor_textBox1.BackColor;
            settings.Font = configCon.font_textBox1.Font;
            settings.Text = configCon.Text_textBox1.Text;
        }
        public static void LoadConfiguration(UserControl userCon,Label tb,ConfigureControl configCon,Settings settings){
            tb.Text = settings.Text;
            userCon.BackColor = settings.BackColor;
            tb.BackColor = settings.BackColor;
            tb.ForeColor = settings.ForeColor;
            tb.Font = settings.Font;
        }
    }
}
