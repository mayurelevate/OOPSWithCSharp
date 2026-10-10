/// <reference path="jquery-3.4.1.min.js" />

function getAccessToken() {
    if (location.hash) {
        if (location.hash.split("access_token=")) {
            var accessToken = location.hash.split("access_token=")[1].split("&")[0];

            if (accessToken) {
                isUserRegistered(accessToken);
            }
        }
    }
}


function isUserRegistered(accessToken) {
    if (accessToken != null || accessToken != "" || accessToken != undefined) {
        $.ajax({
            url: "/api/Account/UserInfo",
            type: "Get",
            headers: {
                'content-type': 'application/json',
                'Authorization': 'Bearer ' + accessToken
            },
            success: function (response) {
                if (response.HasRegistered) {
                    sessionStorage.setItem("accessToken", accessToken);
                    sessionStorage.setItem("userName", response.Email);
                    window.location.href = "Data.html";
                }
                else {
                    signUpExternalUser(accessToken);
                }
            },
            error: function (jqXHR) {

            }
        });
    }
    else {
        alert("Something went wrong.Please try again.");
    }
}


function signUpExternalUser(accessToken) {

    if (accessToken != null || accessToken != "" || accessToken != undefined) {
        $.ajax({
            url: "/api/Account/RegisterExternal",
            type: "Post",
            headers: {
                'content-type': 'application/json',
                'Authorization': 'Bearer ' + accessToken
            },
            success: function () {
                window.location.href = "/api/Account/ExternalLogin?provider=Google&response_type=token&client_id=self&redirect_uri=https%3A%2F%2Flocalhost%3A44308%2FLogin.html&state=NZ1-9J-o86sPpqnseQVAkqED9zzwJ09yebLMAtOMOmY1";
            },
            error: function (jqXHR) {

            }
        });
    }
    else
    {
        alert("Something went wrong.Please try again.");
    }
}