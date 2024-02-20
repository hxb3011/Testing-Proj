namespace HotelManagement.Presentation.ListControlHelpers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public abstract class Material2ItemRenderer<T> where T : ListControl
    {
        protected readonly T control;
        protected Font titleFont;
        protected IDictionary<DrawItemState, Brush> backgroundBrushes, titleBrushes;
        protected IDictionary<DrawItemState, FontStyle> titleFontStyles;
        public Font TitleFont { get => titleFont; set => SetFont(ref titleFont, value, 16); }
        public IDictionary<DrawItemState, Brush> BackgroundBrushes => GetStateInstanceDictionary(ref backgroundBrushes);
        public IDictionary<DrawItemState, Brush> TitleBrushes => GetStateInstanceDictionary(ref titleBrushes);
        public IDictionary<DrawItemState, FontStyle> TitleFontStyles => GetStateInstanceDictionary(ref titleFontStyles);

        protected Material2ItemRenderer(T c, DrawMode drawMode = DrawMode.OwnerDrawFixed)
        {
            if (c is ListBox l)
            {
                l.DrawMode = drawMode;
                l.DrawItem += OnDrawItem;
                l.MeasureItem += OnMeasureItem;
            }
            else if (c is ComboBox b)
            {
                b.DrawMode = drawMode;
                b.DrawItem += OnDrawItem;
                b.MeasureItem += OnMeasureItem;
            }
            else throw c is null ? new ArgumentNullException(nameof(c)) : new NotSupportedException();
            control = c;
        }

        protected abstract void OnMeasureItem(object sender, MeasureItemEventArgs e);
        protected abstract void OnDrawItem(object sender, DrawItemEventArgs e);

        protected static void SetFont(ref Font font, Font value, float size, GraphicsUnit unit = GraphicsUnit.Pixel)
        {
            if (value != null)
            {
                FontFamily family = value.FontFamily;
                FontStyle style = value.Style;
                byte charSet = value.GdiCharSet;
                bool verticalFont = value.GdiVerticalFont;
                if (font is not null && Equals(font.FontFamily, family)
                    && font.Style == style && font.GdiCharSet == charSet
                    && font.GdiVerticalFont == verticalFont) return;
                font = new Font(family, size, style, unit, charSet, verticalFont);
            }
            else font = null;
        }

        private static int ItemStateComparison(DrawItemState x, DrawItemState y) => ((int)y).CompareTo((int)x);

        protected static IDictionary<DrawItemState, TType> GetStateInstanceDictionary<TType>(ref IDictionary<DrawItemState, TType> dictionary)
        {
            IDictionary<DrawItemState, TType> res = dictionary;
            if (res is null) dictionary = res = new SortedDictionary<DrawItemState, TType>(Comparer<DrawItemState>.Create(ItemStateComparison));
            return res;
        }

        protected static bool TryGetInstanceOfState<TInstance>(IDictionary<DrawItemState, TInstance> instances, DrawItemState state, out TInstance result)
        {
            foreach (KeyValuePair<DrawItemState, TInstance> kv in instances)
            {
                DrawItemState mask = kv.Key;
                if ((state & mask) == mask)
                {
                    result = kv.Value;
                    return true;
                }
            }
            result = default;
            return false;
        }

        public class Simple : Material2ItemRenderer<T>
        {
            protected readonly FillItemCallback cb;
            protected Font subtitleFont, subtitle2Font;
            protected IDictionary<DrawItemState, Brush> subtitleBrushes, subtitle2Brushes;
            protected IDictionary<DrawItemState, FontStyle> subtitleFontStyles, subtitle2FontStyles;

            public Font SubtitleFont { get => subtitleFont; set => SetFont(ref subtitleFont, value, 12); }
            public Font Subtitle2Font { get => subtitle2Font; set => SetFont(ref subtitle2Font, value, 12); }
            public IDictionary<DrawItemState, Brush> SubtitleBrushes => GetStateInstanceDictionary(ref subtitleBrushes);
            public IDictionary<DrawItemState, Brush> Subtitle2Brushes => GetStateInstanceDictionary(ref subtitle2Brushes);
            public IDictionary<DrawItemState, FontStyle> SubtitleFontStyles => GetStateInstanceDictionary(ref subtitleFontStyles);
            public IDictionary<DrawItemState, FontStyle> Subtitle2FontStyles => GetStateInstanceDictionary(ref subtitle2FontStyles);

            public Simple(T c, FillItemCallback callback) : this(c, callback, DrawMode.OwnerDrawFixed) { }

            protected Simple(T c, FillItemCallback callback, DrawMode drawMode) : base(c, drawMode) => cb = callback;

            public delegate void FillItemCallback(T control, int itemIndex, DrawItemState state, ref string title, ref string subtitle, ref string subtitle2, ref Image logo, ref bool action);

            protected virtual void OnFillItem(T control, int itemIndex, DrawItemState state, out string title, out string subtitle, out string subtitle2, out Image logo, out bool action)
            {
                if (cb == null) throw new ArgumentNullException("callback",
                    "This instance of type '" + GetType().Name + "' was not initialized with a valid FillItemCallback.");
                title = null; subtitle = null; subtitle2 = null; logo = null; action = false;
                cb(control, itemIndex, state, ref title, ref subtitle, ref subtitle2, ref logo, ref action);
            }

            protected override void OnMeasureItem(object sender, MeasureItemEventArgs e)
            {
                int itemIndex = e.Index;
                if (itemIndex < 0) return;
                OnFillItem(sender as T, itemIndex, DrawItemState.None, out _, out string subtitle, out string subtitle2, out Image logo, out _);

                int height = 72;
                if (subtitle2 is not null) height = 88;
                else if (subtitle is null)
                {
                    if (logo is null) height = 48;
                    else if ((int)logo.HorizontalResolution < 48) height = 56;
                }
                else if (logo is null) height = 64;
                e.ItemHeight = height;
                e.ItemWidth = (sender as T).Width / 5 * 2;
            }

            protected override void OnDrawItem(object sender, DrawItemEventArgs e)
            {
                int itemIndex = e.Index;
                if (itemIndex < 0) return;
                DrawItemState state = e.State;
                OnFillItem(sender as T, itemIndex, state, out string title, out string subtitle, out string subtitle2, out Image logo, out bool action);
                if (TryGetInstanceOfState(BackgroundBrushes, state, out Brush background))
                    e.Graphics.FillRectangle(background, e.Bounds);
                else e.DrawBackground();

                Font titleFont = TitleFont, subtitleFont = SubtitleFont, subtitle2Font = Subtitle2Font;
                if (titleFont is null) SetFont(ref titleFont, e.Font, 14);
                if (subtitleFont is null) SetFont(ref subtitleFont, e.Font, 11);
                if (subtitle2Font is null) SetFont(ref subtitle2Font, e.Font, 11);

                if (TryGetInstanceOfState(TitleFontStyles, state, out FontStyle titleFontStyle) && titleFont is not null)
                    titleFont = new Font(titleFont, titleFontStyle);
                if (TryGetInstanceOfState(SubtitleFontStyles, state, out FontStyle subtitleFontStyle) && subtitleFont is not null)
                    subtitleFont = new Font(subtitleFont, subtitleFontStyle);
                if (TryGetInstanceOfState(Subtitle2FontStyles, state, out FontStyle subtitle2FontStyle) && subtitle2Font is not null)
                    subtitleFont = new Font(subtitle2Font, subtitle2FontStyle);

                if (title is not null && titleFont is null) throw new InvalidOperationException("TitleFont has not been specified!");
                if (subtitle is not null && subtitleFont is null) throw new InvalidOperationException("SubtitleFont has not been specified!");
                if (subtitle2 is not null && subtitle2Font is null) throw new InvalidOperationException("Subtitle2Font has not been specified!");

                Brush foregroundBrush = null;
                if (!TryGetInstanceOfState(TitleBrushes, state, out Brush titleBrush))
                {
                    foregroundBrush = new SolidBrush(e.ForeColor);
                    titleBrush = foregroundBrush;
                }
                if (!TryGetInstanceOfState(SubtitleBrushes, state, out Brush subtitleBrush))
                {
                    foregroundBrush ??= new SolidBrush(e.ForeColor);
                    subtitleBrush = foregroundBrush;
                }
                if (!TryGetInstanceOfState(Subtitle2Brushes, state, out Brush subtitle2Brush))
                {
                    foregroundBrush ??= new SolidBrush(e.ForeColor);
                    subtitle2Brush = foregroundBrush;
                }

                StringFormat sf = new()
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center,
                    FormatFlags = StringFormatFlags.NoWrap,
                    HotkeyPrefix = HotkeyPrefix.Show,
                    Trimming = StringTrimming.EllipsisWord
                };
                title ??= string.Empty;
                Rectangle bounds = e.Bounds;
                Graphics g = e.Graphics;
                if (subtitle2 is not null)
                {
                    RectangleF titleBounds, subtitleBounds, subtitle2Bounds;
                    if (logo is null)
                    {
                        titleBounds = new(bounds.Left + 16, bounds.Top + 14, bounds.Width - (action ? 72 : 32), 16);
                        subtitleBounds = new(bounds.Left + 16, bounds.Top + 38, bounds.Width - (action ? 72 : 32), 12);
                        subtitle2Bounds = new(bounds.Left + 16, bounds.Top + 58, bounds.Width - (action ? 72 : 32), 12);
                    }
                    else
                    {
                        Rectangle imageBounds;
                        int width = (int)logo.HorizontalResolution;
                        if (width < 32)
                        {
                            imageBounds = new(bounds.Left + 16, bounds.Top + 16, 24, 24);
                            titleBounds = new(bounds.Left + 72, bounds.Top + 14, bounds.Width - (action ? 128 : 88), 16);
                            subtitleBounds = new(bounds.Left + 72, bounds.Top + 38, bounds.Width - (action ? 128 : 88), 12);
                            subtitle2Bounds = new(bounds.Left + 72, bounds.Top + 58, bounds.Width - (action ? 128 : 88), 12);
                        }
                        else if (width < 48)
                        {
                            imageBounds = new(bounds.Left + 16, bounds.Top + 16, 40, 40);
                            titleBounds = new(bounds.Left + 72, bounds.Top + 14, bounds.Width - (action ? 128 : 88), 16);
                            subtitleBounds = new(bounds.Left + 72, bounds.Top + 38, bounds.Width - (action ? 128 : 88), 12);
                            subtitle2Bounds = new(bounds.Left + 72, bounds.Top + 58, bounds.Width - (action ? 128 : 88), 12);
                        }
                        else if (width < 84)
                        {
                            imageBounds = new(bounds.Left + 8, bounds.Top + 16, 56, 56);
                            titleBounds = new(bounds.Left + 88, bounds.Top + 14, bounds.Width - (action ? 144 : 104), 16);
                            subtitleBounds = new(bounds.Left + 88, bounds.Top + 38, bounds.Width - (action ? 144 : 104), 12);
                            subtitle2Bounds = new(bounds.Left + 88, bounds.Top + 58, bounds.Width - (action ? 144 : 104), 12);
                        }
                        else
                        {
                            imageBounds = new(bounds.Left, bounds.Top + 16, 100, 56);
                            titleBounds = new(bounds.Left + 116, bounds.Top + 14, bounds.Width - (action ? 172 : 132), 16);
                            subtitleBounds = new(bounds.Left + 116, bounds.Top + 38, bounds.Width - (action ? 172 : 132), 12);
                            subtitle2Bounds = new(bounds.Left + 116, bounds.Top + 58, bounds.Width - (action ? 172 : 132), 12);
                        }
                        g.DrawImage(logo, imageBounds);
                    }

                    if (title is not null) g.DrawString(title, titleFont, titleBrush, titleBounds, sf);
                    if (subtitle is not null) g.DrawString(subtitle, subtitleFont, subtitleBrush, subtitleBounds, sf);
                    g.DrawString(subtitle2, subtitle2Font, subtitle2Brush, subtitle2Bounds, sf);
                }
                else if (subtitle is null)
                {
                    RectangleF textBounds;
                    if (logo is not null)
                    {
                        Rectangle imageBounds;
                        int width = (int)logo.HorizontalResolution;
                        if (width < 32)
                        {
                            imageBounds = new(bounds.Left + 16, bounds.Top + 16, 24, 24);
                            textBounds = new(bounds.Left + 72, bounds.Top + 20, bounds.Width - (action ? 128 : 88), 16);
                        }
                        else if (width < 48)
                        {
                            imageBounds = new(bounds.Left + 16, bounds.Top + 8, 40, 40);
                            textBounds = new(bounds.Left + 72, bounds.Top + 20, bounds.Width - (action ? 128 : 88), 16);
                        }
                        else if (width < 84)
                        {
                            imageBounds = new(bounds.Left + 8, bounds.Top + 8, 56, 56);
                            textBounds = new(bounds.Left + 88, bounds.Top + 28, bounds.Width - (action ? 144 : 104), 16);
                        }
                        else
                        {
                            imageBounds = new(bounds.Left, bounds.Top + 8, 100, 56);
                            textBounds = new(bounds.Left + 116, bounds.Top + 28, bounds.Width - (action ? 172 : 132), 16);
                        }
                        g.DrawImage(logo, imageBounds);
                    }
                    else textBounds = new(bounds.Left + 16, bounds.Top + 16, bounds.Width - (action ? 72 : 32), 16);
                    if (title is not null) g.DrawString(title, titleFont, titleBrush, textBounds, sf);
                }
                else
                {
                    RectangleF titleBounds, subtitleBounds;
                    if (logo is null)
                    {
                        titleBounds = new(bounds.Left + 16, bounds.Top + 14, bounds.Width - (action ? 72 : 32), 16);
                        subtitleBounds = new(bounds.Left + 16, bounds.Top + 38, bounds.Width - (action ? 72 : 32), 12);
                    }
                    else
                    {
                        Rectangle imageBounds;
                        int width = (int)logo.HorizontalResolution;
                        if (width < 32)
                        {
                            imageBounds = new(bounds.Left + 16, bounds.Top + 16, 24, 24);
                            titleBounds = new(bounds.Left + 72, bounds.Top + 18, bounds.Width - (action ? 128 : 88), 16);
                            subtitleBounds = new(bounds.Left + 72, bounds.Top + 42, bounds.Width - (action ? 128 : 88), 12);
                        }
                        else if (width < 48)
                        {
                            imageBounds = new(bounds.Left + 16, bounds.Top + 16, 40, 40);
                            titleBounds = new(bounds.Left + 72, bounds.Top + 18, bounds.Width - (action ? 128 : 88), 16);
                            subtitleBounds = new(bounds.Left + 72, bounds.Top + 42, bounds.Width - (action ? 128 : 88), 12);
                        }
                        else if (width < 84)
                        {
                            imageBounds = new(bounds.Left + 8, bounds.Top + 8, 56, 56);
                            titleBounds = new(bounds.Left + 88, bounds.Top + 18, bounds.Width - (action ? 144 : 104), 16);
                            subtitleBounds = new(bounds.Left + 88, bounds.Top + 42, bounds.Width - (action ? 144 : 104), 12);
                        }
                        else
                        {
                            imageBounds = new(bounds.Left, bounds.Top + 8, 100, 56);
                            titleBounds = new(bounds.Left + 116, bounds.Top + 18, bounds.Width - (action ? 172 : 132), 16);
                            subtitleBounds = new(bounds.Left + 116, bounds.Top + 42, bounds.Width - (action ? 172 : 132), 12);
                        }
                        g.DrawImage(logo, imageBounds);
                    }

                    if (title is not null) g.DrawString(title, titleFont, titleBrush, titleBounds, sf);
                    g.DrawString(subtitle, subtitleFont, subtitleBrush, subtitleBounds, sf);
                }
            }
        }
    }
}
