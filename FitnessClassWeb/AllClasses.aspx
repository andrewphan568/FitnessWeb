<%@ Page Title="Yoga, Bootcamp, RPM | The biggest range of gym classes - Goodlife Health Clubs"
    Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllClasses.aspx.cs"
    Inherits="FitnessClassWeb.AllClasses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CPHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="CPBody" runat="server">
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
        <input type="button" class="btn btn-sm" id="goal-button" value="Filter By Goal">
    </p>

    <script>
        $(document).ready(expandGoalButton());
    </script>


    <div class="row justify-content-center" id="contentBody">
        <asp:Repeater ID="RFitnessClass" runat="server" DataSourceID="SDSFitnessClass">
            <ItemTemplate>
                <div class="col-3 mx-1 my-1 classesListing">
                    <%--add image HTML--%>
                    <div class="pictures ">
                        <img alt='<%# Eval("classTitle") %>' src='<%# Eval("image") %>' class="img" />
                        <div class="centeredTitle">
                            <h3><%# Eval("classTitle") %></h3>
                        </div>
                    </div>
                    <%-- add Class Description--%>
                    <p class="classText"><%# shortText(Eval("classDescription"))%></p>
                    <p class="text-center">
                        <a class="btn btn-sm find-out-button" href="#" role="button">find out more</a>
                    </p>
                </div>
            </ItemTemplate>
            <FooterTemplate>
            </FooterTemplate>
        </asp:Repeater>
    </div>

    <asp:SqlDataSource ID="SDSFitnessClass" runat="server"
        ConnectionString="<%$ ConnectionStrings:FitnessClassWebConnectionString %>"
        SelectCommand="SELECT [classID], [classTitle], [classDescription], [image] FROM [FitnessClasses] 
        WHERE ([active] = @active) ORDER BY [classID]">
        <SelectParameters>
            <asp:Parameter DefaultValue="true" Name="active" Type="Boolean" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="CPScripts" runat="server">
</asp:Content>
