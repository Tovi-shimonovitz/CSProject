using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
            ApplyCustomDesign();
        }
        private void ApplyCustomDesign()
        {
            // עיצוב כללי של הטופס
            this.BackColor = Color.FromArgb(240, 240, 240); // רקע אפור בהיר ונעים
            this.Text = "מערכת ניהול";
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // עיצוב כפתור מנהל (button1)
            StyleButton(button1, Color.FromArgb(41, 128, 185), "כניסת מנהל");

            // עיצוב כפתור קופאי (button2)
            StyleButton(button2, Color.FromArgb(39, 174, 96), "כניסת קופאי");
        }
        private void StyleButton(Button btn, Color backColor, string text)
        {
            btn.Text = text;
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat; // ביטול המראה התלת-ממדי הישן
            btn.FlatAppearance.BorderSize = 0; // הסרת המסגרת
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.Cursor = Cursors.Hand; // שינוי הסמן ליד במעבר על הכפתור
            btn.Size = new Size(180, 50); // גודל אחיד ומרווח
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Manager nextForm = new Manager();

            nextForm.Show();

            
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            back nextForm = new back();

            nextForm.Show();


            this.Hide();

        }

     
    }
}
