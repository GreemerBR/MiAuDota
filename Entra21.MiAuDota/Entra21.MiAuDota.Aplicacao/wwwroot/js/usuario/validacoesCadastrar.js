function mascara(i) {

    var v = i.value;

    if (isNaN(v[v.length - 1])) { 
        i.value = v.substring(0, v.length - 1);
        return;
    }

    i.setAttribute("maxlength", "14");
    if (v.length == 3 || v.length == 7) i.value += ".";
    if (v.length == 11) i.value += "-";

}
function mascaraTel(telefone) {

    var v = telefone.value;

    if (isNaN(v[v.length - 1])) {
        telefone.value = v.substring(0, v.length - 1);
        return;
    }

    telefone.setAttribute("maxlength", "12");
    if (v.length == 2) telefone.value += " ";
    if (v.length == 7) telefone.value += "-";
}
//bug de apagar depois do length 2