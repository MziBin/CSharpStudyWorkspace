# C# 的 DataTable 类精简汇总

C# 中的 `DataTable` 是一个非常重要的类，用于在内存中存储和操作数据。它类似于数据库中的表，具有行和列的结构。以下是 `DataTable` 常见操作方法的详细教程，包含相应示例代码。

## 一、核心操作

### 1. 创建 DataTable

先创建 `DataTable` 对象，再为其添加列定义数据结构。

```csharp
using System;
using System.Data;

class Program
{
    static void Main()
    {
        // 创建 DataTable
        DataTable table = new DataTable("MyTable");

        // 添加列
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Age", typeof(int));

        // 打印表结构
        foreach (DataColumn column in table.Columns)
        {
            Console.WriteLine(column.ColumnName + " - " + column.DataType);
        }
    }
}
```

### 2. 添加行

使用 `NewRow()` 方法创建新行，赋值后通过 `Rows.Add()` 加入表中。

```csharp
using System;
using System.Data;

class Program
{
    static void Main()
    {
        DataTable table = new DataTable("MyTable");
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Age", typeof(int));

        // 添加行
        DataRow row1 = table.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table.Rows.Add(row1);

        DataRow row2 = table.NewRow();
        row2["ID"] = 2;
        row2["Name"] = "Bob";
        row2["Age"] = 30;
        table.Rows.Add(row2);

        // 打印行数据
        foreach (DataRow row in table.Rows)
        {
            Console.WriteLine($"{row["ID"]}, {row["Name"]}, {row["Age"]}");
        }
    }
}
```

### 3. 修改行

通过索引或条件找到目标行，直接修改列值即可。

```csharp
using System;
using System.Data;

class Program
{
    static void Main()
    {
        DataTable table = new DataTable("MyTable");
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Age", typeof(int));

        DataRow row1 = table.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table.Rows.Add(row1);

        DataRow row2 = table.NewRow();
        row2["ID"] = 2;
        row2["Name"] = "Bob";
        row2["Age"] = 30;
        table.Rows.Add(row2);

        // 修改行数据
        DataRow rowToUpdate = table.Rows[0];
        rowToUpdate["Name"] = "Alice Smith";
        rowToUpdate["Age"] = 26;

        // 打印修改后的行数据
        foreach (DataRow row in table.Rows)
        {
            Console.WriteLine($"{row["ID"]}, {row["Name"]}, {row["Age"]}");
        }
    }
}
```

### 4. 删除行

使用 `Delete()` 标记删除行，再通过 `AcceptChanges()` 提交删除；或直接用 `Remove()` 移除。

```csharp
using System;
using System.Data;

class Program
{
    static void Main()
    {
        DataTable table = new DataTable("MyTable");
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Age", typeof(int));

        DataRow row1 = table.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table.Rows.Add(row1);

        DataRow row2 = table.NewRow();
        row2["ID"] = 2;
        row2["Name"] = "Bob";
        row2["Age"] = 30;
        table.Rows.Add(row2);

        // 删除行
        table.Rows[0].Delete(); // 标记为删除
        table.AcceptChanges();  // 提交删除

        // 打印剩余行数据
        foreach (DataRow row in table.Rows)
        {
            Console.WriteLine($"{row["ID"]}, {row["Name"]}, {row["Age"]}");
        }
    }
}
```

### 5. 查询行

通过 `Select()` 方法传入条件表达式，筛选符合要求的行。

```csharp
using System;
using System.Data;

class Program
{
    static void Main()
    {
        DataTable table = new DataTable("MyTable");
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Age", typeof(int));

        DataRow row1 = table.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table.Rows.Add(row1);

        DataRow row2 = table.NewRow();
        row2["ID"] = 2;
        row2["Name"] = "Bob";
        row2["Age"] = 30;
        table.Rows.Add(row2);

        // 查询行
        DataRow[] rows = table.Select("Age > 26");

        // 打印查询结果
        foreach (DataRow row in rows)
        {
            Console.WriteLine($"{row["ID"]}, {row["Name"]}, {row["Age"]}");
        }
    }
}
```

### 6. 排序行

利用 `DefaultView.Sort` 属性设置排序字段和排序方向（升序 ASC/降序 DESC）。

