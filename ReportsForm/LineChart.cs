﻿using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsForm
{
    public partial class LineChart : Form
    {
        public LineChart()
        {
            InitializeComponent();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection piechartData = new SeriesCollection
    {
        new PieSeries
        {
            Title = "Quan dai",
            Values = new ChartValues<double> {35},
            DataLabels = true,
            LabelPoint = labelPoint
        },
        new PieSeries
        {
            Title = "Ao khoac",
            Values = new ChartValues<double> {25},
            DataLabels = true,
            LabelPoint = labelPoint
        },
        new PieSeries
        {
            Title = "Ao thun",
            Values = new ChartValues<double> {25},
            DataLabels = true,
            LabelPoint = labelPoint
        }
    };

            // You can add a new item dinamically with the add method of the collection
            // Useful when you define the data dinamically and not statically
            piechartData.Add(
                new PieSeries
                {
                    Title = "So mi",
                    Values = new ChartValues<double> { 15 },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = System.Windows.Media.Brushes.Gray
                }
            );

            // Define the collection of Values to display in the Pie Chart
            pieChart1.Series = piechartData;

            // Set the legend location to appear in the Right side of the chart
            pieChart1.LegendLocation = LegendLocation.Right;
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }

      
           
  
}
