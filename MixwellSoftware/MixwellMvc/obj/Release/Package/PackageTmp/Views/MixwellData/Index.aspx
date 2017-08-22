﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MixwellMvc.Models.MixwellData>>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>
    <table>
        <tr>
            <th>
                <%: Html.DisplayNameFor(model => model.name) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.place) %>
            </th>
            <th></th>
        </tr>
    
    <% foreach (var item in Model) { %>
        <tr>
            <td>
                <%: Html.DisplayFor(modelItem => item.name) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.place) %>
            </td>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.id }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.id }) %> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.id }) %>
            </td>
        </tr>
    <% } %>
    
    </table>
</body>
</html>
