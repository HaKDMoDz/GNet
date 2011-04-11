﻿using System;

using GNetLibrary.IO;
using GNetLibrary.PInvoke;

namespace GNetLibrary.Macro
{
    public class MouseTap : Step
    {
        public MouseTap(int button)
        {
            int data = 0;

            switch (button)
            {
                case 0:
                case 1:
                    inputs = new InputWrapper[] { InputSimulator.MouseWrapper(MouseEventFlags.LeftDown, data) };
                    inputs = new InputWrapper[] { InputSimulator.MouseWrapper(MouseEventFlags.LeftUp, data) };
                    break;

                case 2:
                    inputs = new InputWrapper[] { InputSimulator.MouseWrapper(MouseEventFlags.RightDown, data) };
                    inputs = new InputWrapper[] { InputSimulator.MouseWrapper(MouseEventFlags.RightUp, data) };
                    break;

                case 3:
                    inputs = new InputWrapper[] { InputSimulator.MouseWrapper(MouseEventFlags.MiddleDown, data) };
                    inputs = new InputWrapper[] { InputSimulator.MouseWrapper(MouseEventFlags.MiddleUp, data) };
                    break;

                default:
                    data = button - 3;
                    inputs = new InputWrapper[] { InputSimulator.MouseWrapper(MouseEventFlags.XDown, data) };
                    inputs = new InputWrapper[] { InputSimulator.MouseWrapper(MouseEventFlags.XUp, data) };
                    break;
            }
        }
    }
}