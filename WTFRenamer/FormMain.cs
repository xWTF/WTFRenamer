using IWshRuntimeLibrary;
//using Microsoft.Win32;

using System.Diagnostics;
using System.Text.RegularExpressions;
using File = System.IO.File;

namespace WTFRenamer
{
    public partial class FormMain : Form
    {
        static readonly Regex NumberingReplace = new(@"([^\\]#|^#)", RegexOptions.Compiled);

        ItemComparer Sorter = new();

        public FormMain(string[] argv)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            // TODO: Load state

            foreach (string f in argv)
            {
                try
                {
                    AddFile(Path.GetFullPath(f));
                }
                catch { }
            }
            if (checkBox_autosort.Checked)
            {
                button_sort.PerformClick();
            }
            else
            {
                UpdatePreview();
            }
        }

        public void UpdatePreview(object? sender = null, EventArgs? e = null)
        {
            button_undo.Enabled = false;
            if (tabControl1.SelectedIndex == 0)
            {
                Regex? regex;
                try
                {
                    regex = new Regex(textBox1.Text == "" ? "^.*$" : textBox1.Text, RegexOptions.Compiled);
                }
                catch
                {
                    regex = null;
                }
                var number = numericUpDown_start.Value;

                listView1.BeginUpdate();
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.SubItems[2].Text != "")
                    {
                        item.SubItems[0].Text = Path.GetFileName((string)item.Tag);
                        item.SubItems[2].Text = "";
                    }
                    try
                    {
                        var name = item.SubItems[0].Text;

                        // Remove Extension
                        string? ext = null;
                        if (!checkBox_ext.Checked)
                        {
                            var index = name.LastIndexOf('.');
                            if (index != -1)
                            {
                                ext = name[index..];
                                name = name[..index];
                            }
                        }

                        // Regex Replace
                        name = regex!.Replace(name, textBox2.Text);

                        // Numbering
                        name = NumberingReplace.Replace(name, e => e.Value[..^1] + number.ToString().PadLeft((int)numericUpDown_length.Value, '0'));
                        number += numericUpDown_incr.Value;

                        // Letter Case
                        switch (comboBox1.SelectedIndex)
                        {
                        case 0:
                            break;
                        case 1:
                            name = name.ToUpper();
                            break;
                        case 2:
                            name = name.ToLower();
                            break;
                        case 3:
                            name = new string(name.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
                            break;
                        }

                        item.SubItems[1].Text = ext == null ? name : name + ext;
                    }
                    catch
                    {
                        item.SubItems[1].Text = "";
                    }
                    item.SubItems[2].Text = "";
                }
                listView1.EndUpdate();
            }
        }

        public void SwapListItem(int prev, int next)
        {
            if (prev > next)
            {
                int tmp = next;
                next = prev;
                prev = tmp;
            }
            ListViewItem pItem = listView1.Items[prev], nItem = listView1.Items[next];
            listView1.Items.RemoveAt(next);
            listView1.Items.RemoveAt(prev);
            listView1.Items.Insert(prev, nItem);
            listView1.Items.Insert(next, pItem);
        }

        public void DoRename(bool undo)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (undo && !item.SubItems[2].Text.StartsWith("¡Ì"))
                {
                    continue;
                }
                try
                {
                    string src = (string)item.Tag, dstFile = undo ? item.SubItems[0].Text : item.SubItems[1].Text;

                    if (dstFile == "")
                    {
                        return;
                    }
                    string dst = Path.Combine(Path.GetDirectoryName(src)!, dstFile), dst_final = dst;

                    // Conflict handling
                    int i = 1;
                    while (File.Exists(dst_final) || Directory.Exists(dst_final))
                    {
                        dst_final = Path.Combine(Path.GetDirectoryName(dst)!, Path.GetFileNameWithoutExtension(dst) + " (" + (i++) + ")" + Path.GetExtension(dst));
                    }

                    if (File.GetAttributes(src).HasFlag(FileAttributes.Directory))
                    {
                        Directory.Move(src, dst_final);
                    }
                    else
                    {
                        File.Move(src, dst_final);
                    }

                    item.Tag = dst_final;
                    item.SubItems[2].Text = i == 1 ? "¡Ì" : "¡Ì CON: " + (i - 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    item.SubItems[2].Text = "ERROR";
                }
            }
        }

        public void AddFile(string file)
        {
            if (!listView1.Items.OfType<ListViewItem>().Any(i => i.Tag as string == file))
            {
                listView1.Items.Add(new ListViewItem(new string[] { Path.GetFileName(file), "", "" })
                {
                    Tag = file
                });
            }
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data!.GetData(DataFormats.FileDrop);
            listView1.BeginUpdate();
            foreach (var f in files)
            {
                AddFile(f);
            }
            if (checkBox_autosort.Checked)
            {
                button_sort.PerformClick();
            }
            else
            {
                UpdatePreview();
            }
            listView1.EndUpdate();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                Sorter.Descending = !Sorter.Descending;
                button_sort.PerformClick();
            }
        }

        private void button_up_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (int index in listView1.SelectedIndices)
            {
                if (index == 0)
                {
                    break;
                }
                SwapListItem(index - 1, index);
            }
            UpdatePreview();
            listView1.EndUpdate();
        }

        private void button_down_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (int index in listView1.SelectedIndices.OfType<int>().Reverse())
            {
                if (index == listView1.Items.Count - 1)
                {
                    break;
                }
                SwapListItem(index, index + 1);
            }
            UpdatePreview();
            listView1.EndUpdate();
        }

        private void button_top_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                var index = listView1.SelectedIndices[0];
                if (index == 0)
                {
                    return;
                }
                listView1.BeginUpdate();
                SwapListItem(0, index);
                UpdatePreview();
                listView1.EndUpdate();
            }
        }

        private void button_bottom_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                var index = listView1.SelectedIndices[0];
                if (index == listView1.Items.Count - 1)
                {
                    return;
                }
                listView1.BeginUpdate();
                SwapListItem(index, listView1.Items.Count - 1);
                UpdatePreview();
                listView1.EndUpdate();
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
            UpdatePreview();
            listView1.EndUpdate();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            listView1.ListViewItemSorter = Sorter;
            listView1.Sort();
            listView1.ListViewItemSorter = null;
            UpdatePreview();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            DoRename(false);
            button_undo.Enabled = true;
        }

        private void button_undo_Click(object sender, EventArgs e)
        {
            button_undo.Enabled = false;
            DoRename(true);
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
            case 0:
                UpdatePreview();
                button_start.Enabled = true;
                break;
            default:
                button_start.Enabled = false;
                break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/xWTF/WTFRenamer")
            {
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private const string ShellKey = @"*\shell\WTF Renamer";
        private static string SendToFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.SendTo), "WTF Renamer.lnk");

        private void button_menu_register_Click(object sender, EventArgs e)
        {
            try
            {
                string exe = Environment.ProcessPath!;

                IWshShortcut shortcut = new WshShell().CreateShortcut(SendToFile);
                shortcut.Description = "Rename with WTF Renamer";   // The description of the shortcut
                shortcut.IconLocation = exe;
                shortcut.TargetPath = exe + " ";
                shortcut.Save();

                MessageBox.Show("SendTo entry created", "Dome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //using var menu = Registry.ClassesRoot.CreateSubKey(ShellKey);
                //menu.SetValue("", "Rename with WTF Renamer");
                ////menu.SetValue("Icon", $"\"{exe}\"");
                //menu.SetValue("MultiSelectModel", "Player");

                //using var cmd = menu.CreateSubKey("command");
                //cmd.SetValue("", $"\"{exe}\" \"%1\"");

                //MessageBox.Show("Context menu entry created", "Dome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_menu_unregister_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(SendToFile);
                MessageBox.Show("SendTo entry removed", "Dome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Registry.ClassesRoot.DeleteSubKeyTree(ShellKey);
                //MessageBox.Show("Context menu entry removed", "Dome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
