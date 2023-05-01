$(document).ready(function() {
    getData();
    getData1()
    pagination()
    $("#search").on("keyup", function() {
        var value = $(this).val().toLowerCase();
        $("#myTable #tbody tr").filter(function() {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });

});
old_id = -1;

var isConfirm = false;
var updatedData = {};

$("#plus").click(function(e) {

    e.preventDefault();
    let addnewrow = `
    <tr class="newTr">
  
    <td><input type="text" id="name" placeholder="Enter Your Name" required/></td>
    <td><input type="email" id="email" placeholder="Enter Your email" required/></td>
    <td> <input type="tel" id="phone" placeholder="Enter your Contact Number" required/> </td>
    <td> 
        <select id="gender" name="gender" class="w-100">
           
            <option value="male" selected >male</option>
            <option value="female">female</option>
        </select>
    <td>  <input type="text" id="enquiry" placeholder="Enter Enquiry" required/></td>
    <td>  <input type="text" id="message" placeholder="Enter Message" required/></td>

    <td>
        <button onclick="add()" class="btn btn-dark " id="submit" type="button" >Add</button>
        <button onclick="clearform()" class="btn btn-dark " id="clearform" type="button" >Clear</button>
        <button id="close" onclick="closetr()" class="btn btn-dark " >close</button>      
    </td>
    </tr>
    
    `;
    $("#tbody").append(addnewrow);
    $('#plus').attr("disabled", true);
})


function add() {
    let x = validate();
    if (!x) {
        console.log("hi");
        return;
    }

    $("#warning").html("");

    var name = $("#name").val();
    var email = $("#email").val();
    var phone = $("#phone").val();
    var gender = $("#gender :selected").val();
    var enquiry = $("#enquiry").val();
    var message = $("#message").val();
    let id = 0

    let detail = {
        name: name,
        email: email,
        phone: phone,
        gender: gender,
        enquiry: enquiry,
        message: message,
        id: id
    };

    $.ajax({
        type: "POST",
        url: 'https://63f5d9a559c944921f67c027.mockapi.io/data',
        data: detail,
        async: false,
        dataType: "json",
        success: function(detail) {
            console.log("bsdf");
            location.reload();
        },
        error: function(error) {
            jsonValue = jQuery.parseJSON(error.responseText);
            alert(error.responseText);
        }


    })
    $('#plus').attr("disabled", false);
    getData()
    location.reload();

}

function clearform() {
    $("#name").val('');
    $("#email").val('');
    $("#phone").val('');
    $("#gender").val('');
    $("#enquiry").val('');
    $("#message").val('');
}

function closetr() {
    $("#close").closest('tr').remove();
    $('#plus').attr("disabled", false);

}
var totalrow = 1;
var currentpage = 1;
var page = 0;
var tablerow = 0;

function getData() {
    const url = new URL('https://63f5d9a559c944921f67c027.mockapi.io/data');
    url.searchParams.append('page', 1);
    url.searchParams.append('limit', 10);
    $.ajax({
        type: 'GET',
        dataType: "json",
        url,
        async: false,

        beforeSend: function() {
            $("#trLoader").show();
        },
        success: function(details) {
            $("#trLoader").remove();
            data = details;
            if (details != null && details.length != 0) {
                var dataInSession = "";
                let maleTotal = 0;
                let femaleTotal = 0;
                for (data of details) {
                    dataInSession += `
                    <tr id="${data.id}">
                    
                  
                    <td>${data.name}</td>
                    <td>${data.email}</td>
                    <td>${data.phone}</td>
                    <td>${data.gender}</td>
                    <td>${data.enquiry}</td>
                    <td>${data.message}</td>
                    <td> 
                    <button onclick="deleteid(${data.id})" class = "link btn btn-dark text-white" ><i class="fa-regular fa-trash"></i></button>
                    <button onclick="editid(${data.id})" class = "link btn btn-dark text-white edit" data-bs-toggle="modal" data-bs-target="#staticBackdrop" id="btn-edit" ><i class="fa-regular fa-pen-to-square"></i></button>
                    </td>
                    </tr>


                    `
                    if (data.gender == 'male') {
                        maleTotal++;
                    } else if (data.gender == 'female') {
                        femaleTotal++;
                    };
                    totalrow = details.length;


                }
                $("#tbody").html(dataInSession);
                $("#totalEnquires").html(details.length);

                $("#maleEnquiries").text(maleTotal);
                $("#femaleEnquires").text(femaleTotal);
            }


        }
    })
}

function deleteid(id) {
    var notification = confirm("Do you want to delete ?");
    if (notification == true) {
        $.ajax({

            type: "DELETE",
            url: 'https://63f5d9a559c944921f67c027.mockapi.io/data/' + id,
            dataType: "json",
            success: function() {
                console.log("deleted succesfully");
                getData();
                pagerow(currentpage, tablerow);
                location.reload();
            }
        })

    }



}

function newclearform() {
    $("#newname").val('');
    $("#newemail").val('');
    $("#newphone").val('');
    $("#newgender").val();
    $("#newequiry").val('');
    $("#newmessage").val('');
}

function editid(id) {
    $.ajax({
        url: "https://63f5d9a559c944921f67c027.mockapi.io/data/" + id,
        type: "GET",
        dataType: "json",
        success: function(data) {
            console.log(data);
            updatedData = data;
            if (data != null) {
                $("#updateName").val(data.name);
                $("#updateEmail").val(data.email);
                $("#updatePhone").val(data.phone);
                $("#updateGender").val(data.gender);
                $("#updateEnquiry").val(data.enquiry);
                $("#updateMessage").val(data.message);
            }
        },
        error: function(xhr, textStatus, errorThrown) {
            console.log("Error in Database");
        },
    });
}
$("#NewUpdatedData").click(function() {
    event.preventDefault();
    let x = validate1();
    if (!x) {
        console.log("hi");
        return;
    } else {
        isConfirm = confirm("Do you want to update!");

        let fname = $("#updateName").val();
        let email = $("#updateEmail").val();
        let phone = $("#updatePhone").val();
        let gender = $("#updateGender").find(":selected").val();
        let enquiry = $("#updateEnquiry").val();
        let message = $("#updateMessage").val();

        if (isConfirm == true) {


            let updatededUserDetail = {
                name: fname,
                email: email,
                phone: phone,
                gender: gender,
                enquiry: enquiry,
                message: message,
            };
            $.ajax({
                url: "https://63f5d9a559c944921f67c027.mockapi.io/data/" + updatedData.id,
                type: "PUT",
                dataType: "json",
                data: updatededUserDetail,
                success: function(res) {

                    location.reload();

                },
                error: function(jqXhr, textStatus, errorMessage) {
                    console.log("Error: " + errorMessage);
                },
            });
        }
        $("#staticBackdrop").trigger("reset");
    }

})


function sortTable(n) {
    var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
    table = document.getElementById("myTable");
    switching = true;
    dir = "asc";
    while (switching) {
        switching = false;
        rows = table.rows;

        for (i = 1; i < (rows.length - 1); i++) {
            shouldSwitch = false;
            x = rows[i].getElementsByTagName("td")[n];
            y = rows[i + 1].getElementsByTagName("td")[n];
            if (dir == "asc") {
                if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                    shouldSwitch = true;
                    break;
                }
            } else if (dir == "desc") {
                if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                    shouldSwitch = true;
                    break;
                }
            }
        }
        if (shouldSwitch) {
            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
            switching = true;
            switchcount++;
        } else {
            if (switchcount == 0 && dir == "asc") {
                dir = "desc";
                switching = true;
            }
        }
    }
}


