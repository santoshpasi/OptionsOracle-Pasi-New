/*
 * OptionsOracle
 * Copyright 2006-2012 SamoaSky (Shlomo Shachar & Oren Moshe)
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OptionsOracle.Update;

namespace OptionsOracle.Forms
{
    public partial class UpgradeForm : Form
    {
        public UpgradeForm(List<UpdateInfo> info)
        {
            InitializeComponent();

            if (info != null)
                upgradeListDataGridView.DataSource = info;

            UpdateControl.EnableElevateIcon(upgradeButton);
        }

        public static DialogResult Show(List<UpdateInfo> info)
        {
            return new UpgradeForm(info).ShowDialog();
        }
    }
}
