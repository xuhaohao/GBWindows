using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GBWindows
{
    public class ItemEvalKeyL15
    {

        private bool saveOnClose = true;
        private string greetingText = "欢迎使用应用程序！";
        private int itemsInMRU = 4;
        private int maxRepeatRate = 10;
        private bool settingsChanged = false;
        private string appVersion = "1.0";

        public bool 徐浩浩
        {
            get { return saveOnClose; }
            set { saveOnClose = value; }
        }
        public string GreetingText
        {
            get { return greetingText; }
            set { greetingText = value; }
        }
        public int MaxRepeatRate
        {
            get { return maxRepeatRate; }
            set { maxRepeatRate = value; }
        }
        public int ItemsInMRUList
        {
            get { return itemsInMRU; }
            set { itemsInMRU = value; }
        }
        public bool SettingsChanged
        {
            get { return settingsChanged; }
            set { settingsChanged = value; }
        }
        public string AppVersion
        {
            get { return appVersion; }
            set { appVersion = value; }
        }
    }
}
