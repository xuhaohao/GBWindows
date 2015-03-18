using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace GBWindows
{
    public class ItemEvalKeyP15
    {

        public XProps PropertyGridDataP15()
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
            xprop.Name = "是否采用屋顶绿化";
            xprop.Value = 1;
            xprop.ProType = typeof(Helper.MyComboItemConvert);
            xprop.Converter = new Helper.MyComboItemConvert("是,否");
            xprop.Description = "是否采用屋顶绿化";
            xps.Add(xprop);

            xprop = new XProp();
            xprop.Category = "常规";
            xprop.ReadOnly = false;
            xprop.Name = "是否采用垂直绿化";
            xprop.Value = 1;
            xprop.ProType = typeof(Helper.MyComboItemConvert);
            xprop.Converter = new Helper.MyComboItemConvert("是,否");
            xprop.Description = "是否采用垂直绿化";
            xps.Add(xprop);

            xprop = new XProp();
            xprop.Category = "常规";
            xprop.ReadOnly = false;
            xprop.Name = "屋顶可绿化面积(m2)";
            xprop.Value = "";
            xprop.Description = "屋顶可绿化面积(m2)";
            xprop.ProType = typeof(decimal);
            xps.Add(xprop);

            xprop = new XProp();
            xprop.Category = "常规";
            xprop.ReadOnly = false;
            xprop.Name = "屋顶绿化面积(m2))";
            xprop.Value = "";
            xprop.Description = "屋顶绿化面积(m2)";
            xprop.ProType = typeof(decimal);
            xps.Add(xprop);

            xprop = new XProp();
            xprop.Category = "常规";
            xprop.ReadOnly = false;
            xprop.Name = "屋顶绿化面积占屋顶可绿化面积比(%)";
            xprop.Value = "";
            xprop.Description = "屋顶绿化面积占屋顶可绿化面积比(%)";
            xprop.ProType = typeof(decimal);
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
        //        if (context != null && context.Instance is ItemEvalKeyP15)
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
        //        if (context != null && context.Instance is ItemEvalKeyP15)
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

        //[CategoryAttribute("3"), TypeConverter(typeof(IsUseConverter)), DisplayName("是否采用包含乔、灌木的复层绿化")]
        //public string IsUse { get; set; }
        //private class IsUseConverter : StringConverter
        //{
        //    public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        //    {
        //        if (context != null && context.Instance is ItemEvalKeyP15)
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
        //[CategoryAttribute("4"), DisplayName("如绿化植物种植在地下车库顶板上，则种植区域覆土深度(m)")]
        //public string Deepth
        //{
        //    get { return deepth; }
        //    set { deepth = value; }
        //}


        //[CategoryAttribute("5"), TypeConverter(typeof(IsRoofGreeningConverter)), DisplayName("是否采用屋顶绿化")]
        //public string IsRoofGreening { get; set; }
        //private class IsRoofGreeningConverter : StringConverter
        //{
        //    public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        //    {
        //        if (context != null && context.Instance is ItemEvalKeyP15)
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

        //[CategoryAttribute("6"), TypeConverter(typeof(IsVerticalGreeningConverter)), DisplayName("是否采用垂直绿化")]
        //public string IsVerticalGreening { get; set; }
        //private class IsVerticalGreeningConverter : StringConverter
        //{
        //    public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        //    {
        //        if (context != null && context.Instance is ItemEvalKeyP15)
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


        //private string caneGreenArea = "";
        //[DisplayName("屋顶可绿化面积(m2)"), Description("屋顶可绿化面积(m2)")]
        //public string CaneGreenArea
        //{
        //    get { return caneGreenArea; }
        //    set { caneGreenArea = value; }
        //}

        //private string greenArea = "";
        //[DisplayName("屋顶绿化面积(m2)"), Description("屋顶绿化面积(m2)")]
        //public string GreenArea
        //{
        //    get { return greenArea; }
        //    set { greenArea = value; }
        //}

        //private string greenSpaceRatio = "";
        //[DisplayName("屋顶绿化面积占屋顶可绿化面积比(%)"), Description("屋顶绿化面积占屋顶可绿化面积比(%)")]
        //public string GreenSpaceRatio
        //{
        //    get { return greenSpaceRatio; }
        //    set { greenSpaceRatio = value; }
        //}
        #endregion

      


    }

}
