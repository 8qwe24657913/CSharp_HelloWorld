using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm {
    class Hello {
        public static void Show(ListView listView, string[] pargs) {
            listView.Items.Clear();
            for (int i = 1; i < pargs.Length; i++) {
                var lv = new ListViewItem();
                lv.Text = i.ToString();
                lv.SubItems.Add(pargs[i]);
                listView.Items.Add(lv);
            }
        }
    }
}
