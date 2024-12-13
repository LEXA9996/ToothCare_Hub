using ToothCare_Hub;

class InitControls
{
    private readonly RegisterForm _form;

    public InitControls(RegisterForm form)
    {
        _form = form;
    }

    public void InitControl()
    {
        var fields = new List<(TextBox Field, string Placeholder)>
        {
            (FindControl<TextBox>("NameField"), "������� ���"),
            (FindControl<TextBox>("SurnameField"), "������� �������"),
            (FindControl<TextBox>("NickField"), "���������� ���� �����"),
            (FindControl<TextBox>("MailField"), "������� ���� ����������� �����"),
            (FindControl<TextBox>("PassField"), "���������� ������"),
            (FindControl<TextBox>("CopyPassField"), "��������� ������")
        };

        foreach (var (field, placeholder) in fields)
        {
            if (field != null)
            {
                field.Text = placeholder;
                field.ForeColor = Color.FromArgb(128, 128, 128);
            }
        }
    }

    private T FindControl<T>(string name) where T : Control
    {
        return FindControlRecursive(_form.Controls, name) as T;
    }

    private Control FindControlRecursive(Control.ControlCollection controls, string name)
    {
        foreach (Control control in controls)
        {
            if (control.Name == name)
                return control;

            var found = FindControlRecursive(control.Controls, name);
            if (found != null)
                return found;
        }
        return null;
    }
}