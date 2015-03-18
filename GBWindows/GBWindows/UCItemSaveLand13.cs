using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GBWindows
{
    public partial class UCItemSaveLand13 : UserControl
    {
        public UCItemSaveLand13()
        {
            InitializeComponent();
        }

        private void UCItemSaveLand13_Load(object sender, EventArgs e)
        {
            var data1 = new List<EvaluateInfo>();
            data1.Add(new EvaluateInfo { EvaluateContent = "下凹式绿地、雨水花园等有调蓄雨水功能的绿地和水体面积之和占绿地面积的比例达到30%", EvaluateScore = " 3" });
            data1.Add(new EvaluateInfo { EvaluateContent = "合理衔接和引导屋面雨水、道路雨水进入地面生态设施，并采取相应的径流污染控制措施", EvaluateScore = " 3" });
            data1.Add(new EvaluateInfo { EvaluateContent = "硬质铺装地面中透水铺装面积的比例达到50%", EvaluateScore = " 3" });
            dgEvaluate.DataSource = data1;

            var data2 = new List<Facility>();
            data2.Add(new Facility { StrIndex = "1", FacilityType = "下凹式绿地" });
            data2.Add(new Facility { StrIndex = "2", FacilityType = "雨水花园" });
            data2.Add(new Facility { StrIndex = "3", FacilityType = "屋顶绿化" });
            data2.Add(new Facility { StrIndex = "4", FacilityType = "植被浅沟" });
            data2.Add(new Facility { StrIndex = "5", FacilityType = "树池" });
            data2.Add(new Facility { StrIndex = "6", FacilityType = "雨水塘" });
            data2.Add(new Facility { StrIndex = "7", FacilityType = "雨水湿地" });
            data2.Add(new Facility { StrIndex = "8", FacilityType = "景观设计水体" });
            data2.Add(new Facility { StrIndex = "9", FacilityType = "自然水体（河流、湖泊）" });
            data2.Add(new Facility { StrIndex = "10", FacilityType = "其他有调蓄雨水功能的绿地和水体" });
            data2.Add(new Facility { StrIndex = string.Empty, FacilityType = "合计" });
            data2.Add(new Facility { StrIndex = string.Empty, FacilityType = "场地绿地面积" });
            data2.Add(new Facility { StrIndex = string.Empty, FacilityType = "有调蓄雨水功能的绿地和水体的面积之和占绿地面积" });
            dgFacility.DataSource = data2;

            var data3 = new List<Permeable>();
            data3.Add(new Permeable() { StrIndex = "1", PermeableType = "植草砖" });
            data3.Add(new Permeable() { StrIndex = "2", PermeableType = "透水沥青" });
            data3.Add(new Permeable() { StrIndex = "3", PermeableType = "透水混凝土" });
            data3.Add(new Permeable() { StrIndex = "4", PermeableType = "透水地砖" });
            data3.Add(new Permeable() { StrIndex = "5", PermeableType = "其他" });
            data3.Add(new Permeable() { PermeableType = "合计" });
            data3.Add(new Permeable() { PermeableType = "硬质铺装总面积" });
            data3.Add(new Permeable() { PermeableType = "硬质铺装地面中透水铺装面积" });
            dgPermeable.DataSource = data3;
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

        /// <summary>
        /// 基础设施
        /// </summary>
        private class Facility
        {
            private string strIndex;

            public string StrIndex
            {
                get { return strIndex; }
                set { strIndex = value; }
            }

            private string facilityType;

            public string FacilityType
            {
                get { return facilityType; }
                set { facilityType = value; }
            }

            private string area;

            public string Area
            {
                get { return area; }
                set { area = value; }
            }
        }

        /// <summary>
        /// 透水铺装类型
        /// </summary>
        private class Permeable {
            private string strIndex;

            public string StrIndex
            {
                get { return strIndex; }
                set { strIndex = value; }
            }

            private string permeableType;

            public string PermeableType
            {
                get { return permeableType; }
                set { permeableType = value; }
            }

            private string area;

            public string Area
            {
                get { return area; }
                set { area = value; }
            }
        }
    }
}
