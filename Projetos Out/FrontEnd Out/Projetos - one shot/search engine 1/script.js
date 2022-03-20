function dict() {
    var x = document.getElementById("search").value
    alert(x)
    const url = "https://dictionary.cambridge.org/pt/dicionario/essential-british-english/"
    var url1 = url + x;
    var win = window.open(url1, "_blank")
    win.focus;
}