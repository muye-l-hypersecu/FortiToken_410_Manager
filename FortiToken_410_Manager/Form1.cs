using Microsoft.VisualBasic;
using Utility;

namespace FortiToken_410_Manager
{
    public partial class Form1 : Form
    {
        int DisplayAPDU = 1;

        // public defines
        string MsgBoxMessage = "";
        string MsgBoxCaption = "";
        MessageBoxButtons MsgBoxButtons;
        DialogResult MsgBoxResult;
        const int vid = 0x2ccf;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEnableHOTP_Click(object sender, EventArgs e)
        {
            int ret;
            //byte[] sendBuf = new byte[64];
            byte[] sendBuf = { 0x80, 0xE1, 0xFF, 0x00, 0x01, 0x30 };
            uint sendLen = 6;

            //byte[] sendBuf = { 0x00, 0xA4, 0x04, 0x00, 0x09, 0xD1, 0x56, 0x00, 0x01, 0x32, 0x83, 0x26, 0x01, 0x01 };
            //uint sendLen = 14;
            byte[] recvBuf = new byte[64];
            uint recvLen = 64;

            MsgBoxMessage = "HOTP feature on this key will be enabled. Do you want to continue?\r\n\r\nClick Yes to Enable, click No to cancel.\r\n\r\nTo complete the process, click Yes, then press the button on the key within 5 seconds when the green light begins flashing.";
            MsgBoxCaption = "";
            MsgBoxButtons = MessageBoxButtons.YesNo;


            // Displays the MessageBox.
            MsgBoxResult = MessageBox.Show(MsgBoxMessage, MsgBoxCaption, MsgBoxButtons, MessageBoxIcon.Warning);

            if (MsgBoxResult == System.Windows.Forms.DialogResult.No)
            {
                return; // Do not reset, return
            }


            ret = HyperFIDO.fidoU2F_find(vid); // Check 0x2CCF

            if (ret <= 0)
            {

                MsgBoxMessage = "Valid key not found. Ensure key is inserted properly or you are using a HyperFIDO Pro key.";
                MsgBoxCaption = "";
                MsgBoxButtons = MessageBoxButtons.OK;

                MsgBoxResult = MessageBox.Show(MsgBoxMessage, MsgBoxCaption, MsgBoxButtons, MessageBoxIcon.Error);
                return;
            }

            ret = HyperFIDO.fidoU2F_open();

            if (0 != ret)
            {


                MsgBoxMessage = "Open HyperFIDO Pro error, click OK to return";
                MsgBoxCaption = "";
                MsgBoxButtons = MessageBoxButtons.OK;

                MsgBoxResult = MessageBox.Show(MsgBoxMessage, MsgBoxCaption, MsgBoxButtons, MessageBoxIcon.Error);
                return;
            }



            ret = HyperFIDO.fidoU2F_cmd(sendBuf, sendLen, recvBuf, ref recvLen);



            if (0 != ret)
            {

                MsgBoxMessage = "Enable HOTP unsuccessful. Please try again.(" + ret.ToString("X") + ")";
                MsgBoxCaption = "";
                MsgBoxButtons = MessageBoxButtons.OK;

                MsgBoxResult = MessageBox.Show(MsgBoxMessage, MsgBoxCaption, MsgBoxButtons, MessageBoxIcon.Error);
                return;

            }

            if (null != recvBuf)
            {


                if ((recvBuf[0] == 0x90) && (recvBuf[1] == 0x00))
                {
                    MsgBoxMessage = "Enable HOTP successful.\r\nRe-insert the key to program. ";
                    MsgBoxCaption = "";
                    MsgBoxButtons = MessageBoxButtons.OK;

                    MsgBoxResult = MessageBox.Show(MsgBoxMessage, MsgBoxCaption, MsgBoxButtons, MessageBoxIcon.Information);

                }
                else
                {
                    MsgBoxMessage = "Enable HOTP unsuccessful. Please try again.";
                    MsgBoxCaption = "";
                    MsgBoxButtons = MessageBoxButtons.OK;

                    MsgBoxResult = MessageBox.Show(MsgBoxMessage, MsgBoxCaption, MsgBoxButtons, MessageBoxIcon.Error);

                }
            }



            HyperFIDO.fidoU2F_close();
        }

