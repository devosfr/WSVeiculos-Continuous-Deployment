
app.config(function($routeProvider){

  $routeProvider.when('/home', { templateUrl: 'Views/main.html', controller:'mainControl'}).when('/contato', { templateUrl: '.Views/Contato/contato.html', controller:'contactControl'}).when('/financiamento', { templateUrl: './Views/Financiamento/financiamento.html', controller:'finControl'}).otherwise({
  	redirectTo: '/'
  });

});



app.config(function($httpProvider){
   $httpProvider.defaults.useXDomain = true;
   delete $httpProvider.defaults.headers.common['X-Requested-With'];
});