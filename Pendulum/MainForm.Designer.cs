
namespace Pendulum
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox groupBox_SystemParams;
            System.Windows.Forms.Label label_CoefViscosity;
            System.Windows.Forms.Label label_CoefFriction;
            System.Windows.Forms.Label label_CoefElasticity;
            System.Windows.Forms.Label label_Weight;
            System.Windows.Forms.GroupBox groupBox_SystemVisualization;
            System.Windows.Forms.GroupBox groupBox_GraphPhasePortrait;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.GroupBox groupBox_InitConditions;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label_Velocity;
            System.Windows.Forms.Label label_Position;
            System.Windows.Forms.Label label_countPortrets;
            System.Windows.Forms.Label label_step;
            System.Windows.Forms.GroupBox groupBox_phasePortrets;
            System.Windows.Forms.GroupBox groupBox_graphPeriodAmpl;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.numUpDown_CoefViscosity = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_CoefFriction = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_CoefElasticity = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_Weight = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_SystemVisualization = new System.Windows.Forms.PictureBox();
            this.chart_PhasePortrait = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numUpDown_stepTime = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_Velocity = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_Position = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_countPortrets = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_step = new System.Windows.Forms.NumericUpDown();
            this.chart_PeriodAmpl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonStartSolve = new System.Windows.Forms.Button();
            this.buttonStopSolve = new System.Windows.Forms.Button();
            this.button_genPhasePortrets = new System.Windows.Forms.Button();
            groupBox_SystemParams = new System.Windows.Forms.GroupBox();
            label_CoefViscosity = new System.Windows.Forms.Label();
            label_CoefFriction = new System.Windows.Forms.Label();
            label_CoefElasticity = new System.Windows.Forms.Label();
            label_Weight = new System.Windows.Forms.Label();
            groupBox_SystemVisualization = new System.Windows.Forms.GroupBox();
            groupBox_GraphPhasePortrait = new System.Windows.Forms.GroupBox();
            groupBox_InitConditions = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label_Velocity = new System.Windows.Forms.Label();
            label_Position = new System.Windows.Forms.Label();
            label_countPortrets = new System.Windows.Forms.Label();
            label_step = new System.Windows.Forms.Label();
            groupBox_phasePortrets = new System.Windows.Forms.GroupBox();
            groupBox_graphPeriodAmpl = new System.Windows.Forms.GroupBox();
            groupBox_SystemParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CoefViscosity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CoefFriction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CoefElasticity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Weight)).BeginInit();
            groupBox_SystemVisualization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SystemVisualization)).BeginInit();
            groupBox_GraphPhasePortrait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PhasePortrait)).BeginInit();
            groupBox_InitConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_stepTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Velocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Position)).BeginInit();
            groupBox_phasePortrets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_countPortrets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_step)).BeginInit();
            groupBox_graphPeriodAmpl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PeriodAmpl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_SystemParams
            // 
            groupBox_SystemParams.Controls.Add(this.numUpDown_CoefViscosity);
            groupBox_SystemParams.Controls.Add(label_CoefViscosity);
            groupBox_SystemParams.Controls.Add(label_CoefFriction);
            groupBox_SystemParams.Controls.Add(this.numUpDown_CoefFriction);
            groupBox_SystemParams.Controls.Add(this.numUpDown_CoefElasticity);
            groupBox_SystemParams.Controls.Add(label_CoefElasticity);
            groupBox_SystemParams.Controls.Add(label_Weight);
            groupBox_SystemParams.Controls.Add(this.numUpDown_Weight);
            groupBox_SystemParams.Location = new System.Drawing.Point(12, 518);
            groupBox_SystemParams.Name = "groupBox_SystemParams";
            groupBox_SystemParams.Size = new System.Drawing.Size(247, 225);
            groupBox_SystemParams.TabIndex = 1;
            groupBox_SystemParams.TabStop = false;
            groupBox_SystemParams.Text = "Параметры системы:";
            // 
            // numUpDown_CoefViscosity
            // 
            this.numUpDown_CoefViscosity.DecimalPlaces = 3;
            this.numUpDown_CoefViscosity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_CoefViscosity.Location = new System.Drawing.Point(166, 97);
            this.numUpDown_CoefViscosity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_CoefViscosity.Name = "numUpDown_CoefViscosity";
            this.numUpDown_CoefViscosity.Size = new System.Drawing.Size(75, 20);
            this.numUpDown_CoefViscosity.TabIndex = 17;
            this.numUpDown_CoefViscosity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_CoefViscosity.Value = new decimal(new int[] {
            10,
            0,
            0,
            196608});
            // 
            // label_CoefViscosity
            // 
            label_CoefViscosity.AutoSize = true;
            label_CoefViscosity.Location = new System.Drawing.Point(35, 102);
            label_CoefViscosity.Name = "label_CoefViscosity";
            label_CoefViscosity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label_CoefViscosity.Size = new System.Drawing.Size(125, 13);
            label_CoefViscosity.TabIndex = 16;
            label_CoefViscosity.Text = "Коэф. вязкости среды:";
            // 
            // label_CoefFriction
            // 
            label_CoefFriction.AutoSize = true;
            label_CoefFriction.Location = new System.Drawing.Point(21, 76);
            label_CoefFriction.Name = "label_CoefFriction";
            label_CoefFriction.Size = new System.Drawing.Size(139, 13);
            label_CoefFriction.TabIndex = 15;
            label_CoefFriction.Text = "Коэф. трения о стержень:";
            label_CoefFriction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numUpDown_CoefFriction
            // 
            this.numUpDown_CoefFriction.DecimalPlaces = 3;
            this.numUpDown_CoefFriction.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_CoefFriction.Location = new System.Drawing.Point(166, 71);
            this.numUpDown_CoefFriction.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_CoefFriction.Name = "numUpDown_CoefFriction";
            this.numUpDown_CoefFriction.Size = new System.Drawing.Size(75, 20);
            this.numUpDown_CoefFriction.TabIndex = 14;
            this.numUpDown_CoefFriction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_CoefFriction.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numUpDown_CoefElasticity
            // 
            this.numUpDown_CoefElasticity.DecimalPlaces = 3;
            this.numUpDown_CoefElasticity.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDown_CoefElasticity.Location = new System.Drawing.Point(166, 45);
            this.numUpDown_CoefElasticity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDown_CoefElasticity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_CoefElasticity.Name = "numUpDown_CoefElasticity";
            this.numUpDown_CoefElasticity.Size = new System.Drawing.Size(75, 20);
            this.numUpDown_CoefElasticity.TabIndex = 13;
            this.numUpDown_CoefElasticity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_CoefElasticity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_CoefElasticity
            // 
            label_CoefElasticity.AutoSize = true;
            label_CoefElasticity.Location = new System.Drawing.Point(15, 47);
            label_CoefElasticity.Name = "label_CoefElasticity";
            label_CoefElasticity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label_CoefElasticity.Size = new System.Drawing.Size(145, 13);
            label_CoefElasticity.TabIndex = 12;
            label_CoefElasticity.Text = "Коэф. жесткости пружины:";
            // 
            // label_Weight
            // 
            label_Weight.AutoSize = true;
            label_Weight.Location = new System.Drawing.Point(117, 21);
            label_Weight.Name = "label_Weight";
            label_Weight.Size = new System.Drawing.Size(43, 13);
            label_Weight.TabIndex = 11;
            label_Weight.Text = "Масса:";
            label_Weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numUpDown_Weight
            // 
            this.numUpDown_Weight.Location = new System.Drawing.Point(166, 19);
            this.numUpDown_Weight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_Weight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_Weight.Name = "numUpDown_Weight";
            this.numUpDown_Weight.Size = new System.Drawing.Size(75, 20);
            this.numUpDown_Weight.TabIndex = 10;
            this.numUpDown_Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_Weight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox_SystemVisualization
            // 
            groupBox_SystemVisualization.Controls.Add(this.pictureBox_SystemVisualization);
            groupBox_SystemVisualization.Location = new System.Drawing.Point(12, 12);
            groupBox_SystemVisualization.Name = "groupBox_SystemVisualization";
            groupBox_SystemVisualization.Size = new System.Drawing.Size(500, 500);
            groupBox_SystemVisualization.TabIndex = 2;
            groupBox_SystemVisualization.TabStop = false;
            groupBox_SystemVisualization.Text = "Визуальное представление системы:";
            // 
            // pictureBox_SystemVisualization
            // 
            this.pictureBox_SystemVisualization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_SystemVisualization.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_SystemVisualization.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_SystemVisualization.Location = new System.Drawing.Point(12, 19);
            this.pictureBox_SystemVisualization.Name = "pictureBox_SystemVisualization";
            this.pictureBox_SystemVisualization.Size = new System.Drawing.Size(475, 475);
            this.pictureBox_SystemVisualization.TabIndex = 0;
            this.pictureBox_SystemVisualization.TabStop = false;
            // 
            // groupBox_GraphPhasePortrait
            // 
            groupBox_GraphPhasePortrait.Controls.Add(this.chart_PhasePortrait);
            groupBox_GraphPhasePortrait.Location = new System.Drawing.Point(518, 12);
            groupBox_GraphPhasePortrait.Name = "groupBox_GraphPhasePortrait";
            groupBox_GraphPhasePortrait.Size = new System.Drawing.Size(500, 500);
            groupBox_GraphPhasePortrait.TabIndex = 4;
            groupBox_GraphPhasePortrait.TabStop = false;
            groupBox_GraphPhasePortrait.Text = "График фазового портрета:";
            // 
            // chart_PhasePortrait
            // 
            this.chart_PhasePortrait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.Maximum = 6D;
            chartArea1.AxisX.Minimum = -6D;
            chartArea1.AxisY.Interval = 10D;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = -100D;
            chartArea1.Name = "ChartArea1";
            this.chart_PhasePortrait.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Name = "Legend1";
            this.chart_PhasePortrait.Legends.Add(legend1);
            this.chart_PhasePortrait.Location = new System.Drawing.Point(6, 19);
            this.chart_PhasePortrait.Name = "chart_PhasePortrait";
            this.chart_PhasePortrait.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Фазовые портреты";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Фазовый портрет 2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Фазовый портрет 3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Blue;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Фазовый портрет 4";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Blue;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Фазовый портрет 5";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Blue;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Фазовый портрет 6";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Blue;
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Фазовый портрет 7";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Blue;
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Фазовый портрет 8";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Blue;
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.Name = "Фазовый портрет 9";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Blue;
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.Name = "Фазовый портрет 10";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.Red;
            series11.Legend = "Legend1";
            series11.Name = "Фазовая траектория";
            this.chart_PhasePortrait.Series.Add(series1);
            this.chart_PhasePortrait.Series.Add(series2);
            this.chart_PhasePortrait.Series.Add(series3);
            this.chart_PhasePortrait.Series.Add(series4);
            this.chart_PhasePortrait.Series.Add(series5);
            this.chart_PhasePortrait.Series.Add(series6);
            this.chart_PhasePortrait.Series.Add(series7);
            this.chart_PhasePortrait.Series.Add(series8);
            this.chart_PhasePortrait.Series.Add(series9);
            this.chart_PhasePortrait.Series.Add(series10);
            this.chart_PhasePortrait.Series.Add(series11);
            this.chart_PhasePortrait.Size = new System.Drawing.Size(488, 475);
            this.chart_PhasePortrait.TabIndex = 2;
            this.chart_PhasePortrait.Text = "chart_PhasePortrait";
            // 
            // groupBox_InitConditions
            // 
            groupBox_InitConditions.Controls.Add(this.numUpDown_stepTime);
            groupBox_InitConditions.Controls.Add(label1);
            groupBox_InitConditions.Controls.Add(this.numUpDown_Velocity);
            groupBox_InitConditions.Controls.Add(label_Velocity);
            groupBox_InitConditions.Controls.Add(label_Position);
            groupBox_InitConditions.Controls.Add(this.numUpDown_Position);
            groupBox_InitConditions.Location = new System.Drawing.Point(265, 518);
            groupBox_InitConditions.Name = "groupBox_InitConditions";
            groupBox_InitConditions.Size = new System.Drawing.Size(247, 117);
            groupBox_InitConditions.TabIndex = 5;
            groupBox_InitConditions.TabStop = false;
            groupBox_InitConditions.Text = "Начальные условия:";
            // 
            // numUpDown_stepTime
            // 
            this.numUpDown_stepTime.DecimalPlaces = 3;
            this.numUpDown_stepTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numUpDown_stepTime.Location = new System.Drawing.Point(163, 69);
            this.numUpDown_stepTime.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_stepTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numUpDown_stepTime.Name = "numUpDown_stepTime";
            this.numUpDown_stepTime.Size = new System.Drawing.Size(75, 20);
            this.numUpDown_stepTime.TabIndex = 11;
            this.numUpDown_stepTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_stepTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(47, 71);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label1.Size = new System.Drawing.Size(110, 13);
            label1.TabIndex = 10;
            label1.Text = "Шаг по времени (dt):";
            // 
            // numUpDown_Velocity
            // 
            this.numUpDown_Velocity.DecimalPlaces = 2;
            this.numUpDown_Velocity.Location = new System.Drawing.Point(163, 45);
            this.numUpDown_Velocity.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numUpDown_Velocity.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.numUpDown_Velocity.Name = "numUpDown_Velocity";
            this.numUpDown_Velocity.Size = new System.Drawing.Size(75, 20);
            this.numUpDown_Velocity.TabIndex = 9;
            this.numUpDown_Velocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Velocity
            // 
            label_Velocity.AutoSize = true;
            label_Velocity.Location = new System.Drawing.Point(62, 47);
            label_Velocity.Name = "label_Velocity";
            label_Velocity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label_Velocity.Size = new System.Drawing.Size(95, 13);
            label_Velocity.TabIndex = 8;
            label_Velocity.Text = "Скорость (по oX):";
            // 
            // label_Position
            // 
            label_Position.AutoSize = true;
            label_Position.Location = new System.Drawing.Point(52, 21);
            label_Position.Name = "label_Position";
            label_Position.Size = new System.Drawing.Size(105, 13);
            label_Position.TabIndex = 7;
            label_Position.Text = "Положение (по oX):";
            label_Position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numUpDown_Position
            // 
            this.numUpDown_Position.DecimalPlaces = 2;
            this.numUpDown_Position.Location = new System.Drawing.Point(163, 19);
            this.numUpDown_Position.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown_Position.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numUpDown_Position.Name = "numUpDown_Position";
            this.numUpDown_Position.Size = new System.Drawing.Size(75, 20);
            this.numUpDown_Position.TabIndex = 6;
            this.numUpDown_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_Position.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label_countPortrets
            // 
            label_countPortrets.AutoSize = true;
            label_countPortrets.Location = new System.Drawing.Point(58, 21);
            label_countPortrets.Name = "label_countPortrets";
            label_countPortrets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label_countPortrets.Size = new System.Drawing.Size(99, 13);
            label_countPortrets.TabIndex = 14;
            label_countPortrets.Text = "Кол-во портретов:";
            // 
            // label_step
            // 
            label_step.AutoSize = true;
            label_step.Location = new System.Drawing.Point(127, 47);
            label_step.Name = "label_step";
            label_step.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label_step.Size = new System.Drawing.Size(30, 13);
            label_step.TabIndex = 16;
            label_step.Text = "Шаг:";
            // 
            // groupBox_phasePortrets
            // 
            groupBox_phasePortrets.Controls.Add(label_countPortrets);
            groupBox_phasePortrets.Controls.Add(this.numUpDown_countPortrets);
            groupBox_phasePortrets.Controls.Add(this.numUpDown_step);
            groupBox_phasePortrets.Controls.Add(label_step);
            groupBox_phasePortrets.Location = new System.Drawing.Point(265, 641);
            groupBox_phasePortrets.Name = "groupBox_phasePortrets";
            groupBox_phasePortrets.Size = new System.Drawing.Size(247, 102);
            groupBox_phasePortrets.TabIndex = 19;
            groupBox_phasePortrets.TabStop = false;
            groupBox_phasePortrets.Text = "Параметры отрисовки фазовых портретов:";
            // 
            // numUpDown_countPortrets
            // 
            this.numUpDown_countPortrets.Location = new System.Drawing.Point(163, 19);
            this.numUpDown_countPortrets.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_countPortrets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_countPortrets.Name = "numUpDown_countPortrets";
            this.numUpDown_countPortrets.Size = new System.Drawing.Size(75, 20);
            this.numUpDown_countPortrets.TabIndex = 15;
            this.numUpDown_countPortrets.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_countPortrets.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numUpDown_step
            // 
            this.numUpDown_step.DecimalPlaces = 2;
            this.numUpDown_step.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_step.Location = new System.Drawing.Point(163, 45);
            this.numUpDown_step.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown_step.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_step.Name = "numUpDown_step";
            this.numUpDown_step.Size = new System.Drawing.Size(75, 20);
            this.numUpDown_step.TabIndex = 17;
            this.numUpDown_step.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_step.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // groupBox_graphPeriodAmpl
            // 
            groupBox_graphPeriodAmpl.Controls.Add(this.chart_PeriodAmpl);
            groupBox_graphPeriodAmpl.Location = new System.Drawing.Point(518, 518);
            groupBox_graphPeriodAmpl.Name = "groupBox_graphPeriodAmpl";
            groupBox_graphPeriodAmpl.Size = new System.Drawing.Size(500, 256);
            groupBox_graphPeriodAmpl.TabIndex = 20;
            groupBox_graphPeriodAmpl.TabStop = false;
            groupBox_graphPeriodAmpl.Text = "Исследование зависимости периода колебания тела от амплитуды:";
            // 
            // chart_PeriodAmpl
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.Maximum = 5D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "Аплитуда";
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "Период колебаний";
            chartArea2.Name = "ChartArea1";
            this.chart_PeriodAmpl.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Name = "Legend1";
            this.chart_PeriodAmpl.Legends.Add(legend2);
            this.chart_PeriodAmpl.Location = new System.Drawing.Point(6, 19);
            this.chart_PeriodAmpl.Name = "chart_PeriodAmpl";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series12.Legend = "Legend1";
            series12.Name = "T(Xmax)";
            this.chart_PeriodAmpl.Series.Add(series12);
            this.chart_PeriodAmpl.Size = new System.Drawing.Size(488, 231);
            this.chart_PeriodAmpl.TabIndex = 18;
            this.chart_PeriodAmpl.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.OnTickTimer);
            // 
            // buttonStartSolve
            // 
            this.buttonStartSolve.Location = new System.Drawing.Point(12, 749);
            this.buttonStartSolve.Name = "buttonStartSolve";
            this.buttonStartSolve.Size = new System.Drawing.Size(120, 25);
            this.buttonStartSolve.TabIndex = 0;
            this.buttonStartSolve.Text = "Начать";
            this.buttonStartSolve.UseVisualStyleBackColor = true;
            this.buttonStartSolve.Click += new System.EventHandler(this.OnClickButtonStartSolve);
            // 
            // buttonStopSolve
            // 
            this.buttonStopSolve.Enabled = false;
            this.buttonStopSolve.Location = new System.Drawing.Point(139, 749);
            this.buttonStopSolve.Name = "buttonStopSolve";
            this.buttonStopSolve.Size = new System.Drawing.Size(120, 25);
            this.buttonStopSolve.TabIndex = 6;
            this.buttonStopSolve.Text = "Остановить";
            this.buttonStopSolve.UseVisualStyleBackColor = true;
            this.buttonStopSolve.Click += new System.EventHandler(this.OnClickButtonStopSolve);
            // 
            // button_genPhasePortrets
            // 
            this.button_genPhasePortrets.Location = new System.Drawing.Point(265, 749);
            this.button_genPhasePortrets.Name = "button_genPhasePortrets";
            this.button_genPhasePortrets.Size = new System.Drawing.Size(247, 25);
            this.button_genPhasePortrets.TabIndex = 10;
            this.button_genPhasePortrets.Text = "Сгенерировать фазовые портреты";
            this.button_genPhasePortrets.UseVisualStyleBackColor = true;
            this.button_genPhasePortrets.Click += new System.EventHandler(this.OnClickGenPhasePortrets);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1027, 786);
            this.Controls.Add(groupBox_graphPeriodAmpl);
            this.Controls.Add(groupBox_phasePortrets);
            this.Controls.Add(this.button_genPhasePortrets);
            this.Controls.Add(this.buttonStopSolve);
            this.Controls.Add(groupBox_InitConditions);
            this.Controls.Add(groupBox_GraphPhasePortrait);
            this.Controls.Add(groupBox_SystemVisualization);
            this.Controls.Add(groupBox_SystemParams);
            this.Controls.Add(this.buttonStartSolve);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ИТФИ ННГУ | Задание 1";
            this.Load += new System.EventHandler(this.OnLoadMainForm);
            groupBox_SystemParams.ResumeLayout(false);
            groupBox_SystemParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CoefViscosity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CoefFriction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CoefElasticity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Weight)).EndInit();
            groupBox_SystemVisualization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SystemVisualization)).EndInit();
            groupBox_GraphPhasePortrait.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_PhasePortrait)).EndInit();
            groupBox_InitConditions.ResumeLayout(false);
            groupBox_InitConditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_stepTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Velocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Position)).EndInit();
            groupBox_phasePortrets.ResumeLayout(false);
            groupBox_phasePortrets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_countPortrets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_step)).EndInit();
            groupBox_graphPeriodAmpl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_PeriodAmpl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonStartSolve;
        private System.Windows.Forms.PictureBox pictureBox_SystemVisualization;
        private System.Windows.Forms.NumericUpDown numUpDown_Velocity;
        private System.Windows.Forms.NumericUpDown numUpDown_Position;
        private System.Windows.Forms.NumericUpDown numUpDown_CoefViscosity;
        private System.Windows.Forms.NumericUpDown numUpDown_CoefFriction;
        private System.Windows.Forms.NumericUpDown numUpDown_CoefElasticity;
        private System.Windows.Forms.NumericUpDown numUpDown_Weight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_PhasePortrait;
        private System.Windows.Forms.Button buttonStopSolve;
        private System.Windows.Forms.Button button_genPhasePortrets;
        private System.Windows.Forms.NumericUpDown numUpDown_stepTime;
        private System.Windows.Forms.NumericUpDown numUpDown_countPortrets;
        private System.Windows.Forms.NumericUpDown numUpDown_step;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_PeriodAmpl;
    }
}

