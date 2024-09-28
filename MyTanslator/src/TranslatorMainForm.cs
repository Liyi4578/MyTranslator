using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MyTanslator.src;
using MyTanslator.utils;
using System.Threading;

namespace MyTanslator
{
    public partial class TranslatorMainForm : Form
    {
        public TranslatorMainForm()
        {
            InitializeComponent();
            myInitComponent();
        }


        private void myInitComponent()
        {
            this.textBox_main.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            this.textBox_result.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            this.MinimumSize = new Size(width: 320, height: 240);
            this.splitContainer_main.Panel2Collapsed = true;
            foreach (string item in Translator.MapLanguage)
            {
                this.toolStripComboBox_sourceLang.Items.Add(item);
                this.toolStripComboBox_dstLang.Items.Add(item);
            }
            this.toolStripComboBox_sourceLang.SelectedIndex = 0;
            this.toolStripComboBox_dstLang.SelectedIndex = 0;
        }

        private void toolBtn_merge_Click(object sender, EventArgs e)
        {
            string text = this.textBox_main.Text.TrimEnd(new char[] { '\n', '\r' });
            for (var counter = 0; counter < text.Length - 1; counter++)
            {

                //合并换行
                if (text[counter + 1].ToString() == "\r" || 
                    text[counter + 1].ToString() == "\r\n" || 
                    text[counter + 1].ToString() == "\n")
                {
                    //如果检测到句号结尾,则不去掉换行
                    if (text[counter].ToString() == "." || text[counter].ToString() == "。") continue;

                    //去除换行
                    text = text.Remove(counter + 1, 1);
                    
                    //判断英文单词或,结尾,则加一个空格
                    if (Regex.IsMatch(text[counter].ToString(), "[a-zA-Z]") || text[counter].ToString() == ",")
                        text = text.Insert(counter + 1, " ");

                    //判断"-"结尾,且前一个字符为英文单词,则去除"-"
                    if (text[counter].ToString() == "-" && Regex.IsMatch(text[counter - 1].ToString(), "[a-zA-Z]"))
                        text = text.Remove(counter, 1);
                }
                //检测到中文时去除空格
                if (Regex.IsMatch(text, @"[\u4e00-\u9fa5]") && text[counter].ToString() == " ")
                {
                    text = text.Remove(counter, 1);
                }
            }
            this.textBox_main.Text = text;
        }

        private async void toolBtn_translate_Click(object sender, EventArgs e)
        {
            if (this.splitContainer_main.Panel2Collapsed == true)
            {
                int oldPanel1Heght = this.splitContainer_main.Panel1.Height;
                this.Height = this.Height * 3 / 2;
                this.splitContainer_main.Panel2Collapsed = false;
                this.splitContainer_main.SplitterDistance = oldPanel1Heght;
            }

            int sourceLanIndex = toolStripComboBox_sourceLang.SelectedIndex;
            int dstLanIndex = toolStripComboBox_dstLang.SelectedIndex;
            string text = textBox_main.Text;
            MyUtils.CountEngAndChineseChacter(text, out int engCount, out int chineseCount);
            if (sourceLanIndex == 0)
            {
                sourceLanIndex = (int)(engCount > chineseCount ? Translator.EnumLanguage.EN : Translator.EnumLanguage.CN);
            }
            if (dstLanIndex == 0)
            {
                dstLanIndex = (int)(engCount > chineseCount ? Translator.EnumLanguage.CN : Translator.EnumLanguage.EN);
            }
            textBox_result.Text = await Task.Run(() =>
            {
                return Translator.Translate(text, 
                    (Translator.EnumLanguage)sourceLanIndex, (Translator.EnumLanguage)dstLanIndex);
                
            });
        }

        private void ToolStripMenuItem_foldResult_Click(object sender, EventArgs e)
        {
            if (this.splitContainer_main.Panel2Collapsed == false)
            {
                // 先调整大小，再折叠
                this.Height -= this.splitContainer_main.Panel2.Height;
                this.splitContainer_main.Panel2Collapsed = true;
            }
        }

        private void toolStripButton_setting_Click(object sender, EventArgs e)
        {
            var configForm = new ConfigForm();
            configForm.Show();
        }

        private void toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ;
        }
    }
}
