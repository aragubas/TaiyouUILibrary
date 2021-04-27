using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiyouUI
{
    public static class Utils
    {
        public static void CreateWindow(taiyouUserControl control, string DefaultTitle = "Untitled Window", bool ShowAsDialog = false)
        {
            TabNotepadForm ParentForm = new TabNotepadForm();

            // Add controls to the form
            control.RootForm = ParentForm;
            ParentForm.FormControls.Controls.Add(control);

            ParentForm.Text = DefaultTitle;

            if (!ShowAsDialog)
            {
                ParentForm.Show();

            }
            else { ParentForm.ShowDialog(); }

        }

    }
}
