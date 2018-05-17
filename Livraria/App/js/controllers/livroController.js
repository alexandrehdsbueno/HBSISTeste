var livrariaApp = angular.module("livrariaApp", []);

livrariaApp.controller("livroController", function($scope, livroService){
	$scope.livro = {};
	$scope.info = "";
	$scope.isEdit = false;
	$scope.livros = [ ];

	$scope.Salvar = function(){
		if (isValid()) {
			livroService.salvar($scope.livro).then(function(result){
				if (result.data.success) {
					listar();
					$scope.info = "Livro cadastrado com sucesso!";
					$scope.livro = {};
				}
			});	
		}
	};

	$scope.obterLivroSelecionado = function(livro){
		$scope.isEdit = true;
		$scope.livro = angular.copy(livro);
	};

	$scope.excluir = function(){
		livroService.excluir($scope.livro.id).then(function(result){
			if (result.data.success) {
				listar();
				$scope.info = "Livro excluído com sucesso!";
			}
		});
	};

	$scope.clearInfo = function(){
		$scope.info = "";
	};

	$scope.openModal = function(){
		$scope.livro = {};
		$scope.isEdit = false;
	}

	function listar(){
		livroService.listar().then(function(result){
			if (result.data.success) {
				$scope.livros = angular.copy(result.data.data);
			}
		});
	}

	function isValid(){
		if (!$scope.livro.titulo){
			alert('Os campos com * são obrigatórios!');
			return false;
		}

		if (!$scope.livro.autor){
			alert('Os campos com * são obrigatórios!');
			return false;
		}

		if (!$scope.livro.dataPublicacao){
			alert('Os campos com * são obrigatórios!');
			return false;
		}
		
		return true;
	}

	listar();
});