//pagination

$("#dataPerPage").change(function() {
    pagination()
})

function pagination() {
    var dataPerpageVal = $("#dataPerPage").find(":selected").val();
    console.log(dataPerpageVal);
    console.log("works");
    const url = new URL('https://63f5d9a559c944921f67c027.mockapi.io/data');
    url.searchParams.append('page', 1);
    url.searchParams.append('limit', dataPerpageVal);

    row = dataPerpageVal;

    page = totalrow / row;
    row = parseInt(row);
    var mybutton = `<li class="fw-bold fs-5 " ><a class="text-decoration-none" onclick="chengerow(-1)"> &nbsp Previous</a></li>`;
    for (i = 1; i < page + 1; i++) {
        mybutton += `<li class="fw-bold fs-5"><a class="text-decoration-none" onclick="pagerow(${i},${row})"> &nbsp ${i}</a></li>`;
    }
    mybutton += `<li class="fw-bold fs-5"><a class="text-decoration-none" onclick="chengerow(1)"> &nbsp Next</a></li>`;
    $("#pagination").html(mybutton);
    $.ajax({
        type: 'GET',
        dataType: "json",
        url: url,
        async: false,
        success: function(details) {
            data = details;
            if (details != null && details.length != 0) {
                var dataInSession = "";
                let maleTotal = 0;
                let femaleTotal = 0;
                for (data of details) {
                    dataInSession += `
                <tr id="${data.id}">
                
              
                <td>${data.name}</td>
                <td>${data.email}</td>
                <td>${data.phone}</td>
                <td>${data.gender}</td>
                <td>${data.enquiry}</td>
                <td>${data.message}</td>
                <td> 
                <button onclick="deleteid(${data.id})" class = "link btn btn-dark text-white" ><i class="fa-regular fa-trash"></i></button>
                <button onclick="editid(${data.id})" class = "link btn btn-dark text-white edit" data-bs-toggle="modal" data-bs-target="#staticBackdrop" id="btn-edit" ><i class="fa-regular fa-pen-to-square"></i></button>
                </td>
                </tr>


                `
                    if (data.gender == 'male') {
                        maleTotal++;
                    } else if (data.gender == 'female') {
                        femaleTotal++;
                    };
                }
                $("#tbody").html(dataInSession);
                $("#totalEnquires").html(details.length);
                $("#maleEnquiries").text(maleTotal);
                $("#femaleEnquires").text(femaleTotal);
            }


        }
    })
}

