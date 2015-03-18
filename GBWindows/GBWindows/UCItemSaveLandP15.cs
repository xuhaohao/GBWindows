using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GBWindows
{
    public partial class UCItemSaveLandP15 : UserControl
    {
        public UCItemSaveLandP15()
        {
            InitializeComponent();
        }

        private void UCItemSaveLandP15_Load(object sender, EventArgs e)
        {
            var data1 = new List<EvaluateInfo>();
            data1.Add(new EvaluateInfo { EvaluateContent = "种植适应当地气候和土壤条件的植物，采用乔、灌、草结合的复层绿化，种植区域覆土深度和排水能力满足植物生长需求", EvaluateScore = "3" });
            data1.Add(new EvaluateInfo { EvaluateContent = "采用垂直绿化、屋顶绿化等方式", EvaluateScore = "3" });
            dgScientificGreening.DataSource = data1;
            

            //绑定PropertyGrid值
            ItemEvalKeyP15 p15 = new ItemEvalKeyP15();
            prgItemEvalKeyP15.SelectedObject = p15.PropertyGridDataP15();
        }

        //内容列表
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
    }
}
