<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>DependencyInjectionView</title>
</head>
<body>
    <div>
        @ViewData["MyData"]
        Hello DJ View <br/>
         Data Is @ViewData["MyData"] 
    </div>
</body>
</html>
