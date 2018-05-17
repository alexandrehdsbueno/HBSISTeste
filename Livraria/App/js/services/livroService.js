angular.module("livrariaApp").service("livroService", function ($http, config) {

	var _listar = function () {
		return $http.get(config.baseUrl + "/Livros/Listar");
	};

	var _obter = function (id) {
		return $http.get(config.baseUrl + "/Livros/Obter/" + id);
	};

	var _salvar = function (livro) {
		return $http.post(config.baseUrl + "/Livros/Salvar", livro);
	};

	var _excluir = function (id) {
		return $http.delete(config.baseUrl + "/Livros/Excluir/" + id);
	};

	return {
		listar: _listar,
		obter: _obter,
		salvar: _salvar,
		excluir: _excluir
	};

});