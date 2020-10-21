

function Numeros()
{
    var key = window.event.keyCode;
    if (key 57) {
        window.event.keyCode = 0;
    }

}

function letras()
{
    var key = window.event.keyCode;
    if (key 57) {

    }
    else
    {
        window.event.keyCode = 0;
    }

}
function solonumeros(e) {

    var key;

    if (window.event) // IE
    {
        key = e.keyCode;
    }
    else if (e.which) // Netscape/Firefox/Opera
    {
        key = e.which;
    }

    if (key < 48 || key > 57) {
        return false;
    }

    return true;
}