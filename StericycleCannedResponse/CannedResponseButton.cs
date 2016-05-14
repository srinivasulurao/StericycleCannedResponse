using MyUtilities;
using RightNow.AddIns.AddInViews;
using System;
using System.AddIn;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace StericycleCannedResponse
{
    public partial class CannedResponseButton : UserControl
    {
        private IGlobalContext globalContext;
        private IRecordContext recordContext;
        private bool inDesignMode;
        private IChatRecordContext chatRecordContext;

        public CannedResponseButton(bool _inDesignMode, IRecordContext _recordContext, IGlobalContext _globalContext,IChatRecordContext _chatRecordContext)
        {
            recordContext = _recordContext;
            globalContext = _globalContext;
            chatRecordContext = _chatRecordContext;
            inDesignMode = _inDesignMode;

            InitializeComponent();
        }

        private void canned_response_button_Click(object sender, EventArgs e)
        {
            CannedResponseSelector crs = new CannedResponseSelector(inDesignMode,recordContext,globalContext,chatRecordContext);
            crs.Show();
        }
    }
}
