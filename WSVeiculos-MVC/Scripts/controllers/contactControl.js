
app.controller('contactControl', function($scope, $rootScope){

    $scope.test = "Estou no contactControl"
    $rootScope.idControl = 3;

    if ($rootScope.idControl == 3) {
        var footer = $('#footer-wrapper');
        footer.css('margin-top', '500px');
    }

});