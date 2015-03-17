using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GBWindows
{
    public partial class UCItemSaveLandL15 : UserControl
    {
        public UCItemSaveLandL15()
        {
            InitializeComponent();


           

        }


        private void UCItemSaveLandL15_Load(object sender, EventArgs e)
        {
            var data1 = new List<EvaluateInfo>();
            data1.Add(new EvaluateInfo { EvaluateContent = "种植适应当地气候和土壤条件的植物，采用乔、灌、草结合的复层绿化，种植区域覆土深度和排水能力满足植物生长需求", EvaluateScore = "3" });
            data1.Add(new EvaluateInfo { EvaluateContent = "绿地配植乔木不少", EvaluateScore = "3" });
            dgScientificGreening.DataSource = data1;


            ItemEvalKeyL15 iek = new ItemEvalKeyL15();
            prgItemEvalKeyL15.SelectedObject = iek;

        }


        private void dgScientificGreening_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            this.dgScientificGreening.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
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
