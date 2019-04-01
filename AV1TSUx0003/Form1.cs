using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV1TSUx0003
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
            Encoder.SelectedIndex = 0;
            Speed.Minimum = 1;
            Speed.Maximum = 8;
            Multithreading.SelectedIndex = 1;
            PixelFormat.SelectedIndex = 3;
            Tiles.SelectedIndex = 0;
            Resolution.SelectedIndex = 0;
        }
        private void Window_Load(object sender, EventArgs e)
        {
        }

        private void Input_Click(object sender, EventArgs e)
        {
            OpenFileDialog Input = new OpenFileDialog();
            Input.ShowDialog();
            InputLocation.Text = Input.FileName;
        }

        private void InputLocation_TextChanged(object sender, EventArgs e)
        {
        }

        private void Output_Click(object sender, EventArgs e)
        {
            SaveFileDialog Output = new SaveFileDialog();
            Output.Filter = "MKV|*.mkv|WEBM|*.webm";
            Output.ShowDialog();
            OutputLocation.Text = Output.FileName;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string command = "";
            if(Encoder.Text == "libaom-av1")
            {
                ProcessStartInfo StartInfo = new ProcessStartInfo();
                command += " -i " + InputLocation.Text;
                command += " -strict experimental -c:v " + Encoder.Text;
                command += " -cpu-used " + Speed.Text;
                command += " -crf " + ConstantQuality.Text.ToString() + " -b:v 0";
                if (Resolution.SelectedIndex > 0)
                {
                    command += " -vf scale=" + Resolution.Text.ToString() + ":-1 ";
                }
                command += " -row-mt " + Multithreading.SelectedIndex.ToString();
                command += " -pix_fmt " + PixelFormat.Text;
                command += " -tiles " + Tiles.Text;
                command += " -c:a libopus -ac 2 -b:a " + AudioBitrate.Text.ToString() + "k";
                command += " -vbr on" + " -compression_level 10";
                command += " " + OutputLocation.Text;
                StartInfo.Arguments = command;
                StartInfo.FileName = "ffmpeg.exe";
                Process.Start(StartInfo).WaitForExit();
            }
            else if(Encoder.Text == "rav1e")
            {
                command = "";
                ProcessStartInfo StartInfo = new ProcessStartInfo();
                command += "/C ffmpeg.exe -i " + InputLocation.Text;
                command += " -f yuv4mpegpipe - | rav1e - ";
                command += " --limit 0";
                command += " --quantizer 100";
                command += " --speed " + Speed.Text.ToString();
                command += " --output video.ivf";
                StartInfo.Arguments = command;
                StartInfo.FileName = "cmd.exe";
                Process.Start(StartInfo).WaitForExit();
                command = "";
                command += " -i " + InputLocation.Text;
                command += " -c:a libopus -ac 2 -b:a " + AudioBitrate.Text.ToString() + "k";
                command += " -vbr on" + " -compression_level 10";
                command += " audio.opus";
                StartInfo.Arguments = command;
                StartInfo.FileName = "ffmpeg.exe";
                Process.Start(StartInfo).WaitForExit();
                command = "";
                command += "ffmpeg -i video.ivf -i audio.opus -c copy " + OutputLocation.Text;
                StartInfo.Arguments = command;
                StartInfo.FileName = "ffmpeg.exe";
                Process.Start(StartInfo).WaitForExit();
            }
        }



        private void CQ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConstantQuality_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Multithreading_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PixelFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AudioBitrate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Resolution_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Encoder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Encoder.Text == "rav1e")
            {
                Speed.Maximum = 10;
                Speed.Minimum = 0;
                ConstantQuality.Maximum = 255;
                ConstantQuality.Minimum = 0;
                PixelFormat.Enabled = false;
                Tiles.Enabled = false;
                Multithreading.Enabled = false;
                Resolution.Enabled = false;
            }
            if(Encoder.Text == "libaom-av1")
            {
                Speed.Maximum = 8;
                Speed.Minimum = 1;
                ConstantQuality.Maximum = 63;
                ConstantQuality.Minimum = 1;
                PixelFormat.Enabled = true;
                Tiles.Enabled = true;
                Multithreading.Enabled = true;
                Resolution.Enabled = true;
            }
        }

        private void Speed_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
