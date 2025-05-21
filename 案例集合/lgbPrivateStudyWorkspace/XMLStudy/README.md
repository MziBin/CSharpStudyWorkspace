# 项目介绍

该项目用于XML的基本操作

## XML语法规则

**XML 声明**

XML 声明文件的可选部分，如果存在需要放在文档的第一行，如下所示：

```
<?xml version="1.0" encoding="utf-8"?>
```

**XML 文档必须有根元素**

根元素名字可以自定义

```
<?xml version="1.0" encoding="UTF-8"?>
<root>
  <to>Tove</to>
  <from>Jani</from>
  <heading>Reminder</heading>
  <body>Don't forget me this weekend!</body>
</root>
```

**XML 标签对大小写敏感**

**XML 属性值必须加引号**

**XML 中的注释**

```
<!-- This is a comment -->
```

**在 XML 中，空格会被保留**

## C#操作XML

操作序列化和操作document文档

### XML文件的读取基本步骤

1.创建文档对象

2.加载XML文档

3.获取根节点

4.遍历节点并封装数据
