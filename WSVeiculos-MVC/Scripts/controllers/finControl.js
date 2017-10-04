
app.controller('finControl', function ($scope, $rootScope) {

    $scope.test = "Estou no finControl";
    $rootScope.idControl = 2;

    if ($rootScope.idControl == 2) {
        var page = $('.page');
        page.css('margin-top', '400px');
    }


    
});