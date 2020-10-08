<%@ Page Title="Yoga, Bootcamp, RPM | The biggest range of gym classes - Goodlife Health Clubs"
    Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllClassesEF.aspx.cs"
    Inherits="FitnessClassWeb.Management.EFAllClasses" %>

<asp:Content ID="Content4" ContentPlaceHolderID="CPHead" runat="server">
    <script src="../Scripts/jquery-3.4.1.js"></script>
    <script src="../JS-SQFile.js"></script>
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="CPBody" runat="server">
    <div id="classes-ad">
        <h1 class="decoration text-center">Classes</h1>
        <div id="flip-ad">
            <div>
                <div>Any Purpose</div>
            </div>
            <div>
                <div>Any Age</div>
            </div>
            <div>
                <div>Any Job</div>
            </div>
        </div>
    </div>

    <p class="text-center">
        <input type="button" class="btn btn-sm " id="goal-button" value="Filter By Goal">
    </p>

    <script>
        $(document).ready(expandGoalButton());
    </script>

    <div class="row justify-content-center" id="contentBody">
        <asp:Repeater ID="RAllClassesEF" runat="server" ItemType="FitnessClassWeb.Models.FitnessClass" SelectMethod="">
            <ItemTemplate>
                <div class="col-3 mx-1 my-1 classesListing">
                    <%--add image HTML--%>
                    <div class="pictures ">
                        <img alt="<%# Item.classTitle %>" src="<%# Item.image %>" class="img" />
                        <div class="centeredTitle">
                            <h3><%# Item.classTitle %></h3>
                        </div>
                    </div>

                    <%-- Class Description go here--%>
                    <p class="classText"><%# shortText(Item.classDescription)%>  </p>

                    <p class="text-center">
                        <a class="btn btn-sm find-out-button" href="#" role="button">find out more</a>
                    </p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="CPScripts" runat="server">
</asp:Content>

