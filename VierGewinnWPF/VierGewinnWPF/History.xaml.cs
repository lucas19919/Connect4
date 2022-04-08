using System;
using System.Collections.Generic;
using System.Windows;

namespace VierGewinntWPF
{
    public partial class History : Window
    {
        public History()
        {
            InitializeComponent();
        }

        public void GetMatches(List<String> Results)
        {
            foreach (String Result in Results)
                this.MatchResults.Text += "\nResult: " + Result;
        }
    }
}
