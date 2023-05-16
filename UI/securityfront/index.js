function logout() {
  localStorage.removeItem("jwt");
  window.location.href = "./login.html";
}
var jwt = localStorage.getItem("jwt");

if (jwt == null) {
  window.location.href = "./login.html";
} 

function loadUser() {
  /*const req = new Request('http://localhost:8080/api/v1/demo-controller', {
      method: 'GET',
      mode: 'no-cors',
      headers: {
          'Content-Type': 'application/json',
          'Accept': 'application/json',
          'Authorization': 'Bearer ' + jwt
      }
  }) 
  fetch(req).then(response => {
    if(response['status'] === 200) {
      response.json().then((data) => */
      document.getElementById("fname").innerHTML = localStorage.getItem("useremail");
     /* );
    }else {
      console.log(response['status'])
    }

  }); */
}

loadUser();