<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="asp.net_login.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br /><br /><br /><br />
 <div class="row">
     <div class="col-sm-4"></div>
          <div class="col-sm-4">  
            <div class="panel panel-primary">
                <div class="panel-heading text-center">LOGIN</div>
               <div class="panel-body panel-lightBlue">
                  <br /><br /><br />
                           <div class="text-center">
                               <div class="form-group">
                                <label for="TextBoxEmail" class="form-label"> User Name</label>
                                <asp:TextBox ID="TextBoxEmail" runat="server" aria-describedby="emailHelp" placeholder="User Name"></asp:TextBox>
                              </div>

                              <div class="form-group">
                                <label for="TextBoxPassword" class="form-label">Password</label>
                                <asp:TextBox ID="TextBoxPassword" runat="server" aria-describedby="emailHelp" placeholder="Password" TextMode="Password "></asp:TextBox>
                              </div>

                                  <asp:Button ID="ButtonSubmit" class="btn btn-primary" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" /><br />
                                  <asp:Label ID="LabelMessage" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                           </div>
                   <br /><br /><br />
               </div>  
            </div>
          </div>
        <div class="col-sm-4"></div>
     </div>

</asp:Content>