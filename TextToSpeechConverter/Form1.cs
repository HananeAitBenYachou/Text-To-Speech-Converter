using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextToSpeechConverter.Properties;

namespace TextToSpeechConverter
{
    public partial class Form1 : Form
    {
        private clsTextToSpeechConverter _TextToSpeechConverter;

        public Form1()
        {
            InitializeComponent();

            _TextToSpeechConverter = new clsTextToSpeechConverter();
        }

        private void _Reset()
        {
            if (!string.IsNullOrEmpty(tbText.Text))
                tbText.Clear();

            _TextToSpeechConverter.Stop();  

            trbSpeed.Value = 0;

            btnPauseResume.Text = "Pause";

            _PopulateLangugaesComboBox();
        }

        private void _ChangeState()
        {
            if (_TextToSpeechConverter.state == SynthesizerState.Speaking)
            {
                _TextToSpeechConverter.Stop();
                _TextToSpeechConverter.ConvertTextToSpeech(tbText.Text, cbVoices.Text, trbSpeed.Value);
                _TextToSpeechConverter.Resume();
            }
        }

        private void _PopulateVoicesComboBox()
        {
            cbVoices.Items.Clear();
            cbVoices.Items.AddRange(_TextToSpeechConverter.GetVoicesForLanguage(cbLanguages.Text).ToArray());

            cbVoices.SelectedIndex = 0;
        }

        private void _PopulateLangugaesComboBox()
        {
            cbLanguages.Items.Clear();
            cbLanguages.Items.AddRange(_TextToSpeechConverter.GetAvailableLanguages().ToArray());

            cbLanguages.SelectedIndex = 0;
        }

        private bool _IsTextValid()
        {
            string pattern = "";

            switch (cbLanguages.Text.Split('(')[0])
            {
                case "English":
                    pattern = @"^[A-Za-z0-9\s\.,\?!]+$";
                    break;

                case "French":
                    pattern = @"^[A-Za-z0-9\s\.,\?!àâäéèêëîïôöùûüç]+$";
                    break;

                case "Chinese":
                    pattern = @"^[\u4E00-\u9FFF]+$";
                    break;
            }

            return Regex.IsMatch(tbText.Text, pattern);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _Reset();
        }

        private void btnConvertTextToSpeech_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("The text to be converted is not valid , please put the mouse over the red icon to see the error", "Validation Error !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _TextToSpeechConverter.ConvertTextToSpeech(tbText.Text, cbVoices.Text, trbSpeed.Value);
        }

        private void cbLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            _PopulateVoicesComboBox();
        }

        private void cbVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ChangeState();
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            if(btnPauseResume.Text == "Pause")
            {
                _TextToSpeechConverter.Pause();
                btnPauseResume.Text = "Resume";
            }

            else
            {
                _TextToSpeechConverter.Resume();
                btnPauseResume.Text = "Pause";
            }
        }

        private void btnPauseResume_TextChanged(object sender, EventArgs e)
        {
            btnPauseResume.Image = btnPauseResume.Text == "Pause" ? Resources.pause : Resources.resume;
        }

        private void tbText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbText.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbText, "Please enter the text to be converted !");
                tbText.Focus();
            }

            else if(!_IsTextValid())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbText, "The entered text does not match the selected language !");
                tbText.Focus();
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbText, null);
            }
        }

        private void trbSpeed_ValueChanged(object sender, EventArgs e)
        {
            _ChangeState();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
