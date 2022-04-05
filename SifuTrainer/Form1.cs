using MemoryHelper;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SifuTrainer;

public partial class Form1 : Form
{
    private MemoryHelper64 _memory;
    private ulong _baseAddress;
    private ulong _scoreAddress;

    public Form1() =>
        InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
        _memory = new(GetProcessByName("Sifu-Win64-Shipping"));
        _baseAddress = _memory.GetBaseAddress(0x058B7090);
        _scoreAddress = Utils.OffsetCalculator(_memory, _baseAddress, Offsets._score);
    }

    private Process GetProcessByName(string processName)
    {
        var sifu = Process.GetProcessesByName(processName).FirstOrDefault();
        return sifu is not null
               ? sifu
               : throw new NullReferenceException("Process cant found");
    }

    private void SetScoreButton_Click(object sender, EventArgs e)
    {
        if (int.TryParse(ScoreTextBox.Text, out var score) is false)
            throw new ArgumentException("Score must be type Int");

        _memory.WriteMemory(_scoreAddress, (float)score);
    }

    private void GetScoreButton_Click(object sender, EventArgs e)
    {
        ScoreLabel.Text = ScoreLabel.Tag.ToString() + _memory.ReadMemory<float>(_scoreAddress);
    }
}