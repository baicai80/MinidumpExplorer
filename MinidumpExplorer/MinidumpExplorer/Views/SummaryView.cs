﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbgHelp.MinidumpFiles;
using MinidumpExplorer.Dialogs;

namespace MinidumpExplorer.Views
{
    public partial class SummaryView : BaseViewControl
    {
        private MiniDumpHeader _header;

        public SummaryView()
        {
            InitializeComponent();
        }

        public SummaryView(MiniDumpHeader header)
            : this()
        {
            _header = header;

            if (_header == null) return;

            lblNumberOfStreams.Text = _header.NumberOfStreams.ToString();
            lblDateTime.Text = _header.TimeDateStamp.ToString();
            lblFlags.Text = _header.Flags.ToString();

        }
    }
}