using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph_Implementation {
    class CButton : System.Windows.Forms.Button {
        public CButton() {
            SetStyle(System.Windows.Forms.ControlStyles.Selectable, false);
        }
    }
}
