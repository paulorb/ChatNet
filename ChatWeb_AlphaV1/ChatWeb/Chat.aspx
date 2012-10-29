<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="ChatWeb.Chat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
    <script src="//ajax.googleapis.com/ajax/libs/jqueryui/1.8.23/jquery-ui.min.js"></script>
    <script src="Scripts/jquery.dialog.extra.js" type="text/javascript"></script>
    <link rel="stylesheet" type="text/css" href="http://code.jquery.com/ui/1.9.0/themes/base/jquery-ui.css" />
    
    <script language="javascript">


    


        if (jQuery) {
            // jQuery is loaded
            $(function () {
                $("#dialog").dialog();
                $("#dialog").dialog('option', 'resizable', false);
                $("#dialog").dialog('option', 'position', 'bottom');
                $("#dialog").dialog({ canMinimize: true });

            });
        } else {
            // jQuery is not loaded
        }


        function Contato() {
            this.ID = 0,
            this.Nome = ""
        }


        //Classe que gerencia a tela principal que tera a lista de contatos
        var ChatMainWindowManager = {
            CreateMainWindow: function (username, senha) {
                $("#ChatMainWindow").dialog({width:200,height:700});

            }
        }



        var ChatManager = {
            username: "",
            password: "",
            mapWindows: {},
            PegaListaDeContatos: function (username, senha) {
                var arguments = new Object();
                arguments.username = username;
                arguments.password = senha;
                $.ajax({
                    url: 'Chat.asmx/PegaListaDeContatos',
                    type: "POST",
                    data: JSON.stringify(arguments),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (data) {
                        var i = 0;
                        for (i = 0; i < data.d.length; i++) {
                            $("#usuarios").append("<div id=\"usuario_" + data.d[i] + "\" onclick=\"ChatManager.OpenOrCreateChatWindow('" + data.d[i] + "','" + data.d[i] + "')\" onmouseout=\"$(this).css('background-color','white')\"  onmouseover=\"$(this).css('background-color','gray')\"> <div id=\"status\" style=\"float:left\"> <p>" + "OFF" + "</p> </div><div id=\"username\"  style=\"float:right\"><p>" + data.d[i] + "</p> </div><div id=\"sep\"  style=\"clear:both\"> </div></div>");
                        }
                        alert(data);
                    },
                    error: function (error) {
                        alert('error');
                    }
                });
            },
            IsContatoOnline: function (id) {

            },
            OpenOrCreateChatWindow: function (id, TitletargetUser) {
                if (this.mapWindows[id] == null) {
                    this.mapWindows[id] = "CREATED";
                    //create the window

                    var cur_num = 1;    // Counter used previously.
                    //...
                    var cloned = $("#ChatWindowBase").clone(true, true).get(0);
                    cloned.id = "ChatWindow_" + id;                  // Change the div itself.
                    $(cloned).find("*").each(function (index, element) {   // And all inner elements.
                        if (element.id) {
                            var matches = element.id.match(/(.+)_\d+/);
                            if (matches && matches.length >= 2)            // Captures start at [1].
                                element.id = matches[1] + "_" + id;
                        }
                    });
                    $(cloned).appendTo($("body"));
                    $("#ChatWindow_" + id).dialog();
                    $("#ChatWindow_" + id).dialog('option', 'title', TitletargetUser);
                    $("#ChatWindow_" + id).dialog('option', 'resizable', false);
                    $("#ChatWindow_" + id).dialog('option', 'position', 'bottom');
                    $("#ChatWindow_" + id).dialog({ canMinimize: true });

                } else {
                    //    $("#ChatWindow_" + id).dialog('option', 'position', 'bottom');
                    if ($("#ChatWindow_" + id).dialog("isOpen") == false) {
                        $("#ChatWindow_" + id).dialog("destroy");
                        $("#ChatWindow_" + id).dialog();
                        $("#ChatWindow_" + id).dialog('option', 'title', TitletargetUser);
                        $("#ChatWindow_" + id).dialog('option', 'resizable', false);
                        $("#ChatWindow_" + id).dialog('option', 'position', 'bottom');
                        $("#ChatWindow_" + id).dialog({ canMinimize: true });
                    } else {


                        $("#ChatWindow_" + id).dialog('restore');
                    }
                }
            },
            AdicionaMensagemTela: function (idTarget, nome, msg) {
                $("#ChatWindow_" + idTarget).children().children().append("<br/><div><div style=\"float:left\"><img src=\"user_male.png\" width=\"30\" height=\"30\" /></div > <div style=\"float:left\">" + nome + ": " + msg + " </div > <div style=\"clear:both;\"></div> </div>");

            },
            SendMessage: function (destinationUser, message) {

                //                $.ajax({
                //                    url: '~/Chat.asmx/SendMessage',
                //                    success: function (data) {
                //                        $('.result').html(data);
                //                        alert('Load was performed.');
                //                    },
                //                    error: function (error) {

                //                    }
                //                });
            },
            InitiateMonitoringNewMessages: function () {
                setInterval(MonitoringFunction, 1000);
            },
            MonitoringFunction: function () {

            }



        };

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <%--Chat Window--%>
<div id="dialog" title="Chat">
  
   <div>
     <div id="div_mensagens"  style="overflow-x:hidden;overflow-y:auto;height:250px">
         
     </div>
     <div style="background-color:#fff;">
    <input type="text" style="width:80%;float:left" />
    <input type="button"   style="width:10%;float:left" />
    
    </div>  
   </div>
</div>
    
    
 <div id="ChatWindowBase" title="Chat" style="display:none">
  
   <div>
     <div id="div_mensagens"  style="overflow-x:hidden;overflow-y:auto;height:250px">
         
     </div>
     <div style="background-color:#fff;">
    <input type="text" style="width:80%;float:left" />
    <input type="button"   style="width:10%;float:left" />
    
    </div>  
   </div>
</div>
    

 <div id="ChatMainWindow" title="LiveClass Chat" style="display:none">
  
   <div>
   <div id="LogoDiv">
     <%--colocar logo do live class aqui--%>
   </div>
   <div id="StatusENome">
   
   
   </div>

   <div id="linhaDivisoria"></div>
   <div id="usuarios">
   
   
   
   </div>

   

   </div>
</div>



    
    
    </div>
    </form>


 <%--   <div id="usuario_username12132">
        <div id="status" style="float:left"> </div>
        <div id="username"  style="float:right"> </div>
        <div id="sep"  style="clear:both"> </div>
    
    </div>--%>


</body>
</html>
