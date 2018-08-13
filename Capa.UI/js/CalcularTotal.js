function CalcularTotal() {
    var cantiRegular = document.getElementById('idCantRegular').Value;
    var cantiNiños = document.getElementById('idCantNiños').Value;

    if (cantiRegular < 0 || cantiRegular == "" || cantiRegular > 50) {
        alert('Cantidad Regular debe ser un número entre 1 y 50');
        document.getElementById('idCantRegular').focus();
    }

    if (cantiNiños < 0 || cantiNiños == "" || cantiNiños > 50) {
        alert('Cantidad de Niños debe ser un número entre 1 y 50');
        document.getElementById('idCantNiños').focus();
    }
}