namespace AV1TSUx0003
{
    partial class Window
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
            this.InputLocation = new System.Windows.Forms.TextBox();
            this.OutputLocation = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Encoder = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConstantQuality = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Multithreading = new System.Windows.Forms.ComboBox();
            this.PixelFormat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tiles = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AudioBitrate = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Resolution = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.NumericUpDown();
            this.EncodingMode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.VideoBitrate = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConstantQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AudioBitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoBitrate)).BeginInit();
            this.SuspendLayout();
            // 
            // InputLocation
            // 
            this.InputLocation.Location = new System.Drawing.Point(13, 13);
            this.InputLocation.Name = "InputLocation";
            this.InputLocation.Size = new System.Drawing.Size(623, 20);
            this.InputLocation.TabIndex = 0;
            this.InputLocation.TextChanged += new System.EventHandler(this.InputLocation_TextChanged);
            // 
            // OutputLocation
            // 
            this.OutputLocation.Location = new System.Drawing.Point(13, 40);
            this.OutputLocation.Name = "OutputLocation";
            this.OutputLocation.Size = new System.Drawing.Size(623, 20);
            this.OutputLocation.TabIndex = 1;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(642, 10);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(75, 23);
            this.Input.TabIndex = 2;
            this.Input.Text = "Input";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(642, 40);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(75, 23);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(642, 298);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Encoder";
            // 
            // Encoder
            // 
            this.Encoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Encoder.FormattingEnabled = true;
            this.Encoder.Items.AddRange(new object[] {
            "libaom-av1",
            "rav1e"});
            this.Encoder.Location = new System.Drawing.Point(13, 79);
            this.Encoder.Name = "Encoder";
            this.Encoder.Size = new System.Drawing.Size(121, 21);
            this.Encoder.TabIndex = 0;
            this.Encoder.SelectedIndexChanged += new System.EventHandler(this.Encoder_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Constant Quality";
            // 
            // ConstantQuality
            // 
            this.ConstantQuality.Location = new System.Drawing.Point(523, 148);
            this.ConstantQuality.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.ConstantQuality.Name = "ConstantQuality";
            this.ConstantQuality.Size = new System.Drawing.Size(120, 20);
            this.ConstantQuality.TabIndex = 9;
            this.ConstantQuality.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ConstantQuality.ValueChanged += new System.EventHandler(this.ConstantQuality_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Multithreading";
            // 
            // Multithreading
            // 
            this.Multithreading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Multithreading.FormattingEnabled = true;
            this.Multithreading.Items.AddRange(new object[] {
            "False",
            "True"});
            this.Multithreading.Location = new System.Drawing.Point(394, 147);
            this.Multithreading.Name = "Multithreading";
            this.Multithreading.Size = new System.Drawing.Size(121, 21);
            this.Multithreading.TabIndex = 11;
            this.Multithreading.SelectedIndexChanged += new System.EventHandler(this.Multithreading_SelectedIndexChanged);
            // 
            // PixelFormat
            // 
            this.PixelFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PixelFormat.FormattingEnabled = true;
            this.PixelFormat.Items.AddRange(new object[] {
            "yuv420p      ",
            "yuv422p",
            "yuv444p",
            "yuv420p10le",
            "yuv422p10le",
            "yuv444p10le",
            "yuv420p12le",
            "yuv422p12le",
            "yuv444p12le"});
            this.PixelFormat.Location = new System.Drawing.Point(12, 145);
            this.PixelFormat.Name = "PixelFormat";
            this.PixelFormat.Size = new System.Drawing.Size(121, 21);
            this.PixelFormat.TabIndex = 12;
            this.PixelFormat.SelectedIndexChanged += new System.EventHandler(this.PixelFormat_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pixel Format";
            // 
            // Tiles
            // 
            this.Tiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tiles.FormattingEnabled = true;
            this.Tiles.Items.AddRange(new object[] {
            "4x1",
            "2x2"});
            this.Tiles.Location = new System.Drawing.Point(140, 145);
            this.Tiles.Name = "Tiles";
            this.Tiles.Size = new System.Drawing.Size(121, 21);
            this.Tiles.TabIndex = 14;
            this.Tiles.SelectedIndexChanged += new System.EventHandler(this.Tiles_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tiles";
            // 
            // AudioBitrate
            // 
            this.AudioBitrate.Location = new System.Drawing.Point(265, 147);
            this.AudioBitrate.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.AudioBitrate.Name = "AudioBitrate";
            this.AudioBitrate.Size = new System.Drawing.Size(120, 20);
            this.AudioBitrate.TabIndex = 16;
            this.AudioBitrate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.AudioBitrate.ValueChanged += new System.EventHandler(this.AudioBitrate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Audio Bitrate";
            // 
            // Resolution
            // 
            this.Resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Resolution.FormattingEnabled = true;
            this.Resolution.Items.AddRange(new object[] {
            "Source",
            "144",
            "240",
            "360",
            "480",
            "720",
            "1080",
            "1440",
            "2160"});
            this.Resolution.Location = new System.Drawing.Point(264, 78);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(121, 21);
            this.Resolution.TabIndex = 18;
            this.Resolution.SelectedIndexChanged += new System.EventHandler(this.Resolution_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Resolution";
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(520, 79);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(120, 20);
            this.Speed.TabIndex = 20;
            this.Speed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Speed.ValueChanged += new System.EventHandler(this.Speed_ValueChanged);
            // 
            // EncodingMode
            // 
            this.EncodingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodingMode.FormattingEnabled = true;
            this.EncodingMode.Items.AddRange(new object[] {
            "Constant Quality",
            "Constrained Quality",
            "Two-Pass",
            "Average Bitrate"});
            this.EncodingMode.Location = new System.Drawing.Point(138, 79);
            this.EncodingMode.Name = "EncodingMode";
            this.EncodingMode.Size = new System.Drawing.Size(121, 21);
            this.EncodingMode.TabIndex = 21;
            this.EncodingMode.SelectedIndexChanged += new System.EventHandler(this.EncodingMode_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Encoding Mode";
            // 
            // VideoBitrate
            // 
            this.VideoBitrate.Location = new System.Drawing.Point(392, 79);
            this.VideoBitrate.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.VideoBitrate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VideoBitrate.Name = "VideoBitrate";
            this.VideoBitrate.Size = new System.Drawing.Size(120, 20);
            this.VideoBitrate.TabIndex = 23;
            this.VideoBitrate.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.VideoBitrate.ValueChanged += new System.EventHandler(this.VideoBitrate_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(392, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Video Bitrate";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 333);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.VideoBitrate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EncodingMode);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Resolution);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AudioBitrate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tiles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PixelFormat);
            this.Controls.Add(this.Multithreading);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConstantQuality);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Encoder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.OutputLocation);
            this.Controls.Add(this.InputLocation);
            this.Name = "Window";
            this.Text = "AV1TSUx0003";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConstantQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AudioBitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoBitrate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputLocation;
        private System.Windows.Forms.TextBox OutputLocation;
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Encoder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ConstantQuality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Multithreading;
        private System.Windows.Forms.ComboBox PixelFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Tiles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown AudioBitrate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Resolution;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Speed;
        private System.Windows.Forms.ComboBox EncodingMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown VideoBitrate;
        private System.Windows.Forms.Label label10;
    }
}

