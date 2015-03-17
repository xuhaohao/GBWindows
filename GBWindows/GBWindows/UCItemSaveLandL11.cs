using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GBWindows
{
    public partial class UCItemSaveLandL11 : UserControl
    {
        public UCItemSaveLandL11()
        {
            InitializeComponent();
        }

        private void UCItemSaveLandL11_Load(object sender, EventArgs e)
        {
            var data1 = new List<EvaluateInfo>();
            data1.Add(new EvaluateInfo { EvaluateContent = "场地出入口达到幼儿园的步行距离不超过300m", EvaluateScore = "3~6" });
            data1.Add(new EvaluateInfo { EvaluateContent = "场地出入口到达小学的步行距离不超过500m", EvaluateScore = "3~6" });
            data1.Add(new EvaluateInfo { EvaluateContent = "场地出入口到达小学的步行距离不超过500m", EvaluateScore = "3~6" });
            data1.Add(new EvaluateInfo { EvaluateContent = "场地出入口到达商业服务设施的步行距离不超过500m", EvaluateScore = "3~6" });
            data1.Add(new EvaluateInfo { EvaluateContent = "相关设施集中设置并向周边居民开放", EvaluateScore = "3~6" });
            data1.Add(new EvaluateInfo { EvaluateContent = "场地100m范围内设有5种以上的公共服务设施", EvaluateScore = "3~6" });
            dgEvaluate11.DataSource = data1;


            var data2 = new List<ResidentialSpaceInfo>();
            data2.Add(new ResidentialSpaceInfo { ProjectName = "", Type = "",Distance="" });
            data2.Add(new ResidentialSpaceInfo { ProjectName = "", Type = "", Distance = "" });
            data2.Add(new ResidentialSpaceInfo { ProjectName = "", Type = "", Distance = "" });
            data2.Add(new ResidentialSpaceInfo { ProjectName = "", Type = "", Distance = "" });
            data2.Add(new ResidentialSpaceInfo { ProjectName = "", Type = "", Distance = "" });
            data2.Add(new ResidentialSpaceInfo { ProjectName = "", Type = "", Distance = "" });
            data2.Add(new ResidentialSpaceInfo { ProjectName = "", Type = "", Distance = "" });
            data2.Add(new ResidentialSpaceInfo { ProjectName = "", Type = "", Distance = "" });
            dgResidentialSpace.DataSource = data2;
        }

        private void dgEvaluate11_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Helper.MergeColumns(dgEvaluate11, e, 1);
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
        //场地列表
        private class ResidentialSpaceInfo
        {
            private string projectName;

            public string ProjectName
            {
                get { return projectName; }
                set { projectName = value; }
            }

            private string type;

            public string Type
            {
                get { return type; }
                set { type = value; }
            }

            private string distance;

            public string Distance
            {
                get { return distance; }
                set { distance = value; }
            }
        }
    }
}
