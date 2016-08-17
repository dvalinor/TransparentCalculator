using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TransparentCalculator {
    class InputHandler {
        public static void HandleInput(Window win, KeyEventArgs e) {
            switch (e.Key) {
                case Key.Up:
                    if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)) {
                        // Increase transparency / decrease opacity
                        if (win.Opacity > 0.1) {
                            win.Opacity -= 0.05;
                        }
                    } else if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)) {
                        // Move up
                        win.Top -= 8;
                    } else {
                        // Increase window size
                        win.Height += 8;
                        win.Width += 8;
                    }
                    break;
                case Key.Down:
                    if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)) {
                        // Decrease transparency / increase opacity
                        if (win.Opacity < 1) {
                            win.Opacity += 0.05;
                        }
                    } else if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)) {
                        // Move down
                        win.Top += 8;
                    } else {
                        // Decrease window size
                        win.Height -= 8;
                        win.Width -= 8;
                    }
                    break;
                case Key.Left:
                    if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)) {
                        // Move left
                        win.Left -= 8;
                    }
                    break;
                case Key.Right:
                    if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)) {
                        // Move right
                        win.Left += 8;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
