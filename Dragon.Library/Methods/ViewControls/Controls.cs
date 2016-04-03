﻿using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Dragon.Library.Methods.ViewControls
{
   public class Controls
    {
        /// <summary>
        /// Will Set and Remove Child element
        /// </summary>
        /// <param name="AddUE"></param>
        /// <param name="Col"></param>
        /// <param name="Row"></param>
        /// <param name="Child"></param>
        public static void SetUIElementAndRemovParent(UIElement AddUE, int Col, int Row, UserControl Child)
        {           
            Grid.SetColumn(AddUE, Col);
            Grid.SetRow(AddUE, Row);
            ((Panel)Child.Parent).Children.Add(AddUE);
            ((Panel)Child.Parent).Children.Remove(Child);
        }
        /// <summary>
        /// List of Multiple elements to be added
        /// </summary>
        /// <param name="AddUE"></param>
        /// <param name="Child"></param>
        public static void SetUIElementAndRemovParent(List<Objects.MultiUIElm> AddUE, UserControl Child)
        {
            foreach (var a in AddUE)
            {
                Grid.SetColumn(a.Element, a.Col);
                Grid.SetRow(a.Element, a.Row);
                ((Panel)Child.Parent).Children.Add(a.Element);
            }
            ((Panel)Child.Parent).Children.Remove(Child);
        }
        public static void SetUIElement(UIElement AddUE, int Col, int Row, UserControl Child)
        {
            //Issue here when there are no loaded elements
            List<FrameworkElement> lstElemnt = (((UIElementCollection)((Panel)Child.Parent).Children).Cast<FrameworkElement>().ToList()) ?? new List<FrameworkElement>();
            foreach (var c in lstElemnt.OfType<Control>())
            {
                if (Grid.GetColumn(c) == Col && Grid.GetRow(c) == Row)
                    ((Panel)Child.Parent).Children.Remove(c);
            }
            Grid.SetColumn(AddUE, Col);
            Grid.SetRow(AddUE, Row);
            ((Panel)Child.Parent).Children.Add(AddUE);
        }
        public static void SetUIElement(UIElement AddUE, int Col, int Row, Grid main)
        {
            //Issue here when there are no loaded elements
            Grid.SetColumn(AddUE, Col);
            Grid.SetRow(AddUE, Row);
            main.Children.Add(AddUE);
        }
    }
}
