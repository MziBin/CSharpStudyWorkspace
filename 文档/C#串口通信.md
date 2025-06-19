# C# 串口通信

在串口通信中，主要就是发送的数据格式和接收数据。

## 发送数据

可以发送字符串或者字节数组。

## 接收数据

方法一：

通过创建一个线程循环接受

while (true)
{
    string data = serialPort.ReadExisting();
    Console.WriteLine(data);
}

方法二：

通过绑定DataReceived事件，会在有数据的时候触发，可以接受数据内容

serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);

private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
{
  try
    {
        // 等待数据接收完成
        System.Threading.Thread.Sleep(100);

    if (serialPort.BytesToRead > 0)
        {
            // 读取数据
            byte[] buffer = new byte[serialPort.BytesToRead];
            serialPort.Read(buffer, 0, buffer.Length);

    return buffer;
            // 转换为字符串（假设数据是ASCII编码）
            //string receivedData = Encoding.ASCII.GetString(buffer);
        }

    return null;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"接收数据失败: {ex.Message}");
        return null;
    }
}

### 注意

`SerialPort.DataReceived` 事件是 **异步的** ，这是一个重要的特性，需要特别注意，读取的结果可能比操作时慢，导致问题：

解决办法：可以给读取数据时，加一个标志位，判断是否读取成功。2，循环判断读取数据。

**一、异步机制说明**

1. **非 UI 线程触发** ：

* `DataReceived` 事件在 **辅助线程** （非 UI 线程）上触发
* 这意味着不能直接在事件处理程序中操作 UI 控件

1. **异步通知机制** ：

* 当串口接收到数据时，系统会自动触发该事件
* 无需在主线程中轮询等待数据

1. **与 UI 线程的关系** ：

* 若需要更新 UI，必须通过 `Invoke` 或 `BeginInvoke` 方法
* 否则会抛出 `InvalidOperationException` 异常
