### 一、Modbus协议核心数据类型（线圈、寄存器等）

Modbus协议定义了4类核心数据区域，用于与PLC等设备通信，**不同区域对应PLC的不同硬件/存储资源**：

| 数据类型                        | Modbus地址范围 | 位宽 | 读写属性 | 对应PLC资源                 | 核心用途                         |
| ------------------------------- | -------------- | ---- | -------- | --------------------------- | -------------------------------- |
| 线圈（Coils）                   | 0xxxx（0区）   | 1位  | 可读可写 | PLC输出继电器（Y/Q）、内部M | 控制PLC输出（如Y0置1/置0）       |
| 离散输入（Discrete Inputs）     | 1xxxx（1区）   | 1位  | 只读     | PLC输入继电器（X/I）        | 读取外部输入（如按钮X0是否按下） |
| 保持寄存器（Holding Registers） | 3xxxx（3区）   | 16位 | 可读可写 | PLC数据寄存器（D）、设定值  | 存储/修改数值（如频率、计数）    |
| 输入寄存器（Input Registers）   | 4xxxx（4区）   | 16位 | 只读     | PLC模拟量输入（AI）         | 读取模拟量（如温度、压力）       |

#### 关键说明：

1. **地址格式**：Modbus地址是“区域码+偏移”，例如 `00001` 表示线圈区第1个地址（Y0），`10001` 表示离散输入区第1个地址（X0）；
2. **位/字对齐**：线圈/离散输入是1位单位，寄存器是16位（1个字）单位；
3. **PLC映射差异**：不同品牌PLC的Modbus地址映射不同（核心逻辑一致）：
   - 三菱FX系列：X0→10001、Y0→00001；
   - 西门子S7-200Smart：I0.0→10001、Q0.0→00001；
   - 欧姆龙CP系列：X0→10001、Y0→00001。

### 二、C#读取PLC的X输入（离散输入）和Y输出（线圈）

#### 核心前提：

- PLC需启用Modbus TCP/RTU通信（如三菱FX3U+FX5-ENET/IP、西门子200Smart的Modbus TCP）；
- 确认PLC的Modbus地址映射（重点：X/Y对应的起始偏移）；
- C#使用成熟的Modbus库：`NModbus4`（NuGet可直接安装，支持TCP/RTU）。

#### 步骤1：环境准备

打开Visual Studio，创建项目后，通过NuGet安装 `NModbus4`：

```bash
Install-Package NModbus4
```

#### 步骤2：核心代码实现（Modbus TCP示例）

以下示例实现：

- 连接PLC的Modbus TCP服务器（默认端口502）；
- 读取PLC X0-X7（离散输入，10001-10008）；
- 读取PLC Y0-Y7（线圈，00001-00008）；
- 异常处理（断连、地址错误等）。

```csharp
using System;
using System.Net.Sockets;
using Modbus.Device;

namespace ModbusPLCRead
{
    class Program
    {
        static void Main(string[] args)
        {
            // PLC的Modbus TCP配置
            string plcIp = "192.168.3.100"; // PLC的IP地址
            int plcPort = 502; // Modbus TCP默认端口
            int slaveId = 1; // PLC的从站地址（默认1，需与PLC配置一致）

            // 1. 创建Modbus TCP连接
            TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(plcIp, plcPort);
                IModbusMaster modbusMaster = ModbusIpMaster.CreateIp(tcpClient);
                Console.WriteLine("PLC连接成功！");

                // 2. 读取X输入（离散输入：1区，X0-X7对应起始地址0，数量8）
                // 注意：NModbus4的地址是0偏移！Modbus地址10001 = 起始地址0
                bool[] xInputs = modbusMaster.ReadDiscreteInputs(
                    slaveAddress: slaveId,
                    startAddress: 0, // X0对应起始地址0
                    numberOfPoints: 8 // 读取X0-X7共8个输入点
                );
                // 输出X输入状态
                Console.WriteLine("===== PLC X输入状态 =====");
                for (int i = 0; i < xInputs.Length; i++)
                {
                    Console.WriteLine($"X{i}: {(xInputs[i] ? "ON" : "OFF")}");
                }

                // 3. 读取Y输出（线圈：0区，Y0-Y7对应起始地址0，数量8）
                // 注意：Modbus地址00001 = 起始地址0
                bool[] yOutputs = modbusMaster.ReadCoils(
                    slaveAddress: slaveId,
                    startAddress: 0, // Y0对应起始地址0
                    numberOfPoints: 8 // 读取Y0-Y7共8个输出点
                );
                // 输出Y输出状态
                Console.WriteLine("===== PLC Y输出状态 =====");
                for (int i = 0; i < yOutputs.Length; i++)
                {
                    Console.WriteLine($"Y{i}: {(yOutputs[i] ? "ON" : "OFF")}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"通信异常：{ex.Message}");
            }
            finally
            {
                // 4. 关闭连接
                if (tcpClient.Connected)
                    tcpClient.Close();
                tcpClient.Dispose();
                Console.WriteLine("连接已关闭");
            }

            Console.ReadKey();
        }
    }
}
```

#### 步骤3：代码关键说明

1. **地址偏移（核心坑点）**：
   NModbus4的 `startAddress`是**0偏移**（而非Modbus地址的1起始）：

   - Modbus地址10001（X0）→ startAddress=0；
   - Modbus地址10010（X9）→ startAddress=9；
   - Modbus地址00001（Y0）→ startAddress=0。
2. **从站地址（slaveId）**：
   PLC的Modbus从站地址默认是1，需与PLC侧配置一致（如三菱FX的参数设置、西门子的Modbus从站号）。
3. **异常处理**：
   需捕获 `SocketException`（断连）、`ModbusException`（地址越界/权限错误）等异常。

#### 步骤4：RTU通信（串口）适配（可选）

若PLC使用Modbus RTU（串口），只需替换连接方式，核心读取逻辑不变：

```csharp
// 替换TCP连接为串口连接
using System.IO.Ports;
SerialPort serialPort = new SerialPort("COM3", 9600, Parity.Even, 8, StopBits.One);
serialPort.Open();
IModbusMaster modbusMaster = ModbusSerialMaster.CreateRtu(serialPort);
```

### 三、注意事项

1. **PLC侧配置**：

   - 启用Modbus通信（如三菱FX需设置以太网模块的IP、Modbus功能开启；西门子需配置Modbus TCP从站）；
   - 确认X/Y的Modbus地址映射（部分PLC可能偏移不同，如X0对应10000而非10001，需查PLC手册）。
2. **数据长度**：
   单次读取的线圈/离散输入数量建议≤128（Modbus协议限制），寄存器≤125。
3. **读写权限**：

   - 离散输入（X）仅能读，线圈（Y）可读写（若需修改Y输出，用 `WriteSingleCoil`方法）。

### 扩展：修改Y输出（线圈写操作）

若需通过C#控制PLC Y输出，示例代码：

```csharp
// 置Y0为ON（startAddress=0对应Y0）
modbusMaster.WriteSingleCoil(slaveId, 0, true);
// 置Y1为OFF
modbusMaster.WriteSingleCoil(slaveId, 1, false);
```

以上是Modbus协议核心概念及C#读取PLC X/Y的完整实现，需根据实际PLC型号调整地址映射和通信参数。
