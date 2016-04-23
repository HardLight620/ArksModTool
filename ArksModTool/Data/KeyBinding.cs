using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharpDX.DirectInput;

namespace ArksModTool
{
    public class KeyBinding
    {
        public static readonly KeyBinding Empty = new KeyBinding();

        public bool Control { get; set; }
        public bool Shift { get; set; }
        public bool Alt { get; set; }

        public Key Key { get { return m_key; } set { m_key = value; } }
        private Key m_key = 0;

        public KeyBinding()
            : this(0)
        {

        }

        public KeyBinding(Key key)
            : this(key, false, false, false)
        {

        }

        public KeyBinding(Key key, bool ctrl, bool shift, bool alt)
        {
            this.Control = ctrl;
            this.Shift = shift;
            this.Alt = alt;
            this.Key = key;
        }

        public bool HasModifier()
        {
            return Control | Shift | Alt;
        }

        public bool CheckKeystate(KeyboardState curKeystate, KeyboardState lastKeystate)
        {
            bool okay = curKeystate.IsPressed(Key) && !lastKeystate.IsPressed(Key);

            if (Control)
                okay &= (curKeystate.IsPressed(Key.LeftControl) || curKeystate.IsPressed(Key.RightControl));

            if (Alt)
                okay &= (curKeystate.IsPressed(Key.LeftAlt) || curKeystate.IsPressed(Key.RightAlt));

            if (Shift)
                okay &= (curKeystate.IsPressed(Key.LeftShift) || curKeystate.IsPressed(Key.RightShift));

            return okay;
        }
        public override string ToString()
        {
            if (Key == 0)
                return "None";

            string str = "";
            
            str += (Control ? "Ctrl+" : "");
            str += (Alt ? "Alt+" : "");
            str += (Shift ? "Shift+" : "");
            str += Key.ToString();

            return str;
        }

        public static KeyBinding Parse(string str)
        {
            string[] parts = str.Split('+').Select(x => x.Trim()).ToArray();

            KeyBinding result = new KeyBinding();
            result.Control = parts.Contains("Ctrl");
            result.Shift = parts.Contains("Shift");
            result.Alt = parts.Contains("Alt");

            if (!Enum.TryParse(parts.LastOrDefault(), out result.m_key))
                result.Key = 0;

            return result;
        }
    }
}
