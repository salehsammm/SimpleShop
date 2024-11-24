var app = angular.module("MyApp", []);
app.controller("MyCtrl", function ($scope, $compile, $http) {

    $scope.products = [];
    $http.get('/Home/GetProducts')
        .then(function (response) {
            $scope.products = response.data.products;
            $scope.cartItems = response.data.sh;
        });

    $scope.AddToCart = function (productId) {
        var productId = $scope.productId;
        alert(productId);

        $.ajax({
            type: "post",
            url: "/Home/AddToCart",
            data: {
                productId: productId
            },
            datatype: "json",
            success: function (data) {
                alert("test");
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