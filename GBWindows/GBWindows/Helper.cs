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
    }
}
