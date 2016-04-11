function settingsCtlr($scope, $animate, dataservice) {
    
    vm = this;
    scope = $scope;

    vm.settings = [];

    loadSettings();

    vm.modalTitle = "Edit Setting";

    function loadSettings() {
        return dataservice.getSettings()
            .then(function (result) {
                vm.settings = result.data;
            }, function (err) {
                console.log('error in loadSettings: ' + err.status);
            });
    }

    vm.editSetting = function (setting) {
        var modalInstance = $animate.open({
            templateUrl: 'views/modals/editSetting.html',
            size: 'sm',
            controller : editSettingController,
            resolve: { setting: function() { return setting; }}
        });
    }

    vm.addSetting = function(){

    }
}