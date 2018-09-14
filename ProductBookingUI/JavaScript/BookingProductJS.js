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
        const s = productName;
        var myObj = JSON.parse(this.responseText);
        var productDetails = "";
        myObj.forEach(product =>{
          productDetails +=
                  "<div class='product'>"+
                      "<div><h3>" + product.ProductName + "</h3></div>" +
                      "<div>"+"Book At: $"+product.ProductPrice +"</div>" +
                      "<div>" +"Fare: " +product.ProductFare + "/-"+"</div>" +"<br>";
                      if(product.IsBooked==false)
                      {
                        productDetails +="<button class = 'product-list-action book-color' onclick='book("+product.Id+",\""+productName+"\")'>BOOK</button>";
                      }
                      else
                      {
                        productDetails +="<button class = 'product-list-action not-available-color' onclick='book("+product.Id+",\""+productName+"\")'>NOT AVAILABLE</button>";

                      }
                      if(product.IsSaved==false)
                      {
                        productDetails +="<button class = 'product-list-action save-color'onclick='save("+product.Id+",\""+productName+"\")'>SAVE</button>";
                      }
                      else
                      {
                        productDetails +="<button class = 'product-list-action saved-color'onclick='save("+product.Id+",\""+productName+"\")'>ALREADY SAVE</button>";
                      }

                  productDetails +="</div>"+"<br>";
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

function book(id,product)
{
    var xmlhttp = new XMLHttpRequest();
    var object =
    {
      "id" : id,
      "action":"book"
    }
    object = JSON.stringify(object);

    xmlhttp.open("PUT", "http://localhost:59188/api/"+product, true);
    xmlhttp.setRequestHeader("Content-Type", "application/json; charset=utf-8");
    xmlhttp.send(object);
}

function save(id,product)
{
  var xmlhttp = new XMLHttpRequest();
  var object =
  {
    "id" : id,
    "action":"save"
  }
  object = JSON.stringify(object);

  xmlhttp.open("PUT", "http://localhost:59188/api/"+product, true);
  xmlhttp.setRequestHeader("Content-Type", "application/json; charset=utf-8");
  xmlhttp.send(object);
}
