using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BRS.ProgramLogic;

namespace BRS {
    public partial class BRS : Form {
        private AbstractCache cache;

        public BRS() {
            InitializeComponent();
            cacheSizeComboBox.SelectedIndex = 0;
            replacementPolicyComboBox.SelectedIndex = 0;
            numberOfSetsComboBox.SelectedIndex = 0;
        }

        private void help_Click(object sender, EventArgs e) { 
            System.Diagnostics.Process.Start("http://www.ecs.umass.edu/ece/koren/architecture/Cache/frame1.htm");
        }

        private void showCache_Click(object sender, EventArgs e) {


            var cacheSize = int.Parse(cacheSizeComboBox.SelectedItem.ToString());
            var numOfSets = int.Parse(numberOfSetsComboBox.SelectedItem.ToString());
            var dataTable = new DataTable();
            dataGridView.DataSource = dataTable;

            switch (replacementPolicyComboBox.SelectedIndex) {
                case 0:
                    cache = new LruCache(cacheSize, numOfSets);
                    break;
                case 1:
                    cache = new FifoCache(cacheSize, numOfSets);
                    break;
                case 2:
                    cache = new RandomCache(cacheSize, numOfSets);
                    break;
            }

            for (int i = 0; i < cacheSize / numOfSets; i++) { 
                dataTable.Columns.Add(i.ToString());
            }

            foreach (DataGridViewColumn column in dataGridView.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            for (int i = 0; i < numOfSets; i++) {
                DataRow row = dataTable.NewRow();
                for (int j = 0; j < cacheSize / numOfSets; j++) {
                    row[j] = "---";
                }

                dataTable.Rows.Add(row);
                dataGridView.Rows[i].HeaderCell.Value = "Set " + i;
            }

 

            String[] inputAddresses = (inputBox.Text.Trim()).Split(' ');
            for (int i = 0; i < inputAddresses.Length; i++) {
                int address = 0;
                try {
                    address = int.Parse(inputAddresses[i]);
                }
                catch (FormatException fe) { }

            
                int cacheResult = cache.CheckAddress(address);
                int setIndex = cache.ComputeSetFromAddress(address);
                int blockIndex = cache.GetIndexOfPreviouslyAccessedBlock();
                dataTable.Rows[setIndex][blockIndex] =
                    address.ToString() + " - " + cache.ComputeTagFromAddress(address).ToString();
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                switch (cacheResult) {
                    case AbstractCache.Hit:
                        style.BackColor = Color.Green;
                        break;
                    case AbstractCache.CompulsoryMiss:
                        style.BackColor = Color.LightBlue;
                        break;
                    case AbstractCache.ConflictMiss:
                        style.BackColor = Color.Orange;
                        break;
                    case AbstractCache.CapacityMiss:
                        style.BackColor = Color.Yellow;
                        break;
                }

                dataGridView.Rows[setIndex].Cells[blockIndex].Style = style;

             

                queriesLabel.Text = (cache.TotalQueries()).ToString();
                missesLabel.Text = cache.TotalMisses().ToString();
                missRateLabel.Text = Math.Round((Convert.ToDouble(cache.TotalMisses()) * 100
                                                 / cache.TotalQueries()), 2).ToString() + "%";
                hitRateLabel.Text = Math.Round((Convert.ToDouble(cache.NumHits) * 100
                                                / cache.TotalQueries()), 2).ToString() + "%";
                compulsoryMissesLabel.Text = cache.NumCompulsoryMisses.ToString();
                capacityMissesLabel.Text = cache.NumCapacityMisses.ToString();
                conflictMissesLabel.Text = cache.NumConflictMisses.ToString();
                cacheHitsLabel.Text = cache.NumHits.ToString();


            }
        }

        private void cacheSize_SelectedIndexChanged(object sender, EventArgs e) {
     
            var numOfSetsOptions = new List<int>();
            for (int i = 0; i <= cacheSizeComboBox.SelectedIndex + 2; i++) {
                numOfSetsOptions.Add(1 << i);
            }

            numberOfSetsComboBox.DataSource = numOfSetsOptions;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e) {
            dataGridView.CurrentCell.Selected = false; 
        }

        private void BRS_Load(object sender, EventArgs e)
        {

        }

        private void numberOfSetsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}