using System;
using System.Data;
using MyUtilities;
using MyUtilities.CWS_14_8;
using System.Windows.Forms;
using RightNow.AddIns.AddInViews;
using RightNow.AddIns.Common;
using System.Diagnostics;
using System.Collections.Generic;

namespace StericycleCannedResponse
{
   
    public partial class CannedResponseSelector : Form
    {
        private RightNowCWS _rnSrv;
        private IRecordContext _recordContext;
        private IGlobalContext _globalContext;
        private bool _inDesignMode;
        public CWS cwsconnection;
        public IChatRecordContext _chatRecordContext;


        

        public CannedResponseSelector(bool _inDesignMode, IRecordContext _recordContext, IGlobalContext _globalContext, IChatRecordContext _chatRecordContext)
        {
            InitializeComponent();
            this._recordContext = _recordContext;
            this._globalContext = _globalContext;
            this._inDesignMode = _inDesignMode;
            _rnSrv = new RightNowCWS(_globalContext);
            cwsconnection = new CWS(_globalContext);           
                    
        }

        private void CannedResponseSelector_Load(object sender, EventArgs e)
        {
            // Load the instruction text.               
            instruction_text.Text = "Click a standard text entry to see its preview. To add the text to the current thread select and item & press OK.\n You may also double-click items to add multiple entries without closing this dialog.";
            this.LoadCannedResponseList(); 
        }

        public void LoadCannedResponseList()
        {
            try {
                    //We have to do a small ROQL.
                    string query = "SELECT * from Chat.CannedResponses";
                    DataTable crl= _rnSrv.quickQuery(query);
                   
                //Sort them based on separate GroupsName.
                Dictionary<string,int> groupNames = new Dictionary<string,int>();
                int counter = 0;
                foreach (DataRow row in crl.Rows)
                {
                    if (!groupNames.ContainsKey(row["GroupName"].ToString())) {
                        groupNames.Add(row["GroupName"].ToString(), counter);
                        TreeNode pn = new TreeNode();
                        pn.Text = row["GroupName"].ToString();
                        pn.Name = "";
                        pn.Tag = "";
                        CannedResponseTree.Nodes.Add(pn);
                        counter++;
                    }
                }

                foreach (DataRow row in crl.Rows)
                    {
                    TreeNode tn = new TreeNode();
                    tn.Text = row["ResponseName"].ToString();
                    tn.ToolTipText = row["ID"].ToString();
                    tn.Tag = row["ResponseText"];
                    tn.Name = row["ResponseName"].ToString();
                    int groupDictionaryVal = groupNames[row["GroupName"].ToString()];
                    CannedResponseTree.Nodes[groupDictionaryVal].Nodes.Add(tn);
                    //CannedResponseTree.Nodes[counter].ResponseName = row["ResponseName"];
                    //CannedResponseTree.Nodes[counter].ResponseText = row["ResponseText"];
                    //counter++;
                    }

                }
            catch(Exception ex){
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                MessageBox.Show("Error "+ex.Message+" in line number : "+line.ToString()); 
            }              

        }  
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void canned_response_cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void canned_response_text_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void CannedResponseTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ResponseTextName.Text=CannedResponseTree.SelectedNode.Name.ToString();
            canned_response_text.DocumentText=CannedResponseTree.SelectedNode.Tag.ToString();
        }

        private void ResponseTextName_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void canned_response_ok_button_Click(object sender, EventArgs e)
        {
            string CannedChoosenText = ResponseTextName.Text;
            string CannedChosenHTML = canned_response_text.DocumentText;
            try
            {
                //IChatRecordContext genObj = (IChatRecordContext) _recordContext.GetWorkspaceRecord(WorkspaceRecordType.Chat);
                //genObj.AddMessageToComposeControl("Hello World!"); 
                 IChatRecordContext chatContext = _recordContext as IChatRecordContext;
                 chatContext.AddMessageToComposeControl(CannedChosenHTML.ToString());                                                                                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }


            this.Close();
        }
    }
}
