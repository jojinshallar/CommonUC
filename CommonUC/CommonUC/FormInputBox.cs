using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommonUC
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CommonUC"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CommonUC;assembly=CommonUC"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误:
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:FormInputBox/>
    ///
    /// </summary>
    public class FormInputBox : TextBox
    {  /// <summary>
        /// 输入框左边的标签
        /// </summary>
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Label.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(FormInputBox), new PropertyMetadata(""));


        /// <summary>
        /// 右边输入框的边框大小
        /// </summary>
        public Thickness InnerBorderThickness
        {
            get { return (Thickness)GetValue(InnerBorderThicknessProperty); }
            set { SetValue(InnerBorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for InnerBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InnerBorderThicknessProperty =
            DependencyProperty.Register("InnerBorderThickness", typeof(Thickness), typeof(FormInputBox), new PropertyMetadata(new Thickness(1)));





        public Brush InnerBorderBrush
        {
            get { return (Brush)GetValue(InnerBorderBrushProperty); }
            set { SetValue(InnerBorderBrushProperty, value); }
        }


        // Using a DependencyProperty as the backing store for InnerBorderBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InnerBorderBrushProperty =
            DependencyProperty.Register("InnerBorderBrush", typeof(Brush), typeof(FormInputBox), new PropertyMetadata(Brushes.Gray));




        /// <summary>
        /// Label区域的宽度
        /// 属性来自Grid的ColumnDefinition
        /// </summary>
        public GridLength LabelWidth
        {
            get { return (GridLength)GetValue(LabelWidthProperty); }
            set { SetValue(LabelWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelWidthProperty =
            DependencyProperty.Register("LabelWidth", typeof(GridLength), typeof(FormInputBox), new PropertyMetadata(new GridLength(0, GridUnitType.Auto)));



        /// <summary>
        /// 多个本组件在一个容器内时，可以分享Label区域的宽度
        /// 设置相同名即可，不过还需在父容器中添加Grid.IsSharedSizeScope为True
        /// 属性来自Grid的ColumnDefinition
        /// </summary>
        public string SharedSizeGroup
        {
            get { return (string)GetValue(SharedSizeGroupProperty); }
            set { SetValue(SharedSizeGroupProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SharedSizeGroup.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SharedSizeGroupProperty =
            DependencyProperty.Register("SharedSizeGroup", typeof(string), typeof(FormInputBox), new PropertyMetadata(null));


        static FormInputBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FormInputBox), new FrameworkPropertyMetadata(typeof(FormInputBox)));
        }
    }
}
