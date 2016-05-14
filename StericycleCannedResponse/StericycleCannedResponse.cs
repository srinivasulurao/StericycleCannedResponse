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
    public class StericycleCannedResponseClass : Panel, IWorkspaceComponent2
    {
        private IRecordContext _recordContext;
        private IGlobalContext _globalContext;
        private RightNowCWS _rnSrv;
        private bool _inDesignMode;
        private IChatRecordContext _chatRecordContext;

        public StericycleCannedResponseClass(bool inDesignMode, IRecordContext RecordContext, IGlobalContext GlobalContext, IChatRecordContext ChatRecordContext)
        {
            _recordContext = RecordContext;
            _globalContext = GlobalContext;
            _inDesignMode = inDesignMode;
            _chatRecordContext = ChatRecordContext;
            if (_recordContext != null)
            {
                //_recordContext.DataLoaded += LoadCannedResponseList;
                //_recordContext.Saving += SaveColorData;
            }
        }

        

        public bool ReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Control GetControl()
        {
            _rnSrv = new RightNowCWS(_globalContext);
            CannedResponseButton crb = new CannedResponseButton(_inDesignMode,_recordContext, _globalContext,_chatRecordContext);
            return crb;


        }

        public void RuleActionInvoked(string actionName)
        {
            throw new NotImplementedException();
        }

        public string RuleConditionInvoked(string conditionName)
        {
            throw new NotImplementedException();
        }
    }


    [AddIn("StericycleCannedResponse AddIn", Version = "1.0.0.0")]
    public class StericycleCannedResponseFactory : IWorkspaceComponentFactory2
    {
        private IGlobalContext _globalContext;
        private IChatRecordContext _chatRecordContext;

        public Image Image16
        {
            get
            {
                return Properties.Resources.plugin_icon;
            }
        }

        public string Text
        {
            get
            {
                return "Stericycle Canned Response Addin";
            }
        }

        public string Tooltip
        {
            get
            {
                return "Stericycle Canned Response Addin for showing shortcut message for chat workspace!";
            }
        }

        public IWorkspaceComponent2 CreateControl(bool inDesignMode, IRecordContext context)
        {
            return new StericycleCannedResponseClass(inDesignMode, context, _globalContext,_chatRecordContext);
        }

        public bool Initialize(IGlobalContext context)
        {
            _globalContext = context;
            return true;
        }
    }
}
