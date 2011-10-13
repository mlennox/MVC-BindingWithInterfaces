<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PartialBindingExample.Models.YourModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>
	
	<p><%: Html.ActionLink("reset the form","index") %></p>

	<h3>CREATE form - submits to create action method</h3>
	<% using (Html.BeginForm("Create", "Home", FormMethod.Post))
    { %>
		<fieldset>
			
			<%: Html.EditorForModel() %>

			<input type="submit" value="submit" />
		</fieldset>
	<% } %>

	<h3>UPDATE form - submits to update action method</h3>
	<% using (Html.BeginForm("Update", "Home", FormMethod.Post)) { %>

		<fieldset>
			
			<%: Html.EditorForModel() %>

			<input type="submit" value="submit" />
		</fieldset>

	<% } %>


	<h3>The values of the model properties:</h3>
	<%: Html.DisplayForModel() %>

</asp:Content>
