function lobbyCtlr($scope, $animate, dataservice) {
    var scope = $scope;
    var vm = this;

    vm.BAR = '';

    vm.games = [
        { id: 1, contest: 'pick 5', entries: 1, size: 4, fee: '$1.00', prize: '$5.00', sport: 'mlb', live: '10:00:41' },
        { id: 2, contest: 'pick 10', entries: 2, size: 2, fee: '$10.00', prize: '$50.00', sport: 'mlb', live: '00:05:00' },
        { id: 3, contest: 'Salary Cap', entries: 1, size: 2, fee: '$15.00', prize: '$45.00', sport: 'mlb', live: '00:49:32' },
        { id: 1, contest: 'Pick 10 1st Half', entries: 1, size: 4, fee: '$1.00', prize: '$5.00', sport: 'mlb', live: 'Game Started' }
    ];


    loadGames();

    function loadGames(category) {
        var cat = category;
    }

    function openGameInfo(game){
        var modalInstance = $animate.open({
            templateUrl: 'views/modals/gameInfo.html',
            controller: gameInfoController,
            size: 'lg',
            resolve: { game: function () { return game; } }
       });
    }
}