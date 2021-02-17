

function CadastrarContato() {

	var valor = document.getElementById("inputContato").nodeValue;

	var enderecoCompleto = window.location.protocol + "//" + window.location.host + "/tarefa/" 

	var urlParam = enderecoCompleto + valor

	alert(urlParam)

	window.location.href = enderecoCompleto;
}