using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GBWindows
{
    public partial class UCItemSaveLand14 : UserControl
    {
        public UCItemSaveLand14()
        {
            InitializeComponent();
        }

        private void UCItemSaveLand14_Load(object sender, EventArgs e)
        {
            var data1 = new List<EvaluateInfo>();
            data1.Add(new EvaluateInfo { EvaluateContent = "场地年径流总量控制率达到55%", EvaluateScore = "3" });
            data1.Add(new EvaluateInfo { EvaluateContent = "场地年径流总量控制率达到70%", EvaluateScore = "6" });
            dgEvaluate.DataSource = data1;


            var data2 = new List<Infrastructure>();
            data2.Add(new Infrastructure());
            data2.Add(new Infrastructure());
            data2.Add(new Infrastructure());
            data2.Add(new Infrastructure());
            data2.Add(new Infrastructure());
            data2.Add(new Infrastructure());
            var v1 = "场地年径流量(m3)1232424242424";
            var v2 = "场地年降雨量(m2)424244242";
            var v3 = "场地年径流总量控制率(%)";
            data2.Add(new Infrastructure() { SurfaceType = v1, UtilizationMeasure = v1, Area = v1 });
            data2.Add(new Infrastructure() { SurfaceType = v2, UtilizationMeasure = v2, Area = v2 });
            data2.Add(new Infrastructure() { SurfaceType = v3, UtilizationMeasure = v3, Area = v3 });
            dgInfrastructure.DataSource = data2;
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

        private class Infrastructure {
            private string surfaceType;

            public string SurfaceType
            {
                get { return surfaceType; }
                set { surfaceType = value; }
            }

            private string utilizationMeasure;
            /// <summary>
            /// 利用措施
            /// </summary>
            public string UtilizationMeasure
            {
                get { return utilizationMeasure; }
                set { utilizationMeasure = value; }
            }

            private string area;

            public string Area
            {
                get { return area; }
                set { area = value; }
            }


            private string runoffCoefficient;
            /// <summary>
            /// 径流系数
            /// </summary>
            public string RunoffCoefficient
            {
                get { return runoffCoefficient; }
                set { runoffCoefficient = value; }
            }

            private string runoff;
            /// <summary>
            /// 净流量
            /// </summary>
            public string Runoff
            {
                get { return runoff; }
                set { runoff = value; }
            }
        }

        private void dgInfrastructure_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Helper.MergeRows(dgInfrastructure, e, new List<int> { 6,7, 8 },0);

        }
    }
}
