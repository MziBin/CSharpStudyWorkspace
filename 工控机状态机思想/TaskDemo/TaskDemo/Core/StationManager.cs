using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDemo.Models;

namespace TaskDemo.Core
{
    /// <summary>
    /// 全局工位管理器 单例
    /// 统一管理 Task01 Task02 互锁、调度、全局操作
    /// </summary>
    public class StationManager
    {
        public List<WorkStation> StationList { get; }

        private static StationManager _instance;
        public static StationManager Instance => _instance == null ? _instance = new StationManager() : _instance;

        private StationManager()
        {
            StationList = new List<WorkStation>();
            InitTaskStation();
        }

        /// <summary>
        /// 初始化工位 Task01 Task02
        /// </summary>
        private void InitTaskStation()
        {
            var task01 = new WorkStation("Task01");
            var task02 = new WorkStation("Task02");

            // 产线顺序互锁：Task01完成后解锁Task02
            task01.LogAction += msg =>
            {
                if (task01.CurrentState == StationState.Finish)
                {
                    task02.IsAllowRun = true;
                }
            };

            StationList.Add(task01);
            StationList.Add(task02);
        }

        /// <summary>
        /// 所有工位统一轮询
        /// </summary>
        public void AllStationTick(RunMode runMode)
        {
            foreach (var item in StationList)
            {
                item.CurrentMode = runMode;
                item.StateMachineTick();
            }
        }

        /// <summary>
        /// 全局复位
        /// </summary>
        public void AllReset()
        {
            foreach (var item in StationList)
                item.Reset();
        }

        /// <summary>
        /// 全局急停
        /// </summary>
        public void AllEStop()
        {
            foreach (var item in StationList)
                item.EStop();
        }

        /// <summary>
        /// 根据名称获取指定工位
        /// </summary>
        public WorkStation GetStation(string name)
        {
            return StationList.Find(x => x.StationName == name);
        }
    }
}
