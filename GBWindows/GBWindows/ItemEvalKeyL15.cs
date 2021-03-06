﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace GBWindows
{
    public class ItemEvalKeyL15
    {
        public XProps PropertyGridDataL15()
        {
            XProps xps = new XProps();
            XProp xprop = new XProp();


            xprop = new XProp();
            xprop.Category = "常规";
            xprop.ReadOnly = false;
            xprop.Name = "项目所在地为以下选项中的";
            xprop.Value = 0;
            xprop.ProType = typeof(Helper.MyComboItemConvert);
            xprop.Converter = new Helper.MyComboItemConvert("华北,华南");
            xprop.Description = "项目所在地为以下选项中的";
            xps.Add(xprop);

            xprop = new XProp();
            xprop.Category = "常规";
            xprop.ReadOnly = false;
            xprop.Name = "绿化物种是否主要选用适宜当地气候和土壤条件的乡土植物";
            xprop.Value = 0;
            xprop.ProType = typeof(Helper.MyComboItemConvert);
            xprop.Converter = new Helper.MyComboItemConvert("是,否");
            xprop.Description = "绿化物种是否主要选用适宜当地气候和土壤条件的乡土植物";
            xps.Add(xprop);

            xprop = new XProp();
            xprop.Category = "常规";
            xprop.ReadOnly = false;
            xprop.Name = "是否采用包含乔、灌木的复层绿化";
            xprop.Value = 0;
            xprop.ProType = typeof(Helper.MyComboItemConvert);
            xprop.Converter = new Helper.MyComboItemConvert("是,否");
            xprop.Description = "是否采用包含乔、灌木的复层绿化";
            xps.Add(xprop);

            xprop = new XProp();
            xprop.Category = "常规";
            xprop.ReadOnly = false;
            xprop.Name = "如绿化植物种植在地下车库顶板上，则种植区域覆土深度(m)";
            xprop.Value = "";
            xprop.Description = "如绿化植物种植在地下车库顶板上，则种植区域覆土深度(m)";
            xprop.ProType = typeof(String);
            xps.Add(xprop);

            xprop = new XProp();
            xprop.Category = "常规";
            xprop.ReadOnly = false;
            xprop.Name = "项目用地面积(m2)";
            xprop.Value = "";
            xprop.Description = "项目用地面积(m2)";
            xprop.ProType = typeof(decimal);
            xps.Add(xprop);

            xprop = new XProp();
            xprop.Category = "常规";
            xprop.ReadOnly = false;
            xprop.Name = "绿地面积(m2))";
            xprop.Value = "";
            xprop.Description = "绿地面积(m2)";
            xprop.ProType = typeof(decimal);
            xps.Add(xprop);

            xprop = new XProp();
            xprop.Category = "常规";
            xprop.ReadOnly = false;
            xprop.Name = "绿地中乔木的数量(株)";
            xprop.Value = "";
            xprop.Description = "绿地中乔木的数量(株)";
            xprop.ProType = typeof(int);
            xps.Add(xprop);

            xprop = new XProp();
            xprop.Category = "常规";
            xprop.ReadOnly = false;
            xprop.Name = "平均每100m2绿地面积上的乔木数(株)";
            xprop.Value = "";
            xprop.Description = "平均每100m2绿地面积上的乔木数(株)";
            xprop.ProType = typeof(int);
            xps.Add(xprop);

            return xps;
        }



        #region 隐藏
        //[CategoryAttribute("1"), TypeConverter(typeof(ProjectLocatedConverter))]
        //public string 项目所在地为以下选项中的 { get; set; }
        //private class ProjectLocatedConverter : StringConverter
        //{
        //    public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        //    {
        //        if (context != null && context.Instance is ItemEvalKeyL15)
        //        {
        //            List<string> values = new System.Collections.Generic.List<string>();
        //            values.Add("华北");
        //            values.Add("东北");
        //            values.Add("平原");
        //            return new StandardValuesCollection(values);
        //        }
        //        return base.GetStandardValues(context);
        //    }
        //    public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        //    {
        //        return true;
        //    }
        //}

        //[CategoryAttribute("2"), TypeConverter(typeof(IsSelectionConverter))]
        //public string 绿化物种是否主要选用适宜当地气候和土壤条件的乡土植物 { get; set; }
        //private class IsSelectionConverter : StringConverter
        //{
        //    public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        //    {
        //        if (context != null && context.Instance is ItemEvalKeyL15)
        //        {
        //            List<string> values = new System.Collections.Generic.List<string>();
        //            values.Add("是");
        //            values.Add("否");
        //            return new StandardValuesCollection(values);
        //        }
        //        return base.GetStandardValues(context);
        //    }
        //    public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        //    {
        //        return true;
        //    }
        //}

        //[CategoryAttribute("3"), TypeConverter(typeof(IsUseConverter))]
        //[DisplayName("是否采用包含乔、灌木的复层绿化"), Description("是否采用包含乔、灌木的复层绿化")]
        //public string IsUse { get; set; }
        //private class IsUseConverter : StringConverter
        //{
        //    public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        //    {
        //        if (context != null && context.Instance is ItemEvalKeyL15)
        //        {
        //            List<string> values = new System.Collections.Generic.List<string>();
        //            values.Add("是");
        //            values.Add("否");
        //            return new StandardValuesCollection(values);
        //        }
        //        return base.GetStandardValues(context);
        //    }
        //    public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        //    {
        //        return true;
        //    }
        //}

        //private string deepth = "";
        //[DisplayName("如绿化植物种植在地下车库顶板上，则种植区域覆土深度(m)"), Description("如绿化植物种植在地下车库顶板上，则种植区域覆土深度(m)")]
        //public string Deepth
        //{
        //    get { return deepth; }
        //    set { deepth = value; }
        //}

        //private string projectSite = "";
        //[DisplayName("项目用地面积(m2)"), Description("项目用地面积(m2)")]
        //public string ProjectSite
        //{
        //    get { return projectSite; }
        //    set { projectSite = value; }
        //}

        //private string greenArea = "";
        //[DisplayName("绿地面积(m2)"), Description("绿地面积(m2)")]
        //public string GreenArea
        //{
        //    get { return greenArea; }
        //    set { greenArea = value; }
        //}

        //private string greenQuantity = "";
        //[DisplayName("绿地中乔木的数量(株)"), Description("绿地中乔木的数量(株)")]
        //public string GreenQuantity
        //{
        //    get { return greenQuantity; }
        //    set { greenQuantity = value; }
        //}

        //private string areaQuantity = "";
        //[DisplayName("平均每100m2绿地面积上的乔木数(株)"), Description("平均每100m2绿地面积上的乔木数(株)")]
        //public string AreaQuantity
        //{
        //    get { return areaQuantity; }
        //    set { areaQuantity = value; }
        //}

        #endregion






    }



}
