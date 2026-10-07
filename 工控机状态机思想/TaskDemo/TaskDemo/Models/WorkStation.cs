using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDemo.IO;

namespace TaskDemo.Models
{
    /// <summary>
    /// 工位实体类 【Task01 / Task02】
    /// </summary>
    public class WorkStation
    {
        // 工位名称
        public string StationName { get; set; }
        // 当前状态
        public StationState CurrentState { get; set; }
        // 运行模式
        public RunMode CurrentMode { get; set; }

        // 流程步骤
        public int CurrentStep { get; set; }
        public int TotalStep { get; set; } = 5;

        // 硬件IO信号
        public VirtualIO Io { get; set; }
        // 工位互锁权限
        public bool IsAllowRun { get; set; }

        // 日志回调
        public Action<string> LogAction { get; set; }

        public WorkStation(string name)
        {
            StationName = name;
            CurrentState = StationState.Idle;
            CurrentMode = RunMode.Auto;
            CurrentStep = 0;
            IsAllowRun = true;
            Io = new VirtualIO();
        }

        /// <summary>
        /// 状态机核心轮询
        /// </summary>
        public void StateMachineTick()
        {
            // 报警优先
            if (Io.AlarmSignal)
            {
                SwitchState(StationState.Alarm);
                return;
            }

            switch (CurrentState)
            {
                case StationState.Idle:
                    if (CurrentMode == RunMode.Auto && Io.StartSignal && IsAllowRun)
                    {
                        SwitchState(StationState.Ready);
                    }
                    break;

                case StationState.Ready:
                    CurrentStep = 0;
                    SwitchState(StationState.Run);
                    break;

                case StationState.Run:
                    if (CurrentMode == RunMode.Step)
                    {
                        SwitchState(StationState.StepWait);
                        break;
                    }
                    CurrentStep++;
                    LogAction?.Invoke($"{StationName} 运行步骤：{CurrentStep}/{TotalStep}");
                    if (CurrentStep >= TotalStep)
                    {
                        Io.FinishSignal = true;
                        SwitchState(StationState.Finish);
                    }
                    break;

                case StationState.StepWait:
                    break;

                case StationState.Finish:
                    LogAction?.Invoke($"{StationName} 流程执行完成");
                    SwitchState(StationState.Idle);
                    Io.StartSignal = false;
                    Io.FinishSignal = false;
                    break;

                case StationState.Alarm:
                    break;
            }
        }

        /// <summary>
        /// 单步执行
        /// </summary>
        public void StepOnce()
        {
            if (CurrentState != StationState.StepWait) return;
            CurrentStep++;
            LogAction?.Invoke($"{StationName} 单步执行：{CurrentStep}/{TotalStep}");
            var nextState = CurrentStep >= TotalStep ? StationState.Finish : StationState.Run;
            SwitchState(nextState);
        }

        /// <summary>
        /// 统一切换状态
        /// </summary>
        private void SwitchState(StationState newState)
        {
            if (CurrentState == newState) return;
            LogAction?.Invoke($"{StationName} 状态变更：{CurrentState} → {newState}");
            CurrentState = newState;
        }

        /// <summary>
        /// 工位复位
        /// </summary>
        public void Reset()
        {
            CurrentStep = 0;
            Io.ResetAllSignal();
            SwitchState(StationState.Idle);
        }

        /// <summary>
        /// 紧急停止
        /// </summary>
        public void EStop()
        {
            Reset();
            LogAction?.Invoke($"{StationName} 触发急停");
        }
    }
}
