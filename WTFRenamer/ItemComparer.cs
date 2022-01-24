using System.Collections;

namespace WTFRenamer
{
    internal class ItemComparer : IComparer
    {
        public bool Descending = false;

        public int Compare(object? _x, object? _y)
        {
            string xText = (_x as ListViewItem)!.SubItems[0].Text, yText = (_y as ListViewItem)!.SubItems[0].Text;
            return Descending ? yText.CompareTo(xText) : xText.CompareTo(yText);
        }
    }
}
