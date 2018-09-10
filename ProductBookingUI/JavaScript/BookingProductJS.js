function Admin ()
{
  location.href = "./admin.html";
}

function User()
{
    location.href = "./user.html";
}
function Product(evt, productName)
{

    var i, productcontent, ProductLinks;
    productcontent = document.getElementsByClassName("product-content");
    for (i = 0; i < productcontent.length; i++) {
        productcontent[i].style.display = "none";
    }
    ProductLinks = document.getElementsByClassName("ProductLinks");
    for (i = 0; i < ProductLinks.length; i++) {
        ProductLinks[i].className = ProductLinks[i].className.replace(" active", "");
    }

    document.getElementById(productName).style.display = "block";
    evt.currentTarget.className += " active";

}

function ProductList(evt, productName)
{

  var productlistcontent, i, ProductLinks;;
  productlistcontent = document.getElementsByClassName("product-list-content");
  for (i = 0; i < productlistcontent.length; i++) {
      productlistcontent[i].style.display = "none";
  }
  ProductLinks = document.getElementsByClassName("ProductLinks");
  for (i = 0; i < ProductLinks.length; i++) {
      ProductLinks[i].className = ProductLinks[i].className.replace(" active", "");
  }
  evt.currentTarget.className += " active";

  var xmlhttp = new XMLHttpRequest();
  xmlhttp.open("GET", "http://localhost:59188/api/"+productName, true);
  xmlhttp.send();
  xmlhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200)
    {
        document.getElementById(productName).style.display = "block";
        var myObj = JSON.parse(this.responseText);
        var productDetails = "";
        myObj.forEach(product =>{
          productDetails +=
                  "<div class='product'>"+
                      "<div><h3>" + product.ProductName + "</h3></div>" +
                      "<div>"+"Book At: $"+product.ProductPrice +"</div>" +
                      "<div>" +"Fare: " +product.ProductFare + "/-"+"</div>" +"<br>"+
                      "<button class = 'product-list-action'>BOOK</button>" + "<button class = 'product-list-action'>SAVE</button>" +
                  "</div>"+"<br>"

        });
        document.getElementById(productName).innerHTML = productDetails;
    }
  };

}

function AddData(product)
{
    var xmlhttp = new XMLHttpRequest();
    var arr = document.getElementById(product);
    var object = {};
    for(let i=0;i<arr.length;i++)
    {
        object[document.getElementById(product).elements.item(i).getAttribute("name")] = document.getElementById(product).elements.item(i).value;
    }

    object = JSON.stringify(object);

    xmlhttp.open("POST", "http://localhost:59188/api/"+product, true);
    xmlhttp.setRequestHeader("Content-Type", "application/json; charset=utf-8");
    xmlhttp.send(object);

}

function toggle(id)
{
    console.log(id);

}
