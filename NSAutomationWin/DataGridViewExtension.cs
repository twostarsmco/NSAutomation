using System.Windows.Forms;

namespace MyExtensionMethods
{
    public static class DataGridViewExtension
    {
        /// <summary>
        /// A method to offset currently selected range on DataGridView.
        /// </summary>
        /// <param name="dgv">An instance of DataGridView</param>
        /// <param name="offsetRow">Amount of offset in number of rows</param>
        /// <param name="offsetColumn">Amount of offset in number of columns</param>
        public static void OffsetSelectedRange(this DataGridView dgv, int offsetRow, int offsetColumn)
        {
            DataGridViewCell[] deselectCells = new DataGridViewCell[dgv.SelectedCells.Count];
            dgv.SelectedCells.CopyTo(deselectCells, 0);

            foreach (DataGridViewCell cell in deselectCells)
            {
                cell.Selected = false;
                if ((0 <= (cell.RowIndex + offsetRow) && (cell.RowIndex + offsetRow) < dgv.Rows.Count) &&
                    (0 <= (cell.ColumnIndex + offsetColumn) && (cell.ColumnIndex + offsetColumn) < dgv.Columns.Count))
                {
                    dgv.Rows[cell.RowIndex + offsetRow].Cells[cell.ColumnIndex + offsetColumn].Selected = true;
                }
            }
        }
    }
}