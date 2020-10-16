using System;
using System.IO;
using System.Windows.Forms;
namespace ErfanCoImageUploader
{
    public static class ErrorLog
    {
        public static void SaveLog(Exception ex)
        {
            var Error =
                        ex.Message + (ex.InnerException?.Message ?? "") +
                        (ex.InnerException?.InnerException?.Message ?? "");
            System.IO.File.AppendAllText(Path.GetDirectoryName(Application.ExecutablePath) + @"\ErrorLog.txt", Error + Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine);
        }
    }
}