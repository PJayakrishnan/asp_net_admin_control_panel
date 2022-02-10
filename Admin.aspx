<%@ Page Title="Admin.aspx" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="asp.net_login.WebForm1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br /><br /><br /><br />
   <div class="row">
       <div class="col-md-12 text-center">
       <div class="panel-heading text-center">Admin Control Panel</div><br />
         <div class="container">
      <div class="row">
          <div class="col-sm-3">
                   <div class="form-group panel panel-info">
                       <div class="panel-body panel-adminColor1">
                      <label for="TextBoxDefaultPageText1">Defaul Page Text 1:</label>
                      <asp:TextBox ID="TextBoxDefaultPageText1" class="form-control text-center" runat="server" TextMode="MultiLine"></asp:TextBox>
                      </div>
                    </div>
          </div>
          <div class="col-sm-3">
                    <div class="form-group panel panel-info">
                        <div class="panel-body panel-adminColor2">
                      <label for="TextBoxDefaultPageText2">Defaul Page Text 2:</label>
                      <asp:TextBox ID="TextBoxDefaultPageText2" class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                      </div>
                    </div>
          </div>
          <div class="col-sm-3">
                    <div class="form-group panel panel-info">
                        <div class="panel-body panel-adminColor3">
                      <label for="TextBoxHeaderText">Header Text:</label>
                      <asp:TextBox ID="TextBoxHeaderText" class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                      </div>
                    </div>
          </div>
          <div class="col-sm-3">
                    <div class="form-group panel panel-info">
                        <div class="panel-body panel-adminColor4">
                      <label for="TextBoxFooterText">Footer Text:</label>
                      <asp:TextBox ID="TextBoxFooterText" class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                      </div>
                    </div>
          </div>
      </div>
          <br />
        <div class="row">
                    <div class="col-sm-12">
                        <div class="text-center">
                        <asp:Button ID="ButtonSaveAdmin" type="submit" class="btn btn-primary btn-lg" runat="server" Text="Save" OnClick="ButtonSaveAdmin_Click" />
                        </div>
                    </div>
        </div>
    </div><br /><br />
       </div>
       
   </div>
    
    
      

</asp:Content>
