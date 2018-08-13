<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompraCine.aspx.cs" Inherits="Capa.UI.CompraCine" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Compra de ticketes</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
        <a class="navbar-brand" href="#">Navbar</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarColor01">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item">
                    <a class="nav-link" href="Default.aspx">Inicio</a>
                </li>
                <li class="nav-item active">
                    <a class="nav-link" href="CompraCine.aspx">Compra Tickets <span class="sr-only">(current)</span></a>
                </li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server" class="container">
        <div class="row">
            <div class="col-lg-8 ">
                <h2>Listado de Compras</h2>
                <asp:GridView ID="GridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table">
                    <RowStyle BackColor="LightBlue"/>
                    <AlternatingRowStyle BackColor="LightGray"/>
                </asp:GridView>
            </div>
            <div class="col-lg-4">
                <fieldset>
                    <legend>Nueva Compra</legend>
                    <div class="form-group">
                        <label for="idFecha">Fecha</label>
                        <input class="form-control" id="idFecha" type="date" runat="server" required/>
                    </div>
                     <div class="form-group">
                        <p>Película  <asp:DropDownList ID="ddlPeliculas" runat="server"></asp:DropDownList></p>
                    </div>
                    <div class="form-group">
                        <label for="idCantNiños">Cantidad Niños</label>
                        <input class="form-control" id="idCantNiños" type="number" min="1" max="50" placeholder="##" runat="server" required/>
                    </div>
                    <div class="form-group">
                        <label for="idCantRegular">Cantidad Regular</label>
                        <input class="form-control" id="idCantRegular" type="number" min="1" max="50" placeholder="##" runat="server" required/>
                    </div>
                       <div class="form-group">
                        <div class="form-group">
                            <label class="control-label">Descuento</label>
                            <div class="form-group">
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text">₡</span>
                                    </div>
                                    <input class="form-control" id="descuento" aria-label="Amount (to the nearest dollar)" type="text" readonly/>
                                    <div class="input-group-append">
                                        <span class="input-group-text">.00</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                       <div class="form-group">
                        <div class="form-group">
                            <label class="control-label">Cargo Servicio</label>
                            <div class="form-group">
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text">₡</span>
                                    </div>
                                    <input class="form-control" id="cargoServicio" aria-label="Amount (to the nearest dollar)" type="text" readonly/>
                                    <div class="input-group-append">
                                        <span class="input-group-text">.00</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-group">
                            <label class="control-label">Total</label>
                            <div class="form-group">
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text">₡</span>
                                    </div>
                                    <input class="form-control" id="total" aria-label="Amount (to the nearest dollar)" type="text" readonly/>
                                    <div class="input-group-append">
                                        <span class="input-group-text">.00</span><button type="button" onclick="" class="btn btn-outline-secondary">Calcular</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btnRegistrar_Click"/>
                </fieldset>
            </div>
        </div>
    </form>
</body>
<script src="Scripts/bootstrap.min.js"></script>
<script src="Scripts/jquery-3.3.1.min.js"></script>
<script src="Scripts/popper.min.js"></script>
</html>

