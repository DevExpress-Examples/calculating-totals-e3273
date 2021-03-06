﻿using System.Windows;
using DevExpress.Data;
using DevExpress.Xpf.Grid;

namespace DXTreeList_Totals {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            treeListControl1.ItemsSource = Stuff.GetStuff();
            treeListControl1.View.ExpandAllNodes();
            CreateTotal("Age", SummaryItemType.Min);
            CreateTotal("Age", SummaryItemType.Max);
            CreateTotal("Age", SummaryItemType.Average);
        }

        private void CreateTotal(string fieldName, SummaryItemType summaryType) {
            TreeListSummaryItem total = new TreeListSummaryItem() {
                FieldName = fieldName,
                SummaryType = summaryType,
                ShowInColumn = fieldName
            };
            treeListControl1.TotalSummary.Add(total);
        }
    }
}
