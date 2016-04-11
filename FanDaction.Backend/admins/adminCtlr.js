function adminCtlr($scope, $animate, adminservice) {
    vm = this;
    vm.admins = [];
    loadAdminList();

    function loadAdminList() {
        return adminservice.getAdminList()
            .then(function (result) {
                vm.admins = result.data;
            }, function (err) {
                
            });
    }

    function checkPermissions(permission) {
        if (permission == "canEdit")
            return permissions.canEdit;
    }
}