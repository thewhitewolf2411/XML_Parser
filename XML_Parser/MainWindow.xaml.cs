﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Xml;
using Microsoft.Win32;

namespace XML_Parser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void LoadXml_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog OFN = new OpenFileDialog();
            OFN.Multiselect = true;
            OFN.Filter = "XML Files (*.xml;)|*.xml";
            if (OFN.ShowDialog() == true) {

                foreach (String files in OFN.FileNames)
                {
                    string Line = File.ReadAllText(files);
                    Line = Line.Replace("pagedata", "pgData");
                    xmlShow.Text = Line;
                    File.WriteAllText(files, Line);
                    
                    
                }

            }


        }
    }
}
