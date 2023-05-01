var a;
var b;

$(document).ready(function() {


    var sessionCart = $.parseJSON(sessionStorage.getItem("userCart"));
    if (sessionCart != null) {
        showInTable(sessionCart);
    }
    var pp = $("#price").text();
    var x = parseInt(pp);
    var y = $("#quantity").val();
    var z = x * y;
    $("#totalprice").html(z);
    $("#quantity,#product").change(function() {
        a = $("#product").find(":selected").val();
        $("#price").html(a);

        b = $("#product").find(":selected").text();

        var pp = $("#price").text();
        var x = parseInt(pp);
        var y = $("#quantity").val();
        var z = x * y;
        $("#totalprice").html(z);

    });

});



$("#submit").click(function() {
    var sessionData = sessionStorage.getItem("userCart");

    var price = $("#price").text();

    var product = $("#product").find(":selected").text();

    var quantity = $("#quantity").val();

    var total = $("#totalprice").text();
    var id = 0;
    var productDetail = {
        productName: product,
        productPrice: price,
        productQuantity: quantity,
        productTotal: total,
        productId: id
    };
    var userCart = JSON.stringify([productDetail]);
    if (sessionData === null) {
        sessionStorage.setItem("userCart", userCart);
        showInTable($.parseJSON(sessionStorage.getItem("userCart")));

    } else {
        var existUserCart = $.parseJSON(sessionStorage.getItem("userCart"));

        productDetail.productId = existUserCart.length;
        existUserCart.push(productDetail);
        userCart = JSON.stringify(existUserCart);

        sessionStorage.setItem("userCart", userCart);
        showInTable(existUserCart);
    }
});

function deleteProduct(productId) {

    var existUserCart = $.parseJSON(sessionStorage.getItem("userCart"));
    var deleteIndex = existUserCart.findIndex(item => item.productId == productId);
    existUserCart.splice(deleteIndex, 1)

    var userCart = JSON.stringify(existUserCart);

    sessionStorage.setItem("userCart", userCart);

    showInTable(existUserCart)



}

function showInTable(productList) {

    var dataInSession = "";
    var subTotal = 0;

    for (product of productList) {
        dataInSession += `
                        <tr>
                        <td> ${product.productName}</td>
                        <td> ${product.productPrice}</td>
                        <td> ${product.productQuantity}</td>
                        <td> ${product.productTotal}</td>
                            <td class='text-right' width="10%" > 
                            <a href="index.html" id="delete-btn" type="button" onclick="deleteProduct(${product.productId})" class="btn btn-primary"
                            data-bs-toggle="modal" data-bs-target="#myModal">Delete</a>
                            </td>
                        </tr>
                    `;
        subTotal += parseInt(product.productTotal);
    }
    dataInSession += `
                        <tr>
                            <td colspan="3"><strong>Sub Total</strong> </td>
                            <td colspan=""> 
                            <strong>${subTotal}</strong>
                            </td>
                            <td></td>
                        </tr>
    `;
    $('#productCardDetails').html(dataInSession);


}