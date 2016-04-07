function categoryListCtlr($scope, $animate, dataservice) {
    vm = this;

    scope = $scope;

    vm.categories = [];

    loadCategories();

    vm.modalTitle = "Edit Category";

    function loadCategories() {
        return dataservice.getCategories()
            .then(function (result) {
                vm.categories = result.data;
            }, function (err) {
                console.log('error in loadCategories: ' + err.status);
            });
    }
}