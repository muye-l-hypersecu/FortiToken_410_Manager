using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using Utility;
using static Utility.HyperFIDO;

namespace FortiToken_410_Manager
{
    public partial class Form1 : Form
    {
        public static Form1 MainForm = null;
        int DisplayAPDU = 1;

        // public defines
        string MsgBoxMessage = "";
        string MsgBoxCaption = "";
        MessageBoxButtons MsgBoxButtons;
        DialogResult MsgBoxResult;
        const int vid = 0x2ccf;

        [DllImport("HyperFIDO.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void startDeviceNotify(CSCallback callback);

        public delegate void CSCallback(int n);

        static CSCallback callback;

        public Form1()
        {
            InitializeComponent();
            MainForm = this;
            Thread th = new Thread(new ThreadStart(CallbackFunc));
            th.IsBackground = true;
            if (th == null)
            {
                DialogResult result = MessageBox.Show("Thread error occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }

            Form1.MainForm.keyStateLabel.Hide();

            th.Start();
            CSCallbackFunc(1);
        }

        static void CallbackFunc()
        {
            callback = CSCallbackFunc;
            startDeviceNotify(callback);
        }

        static void CSCallbackFunc(int n)
        {
            if (n == 0)
            {
                Form1.MainForm.keyStateLabel.Show();
                Form1.MainForm.keyStateLabel.Text = "Key removed.";
                fidoU2F_close();
            }
            else if (n == 1)
            {
                int ret;
                ret = fidoU2F_find(vid); // searches USB
                if (ret <= 0)
                {
                    Form1.MainForm.keyStateLabel.Text = "This is not a FortiToken 410 key.";
                    return;
                }

                ret = fidoU2F_open();
                if (ret != 0)
                {
                    Form1.MainForm.keyStateLabel.Text = "Open key error.";
                    return;
                }
                else
                {
                    Form1.MainForm.keyStateLabel.Show();
                    Form1.MainForm.keyStateLabel.Text = "FortiToken410 connected: ";
                    int p = fidoU2F_get_protocol();

                    switch (p)
                    {
                        case 0:
                            Form1.MainForm.keyStateLabel.Text += "HOTP only";
                            break;
                        case 1:
                            Form1.MainForm.keyStateLabel.Text += "FIDO only";
                            break;
                        case 2:
                            Form1.MainForm.keyStateLabel.Text += "FIDO and HOTP";
                            break;
                        default:
                            Form1.MainForm.keyStateLabel.Text += "Key Protocol is unavailable, Error code: " + ret.ToString("X");
                            break;

                    }
                }
            }
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


                MsgBoxMessage = "Open HyperFIDO Pro error, click OK to return.";
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
                    MsgBoxMessage = "Enable HOTP successful.";
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


                MsgBoxMessage = "Token Key Open Error, click OK to return";
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
                    MsgBoxMessage = "Disable HOTP successful.";
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
