using System;
using System.IO;

namespace HelpersLibStd
{
    public class FileHelpers
    {
        public static bool DeleteFile(string filePath, bool sendToRecycleBin = false)
        {
            try
            {
                if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                {
                    if (sendToRecycleBin)
                    {
                        // FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    }
                    else
                    {
                        File.Delete(filePath);
                    }

                    return true;
                }
            }
            catch (Exception e)
            {
                //  DebugHelper.WriteException(e);
            }

            return false;
        }

    }
}
