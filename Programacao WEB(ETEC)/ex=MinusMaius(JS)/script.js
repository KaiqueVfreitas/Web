function Pesquisar()
{
    var sigla = document.getElementById("txtSigla").value;
    if (sigla.toUpperCase()=="1ADS")
    {
        document.getElementById("txtTurma").value="1 modulo DS";
        document.getElementById("txtPeriodo").value="Período Tarde";
    }
    else if (sigla.toUpperCase()=="2ADS")
    {
        document.getElementById("txtTurma").value="2 modulo DS";
        document.getElementById("txtPeriodo").value="Período Tarde";
    }
    else if (sigla.toUpperCase()=="3ADS")
    {
        document.getElementById("txtTurma").value="3 modulo DS";
        document.getElementById("txtPeriodo").value="Período Tarde";
    }
    else if (sigla.toUpperCase()=="1BDS")
    {
        document.getElementById("txtTurma").value="1 modulo DS";
        document.getElementById("txtPeriodo").value="Período NOite";
    }
    else if (sigla.toUpperCase()=="2BDS")
    {
        document.getElementById("txtTurma").value="2 modulo DS";
        document.getElementById("txtPeriodo").value="Período Noite";
    }
    else if (sigla.toUpperCase()=="3BDS")
    {
        document.getElementById("txtTurma").value="3 modulo DS";
        document.getElementById("txtPeriodo").value="Período Noite";
    }
    else
    {
        document.getElementById("txtTurma").value="2 modulo DS";
        document.getElementById("txtPeriodo").value="Período Tarde";
    }
}