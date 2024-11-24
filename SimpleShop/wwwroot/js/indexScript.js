var app = angular.module("MyApp", []);
app.controller("MyCtrl", function ($scope, $compile, $http) {

    $scope.products = [];
    $scope.Cartproducts = [];
    $http.get('/Home/GetProducts')
        .then(function (response) {
            $scope.products = response.data.products;
            $scope.cartItems = response.data.shopingCartItems;
        });

    $scope.AddToCart = function (productId) {
        //alert(productId);
        $.ajax({
            type: "post",
            url: "/Home/AddToCart",
            data: {
                productId: productId
            },
            datatype: "json",
            success: function (data) {
                $scope.Cartproducts = data;
                $scope.$apply();
            }
        });

    }

    $scope.GoToDetail = function (productId) {

        alert($scope.productId);
    }

    $scope.Test = function () {
        alert("Test");
    }

});