using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selection_Sort_Visualizer
{
    public partial class SelectionForm : Form
    {
        private int[] array;
        private int minIndex;
        private int i;
        private bool haveMinIndex;

        public SelectionForm()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            labelSwap.Visible = false;
            if(array == null)
            {
                i = -1;
                haveMinIndex = false;

                array = textBoxNums.Text
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => int.Parse(s))
                    .ToArray();
                textBoxNums.Visible = false;
            }
            Invalidate();
            Application.DoEvents();
            Graphics graphics = CreateGraphics();
            
            if(i < array.Length)
            {
                if (haveMinIndex)
                {
                    int temp = array[minIndex];
                    array[minIndex] = array[i];
                    array[i] = temp;

                    DrawBoxes(array, graphics, ClientRectangle, Enumerable.Range(0, i + 1).ToArray(), -1, -1);
                    haveMinIndex = false;
                }
                else
                {
                    i++;
                    minIndex = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < array[minIndex])
                        {
                            minIndex = j;
                        }
                    }
                    DrawBoxes(array, graphics, ClientRectangle, Enumerable.Range(0, i + 1).ToArray(), minIndex, i);
                    if(minIndex != i)
                    {
                        labelSwap.Visible = true;
                    }
                    
                    if (i == array.Length - 1)
                    {
                        return;
                    }
                  
                    haveMinIndex = true;
                }
            }
            else
            {
                array = null;
                textBoxNums.Visible = true;
            }          
        }

        protected void DrawBoxes(int[] array, Graphics graphics, Rectangle clientRectangle, int[] blueRange, int min, int swap)
        {
            for(int index = 0; index < array.Length; index++)
            {
                RectangleF rectangleF = new RectangleF(
                    clientRectangle.Width / 30 + (clientRectangle.Width / 15) * index + 6 * index,
                    clientRectangle.Height / 4 + 90,
                    clientRectangle.Width / 15,
                    clientRectangle.Height / 7);

                graphics.FillRectangle(Brushes.White, rectangleF);

                if (blueRange.Contains(index))
                {
                    graphics.FillRectangle(Brushes.LightBlue, rectangleF);
                }
                if (swap == index)
                {
                    graphics.FillRectangle(Brushes.Pink, rectangleF);
                }
                if (min == index)
                {
                    graphics.FillRectangle(Brushes.Green, rectangleF);
                }
                
                graphics.DrawString(
                    array[index].ToString(),
                    new Font("Time New Rome", 16),
                    Brushes.Black,
                    new RectangleF(
                    clientRectangle.Width / 30 + (clientRectangle.Width / 15) * index + 6 * index,
                    clientRectangle.Height / 4 + 90 + 25,
                    clientRectangle.Width / 15,
                    clientRectangle.Height / 7 + 25),
                    StringFormat.GenericDefault);

                using(Pen pen = new Pen(Brushes.Black))
                {
                    graphics.DrawRectangle(pen, rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);
                }               
            }
        }
    }
}
