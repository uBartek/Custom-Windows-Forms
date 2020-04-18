using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Base
{
    public partial class GUI : Form
    {

        private int formSizeX, formSizeY, formPositionX, formPositionY, cursorPositionX, cursorPositionY, prevCursorPositionX, prevCursorPositionY;
        private bool fullSizeWindow = false;
        private bool resizeEnabled = false, moveFormEnable = false;

        public GUI()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {

            ///enables shadow behind Main Form
            ///copied from https://stackoverflow.com/questions/16493698/drop-shadow-on-a-borderless-winform

            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
          /*
           * disable moving
           */
            moveFormEnable = false;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
          /*
           * enables moving 
           */

            moveFormEnable = true;
            cursorPositionX = e.X;
            cursorPositionY = e.Y;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
          /*
           * move form when main panel is clicked
           */

            if (moveFormEnable)
            {
                this.SetDesktopLocation(MousePosition.X - cursorPositionX, MousePosition.Y - cursorPositionY);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            /*
             * close form
             */

            try
            {
                System.Windows.Forms.Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exit Error");
            }
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            /*
             *  make red highlight
             */
            buttonExit.BackColor = Color.FromArgb(203, 67, 53);
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            /*
             *  disable highlight
             */
            buttonExit.BackColor = Color.FromArgb(22, 22, 22);
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            /*
             *  maximize or restore form size
             */

            fullSizeWindow ^= true;

            if (fullSizeWindow)
            {
                formSizeX = this.Size.Width;
                formSizeY = this.Size.Height;
                formPositionX = this.Left;
                formPositionY = this.Top;

                this.buttonResize.BackgroundImage = global::GUI_Base.Properties.Resources.icons8_restore_down_24;
                this.Location = new Point(0, 0);
                this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            }
            else
            {
                this.buttonResize.BackgroundImage = global::GUI_Base.Properties.Resources.icons8_maximize_button_24;
                this.Location = new Point(formPositionX, formPositionY);
                this.Size = new Size(formSizeX, formSizeY);
            }

            //hide/show green borders
            panelRightForResize.Visible ^= true;
            panelLeftForResize.Visible ^= true;
            panelTopForResize.Visible ^= true;
            panelBottomForResize.Visible ^= true;
            panelRightTopCornerForResize1.Visible ^= true;
            panelRightTopCornerForResize2.Visible ^= true;
            panelRightBottomCornerForResize1.Visible ^= true;
            panelRightBottomCornerForResize2.Visible ^= true;
            panelLeftTopCornerForResize1.Visible ^= true;
            panelLeftTopCornerForResize2.Visible ^= true;
            panelLeftBottomCornerForResize1.Visible ^= true;
            panelLeftBottomCornerForResize2.Visible ^= true;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void borders_MouseDown(object sender, MouseEventArgs e)
        {
            /*
             * enable resizing
             */
            resizeEnabled = true;
        }

        private void borders_MouseMove(object sender, MouseEventArgs e)
        {
            if(resizeEnabled)
            {
                /*
                 *  resize
                 */

                if (sender.Equals(panelRightForResize))
                    resizeForm(ref e, false, true, false, false);

                else if (sender.Equals(panelLeftForResize))
                    resizeForm(ref e, false, true, false, true);

                else if (sender.Equals(panelTopForResize))
                    resizeForm(ref e, true, false, true, false);

                else if (sender.Equals(panelBottomForResize))
                    resizeForm(ref e, true, false, false, false);

                else if (sender.Equals(panelRightTopCornerForResize1) || sender.Equals(panelRightTopCornerForResize2))
                    resizeForm(ref e, true, true, true, false);

                else if (sender.Equals(panelRightBottomCornerForResize1) || sender.Equals(panelRightBottomCornerForResize2))
                    resizeForm(ref e, true, true, false, false);

                else if (sender.Equals(panelLeftTopCornerForResize1) || sender.Equals(panelLeftTopCornerForResize2))
                    resizeForm(ref e, true, true, true, true);

                else if (sender.Equals(panelLeftBottomCornerForResize1) || sender.Equals(panelLeftBottomCornerForResize2))
                    resizeForm(ref e, true, true, false, true);
            }
        }

        private void borders_MouseUp(object sender, MouseEventArgs e)
        {
            /*
             * disable resizing
             */
            resizeEnabled = false;
        }

        private void resizeForm(ref MouseEventArgs e, bool moveHorizontal, bool moveVertical, bool resizeFromTop, bool ResizeFromLeft)
        {
            if (moveVertical)
            {
                cursorPositionX -= e.X;

                if (ResizeFromLeft)
                {
                    int dCursorPositionX = MousePosition.X - prevCursorPositionX;
                    prevCursorPositionX = MousePosition.X;

                    this.Size = new Size(this.Size.Width - dCursorPositionX, this.Size.Height);
                    if (this.Size.Width > this.MinimumSize.Width)
                        this.SetDesktopLocation(MousePosition.X, this.Top);
                }
                else
                {
                    this.Size = new Size(formSizeX - cursorPositionX, this.Size.Height);
                }
            }
            if (moveHorizontal)
            {
                cursorPositionY -= e.Y;

                if (resizeFromTop)
                {
                    int dCursorPositionY = MousePosition.Y - prevCursorPositionY;
                    prevCursorPositionY = MousePosition.Y;

                    this.Size = new Size(this.Size.Width, this.Size.Height - dCursorPositionY);
                    if (this.Size.Height > this.MinimumSize.Height)
                        this.SetDesktopLocation(this.Left, MousePosition.Y);
                }
                else
                {
                    this.Size = new Size(this.Size.Width, formSizeY - cursorPositionY);
                }
            }
        }
    }
}