function validate1() {
    let uname = $("#updateName").val();
    let uemail = $("#updateEmail").val();
    let uphone = $("#updatePhone").val();
    let uenquiry = $("#updateEnquiry").val();
    let umessage = $("#updateMessage").val();
    let validatename = /^\w{1,10}(\s\w{1,10})?$/i;
    let validateemail = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/i;
    let validatephone = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/i;

    let warning_text = "";
    let wrong_input = true;
    if (uname == "") {
        warning_text += "*Please enter Name.<br>";
        wrong_input = false;
    } else if ((!validatename.test(uname))) {
        warning_text += "*Please enter Name.<br>";
        wrong_input = false;
    }
    if (uemail == "") {
        warning_text += "*Please enter email.<br>";
        wrong_input = false;
    } else if ((!validateemail.test(uemail))) {
        warning_text += "*Please enter valid email.<br>";
        wrong_input = false;
    }
    if (uphone == "") {
        warning_text += "*Please enter phone number.<br>";
        wrong_input = false;
    } else if ((!validatephone.test(uphone))) {
        warning_text += "*Please enter valid phone number.<br>";
        wrong_input = false;
    }
    if (uenquiry == "") {
        warning_text += "*Please enter enquiry.<br>";
        wrong_input = false;
    }

    if (umessage == "") {
        warning_text += "*Please enter message.<br>";
        wrong_input = false;
    }

    if (wrong_input == false) {
        $("#warning1").html(warning_text);
    }

    return wrong_input;

}

function validate() {

    let name = $("#name").val();
    let email = $("#email").val();
    let phone = $("#phone").val();
    let enquiry = $("#enquiry").val();
    let message = $("#message").val();
    let validatename = /^\w{1,10}(\s\w{1,10})?$/i;
    let validateemail = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/i;
    let validatephone = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/i;



    let warning_text = "";
    let wrong_input = true;

    if (name == "") {
        warning_text += "*Please enter Name.<br>";
        wrong_input = false;
    } else if ((!validatename.test(name))) {
        warning_text += "*Please enter Name.<br>";
        wrong_input = false;
    }
    if (email == "") {
        warning_text += "*Please enter email.<br>";
        wrong_input = false;
    } else if ((!validateemail.test(email))) {
        warning_text += "*Please enter valid email.<br>";
        wrong_input = false;
    }
    if (phone == "") {
        warning_text += "*Please enter phone number.<br>";
        wrong_input = false;
    } else if ((!validatephone.test(phone))) {
        warning_text += "*Please enter valid phone number.<br>";
        wrong_input = false;
    }
    if (enquiry == "") {
        warning_text += "*Please enter enquiry.<br>";
        wrong_input = false;
    }

    if (message == "") {
        warning_text += "*Please enter message.<br>";
        wrong_input = false;
    }

    if (wrong_input == false) {
        $("#warning").html(warning_text);
    }

    return wrong_input;

}