```csharp
using System;
using System.Data;

class Program
{
    static void Main()
    {
        DataTable table = new DataTable("MyTable");
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Age", typeof(int));

        DataRow row1 = table.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table.Rows.Add(row1);

        DataRow row2 = table.NewRow();
        row2["ID"] = 2;
        row2["Name"] = "Bob";
        row2["Age"] = 30;
        table.Rows.Add(row2);

        // 排序
        table.DefaultView.Sort = "Age DESC";

        // 打印排序后的行数据
        foreach (DataRowView rowView in table.DefaultView)
        {
            DataRow row = rowView.Row;
            Console.WriteLine($"{row["ID"]}, {row["Name"]}, {row["Age"]}");
        }
    }
}
```

---

## 二、高级操作

### 7. 合并 DataTable

使用 `Merge()` 方法将两个结构相同或兼容的 `DataTable` 合并。

```csharp
using System;
using System.Data;

class Program
{
    static void Main()
    {
        DataTable table1 = new DataTable("MyTable");
        table1.Columns.Add("ID", typeof(int));
        table1.Columns.Add("Name", typeof(string));
        table1.Columns.Add("Age", typeof(int));

        DataRow row1 = table1.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table1.Rows.Add(row1);

        DataTable table2 = new DataTable("MyTable");
        table2.Columns.Add("ID", typeof(int));
        table2.Columns.Add("Name", typeof(string));
        table2.Columns.Add("Age", typeof(int));

        DataRow row2 = table2.NewRow();
        row2["ID"] = 2;
        row2["Name"] = "Bob";
        row2["Age"] = 30;
        table2.Rows.Add(row2);

        // 合并 DataTable
        table1.Merge(table2);

        // 打印合并后的行数据
        foreach (DataRow row in table1.Rows)
        {
            Console.WriteLine($"{row["ID"]}, {row["Name"]}, {row["Age"]}");
        }
    }
}
```

### 8. 克隆 DataTable

`Clone()` 方法仅复制 `DataTable` 的结构（列定义、约束等），不复制数据。

```csharp
using System;
using System.Data;

class Program
{
    static void Main()
    {
        DataTable table1 = new DataTable("MyTable");
        table1.Columns.Add("ID", typeof(int));
        table1.Columns.Add("Name", typeof(string));
        table1.Columns.Add("Age", typeof(int));

        DataRow row1 = table1.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table1.Rows.Add(row1);

        // 克隆 DataTable
        DataTable table2 = table1.Clone();

        // 打印克隆后的表结构
        foreach (DataColumn column in table2.Columns)
        {
            Console.WriteLine(column.ColumnName + " - " + column.DataType);
        }
    }
}
```

### 9. 复制 DataTable

`Copy()` 方法同时复制 `DataTable` 的结构和所有数据。

```csharp
using System;
using System.Data;

class Program
{
    static void Main()
    {
        DataTable table1 = new DataTable("MyTable");
        table1.Columns.Add("ID", typeof(int));
        table1.Columns.Add("Name", typeof(string));
        table1.Columns.Add("Age", typeof(int));

        DataRow row1 = table1.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table1.Rows.Add(row1);

        // 复制 DataTable
        DataTable table2 = table1.Copy();

        // 打印复制后的行数据
        foreach (DataRow row in table2.Rows)
        {
            Console.WriteLine($"{row["ID"]}, {row["Name"]}, {row["Age"]}");
        }
    }
}
```

### 10. 使用 DataView 过滤和排序

`DataView` 是 `DataTable` 的视图，可独立设置过滤条件和排序规则，不影响原表。

```csharp
using System;
using System.Data;

class Program
{
    static void Main()
    {
        DataTable table = new DataTable("MyTable");
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Age", typeof(int));

        DataRow row1 = table.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table.Rows.Add(row1);

        DataRow row2 = table.NewRow();
        row2["ID"] = 2;
        row2["Name"] = "Bob";
        row2["Age"] = 30;
        table.Rows.Add(row2);

        // 创建 DataView
        DataView view = new DataView(table);
        view.RowFilter = "Age > 26";
        view.Sort = "Name DESC";

        // 打印过滤和排序后的行数据
        foreach (DataRowView rowView in view)
        {
            DataRow row = rowView.Row;
            Console.WriteLine($"{row["ID"]}, {row["Name"]}, {row["Age"]}");
        }
    }
}
```

### 11. 使用 DataTable 的事件

