using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CR.Utilities
{
    public class UserControlBase : UserControl
    {

        public virtual void OnClickSave(object sender, EventArgs e) => throw new NotImplementedException();
        public virtual void OnClickCancel(object sender, EventArgs e) => throw new NotImplementedException();
        public virtual void OnClickReset() => throw new NotImplementedException();
    }
}