function chengerow(x) {
    page = Math.ceil(page);
    if (currentpage + x > page || currentpage + x < 1) {
        return
    }
    console.log("page ", page);
    console.log("currentpage ", currentpage);
    console.log("page_size ", page_size);
    console.log("page ", page);

    var page_size = $("#dataPerPage").find(":selected").val();
    currentpage = currentpage + x;
    pagerow(currentpage, page_size);

}
//pagination function

function pagerow(page, pagesize) {
    currentpage = page;
    jQuery.ajax({
        url: 'https://63f5d9a559c944921f67c027.mockapi.io/data?' + 'limit=' + pagesize + '&page=' + page,
        type: 'GET',
        async: false,
        success: function(details) {
            data = details;

            if (details != null && details.length != 0) {
                var dataInSession = "";
                let maleTotal = 0;
                let femaleTotal = 0;
                for (data of details) {
                    dataInSession += `
                <tr id="${data.id}">
                
              
                <td>${data.name}</td>
                <td>${data.email}</td>
                <td>${data.phone}</td>
                <td>${data.gender}</td>
                <td>${data.enquiry}</td>
                <td>${data.message}</td>
                <td> 
                <button onclick="deleteid(${data.id})" class = "link btn btn-dark text-white" ><i class="fa-regular fa-trash"></i></button>
                <button onclick="editid(${data.id})" class = "link btn btn-dark text-white edit" data-bs-toggle="modal" data-bs-target="#staticBackdrop" id="btn-edit" ><i class="fa-regular fa-pen-to-square"></i></button>
                </td>
                </tr>


                `
                    if (data.gender == 'male') {
                        maleTotal++;
                    } else if (data.gender == 'female') {
                        femaleTotal++;
                    };
                }
                $("#tbody").html(dataInSession);
                $("#totalEnquires").html(details.length);
                $("#maleEnquiries").text(maleTotal);
                $("#femaleEnquires").text(femaleTotal);
            }
        },
        error: function(jqXHR, textStatus, errorThrown) {
            console.log(textStatus + "::" + errorThrown);
        }
    });
}
$("#myTable").click(function() {
    $("#tr th i").toggleClass(" fa-solid fa-arrow-up-a-z fa-solid fa-arrow-up-z-a")
});


function getData1() {
    const url = new URL('https://63f5d9a559c944921f67c027.mockapi.io/data');
    url.searchParams.append('page', 1);
    url.searchParams.append('limit', 1000);
    $.ajax({
        type: 'GET',
        dataType: "json",
        url,
        async: false,

        beforeSend: function() {
            $("#trLoader").show();
        },
        success: function(details) {
            $("#trLoader").remove();
            data = details;
            if (details != null && details.length != 0) {
                var dataInSession = "";
                let maleTotal = 0;
                let femaleTotal = 0;
                for (data of details) {
                    dataInSession += `
                    <tr id="${data.id}">
                    
                  
                    <td>${data.name}</td>
                    <td>${data.email}</td>
                    <td>${data.phone}</td>
                    <td>${data.gender}</td>
                    <td>${data.enquiry}</td>
                    <td>${data.message}</td>
                    <td> 
                    <button onclick="deleteid(${data.id})" class = "link btn btn-dark text-white" ><i class="fa-regular fa-trash"></i></button>
                    <button onclick="editid(${data.id})" class = "link btn btn-dark text-white edit" data-bs-toggle="modal" data-bs-target="#staticBackdrop" id="btn-edit" ><i class="fa-regular fa-pen-to-square"></i></button>
                    </td>
                    </tr>


                    `
                    if (data.gender == 'male') {
                        maleTotal++;
                    } else if (data.gender == 'female') {
                        femaleTotal++;
                    };
                    totalrow = details.length;


                }
                $("#totalData").html(details.length);
            }


        }
    })
}