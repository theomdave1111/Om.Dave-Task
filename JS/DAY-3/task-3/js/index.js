function database() {
    var link = "https://63f5d9a559c944921f67c027.mockapi.io/Datas";
    var request = new XMLHttpRequest()
    request.open('GET', link)

    request.onload = function() {
        var users = JSON.parse(request.responseText);

        if (request.readyState == 4 && request.status == "200") {
            console.log(users);
            for (var i = 0; i < users.length; i++) {

                const user = users[i];
                const tbody = document.getElementById("table").getElementsByTagName("tbody")[0];

                const row = tbody.insertRow(i);

                row.insertCell(0).innerHTML = user.id;
                row.insertCell(1).innerHTML = user.Firstname;
                row.insertCell(2).innerHTML = user.Lastname;
                row.insertCell(3).innerHTML = user.Email;
                row.insertCell(4).innerHTML = user.Address;
            }


        } else {
            console.error(users);
        }
    }
    request.send(null);
}