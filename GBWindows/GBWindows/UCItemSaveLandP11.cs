using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GBWindows
{
    public partial class UCItemSaveLandP11 : UserControl
    {
        public UCItemSaveLandP11()
        {
            InitializeComponent();
        }

        private void UCItemSaveLandP11_Load(object sender, EventArgs e)
        {
            var data1 = new List<EvaluateInfo>();
            data1.Add(new EvaluateInfo { EvaluateContent = "场地出入口达到幼儿园的步行距离不超过300m", EvaluateScore = "3~6" });
            data1.Add(new EvaluateInfo { EvaluateContent = "场地出入口到达小学的步行距离不超过500m", EvaluateScore = "3~6" });
            data1.Add(new EvaluateInfo { EvaluateContent = "场地出入口到达小学的步行距离不超过500m", EvaluateScore = "3~6" });
            data1.Add(new EvaluateInfo { EvaluateContent = "场地出入口到达商业服务设施的步行距离不超过500m", EvaluateScore = "3~6" });
            data1.Add(new EvaluateInfo { EvaluateContent = "相关设施集中设置并向周边居民开放", EvaluateScore = "3~6" });
            data1.Add(new EvaluateInfo { EvaluateContent = "场地100m范围内设有5种以上的公共服务设施", EvaluateScore = "3~6" });
            dgEvaluateP11.DataSource = data1;

            var data2 = new List<PublicWorksInfo>();
            data2.Add(new PublicWorksInfo { PublicWorksNo = "", PublicWorksName = "", PublicWorksType = "", PublicWorksNum = "", PublicWorksDes = "" });
            data2.Add(new PublicWorksInfo { PublicWorksNo = "", PublicWorksName = "", PublicWorksType = "", PublicWorksNum = "", PublicWorksDes = "" });
            data2.Add(new PublicWorksInfo { PublicWorksNo = "", PublicWorksName = "", PublicWorksType = "", PublicWorksNum = "", PublicWorksDes = "" });
            dgPublicWorks.DataSource = data2;

            var data3 = new List<SupportingFacilitiesInfo>();
            data3.Add(new SupportingFacilitiesInfo { SupportingFacilitiesNo = "", SupportingFacilitiesName = "", SupportingFacilitiesNum = "", SupportingFacilitiesAffect = "", SupportingFacilitiesObject = "" });
            data3.Add(new SupportingFacilitiesInfo { SupportingFacilitiesNo = "", SupportingFacilitiesName = "", SupportingFacilitiesNum = "", SupportingFacilitiesAffect = "", SupportingFacilitiesObject = "" });
            dgSupportingFacilities.DataSource = data3;

            var data4 = new List<OpenSpaceInfo>();
            data4.Add(new OpenSpaceInfo { OpenSpaceNo = "", OpenSpaceName = "", OpenSpaceNum = "", OpenSpaceAffect = "", OpenSpaceTime = "" });
            data4.Add(new OpenSpaceInfo { OpenSpaceNo = "", OpenSpaceName = "", OpenSpaceNum = "", OpenSpaceAffect = "", OpenSpaceTime = "" });
            dgOpenSpace.DataSource = data4;
        }

        private void dgEvaluateP11_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Helper.MergeColumns(dgEvaluateP11, e, 1);
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

        //公共建筑列表
        private class PublicWorksInfo
        {
            private string publicWorksNo;

            public string PublicWorksNo
            {
                get { return publicWorksNo; }
                set { publicWorksNo = value; }
            }

            private string publicWorksName;

            public string PublicWorksName
            {
                get { return publicWorksName; }
                set { publicWorksName = value; }
            }

            private string publicWorksType;

            public string PublicWorksType
            {
                get { return publicWorksType; }
                set { publicWorksType = value; }
            }

            private string publicWorksNum;

            public string PublicWorksNum
            {
                get { return publicWorksNum; }
                set { publicWorksNum = value; }
            }

            private string publicWorksDes;

            public string PublicWorksDes
            {
                get { return publicWorksDes; }
                set { publicWorksDes = value; }
            }
        }

        //配套设施列表
        private class SupportingFacilitiesInfo
        {
            private string supportingFacilitiesNo;

            public string SupportingFacilitiesNo
            {
                get { return supportingFacilitiesNo; }
                set { supportingFacilitiesNo = value; }
            }

            private string supportingFacilitiesName;

            public string SupportingFacilitiesName
            {
                get { return supportingFacilitiesName; }
                set { supportingFacilitiesName = value; }
            }

            private string supportingFacilitiesNum;

            public string SupportingFacilitiesNum
            {
                get { return supportingFacilitiesNum; }
                set { supportingFacilitiesNum = value; }
            }

            private string supportingFacilitiesAffect;

            public string SupportingFacilitiesAffect
            {
                get { return supportingFacilitiesAffect; }
                set { supportingFacilitiesAffect = value; }
            }

            private string supportingFacilitiesObject;

            public string SupportingFacilitiesObject
            {
                get { return supportingFacilitiesObject; }
                set { supportingFacilitiesObject = value; }
            }
        }

        //开放空间列表
        private class OpenSpaceInfo
        {
            private string openSpaceNo;

            public string OpenSpaceNo
            {
                get { return openSpaceNo; }
                set { openSpaceNo = value; }
            }

            private string openSpaceName;

            public string OpenSpaceName
            {
                get { return openSpaceName; }
                set { openSpaceName = value; }
            }

            private string openSpaceNum;

            public string OpenSpaceNum
            {
                get { return openSpaceNum; }
                set { openSpaceNum = value; }
            }

            private string openSpaceAffect;

            public string OpenSpaceAffect
            {
                get { return openSpaceAffect; }
                set { openSpaceAffect = value; }
            }

            private string openSpaceTime;

            public string OpenSpaceTime
            {
                get { return openSpaceTime; }
                set { openSpaceTime = value; }
            }
        }


    }
}
