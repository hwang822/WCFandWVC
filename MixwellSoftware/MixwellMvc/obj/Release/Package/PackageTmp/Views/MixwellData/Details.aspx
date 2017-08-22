﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MixwellMvc.Models.MixwellData>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Details</title>
</head>
<body>
    <fieldset>
        <legend>MixwellData</legend>
    
        <div class="display-label">
            <%: Html.DisplayNameFor(model => model.name) %>
        </div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.name) %>
        </div>
    
        <div class="display-label">
            <%: Html.DisplayNameFor(model => model.place) %>
        </div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.place) %>
        </div>
    </fieldset>
    <p>
    
        <%: Html.ActionLink("Edit", "Edit", new { id=Model.id }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
</body>
</html>
