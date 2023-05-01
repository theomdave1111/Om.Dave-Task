$(document).ready(function() {

    showInTable();
    $("#p").hide();

});
old_id = -1;

function savedata() {
    let x = validate();
    if (!x) {
        return;
    }
    $("#warning").html("");

    var name = $("#name").val();
    var email = $("#email").val();
    var phone_no = $("#phone_no").val();
    var age = $("#age").val();
    var city = $("#city").val();


    var data = {
        Name: name,
        Email: email,
        Phone_no: phone_no,
        Age: age,
        City: city,
        id: 1,

    }

    //data = JSON.stringify(data);
    if (old_id != -1) {

        data.id = old_id;
        console.log(data.id, old_id);
        data = JSON.stringify(data);
        jQuery.ajax({
            url: ('https://63f5a03a55677ef68bd0f70d.mockapi.io/data/' + old_id),
            type: 'PUT',
            async: false,
            contentType: "application/json",
            data: data,
            success: function(data) {

                showInTable();
                old_id = -1;
            },
            error: function(jqXHR, textStatus, errorThrown) {
                console.log(textStatus + "::" + errorThrown);
            }
        });
    } else {
        data = JSON.stringify(data);
        jQuery.ajax({
            url: 'https://63f5a03a55677ef68bd0f70d.mockapi.io/data',
            type: 'POST',
            async: false,
            contentType: "application/json",
            data: data,
            success: function(data) {
                showInTable();
            },
            error: function(jqXHR, textStatus, errorThrown) {
                console.log(textStatus + "::" + errorThrown);
            }
        });
    }
    $("input").val("");
    $("#p").hide();
};


function showInTable() {
    jQuery.ajax({
        url: 'https://63f5a03a55677ef68bd0f70d.mockapi.io/data',
        type: 'GET',
        async: false,
        success: function(myform) {

            if (myform == null) {
                $("#warning").html("empty");
            }
            var dataInSession = "";
            for (data of myform) {
                dataInSession +=
                    `
                    <tr id="my_id_${data.id}">
                        <td id="id"> ${data.id}</td>
                        <td id= "name"> ${data.Name}</td>
                        <td id="email"> ${data.Email}</td>
                        <td id="phoneno"> ${data.Phone_no}</td>
                        <td id="age"> ${data.Age}</td>
                        <td id="city"> ${data.City}</td>
                        <td> 
                            <a href="index.html" id="delete-btn" type="button" onclick="deletedata(${data.id}) " class="btn btn-sm btn-danger"
                            data-bs-toggle="modal" data-bs-target="#myModal">Delete</a>
                            <a href="index.html" id="btn-edit" type="button" onclick="updatedata(${data.id}) " class="btn btn-sm btn-danger"
                            data-bs-toggle="modal" data-bs-target="#myModal">Edit</a>
                        </td>
                    </tr>
                `;
                console.log(data.id);
            }
            $("#formdata").html(dataInSession);

            check();
        },
        error: function(jqXHR, textStatus, errorThrown) {
            console.log(textStatus + "::" + errorThrown);
        }
    });

}



function deletedata(id) {
    var notification = confirm("Do you want to delete ?");
    if (notification == true) {


        jQuery.ajax({
            url: "https://63f5a03a55677ef68bd0f70d.mockapi.io/data/" + id,
            type: 'DELETE',
            async: false,
            success: function(myform) {
                if (myform == null) {
                    $("#warning").html("empty");
                }

                showInTable();
            },
            error: function(jqXHR, textStatus, errorThrown) {
                console.log(textStatus + "::" + errorThrown);
            }
        });
    } else {
        alert("thank you!");
    }
    $("input").val("");

}

function updatedata(id) {
    $("#warning").html("");
    var notification = confirm("Do you want to edit ?");
    if (notification == true) {

        jQuery.ajax({
            url: "https://63f5a03a55677ef68bd0f70d.mockapi.io/data/" + id,
            type: 'GET',
            async: false,
            success: function(data) {
                if (data == null) {
                    $("#warning").html("empty");
                }

                $("#name").val(data.Name);
                $("#email").val(data.Email);
                $("#phone_no").val(data.Phone_no);
                $("#age").val(data.Age);
                $("#city").val(data.City);

                console.log(id);
                old_id = id;
            },
            error: function(jqXHR, textStatus, errorThrown) {
                console.log(textStatus + "::" + errorThrown);
            }
        });
    }

}

function validate() {

    var name_v = $("#name").val();
    var email_v = $("#email").val();
    var phone_v = $("#phone_no").val();
    var age_v = $("#age").val();
    var city_v = $("#city").val();

    let warning_text = "";
    let wrong_input = true;



    let name = /^\w{1,10}(\s\w{1,10})?$/i;
    let email = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/i;
    let phone_no = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/i;
    let age = /^\d{1,2}$/i;
    let city = /^\w{3,15}(\s\w{3,10})?$/i;
    if (name_v == "") {
        warning_text += "Please enter Name.<br>";
        wrong_input = false;
    } else if ((!name.test(name_v))) {
        warning_text += " *Enter valid name : No special char, No digit<br> ";
        warning_text += "Name : no special char , no digit , length = (3 , 20)<br>";
        wrong_input = false;
    }
    if (email_v == "") {
        warning_text += "Please enter email.<br>";
        wrong_input = false;
    } else if ((!email.test(email_v))) {
        warning_text += "* Enter a proper email !<br>";
        wrong_input = false;
    }
    if (phone_v == "") {
        warning_text += "Please enter phone no.<br>";
        wrong_input = false;

    } else if ((!phone_no.test(phone_v))) {
        warning_text += " * Enter 10 digit number !<br>";
        wrong_input = false;
    }
    if (age_v == "") {
        warning_text += "Please enter Age.<br>";
        wrong_input = false;
    } else if ((!age.test(age_v))) {
        warning_text += "Invalid age(1 to 99)!<br>";
        wrong_input = false;
    }
    if (city_v == "") {
        warning_text += "Please enter city.<br>";
        wrong_input = false;
    } else if ((!city.test(city_v))) {
        warning_text += "* Enter valid City : no special char , no digit , length = (3 , 20)<br>";
        wrong_input = false;
    }

    if (wrong_input == false) {
        $("#warning").html(warning_text);
    }

    return wrong_input;

};

function check() {
    if (data.length == 0) {
        $("#p").show();
    }

}