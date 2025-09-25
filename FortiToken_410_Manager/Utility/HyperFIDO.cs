using System;
using System.Runtime.InteropServices;

namespace Utility;

/// <summary>
/// Represents the class the stores all the externally implemented functions for the HyperFIDO
/// </summary>
public static class HyperFIDO
{

    [DllImport("HyperFIDO.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int fidoU2F_find(int vid);

    [DllImport("HyperFIDO.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int fidoU2F_open();

    [DllImport("HyperFIDO.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    public static extern int fidoU2F_cmd(byte[] cmd, uint len, byte[] recvBuf, ref uint recvLen);

    [DllImport("HyperFIDO.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int fidoU2F_close();

    //Convert byte to Hex String
    public static string byteToHexStr(byte[] bytes)
    {
        string returnStr = "";
        if (bytes != null)
        {
            for (int i = 0; i < bytes.Length; i++)
            {
                returnStr += bytes[i].ToString("X2");
            }
        }
        return returnStr;
    }

}
