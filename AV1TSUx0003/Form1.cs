using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV1TSUx0003
{
    public partial class Window : Form
    {
        int ContainerIndex;
        string NUL;
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
            EncodingMode.SelectedIndex = 0;
            AudioChannel.SelectedIndex = 1;
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
            ContainerIndex = Output.FilterIndex;
            OutputLocation.Text = Output.FileName;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string command = "";
            if (Encoder.Text == "libaom-av1")
            {
                if (EncodingMode.Text == "Constant Quality")
                {
                    ProcessStartInfo StartInfo = new ProcessStartInfo();
                    command += " -y -i " + InputLocation.Text;
                    command += " -strict experimental -c:v " + Encoder.Text;
                    command += " -cpu-used " + Speed.Text;
                    command += " -crf " + ConstantQuality.Text.ToString();
                    command += " -b:v 0";
                    if (Resolution.SelectedIndex > 0)
                    {
                        command += " -vf scale=-1:" + Resolution.Text.ToString();
                    }
                    command += " -row-mt " + Multithreading.SelectedIndex.ToString();
                    command += " -pix_fmt " + PixelFormat.Text;
                    command += " -tiles " + Tiles.Text;
                    command += " -c:a libopus -ac " + AudioChannel.SelectedIndex + 1.ToString();
                    command += " -b:a " + AudioBitrate.Text.ToString() + "k";
                    command += " -vbr on" + " -compression_level 10";
                    command += " " + OutputLocation.Text;
                    StartInfo.Arguments = command;
                    StartInfo.FileName = "ffmpeg.exe";
                    Process.Start(StartInfo).WaitForExit();
                }
                else if (EncodingMode.Text == "Constrained Quality")
                {
                    ProcessStartInfo StartInfo = new ProcessStartInfo();
                    command += " -y -i " + InputLocation.Text;
                    command += " -strict experimental -c:v " + Encoder.Text;
                    command += " -cpu-used " + Speed.Text;
                    command += " -crf " + ConstantQuality.Text.ToString();
                    command += " -b:v " + VideoBitrate.Value.ToString() + "k";
                    if (Resolution.SelectedIndex > 0)
                    {
                        command += " -vf scale=-1:" + Resolution.Text.ToString();
                    }
                    command += " -row-mt " + Multithreading.SelectedIndex.ToString();
                    command += " -pix_fmt " + PixelFormat.Text;
                    command += " -tiles " + Tiles.Text;
                    command += " -c:a libopus";
                    command += " -ac " + AudioChannel.SelectedIndex + 1.ToString();
                    command += " -b:a " + AudioBitrate.Text.ToString() + "k";
                    command += " -vbr on" + " -compression_level 10";
                    command += " " + OutputLocation.Text;
                    StartInfo.Arguments = command;
                    StartInfo.FileName = "ffmpeg.exe";
                    Process.Start(StartInfo).WaitForExit();
                }
                //////////////////////////////////////////////////////////////////////////////////////
                else if (EncodingMode.Text == "Two-Pass")
                {
                    ProcessStartInfo StartInfo = new ProcessStartInfo();
                    command += "/C ffmpeg.exe -y -i " + InputLocation.Text;
                    command += " -strict experimental -c:v " + Encoder.Text;
                    command += " -b:v " + VideoBitrate.Value.ToString() + "k";
                    if (Resolution.SelectedIndex > 0)
                    {
                        command += " -vf scale=-1:" + Resolution.Text.ToString();
                    }
                    command += " -row-mt " + Multithreading.SelectedIndex.ToString();
                    command += " -pix_fmt " + PixelFormat.Text;
                    command += " -tiles " + Tiles.Text;
                    command += " -pass 1 -an -f";
                    if (ContainerIndex == 1)
                    {
                        command += " matroska NUL &&";
                    }
                    else if (ContainerIndex == 2)
                    {
                        command += " webm NUL &&";
                    }
                    command += " ffmpeg.exe -y -i " + InputLocation.Text;
                    command += " -strict experimental -c:v " + Encoder.Text;
                    command += " -cpu-used " + Speed.Text;
                    command += " -b:v " + VideoBitrate.Value.ToString() + "k";
                    if (Resolution.SelectedIndex > 0)
                    {
                        command += " -vf scale=-1:" + Resolution.Text.ToString();
                    }
                    command += " -row-mt " + Multithreading.SelectedIndex.ToString();
                    command += " -pix_fmt " + PixelFormat.Text;
                    command += " -tiles " + Tiles.Text;
                    command += " -pass 2";
                    command += " -c:a libopus";
                    command += " -ac " + AudioChannel.SelectedIndex + 1.ToString();
                    command += " -b:a " + AudioBitrate.Text.ToString() + "k";
                    command += " -vbr on" + " -compression_level 10";
                    command += " " + OutputLocation.Text;
                    StartInfo.Arguments = command;
                    StartInfo.FileName = "cmd.exe";
                    Process.Start(StartInfo).WaitForExit();
                }
                else if (EncodingMode.Text == "Average Bitrate")
                {
                    ProcessStartInfo StartInfo = new ProcessStartInfo();
                    command += " -y -i " + InputLocation.Text;
                    command += " -strict experimental -c:v " + Encoder.Text;
                    command += " -cpu-used " + Speed.Text;
                    command += " -b:v " + VideoBitrate.Value.ToString() + "k";
                    if (Resolution.SelectedIndex > 0)
                    {
                        command += " -vf scale=-1:" + Resolution.Text.ToString();
                    }
                    command += " -row-mt " + Multithreading.SelectedIndex.ToString();
                    command += " -pix_fmt " + PixelFormat.Text;
                    command += " -tiles " + Tiles.Text;
                    command += " -c:a libopus";
                    command += " -ac " + AudioChannel.SelectedIndex + 1.ToString();
                    command += " -b:a " + AudioBitrate.Text.ToString() + "k";
                    command += " -vbr on" + " -compression_level 10";
                    command += " " + OutputLocation.Text;
                    StartInfo.Arguments = command;
                    StartInfo.FileName = "ffmpeg.exe";
                    Process.Start(StartInfo).WaitForExit();
                }
            }
            else if (Encoder.Text == "rav1e")
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
                command += " -c:a libopus -ac " + AudioChannel.SelectedIndex + 1.ToString();
                command += " -b:a " + AudioBitrate.Text.ToString() + "k";
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
                EncodingMode.Enabled = false;
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
                EncodingMode.Enabled = true;
            }
        }

        private void Speed_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EncodingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(EncodingMode.Text == "Constant Quality")
            {
                ConstantQuality.Enabled = true;
                VideoBitrate.Enabled = false;
            }
            else if(EncodingMode.Text == "Constrained Quality")
            {
                ConstantQuality.Enabled = true;
                VideoBitrate.Enabled = true;
            }
            else if(EncodingMode.Text == "Two-Pass")
            {
                ConstantQuality.Enabled = false;
                VideoBitrate.Enabled = true;
            }
            else if(EncodingMode.Text == "Average Bitrate")
            {
                ConstantQuality.Enabled = false;
                VideoBitrate.Enabled = true;
            }

        }

        private void VideoBitrate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AudioChannel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