        private void BtnDisableHOTP_Click(object sender, EventArgs e)
        {
            int ret;
            //byte[] sendBuf = new byte[64];
            byte[] sendBuf = { 0x80, 0xE1, 0xFF, 0x00, 0x01, 0x20 };
            uint sendLen = 6;

            //byte[] sendBuf = { 0x00, 0xA4, 0x04, 0x00, 0x09, 0xD1, 0x56, 0x00, 0x01, 0x32, 0x83, 0x26, 0x01, 0x01 };
            //uint sendLen = 14;
            byte[] recvBuf = new byte[64];
            uint recvLen = 64;

            MsgBoxMessage = "HOTP feature on this key will be disabled. Do you want to continue?\r\n\r\nClick Yes to Enable, click No to cancel.\r\n\r\nTo complete the process, click Yes, then press the button on the key within 5 seconds when the green light begins flashing.";
            MsgBoxCaption = "";
            MsgBoxButtons = MessageBoxButtons.YesNo;


            // Displays the MessageBox.
            MsgBoxResult = MessageBox.Show(MsgBoxMessage, MsgBoxCaption, MsgBoxButtons, MessageBoxIcon.Warning);

            if (MsgBoxResult == System.Windows.Forms.DialogResult.No)
            {
                return; // Do not reset, return
            }


            ret = HyperFIDO.fidoU2F_find(vid); // Check 0x2CCF

            if (ret <= 0)
            {

                MsgBoxMessage = "Valid key not found. Ensure key is inserted properly or you are using a HyperFIDO Pro key.";
                MsgBoxCaption = "";
                MsgBoxButtons = MessageBoxButtons.OK;

                MsgBoxResult = MessageBox.Show(MsgBoxMessage, MsgBoxCaption, MsgBoxButtons, MessageBoxIcon.Error);
                return;
            }

            ret = HyperFIDO.fidoU2F_open();

            if (0 != ret)
            {


                MsgBoxMessage = "Open HyperFIDO Pro error, click OK to return";
                MsgBoxCaption = "";
                MsgBoxButtons = MessageBoxButtons.OK;

                MsgBoxResult = MessageBox.Show(MsgBoxMessage, MsgBoxCaption, MsgBoxButtons, MessageBoxIcon.Error);
                return;
            }



            ret = HyperFIDO.fidoU2F_cmd(sendBuf, sendLen, recvBuf, ref recvLen);



            if (0 != ret)
            {

                MsgBoxMessage = "Disable HOTP unsuccessful. Please try again.(" + ret.ToString("X") + ")";
                MsgBoxCaption = "";
                MsgBoxButtons = MessageBoxButtons.OK;

                MsgBoxResult = MessageBox.Show(MsgBoxMessage, MsgBoxCaption, MsgBoxButtons, MessageBoxIcon.Error);
                return;

            }

            if (null != recvBuf)
            {
                if ((recvBuf[0] == 0x90) && (recvBuf[1] == 0x00))
                {
                    MsgBoxMessage = "Disable HOTP successful.\r\nRe-insert the key to program. ";
                    MsgBoxCaption = "";
                    MsgBoxButtons = MessageBoxButtons.OK;

                    MsgBoxResult = MessageBox.Show(MsgBoxMessage, MsgBoxCaption, MsgBoxButtons, MessageBoxIcon.Information);

                }
                else
                {
                    MsgBoxMessage = "Disable HOTP unsuccessful. Please try again.";
                    MsgBoxCaption = "";
                    MsgBoxButtons = MessageBoxButtons.OK;

                    MsgBoxResult = MessageBox.Show(MsgBoxMessage, MsgBoxCaption, MsgBoxButtons, MessageBoxIcon.Error);

                }
            }

            HyperFIDO.fidoU2F_close();


        }
    }
}
