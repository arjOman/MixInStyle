namespace MixInStyle.Core
{
    public class Toogle : Button
    {
        internal readonly Color r = Color.FromArgb(50, 50, 50);
        internal readonly Color s = Color.Red;
        protected override void OnClick(EventArgs e)
        {
            if (BackColor == r)
            {
                ForeColor = r;
                BackColor = s;
            }
            else
            {
                ForeColor = s;
                BackColor = r;
            }
            base.OnClick(e);
        }
    }
}