`DataTable` 提供多种事件，可在数据发生变化时触发自定义逻辑。

```csharp
using System;
using System.Data;

class Program
{
    static void Main()
    {
        DataTable table = new DataTable("MyTable");
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Age", typeof(int));

        // 订阅事件
        table.RowChanged += new DataRowChangeEventHandler(RowChangedEvent);

        DataRow row1 = table.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table.Rows.Add(row1);
    }

    private static void RowChangedEvent(object sender, DataRowChangeEventArgs e)
    {
        Console.WriteLine($"Row changed: {e.Action}, {e.Row["Name"]}");
    }
}
```

### 12. 使用 DataTable 的约束

可为 `DataTable` 添加主键约束、唯一约束等，保证数据完整性。

```csharp
using System;
using System.Data;

class Program
{
    static void Main()
    {
        DataTable table = new DataTable("MyTable");
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Age", typeof(int));

        // 添加主键约束
        table.PrimaryKey = new DataColumn[] { table.Columns["ID"] };

        // 添加唯一约束
        table.Columns["Name"].Unique = true;

        DataRow row1 = table.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table.Rows.Add(row1);

        // 尝试添加重复主键
        try
        {
            DataRow row2 = table.NewRow();
            row2["ID"] = 1; // 重复主键
            row2["Name"] = "Bob";
            row2["Age"] = 30;
            table.Rows.Add(row2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
```

### 13. 使用 DataTable 的表达式列

表达式列的值通过表达式动态计算，无需手动赋值。

```csharp
using System;
using System.Data;

class Program
{
    static void Main()
    {
        DataTable table = new DataTable("MyTable");
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Age", typeof(int));

        // 添加表达式列
        table.Columns.Add("IsAdult", typeof(bool), "Age >= 18");

        DataRow row1 = table.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table.Rows.Add(row1);

        DataRow row2 = table.NewRow();
        row2["ID"] = 2;
        row2["Name"] = "Bob";
        row2["Age"] = 16;
        table.Rows.Add(row2);

        // 打印表达式列的值
        foreach (DataRow row in table.Rows)
        {
            Console.WriteLine($"{row["Name"]} is adult: {row["IsAdult"]}");
        }
    }
}
```

### 14. 使用 DataTable 的 XML 序列化

可将 `DataTable` 序列化为 XML 字符串或文件，也可从 XML 反序列化恢复数据。

```csharp
using System;
using System.Data;
using System.IO;

class Program
{
    static void Main()
    {
        DataTable table = new DataTable("MyTable");
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Age", typeof(int));

        DataRow row1 = table.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table.Rows.Add(row1);

        // 序列化为 XML
        string xml = table.GetXml();
        Console.WriteLine(xml);

        // 将 XML 保存到文件
        File.WriteAllText("table.xml", xml);

        // 从 XML 反序列化为 DataTable
        DataTable newTable = new DataTable();
        newTable.ReadXml("table.xml");

        // 打印反序列化后的行数据
        foreach (DataRow row in newTable.Rows)
        {
            Console.WriteLine($"{row["ID"]}, {row["Name"]}, {row["Age"]}");
        }
    }
}
```

### 15. 使用 DataTable 的 JSON 序列化

借助 Newtonsoft.Json 库，可实现 `DataTable` 与 JSON 格式的相互转换。

```csharp
using System;
using System.Data;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        DataTable table = new DataTable("MyTable");
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Age", typeof(int));

        DataRow row1 = table.NewRow();
        row1["ID"] = 1;
        row1["Name"] = "Alice";
        row1["Age"] = 25;
        table.Rows.Add(row1);

        // 序列化为 JSON
        string json = JsonConvert.SerializeObject(table);
        Console.WriteLine(json);

        // 从 JSON 反序列化为 DataTable
        DataTable newTable = JsonConvert.DeserializeObject<DataTable>(json);

        // 打印反序列化后的行数据
        foreach (DataRow row in newTable.Rows)
        {
            Console.WriteLine($"{row["ID"]}, {row["Name"]}, {row["Age"]}");
        }
    }
}
```

---

## 三、总结

`DataTable` 是 C# 中强大的数据结构，适用于处理内存中的数据。通过上述教程，可掌握 `DataTable` 的核心操作（创建、增删改查、排序）和高级功能（合并、克隆、约束、序列化等），满足各类数据处理场景需求。
