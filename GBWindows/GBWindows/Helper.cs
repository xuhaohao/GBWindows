using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GBWindows
{
    class Helper
    {
        /// <summary>
        /// 合并指定列的文本内容
        /// </summary>
        /// <param name="dataGridView">要合并的DataGridView</param>
        /// <param name="e">传入DataGridView的CellPainting事件源</param>
        /// <param name="columnIndex">列号</param>
        public static void MergeColumns(DataGridView dataGridView,DataGridViewCellPaintingEventArgs e,int columnIndex ){
            Brush gridBrush = new SolidBrush(dataGridView.GridColor);
            SolidBrush backBrush = new SolidBrush(e.CellStyle.BackColor);
            SolidBrush fontBrush = new SolidBrush(e.CellStyle.ForeColor);
            int cellheight;
            int fontheight;
            int cellwidth;
            int fontwidth;
            int countU = 0;
            int countD = 0;
            int count = 0;
            int mergeCount = columnIndex;
            // 对第1列相同单元格进行合并
            if (e.ColumnIndex == mergeCount && e.RowIndex != -1)
            {
                cellheight = e.CellBounds.Height;
                fontheight = (int)e.Graphics.MeasureString(e.Value.ToString(), e.CellStyle.Font).Height;
                cellwidth = e.CellBounds.Width;
                fontwidth = (int)e.Graphics.MeasureString(e.Value.ToString(), e.CellStyle.Font).Width;
                Pen gridLinePen = new Pen(gridBrush);
                string curValue = e.Value == null ? "" : e.Value.ToString();
                string curSelected = dataGridView.Rows[e.RowIndex].Cells[mergeCount].Value == null ? ""
                    : dataGridView.Rows[e.RowIndex].Cells[mergeCount].Value.ToString();
                if (!string.IsNullOrEmpty(curValue))
                {
                    for (int i = e.RowIndex; i < dataGridView.Rows.Count; i++)
                    {
                        if (dataGridView.Rows[i].Cells[mergeCount].Value.ToString().Equals(curValue))
                        {
                            dataGridView.Rows[i].Cells[mergeCount].Selected = dataGridView.Rows[e.RowIndex].Selected;

                            dataGridView.Rows[i].Selected = dataGridView.Rows[e.RowIndex].Selected;

                            countD++;

                        }

                        else
                        {
                            break;
                        }
                    }
                    for (int i = e.RowIndex; i >= 0; i--)
                    {
                        if (dataGridView.Rows[i].Cells[mergeCount].Value.ToString().Equals(curValue))
                        {
                            dataGridView.Rows[i].Cells[mergeCount].Selected = dataGridView.Rows[e.RowIndex].Selected;

                            dataGridView.Rows[i].Selected = dataGridView.Rows[e.RowIndex].Selected;

                            countU++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    count = countD + countU - 1;
                    if (count < 2) { return; }
                }

                if (dataGridView.Rows[e.RowIndex].Selected)
                {
                    backBrush.Color = e.CellStyle.SelectionBackColor;
                    fontBrush.Color = e.CellStyle.SelectionForeColor;
                }

                e.Graphics.FillRectangle(backBrush, e.CellBounds);
                e.Graphics.DrawString((String)e.Value, e.CellStyle.Font, fontBrush, e.CellBounds.X + (cellwidth - fontwidth) / 2, e.CellBounds.Y - cellheight * (countU - 1) + (cellheight * count - fontheight) / 2);

                if (countD == 1)
                {
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    count = 0;
                }

                // 画右边线
                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);

                e.Handled = true;
            }
        }

        /// <summary>
        /// 合并指定列的文本内容
        /// </summary>
        /// <param name="dataGridView">要合并的DataGridView</param>
        /// <param name="e">传入DataGridView的CellPainting事件源</param>
        /// <param name="rowIndexList">列号</param>
        public static void MergeRows(DataGridView dataGridView, DataGridViewCellPaintingEventArgs e,List<int> rowIndexList,int a)
        {
            var cellwidth = e.CellBounds.Width;
            string curValue = e.Value == null ? "" : e.Value.ToString();
            var fontwidth = (int)e.Graphics.MeasureString(curValue, e.CellStyle.Font).Width;
            // 对第n行相同单元格进行合并
            if (rowIndexList.Contains(e.RowIndex) && e.ColumnIndex != -1)
            {
                using
                    (
                    Brush gridBrush = new SolidBrush(dataGridView.GridColor),
                    backColorBrush = new SolidBrush(e.CellStyle.BackColor)
                    )
                {
                    using (Pen gridLinePen = new Pen(gridBrush))
                    {
                        // 清除单元格
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                        // 画 Grid 边线（仅画单元格的底边线和右边线）
                        //   如果下一行和当前行的数据不同，则在当前的单元格画一条底边线
                        if (e.ColumnIndex < dataGridView.Columns.Count - 1 ){
                            var strValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value;
                            if (strValue == null || (strValue != null && e.Value != strValue))
	                        {
                                //画右边线
                                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                                e.CellBounds.Top, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom);
	                        }
                        }
                        // 画底线
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                        e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                        e.CellBounds.Bottom - 1);

                        // 画（填写）单元格内容，相同的内容的单元格只填写第一个
                        if (e.Value != null)
                        {
                            if (e.ColumnIndex > 0 && dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value.ToString() == e.Value.ToString())
                            {

                            }
                            else
                            {
                                e.Graphics.DrawString((String)e.Value, e.CellStyle.Font,
                                    Brushes.Black, e.CellBounds.X + 2,
                                    e.CellBounds.Y + 5, StringFormat.GenericDefault);
                            }
                        }
                        e.Handled = true;
                    }
                }
            }
        }

        public static void MergeRows(DataGridView dataGridView, DataGridViewCellPaintingEventArgs e, List<int> rowIndexList)
        {
            Brush gridBrush = new SolidBrush(dataGridView.GridColor);
            SolidBrush backBrush = new SolidBrush(e.CellStyle.BackColor);
            SolidBrush fontBrush = new SolidBrush(e.CellStyle.ForeColor);
            int cellheight;
            int fontheight;
            int cellwidth;
            int fontwidth;
            int countU = 0;
            int countD = 0;
            int count = 0;
            //int mergeCount = columnIndex;
            // 对第1列相同单元格进行合并
            foreach (var mergeRow in rowIndexList)
            {
                if (rowIndexList.Contains(e.RowIndex) && e.ColumnIndex != -1)
                {
                    cellheight = e.CellBounds.Height;
                    string curValue = e.Value == null ? "" : e.Value.ToString();
                    //var strValue = e.Value == null ? string.Empty : e.Value.ToString();
                    fontheight = (int)e.Graphics.MeasureString(curValue, e.CellStyle.Font).Height;
                    cellwidth = e.CellBounds.Width;
                    fontwidth = (int)e.Graphics.MeasureString(curValue, e.CellStyle.Font).Width;
                    Pen gridLinePen = new Pen(gridBrush);
                    
                    string curSelected = dataGridView.Rows[mergeRow].Cells[e.ColumnIndex].Value == null ? ""
                        : dataGridView.Rows[mergeRow].Cells[e.ColumnIndex].Value.ToString();
                    if (!string.IsNullOrEmpty(curValue))
                    {
                        for (int i = e.ColumnIndex; i >= 0; i--)
                        {
                            if (dataGridView.Rows[mergeRow].Cells[i].Value != null && dataGridView.Rows[mergeRow].Cells[i].Value.ToString().Equals(curValue))
                            {
                                dataGridView.Rows[mergeRow].Cells[i].Selected = dataGridView.Columns[e.ColumnIndex].Selected;

                                dataGridView.Rows[mergeRow].Selected = dataGridView.Columns[e.ColumnIndex].Selected;

                                countU++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        for (int i = e.ColumnIndex; i < dataGridView.Columns.Count; i++)
                        {
                            if (dataGridView.Rows[mergeRow].Cells[i].Value != null && dataGridView.Rows[mergeRow].Cells[i].Value.ToString().Equals(curValue))
                            {
                                dataGridView.Rows[mergeRow].Cells[i].Selected = dataGridView.Columns[e.ColumnIndex].Selected;

                                dataGridView.Rows[mergeRow].Selected = dataGridView.Columns[e.ColumnIndex].Selected;

                                countD++;
                            }

                            else
                            {
                                break;
                            }
                        }
                        

                        count = countD + countU - 1;
                        if (count < 2) { return; }
                    }
                    else
                    {
                        //空内容直接画右边线
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                    }

                    if (dataGridView.Columns[e.ColumnIndex].Selected)
                    {
                        backBrush.Color = e.CellStyle.SelectionBackColor;
                        fontBrush.Color = e.CellStyle.SelectionForeColor;
                    }

                    e.Graphics.FillRectangle(backBrush, e.CellBounds);
                    e.Graphics.DrawString((String)e.Value, e.CellStyle.Font, fontBrush, e.CellBounds.X + (cellwidth - fontwidth) / 2, e.CellBounds.Y - cellheight * (countU - 1) + (cellheight * count - fontheight) / 2);

                    if (countD == 1)
                    {
                        // 画右边线
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                        count = 0;
                    }
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    //e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                    

                    e.Handled = true;
                }
            }
        }
    }
}
