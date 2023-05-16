var jwt = localStorage.getItem("jwt");
if (jwt != null) {
  window.location.href = './index.html'
} 

const objects = {
  "messageOk": 'Registeration Success!',
  "messageNo": 'Registeration Failed!',
  "messageEmptyString": 'You must fill the blanks!' 
}

function register() {
  const username = document.getElementById("username").value;
  const password = document.getElementById("password").value;
  const firstname = document.getElementById("firstname").value;
  const lastname = document.getElementById("lastname").value;
  let isStrEmpty = true;
  if(!username || !password || !lastname || !firstname) {
    swalFire(objects['messageEmptyString'])
    isStrEmpty = false;
  }
  const input = {
    "email": username,
    "password": password,
    "firstname": firstname,
    "lastname": lastname
  }
  const jsonVal = JSON.stringify(input);
  
  if(isStrEmpty) {
  const req = new Request('http://localhost:8080/api/v1/auth/register', {
      method: 'POST',
      mode: 'cors',
      headers: {
          'Content-Type': 'application/json',
          'Accept': 'application/json',
      },
      body: jsonVal
  }) 

  fetch(req).then(response => {
    response.json().then((data) => {
        //console.log(data["token"])
        localStorage.setItem("jwt", data["token"])
    });
    if (response['status'] == 200) {
      Swal.fire({
        text: objects['messageOk'],
        icon: 'success',
        confirmButtonText: 'OK'
      }).then((result) => {
      if (result.isConfirmed) {
            window.location.href = './index.html';
          }
      });
      } else {
        swalFire(objects['messageNo'])
      }
    }).catch(err => {
        console.log(err)  
    })
  }
  return false;
}


function swalFire(message) {
    Swal.fire({
      text: message,
      icon: 'error',
      confirmButtonText: 'OK'
    });
}


