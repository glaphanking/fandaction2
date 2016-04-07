function gameInfoController($scope, $animateInstance, dataservice, game) {
    $scope.cancel = function () {
        $animateInstance.dismiss('cancel');
    }

    $scope.modalTitle = "Game Info";

}