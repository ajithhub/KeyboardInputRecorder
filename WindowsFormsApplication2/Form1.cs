using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2 {
    public partial class Form1 : Form {
        public List<KeyRecord> allrecords = new List<KeyRecord>();
        Dictionary<Keys, KeyRecord> lastDowns = new Dictionary<Keys, KeyRecord>();

        public Form1() {
            InitializeComponent();
        }

        private void textEntry_KeyDown(object sender, System.Windows.Forms.KeyEventArgs ke) {

            DateTime downTime = DateTime.Now;
            System.Console.WriteLine("{1} Down at {0}", downTime.Millisecond, ke.KeyCode);
            if (!lastDowns.ContainsKey(ke.KeyCode)) {
                KeyRecord k = new KeyRecord(ke.KeyCode);
                k.down = downTime;
                lastDowns.Add(k.key, k);
            } else {
                System.Console.WriteLine("Duplicate Down");
            }
        }

        private void textEntry_KeyUp(object sender, System.Windows.Forms.KeyEventArgs ke) {
            DateTime upTime = DateTime.Now;
            System.Console.WriteLine("{1} Up   at {0}", upTime.Millisecond, ke.KeyCode);
            if (lastDowns.ContainsKey(ke.KeyCode)) {
                KeyRecord k = lastDowns[ke.KeyCode];
                k.up = upTime;
                lastDowns.Remove(k.key);
                System.Console.WriteLine(k.toAutoIT());
            }

        }


    }
    public class KeyRecord {
        public DateTime down;
        public DateTime up;
        private int duration;
        int delay;
        public Keys key;

        public KeyRecord(Keys key) {
            this.key = key;
 
        }
        public String toAutoIT() {

            StringBuilder r = new StringBuilder();
            r.AppendFormat("Opt(\"SendKeyDelay\", {0})\n", this.Duration);
            r.AppendFormat("Send(\"{{ASC {0}}}\")\n", this.key);

            return r.ToString();

        }

        public int Duration {
            get{
                TimeSpan ts = up - down;
                duration =  Convert.ToInt32(ts.TotalMilliseconds);
                return duration;
            }
            set {
                duration = value;
            }
        }
    }

  
}
