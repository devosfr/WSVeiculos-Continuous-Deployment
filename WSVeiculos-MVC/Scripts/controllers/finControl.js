
app.controller('finControl', function ($scope, $rootScope) {

    $scope.test = "Estou no finControl";
    $rootScope.idControl = 2;

    if ($rootScope.idControl == 2) {
        var page = $('.page');
        page.css('margin-top', '400px');
    }


    var toogle = false;

    $('#financiamento-1B').hide();
    $('#financiamento-2B').hide();
    $('#financiamento-3B').hide();

    $scope.toogleFunction = function (id) {
        

        //var img1 = document.getElementById('financiamento-1');


        if (toogle && id == 1) {
            $('#financiamento-1B').hide();
            $('#financiamento-1').show();
            toogle = false
        } else if (toogle == false && id == 1) {
            $('#financiamento-1B').show();
            $('#financiamento-1').hide();
            toogle = true
        }

      
        if (toogle && id == 2) {
            $('#financiamento-2B').hide();
            $('#financiamento-2').show();
            toogle = false
        } else if (toogle == false && id == 2) {
            $('#financiamento-2B').show();
            $('#financiamento-2').hide();
            toogle = true
        }

        if (toogle && id == 3) {
            $('#financiamento-3B').hide();
            $('#financiamento-3').show();
            toogle = false
        } else if (toogle == false && id == 3) {
            $('#financiamento-3B').show();
            $('#financiamento-3').hide();
            toogle = true
        }



    }

    
});