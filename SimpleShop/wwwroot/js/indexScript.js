var app = angular.module("MyApp", []);
app.controller("MyCtrl", function ($scope, $compile, $http) {

    $scope.filterText = '';

    $scope.products = [];
    $scope.Cartproducts = [];
    $http.get('/Home/GetProducts')
        .then(function (response) {
            $scope.products = response.data.products;
            $scope.cartItems = response.data.shopingCartItems;
        });

    var CartPros = [];
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
        //alert(productId);
        $scope.productId = productId;
        window.location.href = "/Home/ProductDetail";
    }

    $scope.DeleteProduct = function (productId) {
        alert(productId);
        //$.ajax({
        //    type: "post",
        //    url: "/Home/DeleteProduct",
        //    data: {
        //        productId: productId
        //    },
        //    datatype: "json",
        //    success: function (data) {
        //        $scope.Cartproducts = data;
        //        $scope.$apply();
        //    }
        //});
    }

});