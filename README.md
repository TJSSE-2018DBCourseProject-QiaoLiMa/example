**此为前后端分离开发后最终整合该有的样子**



## 食用说明

-1.修改ip

wwwroot/index.html中更改ip

```javascript
 axios.get('http://10.0.2.15:58546/hello')
```

更改为

```
 axios.get('http://<你的ip>:58546/hello')
```

_____

vs2017打开项目，点击"调试->webapplication1属性"，找到最下方"应用URL"，更改为"http://<你的ip>:58546/"

0.run

1.打开http://10.0.2.15:58546/index.html

2.点击按钮



## 原理

**注：这个不是服务器渲染！只是第一次访问的时候客户端程序需要由服务器端发送**

请求http://10.0.2.15:58546/index.html

服务器发送静态网页，静态网页于后端程序位于目录wwwroot下

其他原理与前后端分离的版本相同，请查看前后端分离的readme