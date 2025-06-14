public static class Prompt
{
    public static string ShowDialog(string text, string caption, string defaultValue)
    {
        Form prompt = new Form()
        {
            Width = 400,
            Height = 150,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen
        };
        Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 340 };
        TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340, Text = defaultValue };
        Button confirmation = new Button() { Text = "OK", Left = 200, Width = 80, Top = 80, DialogResult = DialogResult.OK };
        Button cancel = new Button() { Text = "Cancel", Left = 280, Width = 80, Top = 80, DialogResult = DialogResult.Cancel };
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(cancel);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;
        prompt.CancelButton = cancel;

        var result = prompt.ShowDialog();
        return result == DialogResult.OK ? textBox.Text : null;
    }
}