<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NaytaHenkilot.aspx.cs" Inherits="WebApplication4.NaytaHenkilot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 222px;
        }
        .auto-style4 {
            width: 157px;
        }
        .auto-style5 {
            width: 131px;
        }
        .auto-style6 {
            width: 146px;
        }
        .auto-style7 {
            width: 214px;
        }
       
        

       div.form_div{background-color:#fffacd;}
        .auto-style8 {
            width: 104px;
        }
        .auto-style9 {
            width: 242px;
        }
        .auto-style10 {
            width: 183px;
        }
        .auto-style11 {
            width: 183px;
            height: 24px;
        }
        .auto-style12 {
            height: 24px;
        }
        .auto-style13 {
            height: 24px;
            width: 255px;
        }
        .auto-style14 {
            width: 255px;
        }
        .auto-style15 {
            width: 183px;
            height: 30px;
        }
        .auto-style16 {
            height: 30px;
        }
        .table {
            background-color:#fffacd
        }
        </style>
        <script>
            function showdiv(divname) {
                document.getElementById("henkilodiv").style.display = "none";
                document.getElementById("asuntodiv").style.display = "none";
                document.getElementById("henkilodivpoista").style.display = "none";
                document.getElementById("asuntodivpoista").style.display = "none";
                document.getElementById("henkilomuokkaa").style.display = "none";

                if (divname != null)
                    document.getElementById(divname).style.display = "block";
            }
        </script>
</head>
<body onload="showdiv()">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            <asp:Label ID="DEBUGTEXT" runat="server"></asp:Label>
        </p>
        <asp:GridView ID="GridView1" runat="server" Height="229px" Width="448px">
        </asp:GridView>
            <asp:Button ID="henkiloNappi" runat="server" OnClick="henkiloNappi_Click" Text="Näytä Henkilöt" />
        <input id="Button1" type="button" value="Lisää Henkilö" onclick="showdiv('henkilodiv')"/><asp:Button ID="asunnotNappi" runat="server" OnClick="asunnotNappi_Click" Text="Näytä Asunnot" />
            &nbsp;<input id="Button2" type="button" value="Lisää Asunto" onclick="showdiv('asuntodiv')"/>
        <input id="Button5" type="button" onclick="showdiv('henkilodivpoista')" value="Poista Henkilö" />
        <input id="Button6" type="button" onclick="showdiv('asuntodivpoista')" value="Poista Asunto" />
        <input id="Button7" type="button" onclick="showdiv('henkilomuokkaa')" value="Muokkaa..." />
        <div class="form_div" id="henkilodiv">
        <table style="background-color:#fffacd;">
            <tr>
                <td class="auto-style7">HenkilöID</td>
                <td class="auto-style4">Etunimi</td>
                <td class="auto-style6">Sukunimi</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:TextBox ID="hID" runat="server" Width="83px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="henimi" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="hsnimi" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">Syntymäaika (YEAR-MM-DD)</td>
                <td class="auto-style4">Sukupuoli</td>
                <td class="auto-style6">Asunto</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:TextBox ID="hsaika" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="sukupuoliList" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="auto-style6">
                    <asp:DropDownList ID="asunnotLista" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="auto-style1">
                    <asp:Button ID="lisaaHenkilo" runat="server" Text="Lisää Henkilö" OnClick="lisaaHenkilo_Click" />
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            </table>
    </div>
        <div class="form_div" id="asuntodiv">
            <table style="width:100%;">
                <tr>
                    <td>AsuntoID</td>
                    <td>Osoite</td>
                    <td class="auto-style6">Pinta-ala</td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:TextBox ID="aID" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="aosoite" runat="server" Width="226px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="aala" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">Huonelkm</td>
                    <td class="auto-style9">Tyyppi</td>
                    <td class="auto-style6">
                        <asp:CheckBox ID="aomistus" runat="server" Text="Omistusasunto?" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:TextBox ID="ahlkm" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
                        <asp:DropDownList ID="atyyppi" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>
                        <asp:Button ID="lisaaAsunto" runat="server" Text="Lisää Asunto" OnClick="lisaaAsunto_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <div id="henkilodivpoista" class="form_div">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style11">HenkilöID</td>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:TextBox ID="hID_poista" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Poista Henkilö" OnClick="Button3_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <div id="asuntodivpoista" class="form_div">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style11">AsuntoID</td>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:TextBox ID="aID_poista" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style16">
                        <asp:Button ID="Button4" runat="server" Text="Poista Asunto" OnClick="Button4_Click" />
                    </td>
                    <td class="auto-style16"></td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <div id="henkilomuokkaa" class="form_div">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style11">HenkilöID</td>
                    <td class="auto-style13">Asunto</td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:TextBox ID="hID2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style14">
                        <asp:DropDownList ID="asunnotLista2" runat="server" Width="192px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Valmis" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
    </body>
</html>
