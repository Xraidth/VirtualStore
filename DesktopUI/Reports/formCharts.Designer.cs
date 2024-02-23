namespace DesktopUI.Reports
{
    partial class formCharts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chcChartControl = new Syncfusion.Windows.Forms.Chart.ChartControl();
            SuspendLayout();
            // 
            // chcChartControl
            // 
            chcChartControl.ChartArea.CursorLocation = new Point(0, 0);
            chcChartControl.ChartArea.CursorReDraw = false;
            chcChartControl.Dock = DockStyle.Fill;
            chcChartControl.IsWindowLess = false;
            // 
            // 
            // 
            chcChartControl.Legend.Location = new Point(431, 75);
            chcChartControl.Localize = null;
            chcChartControl.Location = new Point(0, 0);
            chcChartControl.Name = "chcChartControl";
            chcChartControl.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chcChartControl.PrimaryXAxis.Margin = true;
            chcChartControl.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chcChartControl.PrimaryYAxis.Margin = true;
            chcChartControl.Size = new Size(540, 336);
            chcChartControl.TabIndex = 0;
            chcChartControl.Text = "chartControl";
            // 
            // 
            // 
            chcChartControl.Title.Name = "Default";
            chcChartControl.Titles.Add(chcChartControl.Title);
            chcChartControl.VisualTheme = "";
            // 
            // formCharts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 336);
            Controls.Add(chcChartControl);
            Name = "formCharts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formCharts";
            Load += formCharts_Load;
            KeyDown += formCharts_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chcChartControl;
    }
}