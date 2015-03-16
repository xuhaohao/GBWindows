using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GBWindows
{
    public partial class UCItemSaveLand10 : UserControl
    {
        public UCItemSaveLand10()
        {
            InitializeComponent();
        }



        private void UCItemSaveLand10_Load(object sender, EventArgs e)
        {
            var data1 = new List<EvaluateInfo>();
            data1.Add(new EvaluateInfo { EvaluateContent = "自行车停车设施位置合理、方便出入，且有遮阳防雨措施", EvaluateScore = " 3" });
            data1.Add(new EvaluateInfo { EvaluateContent = "合理设置机动车停车设施，并采取下列措施至少2项：", EvaluateScore = " 3 " });
            data1.Add(new EvaluateInfo { EvaluateContent = "1、采用机械式停车库、地下停车库或停车楼等方式节约集约用地；", EvaluateScore = " 3 " });
            data1.Add(new EvaluateInfo { EvaluateContent = "2、采用错时停车方式向社会开放，提高停车场（库）使用效率", EvaluateScore = " 3 " });
            data1.Add(new EvaluateInfo { EvaluateContent = "3、合理设计地面停车位不挤占步行空间及活动场所。", EvaluateScore = " 3 " });
            dgEvaluate.DataSource = data1;

            var data2 = new List<ParkConfigType>();
            data2.Add(new ParkConfigType { StrType = "自行车停车位数量" });
            data2.Add(new ParkConfigType { StrType = "机动车停车位数量" });
            dgParkConfig.DataSource = data2;



        }

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

        private class ParkConfigType
        {
            private string strType;

            public string StrType
            {
                get { return strType; }
                set { strType = value; }
            }

            private string standardThreshold;

            public string StandardThreshold
            {
                get { return standardThreshold; }
                set { standardThreshold = value; }
            }

            private string designCount;

            public string DesignCount
            {
                get { return designCount; }
                set { designCount = value; }
            }

            private string isSatisfy;

            public string IsSatisfy
            {
                get { return isSatisfy; }
                set { isSatisfy = value; }
            }
            
        }

        private void dgEvaluate_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Helper.MergeColumns(dgEvaluate, e, 1);
        }
    }


    
}
