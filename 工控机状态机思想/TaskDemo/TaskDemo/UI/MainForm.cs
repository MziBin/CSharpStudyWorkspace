using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskDemo.Core;
using TaskDemo.Models;
using TaskDemo.Utils;

namespace TaskDemo
{
    public partial class MainForm : Form
    {
        private readonly StationManager _stationMgr;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _stationMgr = StationManager.Instance;
            InitSystem();
        }

        private void InitSystem()
        {
            // 绑定日志控件
            LogHelper.LogTextBox = txtLog;
            // 绑定工位日志输出
            foreach (var station in _stationMgr.StationList)
            {
                station.LogAction += LogHelper.Write;
            }
            timer1.Start();
        }

        // 全局心跳
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 获取当前运行模式
            var runMode = RunMode.Auto;
            if (rbManual.Checked) runMode = RunMode.Manual;
            if (rbStep.Checked) runMode = RunMode.Step;

            // 驱动所有工位状态机
            _stationMgr.AllStationTick(runMode);
            // 刷新界面
            RefreshStationUi();
        }

        // 刷新工位状态显示
        private void RefreshStationUi()
        {
            var t1 = _stationMgr.GetStation("Task01");
            var t2 = _stationMgr.GetStation("Task02");

            lblTask01.Text = $"Task01 状态：{t1.CurrentState}  步骤：{t1.CurrentStep}/{t1.TotalStep}";
            lblTask02.Text = $"Task02 状态：{t2.CurrentState}  步骤：{t2.CurrentStep}/{t2.TotalStep}";
        }

        #region 按钮事件
        private void btnStart_Click(object sender, EventArgs e)
        {
            LogHelper.Write("系统：点击全局启动");
            _stationMgr.GetStation("Task02").IsAllowRun = false;
            _stationMgr.AllReset();
            _stationMgr.GetStation("Task01").Io.StartSignal = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            LogHelper.Write("系统：设备暂停");
            foreach (var s in _stationMgr.StationList)
                s.Io.StartSignal = false;
        }

        private void btnStepRun_Click(object sender, EventArgs e)
        {
            _stationMgr.GetStation("Task01").StepOnce();
            _stationMgr.GetStation("Task02").StepOnce();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LogHelper.Write("系统：全局复位");
            _stationMgr.AllReset();
        }

        private void btnEMO_Click(object sender, EventArgs e)
        {
            LogHelper.Write("系统：紧急停止触发");
            _stationMgr.AllEStop();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }
        #endregion
    }
}
