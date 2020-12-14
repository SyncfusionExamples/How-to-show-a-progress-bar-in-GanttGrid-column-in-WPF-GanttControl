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
using Syncfusion.Windows.Controls.Grid;
using System.Collections.ObjectModel;
using Syncfusion.Windows.Controls.Gantt;
using Syncfusion.Windows.Shared;

namespace Gantt_Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Gantt_Loaded(object sender, RoutedEventArgs e)
        {
            this.Gantt.GanttGrid.Loaded += GanttGrid_Loaded;
        }

        private void GanttGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var progressColumn = Gantt.GanttGrid.Columns[6];
            progressColumn.StyleInfo = new GridStyleInfo();
            progressColumn.StyleInfo.CellType = "DataBoundTemplate";
            progressColumn.StyleInfo.CellItemTemplateKey = "progressTemplate";

        }
    }
}
