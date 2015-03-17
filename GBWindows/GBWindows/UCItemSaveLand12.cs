using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GBWindows
{
    public partial class UCItemSaveLand12 : UserControl
    {
        public UCItemSaveLand12()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 评价
        /// </summary>
        private class EvaluateInfo
        {
            private string evaluateContent;

            public string EvaluateContent
            {
                get { return evaluateContent; }
                set { evaluateContent = value; }
            }

            private string evaluateScore;

            public string EvaluateScore
            {
                get { return evaluateScore; }
                set { evaluateScore = value; }
            }
        }

        private void UCItemSaveLand12_Load(object sender, EventArgs e)
        {
            var data1 = new List<EvaluateInfo>();
            data1.Add(new EvaluateInfo { EvaluateContent = "结合场地情况采取生态补偿措施", EvaluateScore = " 3" });
            dgEvaluate.DataSource = data1;
        }



    }
}
